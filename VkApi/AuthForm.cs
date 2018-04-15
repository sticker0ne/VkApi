using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VkApi
{
    public partial class AuthForm : Form
    {
        private const string oauthUrl = "https://oauth.vk.com/authorize?client_id=6233819&display=page&redirect_uri=https://oauth.vk.com/blank.html/callback&scope=friends&response_type=token&v=5.73&state=123456";
        private apiWorker api;

        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            authBrowser.Navigate(oauthUrl);
        }

        private void authBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if(authBrowser.Url.ToString().Contains("access"))
            {
                string accessToken = authBrowser.Url.ToString().Split('=')[1];
                accessToken = accessToken.Split('&')[0];
                runApi(accessToken);
            }

            Width = authBrowser.Document.Body.ScrollRectangle.Size.Width + 25;
            Height = authBrowser.Document.Body.ScrollRectangle.Size.Height + 40;
        }

        private void runApi(string accessToken)
        {
            api = new apiWorker(accessToken);
            DataHolder.api = api;
            SaveJsonForm sf = new SaveJsonForm();
            this.Hide();
            sf.ShowDialog();
            DialogResult = sf.DialogResult;
            
            sf.FormClosed += (t, y) => { this.Close(); };
        }
    }
}
