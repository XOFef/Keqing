using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectIlosion
{
    public partial class VerticalHorizontalIllusion : Form
    {
        private float angle = 0; // Угол между линиями
        public VerticalHorizontalIllusion()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Button rotateButton = new Button();
            rotateButton.Text = "Повернуть";
            rotateButton.Click += new EventHandler(RotateButton_Click);
            rotateButton.Dock = DockStyle.Bottom;
            this.Controls.Add(rotateButton);
        }





        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static bool MAXIMIZED = true;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);

            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            // Задаем длину горизонтальной линии
            int horizontalLineLength = 500;

            // Рассчитываем начальную и конечную точки горизонтальной линии
            int horizontalLineStartX = (width - horizontalLineLength) / 2;
            int horizontalLineEndX = horizontalLineStartX + horizontalLineLength;
            int horizontalLineY = height / 2 + 150;

            // Рисуем горизонтальную линию
            g.DrawLine(pen, horizontalLineStartX, horizontalLineY, horizontalLineEndX, horizontalLineY);

            // На краю середины горизонтальной линии рисуем вертикальную линию
            int verticalLineStartY = horizontalLineY - 500; // Половина длины горизонтальной линии
            int verticalLineEndY = verticalLineStartY + 500; // Длина вертикальной линии
            int verticalLineX = width / 2;
            g.DrawLine(pen, verticalLineX, verticalLineStartY, verticalLineX, verticalLineEndY);
            Matrix transformMatrix = new Matrix();
            transformMatrix.RotateAt(angle, new PointF(verticalLineX, verticalLineStartY));
            g.Transform = transformMatrix;

            g.DrawLine(pen, horizontalLineStartX, horizontalLineY, horizontalLineEndX, horizontalLineY);
            g.DrawLine(pen, verticalLineX, verticalLineStartY, verticalLineX, verticalLineEndY);
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            angle += 10; // Увеличиваем угол поворота на 10 градусов
            this.Invalidate(); // Перерисовываем форму
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
