using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace SimpleWebBrowser
{
    public class Addmefast
    {
        public CookieContainer cookieContainer;
        private const string AJAXURL = "http://addmefast.com/includes/ajax.php";
        public Addmefast()
        {
            cookieContainer = new CookieContainer();
            cookieContainer.Add(new CookieCollection());
        }
        public string Login()
        {
            string postData = "act=login&params={\"email\": \"phoenixsinh@gmail.com\", \"ps\": \"fathertime\", \"rem\":\"1\"}";
            string response = Post(postData);
            return response;
        }
        public string GetLinksList(string network)
        {
            string postData = "act=getLinksList&params={\"network\":\"" + network + "\", \"page\":\"1\"}";
            string response = Post(postData);
            return response;
        }
        private string Post(string postData)
        {
            HttpWebRequest getRequest = (HttpWebRequest)WebRequest.Create(AJAXURL);
            getRequest.CookieContainer = cookieContainer;
            getRequest.Method = WebRequestMethods.Http.Post;
            getRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
            getRequest.AllowWriteStreamBuffering = true;
            getRequest.ProtocolVersion = HttpVersion.Version11;
            getRequest.AllowAutoRedirect = true;
            getRequest.ContentType = "application/x-www-form-urlencoded";
            byte[] byteArray = Encoding.ASCII.GetBytes(postData);
            getRequest.ContentLength = byteArray.Length;
            Stream newStream = getRequest.GetRequestStream(); //open connection
            newStream.Write(byteArray, 0, byteArray.Length); // Send the data.
            newStream.Close();
            HttpWebResponse getResponse = (HttpWebResponse)getRequest.GetResponse();
            
            using (StreamReader sr = new StreamReader(getResponse.GetResponseStream()))
            {
                string sourceCode = sr.ReadToEnd();
                return sourceCode;
            }
        }
    }
}
