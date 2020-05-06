using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackupRestore
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            tbServername.Text = Program.servername;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.conn.Close();
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Trim()=="")
            {
                MessageBox.Show("Tài khoản đăng nhập khộng được trống", "Báo Lỗi",MessageBoxButtons.OK);
                txtUsername.Focus();
                return;
            }
            Program.mlogin = txtUsername.Text;
            Program.password = txtPassword.Text;
            Program.mlogin = txtUsername.Text;
            Program.servername = tbServername.Text;
            if (Program.KetNoi() == 0) return;
            //Đăng nhập thành công
            if(Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu", "", MessageBoxButtons.OK);
                return;
            }
            //Program.conn.Close();
            Program.frmMain = new frmMain();
            Program.frmMain.Activate();
            Program.frmMain.Show();
            this.Visible=false;
        }
    }
}
