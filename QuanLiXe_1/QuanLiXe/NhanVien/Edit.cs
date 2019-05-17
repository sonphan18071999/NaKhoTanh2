using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiXe
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            //#region
            //txtMaNV.Text = Global.manv;
            //txtHo.Text = Global.lName;
            //txtTen.Text = Global.fName;
            //ptbAva.Image = Global.pic;
            ////dtpBirthday.Value = Global.bday;
            //txtAddress.Text = Global.Address;
            //txtCmnd.Text = Global.Cmnd;
            //txtSdt.Text = Global.phone;
            //if (Global.Gender == "male")
            //{
            //    radioMale.Checked = true;
            //}
            //else
            //{
            //    radioFemale.Checked = true;
            //}
            //if (Global.type == "Van Phong")
            //{
            //    radioVP.Checked = true;
            //}
            //else if (Global.type == "Giam Sat")
            //{
            //    radioGS.Checked = true;
            //}
            //else
            //{
            //    radioTho.Checked = true;
            //}
            //#endregion
            //DataTable dt = new DataTable();
            //dt = nv.searchNhanVien(Global.manv);
            //txtMaNV.Text = dt.Rows[0].ToString();



        }
        NhanVien nv = new NhanVien();
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //try
            //{
                string ten = txtTen.Text;
                string ho = txtHo.Text;
                string address = txtAddress.Text;
                string cmnd = txtCmnd.Text;
                DateTime birhtday = dtpBirthday.Value;
                MemoryStream pt = new MemoryStream();
                ptbAva.Image.Save(pt, ptbAva.Image.RawFormat);
                string manv = txtMaNV.Text;
                string gender = "male";
                if (radioFemale.Checked)
                {
                    gender = "Female";
                }
                string type = "Van Phong";
                if (radioGS.Checked)
                {
                    type = "Giam Sat";
                }
                else if (radioTho.Checked)
                {
                    type = "Tho";

                }
                
                   
                string sdt = txtSdt.Text;
                if (verif())
                {
                if(nv.UpdateNhanVien(manv, ho, ten, gender, birhtday, sdt, address, cmnd, pt, type))
                    MessageBox.Show("Đã thay đổi thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thay đổi thông tin nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Thông tin điền không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void ptbAva_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                ptbAva.Image = Image.FromFile(open.FileName);
        }
        bool verif()
        {
            if ((txtAddress.Text.Trim() == "")
                || (txtCmnd.Text.Trim() == "")
                || (txtHo.Text.Trim() == "")
                || (txtTen.Text.Trim() == "")
                || (txtMaNV.Text.Trim() == "")
               || (txtSdt.Text.Trim() == "" || (ptbAva.Image == null)))
                return false;
            return true;
        }
    }
}
