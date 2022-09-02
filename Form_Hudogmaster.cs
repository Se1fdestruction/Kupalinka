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

    /// </summary>
    public partial class Form_Hudogmaster : Form
    {



        public Form_Hudogmaster()
        {
            InitializeComponent();
        }


        SQLConnect sql = new SQLConnect();
        DataTable dt = new DataTable();
        public int buf_ID_MOD = 0;



        private void load_sql()
        {
            lb_model.Items.Clear();
            dt = sql.Execute_read("select ID_MOD,GOTOVO,HODOVAIA,MODEL,MODEL_ZAK,NI,AK,KIK,VREMA,SCALA,RAZMFIGURY1,RAZMFIGURY2,KOLLECIA,GOST,PRIMECANIE,IGLANOMER,VNIMANIE1,VNIMANIE2,NAIMK1,NAIMK2,TOBYNOMER,TOBYGOD,UTVERZDATA,VEDENIDATA,DATASOZDMOD,DRUGIEMODELI,HUDOZNIK,KONSTRUKTOR,TEHNOLOG,ASSORTIMENT,KUDAMODEL,SPECZAKAZKTO,GOST1,GOST2,GOST3,GOST4,GOST5,GOST6,NAIM1,NAIM2,NAIM3,NAIM4,NAIM5,NAIM6,POL1,POL2,POL3,POL4,POL5,POL6,POLO1,POLO2,POLO3,POLO4,POLO5,POLO6 from TOMODEL");
            //  dt = sql.Execute_read("select model from tomodel");
            lb_model.Items.Add("*Новая модель");
            foreach (DataRow dr in dt.Rows)
            {

                lb_model.Items.Add(dr["MODEL"].ToString());
            }
        }

        private void Lb_searh_TextChanged(object sender, EventArgs e)
        {
            lb_model.Items.Clear();
            lb_model.Items.Add("*Новая модель");
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["MODEL"].ToString().Contains(lb_searh.Text))
                {
                    lb_model.Items.Add(dt.Rows[i]["MODEL"].ToString());
                }
            }
        }

        private void Hudogmaster_Load(object sender, EventArgs e)
        {
            load_sql();

            //   this.Width = Screen.PrimaryScreen.WorkingArea.Width; //Раскрываем форму окна на весь экран(можно и так тоже)
            //   this.Height = Screen.PrimaryScreen.WorkingArea.Height; //Раскрываем форму окна на весь экран
            this.WindowState = FormWindowState.Maximized; //Раскрываем форму окна на весь экран



        }

        private void Lb_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_model.SelectedItem.ToString() == "*Новая модель")
            {
          
                lb_mod.Text = "";
                lb_ni.Text = "";
                
                lb_kudamodel.Text = "";
               
                lb_assortiment.Text = "";
                lb_scala.Text = "";
                lb_razmfigury1.Text = "";
                lb_razmfigury2.Text = "";
                lb_kollecia.Text = "";
                lb_pol1.Text = "";
                lb_pol2.Text = "";
                lb_pol3.Text = "";
                lb_pol4.Text = "";
                lb_pol5.Text = "";
                lb_pol6.Text = "";
                lb_polo1.Text = "";
                lb_polo2.Text = "";
                lb_polo3.Text = "";
                lb_polo4.Text = "";
                lb_polo5.Text = "";
                lb_polo6.Text = "";
           
          
            }
            else
            {
                foreach (DataRow dt in dt.Rows)
                {
                    if (dt["MODEL"].ToString() == lb_model.SelectedItem.ToString())
                    {
                        buf_ID_MOD = Convert.ToInt32(dt["ID_MOD"]);
                        lb_mod.Text = dt["MODEL"].ToString();
                        lb_ni.Text = dt["NI"].ToString();
                       
                        lb_kudamodel.Text = dt["KUDAMODEL"].ToString();
                        
                        lb_assortiment.Text = dt["ASSORTIMENT"].ToString();
                        lb_scala.Text = dt["SCALA"].ToString();
                        lb_razmfigury1.Text = dt["RAZMFIGURY1"].ToString();
                        lb_razmfigury2.Text = dt["RAZMFIGURY2"].ToString();
                        lb_kollecia.Text = dt["KOLLECIA"].ToString();
                        lb_pol1.Text = dt["POL1"].ToString();
                        lb_pol2.Text = dt["POL2"].ToString();
                        lb_pol3.Text = dt["POL3"].ToString();
                        lb_pol4.Text = dt["POL4"].ToString();
                        lb_pol5.Text = dt["POL5"].ToString();
                        lb_pol6.Text = dt["POL6"].ToString();
                        lb_polo1.Text = dt["POLO1"].ToString();
                        lb_polo2.Text = dt["POLO2"].ToString();
                        lb_polo3.Text = dt["POLO3"].ToString();
                        lb_polo4.Text = dt["POLO4"].ToString();
                        lb_polo5.Text = dt["POLO5"].ToString();
                        lb_polo6.Text = dt["POLO6"].ToString();

                        lb_id_mod.Text = dt["ID_MOD"].ToString(); //выводим текс из dataGridView1 ячейка 1 в label1

                    }
                }
            }
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {

           
            using (Form_Naimenovanieizd frm = new Form_Naimenovanieizd())//**********************
            {
                if (frm.ShowDialog() == DialogResult.OK)//************************
                    lb_ni.Text = frm.GetValueInForm2;//****************************
            }

        }


        void func(string param)
        {
            MessageBox.Show(param + "!");
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Hudogmaster_Activated(object sender, EventArgs e)
        {
 
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }

 
}
