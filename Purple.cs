using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Net;

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

using Ionic.Zip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic;

namespace iSkorpionAiO_RE
{
    public class Purple : Form
    {
        public static string Purplelink = "http://SERVERURL/purple/";
        [CompilerGenerated]
        private sealed class c00000a
        {
            public Purple f000004;
            

            public string old;

            internal void m000004()
            {
                while (true)
                {
                    int num = Math.Abs(-3);
                    while (true)
                    {
                        switch (num)
                        {
                            case 0:
                                f000004.connectserial.Enabled = false;
                                num = Math.Abs(-2);
                                continue;
                            case 2:
                                f000004.bootpurple.Enabled = false;
                                num = Math.Abs(-1);
                                continue;
                            case 3:
                                f000004.bootpurple.Text = "Booting...";
                                num = Math.Abs(0);
                                continue;
                            case 1:
                                f000004.snwrite.Enabled = true;
                                return;
                        }
                        break;
                    }
                }
            }

            internal void m000005()
            {
                while (true)
                {
                    int num = Math.Abs(-3);
                    while (true)
                    {
                        switch (num)
                        {
                            case 0:
                                f000004.bootpurple.Text = old;
                                num = Math.Abs(-2);
                                continue;
                            case 2:
                                f000004.connectserial.Enabled = true;
                                num = Math.Abs(-1);
                                continue;
                            case 3:
                                f000004.Clean_Diags();
                                num = Math.Abs(0);
                                continue;
                            case 1:
                                f000004.bootpurple.Enabled = false;
                                f000004.snwrite.Enabled = true;
                                return;
                        }
                        break;
                    }
                }
            }
        }

        [CompilerGenerated]
        private sealed class c00000b
        {
            public Exception ex;

            public c00000a f000005;

            internal void m000006()
            {
                while (true)
                {
                    int num = Math.Abs(-3);
                    while (true)
                    {
                        switch (num)
                        {
                            case 0:
                                f000005.f000004.bootpurple.Text = f000005.old;
                                num = Math.Abs(-2);
                                continue;
                            case 2:
                                f000005.f000004.connectserial.Enabled = true;
                                num = Math.Abs(-1);
                                continue;
                            case 3:
                                f000005.f000004.Clean_Diags();
                                num = Math.Abs(0);
                                continue;
                            case 1:
                                f000005.f000004.bootpurple.Enabled = true;
                                f000005.f000004.snwrite.Enabled = true;
                                MessageBox.Show(ex.Message);
                                return;
                        }
                        break;
                    }
                }
            }
        }

        public static string ToolDir;
        public string string_1;

        public static string Irecoveryexe;

        public static string imobileinfo;

        public static string libzip;

        public static string f000001;

        public static string string_4;

        public static string LibsFolder;

        public static string string_6;

        private HttpClientDownloadWithProgress downloader = null;

        public static string string_7;

        public static string string_8;

        public static string string_9;

        public static string Irecoveryexe0;

        public static string Irecoveryexe1;

        private string Irecoveryexe2 = "";



        public static string Irecoveryexe4;

        public static string Irecoveryexe5;

        public static string Irecoveryexe6;

        public static string Irecoveryexe7;

        public static string Irecoveryexe8;
        private static string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
        private static string Npath1 = AppData + "Apple Computer\\Logs\\";
        private static string Npath2 = AppData + "Apple Computer\\MobileSync\\";
        private static string Npath3 = AppData + "Apple Computer\\iTunes\\";

        private SerialPort serialPort_0;

        private string Irecoveryexe9;

        private FileStream fileStream_0;
        private static string SIXRD;

        public static string imobileinfo0;

        public static string imobileinfo1;



        private IContainer icontainer_0;

        private Label ECID_TEXT;

        private BackgroundWorker backgroundWorker_0;


        private Label status;
        private System.Windows.Forms.Button snwrite;
        private Label label3;
        private Label label2;
        private Label pwnstat;
        private Label label8;
        private Label devbdid;
        private Label devcpid;
        private Label devname;
        private Label devmodel;
        private Label devproduct;
        private Label label6;
        private Label label5;
        private Label label4;
        private CheckBox mtsncheck;
        private CheckBox fcmscheck;
        private CheckBox bcmscheck;
        private CheckBox batterycheck;
        private CheckBox lcmcheck;
        private CheckBox nsrncheck;
        private CheckBox nvsncheck;
        private CheckBox modelcheck;
        private System.Windows.Forms.Button mtsnwrite;
        private System.Windows.Forms.Button fcmswrite;
        private System.Windows.Forms.Button bcmswrite;
        private System.Windows.Forms.Button batterywrite;
        private System.Windows.Forms.Button lcmwrite;
        private System.Windows.Forms.Button nsrnwrite;
        private System.Windows.Forms.Button nvsnwrite;
        private System.Windows.Forms.Button modelwrite;
        private CheckBox mlbcheck;
        private CheckBox emaccheck;
        private CheckBox bmaccheck;
        private CheckBox wificheck;
        private CheckBox colorcheck;
        private CheckBox regioncheck;
        private CheckBox modecheck;
        private CheckBox sncheck;
        private System.Windows.Forms.Button mlbwrite;
        private System.Windows.Forms.Button emacwrite;
        private System.Windows.Forms.Button btmacwrite;
        private System.Windows.Forms.Button wifiwrite;
        private System.Windows.Forms.Button colorwrite;
        private System.Windows.Forms.Button regionwrite;
        private System.Windows.Forms.Button modewrite;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;

        public string sn;

        public string mode;

        public string regn;

        public string color;

        public string color_housing;

        public string wifi;

        public string bmac;

        public string emac;

        public string mlb;

        public string model;

        public string model_name;

        public string nvsn;

        public string nsrn;

        public string lcm;

        public string battery;

        public string bcms;

        public string fcms;

        public string mtsn;

        public string template_color = "";
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Button ButtonX;
        private System.Windows.Forms.Button writeselected;
        private System.Windows.Forms.Button readdfudevice;
        private System.Windows.Forms.Button bootpurple;
        private System.Windows.Forms.Button connectserial;
        private System.Windows.Forms.Button readsyscfg;
        private System.Windows.Forms.Button savesyscfg;
        private System.Windows.Forms.Button fixcamera;
        private System.Windows.Forms.Button fixfacetime;
        private System.Windows.Forms.Button unbindwifi;
        private System.Windows.Forms.Button factoryreset;
        private System.Windows.Forms.Button exitpurple;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox snbox;
        private System.Windows.Forms.TextBox modebox;
        private System.Windows.Forms.TextBox regionbox;
        private System.Windows.Forms.TextBox wifibox;
        private System.Windows.Forms.TextBox bmacbox;
        private System.Windows.Forms.TextBox emacbox;
        private System.Windows.Forms.TextBox mlbbox;
        private System.Windows.Forms.TextBox modelbox;
        private System.Windows.Forms.TextBox nvsnbox;
        private System.Windows.Forms.TextBox nsrnbox;
        private System.Windows.Forms.TextBox lcmbox;
        private System.Windows.Forms.TextBox batterybox;
        private System.Windows.Forms.TextBox bcmsbox;
        private System.Windows.Forms.TextBox fcmsbox;
        private System.Windows.Forms.TextBox mtsnbox;
        private System.Windows.Forms.Button dcsdlist;
        private System.Windows.Forms.ComboBox metroComboBox1;
        private Label label7;
        private Label label9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private System.Windows.Forms.TextBox textBox1;
        public string key;

        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern bool IsWow64Process(IntPtr hProcess, out bool Wow64Process);

        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern bool Wow64DisableWow64FsRedirection(out IntPtr OldValue);


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        private const int WM_VSCROLL = 0x115;
        private const int SB_BOTTOM = 7;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public IntPtr txs = new IntPtr(HT_CAPTION);


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Purple()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.MouseDown += new MouseEventHandler(Purple_MouseDown);
            this.FormBorderStyle = FormBorderStyle.None;
            serialPort_0 = new SerialPort();

            NewPurple();
        }

        private void Purple_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, txs, (IntPtr)0);
            }
        }

        public void method_0(string pathDrivers)
        {
            if (!Directory.Exists(pathDrivers))
            {
                Directory.CreateDirectory(pathDrivers);
            }
        }

        private void snChangeForm_Load(object sender, EventArgs e)
        {
            Thread xx = new Thread(readDFU);
            xx.IsBackground = true;
            xx.Start();
        }

        [DllImport("Setupapi.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void InstallHinfSection([In] IntPtr hwnd, [In] IntPtr ModuleHandle, [In][MarshalAs(UnmanagedType.LPWStr)] string CmdLineBuffer, int nCmdShow);

        public bool method_1()
        {
            try
            {
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = Irecoveryexe,
                    Arguments = "-q",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                process.Start();
                process.WaitForExit();
                string text = process.StandardOutput.ReadToEnd();
                if (text.Contains("ERROR"))
                {
                    return false;
                }
                bool result = true;
                string[] array = text.Split('\n');
                for (int i = 0; i < array.Length; i++)
                {
                    string text2 = array[i].Replace("\r", "");
                    if (text2.StartsWith("ECID: "))
                    {
                        string_9 = text2.Replace("ECID: 0x", "");
                        ECID_TEXT.Text = "0x" + string_9;
                    }
                    else if (text2.StartsWith("PWND: "))
                    {
                        var text3 = text2.Replace("PWND: ", "");
                        iOSDevicex.ipwndfu = text3;
                        label3.Text = text3;
                    }
                    else if (text2.StartsWith("NAME: "))
                    {
                        var text3 = text2.Replace("NAME: ", "");
                        iOSDevicex.ipwndfu = text3;
                        devname.Text = text3;
                    }
                    else if (text2.StartsWith("CPID: 0x"))
                    {
                        var text3 = text2.Replace("CPID: 0x", "");
                        iOSDevicex.ipwndfu = text3;
                        devcpid.Text = text3;
                    }
                    else if (text2.StartsWith("BDID: 0x"))
                    {
                        var text3 = text2.Replace("BDID: 0x", "");
                        iOSDevicex.ipwndfu = text3;
                        devbdid.Text = text3;
                    }
                    else if (text2.StartsWith("MODEL: "))
                    {
                        var text3 = text2.Replace("MODEL: ", "");
                        iOSDevicex.ipwndfu = text3;
                        devmodel.Text = text3;
                    }

                    else if (text2.StartsWith("PRODUCT: "))
                    {
                        string_6 = text2.Replace("PRODUCT: ", "");
                        devproduct.Text = string_6;
                    }
                    NewPurple();
                }
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }



        private void boot_btn_Click(object sender, EventArgs e)
        {


        }

        public void EnableALL()
        {
            bootpurple.Enabled = true;
            bootpurple.Text = "Boot Purple";
            connectserial.Enabled = true;
            snwrite.Enabled = true;
            factoryreset.Enabled = true;

            readdfudevice.Enabled = true;



        }
        public string method_3()
        {
            if (serialPort_0.IsOpen)
            {
                try
                {
                    string text = serialPort_0.ReadExisting();
                    Irecoveryexe4 += text;
                }
                catch (Exception ex)
                {
                    std(ex.Message + "Is there a problem with your baud rate?？？？");
                    return Irecoveryexe4;
                }
                serialPort_0.DiscardInBuffer();
                return Irecoveryexe4;
            }
            std("Please open a serial port");
            return Irecoveryexe4;
        }

        public void method_4()
        {
            if (serialPort_0.IsOpen)
            {

                return;
            }
            try
            {
                if (metroComboBox1.SelectedIndex == -1)
                {
                    status.Text = "Invalid Port!!!";
                    status.ForeColor = Color.Red;
                    return;
                }
                string portName = metroComboBox1.SelectedItem.ToString();
                string value = "8";
                int baudRate = Convert.ToInt32("9600");
                int dataBits = Convert.ToInt32(value);
                serialPort_0.PortName = portName;
                serialPort_0.BaudRate = baudRate;
                serialPort_0.DataBits = dataBits;
                serialPort_0.StopBits = StopBits.One;
                serialPort_0.Parity = Parity.None;
                if (Irecoveryexe9 != null)
                {
                    fileStream_0 = File.Create(Irecoveryexe9);
                }
                serialPort_0.Open();
                metroComboBox1.Enabled = true;
                bootpurple.Enabled = false;
                snwrite.Enabled = true;
                factoryreset.Enabled = true;
                serialPort_0.WriteLine("sn");
                method_3();
            }
            catch (Exception ex)
            {
                status.Text = "Error! : " + ex.Message;
                status.ForeColor = Color.Red;
            }
        }

        private void method_5()
        {
            try
            {
                metroComboBox1.Text = "";
                metroComboBox1.Items.Clear();
                string[] portNames = SerialPort.GetPortNames();
                foreach (string item in portNames)
                {
                    metroComboBox1.Items.Add(item);
                }
                metroComboBox1.SelectedIndex = 0;
            }
            catch (Exception)
            {
                status.Text = "No Serial Port Detected!";
                status.ForeColor = Color.Red;
            }
            metroComboBox1.Enabled = true;
        }

        private void method_6(object sender, EventArgs e)
        {
        }

        private void ECID_TEXT_Click(object sender, EventArgs e)
        {
        }

        private void checkConn_btn_Click(object sender, EventArgs e)
        {

        }

        private void snChangeForm_Shown(object sender, EventArgs e)
        {

            snwrite.Enabled = true;
            bootpurple.Enabled = true;
            backgroundWorker_0.DoWork += backgroundWorker_0_DoWork;
            backgroundWorker_0.ProgressChanged += backgroundWorker_0_ProgressChanged;
            backgroundWorker_0.RunWorkerCompleted += backgroundWorker_0_RunWorkerCompleted;
            backgroundWorker_0.WorkerReportsProgress = true;
            backgroundWorker_0.WorkerSupportsCancellation = true;
        }

        public void Boot_Diags()
        {
            string diag = Npath2 + SIXRD + "\\diag.img4";
            string iboot = Npath2 + SIXRD + "\\iBoot.img4";
            string ibec = Npath2 + SIXRD + "\\ibec.img4";
            string ibss = Npath2 + SIXRD + "\\ibss.img4";
            try
            {
                Process process = new Process();
                if (File.Exists(iboot))
                {
                    new Process();
                    process.StartInfo.FileName = Irecoveryexe;
                    process.StartInfo.Arguments = "-f " + '\u0022' + iboot + '\u0022';
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    Thread.Sleep(3000);
                    backgroundWorker_0.ReportProgress(20);
                    new Process();
                    process.StartInfo.FileName = Irecoveryexe;
                    process.StartInfo.Arguments = "-f " + '\u0022' + iboot + '\u0022';
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    Thread.Sleep(3000);
                }
                if (File.Exists(ibss))
                {
                    new Process();
                    process.StartInfo.FileName = Irecoveryexe;
                    process.StartInfo.Arguments = "-f " + '\u0022' + ibss + '\u0022';
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    Thread.Sleep(3000);
                    backgroundWorker_0.ReportProgress(20);
                    new Process();
                    process.StartInfo.FileName = Irecoveryexe;
                    process.StartInfo.Arguments = "-f " + '\u0022' + ibss + '\u0022';
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    Thread.Sleep(3000);
                    backgroundWorker_0.ReportProgress(25);
                    new Process();
                    process.StartInfo.FileName = Irecoveryexe;
                    process.StartInfo.Arguments = "-f " + '\u0022' + ibec + '\u0022';
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    Thread.Sleep(3000);
                }
                backgroundWorker_0.ReportProgress(30);
                new Process();
                process.StartInfo.FileName = Irecoveryexe;
                process.StartInfo.Arguments = "-c \"setenv boot-args usbserial=enabled\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                backgroundWorker_0.ReportProgress(50);
                new Process();
                process.StartInfo.FileName = Irecoveryexe;
                process.StartInfo.Arguments = "-c saveenv";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                backgroundWorker_0.ReportProgress(70);
                new Process();
                process.StartInfo.FileName = Irecoveryexe;
                process.StartInfo.Arguments = "-f " + '\u0022' + diag + '\u0022';
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                backgroundWorker_0.ReportProgress(80);
                new Process();
                process.StartInfo.FileName = Irecoveryexe;
                process.StartInfo.Arguments = "-c go";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                backgroundWorker_0.ReportProgress(100);
            }
            catch (Exception)
            {
                status.Text = "ERROR: theres a problem when booting device!";
                status.ForeColor = Color.Red;
            }
        }

        private void Diags_Download()
        {




        }

        public void Clean_Diags()
        {
            if (File.Exists(Npath1 + SIXRD + ".zip"))
            {
                File.Delete(Npath1 + SIXRD + ".zip");
            }
            if (Directory.Exists(Npath2 + SIXRD))
            {
                Directory.Delete(Npath2 + SIXRD, recursive: true);
            }
            if (File.Exists(Npath3 + "diag.img4"))
            {
                File.Delete(Npath3 + "diag.img4");
            }
            if (File.Exists(Npath3 + "iBoot.img4"))
            {
                File.Delete(Npath3 + "iBoot.img4");
            }
        }

        public void method_10()
        {
            string[] array = Classx.smethod_0();
            for (int i = 0; i < array.Length; i++)
            {
                Classx @class = new Classx(array[i]);
                try
                {
                    if (@class.String_1 == "")
                    {
                        std("there's no installed drivers");
                    }
                    if (@class.String_1 == "USBAAPL64.CAT" || @class.String_1 == "usbaapl64.cat")
                    {
                        Irecoveryexe2 = @class.String_0;
                    }
                }
                catch (Exception ex)
                {
                    std(ex.Message);
                }
            }
        }

        public void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            imobileinfo0 = LibsFolder + "\\" + string_6 + "\\iBoot.img4";
            Irecoveryexe7 = LibsFolder + "\\" + string_6 + "\\diag.img4";
            Irecoveryexe1 = LibsFolder + "\\" + string_6 + "\\ibec.img4";
            imobileinfo1 = LibsFolder + "\\" + string_6 + "\\ibss.img4";
            string old = bootpurple.Text;
            BeginInvoke((Action)delegate
            {
                while (true)
                {
                    int num3 = Math.Abs(-3);
                    while (true)
                    {
                        switch (num3)
                        {
                            case 0:
                                connectserial.Enabled = false;
                                num3 = Math.Abs(-2);
                                continue;
                            case 2:
                                bootpurple.Enabled = false;
                                num3 = Math.Abs(-1);
                                continue;
                            case 3:
                                bootpurple.Text = "Booting...";
                                num3 = Math.Abs(0);
                                continue;
                            case 1:
                                snwrite.Enabled = true;
                                return;
                        }
                        break;
                    }
                }
            });
            try
            {
                newShetouane Purple_0 = new newShetouane();
                if (label3.Text.ToLower() != "gaster")
                {
                    Clean_Diags();
                    std("**Go enter pwndfu First!");

                }
                backgroundWorker_0.ReportProgress(5);


                backgroundWorker_0.ReportProgress(10);
                try
                {
                    string source = Npath1 + SIXRD + ".zip";
                    string dest = Npath2 + SIXRD;
                    string source2 = dest + "\\diag.img4";
                    string source3 = dest + "\\iBoot.img4";

                    Extract(source, dest);
                    Thread.Sleep(2000);

                }
                catch (Exception exs)
                {
                    status.Text = exs.Message;
                    status.ForeColor = Color.Red;
                    EnableALL();
                    return;
                }
                Boot_Diags();
                Thread.Sleep(2000);
                Clean_Diags();
                if (Purple_0.CheckDeviceMode(Irecoveryexe))
                {
                    Clean_Diags();
                    std("Failed to boot purple mode");

                }



                BeginInvoke((Action)delegate
                {
                    while (true)
                    {
                        int num2 = Math.Abs(-3);
                        while (true)
                        {
                            switch (num2)
                            {
                                case 0:
                                    bootpurple.Text = old;
                                    num2 = Math.Abs(-2);
                                    continue;
                                case 2:
                                    connectserial.Enabled = true;
                                    num2 = Math.Abs(-1);
                                    continue;
                                case 3:
                                    Clean_Diags();
                                    num2 = Math.Abs(0);
                                    continue;
                                case 1:
                                    bootpurple.Enabled = false;
                                    snwrite.Enabled = true;
                                    return;
                            }
                            break;
                        }
                    }
                });
                method_10();

                newShetouane shit = new newShetouane();
                shit.RemoveDriver(Irecoveryexe2);
                method_0(Irecoveryexe6);
                method_12(Irecoveryexe6);
                smethod_0(Irecoveryexe5 + "\\serial\\", Irecoveryexe6);
                method_11();
                label3.Text = "NA";
                status.Text = "Done Booting!";
                status.ForeColor = Color.Orange;
                MessageBox.Show("**Please reconnect your device then: \n1-Select last COM Port from list\n2-Click Connect Serial Port!\n", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex2)
            {
                Exception ex3 = ex2;
                Exception ex = ex3;
                BeginInvoke((Action)delegate
                {
                    while (true)
                    {
                        int num = Math.Abs(-3);
                        while (true)
                        {
                            switch (num)
                            {
                                case 0:
                                    bootpurple.Text = old;
                                    num = Math.Abs(-2);
                                    continue;
                                case 2:
                                    connectserial.Enabled = true;
                                    num = Math.Abs(-1);
                                    continue;
                                case 3:
                                    Clean_Diags();
                                    num = Math.Abs(0);
                                    continue;
                                case 1:
                                    bootpurple.Enabled = true;
                                    snwrite.Enabled = true;
                                    MessageBox.Show(ex.Message);
                                    return;
                            }
                            break;
                        }
                    }
                });
            }
        }

        public void method_11()
        {
            bool Wow64Process = false;
            IsWow64Process(Process.GetCurrentProcess().Handle, out Wow64Process);
            if (Wow64Process)
            {
                IntPtr OldValue = IntPtr.Zero;
                Wow64DisableWow64FsRedirection(out OldValue);
            }
            X509Certificate2 certificate = new X509Certificate2(Convert.FromBase64String("MIIF4zCCA8ugAwIBAgIQfrCvAZdwF6VF9pnqOIn2EjANBgkqhkiG9w0BAQsFADBjMWEwXwYDVQQDHlgAVQBTAEIAXABWAEkARABfADAANQBBAEMAJgBQAEkARABfADEAMgAyADcAIAAoAGwAaQBiAHcAZABpACAAYQB1AHQAbwBnAGUAbgBlAHIAYQB0AGUAZAApMB4XDTIyMDQxOTE2NDkxMloXDTI5MDEwMTAwMDAwMFowYzFhMF8GA1UEAx5YAFUAUwBCAFwAVgBJAEQAXwAwADUAQQBDACYAUABJAEQAXwAxADIAMgA3ACAAKABsAGkAYgB3AGQAaQAgAGEAdQB0AG8AZwBlAG4AZQByAGEAdABlAGQAKTCCAiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBAJBkH9v5lQGa3oRf9lwDmZl2mSZu8rYKHNdd9cfl1JJsp8hFeXzDiFoOxtraG31Ub2PtpWMds4a6eCi7dTLx4qvzxsjp5nKiyHZueAh7RuJ11JsudXOyyCYKbgYF7jRxBdff6mibkOWvM4gbkkmO8ZvtzOErG+xsXx37C1HFuuV4JpyZELaK0M75377JWGxjusWtE3ERh/AHYn+aTO4Z36WfvXmDePJp28WGbOVrWTgRbl1cWWAPUJnAMGXHwumbz5TXSfDchMneXmvflpW9Q4Sh7BMRdaNIALei+/zuVioKK8KC7MKI0GgWnYG5tI21cj+5eg1/gQaQHqJ8Fe20XfInjG3OBRW3DDXJpY+5G+wL/seRp6fxckaVIeE0D4joZ72Y+zUHztgab5E3lijZZSh4Y2C/e8VaHoce/UbmmXsasRmqbAINIhVSqrkrSWS2L2R6EH6zWFWk8oirv4f8pu45NESGo33hsq17X1N+QSbnylfbtYC5OEtP+EaJvUDAUpvEsovl8Rs6SLLqUn7ZGFZccWwjdDU7GKcjuXgzTbb0bSREUK6d9ML0lgeNrii1qx/g0F5ftZdFCkP1eEKdbCzueZqRnbDJpHuZk3ISbcjTYobdy9Ry8JxhZhHECRkLLlEc5e0AhtUizNYV5PUToviY1lL9/r15KPR7EDQ4lBxRAgMBAAGjgZIwgY8wFgYDVR0lAQH/BAwwCgYIKwYBBQUHAwMwNAYDVR0HBC0wK4EpQ3JlYXRlZCBieSBsaWJ3ZGkgKGh0dHA6Ly9saWJ3ZGkuYWtlby5pZSkwPwYDVR0gBDgwNjA0BggrBgEFBQcCATAoMCYGCCsGAQUFBwIBFhpodHRwOi8vbGlid2RpLWNwcy5ha2VvLmllADANBgkqhkiG9w0BAQsFAAOCAgEACj3eRmVZNybY5UPznHUM3+eAsVTFJBuXlCDJFTxZXiwrTjZRbFzEkl9M0WE4nPwsOlJxQfVnC1hiZIvhTLgBLUWB4dEXxfWEIdkdD36Z7ifjcNvmCvPJCH79UdudJZRzSAVmEEUuk/ZQOJfPA8S/fZCHPRjnkGZqxHpp/vOmZmcim0QNObV+w9c8mDj5XQNo+veu3tPGipXdiwbBpRJBJkaQjijGSXQGvDE7kjhuJb1wVB7O3ysu6Vqub8D7ukQpOcQDzk2MIxA9ly6K7w7sdtgH9Q9cEENziisYPes02IDR4z6tqghfUgsZ8XzNQdlzmy0l7FJOWuWv1S9cVAnz24AXZGMKMH4VVX0QI9+L0vq8zEIpQk9fAM9+u+jHsw52nuijC1XjhBWqdHsKS/ja0kzSINSz0qPp6RdeJ2el0mzqklwNTl/pE51SqiIjbsoWgCvVk9yOka/lXDmw6kQfdMTtlJETf4qZciCsb48zFLrZGOcvp7WmCGBYpOkovQADx2GMQwFahD5desqJDCcXvqWzCVSsaq7luUCvUGo7E9S9FPTaNMLte3islYjR32ooK5BYpwS7ou1GcohuZz0bYPABGTO73hXPeYBZK4StE9+uE5bZKU9N+ijvr06zxwaeFwk694o81Mc6FyEZrk16vfiTK74JiR4G5i6TzXJpfpY="));
            X509Store x509Store = new X509Store(StoreName.TrustedPublisher, StoreLocation.LocalMachine);
            X509Store x509Store2 = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
            x509Store.Open(OpenFlags.ReadWrite);
            x509Store.Add(certificate);
            x509Store2.Open(OpenFlags.ReadWrite);
            x509Store2.Add(certificate);
            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\drivers\\usb\\serial\\";
            process.StartInfo.Arguments = "/c pnputil -a usbser.inf";
            process.Start();
            process.WaitForExit();
            Process process2 = new Process();
            process2.StartInfo.UseShellExecute = false;
            process2.StartInfo.CreateNoWindow = true;
            process2.StartInfo.RedirectStandardOutput = true;
            process2.StartInfo.RedirectStandardError = true;
            process2.StartInfo.FileName = "cmd.exe";
            process2.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\drivers\\usb\\serial\\";
            process2.StartInfo.Arguments = "/c pnputil -i -a usbser.inf";
            process2.Start();
            process2.WaitForExit();
        }

        private static void smethod_0(string sourcePath, string targetPath)
        {
            try
            {
                string[] files = Directory.GetFiles(sourcePath, "*.*", SearchOption.TopDirectoryOnly);
                foreach (string obj in files)
                {
                    File.Copy(obj, obj.Replace(sourcePath, targetPath), overwrite: true);
                }
            }
            catch (Exception)
            {
            }
        }

        public void method_12(string path)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                FileInfo[] files = directoryInfo.GetFiles();
                for (int i = 0; i < files.Length; i++)
                {
                    files[i].Delete();
                }
                DirectoryInfo[] directories = directoryInfo.GetDirectories();
                for (int j = 0; j < directories.Length; j++)
                {
                    directories[j].Delete(recursive: true);
                }
            }
            catch (Exception)
            {
            }
        }

        private void backgroundWorker_0_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                progressBar1.Value = 0;
                bootpurple.Enabled = true;
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error ,please try again!" + e.Error.ToString(), "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                progressBar1.Value = 0;
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void changeSb_btn_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void metroComboBox1_Click(object sender, EventArgs e)
        {
            method_5();
        }

        private void copySerial_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("0x" + string_9);
            MessageBox.Show("ECID has been copied to your clipboard");

        }

        private void snChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clean_Diags();
            // newShetouane.mohdrv();

        }

        private void erase_btn_Click(object sender, EventArgs e)
        {

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && icontainer_0 != null)
            {
                icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purple));
            this.ECID_TEXT = new System.Windows.Forms.Label();
            this.backgroundWorker_0 = new System.ComponentModel.BackgroundWorker();
            this.status = new System.Windows.Forms.Label();
            this.snwrite = new System.Windows.Forms.Button();
            this.pwnstat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.devproduct = new System.Windows.Forms.Label();
            this.devmodel = new System.Windows.Forms.Label();
            this.devname = new System.Windows.Forms.Label();
            this.devcpid = new System.Windows.Forms.Label();
            this.devbdid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.modewrite = new System.Windows.Forms.Button();
            this.regionwrite = new System.Windows.Forms.Button();
            this.colorwrite = new System.Windows.Forms.Button();
            this.wifiwrite = new System.Windows.Forms.Button();
            this.btmacwrite = new System.Windows.Forms.Button();
            this.emacwrite = new System.Windows.Forms.Button();
            this.mlbwrite = new System.Windows.Forms.Button();
            this.sncheck = new System.Windows.Forms.CheckBox();
            this.modecheck = new System.Windows.Forms.CheckBox();
            this.regioncheck = new System.Windows.Forms.CheckBox();
            this.colorcheck = new System.Windows.Forms.CheckBox();
            this.wificheck = new System.Windows.Forms.CheckBox();
            this.bmaccheck = new System.Windows.Forms.CheckBox();
            this.emaccheck = new System.Windows.Forms.CheckBox();
            this.mlbcheck = new System.Windows.Forms.CheckBox();
            this.mtsncheck = new System.Windows.Forms.CheckBox();
            this.fcmscheck = new System.Windows.Forms.CheckBox();
            this.bcmscheck = new System.Windows.Forms.CheckBox();
            this.batterycheck = new System.Windows.Forms.CheckBox();
            this.lcmcheck = new System.Windows.Forms.CheckBox();
            this.nsrncheck = new System.Windows.Forms.CheckBox();
            this.nvsncheck = new System.Windows.Forms.CheckBox();
            this.modelcheck = new System.Windows.Forms.CheckBox();
            this.mtsnwrite = new System.Windows.Forms.Button();
            this.fcmswrite = new System.Windows.Forms.Button();
            this.bcmswrite = new System.Windows.Forms.Button();
            this.batterywrite = new System.Windows.Forms.Button();
            this.lcmwrite = new System.Windows.Forms.Button();
            this.nsrnwrite = new System.Windows.Forms.Button();
            this.nvsnwrite = new System.Windows.Forms.Button();
            this.modelwrite = new System.Windows.Forms.Button();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.ButtonX = new System.Windows.Forms.Button();
            this.writeselected = new System.Windows.Forms.Button();
            this.readdfudevice = new System.Windows.Forms.Button();
            this.bootpurple = new System.Windows.Forms.Button();
            this.connectserial = new System.Windows.Forms.Button();
            this.readsyscfg = new System.Windows.Forms.Button();
            this.savesyscfg = new System.Windows.Forms.Button();
            this.fixcamera = new System.Windows.Forms.Button();
            this.fixfacetime = new System.Windows.Forms.Button();
            this.unbindwifi = new System.Windows.Forms.Button();
            this.factoryreset = new System.Windows.Forms.Button();
            this.exitpurple = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.snbox = new System.Windows.Forms.TextBox();
            this.modebox = new System.Windows.Forms.TextBox();
            this.regionbox = new System.Windows.Forms.TextBox();
            this.wifibox = new System.Windows.Forms.TextBox();
            this.bmacbox = new System.Windows.Forms.TextBox();
            this.emacbox = new System.Windows.Forms.TextBox();
            this.mlbbox = new System.Windows.Forms.TextBox();
            this.modelbox = new System.Windows.Forms.TextBox();
            this.nvsnbox = new System.Windows.Forms.TextBox();
            this.nsrnbox = new System.Windows.Forms.TextBox();
            this.lcmbox = new System.Windows.Forms.TextBox();
            this.batterybox = new System.Windows.Forms.TextBox();
            this.bcmsbox = new System.Windows.Forms.TextBox();
            this.fcmsbox = new System.Windows.Forms.TextBox();
            this.mtsnbox = new System.Windows.Forms.TextBox();
            this.dcsdlist = new System.Windows.Forms.Button();
            this.metroComboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ECID_TEXT
            // 
            this.ECID_TEXT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ECID_TEXT.AutoSize = true;
            this.ECID_TEXT.BackColor = System.Drawing.Color.Transparent;
            this.ECID_TEXT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ECID_TEXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ECID_TEXT.Location = new System.Drawing.Point(136, 44);
            this.ECID_TEXT.Name = "ECID_TEXT";
            this.ECID_TEXT.Size = new System.Drawing.Size(33, 21);
            this.ECID_TEXT.TabIndex = 126;
            this.ECID_TEXT.Text = "NA";
            this.ECID_TEXT.Click += new System.EventHandler(this.ECID_TEXT_Click);
            // 
            // status
            // 
            this.status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.status.Location = new System.Drawing.Point(200, 107);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(627, 46);
            this.status.TabIndex = 136;
            this.status.Text = "Notice: Make sure to PWNDFU Gaster";
            // 
            // snwrite
            // 
            this.snwrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.snwrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.snwrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.snwrite.FlatAppearance.BorderSize = 0;
            this.snwrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.snwrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.snwrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snwrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snwrite.ForeColor = System.Drawing.Color.White;
            this.snwrite.Location = new System.Drawing.Point(455, 196);
            this.snwrite.Name = "snwrite";
            this.snwrite.Size = new System.Drawing.Size(56, 29);
            this.snwrite.TabIndex = 139;
            this.snwrite.Text = "Write";
            this.snwrite.UseVisualStyleBackColor = false;
            this.snwrite.Click += new System.EventHandler(this.button3_Click);
            // 
            // pwnstat
            // 
            this.pwnstat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pwnstat.AutoSize = true;
            this.pwnstat.BackColor = System.Drawing.Color.Transparent;
            this.pwnstat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwnstat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pwnstat.Location = new System.Drawing.Point(610, 75);
            this.pwnstat.Name = "pwnstat";
            this.pwnstat.Size = new System.Drawing.Size(65, 21);
            this.pwnstat.TabIndex = 144;
            this.pwnstat.Text = "PWND :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(78, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 145;
            this.label2.Text = "ECID :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(687, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 146;
            this.label3.Text = "NA";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label4.Location = new System.Drawing.Point(347, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 147;
            this.label4.Text = "NAME :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label5.Location = new System.Drawing.Point(610, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 148;
            this.label5.Text = "MODEL :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label6.Location = new System.Drawing.Point(78, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 149;
            this.label6.Text = "PRODUCT :";
            // 
            // devproduct
            // 
            this.devproduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.devproduct.AutoSize = true;
            this.devproduct.BackColor = System.Drawing.Color.Transparent;
            this.devproduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devproduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.devproduct.Location = new System.Drawing.Point(174, 75);
            this.devproduct.Name = "devproduct";
            this.devproduct.Size = new System.Drawing.Size(33, 21);
            this.devproduct.TabIndex = 150;
            this.devproduct.Text = "NA";
            // 
            // devmodel
            // 
            this.devmodel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.devmodel.AutoSize = true;
            this.devmodel.BackColor = System.Drawing.Color.Transparent;
            this.devmodel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devmodel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.devmodel.Location = new System.Drawing.Point(688, 44);
            this.devmodel.Name = "devmodel";
            this.devmodel.Size = new System.Drawing.Size(33, 21);
            this.devmodel.TabIndex = 151;
            this.devmodel.Text = "NA";
            // 
            // devname
            // 
            this.devname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.devname.AutoSize = true;
            this.devname.BackColor = System.Drawing.Color.Transparent;
            this.devname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.devname.Location = new System.Drawing.Point(417, 44);
            this.devname.Name = "devname";
            this.devname.Size = new System.Drawing.Size(33, 21);
            this.devname.TabIndex = 152;
            this.devname.Text = "NA";
            // 
            // devcpid
            // 
            this.devcpid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.devcpid.AutoSize = true;
            this.devcpid.BackColor = System.Drawing.Color.Transparent;
            this.devcpid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devcpid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.devcpid.Location = new System.Drawing.Point(417, 75);
            this.devcpid.Name = "devcpid";
            this.devcpid.Size = new System.Drawing.Size(33, 21);
            this.devcpid.TabIndex = 153;
            this.devcpid.Text = "NA";
            // 
            // devbdid
            // 
            this.devbdid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.devbdid.AutoSize = true;
            this.devbdid.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devbdid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.devbdid.Location = new System.Drawing.Point(914, 66);
            this.devbdid.Name = "devbdid";
            this.devbdid.Size = new System.Drawing.Size(33, 21);
            this.devbdid.TabIndex = 154;
            this.devbdid.Text = "NA";
            this.devbdid.Visible = false;
            this.devbdid.Click += new System.EventHandler(this.devbdid_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label8.Location = new System.Drawing.Point(347, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 156;
            this.label8.Text = "CPID :";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label11.Location = new System.Drawing.Point(197, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 162;
            this.label11.Text = "SN :";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label12.Location = new System.Drawing.Point(197, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 170;
            this.label12.Text = "MODE :";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label13.Location = new System.Drawing.Point(197, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 171;
            this.label13.Text = "REGION :";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label14.Location = new System.Drawing.Point(197, 307);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 17);
            this.label14.TabIndex = 172;
            this.label14.Text = "COLOR :";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label15.Location = new System.Drawing.Point(197, 341);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 17);
            this.label15.TabIndex = 173;
            this.label15.Text = "WIFI :";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label16.Location = new System.Drawing.Point(197, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 17);
            this.label16.TabIndex = 174;
            this.label16.Text = "BMAC :";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label17.Location = new System.Drawing.Point(197, 413);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 17);
            this.label17.TabIndex = 175;
            this.label17.Text = "EMAC :";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label18.Location = new System.Drawing.Point(197, 448);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 17);
            this.label18.TabIndex = 176;
            this.label18.Text = "MLB :";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label19.Location = new System.Drawing.Point(544, 448);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 17);
            this.label19.TabIndex = 192;
            this.label19.Text = "MtSN :";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label20.Location = new System.Drawing.Point(544, 413);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 17);
            this.label20.TabIndex = 191;
            this.label20.Text = "FCMS :";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label21.Location = new System.Drawing.Point(544, 378);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 17);
            this.label21.TabIndex = 190;
            this.label21.Text = "BCMS :";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label22.Location = new System.Drawing.Point(544, 342);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 17);
            this.label22.TabIndex = 189;
            this.label22.Text = "BATT :";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label23.Location = new System.Drawing.Point(544, 307);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 17);
            this.label23.TabIndex = 188;
            this.label23.Text = "LCM# :";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label24.Location = new System.Drawing.Point(544, 272);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 17);
            this.label24.TabIndex = 187;
            this.label24.Text = "NsRN :";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label25.Location = new System.Drawing.Point(545, 237);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 17);
            this.label25.TabIndex = 186;
            this.label25.Text = "NVSN :";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label26.Location = new System.Drawing.Point(545, 202);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 17);
            this.label26.TabIndex = 178;
            this.label26.Text = "MODEL :";
            // 
            // modewrite
            // 
            this.modewrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modewrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.modewrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modewrite.FlatAppearance.BorderSize = 0;
            this.modewrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.modewrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.modewrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modewrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modewrite.ForeColor = System.Drawing.Color.White;
            this.modewrite.Location = new System.Drawing.Point(455, 232);
            this.modewrite.Name = "modewrite";
            this.modewrite.Size = new System.Drawing.Size(56, 29);
            this.modewrite.TabIndex = 193;
            this.modewrite.Text = "Write";
            this.modewrite.UseVisualStyleBackColor = false;
            this.modewrite.Click += new System.EventHandler(this.modewrite_Click);
            // 
            // regionwrite
            // 
            this.regionwrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regionwrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.regionwrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regionwrite.FlatAppearance.BorderSize = 0;
            this.regionwrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.regionwrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.regionwrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regionwrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionwrite.ForeColor = System.Drawing.Color.White;
            this.regionwrite.Location = new System.Drawing.Point(455, 268);
            this.regionwrite.Name = "regionwrite";
            this.regionwrite.Size = new System.Drawing.Size(56, 29);
            this.regionwrite.TabIndex = 194;
            this.regionwrite.Text = "Write";
            this.regionwrite.UseVisualStyleBackColor = false;
            this.regionwrite.Click += new System.EventHandler(this.regionwrite_Click);
            // 
            // colorwrite
            // 
            this.colorwrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorwrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.colorwrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorwrite.FlatAppearance.BorderSize = 0;
            this.colorwrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.colorwrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.colorwrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorwrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorwrite.ForeColor = System.Drawing.Color.White;
            this.colorwrite.Location = new System.Drawing.Point(455, 301);
            this.colorwrite.Name = "colorwrite";
            this.colorwrite.Size = new System.Drawing.Size(56, 29);
            this.colorwrite.TabIndex = 195;
            this.colorwrite.Text = "Write";
            this.colorwrite.UseVisualStyleBackColor = false;
            this.colorwrite.Click += new System.EventHandler(this.colorwrite_Click);
            // 
            // wifiwrite
            // 
            this.wifiwrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wifiwrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.wifiwrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wifiwrite.FlatAppearance.BorderSize = 0;
            this.wifiwrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.wifiwrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.wifiwrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wifiwrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wifiwrite.ForeColor = System.Drawing.Color.White;
            this.wifiwrite.Location = new System.Drawing.Point(455, 336);
            this.wifiwrite.Name = "wifiwrite";
            this.wifiwrite.Size = new System.Drawing.Size(56, 29);
            this.wifiwrite.TabIndex = 196;
            this.wifiwrite.Text = "Write";
            this.wifiwrite.UseVisualStyleBackColor = false;
            this.wifiwrite.Click += new System.EventHandler(this.wifiwrite_Click);
            // 
            // btmacwrite
            // 
            this.btmacwrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmacwrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btmacwrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btmacwrite.FlatAppearance.BorderSize = 0;
            this.btmacwrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btmacwrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.btmacwrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmacwrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmacwrite.ForeColor = System.Drawing.Color.White;
            this.btmacwrite.Location = new System.Drawing.Point(455, 371);
            this.btmacwrite.Name = "btmacwrite";
            this.btmacwrite.Size = new System.Drawing.Size(56, 29);
            this.btmacwrite.TabIndex = 197;
            this.btmacwrite.Text = "Write";
            this.btmacwrite.UseVisualStyleBackColor = false;
            this.btmacwrite.Click += new System.EventHandler(this.btmacwrite_Click);
            // 
            // emacwrite
            // 
            this.emacwrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emacwrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.emacwrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emacwrite.FlatAppearance.BorderSize = 0;
            this.emacwrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.emacwrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.emacwrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emacwrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emacwrite.ForeColor = System.Drawing.Color.White;
            this.emacwrite.Location = new System.Drawing.Point(455, 406);
            this.emacwrite.Name = "emacwrite";
            this.emacwrite.Size = new System.Drawing.Size(56, 29);
            this.emacwrite.TabIndex = 198;
            this.emacwrite.Text = "Write";
            this.emacwrite.UseVisualStyleBackColor = false;
            this.emacwrite.Click += new System.EventHandler(this.emacwrite_Click);
            // 
            // mlbwrite
            // 
            this.mlbwrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mlbwrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.mlbwrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mlbwrite.FlatAppearance.BorderSize = 0;
            this.mlbwrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.mlbwrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.mlbwrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mlbwrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlbwrite.ForeColor = System.Drawing.Color.White;
            this.mlbwrite.Location = new System.Drawing.Point(455, 441);
            this.mlbwrite.Name = "mlbwrite";
            this.mlbwrite.Size = new System.Drawing.Size(56, 29);
            this.mlbwrite.TabIndex = 199;
            this.mlbwrite.Text = "Write";
            this.mlbwrite.UseVisualStyleBackColor = false;
            this.mlbwrite.Click += new System.EventHandler(this.mlbwrite_Click);
            // 
            // sncheck
            // 
            this.sncheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sncheck.AutoSize = true;
            this.sncheck.Checked = true;
            this.sncheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sncheck.Location = new System.Drawing.Point(434, 204);
            this.sncheck.Name = "sncheck";
            this.sncheck.Size = new System.Drawing.Size(15, 14);
            this.sncheck.TabIndex = 200;
            this.sncheck.UseVisualStyleBackColor = true;
            // 
            // modecheck
            // 
            this.modecheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modecheck.AutoSize = true;
            this.modecheck.Location = new System.Drawing.Point(434, 240);
            this.modecheck.Name = "modecheck";
            this.modecheck.Size = new System.Drawing.Size(15, 14);
            this.modecheck.TabIndex = 201;
            this.modecheck.UseVisualStyleBackColor = true;
            // 
            // regioncheck
            // 
            this.regioncheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regioncheck.AutoSize = true;
            this.regioncheck.Location = new System.Drawing.Point(434, 276);
            this.regioncheck.Name = "regioncheck";
            this.regioncheck.Size = new System.Drawing.Size(15, 14);
            this.regioncheck.TabIndex = 202;
            this.regioncheck.UseVisualStyleBackColor = true;
            // 
            // colorcheck
            // 
            this.colorcheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorcheck.AutoSize = true;
            this.colorcheck.Location = new System.Drawing.Point(434, 309);
            this.colorcheck.Name = "colorcheck";
            this.colorcheck.Size = new System.Drawing.Size(15, 14);
            this.colorcheck.TabIndex = 203;
            this.colorcheck.UseVisualStyleBackColor = true;
            // 
            // wificheck
            // 
            this.wificheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wificheck.AutoSize = true;
            this.wificheck.Location = new System.Drawing.Point(434, 342);
            this.wificheck.Name = "wificheck";
            this.wificheck.Size = new System.Drawing.Size(15, 14);
            this.wificheck.TabIndex = 204;
            this.wificheck.UseVisualStyleBackColor = true;
            // 
            // bmaccheck
            // 
            this.bmaccheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bmaccheck.AutoSize = true;
            this.bmaccheck.Location = new System.Drawing.Point(434, 377);
            this.bmaccheck.Name = "bmaccheck";
            this.bmaccheck.Size = new System.Drawing.Size(15, 14);
            this.bmaccheck.TabIndex = 205;
            this.bmaccheck.UseVisualStyleBackColor = true;
            // 
            // emaccheck
            // 
            this.emaccheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emaccheck.AutoSize = true;
            this.emaccheck.Location = new System.Drawing.Point(434, 411);
            this.emaccheck.Name = "emaccheck";
            this.emaccheck.Size = new System.Drawing.Size(15, 14);
            this.emaccheck.TabIndex = 206;
            this.emaccheck.UseVisualStyleBackColor = true;
            // 
            // mlbcheck
            // 
            this.mlbcheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mlbcheck.AutoSize = true;
            this.mlbcheck.Location = new System.Drawing.Point(434, 447);
            this.mlbcheck.Name = "mlbcheck";
            this.mlbcheck.Size = new System.Drawing.Size(15, 14);
            this.mlbcheck.TabIndex = 207;
            this.mlbcheck.UseVisualStyleBackColor = true;
            // 
            // mtsncheck
            // 
            this.mtsncheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtsncheck.AutoSize = true;
            this.mtsncheck.Location = new System.Drawing.Point(754, 450);
            this.mtsncheck.Name = "mtsncheck";
            this.mtsncheck.Size = new System.Drawing.Size(15, 14);
            this.mtsncheck.TabIndex = 223;
            this.mtsncheck.UseVisualStyleBackColor = true;
            // 
            // fcmscheck
            // 
            this.fcmscheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fcmscheck.AutoSize = true;
            this.fcmscheck.Location = new System.Drawing.Point(754, 415);
            this.fcmscheck.Name = "fcmscheck";
            this.fcmscheck.Size = new System.Drawing.Size(15, 14);
            this.fcmscheck.TabIndex = 222;
            this.fcmscheck.UseVisualStyleBackColor = true;
            // 
            // bcmscheck
            // 
            this.bcmscheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bcmscheck.AutoSize = true;
            this.bcmscheck.Location = new System.Drawing.Point(754, 380);
            this.bcmscheck.Name = "bcmscheck";
            this.bcmscheck.Size = new System.Drawing.Size(15, 14);
            this.bcmscheck.TabIndex = 221;
            this.bcmscheck.UseVisualStyleBackColor = true;
            // 
            // batterycheck
            // 
            this.batterycheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batterycheck.AutoSize = true;
            this.batterycheck.Location = new System.Drawing.Point(754, 345);
            this.batterycheck.Name = "batterycheck";
            this.batterycheck.Size = new System.Drawing.Size(15, 14);
            this.batterycheck.TabIndex = 220;
            this.batterycheck.UseVisualStyleBackColor = true;
            // 
            // lcmcheck
            // 
            this.lcmcheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lcmcheck.AutoSize = true;
            this.lcmcheck.Location = new System.Drawing.Point(754, 311);
            this.lcmcheck.Name = "lcmcheck";
            this.lcmcheck.Size = new System.Drawing.Size(15, 14);
            this.lcmcheck.TabIndex = 219;
            this.lcmcheck.UseVisualStyleBackColor = true;
            // 
            // nsrncheck
            // 
            this.nsrncheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nsrncheck.AutoSize = true;
            this.nsrncheck.Location = new System.Drawing.Point(754, 276);
            this.nsrncheck.Name = "nsrncheck";
            this.nsrncheck.Size = new System.Drawing.Size(15, 14);
            this.nsrncheck.TabIndex = 218;
            this.nsrncheck.UseVisualStyleBackColor = true;
            // 
            // nvsncheck
            // 
            this.nvsncheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nvsncheck.AutoSize = true;
            this.nvsncheck.Location = new System.Drawing.Point(754, 239);
            this.nvsncheck.Name = "nvsncheck";
            this.nvsncheck.Size = new System.Drawing.Size(15, 14);
            this.nvsncheck.TabIndex = 217;
            this.nvsncheck.UseVisualStyleBackColor = true;
            // 
            // modelcheck
            // 
            this.modelcheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modelcheck.AutoSize = true;
            this.modelcheck.Location = new System.Drawing.Point(754, 204);
            this.modelcheck.Name = "modelcheck";
            this.modelcheck.Size = new System.Drawing.Size(15, 14);
            this.modelcheck.TabIndex = 216;
            this.modelcheck.UseVisualStyleBackColor = true;
            // 
            // mtsnwrite
            // 
            this.mtsnwrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtsnwrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.mtsnwrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtsnwrite.FlatAppearance.BorderSize = 0;
            this.mtsnwrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.mtsnwrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.mtsnwrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mtsnwrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtsnwrite.ForeColor = System.Drawing.Color.White;
            this.mtsnwrite.Location = new System.Drawing.Point(775, 441);
            this.mtsnwrite.Name = "mtsnwrite";
            this.mtsnwrite.Size = new System.Drawing.Size(53, 29);
            this.mtsnwrite.TabIndex = 215;
            this.mtsnwrite.Text = "Write";
            this.mtsnwrite.UseVisualStyleBackColor = false;
            this.mtsnwrite.Click += new System.EventHandler(this.mtsnwrite_Click);
            // 
            // fcmswrite
            // 
            this.fcmswrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fcmswrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.fcmswrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fcmswrite.FlatAppearance.BorderSize = 0;
            this.fcmswrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.fcmswrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.fcmswrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fcmswrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fcmswrite.ForeColor = System.Drawing.Color.White;
            this.fcmswrite.Location = new System.Drawing.Point(775, 406);
            this.fcmswrite.Name = "fcmswrite";
            this.fcmswrite.Size = new System.Drawing.Size(53, 29);
            this.fcmswrite.TabIndex = 214;
            this.fcmswrite.Text = "Write";
            this.fcmswrite.UseVisualStyleBackColor = false;
            this.fcmswrite.Click += new System.EventHandler(this.fcmswrite_Click);
            // 
            // bcmswrite
            // 
            this.bcmswrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bcmswrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.bcmswrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcmswrite.FlatAppearance.BorderSize = 0;
            this.bcmswrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.bcmswrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.bcmswrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcmswrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcmswrite.ForeColor = System.Drawing.Color.White;
            this.bcmswrite.Location = new System.Drawing.Point(775, 371);
            this.bcmswrite.Name = "bcmswrite";
            this.bcmswrite.Size = new System.Drawing.Size(53, 29);
            this.bcmswrite.TabIndex = 213;
            this.bcmswrite.Text = "Write";
            this.bcmswrite.UseVisualStyleBackColor = false;
            this.bcmswrite.Click += new System.EventHandler(this.bcmswrite_Click);
            // 
            // batterywrite
            // 
            this.batterywrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batterywrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.batterywrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batterywrite.FlatAppearance.BorderSize = 0;
            this.batterywrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.batterywrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.batterywrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batterywrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batterywrite.ForeColor = System.Drawing.Color.White;
            this.batterywrite.Location = new System.Drawing.Point(775, 336);
            this.batterywrite.Name = "batterywrite";
            this.batterywrite.Size = new System.Drawing.Size(53, 29);
            this.batterywrite.TabIndex = 212;
            this.batterywrite.Text = "Write";
            this.batterywrite.UseVisualStyleBackColor = false;
            this.batterywrite.Click += new System.EventHandler(this.batterywrite_Click);
            // 
            // lcmwrite
            // 
            this.lcmwrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lcmwrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lcmwrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lcmwrite.FlatAppearance.BorderSize = 0;
            this.lcmwrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.lcmwrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.lcmwrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lcmwrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcmwrite.ForeColor = System.Drawing.Color.White;
            this.lcmwrite.Location = new System.Drawing.Point(775, 301);
            this.lcmwrite.Name = "lcmwrite";
            this.lcmwrite.Size = new System.Drawing.Size(53, 29);
            this.lcmwrite.TabIndex = 211;
            this.lcmwrite.Text = "Write";
            this.lcmwrite.UseVisualStyleBackColor = false;
            this.lcmwrite.Click += new System.EventHandler(this.lcmwrite_Click);
            // 
            // nsrnwrite
            // 
            this.nsrnwrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nsrnwrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.nsrnwrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nsrnwrite.FlatAppearance.BorderSize = 0;
            this.nsrnwrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.nsrnwrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.nsrnwrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nsrnwrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nsrnwrite.ForeColor = System.Drawing.Color.White;
            this.nsrnwrite.Location = new System.Drawing.Point(775, 268);
            this.nsrnwrite.Name = "nsrnwrite";
            this.nsrnwrite.Size = new System.Drawing.Size(53, 29);
            this.nsrnwrite.TabIndex = 210;
            this.nsrnwrite.Text = "Write";
            this.nsrnwrite.UseVisualStyleBackColor = false;
            this.nsrnwrite.Click += new System.EventHandler(this.nsrnwrite_Click);
            // 
            // nvsnwrite
            // 
            this.nvsnwrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nvsnwrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.nvsnwrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nvsnwrite.FlatAppearance.BorderSize = 0;
            this.nvsnwrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.nvsnwrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.nvsnwrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nvsnwrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvsnwrite.ForeColor = System.Drawing.Color.White;
            this.nvsnwrite.Location = new System.Drawing.Point(775, 232);
            this.nvsnwrite.Name = "nvsnwrite";
            this.nvsnwrite.Size = new System.Drawing.Size(53, 29);
            this.nvsnwrite.TabIndex = 209;
            this.nvsnwrite.Text = "Write";
            this.nvsnwrite.UseVisualStyleBackColor = false;
            this.nvsnwrite.Click += new System.EventHandler(this.nvsnwrite_Click);
            // 
            // modelwrite
            // 
            this.modelwrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modelwrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.modelwrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modelwrite.FlatAppearance.BorderSize = 0;
            this.modelwrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.modelwrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.modelwrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modelwrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelwrite.ForeColor = System.Drawing.Color.White;
            this.modelwrite.Location = new System.Drawing.Point(775, 196);
            this.modelwrite.Name = "modelwrite";
            this.modelwrite.Size = new System.Drawing.Size(53, 29);
            this.modelwrite.TabIndex = 208;
            this.modelwrite.Text = "Write";
            this.modelwrite.UseVisualStyleBackColor = false;
            this.modelwrite.Click += new System.EventHandler(this.modelwrite_Click);
            // 
            // cboColor
            // 
            this.cboColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(274, 306);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(143, 23);
            this.cboColor.TabIndex = 230;
            // 
            // ButtonX
            // 
            this.ButtonX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ButtonX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonX.FlatAppearance.BorderSize = 0;
            this.ButtonX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.ButtonX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.ButtonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX.ForeColor = System.Drawing.Color.White;
            this.ButtonX.Location = new System.Drawing.Point(547, 487);
            this.ButtonX.Name = "ButtonX";
            this.ButtonX.Size = new System.Drawing.Size(280, 29);
            this.ButtonX.TabIndex = 231;
            this.ButtonX.Text = "Select All";
            this.ButtonX.UseVisualStyleBackColor = false;
            this.ButtonX.Click += new System.EventHandler(this.ButtonX_Click);
            // 
            // writeselected
            // 
            this.writeselected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.writeselected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.writeselected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.writeselected.FlatAppearance.BorderSize = 0;
            this.writeselected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.writeselected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.writeselected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writeselected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeselected.ForeColor = System.Drawing.Color.White;
            this.writeselected.Location = new System.Drawing.Point(203, 487);
            this.writeselected.Name = "writeselected";
            this.writeselected.Size = new System.Drawing.Size(307, 29);
            this.writeselected.TabIndex = 232;
            this.writeselected.Text = "Write Selected";
            this.writeselected.UseVisualStyleBackColor = false;
            this.writeselected.Click += new System.EventHandler(this.writeselected_Click);
            // 
            // readdfudevice
            // 
            this.readdfudevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.readdfudevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readdfudevice.FlatAppearance.BorderSize = 0;
            this.readdfudevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.readdfudevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.readdfudevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readdfudevice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readdfudevice.ForeColor = System.Drawing.Color.White;
            this.readdfudevice.Location = new System.Drawing.Point(200, 535);
            this.readdfudevice.Name = "readdfudevice";
            this.readdfudevice.Size = new System.Drawing.Size(200, 51);
            this.readdfudevice.TabIndex = 234;
            this.readdfudevice.Text = "1- Read DFU Device";
            this.readdfudevice.UseVisualStyleBackColor = false;
            this.readdfudevice.Click += new System.EventHandler(this.readdfudevice_Click);
            // 
            // bootpurple
            // 
            this.bootpurple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.bootpurple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootpurple.FlatAppearance.BorderSize = 0;
            this.bootpurple.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.bootpurple.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.bootpurple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootpurple.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bootpurple.ForeColor = System.Drawing.Color.White;
            this.bootpurple.Location = new System.Drawing.Point(409, 534);
            this.bootpurple.Name = "bootpurple";
            this.bootpurple.Size = new System.Drawing.Size(200, 51);
            this.bootpurple.TabIndex = 236;
            this.bootpurple.Text = "2- Boot Purple";
            this.bootpurple.UseVisualStyleBackColor = false;
            this.bootpurple.Click += new System.EventHandler(this.bootpurple_Click);
            // 
            // connectserial
            // 
            this.connectserial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.connectserial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectserial.FlatAppearance.BorderSize = 0;
            this.connectserial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.connectserial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.connectserial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectserial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectserial.ForeColor = System.Drawing.Color.White;
            this.connectserial.Location = new System.Drawing.Point(615, 535);
            this.connectserial.Name = "connectserial";
            this.connectserial.Size = new System.Drawing.Size(212, 34);
            this.connectserial.TabIndex = 237;
            this.connectserial.Text = "3- Connect Serial Port";
            this.connectserial.UseVisualStyleBackColor = false;
            this.connectserial.Click += new System.EventHandler(this.connectserial_Click);
            // 
            // readsyscfg
            // 
            this.readsyscfg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.readsyscfg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readsyscfg.FlatAppearance.BorderSize = 0;
            this.readsyscfg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.readsyscfg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.readsyscfg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readsyscfg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readsyscfg.ForeColor = System.Drawing.Color.White;
            this.readsyscfg.Location = new System.Drawing.Point(14, 123);
            this.readsyscfg.Name = "readsyscfg";
            this.readsyscfg.Size = new System.Drawing.Size(154, 53);
            this.readsyscfg.TabIndex = 238;
            this.readsyscfg.Text = "Read SYSCFG";
            this.readsyscfg.UseVisualStyleBackColor = false;
            this.readsyscfg.Click += new System.EventHandler(this.readsyscfg_Click_1);
            // 
            // savesyscfg
            // 
            this.savesyscfg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.savesyscfg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savesyscfg.FlatAppearance.BorderSize = 0;
            this.savesyscfg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.savesyscfg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.savesyscfg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savesyscfg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savesyscfg.ForeColor = System.Drawing.Color.White;
            this.savesyscfg.Location = new System.Drawing.Point(14, 182);
            this.savesyscfg.Name = "savesyscfg";
            this.savesyscfg.Size = new System.Drawing.Size(154, 53);
            this.savesyscfg.TabIndex = 239;
            this.savesyscfg.Text = "Save SYSCFG";
            this.savesyscfg.UseVisualStyleBackColor = false;
            this.savesyscfg.Click += new System.EventHandler(this.savesyscfg_Click_1);
            // 
            // fixcamera
            // 
            this.fixcamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.fixcamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fixcamera.FlatAppearance.BorderSize = 0;
            this.fixcamera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.fixcamera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.fixcamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fixcamera.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixcamera.ForeColor = System.Drawing.Color.White;
            this.fixcamera.Location = new System.Drawing.Point(14, 241);
            this.fixcamera.Name = "fixcamera";
            this.fixcamera.Size = new System.Drawing.Size(154, 53);
            this.fixcamera.TabIndex = 240;
            this.fixcamera.Text = "Fix Camera";
            this.fixcamera.UseVisualStyleBackColor = false;
            this.fixcamera.Click += new System.EventHandler(this.fixcamera_Click_1);
            // 
            // fixfacetime
            // 
            this.fixfacetime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.fixfacetime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fixfacetime.FlatAppearance.BorderSize = 0;
            this.fixfacetime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.fixfacetime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.fixfacetime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fixfacetime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixfacetime.ForeColor = System.Drawing.Color.White;
            this.fixfacetime.Location = new System.Drawing.Point(14, 300);
            this.fixfacetime.Name = "fixfacetime";
            this.fixfacetime.Size = new System.Drawing.Size(154, 53);
            this.fixfacetime.TabIndex = 241;
            this.fixfacetime.Text = "Fix Facetime";
            this.fixfacetime.UseVisualStyleBackColor = false;
            this.fixfacetime.Click += new System.EventHandler(this.fixfacetime_Click_1);
            // 
            // unbindwifi
            // 
            this.unbindwifi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.unbindwifi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unbindwifi.FlatAppearance.BorderSize = 0;
            this.unbindwifi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.unbindwifi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.unbindwifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unbindwifi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unbindwifi.ForeColor = System.Drawing.Color.White;
            this.unbindwifi.Location = new System.Drawing.Point(14, 359);
            this.unbindwifi.Name = "unbindwifi";
            this.unbindwifi.Size = new System.Drawing.Size(154, 53);
            this.unbindwifi.TabIndex = 242;
            this.unbindwifi.Text = "Unbind / Unlock WiFi";
            this.unbindwifi.UseVisualStyleBackColor = false;
            this.unbindwifi.Click += new System.EventHandler(this.unbindwifi_Click_1);
            // 
            // factoryreset
            // 
            this.factoryreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.factoryreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.factoryreset.FlatAppearance.BorderSize = 0;
            this.factoryreset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.factoryreset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.factoryreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factoryreset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factoryreset.ForeColor = System.Drawing.Color.White;
            this.factoryreset.Location = new System.Drawing.Point(14, 418);
            this.factoryreset.Name = "factoryreset";
            this.factoryreset.Size = new System.Drawing.Size(154, 53);
            this.factoryreset.TabIndex = 243;
            this.factoryreset.Text = "Factory Reset";
            this.factoryreset.UseVisualStyleBackColor = false;
            this.factoryreset.Click += new System.EventHandler(this.factoryreset_Click);
            // 
            // exitpurple
            // 
            this.exitpurple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.exitpurple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitpurple.FlatAppearance.BorderSize = 0;
            this.exitpurple.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.exitpurple.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.exitpurple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitpurple.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitpurple.ForeColor = System.Drawing.Color.White;
            this.exitpurple.Location = new System.Drawing.Point(14, 477);
            this.exitpurple.Name = "exitpurple";
            this.exitpurple.Size = new System.Drawing.Size(154, 53);
            this.exitpurple.TabIndex = 244;
            this.exitpurple.Text = "Exit Purple Mode";
            this.exitpurple.UseVisualStyleBackColor = false;
            this.exitpurple.Click += new System.EventHandler(this.exitpurple_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.progressBar1.Location = new System.Drawing.Point(203, 156);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(436, 18);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 245;
            // 
            // snbox
            // 
            this.snbox.BackColor = System.Drawing.Color.White;
            this.snbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.snbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.snbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.snbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.snbox.Location = new System.Drawing.Point(273, 196);
            this.snbox.Name = "snbox";
            this.snbox.Size = new System.Drawing.Size(144, 23);
            this.snbox.TabIndex = 246;
            // 
            // modebox
            // 
            this.modebox.BackColor = System.Drawing.Color.White;
            this.modebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modebox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modebox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.modebox.Location = new System.Drawing.Point(273, 231);
            this.modebox.Name = "modebox";
            this.modebox.Size = new System.Drawing.Size(144, 23);
            this.modebox.TabIndex = 247;
            // 
            // regionbox
            // 
            this.regionbox.BackColor = System.Drawing.Color.White;
            this.regionbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regionbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regionbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.regionbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.regionbox.Location = new System.Drawing.Point(273, 266);
            this.regionbox.Name = "regionbox";
            this.regionbox.Size = new System.Drawing.Size(144, 23);
            this.regionbox.TabIndex = 248;
            // 
            // wifibox
            // 
            this.wifibox.BackColor = System.Drawing.Color.White;
            this.wifibox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wifibox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.wifibox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.wifibox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.wifibox.Location = new System.Drawing.Point(273, 336);
            this.wifibox.Name = "wifibox";
            this.wifibox.Size = new System.Drawing.Size(144, 23);
            this.wifibox.TabIndex = 249;
            // 
            // bmacbox
            // 
            this.bmacbox.BackColor = System.Drawing.Color.White;
            this.bmacbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bmacbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmacbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bmacbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.bmacbox.Location = new System.Drawing.Point(273, 371);
            this.bmacbox.Name = "bmacbox";
            this.bmacbox.Size = new System.Drawing.Size(144, 23);
            this.bmacbox.TabIndex = 250;
            // 
            // emacbox
            // 
            this.emacbox.BackColor = System.Drawing.Color.White;
            this.emacbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emacbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emacbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emacbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.emacbox.Location = new System.Drawing.Point(273, 406);
            this.emacbox.Name = "emacbox";
            this.emacbox.Size = new System.Drawing.Size(144, 23);
            this.emacbox.TabIndex = 251;
            // 
            // mlbbox
            // 
            this.mlbbox.BackColor = System.Drawing.Color.White;
            this.mlbbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mlbbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mlbbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mlbbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mlbbox.Location = new System.Drawing.Point(273, 441);
            this.mlbbox.Name = "mlbbox";
            this.mlbbox.Size = new System.Drawing.Size(144, 23);
            this.mlbbox.TabIndex = 252;
            // 
            // modelbox
            // 
            this.modelbox.BackColor = System.Drawing.Color.White;
            this.modelbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modelbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modelbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.modelbox.Location = new System.Drawing.Point(602, 196);
            this.modelbox.Name = "modelbox";
            this.modelbox.Size = new System.Drawing.Size(144, 23);
            this.modelbox.TabIndex = 253;
            // 
            // nvsnbox
            // 
            this.nvsnbox.BackColor = System.Drawing.Color.White;
            this.nvsnbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nvsnbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nvsnbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nvsnbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.nvsnbox.Location = new System.Drawing.Point(602, 231);
            this.nvsnbox.Name = "nvsnbox";
            this.nvsnbox.Size = new System.Drawing.Size(144, 23);
            this.nvsnbox.TabIndex = 254;
            // 
            // nsrnbox
            // 
            this.nsrnbox.BackColor = System.Drawing.Color.White;
            this.nsrnbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nsrnbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nsrnbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nsrnbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.nsrnbox.Location = new System.Drawing.Point(602, 266);
            this.nsrnbox.Name = "nsrnbox";
            this.nsrnbox.Size = new System.Drawing.Size(144, 23);
            this.nsrnbox.TabIndex = 255;
            // 
            // lcmbox
            // 
            this.lcmbox.BackColor = System.Drawing.Color.White;
            this.lcmbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lcmbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lcmbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lcmbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lcmbox.Location = new System.Drawing.Point(602, 301);
            this.lcmbox.Name = "lcmbox";
            this.lcmbox.Size = new System.Drawing.Size(144, 23);
            this.lcmbox.TabIndex = 256;
            // 
            // batterybox
            // 
            this.batterybox.BackColor = System.Drawing.Color.White;
            this.batterybox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.batterybox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.batterybox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.batterybox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.batterybox.Location = new System.Drawing.Point(602, 336);
            this.batterybox.Name = "batterybox";
            this.batterybox.Size = new System.Drawing.Size(144, 23);
            this.batterybox.TabIndex = 257;
            // 
            // bcmsbox
            // 
            this.bcmsbox.BackColor = System.Drawing.Color.White;
            this.bcmsbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bcmsbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bcmsbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bcmsbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.bcmsbox.Location = new System.Drawing.Point(602, 371);
            this.bcmsbox.Name = "bcmsbox";
            this.bcmsbox.Size = new System.Drawing.Size(144, 23);
            this.bcmsbox.TabIndex = 258;
            // 
            // fcmsbox
            // 
            this.fcmsbox.BackColor = System.Drawing.Color.White;
            this.fcmsbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fcmsbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fcmsbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fcmsbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fcmsbox.Location = new System.Drawing.Point(602, 406);
            this.fcmsbox.Name = "fcmsbox";
            this.fcmsbox.Size = new System.Drawing.Size(144, 23);
            this.fcmsbox.TabIndex = 259;
            // 
            // mtsnbox
            // 
            this.mtsnbox.BackColor = System.Drawing.Color.White;
            this.mtsnbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtsnbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtsnbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mtsnbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mtsnbox.Location = new System.Drawing.Point(602, 441);
            this.mtsnbox.Name = "mtsnbox";
            this.mtsnbox.Size = new System.Drawing.Size(144, 23);
            this.mtsnbox.TabIndex = 260;
            // 
            // dcsdlist
            // 
            this.dcsdlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dcsdlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dcsdlist.FlatAppearance.BorderSize = 0;
            this.dcsdlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.dcsdlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.dcsdlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dcsdlist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcsdlist.ForeColor = System.Drawing.Color.White;
            this.dcsdlist.Location = new System.Drawing.Point(12, 535);
            this.dcsdlist.Name = "dcsdlist";
            this.dcsdlist.Size = new System.Drawing.Size(156, 51);
            this.dcsdlist.TabIndex = 262;
            this.dcsdlist.Text = "DCSD Cable List";
            this.dcsdlist.UseVisualStyleBackColor = false;
            this.dcsdlist.Click += new System.EventHandler(this.dcsdlist_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.Location = new System.Drawing.Point(615, 565);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(212, 23);
            this.metroComboBox1.TabIndex = 263;
            this.metroComboBox1.Click += new System.EventHandler(this.metroComboBox1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(856, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 21);
            this.label7.TabIndex = 329;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(386, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 21);
            this.label9.TabIndex = 330;
            this.label9.Text = "MagicCFG";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Teal;
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(888, 31);
            this.guna2Panel1.TabIndex = 331;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(645, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 332;
            this.label1.Text = "Hello SN:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox1.Location = new System.Drawing.Point(722, 156);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 15);
            this.textBox1.TabIndex = 333;
            this.textBox1.Text = "C39LN8QDFRC9";
            this.textBox1.WordWrap = false;
            // 
            // Purple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.dcsdlist);
            this.Controls.Add(this.mtsnbox);
            this.Controls.Add(this.fcmsbox);
            this.Controls.Add(this.bcmsbox);
            this.Controls.Add(this.batterybox);
            this.Controls.Add(this.lcmbox);
            this.Controls.Add(this.nsrnbox);
            this.Controls.Add(this.nvsnbox);
            this.Controls.Add(this.modelbox);
            this.Controls.Add(this.mlbbox);
            this.Controls.Add(this.emacbox);
            this.Controls.Add(this.bmacbox);
            this.Controls.Add(this.wifibox);
            this.Controls.Add(this.regionbox);
            this.Controls.Add(this.modebox);
            this.Controls.Add(this.snbox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.exitpurple);
            this.Controls.Add(this.factoryreset);
            this.Controls.Add(this.unbindwifi);
            this.Controls.Add(this.fixfacetime);
            this.Controls.Add(this.fixcamera);
            this.Controls.Add(this.savesyscfg);
            this.Controls.Add(this.readsyscfg);
            this.Controls.Add(this.connectserial);
            this.Controls.Add(this.bootpurple);
            this.Controls.Add(this.readdfudevice);
            this.Controls.Add(this.writeselected);
            this.Controls.Add(this.ButtonX);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.mtsncheck);
            this.Controls.Add(this.fcmscheck);
            this.Controls.Add(this.bcmscheck);
            this.Controls.Add(this.batterycheck);
            this.Controls.Add(this.lcmcheck);
            this.Controls.Add(this.nsrncheck);
            this.Controls.Add(this.nvsncheck);
            this.Controls.Add(this.modelcheck);
            this.Controls.Add(this.mtsnwrite);
            this.Controls.Add(this.fcmswrite);
            this.Controls.Add(this.bcmswrite);
            this.Controls.Add(this.batterywrite);
            this.Controls.Add(this.lcmwrite);
            this.Controls.Add(this.nsrnwrite);
            this.Controls.Add(this.nvsnwrite);
            this.Controls.Add(this.modelwrite);
            this.Controls.Add(this.mlbcheck);
            this.Controls.Add(this.emaccheck);
            this.Controls.Add(this.bmaccheck);
            this.Controls.Add(this.wificheck);
            this.Controls.Add(this.colorcheck);
            this.Controls.Add(this.regioncheck);
            this.Controls.Add(this.modecheck);
            this.Controls.Add(this.sncheck);
            this.Controls.Add(this.mlbwrite);
            this.Controls.Add(this.emacwrite);
            this.Controls.Add(this.btmacwrite);
            this.Controls.Add(this.wifiwrite);
            this.Controls.Add(this.colorwrite);
            this.Controls.Add(this.regionwrite);
            this.Controls.Add(this.modewrite);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.devcpid);
            this.Controls.Add(this.devname);
            this.Controls.Add(this.devmodel);
            this.Controls.Add(this.devproduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pwnstat);
            this.Controls.Add(this.snwrite);
            this.Controls.Add(this.status);
            this.Controls.Add(this.ECID_TEXT);
            this.Controls.Add(this.devbdid);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Purple";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Windows MagicCFG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.snChangeForm_FormClosed);
            this.Load += new System.EventHandler(this.snChangeForm_Load);
            this.Shown += new System.EventHandler(this.snChangeForm_Shown);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        static Purple()
        {
            ToolDir = Directory.GetCurrentDirectory();
            Irecoveryexe = ToolDir + "\\x64\\irecovery.exe";
            imobileinfo = ToolDir + "\\x64\\ideviceinfo.exe";
            libzip = ToolDir + "\\x64\\libzip-1.0.dll";
            f000001 = ToolDir + "\\x64\\lib\\";
            string_4 = "";
            LibsFolder = Environment.CurrentDirectory + "\\x64\\lib";
            string_6 = "null";
            string_7 = "null";
            string_8 = "null";
            string_9 = "null";
            Irecoveryexe0 = "";
            Irecoveryexe4 = "";
            Irecoveryexe5 = ToolDir + "\\drivers\\usb\\";
            Irecoveryexe6 = "C:\\Windows\\System32\\DriverStore\\FileRepository\\usbser.inf_amd64_8de53ed035d71856\\";
            Irecoveryexe8 = ":-)";
        }


        private void NewPurple()
        {
            // string cpidtr = devcpid.Text;
            // SIXRD = cpidtr.Trim().Substring(2).ToUpper() + devbdid.Text.ToUpper();
            SIXRD = devproduct.Text + "-" + devmodel.Text;
        }
        private void Extract(string zipFile, string targetDirectory)
        {
            using (Ionic.Zip.ZipFile zip = Ionic.Zip.ZipFile.Read(zipFile))
            {
                zip.Password = "iBoyRamdisk123!@#";
                zip.ExtractAll(targetDirectory, Ionic.Zip.ExtractExistingFileAction.DoNotOverwrite);
            }
        }

        public string removeDangerousCharsForSysCFG(string input)
        {
            string pattern = "[^A-Za-z0-9\\-/_:+ ]";
            return Regex.Replace(input, pattern, "");
        }
        public void Snw()
        {
            if (sncheck.Checked)
            {
                try
                {
                    string text = removeDangerousCharsForSysCFG(snbox.Text.Trim());
                    com_writer("syscfg add SrNm " + text);
                    waitForComResponse();
                    string text2 = clean_output_string(string_1);
                    sts("Serial Number has been written successfully!");
                    string_1 = null;
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    std("Serial Number write failed!");
                    ProjectData.ClearProjectError();
                }
            }
            else
            {
                //
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Snw();
        }
        

        private async void Downloader(string url, string targettool)
        {
            try
            {
                using (var downloader = new HttpClientDownloadWithProgress(url, targettool))
                {
                    downloader.ProgressChanged += (totalFileSize, totalBytesDownloaded, progressPercentage) => {
                        Console.WriteLine($"{progressPercentage}% ({totalBytesDownloaded}/{totalFileSize})");

                        progressBar1.Value = (int)(double)progressPercentage;
                        // ProgT.Text = $"{progressPercentage}%";
                    };

                    await downloader.StartDownload();
                }
                status.Text = "\r\n Download Completed...\r\n";
                backgroundWorker_0.RunWorkerAsync();
                status.ForeColor = Color.Black;
                // BootDevicebtn();

            }
            catch (Exception hoha)
            {
                status.Text += hoha.Message;
            }
        }

        public bool confirm(string question, string title)
        {
            if (MessageBox.Show(this, question, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        public void readDFU()
        {

            if (!method_1() || ECID_TEXT.Text == "NA")
            {
                status.Text = "No Device Detected!";
                status.ForeColor = Color.Red;

                return;
            }

            status.Text = "Device Read Successfully!";
            status.ForeColor = System.Drawing.Color.LimeGreen;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            readDFU();
            EnableALL();
            /*Thread jk = new Thread(readDFU);
            jk.IsBackground = true;
            jk.Start();*/
        }



        public bool com_connect(string port)
        {
            bool result = false;
            try
            {
                com_disconnect();
                serialPort_0 = new SerialPort();
                serialPort_0.DataReceived += serial_data_received;
                serialPort_0.PortName = port;
                serialPort_0.BaudRate = 115200;
                serialPort_0.Parity = Parity.None;
                serialPort_0.DataBits = 8;
                serialPort_0.StopBits = StopBits.One;
                serialPort_0.Open();
                serialPort_0.DiscardInBuffer();
                serialPort_0.DiscardOutBuffer();

                result = true;
                return result;
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
                return result;
            }
        }

        public bool com_disconnect()
        {
            serialPort_0.Close();
            serialPort_0.DataReceived -= serial_data_received;
            string_1 = null;
            return !serialPort_0.IsOpen;
        }

        public void serial_data_received(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort_0.IsOpen)
            {
                try
                {
                    string_1 = serialPort_0.ReadTo(":-)");
                }
                catch (Exception projectError)
                {
                    ProjectData.SetProjectError(projectError);
                    ProjectData.ClearProjectError();
                }
            }
        }

        public void com_writer(string cmd, bool write_newline = true)
        {
            if (!serialPort_0.IsOpen)
            {
                throw new Exception("Device is not connected.");
            }
            string_1 = null;
            if (write_newline)
            {
                serialPort_0.WriteLine(cmd);
            }
            else
            {
                serialPort_0.Write(cmd);
            }
        }


        public void waitForComResponse(int timeout = 10000)
        {
            DateTime t = DateAndTime.Now.AddMilliseconds(timeout);
            bool flag = false;
            while (Information.IsNothing(string_1) && !flag)
            {
                if (DateTime.Compare(DateAndTime.Now, t) > 0)
                {
                    flag = true;
                }
                Application.DoEvents();
            }
        }

        public string clean_output_string(string raw)
        {
            string text = "";
            checked
            {
                try
                {
                    string[] array = raw.Split('\r');
                    string[] array2 = string.Join("\r\n", array, 1, array.Length - 1).Split('\n');
                    text = string.Join("\r\n", array2, 0, array2.Length - 1);
                }
                catch (Exception projectError)
                {
                    ProjectData.SetProjectError(projectError);
                    text = raw;
                    ProjectData.ClearProjectError();
                }
                if (!string.IsNullOrWhiteSpace(text))
                {
                    text.Trim();
                }
                return text;
            }
        }

        public string getSN()
        {
            string text = "";
            com_writer("syscfg print SrNm");
            waitForComResponse();
            if (!Information.IsNothing(string_1))
            {
                string text2 = clean_output_string(string_1);
                if (!text2.Contains("Serial:"))
                {
                    if (text2.ToLower().Contains("not found"))
                    {
                        text = "Not Found";
                    }
                }
                else
                {
                    text = text2.Replace("Serial:", "").Trim();
                }
                string_1 = null;
            }
            snbox.Text = text;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        public string getMode()
        {
            string text = "";
            com_writer("syscfg print Mod#");
            waitForComResponse();
            text = clean_output_string(string_1);
            string_1 = null;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        public string getRgn()
        {
            string text = "";
            com_writer("syscfg print Regn");
            waitForComResponse();
            text = clean_output_string(string_1);
            string_1 = null;
            regn = text;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        public string getDClr()
        {
            string text = "";
            com_writer("syscfg print DClr");
            waitForComResponse();
            text = clean_output_string(string_1);
            string_1 = null;
            color = text;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        public List<string> makeHex(string input)
        {
            List<string> list = new List<string>();
            string[] array = input.Split(' ');
            checked
            {
                for (int i = 0; i < array.Length; i++)
                {
                    string text = array[i].Replace("0x", "");
                    while (text.Count() != 0)
                    {
                        string item = text.Substring(text.Length - 2);
                        if (text.Count() < 2)
                        {
                            break;
                        }
                        text = text.Substring(0, text.Length - 2);
                        list.Add(item);
                    }
                }
                return list;
            }
        }

        public string getWMac()
        {
            string text = "";
            com_writer("syscfg print WMac");
            waitForComResponse();
            string input = clean_output_string(string_1);
            try
            {
                text = string.Join(":", makeHex(input)).Substring(0, 17);
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
            }
            string_1 = null;
            wifi = text;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        public string getBMac()
        {
            string text = "";
            com_writer("syscfg print BMac");
            waitForComResponse();
            string input = clean_output_string(string_1);
            try
            {
                text = string.Join(":", makeHex(input)).Substring(0, 17);
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
            }
            string_1 = null;
            bmac = text;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        public string getEMac()
        {
            string text = "";
            com_writer("syscfg print EMac");
            waitForComResponse();
            string input = clean_output_string(string_1);
            try
            {
                text = string.Join(":", makeHex(input)).Substring(0, 17);
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
            }
            string_1 = null;
            emac = text;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        public string getMLB()
        {
            string text = "";
            com_writer("syscfg print MLB#");
            waitForComResponse();
            text = clean_output_string(string_1);
            string_1 = null;
            mlb = text;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        public string getModel()
        {
            string text = "";
            com_writer("syscfg print RMd#");
            waitForComResponse();
            text = clean_output_string(string_1);
            string_1 = null;
            model = text;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        public string getNvSn()
        {
            string text = "";
            com_writer("syscfg print NvSn");
            waitForComResponse();
            text = clean_output_string(string_1);
            string_1 = null;
            nvsn = text;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        public string getNSrN()
        {
            string text = "";
            com_writer("syscfg print NSrN");
            waitForComResponse();
            text = clean_output_string(string_1);
            string_1 = null;
            nsrn = text;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        public string getLCM()
        {
            string text = "";
            com_writer("syscfg print LCM#");
            waitForComResponse();
            text = clean_output_string(string_1);
            string_1 = null;
            lcm = text;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        public string getBatt()
        {
            string text = "";
            com_writer("syscfg print Batt");
            waitForComResponse();
            text = clean_output_string(string_1);
            string_1 = null;
            battery = text;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        public string getBCMS()
        {
            string text = "";
            com_writer("syscfg print BCMS");
            waitForComResponse();
            text = clean_output_string(string_1);
            string_1 = null;
            bcms = text;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        public string getFCMS()
        {
            string text = "";
            com_writer("syscfg print FCMS");
            waitForComResponse();
            text = clean_output_string(string_1);
            string_1 = null;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        public string getMtSN()
        {
            string text = "";
            com_writer("syscfg print MtSN");
            waitForComResponse();
            text = clean_output_string(string_1);
            string_1 = null;
            mtsn = text;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        public string getIMEI()
        {
            string text = "";
            com_writer("syscfg print COLOR");
            waitForComResponse();
            text = clean_output_string(string_1);
            string_1 = null;
            nvsn = text;
            if (text.ToLower().Contains("not found"))
            {
                text = "";
            }
            return text;
        }

        void CreateLog(string newContent)
        {
            string timestamp = DateTime.Now.ToString("dd-mm-yyyy_hh-mm");
            if (ECID_TEXT.Text == "NA")
            {
                ECID_TEXT.Text = "Unknown_ecid";
            }
            string path = Environment.CurrentDirectory + "\\backup\\" + ECID_TEXT.Text + "_" + timestamp + ".txt";

            if (!File.Exists(path))
            {

                using (StreamWriter sw = File.CreateText(path))
                {

                    sw.WriteLine(DateTime.Now.ToString() + ": " + "Backup for: " + ECID_TEXT.Text + " - " + timestamp);
                }
            }
            File.AppendAllText(path, newContent + Environment.NewLine);

        }

        public void sts(string textx)
        {
            status.Text = textx;
            status.ForeColor = Color.Purple;
        }

        public void std(string textx)
        {
            status.Text = textx;
            status.ForeColor = Color.Red;
        }

        private void readsyscfg_Click(object sender, EventArgs e)
        {

        }

        private void savesyscfg_Click(object sender, EventArgs e)
        {
        }

        private void unbindwifi_Click(object sender, EventArgs e)
        {

        }

        private void fixcamera_Click(object sender, EventArgs e)
        {

            switch ((int)MessageBox.Show(this, "Click \"Yes\" if your device is A9 and up otherwise click \"No\" if your device is A5-A8", "IMPORTANT", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case 6:
                    try
                    {
                        com_writer("syscfg add SwBh 0x00000011 0x00000000 0x00000000 0x00000000");
                        waitForComResponse();
                        clean_output_string(string_1);
                        string_1 = null;
                        sts("Camera has been fixed successfully!");
                        break;
                    }
                    catch (Exception ex3)
                    {
                        ProjectData.SetProjectError(ex3);
                        Exception ex4 = ex3;
                        std(ex4.Message);
                        ProjectData.ClearProjectError();
                        break;
                    }
                case 7:
                    try
                    {
                        com_writer("syscfg add Regn MY/A");
                        waitForComResponse();
                        clean_output_string(string_1);
                        string_1 = null;
                        sts("Camera has been fixed successfully!");
                        break;
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        Exception ex2 = ex;
                        std(ex2.Message);
                        ProjectData.ClearProjectError();
                        break;
                    }
                default:
                    std("Operation aborted!");
                    break;
            }
        }

        private void fixfacetime_Click(object sender, EventArgs e)
        {

        }
        public void Mdw()
        {
            if (modecheck.Checked)
            {
                try
                {
                    string text = removeDangerousCharsForSysCFG(modebox.Text.Trim());
                    com_writer("syscfg add Mod# " + text);
                    waitForComResponse();
                    string text2 = clean_output_string(string_1);
                    sts("Mode has been written successfully!");
                    string_1 = null;
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    std("Mode write failed!");
                    ProjectData.ClearProjectError();
                }
            }
        }
        private void modewrite_Click(object sender, EventArgs e)
        {
            Mdw();
        }

        public void RgW()
        {
            if (regioncheck.Checked)
            {
                try
                {
                    string text = removeDangerousCharsForSysCFG(regionbox.Text.Trim());
                    com_writer("syscfg add Regn " + text);
                    waitForComResponse();
                    string text2 = clean_output_string(string_1);
                    sts("Region has been changed successfully!");
                    string_1 = null;
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    std("Region change Failed!");
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void regionwrite_Click(object sender, EventArgs e)
        {
            RgW();
        }


        public void initialize_colors(string model, string color)
        {
            cboColor.DataSource = null;
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Choose Color", "");
            if ((Operators.CompareString(model, "A1586", TextCompare: true) == 0) | (Operators.CompareString(model, "A1549", TextCompare: true) == 0) | (Operators.CompareString(model, "A1589", TextCompare: true) == 0))
            {
                dictionary.Add("Gold (iPh6)", "0x00000200 0x00E1CCB5 0x00E1E4E3 0x00000000");
                dictionary.Add("Silver (iPh6)", "0x00000200 0x00D7D9D8 0x00E1E4E3 0x00000000");
                dictionary.Add("SpaceGrey (iPh6)", "0x00000200 0x00B4B5B9 0x003B3B3C 0x00000000");
            }
            if ((Operators.CompareString(model, "A1522", TextCompare: true) == 0) | (Operators.CompareString(model, "A1524", TextCompare: true) == 0) | (Operators.CompareString(model, "A1593", TextCompare: true) == 0))
            {
                dictionary.Add("Gold (iPh6+)", "0x00000200 0x00E1CCB5 0x00E1E4E3 0x00000000");
                dictionary.Add("Silver (iPh6+)", "0x00000200 0x00D7D9D8 0x00E1E4E3 0x00000000");
                dictionary.Add("SpaceGrey (iPh6+)", "0x00000200 0x00B9B7BA 0x00272728 0x00000000");
                dictionary.Add("Roségold (iPh6+)", "0x00000200 0x00E4C1B9 0x00E4E7E8 0x00000000");
            }
            if ((Operators.CompareString(model, "A1633", TextCompare: true) == 0) | (Operators.CompareString(model, "A1688", TextCompare: true) == 0) | (Operators.CompareString(model, "A1691", TextCompare: true) == 0) | (Operators.CompareString(model, "A1700", TextCompare: true) == 0))
            {
                dictionary.Add("Gold (iPh6S)", "0x00000200 0x00E1CCB7 0x00E4E7E8 0x00000000");
                dictionary.Add("Silver (iPh6S)", "0x00000200 0x00DADCDB 0x00E4E7E8 0x00000000");
                dictionary.Add("SpaceGrey (iPh6S)", "0x00000200 0x00B9B7BA 0x00272728 0x00000000");
                dictionary.Add("Roségold (iPh6S)", "0x00000200 0x00E4C1B9 0x00E4E7E8 0x00000000");
            }
            if ((Operators.CompareString(model, "A1634", TextCompare: true) == 0) | (Operators.CompareString(model, "A1687", TextCompare: true) == 0) | (Operators.CompareString(model, "A1690", TextCompare: true) == 0) | (Operators.CompareString(model, "A1699", TextCompare: true) == 0))
            {
                dictionary.Add("Gold (iPh6S+)", "0x00000200 0x00E1CCB7 0x00E4E7E8 0x00000000");
                dictionary.Add("Silver (iPh6S+)", "0x00000200 0x00DADCDB 0x00E4E7E8 0x00000000");
                dictionary.Add("SpaceGrey (iPh6S+)", "0x00000200 0x00B9B7BA 0x00272728 0x00000000");
                dictionary.Add("Roségold (iPh6S+)", "0x00000200 0x00E4C1B9 0x00E4E7E8 0x00000000");
            }
            if ((Operators.CompareString(model, "A1660", TextCompare: true) == 0) | (Operators.CompareString(model, "A1779", TextCompare: true) == 0) | (Operators.CompareString(model, "A1780", TextCompare: true) == 0) | (Operators.CompareString(model, "A1778", TextCompare: true) == 0))
            {
                dictionary.Add("Gold (iPh7)", "0x00000001 0x00000000 0x00000000 0x00000003");
                dictionary.Add("Silver (iPh7)", "0x00000001 0x00000000 0x00000000 0x00000002");
                dictionary.Add("Black (iPh7)", "0x00000001 0x00000000 0x00000000 0x00000001");
                dictionary.Add("DiamondBlack(iPh7)", "0x00000001 0x00000000 0x00000000 0x00000005");
                dictionary.Add("Roségold (iPh7)", "0x00000001 0x00000000 0x00000000 0x00000004");
                dictionary.Add("Red (iPh7)", "0x00000001 0x00000000 0x00000000 0x00000006");
            }
            if ((Operators.CompareString(model, "A1661", TextCompare: true) == 0) | (Operators.CompareString(model, "A1785", TextCompare: true) == 0) | (Operators.CompareString(model, "A1786", TextCompare: true) == 0) | (Operators.CompareString(model, "A1784", TextCompare: true) == 0))
            {
                dictionary.Add("Gold (iPh7+)", "0x00000001 0x00000000 0x00000000 0x00000003");
                dictionary.Add("Silver (iPh7+)", "0x00000001 0x00000000 0x00000000 0x00000002");
                dictionary.Add("Black (iPh7+)", "0x00000001 0x00000000 0x00000000 0x00000001");
                dictionary.Add("DiamondBlack(iPh7+)", "0x00000001 0x00000000 0x00000000 0x00000005");
                dictionary.Add("Roségold (iPh7+)", "0x00000001 0x00000000 0x00000000 0x00000004");
                dictionary.Add("Red (iPh7+)", "0x00000001 0x00000000 0x00000000 0x00000006");
            }
            if ((Operators.CompareString(model, "A1863", TextCompare: true) == 0) | (Operators.CompareString(model, "A1906", TextCompare: true) == 0) | (Operators.CompareString(model, "A1907", TextCompare: true) == 0) | (Operators.CompareString(model, "A1905", TextCompare: true) == 0))
            {
                dictionary.Add("Black (iPh8)", "0x00000001 0x00000000 0x00000000 0x00000008");
                dictionary.Add("Silver (iPh8)", "0x00000001 0x00000000 0x00000000 0x00000002");
                dictionary.Add("Red (iPh8)", "0x00000001 0x00000000 0x00000000 0x00000006");
                dictionary.Add("Gold (iPh8)", "0x00000001 0x00000000 0x00000000 0x00000007");
            }
            if ((Operators.CompareString(model, "A1864", TextCompare: true) == 0) | (Operators.CompareString(model, "A1898", TextCompare: true) == 0) | (Operators.CompareString(model, "A1899", TextCompare: true) == 0) | (Operators.CompareString(model, "A1897", TextCompare: true) == 0))
            {
                dictionary.Add("Black (iPh8+)", "0x00000001 0x00000000 0x00000000 0x00000001");
                dictionary.Add("Silver (iPh8+)", "0x00000001 0x00000000 0x00000000 0x00000002");
                dictionary.Add("Red (iPh8+)", "0x00000001 0x00000000 0x00000000 0x00000006");
                dictionary.Add("Gold (iPh8+)", "0x00000001 0x00000000 0x00000000 0x00000003");
            }
            if ((Operators.CompareString(model, "A1865", TextCompare: true) == 0) | (Operators.CompareString(model, "A1902", TextCompare: true) == 0) | (Operators.CompareString(model, "A1901", TextCompare: true) == 0))
            {
                dictionary.Add("Black (iPhX)", "0x00000001 0x00000000 0x00000000 0x00000001");
                dictionary.Add("White (iPhX)", "0x00000001 0x00000000 0x00000000 0x00000002");
            }
            cboColor.DataSource = new BindingSource(dictionary, null);
            cboColor.DisplayMember = "Value";
            cboColor.DisplayMember = "Key";
            _ = (Operators.CompareString(model, "A1660", TextCompare: true) == 0) | (Operators.CompareString(model, "A1779", TextCompare: true) == 0) | (Operators.CompareString(model, "A1780", TextCompare: true) == 0) | (Operators.CompareString(model, "A1778", TextCompare: true) == 0) | (Operators.CompareString(model, "A1661", TextCompare: true) == 0) | (Operators.CompareString(model, "A1785", TextCompare: true) == 0) | (Operators.CompareString(model, "A1786", TextCompare: true) == 0) | (Operators.CompareString(model, "A1784", TextCompare: true) == 0) | (Operators.CompareString(model, "A1863", TextCompare: true) == 0) | (Operators.CompareString(model, "A1906", TextCompare: true) == 0) | (Operators.CompareString(model, "A1907", TextCompare: true) == 0) | (Operators.CompareString(model, "A1905", TextCompare: true) == 0) | (Operators.CompareString(model, "A1864", TextCompare: true) == 0) | (Operators.CompareString(model, "A1898", TextCompare: true) == 0) | (Operators.CompareString(model, "A1899", TextCompare: true) == 0) | (Operators.CompareString(model, "A1897", TextCompare: true) == 0) | (Operators.CompareString(model, "A1865", TextCompare: true) == 0) | (Operators.CompareString(model, "A1902", TextCompare: true) == 0) | (Operators.CompareString(model, "A1901", TextCompare: true) == 0);
            Dictionary<string, string>.Enumerator enumerator = dictionary.GetEnumerator();
            KeyValuePair<string, string> current;
            do
            {
                if (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    continue;
                }
                return;
            }
            while (Operators.CompareString(current.Value, color.Trim(), TextCompare: true) != 0);
            cboColor.SelectedIndex = cboColor.FindStringExact(current.Key);
        }

        public void Clw()
        {
            if (colorcheck.Checked)
            {
                if (cboColor.SelectedIndex >= 0)
                {
                    try
                    {
                        string text = removeDangerousCharsForSysCFG(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(cboColor.SelectedItem, null, "value", new object[0], null, null, null), null, "Trim", new object[0], null, null, null)));
                        com_writer("syscfg add DClr " + text);
                        waitForComResponse();
                        string text2 = clean_output_string(string_1);
                        sts("Color has been changed successfully!");
                        string_1 = null;
                        return;
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        Exception ex2 = ex;
                        std(ex2.Message);
                        ProjectData.ClearProjectError();
                        return;
                    }
                }
                std("Please select a color value from the box!");
            }

        }
        private void colorwrite_Click(object sender, EventArgs e)
        {
            Clw();
        }


        public void Mlw()
        {
            if (mlbcheck.Checked)
            {
                try
                {
                    string text = removeDangerousCharsForSysCFG(mlbbox.Text.Trim());
                    com_writer("syscfg add MLB# " + text);
                    waitForComResponse();
                    string text2 = clean_output_string(string_1);
                    sts("MLB# has been written successfully!");
                    string_1 = null;
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    std(ex2.Message);
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void mlbwrite_Click(object sender, EventArgs e)
        {
            Mlw();
        }


        public void Mdlw()
        {
            if (modelcheck.Checked)
            {
                try
                {
                    string text = removeDangerousCharsForSysCFG(modelbox.Text.Trim());
                    com_writer("syscfg add RMd# " + text);
                    waitForComResponse();
                    string text2 = clean_output_string(string_1);
                    sts("Model has been changed successfully!");
                    string_1 = null;
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    std(ex2.Message);
                    ProjectData.ClearProjectError();
                }
            }
        }
        private void modelwrite_Click(object sender, EventArgs e)
        {
            Mdlw();
        }


        public void Nvsnw()
        {
            if (nvsncheck.Checked)
            {
                try
                {
                    string text = removeDangerousCharsForSysCFG(nvsnbox.Text.Trim());
                    com_writer("syscfg add NvSn " + text);
                    waitForComResponse();
                    string text2 = clean_output_string(string_1);
                    sts("NvSn has been changed successfully!");
                    string_1 = null;
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    std(ex2.Message);
                    ProjectData.ClearProjectError();
                }
            }
        }
        private void nvsnwrite_Click(object sender, EventArgs e)
        {
            Nvsnw();
        }


        public void Nsrnw()
        {
            if (nsrncheck.Checked)
            {


                try
                {
                    string text = removeDangerousCharsForSysCFG(nsrnbox.Text.Trim());
                    com_writer("syscfg add NSrN " + text);
                    waitForComResponse();
                    string text2 = clean_output_string(string_1);
                    sts("NSrN has been changed successfully!");
                    string_1 = null;
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    std(ex2.Message);
                    ProjectData.ClearProjectError();
                }
            }
        }
        private void nsrnwrite_Click(object sender, EventArgs e)
        {
            Nsrnw();
        }


        public void Lcmw()
        {
            if (lcmcheck.Checked)
            {
                try
                {
                    string text = removeDangerousCharsForSysCFG(lcmbox.Text.Trim());
                    com_writer("syscfg add LCM# " + text);
                    waitForComResponse();
                    string text2 = clean_output_string(string_1);
                    sts("LCM# has been changed successfully!");
                    string_1 = null;
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    std(ex2.Message);
                    ProjectData.ClearProjectError();
                }
            }
        }
        private void lcmwrite_Click(object sender, EventArgs e)
        {
            Lcmw();
        }


        public void Btrw()
        {
            if (batterycheck.Checked)
            {
                try
                {
                    string text = removeDangerousCharsForSysCFG(batterybox.Text.Trim());
                    com_writer("syscfg add Batt " + text);
                    waitForComResponse();
                    string text2 = clean_output_string(string_1);
                    sts("Battery SN has been changed successfully!");
                    string_1 = null;
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    std(ex2.Message);
                    ProjectData.ClearProjectError();
                }
            }
        }
        private void batterywrite_Click(object sender, EventArgs e)
        {
            Btrw();
        }


        public void Bcmw()
        {
            if (bcmscheck.Checked)
            {
                try
                {
                    string text = removeDangerousCharsForSysCFG(bcmsbox.Text.Trim());
                    com_writer("syscfg add BCMS " + text);
                    waitForComResponse();
                    string text2 = clean_output_string(string_1);
                    sts("BCMS has been changed successfully!");
                    string_1 = null;
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    std(ex2.Message);
                    ProjectData.ClearProjectError();
                }
            }
        }
        private void bcmswrite_Click(object sender, EventArgs e)
        {
            Bcmw();
        }



        public void Fcmw()
        {
            if (fcmscheck.Checked)
            {

                try
                {
                    string text = removeDangerousCharsForSysCFG(fcmsbox.Text.Trim());
                    com_writer("syscfg add FCMS " + text);
                    waitForComResponse();
                    string text2 = clean_output_string(string_1);
                    sts("FCMS has been changed successfully!");
                    string_1 = null;
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    std(ex2.Message);
                    ProjectData.ClearProjectError();
                }
            }
        }
        private void fcmswrite_Click(object sender, EventArgs e)
        {
            Fcmw();
        }



        public void Mtsnw()
        {
            if (mtsncheck.Checked)
            {

                try
                {
                    string text = removeDangerousCharsForSysCFG(mtsnbox.Text.Trim());
                    com_writer("syscfg add MtSN " + text);
                    waitForComResponse();
                    string text2 = clean_output_string(string_1);
                    sts("MTSN has been changed successfully!");
                    string_1 = null;
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    std(ex2.Message);
                    ProjectData.ClearProjectError();
                }
            }
        }
        private void mtsnwrite_Click(object sender, EventArgs e)
        {
            Mtsnw();
        }
        public string parseMacToOctal(string hex)
        {
            string result = "";
            try
            {
                string[] array = hex.Split(':');
                result = "0x" + array[3].ToString() + array[2].ToString() + array[1].ToString() + array[0].ToString() + " 0x0000" + array[5].ToString() + array[4].ToString() + " 0x00000000 0x00000000";
                return result;
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
                return result;
            }
        }

        public static object smethod_27(string string_20)
        {
            if (new Regex("^([0-9a-fA-F]{2}(?:(?:[0-9a-fA-F]{2}){5}|(?::[0-9a-fA-F]{2}){5}|[0-9a-fA-F]{10}))$").IsMatch(string_20))
            {
                return true;
            }
            return false;
        }

        public void Wfw()
        {
            if (wificheck.Checked)
            {
                if (Conversions.ToBoolean(smethod_27(wifibox.Text)))
                {
                    try
                    {
                        string text = parseMacToOctal(wifibox.Text);
                        string text2 = removeDangerousCharsForSysCFG(text.Trim());
                        com_writer("syscfg add WMac " + text2);
                        waitForComResponse();
                        string text3 = clean_output_string(string_1);
                        sts("WiFi has been changed successfully!");
                        string_1 = null;
                        return;
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        Exception ex2 = ex;
                        std(ex2.Message);
                        ProjectData.ClearProjectError();
                        return;
                    }
                }

                std("Please enter a valid MAC address!");
            }
        }
        private void wifiwrite_Click(object sender, EventArgs e)
        {
            Wfw();
        }


        public void Btmw()
        {
            if (bmaccheck.Checked)
            {
                if (Conversions.ToBoolean(smethod_27(bmacbox.Text)))
                {
                    try
                    {
                        string text = parseMacToOctal(bmacbox.Text);
                        string text2 = removeDangerousCharsForSysCFG(text.Trim());
                        com_writer("syscfg add BMac " + text2);
                        waitForComResponse();
                        string text3 = clean_output_string(string_1);
                        sts("BMAC has been changed successfully!");
                        string_1 = null;
                        return;
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        Exception ex2 = ex;
                        std(ex2.Message);
                        ProjectData.ClearProjectError();
                        return;
                    }
                }

                std("Please enter a valid MAC address!");
            }
        }
        private void btmacwrite_Click(object sender, EventArgs e)
        {
            Btmw();
        }


        public void Emacw()
        {
            if (emaccheck.Checked)
            {
                if (Conversions.ToBoolean(smethod_27(emacbox.Text)))
                {
                    try
                    {
                        string text = parseMacToOctal(emacbox.Text);
                        string text2 = removeDangerousCharsForSysCFG(text.Trim());
                        com_writer("syscfg add EMac " + text2);
                        waitForComResponse();
                        string text3 = clean_output_string(string_1);
                        sts("EMAC has been changed successfully!");
                        string_1 = null;
                        return;
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        Exception ex2 = ex;
                        std(ex2.Message);
                        ProjectData.ClearProjectError();
                        return;
                    }
                }
                std("Please enter a valid MAC address!");

            }
        }
        private void emacwrite_Click(object sender, EventArgs e)
        {
            Emacw();
        }



        private void ButtonX_Click(object sender, EventArgs e)
        {
            bool @checked = false;
            if (Operators.CompareString(ButtonX.Text, "Select All", TextCompare: true) == 0)
            {
                @checked = true;
                ButtonX.Text = "Unselect All";
                string stat = "All fields have been selected";
                sts(stat);
            }
            else if (Operators.CompareString(ButtonX.Text, "Unselect All", TextCompare: true) == 0)
            {
                @checked = false;
                ButtonX.Text = "Select All";
                string stat = "All fields have been unselected";
                sts(stat);
            }
            sncheck.Checked = @checked;
            modecheck.Checked = @checked;
            regioncheck.Checked = @checked;
            colorcheck.Checked = @checked;
            wificheck.Checked = @checked;
            bmaccheck.Checked = @checked;
            emaccheck.Checked = @checked;
            mlbcheck.Checked = @checked;
            modelcheck.Checked = @checked;
            nvsncheck.Checked = @checked;
            nsrncheck.Checked = @checked;
            lcmcheck.Checked = @checked;
            batterycheck.Checked = @checked;
            bcmscheck.Checked = @checked;
            fcmscheck.Checked = @checked;
            mtsncheck.Checked = @checked;


        }

        private void writeselected_Click(object sender, EventArgs e)
        {
            Snw();
            Mdw();
            RgW();
            Clw();
            Wfw();
            Btmw();
            Emacw();
            Mlw();
            Mdlw();
            Nvsnw();
            Nsrnw();
            Lcmw();
            Btrw();
            Bcmw();
            Fcmw();
            Mtsnw();


        }

       

        private void devbdid_Click(object sender, EventArgs e)
        {

        }

        private void readdfudevice_Click(object sender, EventArgs e)
        {
            Thread dfff = new Thread(readDFU);
            dfff.IsBackground = true;
            dfff.Start();

            EnableALL();
        }

       

        private void bootpurple_Click(object sender, EventArgs e)
        {
            try
            {
                readDFU();
                NewPurple();
                if (label3.Text.ToLower() != "gaster")
                {
                    throw new Exception("Please PWNDFU Device with GASTER");
                }
                string path = Purplelink + SIXRD + ".zip";
                string localpath = Npath1 + SIXRD + ".zip";

                if (!Directory.Exists(Npath1))
                {
                    Directory.CreateDirectory(Npath1);
                }

                Downloader(path, localpath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void connectserial_Click(object sender, EventArgs e)
        {

            com_connect(metroComboBox1.SelectedItem.ToString());
            status.Text = "Serial Port Connected Successfully!";
            status.ForeColor = System.Drawing.Color.LimeGreen;
        }

        private void readsyscfg_Click_1(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(getIMEI());
                snbox.Text = getSN();
                modebox.Text = getMode();
                regionbox.Text = getRgn();
                cboColor.Text = getDClr();
                wifibox.Text = getWMac();
                bmacbox.Text = getBMac();
                emacbox.Text = getEMac();
                mlbbox.Text = getMLB();
                modelbox.Text = getModel();
                initialize_colors(modelbox.Text, template_color);
                nvsnbox.Text = getNvSn();
                nsrnbox.Text = getNSrN();
                lcmbox.Text = getLCM();
                batterybox.Text = getBatt();
                bcmsbox.Text = getBCMS();
                fcmsbox.Text = getFCMS();
                mtsnbox.Text = getMtSN();
                sts("SYSCFG Read Completed!");

            }
            catch (Exception ex)
            {
                std("Error:" + ex.Message);
                serialPort_0.Close();
            }
        }

        private void savesyscfg_Click_1(object sender, EventArgs e)
        {

            CreateLog("==========================");
            CreateLog("           ");
            CreateLog("SrNm: " + snbox.Text);
            CreateLog("Mod#: " + modebox.Text);
            CreateLog("Regn: " + regionbox.Text);
            CreateLog("DClr: " + cboColor.Text);
            CreateLog("WMac: " + wifibox.Text);
            CreateLog("BMac: " + bmacbox.Text);
            CreateLog("EMac: " + emacbox.Text);
            CreateLog("MLB#: " + mlbbox.Text);
            CreateLog("RMd#: " + modelbox.Text);
            CreateLog("NvSn: " + nvsnbox.Text);
            CreateLog("NSrN: " + nsrnbox.Text);
            CreateLog("LCM#: " + lcmbox.Text);
            CreateLog("Batt: " + batterybox.Text);
            CreateLog("BCMS: " + bcmsbox.Text);
            CreateLog("FCMS: " + fcmsbox.Text);
            CreateLog("MtSN: " + mtsnbox.Text);
            CreateLog("         ");
            CreateLog("==========================");

            string timestamp = DateTime.Now.ToString("dd-mm-yyyy_hh-mm");
            sts("Backup has been saved successfully at: " + Environment.CurrentDirectory + "\\backup\\" + ECID_TEXT.Text + "_" + timestamp + ".txt");
        }

        private void fixcamera_Click_1(object sender, EventArgs e)
        {

            switch ((int)MessageBox.Show(this, "Click \"Yes\" if your device is A9 and up otherwise click \"No\" if your device is A5-A8", "IMPORTANT", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case 6:
                    try
                    {
                        com_writer("syscfg add SwBh 0x00000011 0x00000000 0x00000000 0x00000000");
                        waitForComResponse();
                        clean_output_string(string_1);
                        string_1 = null;
                        sts("Camera has been fixed successfully!");
                        break;
                    }
                    catch (Exception ex3)
                    {
                        ProjectData.SetProjectError(ex3);
                        Exception ex4 = ex3;
                        std(ex4.Message);
                        ProjectData.ClearProjectError();
                        break;
                    }
                case 7:
                    try
                    {
                        com_writer("syscfg add Regn MY/A");
                        waitForComResponse();
                        clean_output_string(string_1);
                        string_1 = null;
                        sts("Camera has been fixed successfully!");
                        break;
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        Exception ex2 = ex;
                        std(ex2.Message);
                        ProjectData.ClearProjectError();
                        break;
                    }
                default:
                    std("Operation aborted!");
                    break;
            }
        }

        private void fixfacetime_Click_1(object sender, EventArgs e)
        {
            try
            {
                com_writer("syscfg add SwBh 0x00000001 0x00000000 0x00000000 0x00000000");
                waitForComResponse();
                clean_output_string(string_1);
                sts("FaceTime has been Fixed successfully!");
                string_1 = null;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                std("Failed to fix FaceTime!");
                ProjectData.ClearProjectError();
            }
        }

        private void unbindwifi_Click_1(object sender, EventArgs e)
        {
            try
            {
                com_writer("syscfg delete WCAL");
                waitForComResponse();
                clean_output_string(string_1);
                sts("WiFi has been Unlocked Successfully!");
                string_1 = null;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                std("WiFi Unlock Failed!");
                ProjectData.ClearProjectError();
            }
        }

        private void factoryreset_Click(object sender, EventArgs e)
        {
            if (confirm("You are about to factory reset your device. This will erase all device content and settings. This can't be undone after restarted!\r\n\r\nAre you sure that you want to continue?", "WARNING!"))
            {
                try
                {
                    com_writer("nvram --set oblit-inprogress 5");
                    waitForComResponse();
                    com_writer("nvram --save");
                    waitForComResponse();
                    com_writer("reset");
                    string_1 = null;
                    sts("Your device should reboot now and start Factory Reset Process!");

                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    std(ex2.Message);
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void exitpurple_Click(object sender, EventArgs e)
        {
            try
            {
                com_writer("nvram -d oblit-inprogress");
                com_writer("nvram -d oblit-inprogress");
                com_writer("reset");
                com_disconnect();
                status.Text = "Device Should Reboot Now...";
                status.ForeColor = System.Drawing.Color.LimeGreen;
                newShetouane.FixAllDrivers();

            }
            catch (Exception ex)
            {
                std("Error:" + ex.Message);
                serialPort_0.Close();
            }
        }

        private void dcsdlist_Click(object sender, EventArgs e)
        {
            string devlist = "Modelos soportados púrpura con y sin cable   \r\n" +
                "\r\n" +
                "iPhone SE (DCSD) \r\n" +
                "iPhone 6s & 6sPlus (DCSD) \r\n" +
                "iPhone 7 & 7Plus\r\n" +
                "iPhone 8 & 8Plus \r\n" +
                "iPhone X    \r\n" +
                "Supported iPad models: \r\n  \r\n" +
                "iPad Air 2 WiFi (A1566) (DCSD) \r\n" +
                "iPad Air 2 4G (A1567) (DCSD) \r\n" +
                "iPad Mini 4 WiFi (A1538) (DCSD) \r\n" +
                "iPad Mini 4 4G (A1550) (DCSD) \r\n" +
                "iPad 5 2017 WiFi (A1822) (DCSD) \r\n" +
                "iPad 5 2017 4G (A1823) (DCSD) \r\n" +
                "iPad 6 2018 WiFi (A1893) \r\n" +
                "iPad 6 2018 4G (A1954) \r\n" +
                "iPad 7 2019 WiFi (A2197) \r\n" +
                "iPad 7 2019 4G (A2198)(A2200) \r\n" +
                "iPad Pro 10.5 WiFi (A1701) \r\n" +
                "iPad Pro 10.5 4G (A1709) (A1852) \r\n" +
                "iPad Pro 12.9 2nd Gen WiFi (A1670) \r\n" +
                "iPad Pro 12.9 2nd Gen 4G (A1671) (A1821) \r\n" +
                "iPad Pro 2 (12.9-inch, WiFi / LTE)";
            MessageBox.Show(devlist, "Supported models with or without DCSD Cable");
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public static class iOSDevicex
    {
        public static bool debugMode = false;
        public static string Model = "";
        public static string ECID = "";
        public static string ipwndfu = "";
        public static string ProductType = "";
        public static string mode = "";
        public static bool isMEID = false;

    }
}
