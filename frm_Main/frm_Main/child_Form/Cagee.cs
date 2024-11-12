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
    public partial class Cagee : Form
    {
        ProcessDataBase processData;
        public Cagee()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //processData = new ProcessDataBase();
            //processData.CapNhatDuLieu("Update ChiTietSp  set  [Mã SP] = '" + textBox3.Text + "', [Tên SP] =N'" + textBox4.Text + "', [Ngày SX] ='" + dateTimePicker1.Value.ToString() + "',[Ngày HH] ='" + dateTimePicker2.Value.ToString() + "',[Đơn vị] = N'" + textBox5.Text + "',[Đơn Giá] = " + int.Parse(textBox6.Text.ToString()) + ",[Ghi chú] =N'" + richTextBox1.Text + "'");
            //dt = processData.DocBang("Select * from ChiTietSP");
            //dataGridView1.DataSource = dt;
            groupBox2.Enabled = true;
            button3.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
            label7.Text = "Đang thêm dữ liệu";
            label7.ForeColor = System.Drawing.Color.Green;
            textBox3.Text = "";
           comboBox2.Text = "";
            comboBox1.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            richTextBox1.Text = "";
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            processData = new ProcessDataBase();
            if (textBox1.Text == "" && textBox2.Text == "") { dt = processData.DocBang("select * from Chuong "); dataGridView1.DataSource = dt; }
            else if (textBox1.Text != "" && textBox2.Text == "")
            {
                dt = processData.DocBang("Select * from Chuong where [Mã chuồng] = '" + textBox1.Text + "'");
            }
            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                dt = processData.DocBang("Select * from Chuong where [Mã chuồng] = '" + textBox1.Text + "' and [Mã nhân viên] = N'" + textBox2.Text + "'");
            }
            else dt = processData.DocBang("Select * from Chuong where [Mã nhân viên] = '" + textBox2.Text + "'");
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (label7.Text == "Đang thêm dữ liệu")
            {
                if (textBox3 != null && comboBox2.Text != null && comboBox1.Text !=null && numericUpDown1.Value > 0 && numericUpDown2.Value <= numericUpDown1.Value  )
                {
                    DataTable dt = new DataTable();
                    processData = new ProcessDataBase();
                    try
                    {
                        processData.CapNhatDuLieu("insert into Chuong ([Mã chuồng] , [Mã nhân viên] , [Mã khu] , [Mức chứa] , [Số lượng thú] ,[Ghi chú]) values('" + textBox3.Text + "','" + comboBox2.SelectedValue + "','" + comboBox1.SelectedValue + "'," + numericUpDown1.Value + "," + numericUpDown2.Value + ",'" + richTextBox1.Text + "') ");
                        dt = processData.DocBang("Select * from Chuong");
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
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                   
                    richTextBox1.Text = "";
                   

                }
                else MessageBox.Show("Bạn cần nhập đầy đủ thông tin hợp lệ ! ");
            }
            else if (label7.Text == "Đang Xóa")
            {
                DataTable dt = new DataTable();
                processData = new ProcessDataBase();
                try
                {
                    processData.CapNhatDuLieu("Delete from Chuong where [Mã chuồng] = '" + textBox3.Text + "'");
                    dt = processData.DocBang("Select * from Chuong");
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
                    comboBox2.Text = "";
                    comboBox1.Text = "";

                    richTextBox1.Text = "";
                }
                catch (Exception ex) {
                    MessageBox.Show("Chuồng phải được làm chống trước khi xóa !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
               
            }
            else if (label7.Text == "Đang sửa")
            {
                DataTable dt = new DataTable();
                processData = new ProcessDataBase();
                processData.CapNhatDuLieu("UPDATE Chuong SET  [Mã nhân viên] = N'" + comboBox2.SelectedValue + "', [Mã khu] = '" + comboBox1.SelectedValue + "', [Mức chứa] = " + numericUpDown1.Value + ",[Ghi chú] = N'" + richTextBox1.Text + "' where [Mã chuồng] = '" + textBox3.Text + "'" );
                dt = processData.DocBang("Select * from Chuong");
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
                comboBox2.Text = "";
                comboBox1.Text = "";

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
            comboBox2.Text = "";
            comboBox1.Text = "";

            richTextBox1.Text = "";

            textBox3.Enabled = true;
            comboBox2.Enabled = true;
            comboBox1.Enabled = true;
            numericUpDown1.Enabled = true;
            

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
                textBox3.Text = dataGridViewRow.Cells["Mã chuồng"].Value.ToString();
                comboBox2.SelectedValue = dataGridViewRow.Cells["Mã nhân viên"].Value.ToString();
                comboBox1.SelectedValue = dataGridViewRow.Cells["Mã khu"].Value.ToString();
                numericUpDown1.Value = int.Parse(dataGridViewRow.Cells["Mức chứa"].Value.ToString());
                numericUpDown2.Value = int.Parse(dataGridViewRow.Cells["Số lượng thú"].Value.ToString());
                richTextBox1.Text = dataGridViewRow.Cells["Ghi chú"].Value.ToString();
                groupBox2.Enabled = true;
                textBox3.Enabled = false;
                comboBox2.Enabled = false;
                comboBox1.Enabled = false;
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
               
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
                textBox3.Text = dataGridViewRow.Cells["Mã chuồng"].Value.ToString();
                comboBox2.SelectedValue = dataGridViewRow.Cells["Mã nhân viên"].Value.ToString();
                comboBox1.SelectedValue = dataGridViewRow.Cells["Mã khu"].Value.ToString();
                numericUpDown1.Value = int.Parse(dataGridViewRow.Cells["Mức chứa"].Value.ToString());
                numericUpDown2.Value = int.Parse(dataGridViewRow.Cells["Số lượng thú"].Value.ToString());
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

        private void Cagee_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            processData = new ProcessDataBase();
            dt = processData.DocBang("Select * from Chuong");
            dataGridView1.DataSource = dt;
            groupBox2.Enabled = false;
            dt = processData.DocBang("Select [Mã khu] , [Tên khu] from Khu");
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Tên khu";
            comboBox1.ValueMember = "Mã khu";
            dt = processData.DocBang("Select [Mã nhân viên] , [Tên nhân viên] from NhanVien ");
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Tên nhân viên";
            comboBox2.ValueMember = "Mã nhân viên";

        }
    }
}
