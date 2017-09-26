using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProg
{
    public partial class MainForm : Form
    {

        int count = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Первые программы");

        }

        private void bLCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Роман BL@CK Соболев");
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = Convert.ToString(count);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count--;
            label1.Text = Convert.ToString(count);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            count = 0;
            label1.Text = Convert.ToString(count);

        }
    }
}
