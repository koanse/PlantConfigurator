namespace PlantConfig
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label repZoneNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label repZoneNameEngLabel;
            System.Windows.Forms.Label repZonePosX1Label;
            System.Windows.Forms.Label repZonePosY1Label;
            System.Windows.Forms.Label repZonePosX2Label;
            System.Windows.Forms.Label repZonePosY2Label;
            System.Windows.Forms.Label repZoneIdLabel;
            System.Windows.Forms.Label contPointNameLabel;
            System.Windows.Forms.Label contPointTypeLabel;
            System.Windows.Forms.Label contNameLabel;
            System.Windows.Forms.Label contIpLabel;
            System.Windows.Forms.Label contPosXLabel;
            System.Windows.Forms.Label contPosYLabel;
            System.Windows.Forms.Label inputCoilStartAddressLabel;
            System.Windows.Forms.Label inputCoilUnitCountLabel;
            System.Windows.Forms.Label outputCoilStartAddressLabel;
            System.Windows.Forms.Label outputCoilUnitCountLabel;
            System.Windows.Forms.Label termIdLabel;
            System.Windows.Forms.Label termModeLabel;
            System.Windows.Forms.Label repZoneIdLabel1;
            System.Windows.Forms.Label termNameLabel;
            System.Windows.Forms.Label termIpLabel;
            System.Windows.Forms.Label termPosXLabel;
            System.Windows.Forms.Label termPosYLabel;
            System.Windows.Forms.Label scanDataPortLabel;
            System.Windows.Forms.Label contPointIdLabel;
            System.Windows.Forms.Label contIdLabel;
            System.Windows.Forms.Label scanNameLabel;
            System.Windows.Forms.Label scanTypeLabel;
            System.Windows.Forms.Label scanAddressLabel;
            System.Windows.Forms.Label scanPosXLabel;
            System.Windows.Forms.Label scanPosYLabel;
            System.Windows.Forms.Label locIdLabel;
            System.Windows.Forms.Label contIdLabel1;
            System.Windows.Forms.Label contPointIdLabel1;
            System.Windows.Forms.Label locTypeLabel;
            System.Windows.Forms.Label locAddressLabel;
            System.Windows.Forms.Label sensIdLabel;
            System.Windows.Forms.Label contPointIdLabel2;
            System.Windows.Forms.Label contIdLabel2;
            System.Windows.Forms.Label sensTypeLabel;
            System.Windows.Forms.Label sensAddressLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.rewTreeView1 = new PlantConfig.RewTreeView();
            this.dsMain = new PlantConfig.ReworksDataSet();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRz = new System.Windows.Forms.TabPage();
            this.repZoneNameTextBox = new System.Windows.Forms.TextBox();
            this.bsRepZone = new System.Windows.Forms.BindingSource(this.components);
            this.repZoneNameEngTextBox = new System.Windows.Forms.TextBox();
            this.repZonePosX1TextBox = new System.Windows.Forms.TextBox();
            this.repZonePosY1TextBox = new System.Windows.Forms.TextBox();
            this.repZonePosX2TextBox = new System.Windows.Forms.TextBox();
            this.repZonePosY2TextBox = new System.Windows.Forms.TextBox();
            this.tabPageCp = new System.Windows.Forms.TabPage();
            this.repZoneIdComboBox = new System.Windows.Forms.ComboBox();
            this.bsContPoint = new System.Windows.Forms.BindingSource(this.components);
            this.bsRepZonesListContPoint = new System.Windows.Forms.BindingSource(this.components);
            this.contPointNameTextBox = new System.Windows.Forms.TextBox();
            this.contPointTypeComboBox = new System.Windows.Forms.ComboBox();
            this.bsTypesContPoint = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageCont = new System.Windows.Forms.TabPage();
            this.contNameTextBox = new System.Windows.Forms.TextBox();
            this.bsController = new System.Windows.Forms.BindingSource(this.components);
            this.contIpTextBox = new System.Windows.Forms.TextBox();
            this.contPosXTextBox = new System.Windows.Forms.TextBox();
            this.contPosYTextBox = new System.Windows.Forms.TextBox();
            this.inputCoilStartAddressTextBox = new System.Windows.Forms.TextBox();
            this.inputCoilUnitCountTextBox = new System.Windows.Forms.TextBox();
            this.outputCoilStartAddressTextBox = new System.Windows.Forms.TextBox();
            this.outputCoilUnitCountTextBox = new System.Windows.Forms.TextBox();
            this.tabPageTerm = new System.Windows.Forms.TabPage();
            this.termIdTextBox = new System.Windows.Forms.TextBox();
            this.bsTerminal = new System.Windows.Forms.BindingSource(this.components);
            this.termModeComboBox = new System.Windows.Forms.ComboBox();
            this.repZoneIdComboBox1 = new System.Windows.Forms.ComboBox();
            this.bsRepZonesListTerm = new System.Windows.Forms.BindingSource(this.components);
            this.termNameTextBox = new System.Windows.Forms.TextBox();
            this.termIpTextBox = new System.Windows.Forms.TextBox();
            this.termPosXTextBox = new System.Windows.Forms.TextBox();
            this.termPosYTextBox = new System.Windows.Forms.TextBox();
            this.tabPageScan = new System.Windows.Forms.TabPage();
            this.scanDataPortTextBox = new System.Windows.Forms.TextBox();
            this.bsScaner = new System.Windows.Forms.BindingSource(this.components);
            this.contPointIdComboBox = new System.Windows.Forms.ComboBox();
            this.bsContPointsListScan = new System.Windows.Forms.BindingSource(this.components);
            this.contIdComboBox = new System.Windows.Forms.ComboBox();
            this.bsControllersListScan = new System.Windows.Forms.BindingSource(this.components);
            this.scanNameTextBox = new System.Windows.Forms.TextBox();
            this.scanTypeComboBox = new System.Windows.Forms.ComboBox();
            this.bsTypesScan = new System.Windows.Forms.BindingSource(this.components);
            this.scanAddressTextBox = new System.Windows.Forms.TextBox();
            this.scanPosXTextBox = new System.Windows.Forms.TextBox();
            this.scanPosYTextBox = new System.Windows.Forms.TextBox();
            this.tabPageLock = new System.Windows.Forms.TabPage();
            this.locIdTextBox = new System.Windows.Forms.TextBox();
            this.bsLocker = new System.Windows.Forms.BindingSource(this.components);
            this.contIdComboBox1 = new System.Windows.Forms.ComboBox();
            this.bsControllersListLock = new System.Windows.Forms.BindingSource(this.components);
            this.contPointIdComboBox1 = new System.Windows.Forms.ComboBox();
            this.bsContPointsListLoc = new System.Windows.Forms.BindingSource(this.components);
            this.locTypeComboBox = new System.Windows.Forms.ComboBox();
            this.bsTypesLock = new System.Windows.Forms.BindingSource(this.components);
            this.locAddressTextBox = new System.Windows.Forms.TextBox();
            this.tabPageSens = new System.Windows.Forms.TabPage();
            this.sensIdTextBox = new System.Windows.Forms.TextBox();
            this.bsSensor = new System.Windows.Forms.BindingSource(this.components);
            this.contPointIdComboBox2 = new System.Windows.Forms.ComboBox();
            this.bsContPointsListSens = new System.Windows.Forms.BindingSource(this.components);
            this.contIdComboBox2 = new System.Windows.Forms.ComboBox();
            this.bsControllersListSens = new System.Windows.Forms.BindingSource(this.components);
            this.sensTypeComboBox = new System.Windows.Forms.ComboBox();
            this.bsTypesSens = new System.Windows.Forms.BindingSource(this.components);
            this.sensAddressTextBox = new System.Windows.Forms.TextBox();
            this.pictureBoxGlyphs1 = new PlantConfig.PictureBoxGlyphs();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPlantBitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allowVisualEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejectChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStatusesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRelationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taRepZone = new PlantConfig.ReworksDataSetTableAdapters.RepairZoneTableAdapter();
            this.taContPoint = new PlantConfig.ReworksDataSetTableAdapters.ControlPointTableAdapter();
            this.taController = new PlantConfig.ReworksDataSetTableAdapters.ControllerTableAdapter();
            this.taTerminal = new PlantConfig.ReworksDataSetTableAdapters.TerminalTableAdapter();
            this.taScaner = new PlantConfig.ReworksDataSetTableAdapters.ScanerTableAdapter();
            this.taLocker = new PlantConfig.ReworksDataSetTableAdapters.LockerTableAdapter();
            this.taSensor = new PlantConfig.ReworksDataSetTableAdapters.SensorTableAdapter();
            this.taPlant = new PlantConfig.ReworksDataSetTableAdapters.PlantTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            repZoneNameLabel = new System.Windows.Forms.Label();
            repZoneNameEngLabel = new System.Windows.Forms.Label();
            repZonePosX1Label = new System.Windows.Forms.Label();
            repZonePosY1Label = new System.Windows.Forms.Label();
            repZonePosX2Label = new System.Windows.Forms.Label();
            repZonePosY2Label = new System.Windows.Forms.Label();
            repZoneIdLabel = new System.Windows.Forms.Label();
            contPointNameLabel = new System.Windows.Forms.Label();
            contPointTypeLabel = new System.Windows.Forms.Label();
            contNameLabel = new System.Windows.Forms.Label();
            contIpLabel = new System.Windows.Forms.Label();
            contPosXLabel = new System.Windows.Forms.Label();
            contPosYLabel = new System.Windows.Forms.Label();
            inputCoilStartAddressLabel = new System.Windows.Forms.Label();
            inputCoilUnitCountLabel = new System.Windows.Forms.Label();
            outputCoilStartAddressLabel = new System.Windows.Forms.Label();
            outputCoilUnitCountLabel = new System.Windows.Forms.Label();
            termIdLabel = new System.Windows.Forms.Label();
            termModeLabel = new System.Windows.Forms.Label();
            repZoneIdLabel1 = new System.Windows.Forms.Label();
            termNameLabel = new System.Windows.Forms.Label();
            termIpLabel = new System.Windows.Forms.Label();
            termPosXLabel = new System.Windows.Forms.Label();
            termPosYLabel = new System.Windows.Forms.Label();
            scanDataPortLabel = new System.Windows.Forms.Label();
            contPointIdLabel = new System.Windows.Forms.Label();
            contIdLabel = new System.Windows.Forms.Label();
            scanNameLabel = new System.Windows.Forms.Label();
            scanTypeLabel = new System.Windows.Forms.Label();
            scanAddressLabel = new System.Windows.Forms.Label();
            scanPosXLabel = new System.Windows.Forms.Label();
            scanPosYLabel = new System.Windows.Forms.Label();
            locIdLabel = new System.Windows.Forms.Label();
            contIdLabel1 = new System.Windows.Forms.Label();
            contPointIdLabel1 = new System.Windows.Forms.Label();
            locTypeLabel = new System.Windows.Forms.Label();
            locAddressLabel = new System.Windows.Forms.Label();
            sensIdLabel = new System.Windows.Forms.Label();
            contPointIdLabel2 = new System.Windows.Forms.Label();
            contIdLabel2 = new System.Windows.Forms.Label();
            sensTypeLabel = new System.Windows.Forms.Label();
            sensAddressLabel = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageRz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRepZone)).BeginInit();
            this.tabPageCp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsContPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRepZonesListContPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypesContPoint)).BeginInit();
            this.tabPageCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsController)).BeginInit();
            this.tabPageTerm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRepZonesListTerm)).BeginInit();
            this.tabPageScan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsScaner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContPointsListScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsControllersListScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypesScan)).BeginInit();
            this.tabPageLock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsControllersListLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContPointsListLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypesLock)).BeginInit();
            this.tabPageSens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContPointsListSens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsControllersListSens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypesSens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlyphs1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // repZoneNameLabel
            // 
            resources.ApplyResources(repZoneNameLabel, "repZoneNameLabel");
            repZoneNameLabel.Name = "repZoneNameLabel";
            // 
            // repZoneNameEngLabel
            // 
            resources.ApplyResources(repZoneNameEngLabel, "repZoneNameEngLabel");
            repZoneNameEngLabel.Name = "repZoneNameEngLabel";
            // 
            // repZonePosX1Label
            // 
            resources.ApplyResources(repZonePosX1Label, "repZonePosX1Label");
            repZonePosX1Label.Name = "repZonePosX1Label";
            // 
            // repZonePosY1Label
            // 
            resources.ApplyResources(repZonePosY1Label, "repZonePosY1Label");
            repZonePosY1Label.Name = "repZonePosY1Label";
            // 
            // repZonePosX2Label
            // 
            resources.ApplyResources(repZonePosX2Label, "repZonePosX2Label");
            repZonePosX2Label.Name = "repZonePosX2Label";
            // 
            // repZonePosY2Label
            // 
            resources.ApplyResources(repZonePosY2Label, "repZonePosY2Label");
            repZonePosY2Label.Name = "repZonePosY2Label";
            // 
            // repZoneIdLabel
            // 
            resources.ApplyResources(repZoneIdLabel, "repZoneIdLabel");
            repZoneIdLabel.Name = "repZoneIdLabel";
            // 
            // contPointNameLabel
            // 
            resources.ApplyResources(contPointNameLabel, "contPointNameLabel");
            contPointNameLabel.Name = "contPointNameLabel";
            // 
            // contPointTypeLabel
            // 
            resources.ApplyResources(contPointTypeLabel, "contPointTypeLabel");
            contPointTypeLabel.Name = "contPointTypeLabel";
            // 
            // contNameLabel
            // 
            resources.ApplyResources(contNameLabel, "contNameLabel");
            contNameLabel.Name = "contNameLabel";
            // 
            // contIpLabel
            // 
            resources.ApplyResources(contIpLabel, "contIpLabel");
            contIpLabel.Name = "contIpLabel";
            // 
            // contPosXLabel
            // 
            resources.ApplyResources(contPosXLabel, "contPosXLabel");
            contPosXLabel.Name = "contPosXLabel";
            // 
            // contPosYLabel
            // 
            resources.ApplyResources(contPosYLabel, "contPosYLabel");
            contPosYLabel.Name = "contPosYLabel";
            // 
            // inputCoilStartAddressLabel
            // 
            resources.ApplyResources(inputCoilStartAddressLabel, "inputCoilStartAddressLabel");
            inputCoilStartAddressLabel.Name = "inputCoilStartAddressLabel";
            // 
            // inputCoilUnitCountLabel
            // 
            resources.ApplyResources(inputCoilUnitCountLabel, "inputCoilUnitCountLabel");
            inputCoilUnitCountLabel.Name = "inputCoilUnitCountLabel";
            // 
            // outputCoilStartAddressLabel
            // 
            resources.ApplyResources(outputCoilStartAddressLabel, "outputCoilStartAddressLabel");
            outputCoilStartAddressLabel.Name = "outputCoilStartAddressLabel";
            // 
            // outputCoilUnitCountLabel
            // 
            resources.ApplyResources(outputCoilUnitCountLabel, "outputCoilUnitCountLabel");
            outputCoilUnitCountLabel.Name = "outputCoilUnitCountLabel";
            // 
            // termIdLabel
            // 
            resources.ApplyResources(termIdLabel, "termIdLabel");
            termIdLabel.Name = "termIdLabel";
            // 
            // termModeLabel
            // 
            resources.ApplyResources(termModeLabel, "termModeLabel");
            termModeLabel.Name = "termModeLabel";
            // 
            // repZoneIdLabel1
            // 
            resources.ApplyResources(repZoneIdLabel1, "repZoneIdLabel1");
            repZoneIdLabel1.Name = "repZoneIdLabel1";
            // 
            // termNameLabel
            // 
            resources.ApplyResources(termNameLabel, "termNameLabel");
            termNameLabel.Name = "termNameLabel";
            // 
            // termIpLabel
            // 
            resources.ApplyResources(termIpLabel, "termIpLabel");
            termIpLabel.Name = "termIpLabel";
            // 
            // termPosXLabel
            // 
            resources.ApplyResources(termPosXLabel, "termPosXLabel");
            termPosXLabel.Name = "termPosXLabel";
            // 
            // termPosYLabel
            // 
            resources.ApplyResources(termPosYLabel, "termPosYLabel");
            termPosYLabel.Name = "termPosYLabel";
            // 
            // scanDataPortLabel
            // 
            resources.ApplyResources(scanDataPortLabel, "scanDataPortLabel");
            scanDataPortLabel.Name = "scanDataPortLabel";
            // 
            // contPointIdLabel
            // 
            resources.ApplyResources(contPointIdLabel, "contPointIdLabel");
            contPointIdLabel.Name = "contPointIdLabel";
            // 
            // contIdLabel
            // 
            resources.ApplyResources(contIdLabel, "contIdLabel");
            contIdLabel.Name = "contIdLabel";
            // 
            // scanNameLabel
            // 
            resources.ApplyResources(scanNameLabel, "scanNameLabel");
            scanNameLabel.Name = "scanNameLabel";
            // 
            // scanTypeLabel
            // 
            resources.ApplyResources(scanTypeLabel, "scanTypeLabel");
            scanTypeLabel.Name = "scanTypeLabel";
            // 
            // scanAddressLabel
            // 
            resources.ApplyResources(scanAddressLabel, "scanAddressLabel");
            scanAddressLabel.Name = "scanAddressLabel";
            // 
            // scanPosXLabel
            // 
            resources.ApplyResources(scanPosXLabel, "scanPosXLabel");
            scanPosXLabel.Name = "scanPosXLabel";
            // 
            // scanPosYLabel
            // 
            resources.ApplyResources(scanPosYLabel, "scanPosYLabel");
            scanPosYLabel.Name = "scanPosYLabel";
            // 
            // locIdLabel
            // 
            resources.ApplyResources(locIdLabel, "locIdLabel");
            locIdLabel.Name = "locIdLabel";
            // 
            // contIdLabel1
            // 
            resources.ApplyResources(contIdLabel1, "contIdLabel1");
            contIdLabel1.Name = "contIdLabel1";
            // 
            // contPointIdLabel1
            // 
            resources.ApplyResources(contPointIdLabel1, "contPointIdLabel1");
            contPointIdLabel1.Name = "contPointIdLabel1";
            // 
            // locTypeLabel
            // 
            resources.ApplyResources(locTypeLabel, "locTypeLabel");
            locTypeLabel.Name = "locTypeLabel";
            // 
            // locAddressLabel
            // 
            resources.ApplyResources(locAddressLabel, "locAddressLabel");
            locAddressLabel.Name = "locAddressLabel";
            // 
            // sensIdLabel
            // 
            resources.ApplyResources(sensIdLabel, "sensIdLabel");
            sensIdLabel.Name = "sensIdLabel";
            // 
            // contPointIdLabel2
            // 
            resources.ApplyResources(contPointIdLabel2, "contPointIdLabel2");
            contPointIdLabel2.Name = "contPointIdLabel2";
            // 
            // contIdLabel2
            // 
            resources.ApplyResources(contIdLabel2, "contIdLabel2");
            contIdLabel2.Name = "contIdLabel2";
            // 
            // sensTypeLabel
            // 
            resources.ApplyResources(sensTypeLabel, "sensTypeLabel");
            sensTypeLabel.Name = "sensTypeLabel";
            // 
            // sensAddressLabel
            // 
            resources.ApplyResources(sensAddressLabel, "sensAddressLabel");
            sensAddressLabel.Name = "sensAddressLabel";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.rewTreeView1);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxGlyphs1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripButtonDelete});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButtonAdd, "toolStripButtonAdd");
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButtonSave, "toolStripButtonSave");
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButtonDelete, "toolStripButtonDelete");
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // rewTreeView1
            // 
            resources.ApplyResources(this.rewTreeView1, "rewTreeView1");
            this.rewTreeView1.DataSet = this.dsMain;
            this.rewTreeView1.ImageList = this.imageList1;
            this.rewTreeView1.Name = "rewTreeView1";
            this.rewTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.rewTreeView1_AfterSelect);
            // 
            // dsMain
            // 
            this.dsMain.DataSetName = "ReworksDataSet";
            this.dsMain.Locale = new System.Globalization.CultureInfo("");
            this.dsMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "Control point.bmp");
            this.imageList1.Images.SetKeyName(1, "Controller.bmp");
            this.imageList1.Images.SetKeyName(2, "Error.bmp");
            this.imageList1.Images.SetKeyName(3, "Locker.bmp");
            this.imageList1.Images.SetKeyName(4, "Plant.bmp");
            this.imageList1.Images.SetKeyName(5, "Repair zone.bmp");
            this.imageList1.Images.SetKeyName(6, "Scaner.bmp");
            this.imageList1.Images.SetKeyName(7, "Sensor.bmp");
            this.imageList1.Images.SetKeyName(8, "Terminal.bmp");
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPageRz);
            this.tabControl1.Controls.Add(this.tabPageCp);
            this.tabControl1.Controls.Add(this.tabPageCont);
            this.tabControl1.Controls.Add(this.tabPageTerm);
            this.tabControl1.Controls.Add(this.tabPageScan);
            this.tabControl1.Controls.Add(this.tabPageLock);
            this.tabControl1.Controls.Add(this.tabPageSens);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.SizeChanged += new System.EventHandler(this.tabControl1_SizeChanged);
            // 
            // tabPageRz
            // 
            this.tabPageRz.Controls.Add(repZoneNameLabel);
            this.tabPageRz.Controls.Add(this.repZoneNameTextBox);
            this.tabPageRz.Controls.Add(repZoneNameEngLabel);
            this.tabPageRz.Controls.Add(this.repZoneNameEngTextBox);
            this.tabPageRz.Controls.Add(repZonePosX1Label);
            this.tabPageRz.Controls.Add(this.repZonePosX1TextBox);
            this.tabPageRz.Controls.Add(repZonePosY1Label);
            this.tabPageRz.Controls.Add(this.repZonePosY1TextBox);
            this.tabPageRz.Controls.Add(repZonePosX2Label);
            this.tabPageRz.Controls.Add(this.repZonePosX2TextBox);
            this.tabPageRz.Controls.Add(repZonePosY2Label);
            this.tabPageRz.Controls.Add(this.repZonePosY2TextBox);
            resources.ApplyResources(this.tabPageRz, "tabPageRz");
            this.tabPageRz.Name = "tabPageRz";
            this.tabPageRz.UseVisualStyleBackColor = true;
            // 
            // repZoneNameTextBox
            // 
            resources.ApplyResources(this.repZoneNameTextBox, "repZoneNameTextBox");
            this.repZoneNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRepZone, "RepZoneName", true));
            this.repZoneNameTextBox.Name = "repZoneNameTextBox";
            // 
            // bsRepZone
            // 
            this.bsRepZone.DataMember = "RepairZone";
            this.bsRepZone.DataSource = this.dsMain;
            this.bsRepZone.Sort = "RepZoneName";
            // 
            // repZoneNameEngTextBox
            // 
            resources.ApplyResources(this.repZoneNameEngTextBox, "repZoneNameEngTextBox");
            this.repZoneNameEngTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRepZone, "RepZoneNameEng", true));
            this.repZoneNameEngTextBox.Name = "repZoneNameEngTextBox";
            // 
            // repZonePosX1TextBox
            // 
            resources.ApplyResources(this.repZonePosX1TextBox, "repZonePosX1TextBox");
            this.repZonePosX1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRepZone, "RepZonePosX1", true));
            this.repZonePosX1TextBox.Name = "repZonePosX1TextBox";
            // 
            // repZonePosY1TextBox
            // 
            resources.ApplyResources(this.repZonePosY1TextBox, "repZonePosY1TextBox");
            this.repZonePosY1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRepZone, "RepZonePosY1", true));
            this.repZonePosY1TextBox.Name = "repZonePosY1TextBox";
            // 
            // repZonePosX2TextBox
            // 
            resources.ApplyResources(this.repZonePosX2TextBox, "repZonePosX2TextBox");
            this.repZonePosX2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRepZone, "RepZonePosX2", true));
            this.repZonePosX2TextBox.Name = "repZonePosX2TextBox";
            // 
            // repZonePosY2TextBox
            // 
            resources.ApplyResources(this.repZonePosY2TextBox, "repZonePosY2TextBox");
            this.repZonePosY2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRepZone, "RepZonePosY2", true));
            this.repZonePosY2TextBox.Name = "repZonePosY2TextBox";
            // 
            // tabPageCp
            // 
            this.tabPageCp.Controls.Add(repZoneIdLabel);
            this.tabPageCp.Controls.Add(this.repZoneIdComboBox);
            this.tabPageCp.Controls.Add(contPointNameLabel);
            this.tabPageCp.Controls.Add(this.contPointNameTextBox);
            this.tabPageCp.Controls.Add(contPointTypeLabel);
            this.tabPageCp.Controls.Add(this.contPointTypeComboBox);
            resources.ApplyResources(this.tabPageCp, "tabPageCp");
            this.tabPageCp.Name = "tabPageCp";
            this.tabPageCp.UseVisualStyleBackColor = true;
            // 
            // repZoneIdComboBox
            // 
            resources.ApplyResources(this.repZoneIdComboBox, "repZoneIdComboBox");
            this.repZoneIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsContPoint, "RepZoneId", true));
            this.repZoneIdComboBox.DataSource = this.bsRepZonesListContPoint;
            this.repZoneIdComboBox.DisplayMember = "RepZoneName";
            this.repZoneIdComboBox.FormattingEnabled = true;
            this.repZoneIdComboBox.Name = "repZoneIdComboBox";
            this.repZoneIdComboBox.ValueMember = "RepZoneId";
            // 
            // bsContPoint
            // 
            this.bsContPoint.DataMember = "ControlPoint";
            this.bsContPoint.DataSource = this.dsMain;
            this.bsContPoint.Sort = "ContPointName";
            // 
            // bsRepZonesListContPoint
            // 
            this.bsRepZonesListContPoint.DataMember = "RepairZone";
            this.bsRepZonesListContPoint.DataSource = this.dsMain;
            this.bsRepZonesListContPoint.Sort = "RepZoneName";
            // 
            // contPointNameTextBox
            // 
            resources.ApplyResources(this.contPointNameTextBox, "contPointNameTextBox");
            this.contPointNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsContPoint, "ContPointName", true));
            this.contPointNameTextBox.Name = "contPointNameTextBox";
            // 
            // contPointTypeComboBox
            // 
            resources.ApplyResources(this.contPointTypeComboBox, "contPointTypeComboBox");
            this.contPointTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsContPoint, "ContPointType", true));
            this.contPointTypeComboBox.DataSource = this.bsTypesContPoint;
            this.contPointTypeComboBox.DisplayMember = "Type";
            this.contPointTypeComboBox.FormattingEnabled = true;
            this.contPointTypeComboBox.Name = "contPointTypeComboBox";
            this.contPointTypeComboBox.ValueMember = "TypeId";
            // 
            // bsTypesContPoint
            // 
            this.bsTypesContPoint.DataMember = "DeviceType";
            this.bsTypesContPoint.DataSource = this.dsMain;
            this.bsTypesContPoint.Filter = "";
            this.bsTypesContPoint.Sort = "Type";
            // 
            // tabPageCont
            // 
            resources.ApplyResources(this.tabPageCont, "tabPageCont");
            this.tabPageCont.Controls.Add(contNameLabel);
            this.tabPageCont.Controls.Add(this.contNameTextBox);
            this.tabPageCont.Controls.Add(contIpLabel);
            this.tabPageCont.Controls.Add(this.contIpTextBox);
            this.tabPageCont.Controls.Add(contPosXLabel);
            this.tabPageCont.Controls.Add(this.contPosXTextBox);
            this.tabPageCont.Controls.Add(contPosYLabel);
            this.tabPageCont.Controls.Add(this.contPosYTextBox);
            this.tabPageCont.Controls.Add(inputCoilStartAddressLabel);
            this.tabPageCont.Controls.Add(this.inputCoilStartAddressTextBox);
            this.tabPageCont.Controls.Add(inputCoilUnitCountLabel);
            this.tabPageCont.Controls.Add(this.inputCoilUnitCountTextBox);
            this.tabPageCont.Controls.Add(outputCoilStartAddressLabel);
            this.tabPageCont.Controls.Add(this.outputCoilStartAddressTextBox);
            this.tabPageCont.Controls.Add(outputCoilUnitCountLabel);
            this.tabPageCont.Controls.Add(this.outputCoilUnitCountTextBox);
            this.tabPageCont.Name = "tabPageCont";
            this.tabPageCont.UseVisualStyleBackColor = true;
            // 
            // contNameTextBox
            // 
            resources.ApplyResources(this.contNameTextBox, "contNameTextBox");
            this.contNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsController, "ContName", true));
            this.contNameTextBox.Name = "contNameTextBox";
            // 
            // bsController
            // 
            this.bsController.DataMember = "Controller";
            this.bsController.DataSource = this.dsMain;
            this.bsController.Sort = "ContName";
            // 
            // contIpTextBox
            // 
            resources.ApplyResources(this.contIpTextBox, "contIpTextBox");
            this.contIpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsController, "ContIp", true));
            this.contIpTextBox.Name = "contIpTextBox";
            // 
            // contPosXTextBox
            // 
            resources.ApplyResources(this.contPosXTextBox, "contPosXTextBox");
            this.contPosXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsController, "ContPosX", true));
            this.contPosXTextBox.Name = "contPosXTextBox";
            // 
            // contPosYTextBox
            // 
            resources.ApplyResources(this.contPosYTextBox, "contPosYTextBox");
            this.contPosYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsController, "ContPosY", true));
            this.contPosYTextBox.Name = "contPosYTextBox";
            // 
            // inputCoilStartAddressTextBox
            // 
            resources.ApplyResources(this.inputCoilStartAddressTextBox, "inputCoilStartAddressTextBox");
            this.inputCoilStartAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsController, "InputCoilStartAddress", true));
            this.inputCoilStartAddressTextBox.Name = "inputCoilStartAddressTextBox";
            // 
            // inputCoilUnitCountTextBox
            // 
            resources.ApplyResources(this.inputCoilUnitCountTextBox, "inputCoilUnitCountTextBox");
            this.inputCoilUnitCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsController, "InputCoilUnitCount", true));
            this.inputCoilUnitCountTextBox.Name = "inputCoilUnitCountTextBox";
            // 
            // outputCoilStartAddressTextBox
            // 
            resources.ApplyResources(this.outputCoilStartAddressTextBox, "outputCoilStartAddressTextBox");
            this.outputCoilStartAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsController, "OutputCoilStartAddress", true));
            this.outputCoilStartAddressTextBox.Name = "outputCoilStartAddressTextBox";
            // 
            // outputCoilUnitCountTextBox
            // 
            resources.ApplyResources(this.outputCoilUnitCountTextBox, "outputCoilUnitCountTextBox");
            this.outputCoilUnitCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsController, "OutputCoilUnitCount", true));
            this.outputCoilUnitCountTextBox.Name = "outputCoilUnitCountTextBox";
            // 
            // tabPageTerm
            // 
            this.tabPageTerm.Controls.Add(termIdLabel);
            this.tabPageTerm.Controls.Add(this.termIdTextBox);
            this.tabPageTerm.Controls.Add(this.termModeComboBox);
            this.tabPageTerm.Controls.Add(termModeLabel);
            this.tabPageTerm.Controls.Add(repZoneIdLabel1);
            this.tabPageTerm.Controls.Add(this.repZoneIdComboBox1);
            this.tabPageTerm.Controls.Add(termNameLabel);
            this.tabPageTerm.Controls.Add(this.termNameTextBox);
            this.tabPageTerm.Controls.Add(termIpLabel);
            this.tabPageTerm.Controls.Add(this.termIpTextBox);
            this.tabPageTerm.Controls.Add(termPosXLabel);
            this.tabPageTerm.Controls.Add(this.termPosXTextBox);
            this.tabPageTerm.Controls.Add(termPosYLabel);
            this.tabPageTerm.Controls.Add(this.termPosYTextBox);
            resources.ApplyResources(this.tabPageTerm, "tabPageTerm");
            this.tabPageTerm.Name = "tabPageTerm";
            this.tabPageTerm.UseVisualStyleBackColor = true;
            // 
            // termIdTextBox
            // 
            resources.ApplyResources(this.termIdTextBox, "termIdTextBox");
            this.termIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTerminal, "TermId", true));
            this.termIdTextBox.Name = "termIdTextBox";
            this.termIdTextBox.ReadOnly = true;
            // 
            // bsTerminal
            // 
            this.bsTerminal.DataMember = "Terminal";
            this.bsTerminal.DataSource = this.dsMain;
            this.bsTerminal.Sort = "TermName";
            // 
            // termModeComboBox
            // 
            resources.ApplyResources(this.termModeComboBox, "termModeComboBox");
            this.termModeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsTerminal, "TermMode", true));
            this.termModeComboBox.DataSource = this.dsMain;
            this.termModeComboBox.DisplayMember = "TermModes.ModeName";
            this.termModeComboBox.FormattingEnabled = true;
            this.termModeComboBox.Name = "termModeComboBox";
            this.termModeComboBox.ValueMember = "TermModes.ModeId";
            // 
            // repZoneIdComboBox1
            // 
            resources.ApplyResources(this.repZoneIdComboBox1, "repZoneIdComboBox1");
            this.repZoneIdComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsTerminal, "RepZoneId", true));
            this.repZoneIdComboBox1.DataSource = this.bsRepZonesListTerm;
            this.repZoneIdComboBox1.DisplayMember = "RepZoneName";
            this.repZoneIdComboBox1.FormattingEnabled = true;
            this.repZoneIdComboBox1.Name = "repZoneIdComboBox1";
            this.repZoneIdComboBox1.ValueMember = "RepZoneId";
            // 
            // bsRepZonesListTerm
            // 
            this.bsRepZonesListTerm.DataMember = "RepairZone";
            this.bsRepZonesListTerm.DataSource = this.dsMain;
            this.bsRepZonesListTerm.Sort = "RepZoneName";
            // 
            // termNameTextBox
            // 
            resources.ApplyResources(this.termNameTextBox, "termNameTextBox");
            this.termNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTerminal, "TermName", true));
            this.termNameTextBox.Name = "termNameTextBox";
            // 
            // termIpTextBox
            // 
            resources.ApplyResources(this.termIpTextBox, "termIpTextBox");
            this.termIpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTerminal, "TermIp", true));
            this.termIpTextBox.Name = "termIpTextBox";
            // 
            // termPosXTextBox
            // 
            resources.ApplyResources(this.termPosXTextBox, "termPosXTextBox");
            this.termPosXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTerminal, "TermPosX", true));
            this.termPosXTextBox.Name = "termPosXTextBox";
            // 
            // termPosYTextBox
            // 
            resources.ApplyResources(this.termPosYTextBox, "termPosYTextBox");
            this.termPosYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTerminal, "TermPosY", true));
            this.termPosYTextBox.Name = "termPosYTextBox";
            // 
            // tabPageScan
            // 
            resources.ApplyResources(this.tabPageScan, "tabPageScan");
            this.tabPageScan.Controls.Add(scanDataPortLabel);
            this.tabPageScan.Controls.Add(this.scanDataPortTextBox);
            this.tabPageScan.Controls.Add(contPointIdLabel);
            this.tabPageScan.Controls.Add(this.contPointIdComboBox);
            this.tabPageScan.Controls.Add(contIdLabel);
            this.tabPageScan.Controls.Add(this.contIdComboBox);
            this.tabPageScan.Controls.Add(scanNameLabel);
            this.tabPageScan.Controls.Add(this.scanNameTextBox);
            this.tabPageScan.Controls.Add(scanTypeLabel);
            this.tabPageScan.Controls.Add(this.scanTypeComboBox);
            this.tabPageScan.Controls.Add(scanAddressLabel);
            this.tabPageScan.Controls.Add(this.scanAddressTextBox);
            this.tabPageScan.Controls.Add(scanPosXLabel);
            this.tabPageScan.Controls.Add(this.scanPosXTextBox);
            this.tabPageScan.Controls.Add(scanPosYLabel);
            this.tabPageScan.Controls.Add(this.scanPosYTextBox);
            this.tabPageScan.Name = "tabPageScan";
            this.tabPageScan.UseVisualStyleBackColor = true;
            // 
            // scanDataPortTextBox
            // 
            resources.ApplyResources(this.scanDataPortTextBox, "scanDataPortTextBox");
            this.scanDataPortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsScaner, "ScanDataPort", true));
            this.scanDataPortTextBox.Name = "scanDataPortTextBox";
            // 
            // bsScaner
            // 
            this.bsScaner.DataMember = "Scaner";
            this.bsScaner.DataSource = this.dsMain;
            this.bsScaner.Sort = "ScanName";
            // 
            // contPointIdComboBox
            // 
            resources.ApplyResources(this.contPointIdComboBox, "contPointIdComboBox");
            this.contPointIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsScaner, "ContPointId", true));
            this.contPointIdComboBox.DataSource = this.bsContPointsListScan;
            this.contPointIdComboBox.DisplayMember = "ContPointName";
            this.contPointIdComboBox.FormattingEnabled = true;
            this.contPointIdComboBox.Name = "contPointIdComboBox";
            this.contPointIdComboBox.ValueMember = "ContPointId";
            // 
            // bsContPointsListScan
            // 
            this.bsContPointsListScan.DataMember = "ControlPoint";
            this.bsContPointsListScan.DataSource = this.dsMain;
            this.bsContPointsListScan.Sort = "ContPointName";
            // 
            // contIdComboBox
            // 
            resources.ApplyResources(this.contIdComboBox, "contIdComboBox");
            this.contIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsScaner, "ContId", true));
            this.contIdComboBox.DataSource = this.bsControllersListScan;
            this.contIdComboBox.DisplayMember = "ContName";
            this.contIdComboBox.FormattingEnabled = true;
            this.contIdComboBox.Name = "contIdComboBox";
            this.contIdComboBox.ValueMember = "ContId";
            // 
            // bsControllersListScan
            // 
            this.bsControllersListScan.DataMember = "Controller";
            this.bsControllersListScan.DataSource = this.dsMain;
            this.bsControllersListScan.Sort = "ContName";
            // 
            // scanNameTextBox
            // 
            resources.ApplyResources(this.scanNameTextBox, "scanNameTextBox");
            this.scanNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsScaner, "ScanName", true));
            this.scanNameTextBox.Name = "scanNameTextBox";
            // 
            // scanTypeComboBox
            // 
            resources.ApplyResources(this.scanTypeComboBox, "scanTypeComboBox");
            this.scanTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsScaner, "ScanType", true));
            this.scanTypeComboBox.DataSource = this.bsTypesScan;
            this.scanTypeComboBox.DisplayMember = "Type";
            this.scanTypeComboBox.FormattingEnabled = true;
            this.scanTypeComboBox.Name = "scanTypeComboBox";
            this.scanTypeComboBox.ValueMember = "TypeId";
            // 
            // bsTypesScan
            // 
            this.bsTypesScan.DataMember = "DeviceType";
            this.bsTypesScan.DataSource = this.dsMain;
            this.bsTypesScan.Filter = "";
            this.bsTypesScan.Sort = "Type";
            // 
            // scanAddressTextBox
            // 
            resources.ApplyResources(this.scanAddressTextBox, "scanAddressTextBox");
            this.scanAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsScaner, "ScanAddress", true));
            this.scanAddressTextBox.Name = "scanAddressTextBox";
            // 
            // scanPosXTextBox
            // 
            resources.ApplyResources(this.scanPosXTextBox, "scanPosXTextBox");
            this.scanPosXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsScaner, "ScanPosX", true));
            this.scanPosXTextBox.Name = "scanPosXTextBox";
            // 
            // scanPosYTextBox
            // 
            resources.ApplyResources(this.scanPosYTextBox, "scanPosYTextBox");
            this.scanPosYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsScaner, "ScanPosY", true));
            this.scanPosYTextBox.Name = "scanPosYTextBox";
            // 
            // tabPageLock
            // 
            this.tabPageLock.Controls.Add(locIdLabel);
            this.tabPageLock.Controls.Add(this.locIdTextBox);
            this.tabPageLock.Controls.Add(contIdLabel1);
            this.tabPageLock.Controls.Add(this.contIdComboBox1);
            this.tabPageLock.Controls.Add(contPointIdLabel1);
            this.tabPageLock.Controls.Add(this.contPointIdComboBox1);
            this.tabPageLock.Controls.Add(locTypeLabel);
            this.tabPageLock.Controls.Add(this.locTypeComboBox);
            this.tabPageLock.Controls.Add(locAddressLabel);
            this.tabPageLock.Controls.Add(this.locAddressTextBox);
            resources.ApplyResources(this.tabPageLock, "tabPageLock");
            this.tabPageLock.Name = "tabPageLock";
            this.tabPageLock.UseVisualStyleBackColor = true;
            // 
            // locIdTextBox
            // 
            resources.ApplyResources(this.locIdTextBox, "locIdTextBox");
            this.locIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLocker, "LocId", true));
            this.locIdTextBox.Name = "locIdTextBox";
            this.locIdTextBox.ReadOnly = true;
            // 
            // bsLocker
            // 
            this.bsLocker.DataMember = "Locker";
            this.bsLocker.DataSource = this.dsMain;
            this.bsLocker.Sort = "LocId";
            // 
            // contIdComboBox1
            // 
            resources.ApplyResources(this.contIdComboBox1, "contIdComboBox1");
            this.contIdComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsLocker, "ContId", true));
            this.contIdComboBox1.DataSource = this.bsControllersListLock;
            this.contIdComboBox1.DisplayMember = "ContName";
            this.contIdComboBox1.FormattingEnabled = true;
            this.contIdComboBox1.Name = "contIdComboBox1";
            this.contIdComboBox1.ValueMember = "ContId";
            // 
            // bsControllersListLock
            // 
            this.bsControllersListLock.DataMember = "Controller";
            this.bsControllersListLock.DataSource = this.dsMain;
            this.bsControllersListLock.Sort = "ContName";
            // 
            // contPointIdComboBox1
            // 
            resources.ApplyResources(this.contPointIdComboBox1, "contPointIdComboBox1");
            this.contPointIdComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsLocker, "ContPointId", true));
            this.contPointIdComboBox1.DataSource = this.bsContPointsListLoc;
            this.contPointIdComboBox1.DisplayMember = "ContPointName";
            this.contPointIdComboBox1.FormattingEnabled = true;
            this.contPointIdComboBox1.Name = "contPointIdComboBox1";
            this.contPointIdComboBox1.ValueMember = "ContPointId";
            // 
            // bsContPointsListLoc
            // 
            this.bsContPointsListLoc.DataMember = "ControlPoint";
            this.bsContPointsListLoc.DataSource = this.dsMain;
            this.bsContPointsListLoc.Sort = "ContPointName";
            // 
            // locTypeComboBox
            // 
            resources.ApplyResources(this.locTypeComboBox, "locTypeComboBox");
            this.locTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsLocker, "LocType", true));
            this.locTypeComboBox.DataSource = this.bsTypesLock;
            this.locTypeComboBox.DisplayMember = "Type";
            this.locTypeComboBox.FormattingEnabled = true;
            this.locTypeComboBox.Name = "locTypeComboBox";
            this.locTypeComboBox.ValueMember = "TypeId";
            // 
            // bsTypesLock
            // 
            this.bsTypesLock.DataMember = "DeviceType";
            this.bsTypesLock.DataSource = this.dsMain;
            this.bsTypesLock.Filter = "";
            this.bsTypesLock.Sort = "Type";
            // 
            // locAddressTextBox
            // 
            resources.ApplyResources(this.locAddressTextBox, "locAddressTextBox");
            this.locAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLocker, "LocAddress", true));
            this.locAddressTextBox.Name = "locAddressTextBox";
            // 
            // tabPageSens
            // 
            this.tabPageSens.Controls.Add(sensIdLabel);
            this.tabPageSens.Controls.Add(this.sensIdTextBox);
            this.tabPageSens.Controls.Add(contPointIdLabel2);
            this.tabPageSens.Controls.Add(this.contPointIdComboBox2);
            this.tabPageSens.Controls.Add(contIdLabel2);
            this.tabPageSens.Controls.Add(this.contIdComboBox2);
            this.tabPageSens.Controls.Add(sensTypeLabel);
            this.tabPageSens.Controls.Add(this.sensTypeComboBox);
            this.tabPageSens.Controls.Add(sensAddressLabel);
            this.tabPageSens.Controls.Add(this.sensAddressTextBox);
            resources.ApplyResources(this.tabPageSens, "tabPageSens");
            this.tabPageSens.Name = "tabPageSens";
            this.tabPageSens.UseVisualStyleBackColor = true;
            // 
            // sensIdTextBox
            // 
            resources.ApplyResources(this.sensIdTextBox, "sensIdTextBox");
            this.sensIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSensor, "SensId", true));
            this.sensIdTextBox.Name = "sensIdTextBox";
            this.sensIdTextBox.ReadOnly = true;
            // 
            // bsSensor
            // 
            this.bsSensor.DataMember = "Sensor";
            this.bsSensor.DataSource = this.dsMain;
            this.bsSensor.Sort = "SensId";
            // 
            // contPointIdComboBox2
            // 
            resources.ApplyResources(this.contPointIdComboBox2, "contPointIdComboBox2");
            this.contPointIdComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsSensor, "ContPointId", true));
            this.contPointIdComboBox2.DataSource = this.bsContPointsListSens;
            this.contPointIdComboBox2.DisplayMember = "ContPointName";
            this.contPointIdComboBox2.FormattingEnabled = true;
            this.contPointIdComboBox2.Name = "contPointIdComboBox2";
            this.contPointIdComboBox2.ValueMember = "ContPointId";
            // 
            // bsContPointsListSens
            // 
            this.bsContPointsListSens.DataMember = "ControlPoint";
            this.bsContPointsListSens.DataSource = this.dsMain;
            this.bsContPointsListSens.Sort = "ContPointName";
            // 
            // contIdComboBox2
            // 
            resources.ApplyResources(this.contIdComboBox2, "contIdComboBox2");
            this.contIdComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsSensor, "ContId", true));
            this.contIdComboBox2.DataSource = this.bsControllersListSens;
            this.contIdComboBox2.DisplayMember = "ContName";
            this.contIdComboBox2.FormattingEnabled = true;
            this.contIdComboBox2.Name = "contIdComboBox2";
            this.contIdComboBox2.ValueMember = "ContId";
            // 
            // bsControllersListSens
            // 
            this.bsControllersListSens.DataMember = "Controller";
            this.bsControllersListSens.DataSource = this.dsMain;
            this.bsControllersListSens.Sort = "ContName";
            // 
            // sensTypeComboBox
            // 
            resources.ApplyResources(this.sensTypeComboBox, "sensTypeComboBox");
            this.sensTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsSensor, "SensType", true));
            this.sensTypeComboBox.DataSource = this.bsTypesSens;
            this.sensTypeComboBox.DisplayMember = "Type";
            this.sensTypeComboBox.FormattingEnabled = true;
            this.sensTypeComboBox.Name = "sensTypeComboBox";
            this.sensTypeComboBox.ValueMember = "TypeId";
            // 
            // bsTypesSens
            // 
            this.bsTypesSens.DataMember = "DeviceType";
            this.bsTypesSens.DataSource = this.dsMain;
            this.bsTypesSens.Filter = "";
            this.bsTypesSens.Sort = "Type";
            // 
            // sensAddressTextBox
            // 
            resources.ApplyResources(this.sensAddressTextBox, "sensAddressTextBox");
            this.sensAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSensor, "SensAddress", true));
            this.sensAddressTextBox.Name = "sensAddressTextBox";
            // 
            // pictureBoxGlyphs1
            // 
            this.pictureBoxGlyphs1.DataSet = this.dsMain;
            resources.ApplyResources(this.pictureBoxGlyphs1, "pictureBoxGlyphs1");
            this.pictureBoxGlyphs1.Glyphs = ((System.Collections.ArrayList)(resources.GetObject("pictureBoxGlyphs1.Glyphs")));
            this.pictureBoxGlyphs1.IsEditable = true;
            this.pictureBoxGlyphs1.IsNameVisible = true;
            this.pictureBoxGlyphs1.IsRelationVisible = true;
            this.pictureBoxGlyphs1.IsStatusVisible = true;
            this.pictureBoxGlyphs1.Name = "pictureBoxGlyphs1";
            this.pictureBoxGlyphs1.PlantBmp = ((System.Drawing.Bitmap)(resources.GetObject("pictureBoxGlyphs1.PlantBmp")));
            this.pictureBoxGlyphs1.TabStop = false;
            this.pictureBoxGlyphs1.GlyphClicked += new PlantConfig.GlyphClickedEventHandler(this.pictureBoxGlyphs1_GlyphClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.справкаToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPlantBitmapToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // openPlantBitmapToolStripMenuItem
            // 
            this.openPlantBitmapToolStripMenuItem.Name = "openPlantBitmapToolStripMenuItem";
            resources.ApplyResources(this.openPlantBitmapToolStripMenuItem, "openPlantBitmapToolStripMenuItem");
            this.openPlantBitmapToolStripMenuItem.Click += new System.EventHandler(this.openPlantBitmapToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allowVisualEditToolStripMenuItem,
            this.applyChangesToolStripMenuItem,
            this.rejectChangesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // allowVisualEditToolStripMenuItem
            // 
            this.allowVisualEditToolStripMenuItem.Name = "allowVisualEditToolStripMenuItem";
            resources.ApplyResources(this.allowVisualEditToolStripMenuItem, "allowVisualEditToolStripMenuItem");
            this.allowVisualEditToolStripMenuItem.Click += new System.EventHandler(this.allowVisualEditToolStripMenuItem_Click);
            // 
            // applyChangesToolStripMenuItem
            // 
            this.applyChangesToolStripMenuItem.Name = "applyChangesToolStripMenuItem";
            resources.ApplyResources(this.applyChangesToolStripMenuItem, "applyChangesToolStripMenuItem");
            this.applyChangesToolStripMenuItem.Click += new System.EventHandler(this.applyChangesToolStripMenuItem_Click);
            // 
            // rejectChangesToolStripMenuItem
            // 
            this.rejectChangesToolStripMenuItem.Name = "rejectChangesToolStripMenuItem";
            resources.ApplyResources(this.rejectChangesToolStripMenuItem, "rejectChangesToolStripMenuItem");
            this.rejectChangesToolStripMenuItem.Click += new System.EventHandler(this.rejectChangesToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showNamesToolStripMenuItem,
            this.showStatusesToolStripMenuItem,
            this.showRelationsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // showNamesToolStripMenuItem
            // 
            this.showNamesToolStripMenuItem.Name = "showNamesToolStripMenuItem";
            resources.ApplyResources(this.showNamesToolStripMenuItem, "showNamesToolStripMenuItem");
            this.showNamesToolStripMenuItem.Click += new System.EventHandler(this.showNamesToolStripMenuItem_Click);
            // 
            // showStatusesToolStripMenuItem
            // 
            this.showStatusesToolStripMenuItem.Name = "showStatusesToolStripMenuItem";
            resources.ApplyResources(this.showStatusesToolStripMenuItem, "showStatusesToolStripMenuItem");
            this.showStatusesToolStripMenuItem.Click += new System.EventHandler(this.showStatusesToolStripMenuItem_Click);
            // 
            // showRelationsToolStripMenuItem
            // 
            this.showRelationsToolStripMenuItem.Name = "showRelationsToolStripMenuItem";
            resources.ApplyResources(this.showRelationsToolStripMenuItem, "showRelationsToolStripMenuItem");
            this.showRelationsToolStripMenuItem.Click += new System.EventHandler(this.showRelationsToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            resources.ApplyResources(this.справкаToolStripMenuItem, "справкаToolStripMenuItem");
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            resources.ApplyResources(this.оПрограммеToolStripMenuItem, "оПрограммеToolStripMenuItem");
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // taRepZone
            // 
            this.taRepZone.ClearBeforeFill = true;
            // 
            // taContPoint
            // 
            this.taContPoint.ClearBeforeFill = true;
            // 
            // taController
            // 
            this.taController.ClearBeforeFill = true;
            // 
            // taTerminal
            // 
            this.taTerminal.ClearBeforeFill = true;
            // 
            // taScaner
            // 
            this.taScaner.ClearBeforeFill = true;
            // 
            // taLocker
            // 
            this.taLocker.ClearBeforeFill = true;
            // 
            // taSensor
            // 
            this.taSensor.ClearBeforeFill = true;
            // 
            // taPlant
            // 
            this.taPlant.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageRz.ResumeLayout(false);
            this.tabPageRz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRepZone)).EndInit();
            this.tabPageCp.ResumeLayout(false);
            this.tabPageCp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsContPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRepZonesListContPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypesContPoint)).EndInit();
            this.tabPageCont.ResumeLayout(false);
            this.tabPageCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsController)).EndInit();
            this.tabPageTerm.ResumeLayout(false);
            this.tabPageTerm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRepZonesListTerm)).EndInit();
            this.tabPageScan.ResumeLayout(false);
            this.tabPageScan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsScaner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContPointsListScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsControllersListScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypesScan)).EndInit();
            this.tabPageLock.ResumeLayout(false);
            this.tabPageLock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsControllersListLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContPointsListLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypesLock)).EndInit();
            this.tabPageSens.ResumeLayout(false);
            this.tabPageSens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContPointsListSens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsControllersListSens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypesSens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlyphs1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPlantBitmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRz;
        private System.Windows.Forms.TabPage tabPageCp;
        private System.Windows.Forms.TabPage tabPageCont;
        private System.Windows.Forms.TabPage tabPageTerm;
        private System.Windows.Forms.TabPage tabPageScan;
        private System.Windows.Forms.TabPage tabPageLock;
        private System.Windows.Forms.TabPage tabPageSens;
        private ReworksDataSet dsMain;
        private System.Windows.Forms.BindingSource bsRepZone;
        private PlantConfig.ReworksDataSetTableAdapters.RepairZoneTableAdapter taRepZone;
        private System.Windows.Forms.TextBox repZoneNameTextBox;
        private System.Windows.Forms.TextBox repZoneNameEngTextBox;
        private System.Windows.Forms.TextBox repZonePosX1TextBox;
        private System.Windows.Forms.TextBox repZonePosY1TextBox;
        private System.Windows.Forms.TextBox repZonePosX2TextBox;
        private System.Windows.Forms.TextBox repZonePosY2TextBox;
        private System.Windows.Forms.BindingSource bsContPoint;
        private PlantConfig.ReworksDataSetTableAdapters.ControlPointTableAdapter taContPoint;
        private System.Windows.Forms.ComboBox repZoneIdComboBox;
        private System.Windows.Forms.TextBox contPointNameTextBox;
        private System.Windows.Forms.ComboBox contPointTypeComboBox;
        private System.Windows.Forms.BindingSource bsController;
        private PlantConfig.ReworksDataSetTableAdapters.ControllerTableAdapter taController;
        private System.Windows.Forms.TextBox contNameTextBox;
        private System.Windows.Forms.TextBox contIpTextBox;
        private System.Windows.Forms.TextBox contPosXTextBox;
        private System.Windows.Forms.TextBox contPosYTextBox;
        private System.Windows.Forms.TextBox inputCoilStartAddressTextBox;
        private System.Windows.Forms.TextBox inputCoilUnitCountTextBox;
        private System.Windows.Forms.TextBox outputCoilStartAddressTextBox;
        private System.Windows.Forms.TextBox outputCoilUnitCountTextBox;
        private System.Windows.Forms.BindingSource bsTerminal;
        private PlantConfig.ReworksDataSetTableAdapters.TerminalTableAdapter taTerminal;
        private System.Windows.Forms.ComboBox repZoneIdComboBox1;
        private System.Windows.Forms.TextBox termNameTextBox;
        private System.Windows.Forms.TextBox termIpTextBox;
        private System.Windows.Forms.TextBox termPosXTextBox;
        private System.Windows.Forms.TextBox termPosYTextBox;
        private System.Windows.Forms.BindingSource bsScaner;
        private PlantConfig.ReworksDataSetTableAdapters.ScanerTableAdapter taScaner;
        private System.Windows.Forms.ComboBox contPointIdComboBox;
        private System.Windows.Forms.ComboBox contIdComboBox;
        private System.Windows.Forms.TextBox scanNameTextBox;
        private System.Windows.Forms.ComboBox scanTypeComboBox;
        private System.Windows.Forms.TextBox scanAddressTextBox;
        private System.Windows.Forms.TextBox scanPosXTextBox;
        private System.Windows.Forms.TextBox scanPosYTextBox;
        private System.Windows.Forms.BindingSource bsLocker;
        private PlantConfig.ReworksDataSetTableAdapters.LockerTableAdapter taLocker;
        private System.Windows.Forms.ComboBox contIdComboBox1;
        private System.Windows.Forms.ComboBox contPointIdComboBox1;
        private System.Windows.Forms.ComboBox locTypeComboBox;
        private System.Windows.Forms.TextBox locAddressTextBox;
        private System.Windows.Forms.BindingSource bsSensor;
        private PlantConfig.ReworksDataSetTableAdapters.SensorTableAdapter taSensor;
        private System.Windows.Forms.ComboBox contPointIdComboBox2;
        private System.Windows.Forms.ComboBox contIdComboBox2;
        private System.Windows.Forms.ComboBox sensTypeComboBox;
        private System.Windows.Forms.TextBox sensAddressTextBox;
        private PlantConfig.ReworksDataSetTableAdapters.PlantTableAdapter taPlant;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allowVisualEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStatusesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRelationsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem applyChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejectChangesToolStripMenuItem;
        private PictureBoxGlyphs pictureBoxGlyphs1;
        private System.Windows.Forms.ImageList imageList1;
        private RewTreeView rewTreeView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.BindingSource bsRepZonesListContPoint;
        private System.Windows.Forms.BindingSource bsContPointsListScan;
        private System.Windows.Forms.BindingSource bsControllersListScan;
        private System.Windows.Forms.BindingSource bsRepZonesListTerm;
        private System.Windows.Forms.BindingSource bsControllersListLock;
        private System.Windows.Forms.BindingSource bsContPointsListLoc;
        private System.Windows.Forms.BindingSource bsContPointsListSens;
        private System.Windows.Forms.BindingSource bsControllersListSens;
        private System.Windows.Forms.TextBox locIdTextBox;
        private System.Windows.Forms.TextBox sensIdTextBox;
        private System.Windows.Forms.BindingSource bsTypesContPoint;
        private System.Windows.Forms.BindingSource bsTypesScan;
        private System.Windows.Forms.BindingSource bsTypesLock;
        private System.Windows.Forms.BindingSource bsTypesSens;
        private System.Windows.Forms.ComboBox termModeComboBox;
        private System.Windows.Forms.TextBox termIdTextBox;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TextBox scanDataPortTextBox;
    }
}