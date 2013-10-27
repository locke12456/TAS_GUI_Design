using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void testCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "New TestCase";
            saveFileDialog1.Filter = "test case (*.tsc)|All(*.*)";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
        }
    }
}
