using Online_Store.Properties;
using profile;
using show_screen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Online_Store
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public  void DarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkMode.Checked)
            {
            }
            Program.darkmode = !Program.darkmode;

            DarkMode.ForeColor = Color.White;

        }
    }
}
