using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectIlosion
{
    public partial class ChooseIllusion : Form
    {
        public ChooseIllusion()
        {
            InitializeComponent();
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Curtail_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }




        Point lastpoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void labelup_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void labelup_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void circlesbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            circlesForm f2 = new circlesForm();
            f2.ShowDialog();
        }
    }
}
