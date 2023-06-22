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
    public partial class Userf : Form
    {
        User User = new User();
        public Userf()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string staff ;
            if (checkBoxStaff.Checked)
                staff = "Adm";
            else
                staff = "User";
            User.Add(textBoxID.Text, textBoxName.Text, textBoxAcc.Text, textBoxPass.Text,staff);
            MessageBox.Show("Đã thêm Tài khoản thành công!");
            dataGridView1.DataSource = User.Users.ToList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string staff;
            if (checkBoxStaff.Checked)
                staff = "Adm";
            else
                staff = "User";
            User.Edit(textBoxID.Text, textBoxName.Text, textBoxAcc.Text, textBoxPass.Text,staff);
            MessageBox.Show("Đã sửa Tài khoản thành công!");
            dataGridView1.DataSource = User.Users.ToList();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            User.Delete(textBoxID.Text);
            MessageBox.Show("Đã xóa Tài khoản thành công!");
            dataGridView1.DataSource = User.Users.ToList();
        }
        string id;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxAcc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxPass.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Adm")
                checkBoxStaff.Checked = true;
            else
                checkBoxStaff.Checked = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Userf_Load(object sender, EventArgs e)
        {
            User.Load();
            dataGridView1.DataSource = User.Users.ToList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxStaff_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
