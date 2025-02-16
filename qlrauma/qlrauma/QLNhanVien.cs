﻿using QLRauma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlrauma
{
    public partial class QLNhanVien : Form
    {

        public static string QuyenNV;
        public QLNhanVien()
        {
            InitializeComponent();
            if (QuyenNV == "NV")
            {
                tsmlTTNV.Enabled = false;
                tmslBaoCao.Enabled = false;
            }
        }

        private void frmloadFill(object frm)
        {
            if (this.panel_show.Controls.Count > 0)
                this.panel_show.Controls.RemoveAt(0);
            Form f = frm as Form;
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.Fill;
            this.panel_show.Controls.Add(f);
            this.panel_show.Tag = f;
            f.Show();
        }

        private void frmloadNoNe(object frm)
        {
            if (this.panel_show.Controls.Count > 0)
                this.panel_show.Controls.RemoveAt(0);
            Form f = frm as Form;
            f.TopLevel = false;
            f.TopMost = true;
            f.Dock = DockStyle.None;
            this.panel_show.Controls.Add(f);
            this.panel_show.Tag = f;
            f.Show();
        }
        private void đăngKíTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangKiTaiKhoan dk = new FrmDangKiTaiKhoan();
            frmloadNoNe(dk);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau dk = new FrmDoiMatKhau();
            frmloadNoNe(dk);
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinNhanVien ttvc = new frmThongTinNhanVien();
            frmloadFill(ttvc);
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            if (QuyenNV == "Admin")
            {
                tsmlQLNV.Enabled = true;
                tsmlDKTK.Enabled = true;
                tmslBaoCao.Enabled = true;
                FrmDangKiTaiKhoan DKTK = new FrmDangKiTaiKhoan();
                frmloadNoNe(DKTK);
                return;
            }
            if (QuyenNV == "NV")
            {
                FrmDoiMatKhau DMK = new FrmDoiMatKhau();
                frmloadNoNe(DMK);
            }

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmBaoCao dk = new frmBaoCao();
            //frmloadNoNe(dk);
        }
    }
}
