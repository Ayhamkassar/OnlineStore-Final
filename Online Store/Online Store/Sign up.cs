using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_market_applicatinon_v2
{
    public partial class Sign_up : Form
    {
        public static string pass = "";
        public static string name = "";
        public Sign_up()
        {
            InitializeComponent();
        }

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            if (password.Text.Length < 8 || signup_name.Text.Length < 4)
            {
                if (password.Text.Length < 8)
                    MessageBox.Show("sorry, But the the password is too short", "Error");
                if (signup_name.Text.Length < 4)
                    MessageBox.Show("sorry, But the the username is too short", "Error");
            }
            else
            {
                name = signup_name.Text;

                if (password.Text == confirmation.Text)
                {
                    pass = confirmation.Text;
                    MessageBox.Show("Congarts, now you have an eamil on the application","yahoo!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("no match between the password and the confirmation", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            signup_name.Text = null;
            password.Text = null;
            confirmation.Text = null;
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            Log_in newe = new Log_in();

            newe.Show();
            this.Close();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}