using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frm_Main.Model;

namespace frm_Main.child_Form
{
    public partial class AnimalDetails : Form
    {
        ProcessDataBase processData;
        public AnimalDetails()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
        public void LoadAnimal(AnimalModel animal)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            textBox1.Text = animal.MaThu;
            textBox2.Text = animal.TenThu;
            textBox4.Text = animal.Loai;
            if (animal.Sd) radioButton1.Checked = true;
            else radioButton1.Checked = false;
            textBox8.Text = animal.TenKH;
            textBox7.Text = animal.Kieusinh;
            dateTimePicker1.Value = animal.NgayVao;
            textBox5.Text = animal.Nguongoc;
            richTextBox1.Text = animal.Dacdiem;
            dateTimePicker2.Value = animal.NgaySinh;
            pictureBox1.ImageLocation = animal.Hinhanh;
            textBox14.Text = animal.Tuoi.ToString();
            textBox13.Text = animal.Slcai.ToString();
            textBox12.Text = animal.Slduc.ToString();
        }
        private void AnimalDetails_Load(object sender, EventArgs e)
        {


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            textBox1.Enabled = false;
            button1.Enabled = false;
            label17.Text = "Đang sửa";
            label17.ForeColor = Color.Orange;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label17.Text == "Đang sửa")

            {
                if (ValidateForm())
                {
                    string a = "";
                    processData = new ProcessDataBase();
                    if (radioButton1.Checked == true) a = "Có";
                    else a = "Không";
                    processData.CapNhatDuLieu("Update Thu set [Tên gọi] ='" + textBox2.Text + "',[Loài] = '" + textBox4.Text + "',[Sách đỏ] = '" + a + "', " +
                        "[Tên khoa học] = '" + textBox8.Text + "',[Kiểu sinh] = '" + textBox7.Text + "',[Ngày vào] = '" + dateTimePicker1.Value.ToString() + "',[Nguồn gốc] = '" + textBox5.Text + "',[Đặc điểm] = '" + richTextBox1.Text + "'," +
                        "[Ngày sinh] = '" + dateTimePicker2.Value.ToString() + "',[Hình ảnh] ='" + pictureBox1.ImageLocation + "',[Tuổi thọ] = " + textBox14.Text + ",[Số lượng cá thể cái] = '" + textBox13.Text + "',[Số lượng cá thể đực] = '" + textBox12.Text + "' where [Mã thú] = '" + textBox1.Text + "'");
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    label17.Text = "Bình thường";
                    label17.ForeColor = System.Drawing.Color.Black;
                    this.Close();
                }
                else MessageBox.Show("Sửa thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (label17.Text == "Đang xóa")
            {
                processData = new ProcessDataBase();
                processData.CapNhatDuLieu("Delete from Thu where [Mã thú] = '" + textBox1.Text + "'");
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label17.Text = "Bình thường";
                label17.ForeColor = System.Drawing.Color.Black;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox4.Enabled = false;
            richTextBox1.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            textBox13.Enabled = false;
            textBox12.Enabled = false;
            textBox14.Enabled = false;
            textBox5.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            radioButton1.Enabled = false;
            label17.Text = "Đang xóa";
            label17.ForeColor = Color.Red;
            button2.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            label17.Text = "Bình thường";
            label17.ForeColor = System.Drawing.Color.Black;
            button2.Enabled = true;
            button1.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
