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

namespace winformdemo
{
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            string sQuery = "select * from KhachHang";
            string data = "Data";
        }
    }
}
