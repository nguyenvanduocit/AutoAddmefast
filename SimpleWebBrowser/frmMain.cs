using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace SimpleWebBrowser
{
    public partial class frmMain : Form
    {

        private enum STEP { INT, LOGIN, GETLIST, CHECKLIKEBEFORE, OPENLINK, CHECKAFTER, GETPOINT, CONFIRM, LINKOPENED, UPDATEACTION, ACTIONUPDATED, GETPOINTED, CONFIRMED };
        private STEP preStep;

        private string _openLinkUrl;
        private string _Id;
        private string _linkID;
        private string _url;
        private string _network;
        private string _code;
        private string _Cpc;
        private string _Title;

        public frmMain()
        {
            InitializeComponent();
            preStep = STEP.INT;
        }

        #region facebook
        private void wbFacebook_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            prsFacebook.Maximum = (int)e.MaximumProgress;
            prsFacebook.Value = (int)e.CurrentProgress;
        }

        private void btnLoginFacebook_Click(object sender, EventArgs e)
        {
            string postData = String.Format("email={0}&pass={1}", "muatocroiatmail1@gmail.com", "fathertime");
            PostData(wbFacebook, "https://m.facebook.com/login.php?login_attempt=1", postData);
        }
        #endregion

        #region addmefast

        private void btnLoginAddmefast_Click(object sender, EventArgs e)
        {
            preStep = STEP.LOGIN;
            string postData = "act=login&params={\"email\": \"phoenixsinh@gmail.com\", \"ps\": \"fathertime\", \"rem\":\"1\"}";
            PostData(wbAddmefast, "http://addmefast.com/includes/ajax.php", postData);
        }
        private void btnGetLinkList_Click(object sender, EventArgs e)
        {
            preStep = STEP.GETLIST;
            string network = "25";
            string postData = "act=getLinksList&params={\"network\":\"" + network + "\", \"page\":\"1\"}";
            PostData(wbAddmefast, "http://addmefast.com/includes/ajax.php", postData);
        }
        private void btnOpenLink_Click(object sender, EventArgs e)
        {
            preStep = STEP.OPENLINK;
            wbAddmefast.Navigate("http://addmefast.com" + _openLinkUrl);
        }
        private void btnGetPoint_Click(object sender, EventArgs e)
        {
            preStep = STEP.GETPOINT;
            string postData = "act=upc";
            PostData(wbAddmefast, "http://addmefast.com/includes/ajax.php", postData);
        }
        private void btnCheckBef_Click(object sender, EventArgs e)
        {
            preStep = STEP.OPENLINK;
            string html = wbAddmefast.DocumentText;
            Match match = Regex.Match(html, @"confirmSingleFB\((.*?)\);", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                string parms = match.Groups[1].Value;
                string[] parmArr = parms.Split(',');
                _Id = parmArr[0];
                _url = Uri.EscapeUriString(parmArr[1].Split('"')[1]);
                _linkID = parmArr[2].Split('"')[1];
                _network = parmArr[3].Split('"')[1];
                _code = Uri.UnescapeDataString(parmArr[5].Split('"')[1]);
                _Cpc = parmArr[6].Split('"')[1];
                _Title = parmArr[7].Split('"')[1];
                getFBLikesBef(_Id, _url, _network);
            }
            else
            {
                MessageBox.Show("Not match getFBLikesBef");
            }

            match = Regex.Match(html, @"open\('(.*?)'\);", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                string[] parmArr = match.Groups[1].Value.Split(',');
                _openLinkUrl = parmArr[0].Substring(0, parmArr[0].Length - 1);
            }
            else
            {
                MessageBox.Show("Not match Open popup");
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            confirmSingleFB(_Id, _url, _network);
        }
        private void btnUpdateAction_Click(object sender, EventArgs e)
        {
            updateAction(_linkID, _url, _network, _code);
        }
        private void wbAddmefast_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            prsAddmefast.Maximum = (int)e.MaximumProgress;
            prsAddmefast.Value = (int)e.CurrentProgress;
        }
        private void getFBLikesBef(string id, string url, string network)
        {
            preStep = STEP.CHECKLIKEBEFORE;
             string postData = "act=getFBLikesDataBefore&params={\"id\":\""+id+"\", \"url\":\""+url+"\", \"network\":\""+network+"\"}";
             PostData(wbAddmefast, "http://addmefast.com/includes/ajax.php", postData);
        }
        private void updateAction(string linkid, string url, string network, string code)
        {
            preStep = STEP.UPDATEACTION;
            string postData = "act=updateAction&params={\"link_id\":\"" + linkid + "\", \"url\":\"" + url + "\", \"network\":\"" + network + "\", \"IXY5pZpE\":\"" + code + "\"}";
            System.Console.WriteLine(postData);
            PostData(wbAddmefast, "http://addmefast.com/includes/ajax.php", postData);
        }
        private void confirmSingleFB(string id, string url, string network)
        {
            preStep = STEP.CONFIRM;
            string postData = "act=checkFollowed&params={\"id\":\""+id+"\", \"url\":\""+url+"\", \"network\":\""+network+"\"}";
            PostData(wbAddmefast, "http://addmefast.com/includes/ajax.php", postData);
        }
        private void getLikeNote(string msg, string cpc, string link_title)
        {
            string postData = "act=getLikeNote&params={\"m\":\""+msg+"\", \"cpc\":\""+cpc+"\", \"title\":\""+link_title+"\"}";
            PostData(wbAddmefast, "http://addmefast.com/includes/ajax.php", postData);
        }
        private void wbAddmefast_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            switch (preStep)
            { 
                case STEP.INT:
                    break;
                case STEP.LOGIN:
                    break;
                case STEP.GETLIST:
                    btnOpenLink.PerformClick();
                    break;
                case STEP.OPENLINK:
                    preStep = STEP.LINKOPENED;
                    break;
                case STEP.LINKOPENED:
                    /*Thread.Sleep(10000);
                    HtmlElementCollection elc = this.wbAddmefast.Document.GetElementsByTagName("input");  
                    foreach (HtmlElement el in elc)  
                    {  
                       if (el.GetAttribute("type").Equals("submit"))  
                       {  
                            el.InvokeMember("Click");  
                       }  
                     }
                    Thread.Sleep(10000);
                    btnConfirm.PerformClick();
                     */
                    break;
                case STEP.GETPOINT:
                    break;
                case STEP.CONFIRM:
                    if (wbAddmefast.DocumentText == "1")
                    {
                        wbAddmefast.DocumentText = "Liked";
                    }
                    else 
                    {
                        wbAddmefast.DocumentText = "Not liked";
                    }
                    btnUpdateAction.PerformClick();
                    preStep = STEP.CONFIRMED;
                    break;
                case STEP.UPDATEACTION:
                    preStep = STEP.ACTIONUPDATED;
                    if (wbAddmefast.DocumentText == "0")
                    {
                        wbAddmefast.DocumentText = "Not get point";
                    }
                    else
                    {
                        btnGetPoint.Text = "Get point (" + wbAddmefast.DocumentText + ")";
                        getLikeNote("1",_Cpc, _Title);
                    }
                    break;
                case STEP.ACTIONUPDATED:
                    btnGetPoint.PerformClick();
                    preStep = STEP.GETPOINTED;
                    break;
                case STEP.GETPOINTED:
                    btnGetLinkList.PerformClick();
                    break;

            }
            rtbxAddmefast.Text = wbAddmefast.DocumentText;
        }
        #endregion
        /// <summary>
        /// Post data to server
        /// </summary>
        /// <param name="wb"></param>
        /// <param name="url"></param>
        /// <param name="postData"></param>

        private void PostData(WebBrowser wb,string url, string postData)
        {
            Thread.Sleep(2000);
            byte[] byteArray = Encoding.ASCII.GetBytes(postData);
            wb.Navigate(url, "", byteArray, "Content-Type: application/x-www-form-urlencoded");
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            wbFacebook.Navigate("https://m.facebook.com");
            wbAddmefast.Navigate("http://addmefast.com");
        }
    }
}
