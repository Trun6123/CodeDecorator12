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
    public partial class TienVanChuyen : Form
    {
        Product Product = new Product();
        IProduct product = new Product();
        public TienVanChuyen()
        {
            InitializeComponent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            product.Products = Product.Products;
            DeliveryDecorator DeliveryDecorator = new DeliveryDecorator();

            DeliveryDecorator.productDecorator(product, textBoxID.Text, double.Parse(textPrice.Text));



            DeliveryDecorator.Products = Product.Products;
            DeliveryDecorator.DisplayInfor();
            dataGridView1.DataSource = DeliveryDecorator.dataTable;
            MessageBox.Show("Cập nhật thành công");
        }

        private void TienVanChuyen_Load(object sender, EventArgs e)
        {
            DeliveryDecorator DeliveryDecorator = new DeliveryDecorator();
            Product.Load();
            DeliveryDecorator.Products = Product.Products;
            DeliveryDecorator.DisplayInfor();
            dataGridView1.DataSource = DeliveryDecorator.dataTable;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
