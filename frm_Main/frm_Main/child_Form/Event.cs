using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frm_Main.child_Form
{
    public partial class Event : Form
    {
        ProcessDataBase processData;

        public Event()
        {
            InitializeComponent();
        }

        private void Event_Load(object sender, EventArgs e)
        {
            processData = new ProcessDataBase();
            DataTable dt = new DataTable();
            dt = processData.DocBang("Select [Mã thú] , [Tên sự kiện] ,[Ngày bắt đầu] , [Ngày kết thúc] ,[Lý do],[Cách khắc phục] , [Ghi chú] from Thu_SuKien join SuKien on Thu_SuKien.[Mã sự kiện] = SuKien.[Mã sự kiện] ");
            dataGridView1.DataSource = dt;
            dt = processData.DocBang("Select [Mã thú] from Thu ");
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Mã thú";
            dt = processData.DocBang("Select [Mã sự kiện] , [Tên sự kiện] from SuKien ");
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Tên sự kiện";
            comboBox2.ValueMember = "Mã sự kiện";
            groupBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            processData = new ProcessDataBase();
            if (textBox1.Text == "" && textBox2.Text == "") { dt = processData.DocBang("Select [Mã thú] , [Tên sự kiện] , [Ghi chú] from Thu_SuKien join SuKien on Thu_SuKien.[Mã sự kiện] = SuKien.[Mã sự kiện] "); dataGridView1.DataSource = dt; }
            else if (textBox1.Text != "" && textBox2.Text == "")
            {
                dt = processData.DocBang("Select [Mã thú] , [Tên sự kiện] , [Ghi chú] from Thu_SuKien join SuKien on Thu_SuKien.[Mã sự kiện] = SuKien.[Mã sự kiện] where [Mã thú] = '" + textBox1.Text + "'");
            }
            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                dt = processData.DocBang("Select [Mã thú] , [Tên sự kiện] , [Ghi chú] from Thu_SuKien join SuKien on Thu_SuKien.[Mã sự kiện] = SuKien.[Mã sự kiện] where [Mã thú] = '" + textBox1.Text + "' and [Tên sự kiện] = N'" + textBox2.Text + "'");
            }
            else dt = processData.DocBang("Select [Mã thú] , [Tên sự kiện] , [Ghi chú] from Thu_SuKien join SuKien on Thu_SuKien.[Mã sự kiện] = SuKien.[Mã sự kiện] where [Tên sự kiện] = '" + textBox2.Text + "'");
            dataGridView1.DataSource = dt;
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
            textBox4.Text = "";
            richTextBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            comboBox1.Enabled = true;

        }
        private void button6_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (label7.Text == "Đang thêm dữ liệu")
            {
                if (comboBox1.Text != null && comboBox2.Text != null) 
                {
                    DataTable dt = new DataTable();
                    processData = new ProcessDataBase();
                   
                    
                        processData.CapNhatDuLieu("insert into Thu_SuKien ([Mã thú] , [Mã sự kiện]  , [Ngày bắt đầu] , [Ngày kết thúc] ,[Lý do],[Cách khắc phục],[Ghi chú]) values('" + comboBox1.Text + "','" + comboBox2.SelectedValue + "','" + dateTimePicker1.Value.ToString() + "','" + dateTimePicker2.Value.ToString() + "','" + textBox3.Text + "','" + textBox4.Text + "','" + richTextBox1.Text + "')");
                        dt = processData.DocBang("Select [Mã thú] , [Tên sự kiện] ,[Ngày bắt đầu] , [Ngày kết thúc] ,[Lý do],[Cách khắc phục] , [Ghi chú] from Thu_SuKien join SuKien on Thu_SuKien.[Mã sự kiện] = SuKien.[Mã sự kiện] ");
                        dataGridView1.DataSource = dt;
                        MessageBox.Show("Đã Thêm Thành Công", "Thông Báo");
                    
                    
                    
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


                } else MessageBox.Show("Bạn cần nhập đầy đủ thông tin hợp lệ ! ");

            }
            else if (label7.Text == "Đang Xóa")
            {
                DataTable dt = new DataTable();
                processData = new ProcessDataBase();
               
                
                    processData.CapNhatDuLieu("Delete from Thu_SuKien where [Mã thú] = '" + comboBox1.Text + "'");
                    dt = processData.DocBang("Select [Mã thú] , [Tên sự kiện] ,[Ngày bắt đầu] , [Ngày kết thúc] ,[Lý do],[Cách khắc phục] , [Ghi chú] from Thu_SuKien join SuKien on Thu_SuKien.[Mã sự kiện] = SuKien.[Mã sự kiện] ");
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
                    textBox4.Text = "";
                    textBox3.Enabled = true;
                    comboBox2.Enabled = true;
                    comboBox1.Enabled = true;
                    textBox4.Enabled = true;
                    dateTimePicker2.Enabled = true;
                    dateTimePicker1.Enabled = true;

                richTextBox1.Enabled = true;

                richTextBox1.Text = "";
                
               

            }
            else if (label7.Text == "Đang sửa")
            {
                
                DataTable dt = new DataTable();
                processData = new ProcessDataBase();
                processData.CapNhatDuLieu("UPDATE Thu_SuKien SET  [Mã sự kiện] = '" + comboBox2.SelectedValue + "', [Ngày bắt đầu] = '" +dateTimePicker1.Value.ToString() + "', [Ngày kết thúc] = '" + dateTimePicker2.Value.ToString() + "',[Lý do] ='"+textBox3.Text+"',[Cách khắc phục] ='"+textBox4.Text+"' ,[Ghi chú] = N'" + richTextBox1.Text + "' where [Mã thú] = '" + comboBox1.Text + "'");
                dt = processData.DocBang("Select [Mã thú] , [Tên sự kiện] ,[Ngày bắt đầu] , [Ngày kết thúc] ,[Lý do],[Cách khắc phục] , [Ghi chú] from Thu_SuKien join SuKien on Thu_SuKien.[Mã sự kiện] = SuKien.[Mã sự kiện] ");
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
            textBox4.Enabled = true;


            richTextBox1.Enabled = true;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
                textBox3.Text = dataGridViewRow.Cells["Lý do"].Value.ToString();
                comboBox2.Text = dataGridViewRow.Cells["Tên sự kiện"].Value.ToString();
                comboBox1.Text = dataGridViewRow.Cells["Mã thú"].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dataGridViewRow.Cells["Ngày bắt đầu"].Value.ToString());
                dateTimePicker2.Value = DateTime.Parse(dataGridViewRow.Cells["Ngày kết thúc"].Value.ToString());
                richTextBox1.Text = dataGridViewRow.Cells["Ghi chú"].Value.ToString();
                textBox4.Text = dataGridViewRow.Cells["Cách khắc phục"].Value.ToString();
                groupBox2.Enabled = true;
                textBox3.Enabled = false;
                comboBox2.Enabled = false;
                comboBox1.Enabled = false;
                richTextBox1.Enabled = false;
                label7.Text = "Đang Xóa";
                label7.ForeColor = System.Drawing.Color.Red;
                button2.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = false;
                textBox4.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;

            }
            else MessageBox.Show("Vui lòng chọn để xóa !", "Thông Báo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
                textBox3.Text = dataGridViewRow.Cells["Lý do"].Value.ToString();
                comboBox2.Text = dataGridViewRow.Cells["Tên sự kiện"].Value.ToString();
                comboBox1.Text = dataGridViewRow.Cells["Mã thú"].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dataGridViewRow.Cells["Ngày bắt đầu"].Value.ToString());
                dateTimePicker2.Value = DateTime.Parse(dataGridViewRow.Cells["Ngày kết thúc"].Value.ToString());
                richTextBox1.Text = dataGridViewRow.Cells["Ghi chú"].Value.ToString();
                textBox4.Text = dataGridViewRow.Cells["Cách khắc phục"].Value.ToString();
                groupBox2.Enabled = true;
                label7.Text = "Đang sửa";
                label7.ForeColor = System.Drawing.Color.Orange;
                button2.Enabled = false;
                button1.Enabled = false;
                button4.Enabled = false;
                comboBox1.Enabled = false;
            }
            else MessageBox.Show("Vui lòng chọn để sửa !");
        }
    }
}
