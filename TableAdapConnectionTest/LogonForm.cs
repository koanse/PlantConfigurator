using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Threading;

namespace PlantConfig
{
    public partial class LogonForm : Form
    {
        public OracleConnection conn;
        public LogonForm()
        {
            InitializeComponent();
            this.textBox1.Text = Properties.Settings.Default.ServerName;
            this.textBox2.Text = Properties.Settings.Default.UserName;
            this.listBox1.SelectedItem = Properties.Settings.Default.Language;
            DialogResult = DialogResult.Cancel;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source = " + textBox1.Text +
                " ;Persist Security Info=True;User ID = " +
                textBox2.Text + "; Password = " + textBox3.Text +
                ";Unicode=True";
            this.Text = "REWORKS System - Plant Configurator [connecting...]";
            this.Refresh();
            conn = new OracleConnection(connStr);
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Cannot connect to database", "Database connection error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Text = "REWORKS System - Plant Configurator [logon]";
                return;
            }
            DialogResult = DialogResult.OK;
            if ((string)listBox1.SelectedItem == "Russian")
            {
                Thread.CurrentThread.CurrentCulture =
                    new System.Globalization.CultureInfo("ru-RU");
                Thread.CurrentThread.CurrentUICulture =
                        new System.Globalization.CultureInfo("ru-RU");
            }
            else
            {
                Thread.CurrentThread.CurrentCulture =
                    new System.Globalization.CultureInfo("en-US");
                Thread.CurrentThread.CurrentUICulture =
                        new System.Globalization.CultureInfo("en-US");
            }
            this.Text = "REWORKS System - Plant Configurator [initializing...]";
            this.Refresh();
            Properties.Settings.Default.ServerName = textBox1.Text;
            Properties.Settings.Default.UserName = textBox2.Text;
            Properties.Settings.Default.Language = (string)listBox1.SelectedItem;
            Properties.Settings.Default.Save();
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}