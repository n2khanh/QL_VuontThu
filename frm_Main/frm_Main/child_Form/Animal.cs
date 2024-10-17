using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_Main.child_Form
{
    public partial class Animal : Form
    {
        public Animal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Animal search_Animal = new Search_Animal();
            search_Animal.ShowDialog();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Animal add_Animal = new Add_Animal();
            add_Animal.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cage_Details cage_Details = new Cage_Details();
            cage_Details.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cage_Details cage_Details = new Cage_Details();
            cage_Details.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cage_Details cage_Details = new Cage_Details();
            cage_Details.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cage_Details cage_Details = new Cage_Details();
            cage_Details.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cage_Details cage_Details = new Cage_Details();
            cage_Details.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cage_Details cage_Details = new Cage_Details();
            cage_Details.ShowDialog();
        }
    }
}
