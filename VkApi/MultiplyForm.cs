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
    public partial class MultiplyForm : Form
    {
        public MultiplyForm()
        {
            InitializeComponent();
        }

        private void paintBtn_Click(object sender, EventArgs e)
        {
            if (DataHolder.fullGraph != null)
                Painter.paintFullGraphToFile(DataHolder.fullGraph, multBar.Value);
        }

        private void MultiplyForm_Load(object sender, EventArgs e)
        {
            Height = PreferredSize.Height + 3;
            Width = PreferredSize.Width + 3;
            multValueLbl.Text = multBar.Value.ToString();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void multBar_ValueChanged(object sender, EventArgs e)
        {
            multValueLbl.Text = multBar.Value.ToString();
        }
    }
}
