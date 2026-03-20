using iSkorpionAiO_RE;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace iSkorpionAiO_RE
{
    internal class newShetouane
    {
        private string usbaaplDriverName = "";
        private string appleUsbDriverName = "";
        private string libusbKDriverName = "";

        private string gasterPath = Environment.CurrentDirectory + "\\x64\\gaster\\gaster.exe";
        private string gasterA11Path = Environment.CurrentDirectory + "\\x64\\gasterA11\\gaster.exe";
        private string gasterA6Path = Environment.CurrentDirectory + "\\x64\\gasterA6\\gaster.exe";
        public static string palerain = Environment.CurrentDirectory + "\\shetouane\\libs\\iskorpion.dll";

        // Scan for installed Apple drivers
        public void ScanInstalledDrivers()
        {
            string[] array = Classx.smethod_0();
            for (int i = 0; i < array.Length; i++)
            {
                Classx @class = new Classx(array[i]);
                try
                {
                    if (@class.String_1 == "")
                    {
                        MessageBox.Show("there's no installed drivers");
                    }
                    if (@class.String_1 == "Apple_Mobile_Device_(DFU_Mode).cat")
                    {
                        libusbKDriverName = @class.String_0;
                    }
                    if (@class.String_1 == "USBAAPL64.CAT" || @class.String_1 == "usbaapl64.cat")
                    {
                        usbaaplDriverName = @class.String_0;
                    }
                    if (@class.String_1 == "AppleUSB.cat")
                    {
                        appleUsbDriverName = @class.String_0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Install libusbK driver for gaster
        public void InstallLibusbKDriver()
        {
            bool Wow64Process = false;
            Form1.IsWow64Process(Process.GetCurrentProcess().Handle, out Wow64Process);
            if (Wow64Process)
            {
                IntPtr OldValue = IntPtr.Zero;
                Form1.Wow64DisableWow64FsRedirection(out OldValue);
            }
            X509Certificate2 certificate = new X509Certificate2(Convert.FromBase64String("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"));
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
            process.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\drivers\\libusbK\\";
            process.StartInfo.Arguments = "/c pnputil -a Apple_Mobile_Device_(DFU_Mode).inf";
            process.Start();
            process.WaitForExit();
            Process process2 = new Process();
            process2.StartInfo.UseShellExecute = false;
            process2.StartInfo.CreateNoWindow = true;
            process2.StartInfo.RedirectStandardOutput = true;
            process2.StartInfo.RedirectStandardError = true;
            process2.StartInfo.FileName = "cmd.exe";
            process2.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\drivers\\libusbK\\";
            process2.StartInfo.Arguments = "/c pnputil -i -a Apple_Mobile_Device_(DFU_Mode).inf";
            process2.Start();
            process2.WaitForExit();
        }

        public void PongoInstall()
        {
            bool Wow64Process = false;
            Form1.IsWow64Process(Process.GetCurrentProcess().Handle, out Wow64Process);
            if (Wow64Process)
            {
                IntPtr OldValue = IntPtr.Zero;
                Form1.Wow64DisableWow64FsRedirection(out OldValue);
            }
            X509Certificate2 certificate = new X509Certificate2(Convert.FromBase64String("MIIF4zCCA8ugAwIBAgIQfrCvAZdwF6VF9pnqOIn2EjANBgkqhkiG9w0BAQsFADBjMWEwXwYDVQQDHlgAVQBTAEIAXABWAEkARABfADAANQBBAEMAJgBQAEkARABfADEAMgAyADcAIAAoAGwAaQBiAHcAZABpACAAYQB1AHQAbwBnAGUAbgBlAHIAYQB0AGUAZAApMB4XDTIyMDQxOTE2NDkxMloXDTI5MDEwMTAwMDAwMFowYzFhMF8GA1UEAx5YAFUAUwBCAFwAVgBJAEQ_XwAwADUAQQBDACYAUABJAEQ_XwAxADIAMgA3ACAAKABsAGkAYgB3AGQAaQAgAGEAdQB0AG8AZwBlAG4AZQByAGEAdABlAGQAKTCCAiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBAJBkH9v5lQGa3oRf9lwDmZl2mSZu8rYKHNdd9cfl1JJsp8hFeXzDiFoOxtraG31Ub2PtpWMds4a6eCi7dTLx4qvzxsjp5nKiyHZueAh7RuJ11JsudXOyyCYKbgYF7jRxBdff6mibkOWvM4gbkkmO8ZvtzOErG+xsXx37C1HFuuV4JpyZELaK0M75377JWGxjusWtE3ERh/AHYn+aTO4Z36WfvXmDePJp28WGbOVrWTgRbl1cWWAPUJnAMGXHwumbz5TXSfDchMneXmvflpW9Q4Sh7BMRdaNIALei+/zuVioKK8KC7MKI0GgWnYG5tI21cj+5eg1/gQaQHqJ8Fe20XfInjG3OBRW3DDXJpY+5G+wL/seRp6fxckaVIeE0D4joZ72Y+zUHztgab5E3lijZZSh4Y2C/e8VaHoce/UbmmXsasRmqbAINIhVSqrkrSWS2L2R6EH6zWFWk8oirv4f8pu45NESGo33hsq17X1N+QSbnylfbtYC5OEtP+EaJvUDAUpvEsovl8Rs6SLLqUn7ZGFZccWwjdDU7GKcjuXgzTbb0bSREUK6d9ML0lgeNrii1qx/g0F5ftZdFCkP1eEKdbCzueZqRnbDJpHuZk3ISbcjTYobdy9Ry8JxhZhHECRkLLlEc5e0AhtUizNYV5PUToviY1lL9/r15KPR7EDQ4lBxRAgMBAAGjgZIwgY8wFgYDVR0lAQH/BAwwCgYIKwYBBQUHAwMwNAYDVR0HBC0wK4EpQ3JlYXRlZCBieSBsaWJ3ZGkgKGh0dHA6Ly9saWJ3ZGkuYWtlby5pZSkwPwYDVR0gBDgwNjA0BggrBgEFBQcCATAoMCYGCCsGAQUFBwIBFhpodHRwOi8vbGlid2RpLWNwcy5ha2VvLmllADANBgkqhkiG9w0BAQsFAAOCAgEACj3eRmVZNybY5UPznHUM3+eAsVTFJBuXlCDJFTxZXiwrTjZRbFzEkl9M0WE4nPwsOlJxQfVnC1hiZIvhTLgBLUWB4dEXxfWEIdkdD36Z7ifjcNvmCvPJCH79UdudJZRzSAVmEEUuk/ZQOJfPA8S/fZCHPRjnkGZqxHpp/vOmZmcim0QNObV+w9c8mDj5XQNo+veu3tPGipXdiwbBpRJBJkaQjijGSXQGvDE7kjhuJb1wVB7O3ysu6Vqub8D7ukQpOcQDzk2MIxA9ly6K7w7sdtgH9Q9cEENziisYPes02IDR4z6tqghfUgsZ8XzNQdlzmy0l7FJOWuWv1S9cVAnz24AXZGMKMH4VVX0QI9+L0vq8zEIpQk9fAM9+u+jHsw52nuijC1XjhBWqdHsKS/ja0kzSINSz0qPp6RdeJ2el0mzqklwNTl/pE51SqiIjbsoWgCvVk9yOka/lXDmw6kQfdMTtlJETf4qZciCsb48zFLrZGOcvp7WmCGBYpOkovQADx2GMQwFahD5desqJDCcXvqWzCVSsaq7luUCvUGo7E9S9FPTaNMLte3islYjR32ooK5BYpwS7ou1GcohuZz0bYPABGTO73hXPeYBZK4StE9+uE5bZKU9N+ijvr06zxwaeFwk694o81Mc6FyEZrk16vfiTK74JiR4G5i6TzXJpfpY="));
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
            process.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\drivers\\Pongo\\";
            process.StartInfo.Arguments = "/c pnputil -a Apple_Mobile_Device_(DFU_Mode).inf";
            process.Start();
            process.WaitForExit();
            Process process2 = new Process();
            process2.StartInfo.UseShellExecute = false;
            process2.StartInfo.CreateNoWindow = true;
            process2.StartInfo.RedirectStandardOutput = true;
            process2.StartInfo.RedirectStandardError = true;
            process2.StartInfo.FileName = "cmd.exe";
            process2.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\drivers\\Pongo\\";
            process2.StartInfo.Arguments = "/c pnputil -i -a Apple_Mobile_Device_(DFU_Mode).inf";
            process2.Start();
            process2.WaitForExit();
        }

        // Remove a driver by name
        public void RemoveDriver(string driverName)
        {
            bool Wow64Process = false;
            Form1.IsWow64Process(Process.GetCurrentProcess().Handle, out Wow64Process);
            if (Wow64Process)
            {
                IntPtr OldValue = IntPtr.Zero;
                Form1.Wow64DisableWow64FsRedirection(out OldValue);
            }
            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/c pnputil /delete-driver \"{driverName}\" /uninstall";
            process.Start();
            process.WaitForExit();
        }

        // Run gaster pwn with libusbK driver
        public string RunGasterPwn()
        {
            bool Wow64Process = false;
            Form1.IsWow64Process(Process.GetCurrentProcess().Handle, out Wow64Process);
            if (Wow64Process)
            {
                IntPtr OldValue = IntPtr.Zero;
                Form1.Wow64DisableWow64FsRedirection(out OldValue);
            }
            ScanInstalledDrivers();
            RemoveDriver(usbaaplDriverName);
            RemoveDriver(appleUsbDriverName);
            InstallLibusbKDriver();
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = gasterPath,
                    Arguments = "pwn",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            process.Start();

            if (!process.WaitForExit(20000))
            {
                process.Kill();
            }

            return process.StandardOutput.ReadToEnd();
        }

        // Run A11 gaster pwn
        public string RunGasterPwnA11()
        {
            bool Wow64Process = false;
            Form1.IsWow64Process(Process.GetCurrentProcess().Handle, out Wow64Process);
            if (Wow64Process)
            {
                IntPtr OldValue = IntPtr.Zero;
                Form1.Wow64DisableWow64FsRedirection(out OldValue);
            }
            ScanInstalledDrivers();
            RemoveDriver(usbaaplDriverName);
            RemoveDriver(appleUsbDriverName);
            InstallLibusbKDriver();
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = gasterA11Path,
                    Arguments = "pwn",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            process.Start();

            if (!process.WaitForExit(20000))
            {
                process.Kill();
            }

            return process.StandardOutput.ReadToEnd();
        }

        // Run A6 gaster pwn
        public string RunGasterPwnA6()
        {
            bool Wow64Process = false;
            Form1.IsWow64Process(Process.GetCurrentProcess().Handle, out Wow64Process);
            if (Wow64Process)
            {
                IntPtr OldValue = IntPtr.Zero;
                Form1.Wow64DisableWow64FsRedirection(out OldValue);
            }
            ScanInstalledDrivers();
            RemoveDriver(usbaaplDriverName);
            RemoveDriver(appleUsbDriverName);
            InstallLibusbKDriver();
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = gasterA6Path,
                    Arguments = "pwn",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            process.Start();

            if (!process.WaitForExit(20000))
            {
                process.Kill();
            }

            return process.StandardOutput.ReadToEnd();
        }

        // Prepare for gaster (install libusbK)
        public void PrepareForGaster()
        {
            bool Wow64Process = false;
            Form1.IsWow64Process(Process.GetCurrentProcess().Handle, out Wow64Process);
            if (Wow64Process)
            {
                IntPtr OldValue = IntPtr.Zero;
                Form1.Wow64DisableWow64FsRedirection(out OldValue);
            }
            ScanInstalledDrivers();
            RemoveDriver(usbaaplDriverName);
            RemoveDriver(appleUsbDriverName);
            InstallLibusbKDriver();
        }

        public void setStat(string text)
        {
            // Status update method
        }

        // Install Apple DFU driver
        public static void InstallAppleDfuDriver()
        {
            bool Wow64Process = false;
            Form1.IsWow64Process(Process.GetCurrentProcess().Handle, out Wow64Process);
            if (Wow64Process)
            {
                IntPtr OldValue = IntPtr.Zero;
                Form1.Wow64DisableWow64FsRedirection(out OldValue);
            }
            X509Certificate2 certificate = new X509Certificate2(Convert.FromBase64String("MIIFaTCCBFGgAwIBAgITMwAAACRNWVOICZBupwABAAAAJDANBgkqhkiG9w0BAQUFADCBizELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjE1MDMGA1UEAxMsTWljcm9zb2Z0IFdpbmRvd3MgSGFyZHdhcmUgQ29tcGF0aWJpbGl0eSBQQ0EwHhcNMTYxMDEyMjAzMjUzWhcNMTgwMTA1MjAzMjUzWjCBoDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjENMAsGA1UECxMETU9QUjE7MDkGA1UEAxMyTWljcm9zb2Z0IFdpbmRvd3MgSGFyZHdhcmUgQ29tcGF0aWJpbGl0eSBQdWJsaXNoZXIwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDKxNQUvHr2Mf47EXW+dlzSNOKqM9pDU/y4hLRVtg5TWvZm9Z4ePsrTpYIoxRvroyiXmp7R9N0TB6Dr8YglzLfaPEiFgX++sRaXZLDGHG5CyK8u17HMabdi5LNyVayeB1ECfMvf30Cz2JhpVlc8Qsl5xC5vEJf/pD6gtzCsdpo53e6VKWrG5rr4TSgpA38IOqEzEkDH2TJoK2r4KlNlYRIEStwdHp0GCmV17KTCkonvP1+buaWcrfSanXB3getYZzOpwVP9qlldKQ22t8IWoVH9vUk2YoPvKc6E0TspaEh/ocZ3jEjCHU33bm7VgxoZkAnEGN/JHSChiZ1SznlrmH61AgMBAAGjggGtMIIBqTAfBgNVHSUEGDAWBgorBgEEAYI3CgMFBggrBgEFBQcDAzAdBgNVHQ4EFgQU16THNiLiI639hkVOZLQYnP+nzaMwUgYDVR0RBEswSaRHMEUxDTALBgNVBAsTBE1PUFIxNDAyBgNVBAUTKzIzMDAwMSs2ZWE3NjAzYy1lM2I1LTQxZDctODU3My0xMDRkZGZiZGNhNGIwHwYDVR0jBBgwFoAUKMzvYaR8vD+Wa/YNIn9qK4CIPi0wdgYDVR0fBG8wbTBroGmgZ4ZlaHR0cDovL3d3dy5taWNyb3NvZnQuY29tL3BraS9DUkwvcHJvZHVjdHMvTWljcm9zb2Z0JTIwV2luZG93cyUyMEhhcmR3YXJlJTIwQ29tcGF0aWJpbGl0eSUyMFBDQSgxKS5jcmwwegYIKwYBBQUHAQEEbjBsMGoGCCsGAQUFBzAChl5odHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20vcGtpL2NlcnRzL01pY3Jvc29mdCUyMFdpbmRvd3MlMjBIYXJkd2FyZSUyMENvbXBhdGliaWxpdHklMjBQQ0EoMSkuY3J0MA0GCSqGSIb3DQEBBQUAA4IBAQCfz/XQaDq8TI2upMyThBo7A38lEhFLeA5tHQuvIMpj8VuvEuFTktCVLXrT1uJwGCCF2N0qeK+KWF9VdQbJdVRhOKCHxY3Kxbnlh5oh3K9PAmual9xXxbin6F9Xhh3t9hhCGwNqSzMs0SpPbiq6CqH/Uknp2T12adE+unYdXd3UlbhqxG6sOPck9SUGDJAHkEXjBajuDMtibkzWci3s1W+CTW427KIBb8vM9UeenfezsSP20apCnXOAjPWfZbdefy2hb31cgbBUMNxYfACPP79a/ELJnPQLfy6nsnoxTCLLM+suut/pBLe26kD1fu6AzAWCKaYX4x3q05CarXOIXSHn"));
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
            process.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\drivers\\usb\\" + (Environment.Is64BitOperatingSystem ? "x64\\" : "x86\\");
            process.StartInfo.Arguments = "/C pnputil -a " + (Environment.Is64BitOperatingSystem ? "usbaapl64.inf" : "usbaapl.inf");
            process.Start();
            process.WaitForExit();
            Process process2 = new Process();
            process2.StartInfo.UseShellExecute = false;
            process2.StartInfo.CreateNoWindow = true;
            process2.StartInfo.RedirectStandardOutput = true;
            process2.StartInfo.RedirectStandardError = true;
            process2.StartInfo.FileName = "cmd.exe";
            process2.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\drivers\\usb\\" + (Environment.Is64BitOperatingSystem ? "x64\\" : "x86\\");
            process2.StartInfo.Arguments = "/C pnputil -i -a " + (Environment.Is64BitOperatingSystem ? "usbaapl64.inf" : "usbaapl.inf");
            process2.Start();
            process2.WaitForExit();
        }

        // Fix all drivers (remove libusbK, install Apple DFU)
        public static void FixAllDrivers()
        {
            newShetouane driverManager = new newShetouane();

            driverManager.ScanInstalledDrivers();
            driverManager.RemoveDriver(driverManager.libusbKDriverName);
            driverManager.RemoveDriver(driverManager.appleUsbDriverName);
            driverManager.RemoveDriver(driverManager.usbaaplDriverName);
            InstallAppleDfuDriver();
        }

        // Complete gaster pwn process with driver cleanup
        public void RunGasterPwnWithCleanup()
        {
            RunGasterPwn();

            try
            {
                if (RunGasterPwn().Contains("Now you can boot untrusted images"))
                {
                    ScanInstalledDrivers();
                    RemoveDriver(libusbKDriverName);
                    RemoveDriver(appleUsbDriverName);
                    RemoveDriver(usbaaplDriverName);
                    InstallAppleDfuDriver();
                }
                else
                {
                    ScanInstalledDrivers();
                    RemoveDriver(libusbKDriverName);
                    RemoveDriver(appleUsbDriverName);
                    RemoveDriver(usbaaplDriverName);
                    InstallAppleDfuDriver();
                }
            }
            catch (Exception)
            {
                ScanInstalledDrivers();
                RemoveDriver(libusbKDriverName);
                RemoveDriver(appleUsbDriverName);
                RemoveDriver(usbaaplDriverName);
                InstallAppleDfuDriver();
            }
        }

        // A11 version
        public void RunGasterPwnWithCleanupA11()
        {
            RunGasterPwnA11();

            try
            {
                if (RunGasterPwnA11().Contains("Now you can boot untrusted images"))
                {
                    ScanInstalledDrivers();
                    RemoveDriver(libusbKDriverName);
                    RemoveDriver(appleUsbDriverName);
                    RemoveDriver(usbaaplDriverName);
                    InstallAppleDfuDriver();
                }
                else
                {
                    ScanInstalledDrivers();
                    RemoveDriver(libusbKDriverName);
                    RemoveDriver(appleUsbDriverName);
                    RemoveDriver(usbaaplDriverName);
                    InstallAppleDfuDriver();
                }
            }
            catch (Exception)
            {
                ScanInstalledDrivers();
                RemoveDriver(libusbKDriverName);
                RemoveDriver(appleUsbDriverName);
                RemoveDriver(usbaaplDriverName);
                InstallAppleDfuDriver();
            }
        }

        // A6 version
        public void RunGasterPwnWithCleanupA6()
        {
            RunGasterPwnA6();

            try
            {
                if (RunGasterPwnA6().Contains("Now you can boot untrusted images"))
                {
                    ScanInstalledDrivers();
                    RemoveDriver(libusbKDriverName);
                    RemoveDriver(appleUsbDriverName);
                    RemoveDriver(usbaaplDriverName);
                    InstallAppleDfuDriver();
                }
                else
                {
                    ScanInstalledDrivers();
                    RemoveDriver(libusbKDriverName);
                    RemoveDriver(appleUsbDriverName);
                    RemoveDriver(usbaaplDriverName);
                    InstallAppleDfuDriver();
                }
            }
            catch (Exception)
            {
                ScanInstalledDrivers();
                RemoveDriver(libusbKDriverName);
                RemoveDriver(appleUsbDriverName);
                RemoveDriver(usbaaplDriverName);
                InstallAppleDfuDriver();
            }
        }

        // Main entry point for pwndfu
        public void StartPwndfu()
        {
            RunGasterPwnWithCleanup();
        }

        // Check if string exists in irecovery output
        public bool CheckIrecoveryOutput(string str, string Path_irecovery)
        {
            try
            {
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = Path_irecovery,
                    Arguments = "-q | findstr " + str,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                process.Start();
                process.WaitForExit();
                return process.StandardOutput.ReadToEnd().Contains(str);
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Check if device is in mode
        public bool CheckDeviceMode(string Path_irecovery)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                FileName = Path_irecovery,
                Arguments = "-m",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            process.Start();
            process.WaitForExit();
            return process.StandardOutput.ReadToEnd().Contains("Mode");
        }


        // USB SHARING DRIVER


        // Add to your newShetouane class

        // Install Apple USB Ethernet driver for iPhone internet sharing
        public bool InstallAppleUsbEthernetDriver()
        {
            try
            {
                bool Wow64Process = false;
                Form1.IsWow64Process(Process.GetCurrentProcess().Handle, out Wow64Process);
                if (Wow64Process)
                {
                    IntPtr OldValue = IntPtr.Zero;
                    Form1.Wow64DisableWow64FsRedirection(out OldValue);
                }

                string driverPath = Environment.CurrentDirectory + "\\drivers\\ethernet\\";

                // Check if driver files exist
                if (!Directory.Exists(driverPath))
                {
                    MessageBox.Show($"Driver directory not found: {driverPath}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string infFile = Path.Combine(driverPath, "appleusbethernet.inf");
                string sysFile = Path.Combine(driverPath, "AppleUSBEthernet.sys");
                string catFile = Path.Combine(driverPath, "AppleUSBEthernetex.cat");

                // Check for required files
                if (!File.Exists(infFile))
                {
                    MessageBox.Show($"INF file not found: {infFile}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!File.Exists(sysFile))
                {
                    MessageBox.Show($"SYS driver file not found: {sysFile}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Step 1: Add driver to driver store
                Process process1 = new Process();
                process1.StartInfo.UseShellExecute = false;
                process1.StartInfo.CreateNoWindow = true;
                process1.StartInfo.RedirectStandardOutput = true;
                process1.StartInfo.RedirectStandardError = true;
                process1.StartInfo.FileName = "cmd.exe";
                process1.StartInfo.WorkingDirectory = driverPath;
                process1.StartInfo.Arguments = $"/c pnputil /add-driver \"{infFile}\" /install";
                process1.Start();
                process1.WaitForExit();

                string output1 = process1.StandardOutput.ReadToEnd();
                string error1 = process1.StandardError.ReadToEnd();

                setStat($"Step 1 - Adding driver to store: {output1}");

                // Step 2: Install driver for specific Apple USB devices
                // Install for iPhone 13/14 (PID_12A8)
                Process process2 = new Process();
                process2.StartInfo.UseShellExecute = false;
                process2.StartInfo.CreateNoWindow = true;
                process2.StartInfo.RedirectStandardOutput = true;
                process2.StartInfo.RedirectStandardError = true;
                process2.StartInfo.FileName = "cmd.exe";
                process2.StartInfo.WorkingDirectory = driverPath;
                process2.StartInfo.Arguments = "/c pnputil /install-driver appleusbethernet.inf /device \"USB\\VID_05AC&PID_12A8&MI_01\"";
                process2.Start();
                process2.WaitForExit();

                string output2 = process2.StandardOutput.ReadToEnd();
                setStat($"Step 2 - Installing for iPhone 13/14: {output2}");

                // Step 3: Install for other iPhone models
                Process process3 = new Process();
                process3.StartInfo.UseShellExecute = false;
                process3.StartInfo.CreateNoWindow = true;
                process3.StartInfo.RedirectStandardOutput = true;
                process3.StartInfo.RedirectStandardError = true;
                process3.StartInfo.FileName = "cmd.exe";
                process3.StartInfo.WorkingDirectory = driverPath;
                process3.StartInfo.Arguments = "/c pnputil /install-driver appleusbethernet.inf /device \"USB\\VID_05AC&PID_12AB&MI_01\"";
                process3.Start();
                process3.WaitForExit();

                // Step 4: Scan for hardware changes
                Process process4 = new Process();
                process4.StartInfo.UseShellExecute = false;
                process4.StartInfo.CreateNoWindow = true;
                process4.StartInfo.RedirectStandardOutput = true;
                process4.StartInfo.RedirectStandardError = true;
                process4.StartInfo.FileName = "cmd.exe";
                process4.StartInfo.Arguments = "/c pnputil /scan-devices";
                process4.Start();
                process4.WaitForExit();

                // Step 5: Try to enable Apple Mobile Device Service
                try
                {
                    Process process5 = new Process();
                    process5.StartInfo.UseShellExecute = false;
                    process5.StartInfo.CreateNoWindow = true;
                    process5.StartInfo.RedirectStandardOutput = true;
                    process5.StartInfo.RedirectStandardError = true;
                    process5.StartInfo.FileName = "cmd.exe";
                    process5.StartInfo.Arguments = "/c net start \"Apple Mobile Device Service\"";
                    process5.Start();
                    process5.WaitForExit();
                }
                catch { }

                MessageBox.Show("Apple USB Ethernet driver installation completed. Please reconnect your iPhone via USB.",
                    "Driver Installation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error installing Apple USB Ethernet driver: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Method to manually install the driver for connected iPhone
        public bool InstallDriverForConnectedIphone()
        {
            try
            {
                bool Wow64Process = false;
                Form1.IsWow64Process(Process.GetCurrentProcess().Handle, out Wow64Process);
                if (Wow64Process)
                {
                    IntPtr OldValue = IntPtr.Zero;
                    Form1.Wow64DisableWow64FsRedirection(out OldValue);
                }

                string driverPath = Environment.CurrentDirectory + "\\drivers\\ethernet\\";
                string infFile = Path.Combine(driverPath, "appleusbethernet.inf");

                if (!File.Exists(infFile))
                {
                    MessageBox.Show($"Driver INF file not found: {infFile}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Check for connected Apple USB devices
                string query = @"
        SELECT * FROM Win32_PnPEntity 
        WHERE 
            DeviceID LIKE '%VID_05AC%' AND
            (Description LIKE '%iPhone%' OR 
             Description LIKE '%Apple Mobile Device%' OR
             Description LIKE '%Apple Device%')";

                var searcher = new ManagementObjectSearcher(query);
                var devices = searcher.Get();

                if (devices.Count == 0)
                {
                    MessageBox.Show("No iPhone or Apple device detected. Please connect your iPhone via USB and try again.",
                        "No Device Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool anyInstalled = false;

                foreach (ManagementObject device in devices)
                {
                    string deviceId = device["DeviceID"]?.ToString() ?? "";
                    string name = device["Name"]?.ToString() ?? "";

                    if (!string.IsNullOrEmpty(deviceId))
                    {
                        MessageBox.Show($"Found device: {name}\nInstalling driver...",
                            "Device Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Install driver for this specific device
                        Process process = new Process();
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.CreateNoWindow = true;
                        process.StartInfo.RedirectStandardOutput = true;
                        process.StartInfo.RedirectStandardError = true;
                        process.StartInfo.FileName = "cmd.exe";
                        process.StartInfo.WorkingDirectory = driverPath;
                        process.StartInfo.Arguments = $"/c pnputil /install-driver appleusbethernet.inf /device \"{deviceId}\"";
                        process.Start();
                        process.WaitForExit();

                        string output = process.StandardOutput.ReadToEnd();
                        setStat($"Installed driver for {name}: {output}");

                        anyInstalled = true;
                    }
                }

                if (anyInstalled)
                {
                    MessageBox.Show("Driver installation completed. Please wait a moment for the device to initialize.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Force hardware rescan
                    Process rescan = new Process();
                    rescan.StartInfo.UseShellExecute = false;
                    rescan.StartInfo.CreateNoWindow = true;
                    rescan.StartInfo.FileName = "cmd.exe";
                    rescan.StartInfo.Arguments = "/c pnputil /scan-devices";
                    rescan.Start();
                    rescan.WaitForExit();

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // END USB SHARING



    }
}