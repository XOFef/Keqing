using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectIlosion
{
    public partial class circlesForm : Form
    {
        Image Ball;
        int speed = 1;
        int positionX = 1000;
        int height = 75;
        int width = 150;
        int Sref = (int)Math.Sqrt(Math.Pow(850 - 750, 2) + Math.Pow(350 - 350, 2));
        public circlesForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Ball = Image.FromFile("ball.png");
        }

        public void circlesForm_Paint(object sender, PaintEventArgs e)
        {

            Graphics ball1 = e.Graphics;
            ball1.DrawImage(Ball, 750, 350, 150, 75);

            Graphics ball2 = e.Graphics;
            ball2.DrawImage(Ball, 850, 350, 150, 75);

            Graphics scrollball = e.Graphics;
            scrollball.DrawImage(Ball, positionX, 350, width, height);


        }

        private void Curtail_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private static bool MAXIMIZED = false;

        private void Expand_Click(object sender, EventArgs e)
        {
            if (MAXIMIZED)
            {
                WindowState = FormWindowState.Normal;
                MAXIMIZED = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                MAXIMIZED = true;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Expand_Click_1(object sender, EventArgs e)
        {
            if (MAXIMIZED)
            {
                WindowState = FormWindowState.Normal;
                MAXIMIZED = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                MAXIMIZED = true;
            }
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Curtail_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void button3_Click(object sender, EventArgs e)
        {
           
            int Stest = Math.Max(0, (int)Math.Sqrt(Math.Pow(positionX - 850, 2) + Math.Pow(350 - 350, 2)) - (55 + 55)) ; 
            int result = Sref - Stest ;
 
            MessageBox.Show($"Ошибка: {result}");

            this.Hide();
            ChooseIllusion f2 = new ChooseIllusion();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            positionX-=10;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            positionX+= 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }


      




    }
}
