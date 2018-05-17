using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Resources;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Threading;

namespace PlantConfig
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LogonForm logonForm = new LogonForm();
            if (logonForm.ShowDialog() == DialogResult.OK)
                Application.Run(new MainForm(logonForm.conn));
        }
    }
    public enum GlyphStatus
    {
        On, Off
    }
    public enum GlyphType
    {
        RepZone, Controller, Terminal, Scaner
    }
    public enum GlyphPointType
    {
        None, Default, LeftLower, LeftUpper, RightLower, RightUpper
    }
    public class Glyph
    {
        public decimal id;
        public string name;
        public ArrayList children;
        public GlyphStatus status;
        public GlyphType type;
        public bool isSelected = false;
        public int xPos, yPos;
        public Bitmap bmp;
        public static Bitmap errorBmp = Properties.Resources.Error;
        public static Bitmap selected = Properties.Resources.Selected;
        public virtual void Draw(Graphics g,
            bool isStatusVisible, bool isNameVisible)
        {
            int xDr = xPos - bmp.Width / 2;
            int yDr = yPos - bmp.Height / 2;
            Brush b;
            if (isSelected)
            {
                b = Brushes.Green;
                float[][] matrixItems =
                { 
                    new float[] {0.6f, 0, 0, 0, 0},
                    new float[] {0, 0.6f, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, 1, 0}, 
                    new float[] {0, 0, 0, 0, 1}
                };
                ColorMatrix cMatr = new ColorMatrix(matrixItems);
                ImageAttributes imAttr = new ImageAttributes();
                imAttr.SetColorMatrix(cMatr);
                Rectangle destRect = new Rectangle(xDr, yDr, bmp.Width, bmp.Height);
                g.DrawImage(bmp, destRect, 0, 0,
                    bmp.Width, bmp.Height, GraphicsUnit.Pixel, imAttr);

                float[][] matrixItems2 =
                { 
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, 0.5f, 0}, 
                    new float[] {0, 0, 0, 0, 1}
                };
                cMatr = new ColorMatrix(matrixItems2);
                selected.MakeTransparent(Color.Magenta);
                imAttr = new ImageAttributes();
                imAttr.SetColorMatrix(cMatr);
                destRect = new Rectangle(xDr, yDr,
                    errorBmp.Width, errorBmp.Height);
                g.DrawImage(selected, destRect, 0, 0,
                    errorBmp.Width, errorBmp.Height, GraphicsUnit.Pixel, imAttr);
            }
            else
            {
                b = Brushes.Black;
                g.DrawImage(bmp, xDr, yDr);
            }
            if (isStatusVisible && status == GlyphStatus.Off)
            {
                float[][] matrixItems =
                { 
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, 0.5f, 0}, 
                    new float[] {0, 0, 0, 0, 1}
                };
                ColorMatrix cMatr = new ColorMatrix(matrixItems);
                errorBmp.MakeTransparent(Color.Magenta);
                ImageAttributes imAttr = new ImageAttributes();
                imAttr.SetColorMatrix(cMatr);
                Rectangle destRect = new Rectangle(xDr, yDr,
                    errorBmp.Width, errorBmp.Height);
                g.DrawImage(errorBmp, destRect, 0, 0,
                    errorBmp.Width, errorBmp.Height, GraphicsUnit.Pixel, imAttr);
            }
            if (isNameVisible)
            {
                int epsilon = 15;
                yDr += bmp.Height;
                RectangleF r = new Rectangle(xDr - epsilon, yDr, bmp.Width + 2 * epsilon, 26);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Near;
                Font f = new Font("Arial", 8);
                g.DrawString(this.name, f, b, r, sf);
            }
        }
        public virtual GlyphPointType HitTest(int x, int y)
        {
            int xDr = xPos - bmp.Width / 2;
            int yDr = yPos - bmp.Height / 2;
            if (x >= xDr && x < xDr + bmp.Width &&
                y >= yDr && y < yDr + bmp.Height &&
                bmp.GetPixel(x - xDr, y - yDr) !=
                Color.FromArgb(0, 0, 0, 0))
                return GlyphPointType.Default;
            return GlyphPointType.None;
        }
        public virtual Size GetSize()
        {
            return bmp.Size;
        }
        public virtual void SetSize(int width, int height) { }
        public virtual void UpdateDataSet(ReworksDataSet ds) { }
    }
    public class RepZoneGlyph : Glyph
    {
        public Size size;
        public RepZoneGlyph(ReworksDataSet.RepairZoneRow r)
        {
            this.id = r.RepZoneId;
            this.name = r.RepZoneName;
            this.children = null;
            this.status = GlyphStatus.On;
            this.type = GlyphType.RepZone;
            this.xPos = (int)r.RepZonePosX1;
            this.yPos = (int)r.RepZonePosY1;
            this.size.Width = (int)(r.RepZonePosX2 - r.RepZonePosX1);
            this.size.Height = (int)(r.RepZonePosY2 - r.RepZonePosY1);
            this.bmp = null;
        }
        public override void Draw(Graphics g,
            bool isStatusVisible, bool isNameVisible)
        {
            Pen p;
            Brush b;
            if (isSelected)
            {
                p = new Pen(Color.Green, 2);
                b = Brushes.Green;
                int epsilon = 4;
                Rectangle[] arrRect = 
                {
                    new Rectangle(xPos - epsilon / 2, yPos - epsilon / 2,
                    epsilon, epsilon),
                    new Rectangle(xPos - epsilon / 2, yPos + size.Height - epsilon / 2,
                    epsilon, epsilon),
                    new Rectangle(xPos + size.Width - epsilon / 2, yPos - epsilon / 2,
                    epsilon, epsilon),
                    new Rectangle(xPos + size.Width - epsilon / 2, yPos + size.Height - epsilon / 2,
                    epsilon, epsilon),
                };
                g.FillRectangles(b, arrRect);
            }
            else
            {
                p = new Pen(Color.Black, 1);
                b = Brushes.Black;
            }
            g.DrawRectangle(p, xPos, yPos, size.Width, size.Height);
            if (isNameVisible)
                g.DrawString(name, new Font("Arial", 8), b, xPos, yPos);
        }
        public override GlyphPointType HitTest(int x, int y)
        {
            int epsilon1 = 2, epsilon2 = 4;
            if (x >= xPos - epsilon1 && x <= xPos + epsilon1 &&
                y >= yPos - epsilon1 && y <= yPos + epsilon1)
                return GlyphPointType.LeftUpper;
            if (x >= xPos - epsilon1 && x <= xPos + epsilon1 &&
                y >= yPos + size.Height - epsilon1 && y <= yPos + size.Height + epsilon1)
                return GlyphPointType.LeftLower;
            if (x >= xPos + size.Width - epsilon1 && x <= xPos + size.Width + epsilon1 &&
                y >= yPos - epsilon1 && y <= yPos + epsilon1)
                return GlyphPointType.RightUpper;
            if (x >= xPos + size.Width - epsilon1 && x <= xPos + size.Width + epsilon1 &&
                y >= yPos + size.Height - epsilon1 && y <= yPos + size.Height + epsilon1)
                return GlyphPointType.RightLower;

            if (x >= xPos && x <= xPos + size.Width &&
                y >= yPos && y <= yPos + size.Height &&
                (x >= xPos && x <= xPos + epsilon2 ||
                y >= yPos && y <= yPos + epsilon2 ||
                x >= xPos + size.Width - epsilon2 && x <= xPos + size.Width ||
                y >= yPos + size.Height - epsilon2 && y <= yPos + size.Height))
                return GlyphPointType.Default;
            return GlyphPointType.None;
        }
        public override Size GetSize()
        {
            return size;
        }
        public override void SetSize(int width, int height)
        {
            size.Width = width;
            size.Height = height;
            if (width < 1) size.Width = 1;
            if (height < 1) size.Height = 1;
        }
        public override void UpdateDataSet(ReworksDataSet ds)
        {
            ReworksDataSet.RepairZoneRow r =
                ds.RepairZone.FindByRepZoneId(id);
            r.RepZonePosX1 = xPos;
            r.RepZonePosY1 = yPos;
            r.RepZonePosX2 = xPos + size.Width;
            r.RepZonePosY2 = yPos + size.Height;
        }
    }
    public class ContGlyph : Glyph
    {
        public ContGlyph(ReworksDataSet.ControllerRow r)
        {
            this.id = r.ContId;
            this.name = r.ContName;
            this.children = null;
            this.status = GlyphStatus.On;
            this.type = GlyphType.Controller;
            this.xPos = (int)r.ContPosX;
            this.yPos = (int)r.ContPosY;
            this.bmp = Properties.Resources.Controller;
            this.bmp.MakeTransparent(Color.Magenta);
        }
        public override void UpdateDataSet(ReworksDataSet ds)
        {
            ReworksDataSet.ControllerRow r =
                ds.Controller.FindByContId(id);
            r.ContPosX = xPos;
            r.ContPosY = yPos;
        }
    }
    public class TermGlyph : Glyph
    {
        public TermGlyph(ReworksDataSet.TerminalRow r)
        {
            this.id = r.TermId;
            this.name = r.TermName;
            this.children = null;
            this.status = GlyphStatus.On;
            this.type = GlyphType.Terminal;
            this.xPos = (int)r.TermPosX;
            this.yPos = (int)r.TermPosY;
            this.bmp = Properties.Resources.Terminal;
            this.bmp.MakeTransparent(Color.Magenta);
        }
        public override void UpdateDataSet(ReworksDataSet ds)
        {
            ReworksDataSet.TerminalRow r =
                ds.Terminal.FindByTermId(id);
            r.TermPosX = xPos;
            r.TermPosY = yPos;
        }
    }
    public class ScanGlyph : Glyph
    {
        public ScanGlyph(ReworksDataSet.ScanerRow r)
        {
            this.id = r.ScanId;
            this.name = r.ScanName;
            this.children = null;
            this.status = GlyphStatus.On;
            this.type = GlyphType.Scaner;
            this.xPos = (int)r.ScanPosX;
            this.yPos = (int)r.ScanPosY;
            this.bmp = Properties.Resources.Scaner;
            this.bmp.MakeTransparent(Color.Magenta);
        }
        public override void UpdateDataSet(ReworksDataSet ds)
        {
            ReworksDataSet.ScanerRow r =
                ds.Scaner.FindByScanId(id);
            r.ScanPosX = xPos;
            r.ScanPosY = yPos;
        }
    }
    public class GlyphsLoader
    {
        ReworksDataSet ds;
        public GlyphsLoader(ReworksDataSet ds)
        {
            this.ds = ds;
        }
        public ArrayList LoadItems(decimal plantId)
        {
            ArrayList res = new ArrayList();
            ReworksDataSet.PlantRow pRow = ds.Plant.FindByPlantId(plantId);
            ReworksDataSet.RepairZoneRow[] rzRows =
                pRow.GetRepairZoneRows();
            foreach (ReworksDataSet.RepairZoneRow rzRow in rzRows)
            {
                Glyph rz = new RepZoneGlyph(rzRow);
                ArrayList children = new ArrayList();
                ReworksDataSet.TerminalRow[] tRows =
                    rzRow.GetTerminalRows();
                foreach (ReworksDataSet.TerminalRow tRow in tRows)
                {
                    Glyph term = new TermGlyph(tRow);
                    res.Add(term);
                    children.Add(term);
                }
                ReworksDataSet.ControlPointRow[] cpRows =
                    rzRow.GetControlPointRows();
                foreach (ReworksDataSet.ControlPointRow cpRow in cpRows)
                {
                    ReworksDataSet.ScanerRow[] sRows =
                        cpRow.GetScanerRows();
                    foreach (ReworksDataSet.ScanerRow sRow in sRows)
                    {
                        Glyph scan = new ScanGlyph(sRow);
                        res.Add(scan);
                        children.Add(scan);
                    }
                }
                rz.children = children;
                res.Add(rz);
            }

            ReworksDataSet.ControllerRow[] cRows =
                pRow.GetControllerRows();
            foreach (ReworksDataSet.ControllerRow cRow in cRows)
            {
                Glyph cont = new ContGlyph(cRow);
                cont.children = new ArrayList();
                res.Add(cont);
                ReworksDataSet.ScanerRow[] sRows =
                    cRow.GetScanerRows();
                foreach (ReworksDataSet.ScanerRow sRow in sRows)
                    foreach (Glyph g in res)
                        if (g.type == GlyphType.Scaner && g.id == sRow.ScanId)
                        {
                            cont.children.Add(g);
                            break;
                        }
            }
            return res;
        }
    }
}