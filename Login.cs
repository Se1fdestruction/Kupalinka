using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kupalinka
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form_Menu fr = new Form_Menu();
            fr.Show();
            this.Hide();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
