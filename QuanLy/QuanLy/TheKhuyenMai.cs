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
    public partial class TheKhuyenMai : Form
    {
        public TheKhuyenMai()
        {
            InitializeComponent();
        }
       
        Product Product = new Product();
        IProduct product = new Product();
        
        private void buttonEdit_Click(object sender, EventArgs e)
        {

            product.Products = Product.Products; 
         VoucherDecorator VoucherDecorator = new VoucherDecorator();
           
            VoucherDecorator.productDecorator(product, textBoxID.Text, double.Parse(textPrice.Text));
         
            
           
            VoucherDecorator.Products = Product.Products;
            VoucherDecorator.DisplayInfor();
            dataGridView1.DataSource = VoucherDecorator.dataTable;
            MessageBox.Show("Cập nhật thành công");
        }

        private void TheKhuyenMai_Load(object sender, EventArgs e)
        {
            VoucherDecorator VoucherDecor = new VoucherDecorator();           
            Product.Load();
            VoucherDecor.Products = Product.Products;
            VoucherDecor.DisplayInfor();
            dataGridView1.DataSource = VoucherDecor.dataTable;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
