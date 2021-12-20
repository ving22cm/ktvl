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
using WMPLib;

namespace Project_1
{
    // Lấy dữ liệu từ Menu
    public delegate void ChooseMenu(int choose);
    //
    public partial class Main : Form
    {
        string n1_ng = "Hộp nhạc số 1.mp3", n1_txt = "Hộp nhạc số 1",
               n2_ng = "Hộp nhạc số 2.mp3", n2_txt = "Hộp nhạc số 2",
               n3_ng = "Hộp nhạc số 3.mp3", n3_txt = "Hộp nhạc số 3",
               n4_ng = "Hộp nhạc số 4.mp3", n4_txt = "Hộp nhạc số 4",
               n5_ng = "Hộp nhạc số 5.mp3", n5_txt = "Hộp nhạc số 5";

        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Main()
        {
            player.URL = n3_ng;
            InitializeComponent();
        }
        OpenFileDialog openFileDialog;
        private void Main_Load(object sender, EventArgs e)
        {
            
             player.controls.play();
        }
        // Chuyển Page
        private void RememberAd_Click(object sender, EventArgs e)
        {
            Menu2.SetPage(PageRemember);
        }
        
        private void TodolistAd_Click(object sender, EventArgs e)
        {
            Menu2.SetPage(PageToDoList);
        }

        private void ChallengeAd_Click(object sender, EventArgs e)
        {
            Menu2.SetPage(PageChallenge);
        }
        private void MusicAd_Click(object sender, EventArgs e)
        {

            Menu2.SetPage(PageMusic);
        }
        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Menu2.SetPage(PageSetting);
        }
        // Set Up Hiệu Ứng Cho Menu
        private void Menu4_Click(object sender, EventArgs e)
        {
            TestMenu tabwindow = new TestMenu(ChangePage);
            BunifuTransition trans = new BunifuTransition();
            Panel SpMenu = new Panel();
            SpMenu.Size = new Size(214, 535);
            SpMenu.Location = new Point(0, 0);
            SpMenu.BackColor = System.Drawing.Color.Transparent;
            this.PageChallenge.Controls.Add(SpMenu);
            tabwindow.Visible = false;
            SpMenu.Controls.Add(tabwindow);
            tabwindow.Width = 0;
            if (tabwindow.Width == 0)
            {
                tabwindow.Width = 214;
                SpMenu.BringToFront();// Mang lên nhất cho form đè các control cũ
                trans.ShowSync(tabwindow, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizSlide);
            }
        }
        
        private void Menu3_Click(object sender, EventArgs e)
        {
            TestMenu tabwindow = new TestMenu(ChangePage);
            BunifuTransition trans = new BunifuTransition();
            Panel SpMenu = new Panel();
            SpMenu.Size = new Size(214, 535);
            SpMenu.Location = new Point(0, 0);
            SpMenu.BackColor = System.Drawing.Color.Transparent;
            this.PageMusic.Controls.Add(SpMenu);
            tabwindow.Visible = false;
            SpMenu.Controls.Add(tabwindow);
            tabwindow.Width = 0;
            if (tabwindow.Width == 0)
            {
                tabwindow.Width = 214;
                SpMenu.BringToFront();// Mang lên nhất cho form đè các control cũ
                trans.ShowSync(tabwindow, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizSlide);
            }
        }

        private void Menu1_Click(object sender, EventArgs e)
        {
            TestMenu tabwindow = new TestMenu(ChangePage);
            BunifuTransition trans = new BunifuTransition();
            Panel SpMenu = new Panel();
            SpMenu.Size = new Size(214, 535);
            SpMenu.Location = new Point(0, 0);
            SpMenu.BackColor = System.Drawing.Color.Transparent;
            this.PageToDoList.Controls.Add(SpMenu);
            tabwindow.Visible = false;
            SpMenu.Controls.Add(tabwindow);
            tabwindow.Width = 0;
            if (tabwindow.Width == 0)
            {
                tabwindow.Width = 214;
                SpMenu.BringToFront(); // Mang lên nhất cho form đè các control cũ
                trans.ShowSync(tabwindow,false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizSlide);
            }
            
        }
        private void MenuRemember_Click(object sender, EventArgs e)
        {
            TestMenu tabwindow = new TestMenu(ChangePage);
            BunifuTransition trans = new BunifuTransition();
            Panel SpMenu = new Panel();
            SpMenu.Size = new Size(214, 535);
            SpMenu.Location = new Point(0, 0);
            SpMenu.BackColor = System.Drawing.Color.Transparent;
            this.PageRemember.Controls.Add(SpMenu);
            tabwindow.Visible = false;
            SpMenu.Controls.Add(tabwindow);
            tabwindow.Width = 0;
            if (tabwindow.Width == 0)
            {
                tabwindow.Width = 214;
                SpMenu.BringToFront();// Mang lên nhất cho form đè các control cũ
                trans.ShowSync(tabwindow, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.HorizSlide);
            }
        }

            //
        private void ChangePage(int choose)
        {
            if (choose == 1)
            {
                Menu2.SetPage(PageRemember);
            }
            else if (choose == 2)
            {
                Menu2.SetPage(PageToDoList);
            }
            else if (choose == 3)
            {
                Menu2.SetPage(PageChallenge);
            }
            else if (choose == 4)
            {
                Menu2.SetPage(PageMusic);
            }
            else if (choose == 6)
            {
                Menu2.SetPage(PageSetting);
            }
            else if (choose == 5)
            {
                Menu2.SetPage(PageMethod);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbNameMusic_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void lbNameRemember_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void PannelMusicRunning_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {
            
        }


       

        private void Playlist_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuVScrollBar3_Scroll(object sender, BunifuVScrollBar.ScrollEventArgs e)
        {

        }

        private void bunifuVScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void PageMusic_Click(object sender, EventArgs e)
        {

        }
        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int l1 = 0, l2 = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                guna2TrackBar1.Maximum = (int)player.controls.currentItem.duration;
                guna2TrackBar1.Value = (int)player.controls.currentPosition;
            }
            try
            {
                ltrackst.Text = player.controls.currentPositionString;
                ltracked.Text = player.controls.currentItem.durationString.ToString();
            }
            catch
            { }
        }

        private void volume_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
        {
            player.settings.volume = volume.Value;

        }

        private void nhac1_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            player.URL = n1_ng;
            player.controls.play();
            bunifuLabel2.Text = n1_txt;

        }

        private void nhac2_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            player.URL = n2_ng;
            player.controls.play();
            bunifuLabel2.Text = n2_txt;
        }

        private void nhac3_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            player.URL = n3_ng;
            player.controls.play();
            bunifuLabel2.Text = n3_txt;
        }

        private void nhac4_Click_1(object sender, EventArgs e)
        {
            player.controls.stop();
            player.URL = n4_ng;
            player.controls.play();
            bunifuLabel2.Text = n4_txt;
        }

        private void nhac5_Click_1(object sender, EventArgs e)
        {
            player.controls.stop();
            player.URL = n5_ng;
            player.controls.play();
            bunifuLabel2.Text = n5_txt;
        }

        bool mouse = false;
        private void guna2TrackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            player.controls.currentPosition = player.currentMedia.duration * e.X / guna2TrackBar1.Width;
           
        }

        private void guna2TrackBar1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse) return;
            player.controls.currentPosition = player.currentMedia.duration * e.X / guna2TrackBar1.Width;
        }

        private void guna2TrackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void tim_Click(object sender, EventArgs e)
        {
        
            l1 = l1 + 1;
            if (l1 % 2 == 1)
                tim.Image = Project_1.Properties.Resources.tim;
            else tim.Image = Project_1.Properties.Resources.tim2;
        }
        private void pause_Click(object sender, EventArgs e)
        {
            l2 = l2 + 1;
            if (l2 % 2 == 1)
            {
                pause.Image = Project_1.Properties.Resources.pau;
                player.controls.pause();
            }
            else
            {
                pause.Image = Project_1.Properties.Resources.dpa;
                player.controls.play();
            }
            }

       



        /*int i = 0, t = 0, j = -1, k = 2,d=0;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "mp3 files(*.mp3)|*.mp*";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Open";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                j = j + 1;
                //k=0;
                fd = openFileDialog.FileNames;//đường dẫn file
                fn = openFileDialog.SafeFileNames;//tên file
                foreach (var item in fn)
                {
                    this.listBox1.Items.Add(item);
                    k = k + 1;
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            i =i+1;
            if (i == 1 | t == 1) player.controls.stop();
            if (listBox1.SelectedIndex == 0)
            {
                axWindowsMediaPlayer1.URL = f1_p;
                t = 1;
                this.textBox1.Text = f1_n;
            }
            if (listBox1.SelectedIndex == 1)
            {
                axWindowsMediaPlayer1.URL = f2_p;
                t = 1;
                this.textBox1.Text = f2_n;
            }
            if (listBox1.SelectedIndex > 1)
            {
                if (j ==0) d = listBox1.SelectedIndex - 2;
                if (j!=0)  d = listBox1.SelectedIndex - k;
                t = 0;
   
                axWindowsMediaPlayer1.URL = fd[d];
                this.textBox1.Text = fn[d];
            }
               
          
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

      


        //
    }
}

