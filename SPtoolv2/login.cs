using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPtoolv2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            sptool.claves.Add("User", User.Text);
            sptool.claves.Add("Pass", Pass.Text);
            login.ActiveForm.Close();
        }
    }
}
