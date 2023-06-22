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
    public partial class DatHang : Form
    {
        Product Product = new Product();
        User User = new User();
        Customer Customer = new Customer();

        Order Order = new Order();
        OrderDetail OrderDetail = new OrderDetail();
        public DatHang()
        {
            InitializeComponent();
        }

        private void DatHang_Load(object sender, EventArgs e)
        {
            HienThiComboBox();
            Order.Load();
            dataGridView2.DataSource = Order.Orders.ToList();
            OrderDetail.Load();
            dataGridView1.DataSource = OrderDetail.OrderDetails.ToList();
        }

        void HienThiComboBox()
        {
            Product.Load();
            comboBoxProduct.DisplayMember = "ProductName";
            comboBoxProduct.ValueMember = "ProductID";
            comboBoxProduct.DataSource = Product.Products.ToList();

            User.Load();
            comboBoxUser.DisplayMember = "User_name";
            comboBoxUser.ValueMember = "UserID";
            comboBoxUser.DataSource = User.Users.ToList();

            Customer.Load();
            comboBoxCus.DisplayMember = "Customer_name";
            comboBoxCus.ValueMember = "CustomerID";
            comboBoxCus.DataSource = Customer.Customers.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (OrderDetail.OrderDetails.Where(x => x.OrderID == textBoxID.Text).Where(x => x.ProductID == comboBoxProduct.SelectedValue.ToString()).Count() == 0)
            {
                OrderDetail.Add(textBoxID.Text, comboBoxProduct.SelectedValue.ToString(), double.Parse(textBoxPrice.Text), int.Parse(textBoxQuantity.Text));
                if (Order.Orders.Where(x => x.OrderID == textBoxID.Text).Count() == 0)
                    Order.Add(textBoxID.Text, comboBoxUser.SelectedValue.ToString(), comboBoxCus.SelectedValue.ToString(), double.Parse(textBoxPrice.Text), dateTimePicker1.Value, textBoxStatus.Text);
            }
            if(Order.Orders.Where(x=>x.OrderID==textBoxID.Text).Count()==1)
            {
                labelTotal.Text= OrderDetail.OrderDetails.Where(x => x.OrderID == textBoxID.Text).Sum(x => x.Quantily1 * x.Price1).ToString();
                Order.Edit(textBoxID.Text, comboBoxUser.SelectedValue.ToString(), comboBoxCus.SelectedValue.ToString(), double.Parse(labelTotal.Text), dateTimePicker1.Value, textBoxStatus.Text);
            }
            dataGridView2.DataSource = Order.Orders.ToList();
            dataGridView1.DataSource = OrderDetail.OrderDetails.ToList();
            MessageBox.Show("Đã Thêm Đặt hàng thành công!");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            OrderDetail.Edit(textBoxID.Text, comboBoxProduct.SelectedValue.ToString(), double.Parse(textBoxPrice.Text), int.Parse(textBoxQuantity.Text));
            labelTotal.Text = OrderDetail.OrderDetails.Where(x => x.OrderID == textBoxID.Text).Sum(x => x.Quantily1 * x.Price1).ToString();
            Order.Edit(textBoxID.Text, comboBoxUser.SelectedValue.ToString(), comboBoxCus.SelectedValue.ToString(), double.Parse(labelTotal.Text), dateTimePicker1.Value, textBoxStatus.Text);
            MessageBox.Show("Đã Sửa Đặt hàng thành công!");
            dataGridView2.DataSource = Order.Orders.ToList();
            dataGridView1.DataSource = OrderDetail.OrderDetails.ToList();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            OrderDetail.Delete(textBoxID.Text, comboBoxProduct.SelectedValue.ToString());
            labelTotal.Text = OrderDetail.OrderDetails.Where(x => x.OrderID == textBoxID.Text).Sum(x => x.Quantily1 * x.Price1).ToString();
            Order.Edit(textBoxID.Text, comboBoxUser.SelectedValue.ToString(), comboBoxCus.SelectedValue.ToString(), double.Parse(labelTotal.Text), dateTimePicker1.Value, textBoxStatus.Text);

            MessageBox.Show("Đã xóa Đặt hàng thành công!");
            dataGridView2.DataSource = Order.Orders.ToList();
            dataGridView1.DataSource = OrderDetail.OrderDetails.ToList();
        }
        string id;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxProduct.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxQuantity.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
