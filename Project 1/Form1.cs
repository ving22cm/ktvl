using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    
    public partial class Login : Form
    {
        Main mainform = new Main();
        public Login()
        {
            InitializeComponent();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Name_Click(object sender, EventArgs e)
        {
            Name.Text = "";
        }

        private void Pass_Click(object sender, EventArgs e)
        {
            Pass.Text = "";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Name.Text == "admin" && Pass.Text == "testproject1")
            {
                mainform.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Mật khẩu của bạn đã sai", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void Mainform_closed(object sender ,FormClosedEventArgs e)
        {
            this.Close();
        }
        // Vấn đề: Khi ấn nút tắt của mainform2 thì form1 vẫn đang chạy
    }
}
