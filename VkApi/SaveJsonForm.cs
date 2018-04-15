using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace VkApi
{
    public delegate void UpdateControl(int i, int j, bool block = false);
    public delegate void DownloadSource(int count, string filePath, UpdateControl upCon = null);

    public partial class SaveJsonForm : Form
    {
        private apiWorker api;

        public SaveJsonForm()
        {
            InitializeComponent();
        }

        private void SaveJsonForm_Load(object sender, EventArgs e)
        {
            api = DataHolder.api;
            JObject user = api.getUserInfo();

            frCountTrackBar.Maximum = api.FriendsCount;

            if (user["response"] != null)
            {
                helloLabel.Text = "Здравствуйте " + user["response"][0]["first_name"].ToObject<string>() +
                    ",\n у Вас " + frCountTrackBar.Maximum.ToString() + " друзей\n в социальной сети";

                userLabel.Text = user["response"][0]["first_name"].ToObject<string>() + " " +
                    user["response"][0]["last_name"].ToObject<string>();
            }

            mainPhotoPictureBox.ImageLocation = user["response"][0]["photo_200"].ToObject<string>();
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(mainPhotoPictureBox.DisplayRectangle);
            mainPhotoPictureBox.Region = new Region(gp);

            Width = PreferredSize.Width + 3;
            Height = PreferredSize.Height + 3;

        }

        private void frCountTrackBar_Scroll(object sender, EventArgs e)
        {
            frCntLabel.Text = frCountTrackBar.Value.ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (jsonSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                api.getFriendsToFile(frCountTrackBar.Value, jsonSaveFileDialog.FileName,
                    new UpdateControl(progBarUpdate));
            }

            DataHolder.jsonFilePath = jsonSaveFileDialog.FileName;
            DialogResult = DialogResult.OK;
        }

        private void progBarUpdate(int i, int j, bool block = false)
        {
            if (block)
            {
                saveBtn.Enabled = false;
                frCountTrackBar.Enabled = false;
                frCntLabel.Enabled = false;
            }
            progressBar.Maximum = j;
            progressBar.Value = i;
            progressBar.Refresh();

            if (i == j)
            {
                MessageBox.Show("Downloads complete", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                saveBtn.Enabled = true;
                frCountTrackBar.Enabled = true;
                frCntLabel.Enabled = true;

                progBarUpdate(0, j);
            }
        }
    }
}
