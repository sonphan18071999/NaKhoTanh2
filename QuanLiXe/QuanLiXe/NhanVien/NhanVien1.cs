﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace QuanLiXe
{
    public partial class NhanVien1 : UserControl
    {
        public NhanVien1()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        private void NhanVien1_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nv.getAllCus();
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowTemplate.Height = 90;
            dgvNhanVien.Show();
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvNhanVien.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvNhanVien.AllowUserToAddRows = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNhanVien ad = new AddNhanVien();
            ad.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from NhanVien where MaNV like'%" + txtSearch.Text + "%'");
            dgvNhanVien.ReadOnly = true;
            //xử lí hình ảnh, code có tham khảo msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvNhanVien.RowTemplate.Height = 90; //chỉnh pic đẹp
            dgvNhanVien.DataSource = nv.searchNhanVien(cmd);
            picCol = (DataGridViewImageColumn)dgvNhanVien.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvNhanVien.AllowUserToAddRows = false;
        }
    }
}