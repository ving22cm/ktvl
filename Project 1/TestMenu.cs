using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace Project_1
{
    // Tạo delegate lấy dữ liệu thoát
    public delegate void CloseForm(int MenuStatusValue);
    public partial class TestMenu : UserControl
    {
        // Lấy dữ liệu từ việc chọn Menu
        public ChooseMenu ValChange;
        // Lấy dữ liệu từ việc thoát Menu của người dùng
        public CloseForm ExitMenu;
        //end
        public TestMenu()
        {
            InitializeComponent();
        }
        //Giá trị mặc định là 0
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public int Choose;
        // Việc chọn các khu vực
        private void BtnRememberMenu_Click(object sender, EventArgs e)
        {
            BtnColor.Location = new System.Drawing.Point(8,84);
            Choose = 1;
            this.ValChange(Choose);
        }

        private void BtnTimeTableMenu_Click(object sender, EventArgs e)
        {
            BtnColor.Location = new System.Drawing.Point(8,138);
            Choose = 2;
            this.ValChange(Choose);
        }

        private void BtnChallengeMenu_Click(object sender, EventArgs e)
        {
            BtnColor.Location = new System.Drawing.Point(8, 193);
            Choose = 3;
            this.ValChange(Choose);
        }

        private void BtnMusicMenu_Click(object sender, EventArgs e)
        {
            BtnColor.Location = new System.Drawing.Point(8, 248);
            Choose = 4;
            this.ValChange(Choose);
        }
        private void BtnMethodMenu_Click_1(object sender, EventArgs e)
        {
            BtnColor.Location = new System.Drawing.Point(8, 302);
            Choose = 5;
            this.ValChange(Choose);
        }

        private void btnSettingMenu_Click(object sender, EventArgs e)
        {
            BtnColor.Location = new System.Drawing.Point(8, 358);
            Choose = 6;
            this.ValChange(Choose);
        }
        //end
        //Mong muốn : Khi người dùng chọn vào sẽ chuyển trang như ý muốn
        //Mục đích 1 :Khi người dùng chọn trang khác đứng
        //Mục đích 2 :Khi người dùng chọn label thoát -> Lấy biến và gán giá trị của biến cho biến là 1
        public TestMenu(ChooseMenu sender)
        {
            //Tạo Phương Thức Khởi tạo với biến delegate
            InitializeComponent();
            this.ValChange = sender;
        }
        // end
    }
}
