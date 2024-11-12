using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frm_Main.child_Form
{
    public partial class Area : Form
    {
        ProcessDataBase processData;
        public Area()
        {
            InitializeComponent();
        }

        private void Area_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            processData = new ProcessDataBase();
            dt = processData.DocBang("Select * from Khu");
            dataGridView1.DataSource = dt;
            groupBox2.Enabled = false;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            button3.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
            label7.Text = "Đang thêm dữ liệu";
            label7.ForeColor = System.Drawing.Color.Green;
            textBox3.Text = "";
            textBox4.Text = "";
            richTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            processData = new ProcessDataBase();
            if (textBox1.Text == "" && textBox2.Text == "") { dt = processData.DocBang("select * from Khu"); dataGridView1.DataSource = dt; }
            else if (textBox1.Text != "" && textBox2.Text == "")
            {
                dt = processData.DocBang("Select * from Khu where [Mã khu] = '" + textBox1.Text + "'");
            }
            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                dt = processData.DocBang("Select * from Khu where [Mã khu] = '" + textBox1.Text + "' and [Tên khu] = N'" + textBox2.Text + "'");
            }
            else dt = processData.DocBang("Select * from Khu where [Tên khu] = '" + textBox2.Text + "'");
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (label7.Text == "Đang thêm dữ liệu")
            {
                if (textBox3 != null && textBox4 != null )
                {
                    DataTable dt = new DataTable();
                    processData = new ProcessDataBase();
                    try
                    {
                        processData.CapNhatDuLieu("insert into Khu ([Mã khu] , [Tên khu] ) values('" + textBox3.Text + "','" + textBox4.Text  + "') ");
                        dt = processData.DocBang("Select * from Khu");
                        dataGridView1.DataSource = dt;
                        MessageBox.Show("Đã Thêm Thành Công", "Thông Báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mã sp đã tồn tại");
                        textBox3.Focus();
                    }
                    label7.Text = "Bình thường";
                    label7.ForeColor = System.Drawing.Color.Black;
                    button3.Enabled = true;
                    button1.Enabled = true;
                    button4.Enabled = true;
                    groupBox2.Enabled = false;
                    textBox3.Text = "";
                    textBox4.Text = "";

                    richTextBox1.Text = "";

                }
                else MessageBox.Show("Bạn cần nhập đầy đủ thông tin hợp lệ ! ");
            }
            else if (label7.Text == "Đang xóa")
            {
                DataTable dt = new DataTable();
                processData = new ProcessDataBase();
                processData.CapNhatDuLieu("Delete from Khu where [Mã khu] = '" + textBox3.Text + "'");
                dt = processData.DocBang("Select * from Khu");
                dataGridView1.DataSource = dt;
                MessageBox.Show("Xóa thành công !", "Thông Báo");
                label7.Text = "Bình thường";
                label7.ForeColor = System.Drawing.Color.Black;
                button3.Enabled = true;
                button1.Enabled = true;
                button4.Enabled = true;
                button2.Enabled = true;
                groupBox2.Enabled = false;
                textBox3.Text = "";
                textBox4.Text = "";
                richTextBox1.Text = "";

            }
            else if (label7.Text == "Đang sửa")
            {
                DataTable dt = new DataTable();
                processData = new ProcessDataBase();
                processData.CapNhatDuLieu("UPDATE Khu SET  [Tên khu] = N'" + textBox4.Text + "',[Ghi chú] = N'"+richTextBox1.Text+"' where [Mã khu] == '"+textBox3.Text+"'");
                dt = processData.DocBang("Select * from Khu");
                dataGridView1.DataSource = dt;
                MessageBox.Show("Sửa thành công !", "Thông Báo");
                label7.Text = "Bình thường";
                label7.ForeColor = System.Drawing.Color.Black;
                button3.Enabled = true;
                button1.Enabled = true;
                button4.Enabled = true;
                button2.Enabled = true;
                groupBox2.Enabled = false;
                textBox3.Text = "";
                textBox4.Text = "";

                richTextBox1.Text = "";

                textBox3.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label7.Text = "Bình thường";
            label7.ForeColor = System.Drawing.Color.Black;
            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
            button4.Enabled = true;
            groupBox2.Enabled = false;
            textBox3.Text = "";
            textBox4.Text = "";
            richTextBox1.Text = "";
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            richTextBox1.Enabled = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
                textBox3.Text = dataGridViewRow.Cells["Mã khu"].Value.ToString();
                textBox4.Text = dataGridViewRow.Cells["Tên khu"].Value.ToString();
                richTextBox1.Text = dataGridViewRow.Cells["Ghi chú"].Value.ToString();
                groupBox2.Enabled = true;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                richTextBox1.Enabled = false;
                label7.Text = "Đang Xóa";
                label7.ForeColor = System.Drawing.Color.Red;
                button2.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = false;
            }
            else MessageBox.Show("Vui lòng chọn để xóa !", "Thông Báo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                groupBox2.Enabled = true;
                DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
                textBox3.Text = dataGridViewRow.Cells["Mã khu"].Value.ToString();
                textBox4.Text = dataGridViewRow.Cells["Tên khu"].Value.ToString();
                richTextBox1.Text = dataGridViewRow.Cells["Ghi chú"].Value.ToString();
                label7.Text = "Đang sửa";
                label7.ForeColor = System.Drawing.Color.Orange;
                button2.Enabled = false;
                button1.Enabled = false;
                button4.Enabled = false;
                textBox3.Enabled = false;
            }
            else MessageBox.Show("Vui lòng chọn để sửa !", "Thông Báo");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
