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
        ProcessDataBase _db;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cage_Details_Load(object sender, EventArgs e)
        {
            _db = new ProcessDataBase();
            DataTable dt = new DataTable();
            dt = _db.DocBang("select * from Thu join Thu_Chuong on Thu.[Mã thú] = Thu_Chuong.[Mã thú] where Loài = N'"+groupBox1.Text.Substring(7)+"'");
            dataGridView1.DataSource = dt;
            dt = new DataTable();
            dt = _db.DocBang("select * from Thu join Thu_Chuong on Thu.[Mã thú] = Thu_Chuong.[Mã thú] where Loài = N'" + groupBox2.Text.Substring(7) + "'");
            dataGridView2.DataSource = dt;
            dt = new DataTable();
            dt = _db.DocBang("select * from Thu join Thu_Chuong on Thu.[Mã thú] = Thu_Chuong.[Mã thú] where Loài = N'" + groupBox3.Text.Substring(7) + "'");
            dataGridView3.DataSource = dt;
            dt = new DataTable();
            dt = _db.DocBang("select * from Thu join Thu_Chuong on Thu.[Mã thú] = Thu_Chuong.[Mã thú] where Loài = N'" + groupBox4.Text.Substring(7) + "'");
            dataGridView4.DataSource = dt;
        }
    }
}
