using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VkApi
{
    public partial class AffinityPropagationForm : Form
    {
        public AffinityPropagationForm()
        {
            InitializeComponent();
        }

        private void clusterBar_ValueChanged(object sender, EventArgs e)
        {
            var val = clusterBar.Value;
            clusterLbl.Text = (val / 100.0).ToString("0.00");
        }

        private void iterationBar_ValueChanged(object sender, EventArgs e)
        {
            var val = iterationBar.Value;
            iterationLbl.Text = String.Format("{0} 000", val);
        }

        private void paintBtn_Click(object sender, EventArgs e)
        {
            AffinityPropagation.Mark(DataHolder.fullGraph.nodes, 
                iterationBar.Value * 1000, clusterBar.Value / 100.0);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AffinityPropagationForm_Load(object sender, EventArgs e)
        {
            Width = PreferredSize.Width + 3;
            Height = PreferredSize.Height + 3;
            if (DataHolder.fullGraph == null)
                Close();
        }
    }
}
