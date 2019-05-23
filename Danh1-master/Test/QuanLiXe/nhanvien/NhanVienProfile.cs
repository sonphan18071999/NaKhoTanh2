using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLiXe
{
    public partial class NhanVienProfile : UserControl
    {
        public NhanVienProfile()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        NhanVien nv = new NhanVien();
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = nv.getNVprofile(Global.username);
                txtMaNV.Text = dt.Rows[0]["maNV"].ToString();
                txtTen.Text = dt.Rows[0]["fName"].ToString();
                txtHo.Text = dt.Rows[0]["lName"].ToString();
                if (dt.Rows[0]["gender"].ToString() == "male")
                {
                    radioMale.Checked = true;
                }
                else
                {
                    radioFemale.Checked = true;
                }
                if (dt.Rows[0]["type"].ToString() == "Giam Sat")
                {
                    radioGS.Checked = true;
                }
                else
                {
                    radioVP.Checked = true;
                }
                dateTimePicker1.Value = (DateTime)dt.Rows[0]["birthday"];
                txtSdt.Text = dt.Rows[0]["phone"].ToString();
                txtAddress.Text = dt.Rows[0]["address"].ToString();
                txtCmnd.Text = dt.Rows[0]["Cmnd"].ToString();
                byte[] pic;
                pic = (byte[])dt.Rows[0]["ava"];
                MemoryStream picture = new MemoryStream(pic);
                ptbAva.Image = Image.FromStream(picture);
            }catch(Exception ex)
            {
                MessageBox.Show("Thông tin nhân viên thiếu sót!","Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NhanVienProfile_Load(object sender, EventArgs e)
        {

        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
