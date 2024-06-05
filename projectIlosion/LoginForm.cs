using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            GenderBox.Items.AddRange(new string[] { "М", "Ж" });
            AgeBox.Items.AddRange(new string[] { "16", "17", "18", "19", "20", "21", "22", "23", "24", "25",
            "26", "27","28", "29","30", "31","32", "33","34", "35","36", "37","38", "39","40", "41",
            "42", "43","44", "45","46", "47","48", "49","50", "51","52", "53","54", "55", "56", "57",
            "58", "59","60", "61","62", "63","64", "65","66", "67","68", "69","70"});

            LastName.MaxLength = 100;


            FirstName.MaxLength = 100;


            Patronymic.MaxLength = 100;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }


        Point lastpoint;

        private void paneldown_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void paneldown_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String lastname = LastName.Text;
            String firstname = FirstName.Text;
            String patronymic = Patronymic.Text;
            String age = AgeBox.Text;
            String gender = GenderBox.Text;

            //DB db = new DB();

            //MySqlCommand command = new MySqlCommand("INSERT INTO `useres` (`LastName`, `FirstName`, `Patronymic`, `Age`, `Gender`) " +
            //    "VALUES (@LN, @FN, @Pt, @Ag, @Gd);", db.getConnection());

            //command.Parameters.Add("@LN", MySqlDbType.VarChar).Value = lastname;
            //command.Parameters.Add("@FN", MySqlDbType.VarChar).Value = firstname;
            //command.Parameters.Add("@Pt", MySqlDbType.VarChar).Value = patronymic;
            //command.Parameters.Add("@Ag", MySqlDbType.VarChar).Value = age;
            //command.Parameters.Add("@Gd", MySqlDbType.VarChar).Value = gender;

            //db.openConnection();

            //command.ExecuteNonQuery();

            //db.closeConnection();

            this.Hide();
            ChooseIllusion f2 = new ChooseIllusion();
            f2.ShowDialog();
        }
    }
}
