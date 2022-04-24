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

        private void button3_Click(object sender, EventArgs e)
        {
            // 프로세스 종료 문제
            Application.Exit();
        }
    }
}
