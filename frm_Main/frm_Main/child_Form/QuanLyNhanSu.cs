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
    public partial class QuanLyNhanSu : Form
    {
        ProcessDataBase processData = new ProcessDataBase();
        public QuanLyNhanSu()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataTable dataTable = processData.DocBang("Select * from NhanVien");
            dataGridView1.DataSource = dataTable;
        }
        private void QuanLyNhanSu_Load_2(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nam");
            comboBox1.Items.Add("Nữ");
            comboBox1.Items.Add("Khác");
            LoadData();
            
        }
        private void QuanLyNhanSu_Load1(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox2.Text = "";
        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedItem = dataGridView1.SelectedRows[0];
                textBox1.Text = selectedItem.Cells[0].Value.ToString();
                textBox2.Text = selectedItem.Cells[1].Value.ToString();
                if (DateTime.TryParse(selectedItem.Cells[2].Value.ToString(), out DateTime date))
                {
                    dateTimePicker1.Value = date;
                }
                comboBox1.Text = selectedItem.Cells[3].Value.ToString();
                if (DateTime.TryParse(selectedItem.Cells[4].Value.ToString(), out DateTime date1))
                {
                    dateTimePicker2.Value = date1;
                }
                textBox4.Text = selectedItem.Cells[5].Value.ToString();
                textBox3.Text = selectedItem.Cells[6].Value.ToString();
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            //    textBox1.Text = selectedRow.Cells[0].Value.ToString();
            //    textBox2.Text = selectedRow.Cells[1].Value.ToString();
            //    textBox4.Text = selectedRow.Cells[4].Value.ToString();
            //    textBox3.Text = selectedRow.Cells[5].Value.ToString();
            //    dateTimePicker1.Value = DateTime.Parse(selectedRow.Cells[2].Value.ToString());
            //    comboBox1.Text = selectedRow.Cells[3].Value.ToString();
            //    button3.Enabled = true;
            //    button4.Enabled = true;
            //}
            //else
            //{
            //    button3.Enabled = false;
            //    button4.Enabled = false;
            //}
        }
        private void XoaTrangThongTin()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            comboBox1.Text = "";
            richTextBox2.Text = "";
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private bool Validate_Form()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Không được bỏ trống ô nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from NhanVien where [Mã nhân viên]='" + richTextBox2.Text + "' or [Tên nhân viên]=N'" + richTextBox2.Text + "'";
            DataTable dataTable = processData.DocBang(sql);
            dataGridView1.DataSource = dataTable;
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có mã hay tên nhân viên nào như vậy!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Validate_Form()) return;
            bool isDuplicate = dataGridView1.Rows.Cast<DataGridViewRow>()
                               .Any(row => row.Cells[0].Value != null && row.Cells[0].Value.ToString().Trim() == textBox1.Text.Trim());
            if (isDuplicate)
            {
                MessageBox.Show("Không được nhập trùng mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            processData.CapNhatDuLieu("INSERT INTO NhanVien ([Mã nhân viên], [Tên nhân viên], [Ngày sinh], [Giới tính],[Ngày bắt đầu làm],[Địa chỉ],[Điện thoại]) VALUES ('" + textBox1.Text + "', N'" + textBox2.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + comboBox1.Text + "','"+ dateTimePicker2.Value.ToString("yyyy-MM-dd") + "','" + textBox4.Text + "',N'" + textBox3.Text + "')");
            DataTable dataTable = processData.DocBang("SELECT * FROM NhanVien");
            dataGridView1.DataSource = dataTable;

            XoaTrangThongTin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Validate_Form()) return;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Enabled = false;
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string manhanvien = selectedRow.Cells[0].Value.ToString();
                string query = "UPDATE NhanVien SET [Mã nhân viên] = '" + textBox1.Text + "', [Tên nhân viên] = N'"
                    + textBox2.Text + "', [Ngày sinh] = '"
                    + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', [Giới tính] = '" + comboBox1.Text + "', [Ngày bắt đầu làm] = '"
                    + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "',[Địa chỉ] = N'" + textBox4.Text + "',[Điện thoại] ='" + textBox3.Text
                    + "' WHERE [Mã nhân viên] = '" + manhanvien + "'";
                processData.CapNhatDuLieu(query);
                DataTable dataTable = processData.DocBang("Select * from NhanVien");
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textBox1.Enabled = true;
            XoaTrangThongTin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Validate_Form()) return;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng này? Nhấn OK để xác nhận.",
                                                         "Xác nhận xóa",
                                                         MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    string manhanvien = selectedRow.Cells[0].Value.ToString();
                    string query = "DELETE from NhanVien where [Mã nhân viên]='" + manhanvien + "'";
                    processData.CapNhatDuLieu(query);
                    DataTable dataTable = processData.DocBang("Select * from NhanVien");
                    dataGridView1.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            XoaTrangThongTin();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
