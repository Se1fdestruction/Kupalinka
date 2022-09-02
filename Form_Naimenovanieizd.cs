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
    public partial class Form_Naimenovanieizd : Form

    {
        public string GetValueInForm2//Добавление наименования в форму 1
        {
            get//****************************
            {
                return lb_ni1.Text;//**************************
            }
        }

        public Form_Naimenovanieizd()
        {
            InitializeComponent();

        }



      
        SQLConnect sql = new SQLConnect();
        DataTable nz = new DataTable();


        private void load_sql()
        {
            lb_naimizd.Items.Clear();
            nz = sql.Execute_read("select KOD,NAIMENOVANIE from NAIMIZD");

            foreach (DataRow dr in nz.Rows)
            {
                lb_naimizd.Items.Add(dr["NAIMENOVANIE"].ToString());
            }
        }
        private void Naimenovanieizd_Load(object sender, EventArgs e)
        {
            load_sql();
        }

        private void Lb_naimizd_SelectedIndexChanged(object sender, EventArgs e)
        {
                foreach (DataRow dt in nz.Rows)
                {
                    if (dt["NAIMENOVANIE"].ToString() == lb_naimizd.SelectedItem.ToString())
                    {
                        lb_ni1.Text = dt["NAIMENOVANIE"].ToString();
                    }
                }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            lb_naimizd.Items.Clear();
          
            for (int i = 0; i < nz.Rows.Count -1; i++)
            {
                if (nz.Rows[i]["NAIMENOVANIE"].ToString().ToLower().Contains(lb_searh.Text.ToLower()))
                {
                    lb_naimizd.Items.Add(nz.Rows[i]["NAIMENOVANIE"].ToString());
                }
            }
        }
    }
}
