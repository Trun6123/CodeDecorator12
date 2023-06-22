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
    public partial class NhaSanXuat : Form
    {
        public NhaSanXuat()
        {
            InitializeComponent();
        }
        Product Product = new Product();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
            Product.Add(textBoxID.Text, textBoxName.Text,double.Parse( textPrice.Text), textBoxNote.Text);
            MessageBox.Show("Đã thêm Nhà Sx thành công!");
            dataGridView1.DataSource = Product.Products.ToList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
           
            Product.Edit(textBoxID.Text, textBoxName.Text, double.Parse(textPrice.Text), textBoxNote.Text);
            MessageBox.Show("Đã sửa  Nhà Sx  thành công!");
            dataGridView1.DataSource = Product.Products.ToList();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            Product.Delete(textBoxID.Text);
            MessageBox.Show("Đã xóa  Nhà Sx  thành công!");
            dataGridView1.DataSource = Product.Products.ToList();
        }
        string id;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxNote.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           
        }

        private void NhaSanXuat_Load(object sender, EventArgs e)
        {
            Product.Load();
            dataGridView1.DataSource = Product.Products.ToList();
        }
    }
}
