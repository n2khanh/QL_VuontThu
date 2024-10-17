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
    public partial class Cage_Details : Form
    {
        public Cage_Details()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Animal_Details animal_Details = new Animal_Details();
             animal_Details.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Animal_Details animal_Details = new Animal_Details();
            animal_Details.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Animal_Details animal_Details = new Animal_Details();
            animal_Details.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal_Details animal_Details = new Animal_Details();
            animal_Details.ShowDialog();
        }
    }
}
