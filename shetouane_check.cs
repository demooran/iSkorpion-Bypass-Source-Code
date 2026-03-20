using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace iSkorpionAiO_RE
{
    class checker
    {

        public static string APIBaseURL = "http://iskorpion.com/api/api.php?ecid=";
        public static string A12Api = "http://iskorpion.com/bypass/A12/check.php?serial=";

        public bool checkpasscode(string sn)
        {
            try
            {
                string requestUrl = APIBaseURL + sn + "&service=2";
                HttpWebRequest request = HttpWebRequest.CreateHttp(requestUrl);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.Timeout = -1;
                string responseBodyFromRemoteServer;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseBodyFromRemoteServer = reader.ReadToEnd();
                    }
                }
                Debug.WriteLine(sn);
                Debug.WriteLine(responseBodyFromRemoteServer);  
                return responseBodyFromRemoteServer == "AUTHORIZED";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        public bool checkA12(string sn,string product)
        {
            try
            {
                string requestUrl = A12Api + sn + "&product=" + product;
                HttpWebRequest request = HttpWebRequest.CreateHttp(requestUrl);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.Timeout = -1;
                string responseBodyFromRemoteServer;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseBodyFromRemoteServer = reader.ReadToEnd();
                    }
                }
                Debug.WriteLine(sn);
                Debug.WriteLine(responseBodyFromRemoteServer);
                return responseBodyFromRemoteServer == "AUTHORIZED";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }
       

        public bool checkhello(string sn)
        {
            try
            {
                string requestUrl = APIBaseURL + sn + "&service=3";
                HttpWebRequest request = HttpWebRequest.CreateHttp(requestUrl);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.Timeout = -1;
                string responseBodyFromRemoteServer;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseBodyFromRemoteServer = reader.ReadToEnd();
                    }
                }
                return responseBodyFromRemoteServer == "AUTHORIZED";
            }
            catch
            {
                return false;
            }
        }

        public bool checkaccount(string sn)
        {
            try
            {
                string requestUrl = APIBaseURL + sn + "&service=9";
                HttpWebRequest request = HttpWebRequest.CreateHttp(requestUrl);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.Timeout = -1;
                string responseBodyFromRemoteServer;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseBodyFromRemoteServer = reader.ReadToEnd();
                    }
                }
                return responseBodyFromRemoteServer == "AUTHORIZED";
            }
            catch
            {
                return false;
            }
        }



       
        public bool checkgsm(string sn)
        {
            try
            {
                string requestUrl = APIBaseURL + sn + "&service=5";
                HttpWebRequest request = HttpWebRequest.CreateHttp(requestUrl);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.Timeout = -1;
                string responseBodyFromRemoteServer;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseBodyFromRemoteServer = reader.ReadToEnd();
                    }
                }
                return responseBodyFromRemoteServer == "AUTHORIZED";
            }
            catch
            {
                return false;
            }
        }

        public bool checkmeid(string sn)
        {
            try
            {
                string requestUrl = APIBaseURL + sn + "&service=8";
                HttpWebRequest request = HttpWebRequest.CreateHttp(requestUrl);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.Timeout = -1;
                string responseBodyFromRemoteServer;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseBodyFromRemoteServer = reader.ReadToEnd();
                    }
                }
                return responseBodyFromRemoteServer == "AUTHORIZED";
            }
            catch
            {
                return false;
            }
        }
        public bool check_acc(string sn)
        {
            try
            {
                string requestUrl = APIBaseURL + sn + "&service=9";
                HttpWebRequest request = HttpWebRequest.CreateHttp(requestUrl);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.Timeout = -1;
                string responseBodyFromRemoteServer;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseBodyFromRemoteServer = reader.ReadToEnd();
                    }
                }
                return responseBodyFromRemoteServer == "AUTHORIZED";
            }
            catch
            {
                return false;
            }
        }


        public bool check_pass(string sn)
        {
            try
            {
                string requestUrl = APIBaseURL + sn + "&service=6";
                HttpWebRequest request = HttpWebRequest.CreateHttp(requestUrl);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.Timeout = -1;
                string responseBodyFromRemoteServer;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseBodyFromRemoteServer = reader.ReadToEnd();
                    }
                }
                return responseBodyFromRemoteServer == "AUTHORIZED";
            }
            catch
            {
                return false;
            }
        }

        public bool checkBroken(string sn)
        {
            try
            {
                string requestUrl = APIBaseURL + sn + "&service=7";
                HttpWebRequest request = HttpWebRequest.CreateHttp(requestUrl);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.Timeout = -1;
                string responseBodyFromRemoteServer;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseBodyFromRemoteServer = reader.ReadToEnd();
                    }
                }
                return responseBodyFromRemoteServer == "AUTHORIZED";
            }
            catch
            {
                return false;
            }
        }


        public bool checkMDM(string sn)
        {
            try
            {
                string requestUrl = APIBaseURL + sn + "&service=4";
                HttpWebRequest request = HttpWebRequest.CreateHttp(requestUrl);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.Timeout = -1;
                string responseBodyFromRemoteServer;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseBodyFromRemoteServer = reader.ReadToEnd();
                    }
                }
                return responseBodyFromRemoteServer == "AUTHORIZED";
            }
            catch
            {
                return false;
            }
        }

       

    }
}
