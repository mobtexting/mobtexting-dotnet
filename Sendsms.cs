using System;
using System.IO;
using System.Net;

namespace MobtextingDotnet
{
    public class Sendsms
    {
        private string token;
        public Sendsms(string ACCESS_TOKEN)
        {
            token = ACCESS_TOKEN; 
        }
        public void sendsms(string to, string from, string body, char service)
        {
            string strurl = String.Format("https://portal.mobtexting.com/api/v2/sms/send");
            
            WebRequest requestObjPost = WebRequest.Create(strurl);
            requestObjPost.Method="POST";
            requestObjPost.ContentType = "application/json";

            string postData = "{\"access_token\":  \""+ token + "\" , \"message\": \"" + body + "\" ,\"sender\" : \"" + from + " \" , \"to\" : \"" + to + "\"  , \"service\" : \"" + service + "\"} ";
            using (var streamWriter = new StreamWriter(requestObjPost.GetRequestStream()))
            {
                streamWriter.Write(postData);
                streamWriter.Flush();
                streamWriter.Close();
                var httpResponse = (HttpWebResponse)requestObjPost.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result2= streamReader.ReadToEnd();
                    Console.WriteLine(result2);
                }

            }
        }
    }
}