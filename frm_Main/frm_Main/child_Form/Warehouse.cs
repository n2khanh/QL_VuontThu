using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace frm_Main.child_Form
{
    public partial class Warehouse : Form
    {
        ProcessDataBase processData = new ProcessDataBase();
        public Warehouse()
        {
            InitializeComponent();

            textBox2.TextChanged += textBox2_TextChanged;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            DataTable dataTable = processData.DocBang("Select * from ThucAn");
            dataGridView1.DataSource = dataTable;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from ThucAn where [Mã thức ăn]='" + richTextBox2.Text + "' or [Tên thức ăn]=N'" + richTextBox2.Text + "'";
            DataTable dataTable = processData.DocBang(sql);
            dataGridView1.DataSource = dataTable;
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có mã hay tên thức ăn nào như vậy!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedItem = dataGridView1.SelectedRows[0];
                textBox1.Text = selectedItem.Cells[0].Value.ToString();
                textBox2.Text = selectedItem.Cells[1].Value.ToString();
                textBox3.Text = selectedItem.Cells[4].Value.ToString();
                if (DateTime.TryParse(selectedItem.Cells[2].Value.ToString(), out DateTime date1))
                {
                    dateTimePicker1.Value = date1;
                }
                if (DateTime.TryParse(selectedItem.Cells[3].Value.ToString(), out DateTime date2))
                {
                    dateTimePicker2.Value = date2;
                }
                richTextBox1.Text = selectedItem.Cells[5].Value.ToString();
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void XoaTrangThongTin()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }
        private string VietHoaChuDau(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            return char.ToUpper(input[0]) + input.Substring(1);
        }
        private void Validate_Form()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Không được bỏ trống ô nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(textBox3.Text, out decimal slValue))
            {
                MessageBox.Show("Hãy nhập giá trị hợp lệ cho số lượng (dạng số).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Validate_Form();
            bool isDuplicate = dataGridView1.Rows.Cast<DataGridViewRow>()
                                .Any(row => row.Cells[0].Value != null && row.Cells[0].Value.ToString() == textBox1.Text);

            if (isDuplicate)
            {
                MessageBox.Show("Không được nhập trùng mã.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            processData.CapNhatDuLieu("INSERT INTO ThucAn ([Mã thức ăn], [Tên thức ăn], [Ngày nhập], [Hạn sử dụng],[Số lượng nhập],[Ghi chú]) VALUES ('" + textBox1.Text + "', N'" + textBox2.Text + "', '" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "','" + textBox3.Text + "',N'" + richTextBox1.Text + "')");
            DataTable dataTable = processData.DocBang("SELECT * FROM ThucAn");
            dataGridView1.DataSource = dataTable;
            XoaTrangThongTin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Validate_Form();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Enabled = false;
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string ma = selectedRow.Cells[0].Value.ToString();
                string query = "UPDATE ThucAn SET [Mã thức ăn] = '" + textBox1.Text + "', [Tên thức ăn] = N'"
                            + textBox2.Text + "', [Ngày nhập] = '"
                            + dateTimePicker1.Value + "', [Hạn sử dụng] = '" + dateTimePicker2.Value + "', [Số lượng nhập] = '" + textBox3.Text + "',[Ghi chú] = N'" + richTextBox1.Text
                            + "' WHERE [Mã thức ăn] = '" + ma + "'";
                processData.CapNhatDuLieu(query);
                DataTable dataTable = processData.DocBang("Select * from ThucAn");
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
            Validate_Form();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng này? Nhấn OK để xác nhận.",
                                                         "Xác nhận xóa",
                                                         MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    string ma = selectedRow.Cells[0].Value.ToString();
                    string query = "DELETE from ThucAn where [Mã thức ăn]='" + ma + "'";
                    processData.CapNhatDuLieu(query);
                    DataTable dataTable = processData.DocBang("Select * from ThucAn");
                    dataGridView1.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            XoaTrangThongTin();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = textBox2.SelectionStart;
            textBox2.Text = VietHoaChuDau(textBox2.Text);
            textBox2.SelectionStart = cursorPosition;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = richTextBox1.SelectionStart;
            richTextBox1.Text = VietHoaChuDau(richTextBox1.Text);
            richTextBox1.SelectionStart = cursorPosition;
        }

        private void richTextBox2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
