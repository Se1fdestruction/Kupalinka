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
    public partial class Form_KorTomodel : Form
    {
        public Form_KorTomodel()
        {
            InitializeComponent();
        }
        SQLConnect sql = new SQLConnect();
        DataTable dt = new DataTable();
        public int buf_ID_MOD; //= 0;
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            load_sql();
        }
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
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

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Lb_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_model.SelectedItem.ToString() == "*Новая модель")
            {
               // buf_ID_MOD = 0;
                lb_mod.Text = "";
                lb_ni.Text = "";
                lb_gost.Text = "";
                lb_mod_zak.Text = "";
                lb_kudamodel.Text = "";
                lb_speczakazkto.Text = "";
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
                lb_naimk1.Text = "";
                lb_naimk2.Text = "";
                lb_primecanie.Text = "";
                lb_vnimanie1.Text = "";
                lb_vnimanie2.Text = "";
                lb_vedenidata.Text = "";
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
                        lb_gost.Text = dt["GOST"].ToString();
                        lb_mod_zak.Text = dt["MODEL_ZAK"].ToString();
                        lb_kudamodel.Text = dt["KUDAMODEL"].ToString();
                        lb_speczakazkto.Text = dt["SPECZAKAZKTO"].ToString(); 
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
                        lb_naimk1.Text = dt["NAIMK1"].ToString();
                        lb_naimk2.Text = dt["NAIMK2"].ToString();
                        lb_primecanie.Text = dt["PRIMECANIE"].ToString();
                        lb_vnimanie1.Text = dt["VNIMANIE1"].ToString();
                        lb_vnimanie2.Text = dt["VNIMANIE2"].ToString();
                        lb_vedenidata.Text = dt["VEDENIDATA"].ToString();


                        lb_id_mod.Text = dt["ID_MOD"].ToString(); //выводим текс из dataGridView1 ячейка 1 в label1

                    }
                }
            }
        }

        private void Lb_kik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить модель?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (lb_model.SelectedItem.ToString() == "*Новая модель")
                // if (lb_model.SelectedItem.ToString() != "*Новая модель")
                {
                    sql.Execute_write("INSERT INTO TOMODEL (MODEL,NI,GOST,MODEL_ZAK,KUDAMODEL,SPECZAKAZKTO,ASSORTIMENT,SCALA,RAZMFIGURY1,RAZMFIGURY2,KOLLECIA,POL1,POL2,POL3,POL4,POL5,POL6,POLO1,POLO2,POLO3,POLO4,POLO5,POLO6,NAIMK1,NAIMK2,PRIMECANIE,VNIMANIE1,VNIMANIE2) values ('"
                                                                      + lb_mod.Text + "','"
                                                                      + lb_ni.Text + "','"
                                                                      + lb_gost.Text + "','"
                                                                      + lb_mod_zak.Text + "','"
                                                                      + lb_kudamodel.Text + "', '"
                                                                      + lb_speczakazkto.Text + "', '"
                                                                      + lb_assortiment.Text + "', '"
                                                                      + lb_scala.Text + "', '"
                                                                      + lb_razmfigury1.Text + "', '"
                                                                      + lb_razmfigury2.Text + "', '"
                                                                      + lb_kollecia.Text + "', '"
                                                                      + lb_pol1.Text + "', '"
                                                                      + lb_pol2.Text + "', '"
                                                                      + lb_pol3.Text + "', '"
                                                                      + lb_pol4.Text + "', '"
                                                                      + lb_pol5.Text + "', '"
                                                                      + lb_pol6.Text + "', '"
                                                                      + lb_polo1.Text + "', '"
                                                                      + lb_polo2.Text + "', '"
                                                                      + lb_polo3.Text + "', '"
                                                                      + lb_polo4.Text + "', '"
                                                                      + lb_polo5.Text + "', '"
                                                                      + lb_polo6.Text + "', '"
                                                                      + lb_naimk1.Text + "', '"
                                                                      + lb_naimk2.Text + "', '"
                                                                      + lb_primecanie.Text + "', '"
                                                                      + lb_vnimanie1.Text + "', '"
                                                                      + lb_vnimanie2.Text + "', '"
                                                                      + lb_vedenidata.Text + "')");



                }
                else
                {


                    //   sql.Execute_write("UPDATE TOMODEL set MODEL='" + lb_mod.Text + "', NI='"
                    sql.Execute_write("UPDATE TOMODEL set  NI='" + lb_ni.Text + "', GOST='"
                                                                 + lb_gost.Text + "', MODEL_ZAK='"
                                                                 + lb_mod_zak.Text + "', KUDAMODEL='"
                                                                 + lb_kudamodel.Text + "', SPECZAKAZKTO='"
                                                                 + lb_speczakazkto.Text + "', ASSORTIMENT='"
                                                                 + lb_assortiment.Text + "', SCALA='"
                                                                 + lb_scala.Text + "',  RAZMFIGURY1='"
                                                                 + lb_razmfigury1.Text + "', RAZMFIGURY2='"
                                                                 + lb_razmfigury2.Text + "', KOLLECIA='"
                                                                 + lb_kollecia.Text + "', POL1='"
                                                                 + lb_pol1.Text + "', POL2='"
                                                                 + lb_pol2.Text + "', POL3='"
                                                                 + lb_pol3.Text + "', POL4='"
                                                                 + lb_pol4.Text + "', POL5='"
                                                                 + lb_pol5.Text + "', POL6='"
                                                                 + lb_pol6.Text + "', POLO1='"
                                                                 + lb_polo1.Text + "', POLO2='"
                                                                 + lb_polo2.Text + "', POLO3='"
                                                                 + lb_polo3.Text + "', POLO4='"
                                                                 + lb_polo4.Text + "', POLO5='"
                                                                 + lb_polo5.Text + "', POLO6='"
                                                                 + lb_polo6.Text + "', NAIMK1='"
                                                                 + lb_naimk1.Text + "', NAIMK2='"
                                                                 + lb_naimk2.Text + "', PRIMECANIE='"
                                                                 + lb_primecanie.Text + "', VNIMANIE1='"
                                                                 + lb_vnimanie1.Text + "', VNIMANIE2='"
                                                                 + lb_vnimanie2.Text + "', VEDENIDATA='"
                                                                 + lb_vedenidata.Text + "' where ID_MOD ='" + buf_ID_MOD + "';");

                }
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить модель?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (lb_model.SelectedItem.ToString() != "*Новая модель")
                {
                    sql.Execute_write("delete from TOMODEL where ID_MOD='" + buf_ID_MOD + "'");
                }
                load_sql(); 
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void But_refresh_Click(object sender, EventArgs e)
        {
            load_sql();
        }

        private void Lb_mod_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lb_gost1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Lb_naimk_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form_Tomodel fr = new Form_Tomodel();
            fr.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (Form_Naimenovanieizd frm = new Form_Naimenovanieizd())//**********************
            {
                if (frm.ShowDialog() == DialogResult.OK)//************************
                    lb_ni.Text = frm.GetValueInForm2;//****************************
            }
        }

        private void Lb_vedenidata_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label23_Click(object sender, EventArgs e)
        {

        }
    }

    //if (lb_model.Items.Count != 0)
    //{
    //    lb_model.SelectedIndex = 0;



}
    //   private void TextBox1_MouseClick(object sender, MouseEventArgs e)
    //    {

    //    }

    //   private void GroupBox1_Enter(object sender, EventArgs e)
    //   {

    //   }



