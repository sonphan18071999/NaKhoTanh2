using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiXe.UserControls
{
    public partial class HopDongGui : UserControl
    {
        public HopDongGui()
        {
            InitializeComponent();
        }
        Contract ct = new Contract();
        private void btnAddCon_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvCon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void HopDongGui_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
           dt= ct.getAllContract();
            dgvCon.DataSource = dt;
        }

        private void Click(object sender, EventArgs e)
        {
            string mahd = txtSearch.Text;
            DataTable dt = new DataTable();
            dt = ct.getContractbyID(mahd);
            dgvCon.DataSource = dt;
            
        }
    }
}
