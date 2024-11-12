using frm_Main.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_Main.child_Form
{
    public partial class List_Animal : Form
    {
        ProcessDataBase processData;
        AnimalModel animal;
        public List_Animal()
        {
            InitializeComponent();
        }

        private void List_Animal_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            processData = new ProcessDataBase();
            dt = processData.DocBang("Select* from Thu");
            dataGridView1.DataSource = dt;
            label2.Text = dataGridView1.RowCount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            processData = new ProcessDataBase();
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text =="") { dt = processData.DocBang("select * from Thu "); dataGridView1.DataSource = dt; }
            else if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text=="")
            {
                dt = processData.DocBang("Select * from Thu where [Mã thú] = '" + textBox1.Text + "'");
            }
            else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text == "")
            {
                dt = processData.DocBang("Select * from Thu where [Tên thú] = '"+textBox2.Text );
            }
            else if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != "")
                dt = processData.DocBang("Select * from Thu where [Mã chuồng] = '" + textBox3.Text + "'"); 
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text == "")
                dt = processData.DocBang("Select * from Thu where [Mã thú] = '"+textBox1.Text+ "' and [Tên thú] = '"+textBox2.Text+"'" );
            else if (textBox1.Text == "" && textBox2.Text != "" && textBox3.Text != "")
                dt = processData.DocBang("Select * from Thu where [Mã chuồng] = '" + textBox3.Text + "' and [Tên thú] = '" + textBox2.Text + "'");
            else if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text != "")
                dt = processData.DocBang("Select * from Thu where [Mã thú] = '" + textBox1.Text + "' and [Mã chuồng] = '" + textBox3.Text + "'");
            else dt = processData.DocBang("Select * from Thu where [Mã thú] = '" + textBox1.Text + "' and [Mã chuồng] = '" + textBox3.Text + "' and [Tên thú] ='"+textBox2.Text+"'");
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                button1.Enabled = true;
                pictureBox1.ImageLocation = row.Cells[12].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            animal = new AnimalModel();
            animal.MaThu = row.Cells[0].Value.ToString();
            animal.TenThu = row.Cells[1].Value.ToString();
            animal.Loai = row.Cells[2].Value.ToString();
            if (row.Cells[3].Value.ToString() == "Không") animal.Sd = false;
            else animal.Sd = true;
            animal.TenKH = row.Cells[4].Value.ToString();
            animal.Kieusinh = row.Cells[5].Value.ToString();
            animal.NgayVao = DateTime.Parse( row.Cells[6].Value.ToString());
            animal.Nguongoc = row.Cells[7].Value.ToString();
            animal.Dacdiem = row.Cells[8].Value.ToString();
            animal.NgaySinh = DateTime.Parse(row.Cells[9].Value.ToString());
            animal.Hinhanh = row.Cells[10].Value.ToString();
            animal.Tuoi = int.Parse(row.Cells[11].Value.ToString());
            animal.Slcai = int.Parse(row.Cells[12].Value.ToString());
            animal.Slduc = int.Parse(row.Cells[13].Value.ToString());
            animal.Machuong = row.Cells[14].Value.ToString();
            AnimalDetails animalDetails = new AnimalDetails();
            animalDetails.LoadAnimal(animal);
           animalDetails.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            processData = new ProcessDataBase();
            dt = processData.DocBang("Select* from Thu");
            dataGridView1.DataSource = dt;
            label2.Text = dataGridView1.RowCount.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Animal add_Animal = new Add_Animal();
            add_Animal.ShowDialog();
        } 
    }
}
