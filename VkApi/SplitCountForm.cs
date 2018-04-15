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
    public partial class SplitCountForm : Form
    {
        public SplitCountForm()
        {
            InitializeComponent();
        }

        private void SplitCountForm_Load(object sender, EventArgs e)
        {
            Width = PreferredSize.Width + 3;
            Height = PreferredSize.Height + 3;
            countBar.Minimum = 1;
            if (DataHolder.fullGraph != null)
                countBar.Maximum = DataHolder.fullGraph.nodes.Count;
            else
                Close();
            countLbl.Text = countBar.Value.ToString();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void paintBtn_Click(object sender, EventArgs e)
        {
            GraphBuilder.clear();
            GraphBuilder.buildFullGraph(DataHolder.friends);
            GraphBuilder.buildMinimalTreeKruskal();

            NormalGraph ng = GraphBuilder.getNormalGraph();
            DataHolder.fullGraph = ng;
  
            GraphBuilder.splitArray(countBar.Value);
            List<NormalGraph> lNg = GraphBuilder.getSplittedGraph();
            lNg = lNg.OrderByDescending(n => n.nodes.Count).ToList();
            DataHolder.splittedGraph = lNg;

            Painter.paintGraphsToFile(DataHolder.splittedGraph);
        }

        private void countBar_ValueChanged(object sender, EventArgs e)
        {
            countLbl.Text = countBar.Value.ToString();
        }
    }
}
