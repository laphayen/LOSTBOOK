using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOSTBOOK
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            
        }

        private void form_Closing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetTop_Click(object sender, EventArgs e)
        {
            // 항상 위 고정 버튼
            this.TopMost ^= true;
            
            /*
             * 고정 버튼 클릭 시 이미지 변경 오류
            int flag = 1;
            flag *= -1;
            if (flag == -1)
            {
                Bitmap b1 = new Bitmap(@"C:\Users\NATHAN\source\repos\LOSTBOOK\Properties\p1.png");
                buttonSetTop.Image = b1;
            }
            else
            {
                Bitmap b2 = new Bitmap(@"C:\Users\NATHAN\source\repos\LOSTBOOK\Properties\p2.png");
                buttonSetTop.Image = b2;
            }
            */

        }

        private void buttonPowerOff_Click(object sender, EventArgs e)
        {
            // 프로세스 종료 문제
            Application.Exit();
        }

        // 마우스 포인트 추가
        private Point point = new Point();
         

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonPlusUnit_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
