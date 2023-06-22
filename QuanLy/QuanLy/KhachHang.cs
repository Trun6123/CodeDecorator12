using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class KhachHang : Form
    {
        Customer Customer = new Customer();
        public KhachHang()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
           
        {
            Customer.Load();
            dataGridView1.DataSource = Customer.Customers;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Customer.Add(textBoxID.Text, textBoxName.Text, int.Parse(textBoxPhone.Text), textBoxAddress.Text);
            MessageBox.Show("Đã thêm Khách hàng thành công!");
            dataGridView1.DataSource = Customer.Customers.ToList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Customer.Edit(textBoxID.Text, textBoxName.Text, int.Parse(textBoxPhone.Text), textBoxAddress.Text);
            MessageBox.Show("Đã sửa Khách hàng thành công!");
            dataGridView1.DataSource = Customer.Customers.ToList();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            Customer.Delete(textBoxID.Text);
            MessageBox.Show("Đã xóa Khách hàng thành công!");
            dataGridView1.DataSource = Customer.Customers.ToList();
        }
        string id ;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxAddress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
