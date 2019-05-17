using System;
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
            editNhanVienUC2.Visible = false;
            addNhanVienUC2.Visible = false;
            thongKeNVUC11.Visible = false;
            AddNhanVienUC ad = new AddNhanVienUC();
            ad.Show();
            dgvNhanVien.DataSource = nv.getAllNV();
            dgvNhanVien.Show();
            dgvNhanVien.RowTemplate.Height = 90;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvNhanVien.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }
        public void refresh()
        {
            dgvNhanVien.DataSource = nv.getAllNV();
            dgvNhanVien.Show();
            dgvNhanVien.RowTemplate.Height = 90;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvNhanVien.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        //AddNhanVienUC adnc = new AddNhanVienUC();
        //NhanVien1 nv1 = new NhanVien1();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNhanVienUC2.Show();
            dgvNhanVien.Visible = false;
            editNhanVienUC2.Visible = false;
            thongKeNVUC11.Visible = false;

        }
    
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("select * from NhanVien where MaNV like'%" + txtSearch.Text + "%'");
            dgvNhanVien.ReadOnly = true;
            string manv = txtSearch.Text;
            //xử lí hình ảnh, code có tham khảo msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvNhanVien.RowTemplate.Height = 90; //chỉnh pic đẹp
            dgvNhanVien.DataSource = nv.searchNhanVien(manv);
            picCol = (DataGridViewImageColumn)dgvNhanVien.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvNhanVien.AllowUserToAddRows = false;
        }
        
        private void Edit(object sender, EventArgs e)
        {
            addNhanVienUC2.Visible = false;
            editNhanVienUC2.Visible = false;
            dgvNhanVien.Visible = false;
            #region
            //string manv = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            //manv = manv.Trim();
            //Global.MANV(manv);
            //string fname = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            //fname = fname.Trim();
            //Global.FNAME(fname);
            //string lname = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            //lname = lname.Trim();
            //Global.LNAME(lname);
            //string gender = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            //gender = gender.Trim();
            //Global.gender(gender);

            //Edit ed = new Edit();
            //byte[] pic;
            //pic = (byte[])dgvNhanVien.CurrentRow.Cells[8].Value;
            //MemoryStream picture = new MemoryStream(pic);
            //Global.pic = Image.FromStream(picture);
            //string phone = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            //phone = phone.Trim();
            //Global.PHONE(phone);
            //string address = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            //address = address.Trim();
            //Global.ADDRESS(address);
            //string cmnd = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
            //cmnd = cmnd.Trim();
            //Global.CMND(cmnd);
            //string type = dgvNhanVien.CurrentRow.Cells[9].Value.ToString();
            //type = type.Trim();
            //Global.TYPE(type);
            #endregion
            //DateTime BDAY= (DateTime)dgvNhanVien.CurrentRow.Cells[4].Value;
            //Global.Birthday(BDAY);
            //byte[] pic;
            //pic = (byte[])dgvNhanVien.CurrentRow.Cells[7].Value;
            //ed.ShowDialog();
            editNhanVienUC2.Visible = true;
            editNhanVienUC2.txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            editNhanVienUC2.txtMaNV.Text = editNhanVienUC2.txtMaNV.Text.Trim();
            editNhanVienUC2.txtHo.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            editNhanVienUC2.txtTen.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            dgvNhanVien.CurrentRow.Cells[3].Value = dgvNhanVien.CurrentRow.Cells[3].Value.ToString().Trim();
            if (dgvNhanVien.CurrentRow.Cells[3].Value.ToString()=="Female")
            {
                editNhanVienUC2.radioFemale.Checked = true;
            }
            else
            {
                editNhanVienUC2.radioMale.Checked = true;
               
            }
            editNhanVienUC2.dtpBirthday.Value = (DateTime)dgvNhanVien.CurrentRow.Cells[4].Value;
            editNhanVienUC2.txtSdt.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            editNhanVienUC2.txtAddress.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            editNhanVienUC2.txtCmnd.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
            dgvNhanVien.CurrentRow.Cells[9].Value=dgvNhanVien.CurrentRow.Cells[9].Value.ToString().Trim();
            if (dgvNhanVien.CurrentRow.Cells[9].Value.ToString()=="Giam Sat")
            {
                editNhanVienUC2.radioGS.Checked = true;
            }
            else if(dgvNhanVien.CurrentRow.Cells[9].Value.ToString()=="Van Phong")
            {
                editNhanVienUC2.radioVP.Checked = true;
            }
            else
            {
                editNhanVienUC2.radioTho.Checked = true;
            }
            byte[] pic;
            pic = (byte[])dgvNhanVien.CurrentRow.Cells[8].Value;
            MemoryStream picture = new MemoryStream(pic);
            editNhanVienUC2.ptbAva.Image = Image.FromStream(picture);
            editNhanVienUC2.Show();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
           
            Global.MANV(id);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            //Global.IDGlobal(id);
            

        }
        
        private void btnThongKeNV_Click(object sender, EventArgs e)
        {
            thongKeNVUC11.Visible = true;
            dgvNhanVien.Visible = false;
            editNhanVienUC2.Visible = false;
            addNhanVienUC2.Visible = false;
        }

        private void NhanVien1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //XoaNhanVien xnv = new XoaNhanVien();
            //xnv.ShowDialog();
            string manv=dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            manv = manv.Trim();
            
            DialogResult dlr=MessageBox.Show("Bạn muốn xóa nhân viên có mã " + manv ,"Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            
            if (dlr == DialogResult.Yes)
            {
                dgvNhanVien.DataSource = nv.DeleteNhanVien(manv);
                dgvNhanVien.Show();
                MessageBox.Show("Nhân viên có mã " + manv+" đã bị xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            
        }

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nv.getAllNV();
            dgvNhanVien.Show();
            dgvNhanVien.RowTemplate.Height = 90;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvNhanVien.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvNhanVien.Visible = true;

        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nv.getAllNV();
            dgvNhanVien.Show();
            thongKeNVUC11.Visible = false;
            dgvNhanVien.RowTemplate.Height = 90;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dgvNhanVien.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvNhanVien.Visible = true;
            addNhanVienUC2.Visible = false;
            editNhanVienUC2.Visible = false;
        }
    }
}
