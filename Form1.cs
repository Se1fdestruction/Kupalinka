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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SQLConnect sql = new SQLConnect();
        WorkDBF wdbf = new WorkDBF();
        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
