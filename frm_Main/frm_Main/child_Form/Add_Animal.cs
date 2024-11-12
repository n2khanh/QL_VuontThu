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
    public partial class Add_Animal : Form
    {
        ProcessDataBase processData;
        public Add_Animal()
        {
            InitializeComponent();
        }

        private void Add_Animal_Load(object sender, EventArgs e)
        {
            processData = new ProcessDataBase();
            DataTable dt = new DataTable();
            dt = processData.DocBang("select [Mã chuồng] from Chuong where [Ghi chú] = N'Trống'");
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Mã chuồng";
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Thiết lập các thuộc tính của OpenFileDialog
                ofd.InitialDirectory = @"C:\"; // Thư mục mặc định khi mở
                ofd.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.FilterIndex = 1; // Mặc định chọn loại đầu tiên trong Filter
                ofd.RestoreDirectory = true; // Khôi phục thư mục hiện tại khi đóng

                // Hiển thị OpenFileDialog và kiểm tra nếu người dùng chọn tệp
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn đầy đủ của tệp đã chọn
                    string filePath = ofd.FileName;
                    pictureBox1.ImageLocation = filePath;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidateForm()
        {
            // Validate Mã thú
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã thú.");
                textBox1.Focus();
                return false;
            }

            // Validate Tên thú
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên thú.");
                textBox2.Focus();
                return false;
            }

            // Validate Loài
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Vui lòng nhập Loài.");
                textBox4.Focus();
                return false;
            }

            // Validate Tuổi (chỉ chấp nhận số dương)
            if (!int.TryParse(textBox14.Text, out int tuoi) || tuoi < 0)
            {
                MessageBox.Show("Tuổi phải là một số nguyên dương.");
                textBox14.Focus();
                return false;
            }

            // Validate Số lượng cái
            if (!int.TryParse(textBox13.Text, out int soLuongCai) || soLuongCai < 0)
            {
                MessageBox.Show("Số lượng cái phải là một số nguyên dương.");
                textBox13.Focus();
                return false;
            }

            // Validate Số lượng đực
            if (!int.TryParse(textBox12.Text, out int soLuongDuc) || soLuongDuc < 0)
            {
                MessageBox.Show("Số lượng đực phải là một số nguyên dương.");
                textBox12.Focus();
                return false;
            }

            // Validate ít nhất một trong hai số lượng cái hoặc đực phải lớn hơn 0
            if (soLuongCai == 0 && soLuongDuc == 0)
            {
                MessageBox.Show("Phải có ít nhất một số lượng cái hoặc đực lớn hơn 0.");
                textBox13.Focus();
                return false;
            }

            // Validate Ngày sinh
            if (dateTimePicker2.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không thể lớn hơn ngày hiện tại.");
                dateTimePicker2.Focus();
                return false;
            }

            // Validate Kiểu sinh
            if (string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Vui lòng nhập Kiểu sinh.");
                textBox7.Focus();
                return false;
            }

            // Validate Tên KH
            if (string.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên khoa học.");
                textBox8.Focus();
                return false;
            }

            // Validate Ngày vào
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày vào không thể lớn hơn ngày hiện tại.");
                dateTimePicker1.Focus();
                return false;
            }

            // Validate Nguồn gốc
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Vui lòng nhập Nguồn gốc.");
                textBox5.Focus();
                return false;
            }

            return true; // Nếu tất cả các trường hợp đều hợp lệ
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string a = "";
            if (ValidateForm()) {
                if (radioButton1.Checked) { a = "Có"; } else { a = "Không"; }
                processData = new ProcessDataBase();
                processData.CapNhatDuLieu("INSERT INTO Thu([Mã thú],[Tên gọi],Loài,[Sách đỏ],[Tên khoa học],[Kiểu sinh],[Ngày vào],[Nguồn gốc],[Đặc điểm],[Ngày sinh],[Hình ảnh],[Tuổi thọ],[Số lượng cá thể cái],[Số lượng cá thể đực],[Mã chuồng]) " +
                    "values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + a + "','" + textBox8.Text + "','" + textBox7.Text + "','" + dateTimePicker1.Value.ToString() + "','" + textBox5.Text + "','" + richTextBox1.Text + "','" + dateTimePicker2.Value.ToString() + "','" + pictureBox1.ImageLocation + "','" + textBox14.Text + "','" +
                    textBox13.Text + "','" + textBox12.Text + "','" + comboBox1.Text + "')");
                MessageBox.Show("Thêm thành công !" , "Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Vui lòng nhập đúng!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox12.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            richTextBox1.Text = "";
            radioButton1.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            comboBox1.Text = "";
            pictureBox1.ImageLocation = "";
        }
    }
}
