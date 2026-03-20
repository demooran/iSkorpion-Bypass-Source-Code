using System.Diagnostics;
using System.Windows.Forms;

namespace iSkorpionAiO_RE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.iOSLBL = new System.Windows.Forms.Label();
            this.JBLBL = new System.Windows.Forms.Label();
            this.ActLBL = new System.Windows.Forms.Label();
            this.ProdLBL = new System.Windows.Forms.Label();
            this.ModelLBL = new System.Windows.Forms.Label();
            this.IMEILBL = new System.Windows.Forms.Label();
            this.SNLBL = new System.Windows.Forms.Label();
            this.ECIDLBL = new System.Windows.Forms.Label();
            this.UDIDLBL = new System.Windows.Forms.Label();
            this.BATTLBL = new System.Windows.Forms.Label();
            this.DiskLBL = new System.Windows.Forms.Label();
            this.NameLBL = new System.Windows.Forms.Label();
            this.DriversBTN = new Guna.UI2.WinForms.Guna2Button();
            this.CPIDLBL = new System.Windows.Forms.Label();
            this.BDIDLBL = new System.Windows.Forms.Label();
            this.MODELBL = new System.Windows.Forms.Label();
            this.TestModeBTN = new Guna.UI2.WinForms.Guna2Button();
            this.PWNDFUBTN = new Guna.UI2.WinForms.Guna2Button();
            this.MDMBTN = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConnectSSHBTN = new Guna.UI2.WinForms.Guna2Button();
            this.PWNMan = new Guna.UI2.WinForms.Guna2Button();
            this.BackupRD = new Guna.UI2.WinForms.Guna2Button();
            this.ManBootBTN = new Guna.UI2.WinForms.Guna2Button();
            this.ExitRamdiskBTN = new Guna.UI2.WinForms.Guna2Button();
            this.EraseBTNR = new Guna.UI2.WinForms.Guna2Button();
            this.LogoutBTNR = new Guna.UI2.WinForms.Guna2Button();
            this.PasscodeBTNR = new Guna.UI2.WinForms.Guna2Button();
            this.HelloBTNR = new Guna.UI2.WinForms.Guna2Button();
            this.GSMBTN = new Guna.UI2.WinForms.Guna2Button();
            this.PasscodeActBTNJ = new Guna.UI2.WinForms.Guna2Button();
            this.DisableBBJ = new Guna.UI2.WinForms.Guna2Button();
            this.EnableBBJ = new Guna.UI2.WinForms.Guna2Button();
            this.LogoutBTNJ = new Guna.UI2.WinForms.Guna2Button();
            this.EraseBTNJ = new Guna.UI2.WinForms.Guna2Button();
            this.PatchBTN = new Guna.UI2.WinForms.Guna2Button();
            this.BrokenBBJ = new Guna.UI2.WinForms.Guna2Button();
            this.PasscodeBackBTNJ = new Guna.UI2.WinForms.Guna2Button();
            this.HelloBTNJ = new Guna.UI2.WinForms.Guna2Button();
            this.BuildLBL = new System.Windows.Forms.Label();
            this.HardLBL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RamFolder = new Guna.UI2.WinForms.Guna2Button();
            this.BackupsBTN = new Guna.UI2.WinForms.Guna2Button();
            this.BackupDown = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.button2 = new Guna.UI2.WinForms.Guna2Button();
            this.button3 = new Guna.UI2.WinForms.Guna2Button();
            this.button4 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReadBTN = new Guna.UI2.WinForms.Guna2Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblTotalBytesReceived = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.UCIDLBL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.HeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.InfoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.RegionLBL = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBoxDC = new System.Windows.Forms.PictureBox();
            this.StorageBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.progressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.ActivateButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2Button();
            this.RamdiskPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.AirPlaneMode = new Guna.UI2.WinForms.Guna2CheckBox();
            this.RD17 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RD16 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RD15 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.JailbreakPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.JB1518 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.JB1214 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.ToolsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.MDMPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.A12Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.SkipSX = new Guna.UI2.WinForms.Guna2CheckBox();
            this.AutoOTA = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.status2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.A12B = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MDMB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.RamdiskB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.JailbreakB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ToolBoxB = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FooterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDC)).BeginInit();
            this.RamdiskPanel.SuspendLayout();
            this.JailbreakPanel.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.MDMPanel.SuspendLayout();
            this.A12Panel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // iOSLBL
            // 
            this.iOSLBL.AutoSize = true;
            this.iOSLBL.BackColor = System.Drawing.Color.Transparent;
            this.iOSLBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.iOSLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.iOSLBL.Location = new System.Drawing.Point(429, 67);
            this.iOSLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iOSLBL.Name = "iOSLBL";
            this.iOSLBL.Size = new System.Drawing.Size(24, 15);
            this.iOSLBL.TabIndex = 2;
            this.iOSLBL.Text = "NA";
            // 
            // JBLBL
            // 
            this.JBLBL.AutoSize = true;
            this.JBLBL.BackColor = System.Drawing.Color.Transparent;
            this.JBLBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.JBLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.JBLBL.Location = new System.Drawing.Point(429, 14);
            this.JBLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JBLBL.Name = "JBLBL";
            this.JBLBL.Size = new System.Drawing.Size(24, 15);
            this.JBLBL.TabIndex = 3;
            this.JBLBL.Text = "NA";
            // 
            // ActLBL
            // 
            this.ActLBL.AutoSize = true;
            this.ActLBL.BackColor = System.Drawing.Color.Transparent;
            this.ActLBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ActLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ActLBL.Location = new System.Drawing.Point(429, 120);
            this.ActLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActLBL.Name = "ActLBL";
            this.ActLBL.Size = new System.Drawing.Size(24, 15);
            this.ActLBL.TabIndex = 4;
            this.ActLBL.Text = "NA";
            // 
            // ProdLBL
            // 
            this.ProdLBL.AutoSize = true;
            this.ProdLBL.BackColor = System.Drawing.Color.Transparent;
            this.ProdLBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ProdLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ProdLBL.Location = new System.Drawing.Point(429, 95);
            this.ProdLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProdLBL.Name = "ProdLBL";
            this.ProdLBL.Size = new System.Drawing.Size(24, 15);
            this.ProdLBL.TabIndex = 5;
            this.ProdLBL.Text = "NA";
            // 
            // ModelLBL
            // 
            this.ModelLBL.AutoSize = true;
            this.ModelLBL.BackColor = System.Drawing.Color.Transparent;
            this.ModelLBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ModelLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ModelLBL.Location = new System.Drawing.Point(897, 313);
            this.ModelLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModelLBL.Name = "ModelLBL";
            this.ModelLBL.Size = new System.Drawing.Size(24, 15);
            this.ModelLBL.TabIndex = 6;
            this.ModelLBL.Text = "NA";
            // 
            // IMEILBL
            // 
            this.IMEILBL.AutoSize = true;
            this.IMEILBL.BackColor = System.Drawing.Color.Transparent;
            this.IMEILBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.IMEILBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.IMEILBL.Location = new System.Drawing.Point(200, 92);
            this.IMEILBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IMEILBL.Name = "IMEILBL";
            this.IMEILBL.Size = new System.Drawing.Size(24, 15);
            this.IMEILBL.TabIndex = 7;
            this.IMEILBL.Text = "NA";
            // 
            // SNLBL
            // 
            this.SNLBL.AutoSize = true;
            this.SNLBL.BackColor = System.Drawing.Color.Transparent;
            this.SNLBL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SNLBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.SNLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.SNLBL.Location = new System.Drawing.Point(200, 38);
            this.SNLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SNLBL.Name = "SNLBL";
            this.SNLBL.Size = new System.Drawing.Size(24, 15);
            this.SNLBL.TabIndex = 8;
            this.SNLBL.Text = "NA";
            this.SNLBL.Click += new System.EventHandler(this.SNLBL_Click);
            // 
            // ECIDLBL
            // 
            this.ECIDLBL.AutoSize = true;
            this.ECIDLBL.BackColor = System.Drawing.Color.Transparent;
            this.ECIDLBL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ECIDLBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.ECIDLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.ECIDLBL.Location = new System.Drawing.Point(200, 68);
            this.ECIDLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ECIDLBL.Name = "ECIDLBL";
            this.ECIDLBL.Size = new System.Drawing.Size(24, 15);
            this.ECIDLBL.TabIndex = 9;
            this.ECIDLBL.Text = "NA";
            this.ECIDLBL.Click += new System.EventHandler(this.ECIDLBL_Click);
            // 
            // UDIDLBL
            // 
            this.UDIDLBL.AutoSize = true;
            this.UDIDLBL.BackColor = System.Drawing.Color.Transparent;
            this.UDIDLBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.UDIDLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.UDIDLBL.Location = new System.Drawing.Point(200, 148);
            this.UDIDLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UDIDLBL.Name = "UDIDLBL";
            this.UDIDLBL.Size = new System.Drawing.Size(24, 15);
            this.UDIDLBL.TabIndex = 10;
            this.UDIDLBL.Text = "NA";
            this.UDIDLBL.Click += new System.EventHandler(this.UDIDLBL_Click);
            // 
            // BATTLBL
            // 
            this.BATTLBL.AutoSize = true;
            this.BATTLBL.BackColor = System.Drawing.Color.Transparent;
            this.BATTLBL.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BATTLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.BATTLBL.Location = new System.Drawing.Point(1073, 135);
            this.BATTLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BATTLBL.Name = "BATTLBL";
            this.BATTLBL.Size = new System.Drawing.Size(12, 12);
            this.BATTLBL.TabIndex = 11;
            this.BATTLBL.Text = "+";
            // 
            // DiskLBL
            // 
            this.DiskLBL.AutoSize = true;
            this.DiskLBL.BackColor = System.Drawing.Color.Transparent;
            this.DiskLBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.DiskLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DiskLBL.Location = new System.Drawing.Point(1154, 585);
            this.DiskLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiskLBL.Name = "DiskLBL";
            this.DiskLBL.Size = new System.Drawing.Size(24, 15);
            this.DiskLBL.TabIndex = 12;
            this.DiskLBL.Text = "NA";
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.BackColor = System.Drawing.Color.Transparent;
            this.NameLBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.NameLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.NameLBL.Location = new System.Drawing.Point(200, 14);
            this.NameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(24, 15);
            this.NameLBL.TabIndex = 13;
            this.NameLBL.Text = "NA";
            // 
            // DriversBTN
            // 
            this.DriversBTN.BackColor = System.Drawing.Color.Transparent;
            this.DriversBTN.BorderRadius = 8;
            this.DriversBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DriversBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.DriversBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriversBTN.ForeColor = System.Drawing.Color.White;
            this.DriversBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.DriversBTN.Location = new System.Drawing.Point(580, 51);
            this.DriversBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DriversBTN.Name = "DriversBTN";
            this.DriversBTN.Size = new System.Drawing.Size(144, 44);
            this.DriversBTN.TabIndex = 16;
            this.DriversBTN.Text = "Fix Drivers";
            this.DriversBTN.Click += new System.EventHandler(this.DriversBTN_Click);
            // 
            // CPIDLBL
            // 
            this.CPIDLBL.AutoSize = true;
            this.CPIDLBL.BackColor = System.Drawing.Color.Transparent;
            this.CPIDLBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.CPIDLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CPIDLBL.Location = new System.Drawing.Point(696, 593);
            this.CPIDLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPIDLBL.Name = "CPIDLBL";
            this.CPIDLBL.Size = new System.Drawing.Size(24, 15);
            this.CPIDLBL.TabIndex = 19;
            this.CPIDLBL.Text = "NA";
            // 
            // BDIDLBL
            // 
            this.BDIDLBL.AutoSize = true;
            this.BDIDLBL.BackColor = System.Drawing.Color.Transparent;
            this.BDIDLBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.BDIDLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.BDIDLBL.Location = new System.Drawing.Point(696, 586);
            this.BDIDLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BDIDLBL.Name = "BDIDLBL";
            this.BDIDLBL.Size = new System.Drawing.Size(24, 15);
            this.BDIDLBL.TabIndex = 20;
            this.BDIDLBL.Text = "NA";
            // 
            // MODELBL
            // 
            this.MODELBL.AutoSize = true;
            this.MODELBL.BackColor = System.Drawing.Color.Transparent;
            this.MODELBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.MODELBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MODELBL.Location = new System.Drawing.Point(429, 38);
            this.MODELBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MODELBL.Name = "MODELBL";
            this.MODELBL.Size = new System.Drawing.Size(24, 15);
            this.MODELBL.TabIndex = 22;
            this.MODELBL.Text = "NA";
            // 
            // TestModeBTN
            // 
            this.TestModeBTN.BorderRadius = 8;
            this.TestModeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestModeBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.TestModeBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestModeBTN.ForeColor = System.Drawing.Color.White;
            this.TestModeBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.TestModeBTN.Location = new System.Drawing.Point(7, 16);
            this.TestModeBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TestModeBTN.Name = "TestModeBTN";
            this.TestModeBTN.Size = new System.Drawing.Size(175, 46);
            this.TestModeBTN.TabIndex = 23;
            this.TestModeBTN.Text = "Win Test Mode";
            this.TestModeBTN.Click += new System.EventHandler(this.TestModeBTN_Click);
            // 
            // PWNDFUBTN
            // 
            this.PWNDFUBTN.BorderRadius = 8;
            this.PWNDFUBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PWNDFUBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.PWNDFUBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.PWNDFUBTN.ForeColor = System.Drawing.Color.White;
            this.PWNDFUBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.PWNDFUBTN.Location = new System.Drawing.Point(185, 16);
            this.PWNDFUBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PWNDFUBTN.Name = "PWNDFUBTN";
            this.PWNDFUBTN.Size = new System.Drawing.Size(175, 46);
            this.PWNDFUBTN.TabIndex = 24;
            this.PWNDFUBTN.Text = "Device Manager";
            this.PWNDFUBTN.Click += new System.EventHandler(this.PWNDFUBTN_Click);
            // 
            // MDMBTN
            // 
            this.MDMBTN.BackColor = System.Drawing.Color.Transparent;
            this.MDMBTN.BorderRadius = 8;
            this.MDMBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MDMBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.MDMBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MDMBTN.ForeColor = System.Drawing.Color.White;
            this.MDMBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.MDMBTN.Location = new System.Drawing.Point(186, 120);
            this.MDMBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MDMBTN.Name = "MDMBTN";
            this.MDMBTN.Size = new System.Drawing.Size(208, 44);
            this.MDMBTN.TabIndex = 26;
            this.MDMBTN.Text = "Bypass MDM";
            this.MDMBTN.Click += new System.EventHandler(this.MDMBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label5.Location = new System.Drawing.Point(4, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 105);
            this.label5.TabIndex = 4;
            this.label5.Text = "HOW TO USE:\r\n\r\n* Do not connect to Wifi! if so, Erase, or Clean Restore\r\n- Activa" +
    "te/ Skip setup via 3utools.\r\n- Click MDM Bypass\r\n- Reboot device\r\n- Connect to W" +
    "ifi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label4.Location = new System.Drawing.Point(4, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "This is a Universal Method\r\nSupports all iPhone/iPad Models\r\nUP to iOS 18, withou" +
    "t Jailbreak\r\n";
            // 
            // ConnectSSHBTN
            // 
            this.ConnectSSHBTN.BackColor = System.Drawing.Color.Transparent;
            this.ConnectSSHBTN.BorderRadius = 6;
            this.ConnectSSHBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectSSHBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ConnectSSHBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectSSHBTN.ForeColor = System.Drawing.Color.White;
            this.ConnectSSHBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.ConnectSSHBTN.Location = new System.Drawing.Point(363, 42);
            this.ConnectSSHBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConnectSSHBTN.Name = "ConnectSSHBTN";
            this.ConnectSSHBTN.Size = new System.Drawing.Size(175, 35);
            this.ConnectSSHBTN.TabIndex = 39;
            this.ConnectSSHBTN.Text = "Connect SSH";
            this.ConnectSSHBTN.Click += new System.EventHandler(this.ConnectSSHBTN_Click);
            // 
            // PWNMan
            // 
            this.PWNMan.BackColor = System.Drawing.Color.Transparent;
            this.PWNMan.BorderRadius = 6;
            this.PWNMan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PWNMan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.PWNMan.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWNMan.ForeColor = System.Drawing.Color.White;
            this.PWNMan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.PWNMan.Location = new System.Drawing.Point(6, 42);
            this.PWNMan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PWNMan.Name = "PWNMan";
            this.PWNMan.Size = new System.Drawing.Size(175, 35);
            this.PWNMan.TabIndex = 37;
            this.PWNMan.Text = "PWNDFU";
            this.PWNMan.Click += new System.EventHandler(this.PWNMan_Click);
            // 
            // BackupRD
            // 
            this.BackupRD.BackColor = System.Drawing.Color.Transparent;
            this.BackupRD.BorderRadius = 6;
            this.BackupRD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackupRD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.BackupRD.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupRD.ForeColor = System.Drawing.Color.White;
            this.BackupRD.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.BackupRD.Location = new System.Drawing.Point(184, 82);
            this.BackupRD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackupRD.Name = "BackupRD";
            this.BackupRD.Size = new System.Drawing.Size(175, 35);
            this.BackupRD.TabIndex = 49;
            this.BackupRD.Text = "Backup Passcode";
            this.BackupRD.Click += new System.EventHandler(this.BackupRD_Click);
            // 
            // ManBootBTN
            // 
            this.ManBootBTN.BackColor = System.Drawing.Color.Transparent;
            this.ManBootBTN.BorderRadius = 6;
            this.ManBootBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManBootBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ManBootBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManBootBTN.ForeColor = System.Drawing.Color.White;
            this.ManBootBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.ManBootBTN.Location = new System.Drawing.Point(184, 42);
            this.ManBootBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ManBootBTN.Name = "ManBootBTN";
            this.ManBootBTN.Size = new System.Drawing.Size(175, 35);
            this.ManBootBTN.TabIndex = 38;
            this.ManBootBTN.Text = "Boot Ramdisk";
            this.ManBootBTN.Click += new System.EventHandler(this.ManBootBTN_Click);
            // 
            // ExitRamdiskBTN
            // 
            this.ExitRamdiskBTN.BackColor = System.Drawing.Color.Transparent;
            this.ExitRamdiskBTN.BorderRadius = 6;
            this.ExitRamdiskBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitRamdiskBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ExitRamdiskBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitRamdiskBTN.ForeColor = System.Drawing.Color.White;
            this.ExitRamdiskBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.ExitRamdiskBTN.Location = new System.Drawing.Point(363, 122);
            this.ExitRamdiskBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExitRamdiskBTN.Name = "ExitRamdiskBTN";
            this.ExitRamdiskBTN.Size = new System.Drawing.Size(175, 35);
            this.ExitRamdiskBTN.TabIndex = 35;
            this.ExitRamdiskBTN.Text = "Exit Ramdisk Mode";
            this.ExitRamdiskBTN.Click += new System.EventHandler(this.ExitRamdiskBTN_Click);
            // 
            // EraseBTNR
            // 
            this.EraseBTNR.BackColor = System.Drawing.Color.Transparent;
            this.EraseBTNR.BorderRadius = 6;
            this.EraseBTNR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EraseBTNR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.EraseBTNR.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EraseBTNR.ForeColor = System.Drawing.Color.White;
            this.EraseBTNR.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.EraseBTNR.Location = new System.Drawing.Point(184, 122);
            this.EraseBTNR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EraseBTNR.Name = "EraseBTNR";
            this.EraseBTNR.Size = new System.Drawing.Size(175, 35);
            this.EraseBTNR.TabIndex = 34;
            this.EraseBTNR.Text = "Erase Device";
            this.EraseBTNR.Click += new System.EventHandler(this.EraseBTNR_Click);
            // 
            // LogoutBTNR
            // 
            this.LogoutBTNR.BackColor = System.Drawing.Color.Transparent;
            this.LogoutBTNR.BorderRadius = 6;
            this.LogoutBTNR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBTNR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.LogoutBTNR.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBTNR.ForeColor = System.Drawing.Color.White;
            this.LogoutBTNR.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.LogoutBTNR.Location = new System.Drawing.Point(6, 122);
            this.LogoutBTNR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogoutBTNR.Name = "LogoutBTNR";
            this.LogoutBTNR.Size = new System.Drawing.Size(175, 35);
            this.LogoutBTNR.TabIndex = 33;
            this.LogoutBTNR.Text = "Logout Account";
            this.LogoutBTNR.Click += new System.EventHandler(this.LogoutBTNR_Click);
            // 
            // PasscodeBTNR
            // 
            this.PasscodeBTNR.BackColor = System.Drawing.Color.Transparent;
            this.PasscodeBTNR.BorderRadius = 6;
            this.PasscodeBTNR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasscodeBTNR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.PasscodeBTNR.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasscodeBTNR.ForeColor = System.Drawing.Color.White;
            this.PasscodeBTNR.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.PasscodeBTNR.Location = new System.Drawing.Point(363, 82);
            this.PasscodeBTNR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PasscodeBTNR.Name = "PasscodeBTNR";
            this.PasscodeBTNR.Size = new System.Drawing.Size(175, 35);
            this.PasscodeBTNR.TabIndex = 32;
            this.PasscodeBTNR.Text = "Activate Passcode";
            this.PasscodeBTNR.Click += new System.EventHandler(this.PasscodeBTNR_Click);
            // 
            // HelloBTNR
            // 
            this.HelloBTNR.BackColor = System.Drawing.Color.Transparent;
            this.HelloBTNR.BorderRadius = 6;
            this.HelloBTNR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelloBTNR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.HelloBTNR.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloBTNR.ForeColor = System.Drawing.Color.White;
            this.HelloBTNR.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.HelloBTNR.Location = new System.Drawing.Point(6, 82);
            this.HelloBTNR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HelloBTNR.Name = "HelloBTNR";
            this.HelloBTNR.Size = new System.Drawing.Size(175, 35);
            this.HelloBTNR.TabIndex = 31;
            this.HelloBTNR.Text = "Hello Bypass";
            this.HelloBTNR.Click += new System.EventHandler(this.HelloBTNR_Click);
            // 
            // GSMBTN
            // 
            this.GSMBTN.BackColor = System.Drawing.Color.Transparent;
            this.GSMBTN.BorderRadius = 6;
            this.GSMBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GSMBTN.Enabled = false;
            this.GSMBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.GSMBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GSMBTN.ForeColor = System.Drawing.Color.White;
            this.GSMBTN.Location = new System.Drawing.Point(363, 5);
            this.GSMBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GSMBTN.Name = "GSMBTN";
            this.GSMBTN.Size = new System.Drawing.Size(175, 35);
            this.GSMBTN.TabIndex = 48;
            this.GSMBTN.Text = "GSM Signal 7 - X";
            this.GSMBTN.Click += new System.EventHandler(this.GSMBTN_Click);
            // 
            // PasscodeActBTNJ
            // 
            this.PasscodeActBTNJ.BackColor = System.Drawing.Color.Transparent;
            this.PasscodeActBTNJ.BorderRadius = 6;
            this.PasscodeActBTNJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasscodeActBTNJ.Enabled = false;
            this.PasscodeActBTNJ.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.PasscodeActBTNJ.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasscodeActBTNJ.ForeColor = System.Drawing.Color.White;
            this.PasscodeActBTNJ.Location = new System.Drawing.Point(362, 43);
            this.PasscodeActBTNJ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PasscodeActBTNJ.Name = "PasscodeActBTNJ";
            this.PasscodeActBTNJ.Size = new System.Drawing.Size(175, 35);
            this.PasscodeActBTNJ.TabIndex = 47;
            this.PasscodeActBTNJ.Text = "Passcode Activate";
            this.PasscodeActBTNJ.Click += new System.EventHandler(this.PasscodeActBTNJ_Click);
            // 
            // DisableBBJ
            // 
            this.DisableBBJ.BackColor = System.Drawing.Color.Transparent;
            this.DisableBBJ.BorderRadius = 6;
            this.DisableBBJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisableBBJ.Enabled = false;
            this.DisableBBJ.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.DisableBBJ.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisableBBJ.ForeColor = System.Drawing.Color.White;
            this.DisableBBJ.Location = new System.Drawing.Point(183, 125);
            this.DisableBBJ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DisableBBJ.Name = "DisableBBJ";
            this.DisableBBJ.Size = new System.Drawing.Size(175, 35);
            this.DisableBBJ.TabIndex = 44;
            this.DisableBBJ.Text = "Disable Baseband";
            this.DisableBBJ.Click += new System.EventHandler(this.DisableBBJ_Click);
            // 
            // EnableBBJ
            // 
            this.EnableBBJ.BackColor = System.Drawing.Color.Transparent;
            this.EnableBBJ.BorderRadius = 6;
            this.EnableBBJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnableBBJ.Enabled = false;
            this.EnableBBJ.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.EnableBBJ.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnableBBJ.ForeColor = System.Drawing.Color.White;
            this.EnableBBJ.Location = new System.Drawing.Point(6, 126);
            this.EnableBBJ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EnableBBJ.Name = "EnableBBJ";
            this.EnableBBJ.Size = new System.Drawing.Size(175, 35);
            this.EnableBBJ.TabIndex = 43;
            this.EnableBBJ.Text = "Enable Baseband";
            this.EnableBBJ.Click += new System.EventHandler(this.EnableBBJ_Click);
            // 
            // LogoutBTNJ
            // 
            this.LogoutBTNJ.BackColor = System.Drawing.Color.Transparent;
            this.LogoutBTNJ.BorderRadius = 6;
            this.LogoutBTNJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBTNJ.Enabled = false;
            this.LogoutBTNJ.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.LogoutBTNJ.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBTNJ.ForeColor = System.Drawing.Color.White;
            this.LogoutBTNJ.Location = new System.Drawing.Point(362, 126);
            this.LogoutBTNJ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogoutBTNJ.Name = "LogoutBTNJ";
            this.LogoutBTNJ.Size = new System.Drawing.Size(175, 35);
            this.LogoutBTNJ.TabIndex = 42;
            this.LogoutBTNJ.Text = "Logout Account";
            this.LogoutBTNJ.Click += new System.EventHandler(this.LogoutBTNJ_Click);
            // 
            // EraseBTNJ
            // 
            this.EraseBTNJ.BackColor = System.Drawing.Color.Transparent;
            this.EraseBTNJ.BorderRadius = 6;
            this.EraseBTNJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EraseBTNJ.Enabled = false;
            this.EraseBTNJ.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.EraseBTNJ.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EraseBTNJ.ForeColor = System.Drawing.Color.White;
            this.EraseBTNJ.Location = new System.Drawing.Point(183, 83);
            this.EraseBTNJ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EraseBTNJ.Name = "EraseBTNJ";
            this.EraseBTNJ.Size = new System.Drawing.Size(175, 35);
            this.EraseBTNJ.TabIndex = 41;
            this.EraseBTNJ.Text = "Erase Device";
            this.EraseBTNJ.Click += new System.EventHandler(this.EraseBTNJ_Click);
            // 
            // PatchBTN
            // 
            this.PatchBTN.BackColor = System.Drawing.Color.Transparent;
            this.PatchBTN.BorderRadius = 6;
            this.PatchBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatchBTN.Enabled = false;
            this.PatchBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.PatchBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatchBTN.ForeColor = System.Drawing.Color.White;
            this.PatchBTN.Location = new System.Drawing.Point(6, 84);
            this.PatchBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PatchBTN.Name = "PatchBTN";
            this.PatchBTN.Size = new System.Drawing.Size(175, 35);
            this.PatchBTN.TabIndex = 40;
            this.PatchBTN.Text = "Patch USB";
            this.PatchBTN.Click += new System.EventHandler(this.PatchBTN_Click);
            // 
            // BrokenBBJ
            // 
            this.BrokenBBJ.BackColor = System.Drawing.Color.Transparent;
            this.BrokenBBJ.BorderRadius = 6;
            this.BrokenBBJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrokenBBJ.Enabled = false;
            this.BrokenBBJ.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.BrokenBBJ.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrokenBBJ.ForeColor = System.Drawing.Color.White;
            this.BrokenBBJ.Location = new System.Drawing.Point(362, 84);
            this.BrokenBBJ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BrokenBBJ.Name = "BrokenBBJ";
            this.BrokenBBJ.Size = new System.Drawing.Size(175, 35);
            this.BrokenBBJ.TabIndex = 39;
            this.BrokenBBJ.Text = "Broken Baseband";
            this.BrokenBBJ.Click += new System.EventHandler(this.BrokenBBJ_Click);
            // 
            // PasscodeBackBTNJ
            // 
            this.PasscodeBackBTNJ.BackColor = System.Drawing.Color.Transparent;
            this.PasscodeBackBTNJ.BorderRadius = 6;
            this.PasscodeBackBTNJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasscodeBackBTNJ.Enabled = false;
            this.PasscodeBackBTNJ.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.PasscodeBackBTNJ.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasscodeBackBTNJ.ForeColor = System.Drawing.Color.White;
            this.PasscodeBackBTNJ.Location = new System.Drawing.Point(183, 43);
            this.PasscodeBackBTNJ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PasscodeBackBTNJ.Name = "PasscodeBackBTNJ";
            this.PasscodeBackBTNJ.Size = new System.Drawing.Size(175, 35);
            this.PasscodeBackBTNJ.TabIndex = 38;
            this.PasscodeBackBTNJ.Text = "Passcode Backup";
            this.PasscodeBackBTNJ.Click += new System.EventHandler(this.PasscodeBackBTNJ_Click);
            // 
            // HelloBTNJ
            // 
            this.HelloBTNJ.BackColor = System.Drawing.Color.Transparent;
            this.HelloBTNJ.BorderRadius = 6;
            this.HelloBTNJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelloBTNJ.Enabled = false;
            this.HelloBTNJ.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.HelloBTNJ.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloBTNJ.ForeColor = System.Drawing.Color.White;
            this.HelloBTNJ.Location = new System.Drawing.Point(6, 43);
            this.HelloBTNJ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HelloBTNJ.Name = "HelloBTNJ";
            this.HelloBTNJ.Size = new System.Drawing.Size(175, 35);
            this.HelloBTNJ.TabIndex = 37;
            this.HelloBTNJ.Text = "Hello Bypass";
            this.HelloBTNJ.Click += new System.EventHandler(this.HelloBTNJ_Click);
            // 
            // BuildLBL
            // 
            this.BuildLBL.AutoSize = true;
            this.BuildLBL.BackColor = System.Drawing.Color.Transparent;
            this.BuildLBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.BuildLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.BuildLBL.Location = new System.Drawing.Point(696, 594);
            this.BuildLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuildLBL.Name = "BuildLBL";
            this.BuildLBL.Size = new System.Drawing.Size(24, 15);
            this.BuildLBL.TabIndex = 28;
            this.BuildLBL.Text = "NA";
            // 
            // HardLBL
            // 
            this.HardLBL.AutoSize = true;
            this.HardLBL.BackColor = System.Drawing.Color.Transparent;
            this.HardLBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.HardLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.HardLBL.Location = new System.Drawing.Point(696, 623);
            this.HardLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HardLBL.Name = "HardLBL";
            this.HardLBL.Size = new System.Drawing.Size(24, 15);
            this.HardLBL.TabIndex = 30;
            this.HardLBL.Text = "NA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label8.Location = new System.Drawing.Point(1013, 324);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "Storage:";
            // 
            // RamFolder
            // 
            this.RamFolder.BackColor = System.Drawing.Color.Transparent;
            this.RamFolder.BorderRadius = 8;
            this.RamFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RamFolder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.RamFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.RamFolder.ForeColor = System.Drawing.Color.White;
            this.RamFolder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.RamFolder.Location = new System.Drawing.Point(360, 114);
            this.RamFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RamFolder.Name = "RamFolder";
            this.RamFolder.Size = new System.Drawing.Size(175, 46);
            this.RamFolder.TabIndex = 32;
            this.RamFolder.Text = "Ramdisks Folder";
            this.RamFolder.Click += new System.EventHandler(this.RamFolder_Click);
            // 
            // BackupsBTN
            // 
            this.BackupsBTN.BackColor = System.Drawing.Color.Transparent;
            this.BackupsBTN.BorderRadius = 8;
            this.BackupsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackupsBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.BackupsBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.BackupsBTN.ForeColor = System.Drawing.Color.White;
            this.BackupsBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.BackupsBTN.Location = new System.Drawing.Point(183, 114);
            this.BackupsBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackupsBTN.Name = "BackupsBTN";
            this.BackupsBTN.Size = new System.Drawing.Size(175, 46);
            this.BackupsBTN.TabIndex = 33;
            this.BackupsBTN.Text = "Backups Folder";
            this.BackupsBTN.Click += new System.EventHandler(this.BackupsBTN_Click);
            // 
            // BackupDown
            // 
            this.BackupDown.BackColor = System.Drawing.Color.Transparent;
            this.BackupDown.BorderRadius = 8;
            this.BackupDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackupDown.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.BackupDown.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.BackupDown.ForeColor = System.Drawing.Color.White;
            this.BackupDown.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.BackupDown.Location = new System.Drawing.Point(6, 114);
            this.BackupDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackupDown.Name = "BackupDown";
            this.BackupDown.Size = new System.Drawing.Size(175, 46);
            this.BackupDown.TabIndex = 34;
            this.BackupDown.Text = "Download Backup";
            this.BackupDown.Click += new System.EventHandler(this.BackupDown_Click);
            // 
            // button1
            // 
            this.button1.BorderRadius = 8;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.button1.Location = new System.Drawing.Point(362, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 46);
            this.button1.TabIndex = 35;
            this.button1.Text = "Purple Mode";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BorderRadius = 8;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FillColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.button2.Location = new System.Drawing.Point(363, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 34);
            this.button2.TabIndex = 36;
            this.button2.Text = "DFU Helper";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BorderRadius = 8;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FillColor = System.Drawing.Color.DarkOrange;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.button3.Location = new System.Drawing.Point(183, 5);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 35);
            this.button3.TabIndex = 37;
            this.button3.Text = "Jailbreak iDevice";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BorderRadius = 8;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button4.Location = new System.Drawing.Point(580, 468);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 37);
            this.button4.TabIndex = 38;
            this.button4.Text = "Exit Recovery";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(14, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 55);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // ReadBTN
            // 
            this.ReadBTN.BackColor = System.Drawing.Color.Transparent;
            this.ReadBTN.BorderRadius = 8;
            this.ReadBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ReadBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadBTN.ForeColor = System.Drawing.Color.White;
            this.ReadBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.ReadBTN.Location = new System.Drawing.Point(684, 468);
            this.ReadBTN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReadBTN.Name = "ReadBTN";
            this.ReadBTN.Size = new System.Drawing.Size(182, 36);
            this.ReadBTN.TabIndex = 49;
            this.ReadBTN.Text = "Read Device";
            this.ReadBTN.Click += new System.EventHandler(this.ReadBTN_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label12.Location = new System.Drawing.Point(1316, 118);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 50;
            this.label12.Text = "Progress";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label13.Location = new System.Drawing.Point(1316, 148);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 51;
            this.label13.Text = "Total Received";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label14.Location = new System.Drawing.Point(1316, 174);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 15);
            this.label14.TabIndex = 52;
            this.label14.Text = "Download Rate";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.lblProgress.Location = new System.Drawing.Point(1437, 118);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(12, 15);
            this.lblProgress.TabIndex = 53;
            this.lblProgress.Text = "-";
            // 
            // lblTotalBytesReceived
            // 
            this.lblTotalBytesReceived.AutoSize = true;
            this.lblTotalBytesReceived.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBytesReceived.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTotalBytesReceived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.lblTotalBytesReceived.Location = new System.Drawing.Point(1437, 148);
            this.lblTotalBytesReceived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalBytesReceived.Name = "lblTotalBytesReceived";
            this.lblTotalBytesReceived.Size = new System.Drawing.Size(12, 15);
            this.lblTotalBytesReceived.TabIndex = 54;
            this.lblTotalBytesReceived.Text = "-";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeed.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.lblSpeed.Location = new System.Drawing.Point(1437, 174);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(12, 15);
            this.lblSpeed.TabIndex = 55;
            this.lblSpeed.Text = "-";
            // 
            // UCIDLBL
            // 
            this.UCIDLBL.AutoSize = true;
            this.UCIDLBL.BackColor = System.Drawing.Color.Transparent;
            this.UCIDLBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.UCIDLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.UCIDLBL.Location = new System.Drawing.Point(696, 652);
            this.UCIDLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UCIDLBL.Name = "UCIDLBL";
            this.UCIDLBL.Size = new System.Drawing.Size(24, 15);
            this.UCIDLBL.TabIndex = 57;
            this.UCIDLBL.Text = "NA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(372, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 15);
            this.label11.TabIndex = 42;
            this.label11.Text = "iSkorpion - iOSTool v6.9.4";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.HeaderPanel.BorderThickness = 1;
            this.HeaderPanel.Controls.Add(this.guna2CircleButton2);
            this.HeaderPanel.Controls.Add(this.guna2CircleButton1);
            this.HeaderPanel.Controls.Add(this.pictureBox4);
            this.HeaderPanel.Controls.Add(this.label11);
            this.HeaderPanel.Location = new System.Drawing.Point(-2, -6);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.HeaderPanel.ShadowDecoration.Depth = 50;
            this.HeaderPanel.ShadowDecoration.Enabled = true;
            this.HeaderPanel.Size = new System.Drawing.Size(944, 38);
            this.HeaderPanel.TabIndex = 61;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.HeaderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(11)))));
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Location = new System.Drawing.Point(32, 15);
            this.guna2CircleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Depth = 3;
            this.guna2CircleButton2.ShadowDecoration.Enabled = true;
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(13, 14);
            this.guna2CircleButton2.TabIndex = 747;
            this.guna2CircleButton2.Text = "guna2CircleButton2";
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Red;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(12, 15);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Depth = 3;
            this.guna2CircleButton1.ShadowDecoration.Enabled = true;
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(13, 14);
            this.guna2CircleButton1.TabIndex = 746;
            this.guna2CircleButton1.Text = "guna2CircleButton1";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(853, 10);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 24);
            this.pictureBox4.TabIndex = 80;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.InfoPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.InfoPanel.BorderRadius = 10;
            this.InfoPanel.BorderThickness = 1;
            this.InfoPanel.Controls.Add(this.RegionLBL);
            this.InfoPanel.Controls.Add(this.label32);
            this.InfoPanel.Controls.Add(this.label26);
            this.InfoPanel.Controls.Add(this.label25);
            this.InfoPanel.Controls.Add(this.label24);
            this.InfoPanel.Controls.Add(this.label23);
            this.InfoPanel.Controls.Add(this.label22);
            this.InfoPanel.Controls.Add(this.label21);
            this.InfoPanel.Controls.Add(this.label20);
            this.InfoPanel.Controls.Add(this.label19);
            this.InfoPanel.Controls.Add(this.label18);
            this.InfoPanel.Controls.Add(this.label17);
            this.InfoPanel.Controls.Add(this.NameLBL);
            this.InfoPanel.Controls.Add(this.iOSLBL);
            this.InfoPanel.Controls.Add(this.JBLBL);
            this.InfoPanel.Controls.Add(this.MODELBL);
            this.InfoPanel.Controls.Add(this.ActLBL);
            this.InfoPanel.Controls.Add(this.ProdLBL);
            this.InfoPanel.Controls.Add(this.IMEILBL);
            this.InfoPanel.Controls.Add(this.SNLBL);
            this.InfoPanel.Controls.Add(this.ECIDLBL);
            this.InfoPanel.Controls.Add(this.UDIDLBL);
            this.InfoPanel.Controls.Add(this.pictureBoxDC);
            this.InfoPanel.FillColor = System.Drawing.Color.Transparent;
            this.InfoPanel.Location = new System.Drawing.Point(12, 99);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.ShadowDecoration.BorderRadius = 10;
            this.InfoPanel.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.InfoPanel.ShadowDecoration.Depth = 80;
            this.InfoPanel.ShadowDecoration.Enabled = true;
            this.InfoPanel.Size = new System.Drawing.Size(550, 178);
            this.InfoPanel.TabIndex = 63;
            this.InfoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.InfoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // RegionLBL
            // 
            this.RegionLBL.AutoSize = true;
            this.RegionLBL.BackColor = System.Drawing.Color.Transparent;
            this.RegionLBL.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.RegionLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.RegionLBL.Location = new System.Drawing.Point(198, 120);
            this.RegionLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegionLBL.Name = "RegionLBL";
            this.RegionLBL.Size = new System.Drawing.Size(24, 15);
            this.RegionLBL.TabIndex = 78;
            this.RegionLBL.Text = "NA";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label32.Location = new System.Drawing.Point(358, 38);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(44, 15);
            this.label32.TabIndex = 29;
            this.label32.Text = "Mode :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label26.Location = new System.Drawing.Point(358, 13);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 15);
            this.label26.TabIndex = 23;
            this.label26.Text = "Jailbreak :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label25.Location = new System.Drawing.Point(142, 148);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(43, 15);
            this.label25.TabIndex = 22;
            this.label25.Text = "UDID :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label24.Location = new System.Drawing.Point(142, 67);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 15);
            this.label24.TabIndex = 21;
            this.label24.Text = "ECID :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label23.Location = new System.Drawing.Point(142, 38);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 15);
            this.label23.TabIndex = 20;
            this.label23.Text = "Serial :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label22.Location = new System.Drawing.Point(142, 92);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 15);
            this.label22.TabIndex = 19;
            this.label22.Text = "IMEI :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label21.Location = new System.Drawing.Point(142, 120);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 15);
            this.label21.TabIndex = 18;
            this.label21.Text = "Region :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label20.Location = new System.Drawing.Point(356, 95);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 15);
            this.label20.TabIndex = 17;
            this.label20.Text = "Product :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label19.Location = new System.Drawing.Point(355, 120);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 15);
            this.label19.TabIndex = 16;
            this.label19.Text = "Activation :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label18.Location = new System.Drawing.Point(358, 67);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 15);
            this.label18.TabIndex = 15;
            this.label18.Text = "iOS :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label17.Location = new System.Drawing.Point(142, 13);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 15);
            this.label17.TabIndex = 14;
            this.label17.Text = "Device :";
            // 
            // pictureBoxDC
            // 
            this.pictureBoxDC.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDC.BackgroundImage")));
            this.pictureBoxDC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDC.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxDC.Location = new System.Drawing.Point(-51, 0);
            this.pictureBoxDC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxDC.Name = "pictureBoxDC";
            this.pictureBoxDC.Size = new System.Drawing.Size(233, 174);
            this.pictureBoxDC.TabIndex = 77;
            this.pictureBoxDC.TabStop = false;
            this.pictureBoxDC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pictureBoxDC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // StorageBar
            // 
            this.StorageBar.BorderRadius = 5;
            this.StorageBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.StorageBar.Location = new System.Drawing.Point(987, 426);
            this.StorageBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StorageBar.Name = "StorageBar";
            this.StorageBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.StorageBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.StorageBar.Size = new System.Drawing.Size(248, 14);
            this.StorageBar.TabIndex = 58;
            this.StorageBar.Text = "-";
            this.StorageBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label31.Location = new System.Drawing.Point(1072, 393);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 15);
            this.label31.TabIndex = 28;
            this.label31.Text = "UCID :";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label30.Location = new System.Drawing.Point(1072, 363);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(64, 15);
            this.label30.TabIndex = 27;
            this.label30.Text = "Hardware :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label29.Location = new System.Drawing.Point(984, 374);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 15);
            this.label29.TabIndex = 26;
            this.label29.Text = "BUILD :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label28.Location = new System.Drawing.Point(625, 585);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(42, 15);
            this.label28.TabIndex = 25;
            this.label28.Text = "BDID :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label27.Location = new System.Drawing.Point(625, 593);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 15);
            this.label27.TabIndex = 24;
            this.label27.Text = "CPID :";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.BorderRadius = 5;
            this.progressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.progressBar1.Location = new System.Drawing.Point(9, 284);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.progressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.progressBar1.ShadowDecoration.Enabled = true;
            this.progressBar1.Size = new System.Drawing.Size(553, 12);
            this.progressBar1.TabIndex = 64;
            this.progressBar1.Text = "-";
            this.progressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // ActivateButton
            // 
            this.ActivateButton.BorderRadius = 8;
            this.ActivateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActivateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ActivateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ActivateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ActivateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ActivateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ActivateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.ActivateButton.ForeColor = System.Drawing.Color.White;
            this.ActivateButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.ActivateButton.Location = new System.Drawing.Point(13, 108);
            this.ActivateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ActivateButton.Name = "ActivateButton";
            this.ActivateButton.Size = new System.Drawing.Size(257, 52);
            this.ActivateButton.TabIndex = 0;
            this.ActivateButton.Text = "Activate Device";
            this.ActivateButton.Click += new System.EventHandler(this.ActivateButton_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 8;
            this.guna2GradientButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(160)))));
            this.guna2GradientButton2.Location = new System.Drawing.Point(278, 108);
            this.guna2GradientButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(253, 52);
            this.guna2GradientButton2.TabIndex = 1;
            this.guna2GradientButton2.Text = "Block OTA/Reset";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // RamdiskPanel
            // 
            this.RamdiskPanel.BackColor = System.Drawing.Color.Transparent;
            this.RamdiskPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.RamdiskPanel.BorderRadius = 10;
            this.RamdiskPanel.BorderThickness = 1;
            this.RamdiskPanel.Controls.Add(this.AirPlaneMode);
            this.RamdiskPanel.Controls.Add(this.RD17);
            this.RamdiskPanel.Controls.Add(this.RD16);
            this.RamdiskPanel.Controls.Add(this.ConnectSSHBTN);
            this.RamdiskPanel.Controls.Add(this.LogoutBTNR);
            this.RamdiskPanel.Controls.Add(this.RD15);
            this.RamdiskPanel.Controls.Add(this.PWNMan);
            this.RamdiskPanel.Controls.Add(this.button2);
            this.RamdiskPanel.Controls.Add(this.ExitRamdiskBTN);
            this.RamdiskPanel.Controls.Add(this.HelloBTNR);
            this.RamdiskPanel.Controls.Add(this.BackupRD);
            this.RamdiskPanel.Controls.Add(this.EraseBTNR);
            this.RamdiskPanel.Controls.Add(this.PasscodeBTNR);
            this.RamdiskPanel.Controls.Add(this.ManBootBTN);
            this.RamdiskPanel.CustomizableEdges.TopLeft = false;
            this.RamdiskPanel.CustomizableEdges.TopRight = false;
            this.RamdiskPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.RamdiskPanel.Location = new System.Drawing.Point(12, 338);
            this.RamdiskPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RamdiskPanel.Name = "RamdiskPanel";
            this.RamdiskPanel.ShadowDecoration.BorderRadius = 10;
            this.RamdiskPanel.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.RamdiskPanel.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.RamdiskPanel.ShadowDecoration.Enabled = true;
            this.RamdiskPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.RamdiskPanel.Size = new System.Drawing.Size(550, 167);
            this.RamdiskPanel.TabIndex = 65;
            this.RamdiskPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.RamdiskPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // AirPlaneMode
            // 
            this.AirPlaneMode.AutoSize = true;
            this.AirPlaneMode.BackColor = System.Drawing.Color.Transparent;
            this.AirPlaneMode.Checked = true;
            this.AirPlaneMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.AirPlaneMode.CheckedState.BorderRadius = 2;
            this.AirPlaneMode.CheckedState.BorderThickness = 0;
            this.AirPlaneMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.AirPlaneMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AirPlaneMode.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.AirPlaneMode.ForeColor = System.Drawing.Color.White;
            this.AirPlaneMode.Location = new System.Drawing.Point(250, 13);
            this.AirPlaneMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AirPlaneMode.Name = "AirPlaneMode";
            this.AirPlaneMode.Size = new System.Drawing.Size(102, 17);
            this.AirPlaneMode.TabIndex = 71;
            this.AirPlaneMode.Text = "Airplane Mode";
            this.AirPlaneMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.AirPlaneMode.UncheckedState.BorderRadius = 5;
            this.AirPlaneMode.UncheckedState.BorderThickness = 0;
            this.AirPlaneMode.UncheckedState.FillColor = System.Drawing.Color.White;
            this.AirPlaneMode.UseVisualStyleBackColor = false;
            // 
            // RD17
            // 
            this.RD17.AutoSize = true;
            this.RD17.BackColor = System.Drawing.Color.Transparent;
            this.RD17.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.RD17.CheckedState.BorderThickness = 0;
            this.RD17.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.RD17.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(136)))));
            this.RD17.CheckedState.InnerOffset = -4;
            this.RD17.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.RD17.ForeColor = System.Drawing.Color.White;
            this.RD17.Location = new System.Drawing.Point(157, 13);
            this.RD17.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RD17.Name = "RD17";
            this.RD17.Size = new System.Drawing.Size(58, 17);
            this.RD17.TabIndex = 74;
            this.RD17.Text = "iOS 17";
            this.RD17.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.RD17.UncheckedState.BorderThickness = 2;
            this.RD17.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RD17.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RD17.UseVisualStyleBackColor = false;
            this.RD17.CheckedChanged += new System.EventHandler(this.RD17_CheckedChanged);
            // 
            // RD16
            // 
            this.RD16.AutoSize = true;
            this.RD16.BackColor = System.Drawing.Color.Transparent;
            this.RD16.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.RD16.CheckedState.BorderThickness = 0;
            this.RD16.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.RD16.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(136)))));
            this.RD16.CheckedState.InnerOffset = -4;
            this.RD16.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.RD16.ForeColor = System.Drawing.Color.White;
            this.RD16.Location = new System.Drawing.Point(91, 13);
            this.RD16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RD16.Name = "RD16";
            this.RD16.Size = new System.Drawing.Size(58, 17);
            this.RD16.TabIndex = 75;
            this.RD16.Text = "iOS 16";
            this.RD16.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.RD16.UncheckedState.BorderThickness = 2;
            this.RD16.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RD16.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RD16.UseVisualStyleBackColor = false;
            this.RD16.CheckedChanged += new System.EventHandler(this.RD16_CheckedChanged);
            // 
            // RD15
            // 
            this.RD15.AutoSize = true;
            this.RD15.BackColor = System.Drawing.Color.Transparent;
            this.RD15.Checked = true;
            this.RD15.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.RD15.CheckedState.BorderThickness = 0;
            this.RD15.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.RD15.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(136)))));
            this.RD15.CheckedState.InnerOffset = -4;
            this.RD15.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.RD15.ForeColor = System.Drawing.Color.White;
            this.RD15.Location = new System.Drawing.Point(18, 13);
            this.RD15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RD15.Name = "RD15";
            this.RD15.Size = new System.Drawing.Size(58, 17);
            this.RD15.TabIndex = 71;
            this.RD15.TabStop = true;
            this.RD15.Text = "iOS 15";
            this.RD15.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.RD15.UncheckedState.BorderThickness = 2;
            this.RD15.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RD15.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RD15.UseVisualStyleBackColor = false;
            this.RD15.CheckedChanged += new System.EventHandler(this.RD15_CheckedChanged);
            // 
            // JailbreakPanel
            // 
            this.JailbreakPanel.BackColor = System.Drawing.Color.Transparent;
            this.JailbreakPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.JailbreakPanel.BorderRadius = 10;
            this.JailbreakPanel.BorderThickness = 1;
            this.JailbreakPanel.Controls.Add(this.JB1518);
            this.JailbreakPanel.Controls.Add(this.JB1214);
            this.JailbreakPanel.Controls.Add(this.GSMBTN);
            this.JailbreakPanel.Controls.Add(this.HelloBTNJ);
            this.JailbreakPanel.Controls.Add(this.PasscodeActBTNJ);
            this.JailbreakPanel.Controls.Add(this.LogoutBTNJ);
            this.JailbreakPanel.Controls.Add(this.EraseBTNJ);
            this.JailbreakPanel.Controls.Add(this.EnableBBJ);
            this.JailbreakPanel.Controls.Add(this.PasscodeBackBTNJ);
            this.JailbreakPanel.Controls.Add(this.button3);
            this.JailbreakPanel.Controls.Add(this.PatchBTN);
            this.JailbreakPanel.Controls.Add(this.DisableBBJ);
            this.JailbreakPanel.Controls.Add(this.BrokenBBJ);
            this.JailbreakPanel.CustomizableEdges.TopLeft = false;
            this.JailbreakPanel.CustomizableEdges.TopRight = false;
            this.JailbreakPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.JailbreakPanel.Location = new System.Drawing.Point(12, 338);
            this.JailbreakPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.JailbreakPanel.Name = "JailbreakPanel";
            this.JailbreakPanel.ShadowDecoration.BorderRadius = 10;
            this.JailbreakPanel.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.JailbreakPanel.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.JailbreakPanel.ShadowDecoration.Enabled = true;
            this.JailbreakPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.JailbreakPanel.Size = new System.Drawing.Size(550, 167);
            this.JailbreakPanel.TabIndex = 67;
            this.JailbreakPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.JailbreakPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // JB1518
            // 
            this.JB1518.AutoSize = true;
            this.JB1518.BackColor = System.Drawing.Color.Transparent;
            this.JB1518.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.JB1518.CheckedState.BorderThickness = 0;
            this.JB1518.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.JB1518.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(136)))));
            this.JB1518.CheckedState.InnerOffset = -4;
            this.JB1518.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.JB1518.ForeColor = System.Drawing.Color.White;
            this.JB1518.Location = new System.Drawing.Point(95, 14);
            this.JB1518.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.JB1518.Name = "JB1518";
            this.JB1518.Size = new System.Drawing.Size(80, 17);
            this.JB1518.TabIndex = 72;
            this.JB1518.Text = "iOS 15 - 18";
            this.JB1518.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.JB1518.UncheckedState.BorderThickness = 2;
            this.JB1518.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.JB1518.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.JB1518.UseVisualStyleBackColor = false;
            this.JB1518.CheckedChanged += new System.EventHandler(this.JB1518_CheckedChanged);
            // 
            // JB1214
            // 
            this.JB1214.AutoSize = true;
            this.JB1214.BackColor = System.Drawing.Color.Transparent;
            this.JB1214.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.JB1214.CheckedState.BorderThickness = 0;
            this.JB1214.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.JB1214.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(136)))));
            this.JB1214.CheckedState.InnerOffset = -4;
            this.JB1214.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.JB1214.ForeColor = System.Drawing.Color.White;
            this.JB1214.Location = new System.Drawing.Point(7, 13);
            this.JB1214.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.JB1214.Name = "JB1214";
            this.JB1214.Size = new System.Drawing.Size(80, 17);
            this.JB1214.TabIndex = 73;
            this.JB1214.Text = "iOS 12 - 14";
            this.JB1214.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.JB1214.UncheckedState.BorderThickness = 2;
            this.JB1214.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.JB1214.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.JB1214.UseVisualStyleBackColor = false;
            this.JB1214.CheckedChanged += new System.EventHandler(this.JB1214_CheckedChanged);
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ToolsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ToolsPanel.BorderRadius = 10;
            this.ToolsPanel.BorderThickness = 1;
            this.ToolsPanel.Controls.Add(this.TestModeBTN);
            this.ToolsPanel.Controls.Add(this.RamFolder);
            this.ToolsPanel.Controls.Add(this.PWNDFUBTN);
            this.ToolsPanel.Controls.Add(this.BackupDown);
            this.ToolsPanel.Controls.Add(this.button1);
            this.ToolsPanel.Controls.Add(this.BackupsBTN);
            this.ToolsPanel.CustomizableEdges.TopLeft = false;
            this.ToolsPanel.CustomizableEdges.TopRight = false;
            this.ToolsPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ToolsPanel.Location = new System.Drawing.Point(12, 338);
            this.ToolsPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.ShadowDecoration.BorderRadius = 10;
            this.ToolsPanel.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.ToolsPanel.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.ToolsPanel.ShadowDecoration.Enabled = true;
            this.ToolsPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.ToolsPanel.Size = new System.Drawing.Size(550, 167);
            this.ToolsPanel.TabIndex = 68;
            // 
            // MDMPanel
            // 
            this.MDMPanel.BackColor = System.Drawing.Color.Transparent;
            this.MDMPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.MDMPanel.BorderRadius = 10;
            this.MDMPanel.BorderThickness = 1;
            this.MDMPanel.Controls.Add(this.MDMBTN);
            this.MDMPanel.Controls.Add(this.label4);
            this.MDMPanel.Controls.Add(this.label5);
            this.MDMPanel.CustomizableEdges.TopLeft = false;
            this.MDMPanel.CustomizableEdges.TopRight = false;
            this.MDMPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.MDMPanel.Location = new System.Drawing.Point(12, 338);
            this.MDMPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MDMPanel.Name = "MDMPanel";
            this.MDMPanel.ShadowDecoration.BorderRadius = 10;
            this.MDMPanel.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.MDMPanel.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.MDMPanel.ShadowDecoration.Enabled = true;
            this.MDMPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.MDMPanel.Size = new System.Drawing.Size(550, 167);
            this.MDMPanel.TabIndex = 69;
            this.MDMPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MDMPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // A12Panel
            // 
            this.A12Panel.BackColor = System.Drawing.Color.Transparent;
            this.A12Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.A12Panel.BorderRadius = 10;
            this.A12Panel.BorderThickness = 1;
            this.A12Panel.Controls.Add(this.SkipSX);
            this.A12Panel.Controls.Add(this.AutoOTA);
            this.A12Panel.Controls.Add(this.label16);
            this.A12Panel.Controls.Add(this.label15);
            this.A12Panel.Controls.Add(this.label7);
            this.A12Panel.Controls.Add(this.label6);
            this.A12Panel.Controls.Add(this.guna2GradientButton2);
            this.A12Panel.Controls.Add(this.ActivateButton);
            this.A12Panel.CustomizableEdges.TopLeft = false;
            this.A12Panel.CustomizableEdges.TopRight = false;
            this.A12Panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.A12Panel.Location = new System.Drawing.Point(12, 338);
            this.A12Panel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.A12Panel.Name = "A12Panel";
            this.A12Panel.ShadowDecoration.BorderRadius = 10;
            this.A12Panel.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.A12Panel.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.A12Panel.ShadowDecoration.Enabled = true;
            this.A12Panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.A12Panel.Size = new System.Drawing.Size(550, 167);
            this.A12Panel.TabIndex = 70;
            this.A12Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.A12Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // SkipSX
            // 
            this.SkipSX.AutoSize = true;
            this.SkipSX.Checked = true;
            this.SkipSX.CheckedState.BorderColor = System.Drawing.Color.Teal;
            this.SkipSX.CheckedState.BorderRadius = 0;
            this.SkipSX.CheckedState.BorderThickness = 0;
            this.SkipSX.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.SkipSX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SkipSX.Location = new System.Drawing.Point(432, 38);
            this.SkipSX.Name = "SkipSX";
            this.SkipSX.Size = new System.Drawing.Size(81, 19);
            this.SkipSX.TabIndex = 24;
            this.SkipSX.Text = "Skip Setup";
            this.SkipSX.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SkipSX.UncheckedState.BorderRadius = 0;
            this.SkipSX.UncheckedState.BorderThickness = 0;
            this.SkipSX.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SkipSX.CheckedChanged += new System.EventHandler(this.SkipSX_CheckedChanged);
            // 
            // AutoOTA
            // 
            this.AutoOTA.AutoSize = true;
            this.AutoOTA.CheckedState.BorderColor = System.Drawing.Color.Teal;
            this.AutoOTA.CheckedState.BorderRadius = 0;
            this.AutoOTA.CheckedState.BorderThickness = 0;
            this.AutoOTA.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.AutoOTA.Location = new System.Drawing.Point(432, 13);
            this.AutoOTA.Name = "AutoOTA";
            this.AutoOTA.Size = new System.Drawing.Size(111, 19);
            this.AutoOTA.TabIndex = 23;
            this.AutoOTA.Text = "Block OTA/Erase";
            this.AutoOTA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AutoOTA.UncheckedState.BorderRadius = 0;
            this.AutoOTA.UncheckedState.BorderThickness = 0;
            this.AutoOTA.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AutoOTA.CheckedChanged += new System.EventHandler(this.AutoOTA_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label16.Location = new System.Drawing.Point(21, 36);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(268, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "AND iOS 26.0.1/26.1 FOR iPHONE 11 AND NEWER";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label15.Location = new System.Drawing.Point(20, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(371, 15);
            this.label15.TabIndex = 21;
            this.label15.Text = "PLEASE MAKE SURE YOU ARE ON IOS 18.7.1/18.7.2 on Xr/XS/XS Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label7.Location = new System.Drawing.Point(20, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "iPads :  2020 and newer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.label6.Location = new System.Drawing.Point(20, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "iPhones : XS to 17 Pro Max";
            // 
            // status2
            // 
            this.status2.BackColor = System.Drawing.Color.Transparent;
            this.status2.BorderRadius = 10;
            this.status2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.status2.DefaultText = resources.GetString("status2.DefaultText");
            this.status2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.status2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.status2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.status2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.status2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.status2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.status2.ForeColor = System.Drawing.Color.Teal;
            this.status2.Location = new System.Drawing.Point(580, 108);
            this.status2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.status2.Multiline = true;
            this.status2.Name = "status2";
            this.status2.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.status2.PlaceholderText = "";
            this.status2.ReadOnly = true;
            this.status2.SelectedText = "";
            this.status2.ShadowDecoration.BorderRadius = 10;
            this.status2.ShadowDecoration.Enabled = true;
            this.status2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.status2.Size = new System.Drawing.Size(286, 346);
            this.status2.TabIndex = 71;
            this.status2.TabStop = false;
            // 
            // A12B
            // 
            this.A12B.BackColor = System.Drawing.Color.Transparent;
            this.A12B.BorderRadius = 6;
            this.A12B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A12B.CustomizableEdges.BottomLeft = false;
            this.A12B.CustomizableEdges.BottomRight = false;
            this.A12B.CustomizableEdges.TopRight = false;
            this.A12B.FillColor = System.Drawing.Color.Transparent;
            this.A12B.FillColor2 = System.Drawing.Color.Transparent;
            this.A12B.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A12B.ForeColor = System.Drawing.Color.White;
            this.A12B.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.A12B.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.A12B.Location = new System.Drawing.Point(12, 302);
            this.A12B.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.A12B.Name = "A12B";
            this.A12B.ShadowDecoration.BorderRadius = 0;
            this.A12B.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.A12B.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.A12B.ShadowDecoration.Enabled = true;
            this.A12B.Size = new System.Drawing.Size(134, 37);
            this.A12B.TabIndex = 72;
            this.A12B.Text = "A12+ XS-17PM";
            this.A12B.Click += new System.EventHandler(this.A12B_Click);
            // 
            // MDMB
            // 
            this.MDMB.BackColor = System.Drawing.Color.Transparent;
            this.MDMB.BorderRadius = 6;
            this.MDMB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MDMB.FillColor = System.Drawing.Color.Transparent;
            this.MDMB.FillColor2 = System.Drawing.Color.Transparent;
            this.MDMB.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MDMB.ForeColor = System.Drawing.Color.White;
            this.MDMB.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.MDMB.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.MDMB.Location = new System.Drawing.Point(150, 302);
            this.MDMB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MDMB.Name = "MDMB";
            this.MDMB.ShadowDecoration.BorderRadius = 0;
            this.MDMB.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.MDMB.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.MDMB.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.MDMB.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.MDMB.ShadowDecoration.Enabled = true;
            this.MDMB.Size = new System.Drawing.Size(134, 37);
            this.MDMB.TabIndex = 73;
            this.MDMB.Text = "MDM All";
            this.MDMB.Click += new System.EventHandler(this.MDMB_Click);
            // 
            // RamdiskB
            // 
            this.RamdiskB.BackColor = System.Drawing.Color.Transparent;
            this.RamdiskB.BorderRadius = 6;
            this.RamdiskB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RamdiskB.FillColor = System.Drawing.Color.Transparent;
            this.RamdiskB.FillColor2 = System.Drawing.Color.Transparent;
            this.RamdiskB.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RamdiskB.ForeColor = System.Drawing.Color.White;
            this.RamdiskB.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.RamdiskB.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.RamdiskB.Location = new System.Drawing.Point(289, 302);
            this.RamdiskB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RamdiskB.Name = "RamdiskB";
            this.RamdiskB.ShadowDecoration.BorderRadius = 0;
            this.RamdiskB.ShadowDecoration.Enabled = true;
            this.RamdiskB.Size = new System.Drawing.Size(134, 37);
            this.RamdiskB.TabIndex = 74;
            this.RamdiskB.Text = "Ramdisk 6-X";
            this.RamdiskB.Click += new System.EventHandler(this.RamdiskB_Click);
            // 
            // JailbreakB
            // 
            this.JailbreakB.BackColor = System.Drawing.Color.Transparent;
            this.JailbreakB.BorderRadius = 6;
            this.JailbreakB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JailbreakB.FillColor = System.Drawing.Color.Transparent;
            this.JailbreakB.FillColor2 = System.Drawing.Color.Transparent;
            this.JailbreakB.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JailbreakB.ForeColor = System.Drawing.Color.White;
            this.JailbreakB.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.JailbreakB.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.JailbreakB.Location = new System.Drawing.Point(428, 302);
            this.JailbreakB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.JailbreakB.Name = "JailbreakB";
            this.JailbreakB.ShadowDecoration.BorderRadius = 0;
            this.JailbreakB.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.JailbreakB.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.JailbreakB.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.JailbreakB.ShadowDecoration.Enabled = true;
            this.JailbreakB.Size = new System.Drawing.Size(134, 37);
            this.JailbreakB.TabIndex = 75;
            this.JailbreakB.Text = "Jailbreak 5s-X";
            this.JailbreakB.Click += new System.EventHandler(this.JailbreakB_Click);
            // 
            // ToolBoxB
            // 
            this.ToolBoxB.BackColor = System.Drawing.Color.Transparent;
            this.ToolBoxB.BorderRadius = 8;
            this.ToolBoxB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToolBoxB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.ToolBoxB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBoxB.ForeColor = System.Drawing.Color.White;
            this.ToolBoxB.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            this.ToolBoxB.Location = new System.Drawing.Point(732, 51);
            this.ToolBoxB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ToolBoxB.Name = "ToolBoxB";
            this.ToolBoxB.Size = new System.Drawing.Size(134, 44);
            this.ToolBoxB.TabIndex = 76;
            this.ToolBoxB.Text = "Tool Box";
            this.ToolBoxB.Click += new System.EventHandler(this.ToolBoxB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 77;
            this.label1.Text = "iSkorpion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(74, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 78;
            this.label2.Text = "iOSTool All in One: v6.9.4";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.Transparent;
            this.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.FooterPanel.BorderThickness = 1;
            this.FooterPanel.Controls.Add(this.pictureBox5);
            this.FooterPanel.Controls.Add(this.pictureBox6);
            this.FooterPanel.Controls.Add(this.label3);
            this.FooterPanel.Location = new System.Drawing.Point(-56, 520);
            this.FooterPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.FooterPanel.ShadowDecoration.Depth = 100;
            this.FooterPanel.ShadowDecoration.Enabled = true;
            this.FooterPanel.Size = new System.Drawing.Size(944, 38);
            this.FooterPanel.TabIndex = 79;
            this.FooterPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.FooterPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(37, 14);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 16);
            this.pictureBox5.TabIndex = 77;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(9, 14);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(16, 16);
            this.pictureBox6.TabIndex = 77;
            this.pictureBox6.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(407, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Copyright 2020 - 2025  | iSkorpion";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 552);
            this.Controls.Add(this.DriversBTN);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StorageBar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ToolBoxB);
            this.Controls.Add(this.JailbreakB);
            this.Controls.Add(this.RamdiskB);
            this.Controls.Add(this.MDMB);
            this.Controls.Add(this.A12B);
            this.Controls.Add(this.status2);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.ModelLBL);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.UCIDLBL);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.DiskLBL);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.lblTotalBytesReceived);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ReadBTN);
            this.Controls.Add(this.BATTLBL);
            this.Controls.Add(this.CPIDLBL);
            this.Controls.Add(this.BDIDLBL);
            this.Controls.Add(this.BuildLBL);
            this.Controls.Add(this.HardLBL);
            this.Controls.Add(this.JailbreakPanel);
            this.Controls.Add(this.RamdiskPanel);
            this.Controls.Add(this.A12Panel);
            this.Controls.Add(this.MDMPanel);
            this.Controls.Add(this.ToolsPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iOSTool All in One";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDC)).EndInit();
            this.RamdiskPanel.ResumeLayout(false);
            this.RamdiskPanel.PerformLayout();
            this.JailbreakPanel.ResumeLayout(false);
            this.JailbreakPanel.PerformLayout();
            this.ToolsPanel.ResumeLayout(false);
            this.MDMPanel.ResumeLayout(false);
            this.MDMPanel.PerformLayout();
            this.A12Panel.ResumeLayout(false);
            this.A12Panel.PerformLayout();
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void Status2_LinkClicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
        {
          
            Process.Start(e.LinkText);
        }

        #endregion
        private System.Windows.Forms.Label iOSLBL;
        private System.Windows.Forms.Label JBLBL;
        private System.Windows.Forms.Label ActLBL;
        private System.Windows.Forms.Label ProdLBL;
        private System.Windows.Forms.Label ModelLBL;
        private System.Windows.Forms.Label IMEILBL;
        private System.Windows.Forms.Label SNLBL;
        private System.Windows.Forms.Label ECIDLBL;
        private System.Windows.Forms.Label UDIDLBL;
        private System.Windows.Forms.Label BATTLBL;
        private System.Windows.Forms.Label DiskLBL;
        private System.Windows.Forms.Label NameLBL;
        private Guna.UI2.WinForms.Guna2Button DriversBTN;
        private System.Windows.Forms.Label CPIDLBL;
        private System.Windows.Forms.Label BDIDLBL;
        private System.Windows.Forms.Label MODELBL;
        private Guna.UI2.WinForms.Guna2Button TestModeBTN;
        private Guna.UI2.WinForms.Guna2Button PWNDFUBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button MDMBTN;
        private System.Windows.Forms.Label BuildLBL;
        private System.Windows.Forms.Label HardLBL;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button RamFolder;
        private Guna.UI2.WinForms.Guna2Button BackupsBTN;
        private Guna.UI2.WinForms.Guna2Button BackupDown;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2Button button2;
        private Guna.UI2.WinForms.Guna2Button button3;
        private Guna.UI2.WinForms.Guna2Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button ExitRamdiskBTN;
        private Guna.UI2.WinForms.Guna2Button EraseBTNR;
        private Guna.UI2.WinForms.Guna2Button LogoutBTNR;
        private Guna.UI2.WinForms.Guna2Button PasscodeBTNR;
        private Guna.UI2.WinForms.Guna2Button HelloBTNR;
        private Guna.UI2.WinForms.Guna2Button DisableBBJ;
        private Guna.UI2.WinForms.Guna2Button EnableBBJ;
        private Guna.UI2.WinForms.Guna2Button LogoutBTNJ;
        private Guna.UI2.WinForms.Guna2Button EraseBTNJ;
        private Guna.UI2.WinForms.Guna2Button PatchBTN;
        private Guna.UI2.WinForms.Guna2Button BrokenBBJ;
        private Guna.UI2.WinForms.Guna2Button PasscodeBackBTNJ;
        private Guna.UI2.WinForms.Guna2Button HelloBTNJ;
        private Guna.UI2.WinForms.Guna2Button PasscodeActBTNJ;
        private Guna.UI2.WinForms.Guna2Button ReadBTN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblTotalBytesReceived;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label UCIDLBL;
        private Guna.UI2.WinForms.Guna2Button BackupRD;
        private Guna.UI2.WinForms.Guna2Button GSMBTN;
        Guna.UI2.WinForms.Guna2Button ConnectSSHBTN;
        Guna.UI2.WinForms.Guna2Button ManBootBTN;
        private Guna.UI2.WinForms.Guna2Button PWNMan;
        private Label label11;
        private Guna.UI2.WinForms.Guna2Panel HeaderPanel;
        private Guna.UI2.WinForms.Guna2Panel InfoPanel;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Guna.UI2.WinForms.Guna2ProgressBar StorageBar;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar1;
        private Guna.UI2.WinForms.Guna2Button guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2Button ActivateButton;
        private Guna.UI2.WinForms.Guna2Panel RamdiskPanel;
        private Guna.UI2.WinForms.Guna2Panel JailbreakPanel;
        private Guna.UI2.WinForms.Guna2Panel ToolsPanel;
        private Guna.UI2.WinForms.Guna2Panel MDMPanel;
        private Guna.UI2.WinForms.Guna2Panel A12Panel;
        private Guna.UI2.WinForms.Guna2RadioButton RD15;
        private Guna.UI2.WinForms.Guna2RadioButton JB1518;
        private Guna.UI2.WinForms.Guna2RadioButton JB1214;
        private Guna.UI2.WinForms.Guna2RadioButton RD17;
        private Guna.UI2.WinForms.Guna2RadioButton RD16;
        private Guna.UI2.WinForms.Guna2CheckBox AirPlaneMode;
        private Guna.UI2.WinForms.Guna2TextBox status2;
        private Guna.UI2.WinForms.Guna2GradientButton A12B;
        private Guna.UI2.WinForms.Guna2GradientButton MDMB;
        private Guna.UI2.WinForms.Guna2GradientButton RamdiskB;
        private Guna.UI2.WinForms.Guna2GradientButton JailbreakB;
        private Guna.UI2.WinForms.Guna2Button ToolBoxB;
        private PictureBox pictureBoxDC;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Panel FooterPanel;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label16;
        private Label label15;
        private Label RegionLBL;
        private PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CheckBox AutoOTA;
        private Guna.UI2.WinForms.Guna2CheckBox SkipSX;
    }
}

