using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiXe
{
    public partial class AddConTract : Form
    {
        Contract con = new Contract();

        public AddConTract()
        {
            InitializeComponent();
        }
        
        private void btnAddCon_Click(object sender, EventArgs e)
        {
            //Khai báo để vào insert
                        #region khai báo
            string mahd = txtConID.Text;
            string makh = txtCustomID.Text;
            string thoihan = txtThoiHan.Text;
            DateTime ngaybatdau = dtpDateStart.Value;
            DateTime ngayketthuc;
            string paid = txtPaid.Text;
            string des = txtDescription.Text;
            string type;
            if (radiobtnThue.Checked = true)
            {
                type = radiobtnThue.Text;
            }
            type = radiobtnGui.Text;

            string userid = null;
           
            #endregion
            // Thêm hợp đồng
            if(con.insertCon(mahd,makh,thoihan,ngaybatdau,paid,des,type,userid))
            {
                MessageBox.Show("Đã thêm hợp đồng");
                clearform();
            }
            else MessageBox.Show("Something Wrong!");
            
        }

        private void AddConTract_Load(object sender, EventArgs e)
        {
            txtCustomID.Text = BienToanCuc.IDKH;
        }
        //Hàm reset form sau khi add thành công
        void clearform()
        {
            txtConID.Text = "";
            txtCustomID.Text="";
            txtDescription.Text = "";
            txtPaid.Text = "";
            txtThoiHan.Text = "";
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            //Khai báo biến để Update
            #region khai báo
            string mahd = txtConID.Text;
            string thoihan = txtThoiHan.Text;
            string paid = txtPaid.Text;
            string des = txtDescription.Text;
            DateTime ngaybatdau = dtpDateStart.Value;
            DateTime ngayketthuc = DateTime.Now;
            string makh = txtCustomID.Text;
            string theloai;
            string type;
            if (radiobtnGui.Checked)
            {
                type = radiobtnGui.Text;
            }
            else { type= radiobtnThue.Text; }
            string userid=null;
            
            #endregion
            try
            {
                if (con.updateCon(mahd,makh,thoihan,ngaybatdau,DateTime.Now,paid,des,type,userid))
                {
                    MessageBox.Show("Đã thanh toán xong Hợp Đồng! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
           
        }

        private void btnListBox_Click(object sender, EventArgs e)
        {
            txtBienSo.Text = ListBoxBienSo.Text;
        }
    }
}
