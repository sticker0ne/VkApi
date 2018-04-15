using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace VkApi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void fileCreateBtn_Click(object sender, EventArgs e)
        {
            AuthForm af = new AuthForm();
            af.ShowDialog();

            if (af.DialogResult == DialogResult.OK)
            {
                string name = DataHolder.jsonFilePath;
                if (name != null)
                {
                    name = name.Remove(0, name.LastIndexOf('\\') + 1);
                    fileNameLbl.Text = name;
                }
            }
        }

        private void fileOpenBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataHolder.jsonFilePath = openFileDialog.FileName;
                fileNameLbl.Text = openFileDialog.SafeFileName;
            }
        }

        private void fullGraphBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(DataHolder.jsonFilePath))
            {
                List<Friend> friends = apiWorker.getFriendsFromJsonFile(DataHolder.jsonFilePath);

                DataHolder.friends = friends;

                GraphBuilder.clear();
                GraphBuilder.buildFullGraph(DataHolder.friends);
                GraphBuilder.buildMinimalTreeKruskal();

                NormalGraph ng = GraphBuilder.getNormalGraph();
                DataHolder.fullGraph = ng;

                MultiplyForm mf = new MultiplyForm();
                mf.ShowDialog();
            }
        }

        private void splittedGraphBtn_Click(object sender, EventArgs e)
        {
            SplitCountForm spf = new SplitCountForm();
            spf.ShowDialog();
        }

        private void kmBtn_Click(object sender, EventArgs e)
        {
            KMeansForm kmf = new KMeansForm();
            kmf.ShowDialog();
        }

        private void apBtn_Click(object sender, EventArgs e)
        {
            var apf = new AffinityPropagationForm();
            apf.ShowDialog();
            
        }
    }
}
