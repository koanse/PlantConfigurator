using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.Serialization;

namespace PlantConfig
{
    public partial class MainForm : Form
    {
        decimal plantId;
        BindingSource bsCurrent;
        OracleConnection connection;

        public MainForm(OracleConnection conn)
        {
            InitializeComponent();
            taPlant.Connection = taRepZone.Connection =
                taController.Connection = taContPoint.Connection =
                taTerminal.Connection = taScaner.Connection =
                taLocker.Connection = taSensor.Connection = conn;
            bsCurrent = bsRepZone;
            connection = conn;
            dsMain.RepairZone.RowChanged += new DataRowChangeEventHandler(table_RowChanged);
            dsMain.ControlPoint.RowChanged += new DataRowChangeEventHandler(table_RowChanged);
            dsMain.Controller.RowChanged += new DataRowChangeEventHandler(table_RowChanged);
            dsMain.Terminal.RowChanged += new DataRowChangeEventHandler(table_RowChanged);
            dsMain.Scaner.RowChanged += new DataRowChangeEventHandler(table_RowChanged);
            dsMain.Locker.RowChanged += new DataRowChangeEventHandler(table_RowChanged);
            dsMain.Sensor.RowChanged += new DataRowChangeEventHandler(table_RowChanged);
            dsMain.RepairZone.RowDeleted += new DataRowChangeEventHandler(table_RowChanged);
            dsMain.ControlPoint.RowDeleted += new DataRowChangeEventHandler(table_RowChanged);
            dsMain.Controller.RowDeleted += new DataRowChangeEventHandler(table_RowChanged);
            dsMain.Terminal.RowDeleted += new DataRowChangeEventHandler(table_RowChanged);
            dsMain.Scaner.RowDeleted += new DataRowChangeEventHandler(table_RowChanged);
            dsMain.Locker.RowDeleted += new DataRowChangeEventHandler(table_RowChanged);
            dsMain.Sensor.RowDeleted += new DataRowChangeEventHandler(table_RowChanged);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
                {
                    dsMain.DeviceType.AddDeviceTypeRow(1, "Входной");
                    dsMain.DeviceType.AddDeviceTypeRow(2, "Выходной");
                    dsMain.DeviceType.AddDeviceTypeRow(3, "Входной/Выходной");
                    dsMain.TermModes.AddTermModesRow(1, "Дефекты");
                    dsMain.TermModes.AddTermModesRow(2, "Ремонты");
                    dsMain.TermModes.AddTermModesRow(3, "Дефекты/Ремонты");
                }
                else
                {
                    dsMain.DeviceType.AddDeviceTypeRow(1, "In");
                    dsMain.DeviceType.AddDeviceTypeRow(2, "Out");
                    dsMain.DeviceType.AddDeviceTypeRow(3, "In/Out");
                    dsMain.TermModes.AddTermModesRow(1, "Deffects");
                    dsMain.TermModes.AddTermModesRow(2, "Repairs");
                    dsMain.TermModes.AddTermModesRow(3, "Deffects/Repairs");
                }
                dsMain.AcceptChanges();
                FillDataSet();
                allowVisualEditToolStripMenuItem.Checked =
                    pictureBoxGlyphs1.IsEditable =
                    Properties.Settings.Default.AllowEdit;
                showNamesToolStripMenuItem.Checked =
                    pictureBoxGlyphs1.IsNameVisible =
                    Properties.Settings.Default.ShowDevicesNames;
                showStatusesToolStripMenuItem.Checked =
                    pictureBoxGlyphs1.IsStatusVisible =
                    Properties.Settings.Default.ShowDevicesStatuses;
                showRelationsToolStripMenuItem.Checked =
                    pictureBoxGlyphs1.IsRelationVisible =
                    Properties.Settings.Default.ShowDevicesRelations;
                SetPlantId((dsMain.Plant.Rows[0] as ReworksDataSet.PlantRow).PlantId);
                rewTreeView1.LoadNodes();
                pictureBoxGlyphs1.RefreshBmp();
                pictureBoxGlyphs1.Refresh();
            }
            catch
            {
                HandleError(ErrorType.ProgLoadError);
            }
        }
        private void pictureBoxGlyphs1_GlyphClicked(object sender, GlyphEventArgs e)
        {
            try
            {
                if (e.mouseEvArg.Button == MouseButtons.Right)
                {
                    if (e.selGlyph.status == GlyphStatus.On)
                        e.selGlyph.status = GlyphStatus.Off;
                    else e.selGlyph.status = GlyphStatus.On;
                    (sender as PictureBoxGlyphs).RefreshBmp();
                }
                RewObjectType type = RewObjectType.Plant;
                switch (e.selGlyph.type)
                {
                    case GlyphType.RepZone:
                        type = RewObjectType.RepairZone;
                        break;
                    case GlyphType.Controller:
                        type = RewObjectType.Controller;
                        break;
                    case GlyphType.Terminal:
                        type = RewObjectType.Terminal;
                        break;
                    case GlyphType.Scaner:
                        type = RewObjectType.Scaner;
                        break;
                }
                ShowRewObjectInfo(e.selGlyph.id, type);
                pictureBoxGlyphs1.Select();
            }
            catch
            {
            }
        }
        private void rewTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                RewTreeNode selNode = e.Node as RewTreeNode;
                RewTreeNode node = selNode;
                while (node.Parent != null)
                    node = node.Parent as RewTreeNode;
                if (node.id != plantId)
                    SetPlantId(node.id);
                ArrayList glyphs = pictureBoxGlyphs1.Glyphs;
                GlyphType gtNode = GlyphType.RepZone;
                bool isGtValid = true;
                switch (selNode.type)
                {
                    case RewObjectType.RepairZone:
                        gtNode = GlyphType.RepZone;
                        break;
                    case RewObjectType.Controller:
                        gtNode = GlyphType.Controller;
                        break;
                    case RewObjectType.Terminal:
                        gtNode = GlyphType.Terminal;
                        break;
                    case RewObjectType.Scaner:
                        gtNode = GlyphType.Scaner;
                        break;
                    default:
                        isGtValid = false;
                        break;
                }
                if (glyphs != null)
                {
                    foreach (Glyph g in glyphs)
                    {
                        if (isGtValid && g.type == gtNode
                            && g.id == selNode.id)
                        {
                            g.isSelected = true;
                            //g.status = GlyphStatus.Off;
                        }
                        else
                        {
                            g.isSelected = false;
                            //g.status = GlyphStatus.On;
                        }
                    }
                    pictureBoxGlyphs1.RefreshBmp();
                }
                ShowRewObjectInfo(selNode.id, selNode.type);
            }
            catch
            {
            }
        }
        void table_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            try
            {
                LoadGlyphs();
                rewTreeView1.LoadNodes();
            }
            catch
            {
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bsCurrent.EndEdit();
            }
            catch
            {
                bsCurrent.CancelEdit();
            }
            switch (tabControl1.SelectedTab.Name)
            {
                case "tabPageRz":
                    bsCurrent = bsRepZone;
                    break;
                case "tabPageCp":
                    bsCurrent = bsContPoint;
                    break;
                case "tabPageCont":
                    bsCurrent = bsController;
                    break;
                case "tabPageTerm":
                    bsCurrent = bsTerminal;
                    break;
                case "tabPageScan":
                    bsCurrent = bsScaner;
                    break;
                case "tabPageLock":
                    bsCurrent = bsLocker;
                    break;
                case "tabPageSens":
                    bsCurrent = bsSensor;
                    break;
            }
            if (bsCurrent.Count == 0)
                bsCurrent.AddNew();
        }
        private void tabControl1_SizeChanged(object sender, EventArgs e)
        {
            tabControl1.Invalidate();
        }

        private void openPlantBitmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ArrayList plIds = Properties.Settings.Default.PlantIds;
                    ArrayList plFiles = Properties.Settings.Default.PlantBmpFileNames;
                    if (plIds == null)
                    {
                        plIds = new ArrayList();
                        plFiles = new ArrayList();
                    }
                    string fileName = openFileDialog1.FileName;
                    for (int i = 0; i < plIds.Count; i++)
                        if ((decimal)plIds[i] == plantId)
                        {
                            plIds.RemoveAt(i);
                            plFiles.RemoveAt(i);
                            break;
                        }
                    plIds.Add(plantId);
                    plFiles.Add(fileName);
                    Properties.Settings.Default.PlantIds = plIds;
                    Properties.Settings.Default.PlantBmpFileNames = plFiles;
                    pictureBoxGlyphs1.PlantBmp =
                        (Bitmap)Bitmap.FromFile(fileName);
                }
            }
            catch
            {
                HandleError(ErrorType.BitmapLoadError);
            }
        }
        private void allowVisualEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (allowVisualEditToolStripMenuItem.Checked)
            {
                allowVisualEditToolStripMenuItem.Checked = false;
                Properties.Settings.Default.AllowEdit = false;
                pictureBoxGlyphs1.IsEditable = false;
            }
            else
            {
                allowVisualEditToolStripMenuItem.Checked = true;
                Properties.Settings.Default.AllowEdit = true;
                pictureBoxGlyphs1.IsEditable = true;
            }
        }
        private void showNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showNamesToolStripMenuItem.Checked)
            {
                showNamesToolStripMenuItem.Checked = false;
                Properties.Settings.Default.ShowDevicesNames = false;
                pictureBoxGlyphs1.IsNameVisible = false;
            }
            else
            {
                showNamesToolStripMenuItem.Checked = true;
                Properties.Settings.Default.ShowDevicesNames = true;
                pictureBoxGlyphs1.IsNameVisible = true;
            }
        }
        private void showStatusesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showStatusesToolStripMenuItem.Checked)
            {
                showStatusesToolStripMenuItem.Checked = false;
                Properties.Settings.Default.ShowDevicesStatuses = false;
                pictureBoxGlyphs1.IsStatusVisible = false;
            }
            else
            {
                showStatusesToolStripMenuItem.Checked = true;
                Properties.Settings.Default.ShowDevicesStatuses = true;
                pictureBoxGlyphs1.IsStatusVisible = true;
            }
        }
        private void showRelationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showRelationsToolStripMenuItem.Checked)
            {
                showRelationsToolStripMenuItem.Checked = false;
                Properties.Settings.Default.ShowDevicesRelations = false;
                pictureBoxGlyphs1.IsRelationVisible = false;
            }
            else
            {
                showRelationsToolStripMenuItem.Checked = true;
                Properties.Settings.Default.ShowDevicesRelations = true;
                pictureBoxGlyphs1.IsRelationVisible = true;
            }
        }
        private void applyChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bsCurrent.EndEdit();
            }
            catch
            {
                HandleError(ErrorType.IllegalDataError);
                return;
            }
            try
            {
                UpdateDb();
            }
            catch
            {
                HandleError(ErrorType.AppChangesError);
            }
        }
        private void rejectChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bsCurrent.CancelEdit();
            }
            catch
            {
                HandleError(ErrorType.IllegalDataError);
            }
            try
            {
                dsMain.RejectChanges();
            }
            catch
            {
                HandleError(ErrorType.RejChangesError);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bsCurrent.AddNew();
            }
            catch
            {
                HandleError(ErrorType.IllegalDataError);
            }
        }
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                bsCurrent.EndEdit();
            }
            catch
            {
                HandleError(ErrorType.IllegalDataError);
            }
        }
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bsCurrent.RemoveCurrent();
            }
            catch
            {
                HandleError(ErrorType.IllegalDataError);
            }
            if (bsCurrent.Count == 0)
                bsCurrent.AddNew();
        }       
        
        private void SetPlantId(decimal id)
        {
            plantId = id;
            dsMain.RepairZone.PlantIdColumn.DefaultValue = plantId;
            dsMain.Controller.PlantIdColumn.DefaultValue = plantId;
            SetPlantBitmap();
            LoadGlyphs();
            SetBsFilters();
        }
        private void SetPlantBitmap()
        {
            try
            {
                ArrayList plIds = Properties.Settings.Default.PlantIds;
                ArrayList plFiles = Properties.Settings.Default.PlantBmpFileNames;
                if (plIds != null)
                    for (int i = 0; i < plIds.Count; i++)
                        if ((decimal)plIds[i] == plantId)
                        {
                            pictureBoxGlyphs1.PlantBmp =
                                (Bitmap)Bitmap.FromFile(plFiles[i] as string);
                            return;
                        }
            }
            catch
            {
                HandleError(ErrorType.BitmapLoadError);
            }
            Bitmap bmp = new Bitmap(200, 200);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBoxGlyphs1.PlantBmp = bmp;
        }
        private void SetBsFilters()
        {
            string strPlantId = plantId.ToString();
            bsRepZone.Filter = bsRepZonesListContPoint.Filter =
                bsRepZonesListTerm.Filter = "PlantId = " + strPlantId;
            bsContPoint.Filter = bsContPointsListScan.Filter =
                bsContPointsListLoc.Filter = bsContPointsListSens.Filter =
                "Parent.PlantId = " + strPlantId;
            bsController.Filter = bsControllersListScan.Filter =
                bsControllersListLock.Filter = bsControllersListSens.Filter =
                "PlantId = " + strPlantId;
            bsTerminal.Filter = "Parent.PlantId = " + strPlantId;
            bsScaner.Filter = "Parent(ContScan).PlantId = " + strPlantId;
            bsLocker.Filter = "Parent(ContLock).PlantId = " + strPlantId;
            bsSensor.Filter = "Parent(ContSens).PlantId = " + strPlantId;
        }
        private void LoadGlyphs()
        {
            GlyphsLoader gl = new GlyphsLoader(dsMain);
            ArrayList oldGlyphs = pictureBoxGlyphs1.Glyphs;
            ArrayList newGlyphs = gl.LoadItems(plantId);
            if (oldGlyphs != null)
                foreach (Glyph newGlyph in newGlyphs)
                    for (int i = 0; i < oldGlyphs.Count; i++)
                    {
                        Glyph oldGlyph = oldGlyphs[i] as Glyph;
                        if (newGlyph.type == oldGlyph.type &&
                            newGlyph.id == oldGlyph.id)
                        {
                            newGlyph.isSelected = oldGlyph.isSelected;
                            newGlyph.status = oldGlyph.status;
                            oldGlyphs.RemoveAt(i);
                            break;
                        }
                    }
            pictureBoxGlyphs1.Glyphs = newGlyphs;
        }
        private void FillDataSet()
        {
            taPlant.Fill(dsMain.Plant);
            taRepZone.Fill(dsMain.RepairZone);
            taController.Fill(dsMain.Controller);
            taContPoint.Fill(dsMain.ControlPoint);
            taTerminal.Fill(dsMain.Terminal);
            taScaner.Fill(dsMain.Scaner);
            taLocker.Fill(dsMain.Locker);
            taSensor.Fill(dsMain.Sensor);
        }
        private void UpdateDb()
        {
            /*try
            {
                taSensor.Update(dsMain.Sensor);
                taLocker.Update(dsMain.Locker);
                taScaner.Update(dsMain.Scaner);
                taTerminal.Update(dsMain.Terminal);
                taContPoint.Update(dsMain.ControlPoint);
                taController.Update(dsMain.Controller);
                taRepZone.Update(dsMain.RepairZone);
            }
            catch { }*/
            int i = 10;
            while (dsMain.HasChanges() && i > 0)
            {
                try
                {
                    taRepZone.Update(dsMain.RepairZone);
                }
                catch { }
                try
                {
                    taController.Update(dsMain.Controller);
                }
                catch { }
                try
                {
                    taContPoint.Update(dsMain.ControlPoint);
                }
                catch { }
                try
                {
                    taTerminal.Update(dsMain.Terminal);
                }
                catch { }
                try
                {
                    taScaner.Update(dsMain.Scaner);
                }
                catch { }
                try
                {
                    taLocker.Update(dsMain.Locker);
                }
                catch { }
                try
                {
                    taSensor.Update(dsMain.Sensor);
                }
                catch { }
            }
            if (dsMain.HasChanges())
                throw new Exception();
        }
        private void ShowRewObjectInfo(decimal id, RewObjectType type)
        {
            string selPageName = "";
            int index = -1;
            try
            {
                bsCurrent.EndEdit();
            }
            catch
            {
            }
            switch (type)
            {
                case RewObjectType.Plant:
                    return;
                case RewObjectType.RepairZone:
                    index = bsRepZone.Find("RepZoneId", id);
                    bsCurrent = bsRepZone;
                    selPageName = "tabPageRz";
                    break;
                case RewObjectType.ControlPoint:
                    index = bsContPoint.Find("ContPointId", id);
                    bsCurrent = bsContPoint;
                    selPageName = "tabPageCp";
                    break;
                case RewObjectType.Controller:
                    index = bsController.Find("ContId", id);
                    bsCurrent = bsController;
                    selPageName = "tabPageCont";
                    break;
                case RewObjectType.Terminal:
                    index = bsTerminal.Find("TermId", id);
                    bsCurrent = bsTerminal;
                    selPageName = "tabPageTerm";
                    break;
                case RewObjectType.Scaner:
                    index = bsScaner.Find("ScanId", id);
                    bsCurrent = bsScaner;
                    selPageName = "tabPageScan";
                    break;
                case RewObjectType.Locker:
                    index = bsLocker.Find("LocId", id);
                    bsCurrent = bsLocker;
                    selPageName = "tabPageLock";
                    break;
                case RewObjectType.Sensor:
                    index = bsSensor.Find("SensId", id);
                    bsCurrent = bsSensor;
                    selPageName = "tabPageSens";
                    break;
            }
            try
            {
                if (index >= 0)
                    bsCurrent.Position = index;
            }
            catch
            {
                HandleError(ErrorType.IllegalDataError);
            }
            tabControl1.SelectedTab =
                tabControl1.TabPages[selPageName];
        }
        private DialogResult QuestionSaveChanges()
        {
            if (dsMain.HasChanges())
            {
                DialogResult res;
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
                    res = MessageBox.Show("Внесены изменения, сохранить?",
                        "Выход", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                else res = MessageBox.Show("Do you want to save changes?",
                        "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                    try
                    {
                        UpdateDb();
                    }
                    catch
                    {
                        HandleError(ErrorType.DatabaseError);
                    }
                return res;
            }
            return DialogResult.OK;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (QuestionSaveChanges() == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
            Properties.Settings.Default.Save();
            connection.Close();
        }
        private void HandleError(ErrorType type)
        {
            string caption = "", text = "";
            switch (type)
            {
                case ErrorType.IllegalDataError:
                    bsCurrent.CancelEdit();
                    if (bsCurrent.Count == 0)
                        bsCurrent.AddNew();
                    return;
            }
            if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "ru")
            {
                switch (type)
                {
                    case ErrorType.ProgLoadError:
                        caption = "Ошибка загрузки";
                        text = "Ошибка при загрузке программы";
                        break;
                    case ErrorType.IllegalDataError:
                        caption = "Ошибка ввода";
                        text = "Некорректные данные";
                        break;
                    case ErrorType.DatabaseError:
                        caption = "Ошибка базы данных";
                        text = "Ошибка при взаимодействии с базой данных";
                        break;
                    case ErrorType.AppChangesError:
                        caption = "Ошибка применения изменений";
                        text = "Невозможно применить изменения";
                        break;
                    case ErrorType.RejChangesError:
                        caption = "Ошибка отмены изменений";
                        text = "Невозможно отменить изменения";
                        break;
                    case ErrorType.BitmapLoadError:
                        caption = "Ошибка загрузки изображения";
                        text = "Невозможно загрузить изображение";
                        break;
                }
            }
            else
            {
                switch (type)
                {
                    case ErrorType.ProgLoadError:
                        caption = "Load error";
                        text = "Cannot load program";
                        break;
                    case ErrorType.IllegalDataError:
                        caption = "Input error";
                        text = "Illegal data";
                        break;
                    case ErrorType.DatabaseError:
                        caption = "Database error";
                        text = "Cannot connect to database";
                        break;
                    case ErrorType.AppChangesError:
                        caption = "Input error";
                        text = "Cannot apply changes";
                        break;
                    case ErrorType.RejChangesError:
                        caption = "Input error";
                        text = "Cannot reject changes";
                        break;
                    case ErrorType.BitmapLoadError:
                        caption = "Load error";
                        text = "Cannot load bitmap";
                        break;
                }
            }                
            MessageBox.Show(text, caption, MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }
    }
    public delegate void GlyphClickedEventHandler(object sender, GlyphEventArgs e);
    public class GlyphEventArgs : EventArgs
    {
        public GlyphPointType glPointType;
        public Glyph selGlyph;
        public MouseEventArgs mouseEvArg;
        public GlyphEventArgs(GlyphPointType glPointType, Glyph selGlyph,
            MouseEventArgs mouseEvArg)
        {
            this.glPointType = glPointType;
            this.selGlyph = selGlyph;
            this.mouseEvArg = mouseEvArg;
        }
    }
    public class PictureBoxGlyphs : PictureBox
    {
        Bitmap plantBmp;
        ArrayList glyphs;
        bool isEditable, isStatusVisible, isNameVisible, isRelationVisible;
        bool isGlyphMoved;
        GlyphPointType glPointType;
        Glyph selGlyph;
        Point oldPos;
        Bitmap tempBmp;
        DataSet ds;

        public Bitmap PlantBmp
        {
            set
            {
                plantBmp = value;
                tempBmp = new Bitmap(plantBmp);
                Image = new Bitmap(plantBmp);

                if (glyphs != null)
                {
                    MakeImage();
                    Invalidate();
                }
            }
            get
            {
                return plantBmp;
            }
        }
        public ArrayList Glyphs
        {
            set
            {
                glyphs = value;
                if (plantBmp != null)
                {
                    MakeImage();
                    Invalidate();
                }
            }
            get
            {
                return glyphs;
            }
        }
        public bool IsEditable
        {
            set
            {
                isEditable = value;
                if (plantBmp != null && glyphs != null)
                {
                    MakeImage();
                    Invalidate();
                }
            }
            get
            {
                return isEditable;
            }
        }
        public bool IsStatusVisible
        {
            set
            {
                isStatusVisible = value;
                if (plantBmp != null && glyphs != null)
                {
                    MakeImage();
                    Invalidate();
                }
            }
            get
            {
                return isStatusVisible;
            }
        }
        public bool IsNameVisible
        {
            set
            {
                isNameVisible = value;
                if (plantBmp != null && glyphs != null)
                {
                    MakeImage();
                    Invalidate();
                }
            }
            get
            {
                return isNameVisible;
            }
        }
        public bool IsRelationVisible
        {
            set
            {
                isRelationVisible = value;
                if (plantBmp != null && glyphs != null)
                {
                    MakeImage();
                    Invalidate();
                }
            }
            get
            {
                return isRelationVisible;
            }
        }
        public DataSet DataSet
        {
            set
            {
                ds = value;
            }
            get
            {
                return ds;
            }
        }
        public event GlyphClickedEventHandler GlyphClicked;
        public PictureBoxGlyphs()
        {
            Bitmap b = new Bitmap(200, 200);
            Graphics gr = Graphics.FromImage(b);
            gr.Clear(Color.White);
            this.plantBmp = b;
            this.glyphs = new ArrayList();
            this.isEditable = true;
            this.isStatusVisible = true;
            this.isNameVisible = true;
            this.isRelationVisible = false;
            this.isGlyphMoved = false;
            this.glPointType = GlyphPointType.None;
            this.oldPos = new Point(0, 0);
            this.Image = new Bitmap(b);
            this.tempBmp = new Bitmap(b);
            this.SizeMode = PictureBoxSizeMode.CenterImage;
            Invalidate();
        }
        public void RefreshBmp()
        {
            MakeImage();
            Invalidate();
        }
        private Point PicBoxCoordToBmpCoord(int x, int y)
        {
            int xTran = 0, yTran = 0;
            xTran = (this.ClientSize.Width - this.PreferredSize.Width) / 2;
            yTran = (this.ClientSize.Height - this.PreferredSize.Height) / 2;
            Point p = new Point(x - xTran, y - yTran);
            if (p.X < 0) p.X = 0;
            if (p.X >= this.PreferredSize.Width)
                p.X = this.PreferredSize.Width - 1;
            if (p.Y < 0) p.Y = 0;
            if (p.Y >= this.PreferredSize.Height)
                p.Y = this.PreferredSize.Height - 1;
            return p;
        }
        private void MakeImage()
        {
            Graphics gr = Graphics.FromImage(Image);
            if (isGlyphMoved)
            {
                gr.DrawImage(tempBmp, 0, 0, tempBmp.Width, tempBmp.Height);
                selGlyph.Draw(gr, isStatusVisible, isNameVisible);
                if (isRelationVisible)
                    foreach (Glyph p in glyphs)
                    {
                        if (p.children == null)
                            continue;
                        if (p == selGlyph)
                        {
                            foreach (Glyph c in p.children)
                                gr.DrawLine(Pens.DarkGreen, p.xPos,
                                    p.yPos, c.xPos, c.yPos);
                        }
                        else
                        {
                            foreach (Glyph c in p.children)
                                if (c == selGlyph)
                                {
                                    gr.DrawLine(Pens.DarkGreen, p.xPos,
                                        p.yPos, c.xPos, c.yPos);
                                    break;
                                }
                        }
                    }
            }
            else
            {
                gr.DrawImage(plantBmp, 0, 0, plantBmp.Width, plantBmp.Height);
                foreach (Glyph g in glyphs)
                    g.Draw(gr, isStatusVisible, isNameVisible);
                if (isRelationVisible)
                    foreach (Glyph g in glyphs)
                        if (g.children != null)
                            foreach (Glyph c in g.children)
                                gr.DrawLine(Pens.DarkGreen, g.xPos, g.yPos,
                                    c.xPos, c.yPos);
            }
        }
        private void MakeTempImage()
        {
            Graphics gr = Graphics.FromImage(tempBmp);
            gr.DrawImage(plantBmp, 0, 0, plantBmp.Width, plantBmp.Height);
            foreach (Glyph g in glyphs)
                if (g != selGlyph)
                    g.Draw(gr, isStatusVisible, isNameVisible);
            if (isRelationVisible)
                foreach (Glyph g in glyphs)
                    if (g != selGlyph && g.children != null)
                        foreach (Glyph c in g.children)
                            if (c != selGlyph)
                                gr.DrawLine(Pens.DarkGreen, g.xPos, g.yPos,
                                    c.xPos, c.yPos);
        }
        private void SetSelectedGlyphAndGlyphPointType(MouseEventArgs e)
        {
            selGlyph = null;
            glPointType = GlyphPointType.None;
            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right)
                return;
            foreach (Glyph g in glyphs)
                g.isSelected = false;
            Point p = PicBoxCoordToBmpCoord(e.X, e.Y);
            int curScrPos = -1;
            for (int i = 0; i < glyphs.Count; i++)
            {
                Glyph g = glyphs[i] as Glyph;
                GlyphPointType gpt = g.HitTest(p.X, p.Y);
                if (gpt != GlyphPointType.None &&
                    curScrPos < i)
                {
                    selGlyph = g;
                    glPointType = gpt;
                    curScrPos = i;
                }
            }
            if (selGlyph != null)
            {
                glyphs.RemoveAt(curScrPos);
                glyphs.Insert(glyphs.Count, selGlyph);
                selGlyph.isSelected = true;
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            oldPos = PicBoxCoordToBmpCoord(e.X, e.Y);
            SetSelectedGlyphAndGlyphPointType(e);
            if (selGlyph != null && e.Button == MouseButtons.Left)
                MakeTempImage();
            MakeImage();
            Refresh();
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (isEditable == false ||
                e.Button != MouseButtons.Left ||
                glPointType == GlyphPointType.None)
            {
                base.OnMouseMove(e);
                return;
            }
            isGlyphMoved = true;
            Point p = PicBoxCoordToBmpCoord(e.X, e.Y);
            int xTran = p.X - oldPos.X;
            int yTran = p.Y - oldPos.Y;
            oldPos = p;
            Size s = selGlyph.GetSize();
            switch (glPointType)
            {
                case GlyphPointType.Default:
                    selGlyph.xPos += xTran;
                    selGlyph.yPos += yTran;
                    break;
                case GlyphPointType.LeftUpper:
                    Cursor = Cursors.SizeNWSE;
                    selGlyph.xPos += xTran;
                    selGlyph.yPos += yTran;
                    selGlyph.SetSize(s.Width - xTran, s.Height - yTran);
                    break;
                case GlyphPointType.LeftLower:
                    Cursor = Cursors.SizeNESW;
                    selGlyph.xPos += xTran;
                    selGlyph.SetSize(s.Width - xTran, s.Height + yTran);
                    break;
                case GlyphPointType.RightUpper:
                    Cursor = Cursors.SizeNESW;
                    selGlyph.yPos += yTran;
                    selGlyph.SetSize(s.Width + xTran, s.Height - yTran);
                    break;
                case GlyphPointType.RightLower:
                    Cursor = Cursors.SizeNWSE;
                    selGlyph.SetSize(s.Width + xTran, s.Height + yTran);
                    break;
            }
            MakeImage();
            Refresh();
            base.OnMouseMove(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (selGlyph == null)
            {
                base.OnMouseUp(e);
                return;
            }
            if (isGlyphMoved)
            {
                isGlyphMoved = false;
                selGlyph.UpdateDataSet(ds as ReworksDataSet);
                Cursor = Cursors.Default;
            }
            GlyphEventArgs glEvArgs =
                    new GlyphEventArgs(glPointType, selGlyph, e);
            GlyphClicked(this, glEvArgs);
            MakeImage();
            Refresh();
            base.OnMouseUp(e);
        }
    }
    public class RewTreeView : TreeView
    {
        private DataSet ds;
        public DataSet DataSet
        {
            set
            {
                ds = value;
            }
            get
            {
                return ds;
            }
        }
        public void LoadNodes()
        {
            ReworksDataSet dsMain = ds as ReworksDataSet;
            ArrayList plNodes = new ArrayList();
            foreach (ReworksDataSet.PlantRow pRow in dsMain.Plant.Rows)
            {
                RewTreeNode plNode = new RewTreeNode(pRow.PlantId,
                    pRow.PlantName, "Plant.bmp", RewObjectType.Plant);
                plNode.Nodes.AddRange(LoadRepZones(pRow));
                plNode.Nodes.AddRange(LoadContollers(pRow));
                plNodes.Add(plNode);
            }
            plNodes.Sort();
            if (plNodes.Count == Nodes.Count)
            {
                int i = 0;
                for (i = 0; i < plNodes.Count; i++)
                    if (CompareTrees(plNodes[i] as TreeNode, Nodes[i]) == false)
                        break;
                if (i < plNodes.Count)
                {
                    BeginUpdate();
                    Nodes.Clear();
                    Nodes.AddRange((RewTreeNode[])plNodes.ToArray(typeof(RewTreeNode)));
                    ExpandAll();
                    EndUpdate();
                }
            }
            else
            {
                BeginUpdate();
                Nodes.Clear();
                Nodes.AddRange((RewTreeNode[])plNodes.ToArray(typeof(RewTreeNode)));
                ExpandAll();
                EndUpdate();
            }
        }
        private RewTreeNode[] LoadRepZones(ReworksDataSet.PlantRow pRow)
        {
            ReworksDataSet.RepairZoneRow[] rzRows =
                pRow.GetRepairZoneRows();
            ArrayList rzNodes = new ArrayList();
            foreach (ReworksDataSet.RepairZoneRow rzRow in rzRows)
            {
                RewTreeNode rzNode = new RewTreeNode(rzRow.RepZoneId,
                    rzRow.RepZoneName, "Repair zone.bmp", RewObjectType.RepairZone);
                rzNodes.Add(rzNode);
                rzNode.Nodes.AddRange(LoadContPoints(rzRow));
                rzNode.Nodes.AddRange(LoadTerminals(rzRow));
            }
            rzNodes.Sort();
            return (RewTreeNode[])rzNodes.ToArray(typeof(RewTreeNode));
        }
        private RewTreeNode[] LoadContPoints(ReworksDataSet.RepairZoneRow rzRow)
        {
            ReworksDataSet.ControlPointRow[] cpRows =
                rzRow.GetControlPointRows();
            ArrayList cpNodes = new ArrayList();
            foreach (ReworksDataSet.ControlPointRow cpRow in cpRows)
            {
                RewTreeNode cpNode =
                    new RewTreeNode(cpRow.ContPointId, cpRow.ContPointName,
                    "Control point.bmp", RewObjectType.ControlPoint);
                cpNodes.Add(cpNode);
                cpNode.Nodes.AddRange(LoadScaners(cpRow));
                cpNode.Nodes.AddRange(LoadLockers(cpRow));
                cpNode.Nodes.AddRange(LoadSensors(cpRow));
            }
            cpNodes.Sort();
            return (RewTreeNode[])cpNodes.ToArray(typeof(RewTreeNode));
        }
        private RewTreeNode[] LoadScaners(ReworksDataSet.ControlPointRow cpRow)
        {
            ReworksDataSet.ScanerRow[] sRows =
                cpRow.GetScanerRows();
            ArrayList sNodes = new ArrayList();
            foreach (ReworksDataSet.ScanerRow sRow in sRows)
            {
                RewTreeNode sNode =
                    new RewTreeNode(sRow.ScanId, sRow.ScanName,
                    "Scaner.bmp", RewObjectType.Scaner);
                sNodes.Add(sNode);
            }
            sNodes.Sort();
            return (RewTreeNode[])sNodes.ToArray(typeof(RewTreeNode));
        }
        private RewTreeNode[] LoadLockers(ReworksDataSet.ControlPointRow cpRow)
        {
            ReworksDataSet.LockerRow[] lRows =
                cpRow.GetLockerRows();
            ArrayList lNodes = new ArrayList();
            foreach (ReworksDataSet.LockerRow lRow in lRows)
            {
                RewTreeNode lNode =
                    new RewTreeNode(lRow.LocId, lRow.LocId.ToString(),
                    "Locker.bmp", RewObjectType.Locker);
                lNodes.Add(lNode);
            }
            lNodes.Sort();
            return (RewTreeNode[])lNodes.ToArray(typeof(RewTreeNode));
        }
        private RewTreeNode[] LoadSensors(ReworksDataSet.ControlPointRow cpRow)
        {
            ReworksDataSet.SensorRow[] sRows =
                cpRow.GetSensorRows();
            ArrayList sNodes = new ArrayList();
            foreach (ReworksDataSet.SensorRow sRow in sRows)
            {
                RewTreeNode sNode =
                    new RewTreeNode(sRow.SensId, sRow.SensId.ToString(),
                    "Sensor.bmp", RewObjectType.Sensor);
                sNodes.Add(sNode);
            }
            sNodes.Sort();
            return (RewTreeNode[])sNodes.ToArray(typeof(RewTreeNode));
        }
        private RewTreeNode[] LoadTerminals(ReworksDataSet.RepairZoneRow rzRow)
        {
            ReworksDataSet.TerminalRow[] tRows =
                rzRow.GetTerminalRows();
            ArrayList tNodes = new ArrayList();
            foreach (ReworksDataSet.TerminalRow tRow in tRows)
            {
                RewTreeNode tNode =
                    new RewTreeNode(tRow.TermId, tRow.TermName,
                    "Terminal.bmp", RewObjectType.Terminal);
                tNodes.Add(tNode);
            }
            tNodes.Sort();
            return (RewTreeNode[])tNodes.ToArray(typeof(RewTreeNode));
        }
        private RewTreeNode[] LoadContollers(ReworksDataSet.PlantRow pRow)
        {
            ReworksDataSet.ControllerRow[] contRows =
                pRow.GetControllerRows();
            ArrayList contNodes = new ArrayList();
            foreach (ReworksDataSet.ControllerRow contRow in contRows)
            {
                RewTreeNode contNode = new RewTreeNode(contRow.ContId,
                    contRow.ContName, "Controller.bmp", RewObjectType.Controller);
                contNodes.Add(contNode);
                contNode.Nodes.AddRange(LoadScaners(contRow));
                contNode.Nodes.AddRange(LoadLockers(contRow));
                contNode.Nodes.AddRange(LoadSensors(contRow));
            }
            contNodes.Sort();
            return (RewTreeNode[])contNodes.ToArray(typeof(RewTreeNode));
        }
        private RewTreeNode[] LoadScaners(ReworksDataSet.ControllerRow contRow)
        {
            ReworksDataSet.ScanerRow[] sRows =
                contRow.GetScanerRows();
            ArrayList sNodes = new ArrayList();
            foreach (ReworksDataSet.ScanerRow sRow in sRows)
            {
                RewTreeNode sNode =
                    new RewTreeNode(sRow.ScanId, sRow.ScanName,
                    "Scaner.bmp", RewObjectType.Scaner);
                sNodes.Add(sNode);
            }
            sNodes.Sort();
            return (RewTreeNode[])sNodes.ToArray(typeof(RewTreeNode));
        }
        private RewTreeNode[] LoadLockers(ReworksDataSet.ControllerRow contRow)
        {
            ReworksDataSet.LockerRow[] lRows =
                contRow.GetLockerRows();
            ArrayList lNodes = new ArrayList();
            foreach (ReworksDataSet.LockerRow lRow in lRows)
            {
                RewTreeNode lNode =
                    new RewTreeNode(lRow.LocId, lRow.LocId.ToString(),
                    "Locker.bmp", RewObjectType.Locker);
                lNodes.Add(lNode);
            }
            lNodes.Sort();
            return (RewTreeNode[])lNodes.ToArray(typeof(RewTreeNode));
        }
        private RewTreeNode[] LoadSensors(ReworksDataSet.ControllerRow contRow)
        {
            ReworksDataSet.SensorRow[] sRows =
                contRow.GetSensorRows();
            ArrayList sNodes = new ArrayList();
            foreach (ReworksDataSet.SensorRow sRow in sRows)
            {
                RewTreeNode sNode =
                    new RewTreeNode(sRow.SensId, sRow.SensId.ToString(),
                    "Sensor.bmp", RewObjectType.Sensor);
                sNodes.Add(sNode);
            }
            sNodes.Sort();
            return (RewTreeNode[])sNodes.ToArray(typeof(RewTreeNode));
        }
        private bool CompareTrees(TreeNode n1, TreeNode n2)
        {
            RewTreeNode t1 = n1 as RewTreeNode;
            RewTreeNode t2 = n2 as RewTreeNode;
            if (t1.type != t2.type || t1.id != t2.id
                || t1.Nodes.Count != t2.Nodes.Count)
                return false;
            for (int i = 0; i < t1.Nodes.Count; i++)
                if (CompareTrees(n1.Nodes[i], n2.Nodes[i]) == false)
                    return false;
            return true;
        }
    }
    public class RewTreeNode : TreeNode, IComparable
    {
        public decimal id;
        public RewObjectType type;
        public RewTreeNode() { }
        public RewTreeNode(decimal id, string text,
            string imageKey, RewObjectType type)
        {
            string rewObjectTypeName;
            switch (type)
            {
                case RewObjectType.Locker:
                    if (Thread.CurrentThread.CurrentCulture.
                        TwoLetterISOLanguageName == "ru")
                        rewObjectTypeName = "Стопор";
                    else
                        rewObjectTypeName = "Locker";
                    break;
                case RewObjectType.Sensor:
                    if (Thread.CurrentThread.CurrentCulture.
                        TwoLetterISOLanguageName == "ru")
                        rewObjectTypeName = "Сенсор";
                    else
                        rewObjectTypeName = "Sensor";
                    break;
                default:
                    rewObjectTypeName = "";
                    break;
            }
            this.id = id;
            this.Text = rewObjectTypeName + text;
            this.ImageKey = imageKey;
            this.SelectedImageKey = imageKey;
            this.type = type;
        }
        public int CompareTo(object obj)
        {
            RewTreeNode node = obj as RewTreeNode;
            if (this.type == node.type)
                return this.Text.CompareTo(node.Text);
            return this.type.CompareTo(node.type);
        }
    }
    public enum RewObjectType
    {
        Plant, RepairZone, ControlPoint, Controller,
        Terminal, Scaner, Locker, Sensor
    }
    public enum ErrorType
    {
        ProgLoadError, IllegalDataError, AppChangesError,
        RejChangesError, DatabaseError, BitmapLoadError
    }
}