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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        KhachHang KhachHang;
        private void kháchHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(KhachHang==null||KhachHang.IsDisposed==true)
            {
                KhachHang = new KhachHang();
                KhachHang.MdiParent = FrmMain.ActiveForm;
                KhachHang.Show();
            }
            else
            {
                KhachHang.Activate();
            }
        }
        Userf Userf;
        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Userf == null || Userf.IsDisposed == true)
            {
                Userf = new Userf();
                Userf.MdiParent = FrmMain.ActiveForm;
                Userf.Show();
            }
            else
            {
                Userf.Activate();
            }
        }
        NhaSanXuat NhaSanXuat;
        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NhaSanXuat == null || NhaSanXuat.IsDisposed == true)
            {
                NhaSanXuat = new NhaSanXuat();
                NhaSanXuat.MdiParent = FrmMain.ActiveForm;
                NhaSanXuat.Show();
            }
            else
            {
                NhaSanXuat.Activate();
            }
        }
        TheKhuyenMai TheKhuyenMai;
        private void thẻKMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheKhuyenMai == null || TheKhuyenMai.IsDisposed == true)
            {
                TheKhuyenMai = new TheKhuyenMai();
                TheKhuyenMai.MdiParent = FrmMain.ActiveForm;
                TheKhuyenMai.Show();
            }
            else
            {
                TheKhuyenMai.Activate();
            }
        }
        TienVanChuyen TienVanChuyen;
        private void tiềnVậnChuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TienVanChuyen == null || TienVanChuyen.IsDisposed == true)
            {
                TienVanChuyen = new TienVanChuyen();
                TienVanChuyen.MdiParent = FrmMain.ActiveForm;
                TienVanChuyen.Show();
            }
            else
            {
                TienVanChuyen.Activate();
            }
        }
        DatHang DatHang;
        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatHang == null || DatHang.IsDisposed == true)
            {
                DatHang = new DatHang();
                DatHang.MdiParent = FrmMain.ActiveForm;
                DatHang.Show();
            }
            else
            {
                DatHang.Activate();
            }
        }
    }
}
