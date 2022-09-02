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
    public partial class Form_Menu : Form
    {
        
        public Form_Menu()
        {
            InitializeComponent();            
        }
        SQLConnect sql = new SQLConnect();
        DataTable hm = new DataTable();
        DataTable pl = new DataTable();
        public int bufhm_ID_MOD;
        public int buf_ID_ARTPOL;
        private void load_sql()
        {
            hm_model.Items.Clear();
            hm = sql.Execute_read("select ID_MOD,GOTOVO,HODOVAIA,MODEL,MODEL_ZAK,NI,AK,KIK,VREMA,SCALA,RAZMFIGURY1,RAZMFIGURY2,KOLLECIA,GOST,PRIMECANIE,IGLANOMER,VNIMANIE1,VNIMANIE2,NAIMK1,NAIMK2,TOBYNOMER,TOBYGOD,UTVERZDATA,VEDENIDATA,DATASOZDMOD,DRUGIEMODELI,HUDOZNIK,KONSTRUKTOR,TEHNOLOG,ASSORTIMENT,KUDAMODEL,SPECZAKAZKTO,GOST1,GOST2,GOST3,GOST4,GOST5,GOST6,NAIM1,NAIM2,NAIM3,NAIM4,NAIM5,NAIM6,POL1,POL2,POL3,POL4,POL5,POL6,POLO1,POLO2,POLO3,POLO4,POLO5,POLO6 from TOMODEL");
            //  hm = sql.Execute_read("select model from tomodel");
            hm_model.Items.Add("*Новая модель");
            foreach (DataRow dr in hm.Rows)
            {

                hm_model.Items.Add(dr["MODEL"].ToString());
            }

            pl_artikul.Items.Clear();
            pl = sql.Execute_read("select ID,ARTPOL,NAIMPOL,GRUPPA,VKVO,VLPP,NP,PPPDO,NVP,RNPSH,PROCP1,PROCPNAIM1,PROCP2,PROCPNAIM2,PROCP3,PROCPNAIM3,PROCP4,PROCPNAIM4 from POLOTNO");
            pl_artikul.Items.Add("*Новый артикул");
            foreach (DataRow dr in pl.Rows)
            {

                pl_artikul.Items.Add(dr["ARTPOL"].ToString());
            }
        }
        private void СправочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ТехнологическоеОписаниеМоделиТОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Tomodel fr = new Form_Tomodel();
            fr.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void СозданиеНовойМоделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Hudogmaster fr = new Form_Hudogmaster();
            fr.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            load_sql();
            this.WindowState = FormWindowState.Maximized; //Раскрываем форму окна на весь экран

        }

        private void СправочникПолотнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cfl fl = new Form_Cfl();
            fl.Show();
        }

        private void ОперацииПошиваToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ОперцийToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void hm_searh_TextChanged(object sender, EventArgs e)
        {
            hm_model.Items.Clear();
            hm_model.Items.Add("*Новая модель");
            for (int i = 1; i < hm.Rows.Count; i++)
            {
                if (hm.Rows[i]["MODEL"].ToString().Contains(hm_searh.Text))
                {
                    hm_model.Items.Add(hm.Rows[i]["MODEL"].ToString());
                }
            }
        }

        private void hm_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hm_model.SelectedItem.ToString() == "*Новая модель")
            {

                hm_mod.Text = "";
                hm_ni.Text = "";

                hm_kudamodel.Text = "";

                hm_assortiment.Text = "";
                hm_scala.Text = "";
                hm_razmfigury1.Text = "";
                hm_razmfigury2.Text = "";
                hm_kollecia.Text = "";
                hm_pol1.Text = "";
                hm_pol2.Text = "";
                hm_pol3.Text = "";
                hm_pol4.Text = "";
                hm_pol5.Text = "";
                hm_pol6.Text = "";
                hm_polo1.Text = "";
                hm_polo2.Text = "";
                hm_polo3.Text = "";
                hm_polo4.Text = "";
                hm_polo5.Text = "";
                hm_polo6.Text = "";


            }
            else
            {
                foreach (DataRow hm in hm.Rows)
                {
                    if (hm["MODEL"].ToString() == hm_model.SelectedItem.ToString())
                    {
                        bufhm_ID_MOD = Convert.ToInt32(hm["ID_MOD"]);
                        hm_mod.Text = hm["MODEL"].ToString();
                        hm_ni.Text = hm["NI"].ToString();

                        hm_kudamodel.Text = hm["KUDAMODEL"].ToString();

                        hm_assortiment.Text = hm["ASSORTIMENT"].ToString();
                        hm_scala.Text = hm["SCALA"].ToString();
                        hm_razmfigury1.Text = hm["RAZMFIGURY1"].ToString();
                        hm_razmfigury2.Text = hm["RAZMFIGURY2"].ToString();
                        hm_kollecia.Text = hm["KOLLECIA"].ToString();
                        hm_pol1.Text = hm["POL1"].ToString();
                        hm_pol2.Text = hm["POL2"].ToString();
                        hm_pol3.Text = hm["POL3"].ToString();
                        hm_pol4.Text = hm["POL4"].ToString();
                        hm_pol5.Text = hm["POL5"].ToString();
                        hm_pol6.Text = hm["POL6"].ToString();
                        hm_polo1.Text = hm["POLO1"].ToString();
                        hm_polo2.Text = hm["POLO2"].ToString();
                        hm_polo3.Text = hm["POLO3"].ToString();
                        hm_polo4.Text = hm["POLO4"].ToString();
                        hm_polo5.Text = hm["POLO5"].ToString();
                        hm_polo6.Text = hm["POLO6"].ToString();

                        hm_id_mod.Text = hm["ID_MOD"].ToString(); //выводим текс из dataGridView1 ячейка 1 в label1

                    }
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (Form_Naimenovanieizd frm = new Form_Naimenovanieizd())//**********************
            {
                if (frm.ShowDialog() == DialogResult.OK)//************************
                    hm_ni.Text = frm.GetValueInForm2;//****************************
            }

        }
 void func(string param)
        {
            MessageBox.Show(param + "!");
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            pl_artikul.Items.Clear();
            pl_artikul.Items.Add("*Новый артикул");
            for (int i = 1; i < pl.Rows.Count; i++)
            {
                if (pl.Rows[i]["ARTPOL"].ToString().Contains(pl_searh.Text))
                {
                    pl_artikul.Items.Add(pl.Rows[i]["ARTPOL"].ToString());
                }
            }
        }

        private void hm_artikul_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pl_artikul.SelectedItem.ToString() == "*Новый артикул")
            {

                pl_artpol.Text = "";
                pl_naimpol.Text = "";
                pl_gruppa.Text = "";
                pl_vkvo.Text = "";
                pl_vlpp.Text = "";
                pl_np.Text = "";
                pl_pppdo.Text = "";
                pl_nvp.Text = "";
                pl_rnpsh.Text = "";
                pl_procp1.Text = "";
                pl_procp2.Text = "";
                pl_procp4.Text = "";
                pl_procpnaim1.Text = "";
                pl_procpnaim2.Text = "";
                pl_procpnaim3.Text = "";
                pl_procpnaim4.Text = "";
            }
            else
            {
                foreach (DataRow dt in pl.Rows)
                {
                    if (dt["ARTPOL"].ToString() == pl_artikul.SelectedItem.ToString())
                    {
                        buf_ID_ARTPOL = Convert.ToInt32(dt["ID"]);
                        pl_artpol.Text = dt["ARTPOL"].ToString();
                        pl_naimpol.Text = dt["NAIMPOL"].ToString();
                        pl_gruppa.Text = dt["GRUPPA"].ToString();
                        pl_vkvo.Text = dt["VKVO"].ToString();
                        pl_vlpp.Text = dt["VLPP"].ToString();
                        pl_np.Text = dt["NP"].ToString();
                        pl_pppdo.Text = dt["PPPDO"].ToString();
                        pl_nvp.Text = dt["NVP"].ToString();
                        pl_rnpsh.Text = dt["RNPSH"].ToString();
                        pl_procp1.Text = dt["PROCP1"].ToString();
                        pl_procp2.Text = dt["PROCP2"].ToString();
                        pl_procp3.Text = dt["PROCP3"].ToString();
                        pl_procp4.Text = dt["PROCP4"].ToString();
                        pl_procpnaim1.Text = dt["PROCPNAIM1"].ToString();
                        pl_procpnaim2.Text = dt["PROCPNAIM2"].ToString();
                        pl_procpnaim3.Text = dt["PROCPNAIM3"].ToString();
                        pl_procpnaim4.Text = dt["PROCPNAIM4"].ToString();
                        pl_id_artpol.Text = dt["ID"].ToString(); //выводим текс из dataGridView1 ячейка 1 в label1
                    }
                }
            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить артикул?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (pl_artikul.SelectedItem.ToString() == "*Новый артикул")
                {
                    sql.Execute_write("INSERT INTO POLOTNO (ARTPOL,NAIMPOL,GRUPPA,VKVO,VLPP,NP,PPPDO,NVP,RNPSH,PROCP1,PROCP2,PROCP3,PROCP4,PROCPNAIM1,PROCPNAIM2,PROCPNAIM3,PROCPNAIM4) values ('"
                                                                      + pl_artpol.Text + "','"
                                                                      + pl_naimpol.Text + "','"
                                                                      + pl_gruppa.Text + "','"
                                                                      + pl_vkvo.Text + "','"
                                                                      + pl_vlpp.Text + "', '"
                                                                      + pl_np.Text + "', '"
                                                                      + pl_pppdo.Text + "', '"
                                                                      + pl_nvp.Text + "', '"
                                                                      + pl_rnpsh.Text + "', '"
                                                                      + pl_procp1.Text + "', '"
                                                                      + pl_procp2.Text + "', '"
                                                                      + pl_procp3.Text + "', '"
                                                                      + pl_procp4.Text + "', '"
                                                                      + pl_procpnaim1.Text + "', '"
                                                                      + pl_procpnaim2.Text + "', '"
                                                                      + pl_procpnaim3.Text + "', '"
                                                                      + pl_procpnaim4.Text + "')");



                }
                else
                {
                    sql.Execute_write("UPDATE POLOTNO set  ARTPOL='" + pl_artpol.Text + "', NAIMPOL='"
                                                                 + pl_naimpol.Text + "', GRUPPA='"
                                                                 + pl_gruppa.Text + "', VKVO='"
                                                                 + pl_vkvo.Text + "', VLPP='"
                                                                 + pl_vlpp.Text + "', NP='"
                                                                 + pl_np.Text + "', PPPDO='"
                                                                 + pl_pppdo.Text + "',  NVP='"
                                                                 + pl_nvp.Text + "', RNPSH='"
                                                                 + pl_rnpsh.Text + "', PROCP1='"
                                                                 + pl_procp1.Text + "', PROCP2='"
                                                                 + pl_procp2.Text + "', PROCP3='"
                                                                 + pl_procp3.Text + "', PROCP4='"
                                                                 + pl_procp4.Text + "', PROCPNAIM1='"
                                                                 + pl_procpnaim1.Text + "', PROCPNAIM2='"
                                                                 + pl_procpnaim2.Text + "', PROCPNAIM3='"
                                                                 + pl_procpnaim3.Text + "', PROCPNAIM4='"
                                                                 + pl_procpnaim4.Text + "' where ID='" + buf_ID_ARTPOL + "';");
                }
            }
                 else if (result == DialogResult.No)
            {

            }
            load_sql();
        }

        private void Button19_Click(object sender, EventArgs e)
        {

        }

        private void Button18_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить артикул полотна?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (pl_artikul.SelectedItem.ToString() != "*Новый артикул")
                {
                    sql.Execute_write("delete from POLOTNO where ID='" + buf_ID_ARTPOL + "'");
                }
                load_sql();
            }
            else if (result == DialogResult.No)
            {

            }
            load_sql();
        }

        private void ОперацииПошиваV1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Operaciiposhiva fr = new Form_Operaciiposhiva();
            fr.Show();
        }

        private void ОперацииПошиваV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_OperaciiposhivaV2 fr = new Form_OperaciiposhivaV2();
            fr.Show();
        }

        private void Form_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
