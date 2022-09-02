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
    public partial class Form_Cfl : Form
    {
        public Form_Cfl()
        {
            InitializeComponent();
        }
        SQLConnect sql = new SQLConnect();
        DataTable dt = new DataTable();
        public int buf_ID_ARTPOL; //= 0;
        private void load_sql()
        {
            lb_artikul.Items.Clear();
            dt = sql.Execute_read("select ID,ARTPOL,NAIMPOL,GRUPPA,VKVO,VLPP,NP,PPPDO,NVP,RNPSH,PROCP1,PROCPNAIM1,PROCP2,PROCPNAIM2,PROCP3,PROCPNAIM3,PROCP4,PROCPNAIM4 from POLOTNO");
            //  dt = sql.Execute_read("select model from tomodel");
            lb_artikul.Items.Add("*Новый артикул");
            foreach (DataRow dr in dt.Rows)
            {

                lb_artikul.Items.Add(dr["ARTPOL"].ToString());
            }

        }
        private void Cfl_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            load_sql();
        }

        private void Lb_searh_TextChanged(object sender, EventArgs e)
        {
            lb_artikul.Items.Clear();
            lb_artikul.Items.Add("*Новый артикул");
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["ARTPOL"].ToString().Contains(lb_searh.Text))
                {
                    lb_artikul.Items.Add(dt.Rows[i]["ARTPOL"].ToString());
                }
            }
        }

        private void Lb_artikul_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_artikul.SelectedItem.ToString() == "*Новый артикул")
            {

                lb_artpol.Text = "";
                lb_naimpol.Text = "";
                lb_gruppa.Text = "";
                lb_vkvo.Text = "";
                lb_vlpp.Text = "";
                lb_np.Text = "";
                lb_pppdo.Text = "";
                lb_nvp.Text = "";
                lb_rnpsh.Text = "";
                lb_procp1.Text = "";
                lb_procp2.Text = "";
                lb_procp4.Text = "";
                lb_procpnaim1.Text = "";
                lb_procpnaim2.Text = "";
                lb_procpnaim3.Text = "";
                lb_procpnaim4.Text = "";          
            }
            else
            {
                foreach (DataRow dt in dt.Rows)
                {
                    if (dt["ARTPOL"].ToString() == lb_artikul.SelectedItem.ToString())
                    {
                        buf_ID_ARTPOL = Convert.ToInt32(dt["ID"]);
                        lb_artpol.Text = dt["ARTPOL"].ToString();
                        lb_naimpol.Text = dt["NAIMPOL"].ToString();
                        lb_gruppa.Text = dt["GRUPPA"].ToString();
                        lb_vkvo.Text = dt["VKVO"].ToString();
                        lb_vlpp.Text = dt["VLPP"].ToString();
                        lb_np.Text = dt["NP"].ToString();
                        lb_pppdo.Text = dt["PPPDO"].ToString();
                        lb_nvp.Text = dt["NVP"].ToString();
                        lb_rnpsh.Text = dt["RNPSH"].ToString();
                        lb_procp1.Text = dt["PROCP1"].ToString();
                        lb_procp2.Text = dt["PROCP2"].ToString();
                        lb_procp3.Text = dt["PROCP3"].ToString();
                        lb_procp4.Text = dt["PROCP4"].ToString();
                        lb_procpnaim1.Text = dt["PROCPNAIM1"].ToString();
                        lb_procpnaim2.Text = dt["PROCPNAIM2"].ToString();
                        lb_procpnaim3.Text = dt["PROCPNAIM3"].ToString();
                        lb_procpnaim4.Text = dt["PROCPNAIM4"].ToString(); 
                        //lb_id_artpol.Text = dt["ID"].ToString(); //выводим текс из dataGridView1 ячейка 1 в label1
                    }
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить артикул?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (lb_artikul.SelectedItem.ToString() == "*Новый артикул")
                {
                    sql.Execute_write("INSERT INTO POLOTNO (ARTPOL,NAIMPOL,GRUPPA,VKVO,VLPP,NP,PPPDO,NVP,RNPSH,PROCP1,PROCP2,PROCP3,PROCP4,PROCPNAIM1,PROCPNAIM2,PROCPNAIM3,PROCPNAIM4) values ('"
                                                                      + lb_artpol.Text + "','"
                                                                      + lb_naimpol.Text + "','"
                                                                      + lb_gruppa.Text + "','"
                                                                      + lb_vkvo.Text + "','"
                                                                      + lb_vlpp.Text + "', '"
                                                                      + lb_np.Text + "', '"
                                                                      + lb_pppdo.Text + "', '"
                                                                      + lb_nvp.Text + "', '"
                                                                      + lb_rnpsh.Text + "', '"
                                                                      + lb_procp1.Text + "', '"
                                                                      + lb_procp2.Text + "', '"
                                                                      + lb_procp3.Text + "', '"
                                                                      + lb_procp4.Text + "', '"
                                                                      + lb_procpnaim1.Text + "', '"
                                                                      + lb_procpnaim2.Text + "', '"
                                                                      + lb_procpnaim3.Text + "', '"
                                                                      + lb_procpnaim4.Text + "')");



                }
                else
                {


            
                    sql.Execute_write("UPDATE POLOTNO set  ARTPOL='" + lb_artpol.Text + "', NAIMPOL='"
                                                                 + lb_naimpol.Text + "', GRUPPA='"
                                                                 + lb_gruppa.Text + "', VKVO='"
                                                                 + lb_vkvo.Text + "', VLPP='"
                                                                 + lb_vlpp.Text + "', NP='"
                                                                 + lb_np.Text + "', PPPDO='"
                                                                 + lb_pppdo.Text + "',  NVP='"
                                                                 + lb_nvp.Text + "', RNPSH='"
                                                                 + lb_rnpsh.Text + "', PROCP1='"
                                                                 + lb_procp1.Text + "', PROCP2='"
                                                                 + lb_procp2.Text + "', PROCP3='"
                                                                 + lb_procp3.Text + "', PROCP4='"
                                                                 + lb_procp4.Text + "', PROCPNAIM1='"
                                                                 + lb_procpnaim1.Text + "', PROCPNAIM2='"
                                                                 + lb_procpnaim2.Text + "', PROCPNAIM3='"
                                                                 + lb_procpnaim3.Text + "', PROCPNAIM4='"
                                                                 + lb_procpnaim4.Text + "' where ID='" + buf_ID_ARTPOL + "';");

                }
            }
            else if (result == DialogResult.No)
            {

            }
            load_sql();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            load_sql();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить артикул полотна?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (lb_artikul.SelectedItem.ToString() != "*Новый артикул")
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
    }
}
