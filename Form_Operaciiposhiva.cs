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
    public partial class Form_Operaciiposhiva : Form
    {

        public Form_Operaciiposhiva()
        {
            InitializeComponent();
        }
        SQLConnect sql = new SQLConnect();
        DataTable dt = new DataTable();
        public int buf_ID_OPER; //= 0;

        float a;
        float c;
        float e;
        float f;
        float g;
        float h;
        float i;
        float k;
        float d;
        float b;
        float l;

        private void calc()
        {

            try
            {
                a = float.Parse(lb_vremishodoper.Text);
                c = float.Parse(lb_ruchnoevrema.Text);
                e = float.Parse(lb_oborudvrem.Text);
                f = float.Parse(lb_popravvrem1.Text);
                g = float.Parse(lb_popravvrem2.Text);
                h = float.Parse(lb_popravvrem3.Text);
                i = float.Parse(lb_popravvrem4.Text);
                k = float.Parse(lb_popravvrem5.Text);
                d = float.Parse(lb_polotnokoeficient.Text);
                b = float.Parse(lb_koefficient.Text);
                l = float.Parse(lb_vremaoperacii.Text);
                float s = ((a + c + e + f + g + h + i + k) * d) * (1 + (b / 100));
                float j = 28800 / l;
                lb_vremaoperacii.Text = s.ToString("N3");
                lb_vremaoperacii01.Text = s.ToString();
                lb_smenaschtuki.Text = j.ToString("N0");
            }
            catch (FormatException o)
            {
                lb_vremaoperacii.Text = "";
                lb_smenaschtuki.Text = "";
            }
        }
    
        private void Operaciiposhiva_Load(object sender, EventArgs e)
        {
            load_sql();

           // this.ControlBox = false;
          //  this.Width = Screen.PrimaryScreen.WorkingArea.Width;
          //  this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }
        private void load_sql()
        {
            dt = sql.Execute_read("select id,NOMEROPERACII,NOMEROPERDOS,NAIMOPERACII,VREMAOPERACII,SMENASCHTUKI,STATUS,STATUSDATA,STATUSDOLGNOST,STATUSFIO,RAZRABOTDOLGNOST,RAZRABOTFIO,RUCHNOEVREMA,SHIRINASTEGKA," +
                                            "NAIMOBORUD,KOEFFICIENT,TEXT,TEXT2,DATADOBAVLENIA,VREMISHODOPER,DLINSCHVA,KOLSTEG5SM,OBORUDKOEFICIENT,OBORUDVREM,POLOTNOKOEFICIENT,POLOTNO,OPISPOPRAVVREM1,OPISPOPRAVVREM2," +
                                            "OPISPOPRAVVREM3,OPISPOPRAVVREM4,OPISPOPRAVVREM5," +
                                            "POPRAVVREM1,POPRAVVREM2,POPRAVVREM3,POPRAVVREM4,POPRAVVREM5,ZAMERHUDVREM1,ZAMERHUDSKOGO1," +
                                            "ZAMERHUDKTO1,ZAMERHUDDATA1,ZAMERHUDVREM2,ZAMERHUDSKOGO2,ZAMERHUDKTO2,ZAMERHUDDATA2,ZAMERHUDVREM3,ZAMERHUDSKOGO3,ZAMERHUDKTO3,ZAMERHUDDATA3," +
                                            "ZAMERCEHVREM1A,ZAMERCEHSKOGO1A,ZAMERCEHKTO1A,ZAMERCEHDATA1A,ZAMERCEHVREM1B,ZAMERCEHSKOGO1B,ZAMERCEHKTO1B,ZAMERCEHDATA1B,ZAMERCEHVREM2A," +
                                            "ZAMERCEHSKOGO2A,ZAMERCEHKTO2A,ZAMERCEHDATA2A,ZAMERCEHVREM2B,ZAMERCEHSKOGO2B,ZAMERCEHKTO2B,ZAMERCEHDATA2B,ZAMERCEHVREM3A,ZAMERCEHSKOGO3A," +
                                            "ZAMERCEHKTO3A,ZAMERCEHDATA3A,ZAMERCEHVREM3B,ZAMERCEHSKOGO3B,ZAMERCEHKTO3B,ZAMERCEHDATA3B from OPERACIIPOSHIVA");
            //  dt = sql.Execute_read("select model from tomodel");
            lb_operacii.Items.Add("*Новая операция");
            foreach (DataRow dr in dt.Rows)
            {

                lb_operacii.Items.Add(dr["NOMEROPERACII"].ToString());
                lb_operacii.Items.Add(dr["NAIMOPERACII"].ToString());
                dataGridView1.Rows.Add(dr["NOMEROPERACII"].ToString(), dr["NOMEROPERDOS"].ToString(), dr["NAIMOPERACII"].ToString(), dr["VREMAOPERACII"].ToString(), dr["SMENASCHTUKI"].ToString(), dr["VREMISHODOPER"].ToString(), 
                                       dr["POLOTNOKOEFICIENT"].ToString(), dr["OBORUDVREM"].ToString(), dr["OBORUDKOEFICIENT"].ToString(),
                                       dr["POPRAVVREM1"].ToString(), dr["POPRAVVREM2"].ToString(), dr["POPRAVVREM3"].ToString(), dr["POPRAVVREM4"].ToString(), dr["POPRAVVREM5"].ToString(), dr["KOEFFICIENT"].ToString(), dr["DATADOBAVLENIA"].ToString());
            }

        }

        private void Lb_operacii_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_operacii.SelectedItem.ToString() == "*Новая операция")
            {
                // buf_ID_MOD = 0;
                lb_nomeroperacii.Text = "";
                lb_naimoperacii.Text = "";
                lb_vremaoperacii.Text = "";
                lb_smenaschtuki.Text = "";
                lb_naimoborud.Text = "";
                lb_koefficient.Text = "";
                lb_status.Text = "";
                lb_statusdata.Text = "";
                lb_statusdolgnost.Text = "";
                lb_statusfio.Text = "";
                lb_razrabotdolgnost.Text = "";
                lb_razrabotfio.Text = "";
                lb_ruchnoevrema.Text = "";
                lb_text.Text = "";
                lb_nomeroperdos.Text = "";
                lb_datadobavlenia.Text = "";
                lb_vremishodoper.Text = "";
                lb_dlinschva.Text = "";
                lb_kolsteg5sm.Text = "";
                lb_oborudkoeficient.Text = "";
                lb_oborudvrem.Text = "";               
                lb_polotnokoeficient.Text = "";
                lb_polotno.Text = "";
                lb_opispopravvrem1.Text = "";
                lb_opispopravvrem2.Text = "";
                lb_opispopravvrem3.Text = "";
                lb_opispopravvrem4.Text = "";
                lb_opispopravvrem5.Text = "";
                lb_popravvrem1.Text = "";
                lb_popravvrem2.Text = "";
                lb_popravvrem3.Text = "";
                lb_popravvrem4.Text = "";
                lb_popravvrem5.Text = "";
                lb_zamerhudvrem1.Text = "";
                lb_zamerhudskogo1.Text = "";
                lb_zamerhudkto1.Text = "";
                lb_zamerhuddata1.Text = "";
                lb_zamerhudvrem2.Text = "";
                lb_zamerhudskogo2.Text = "";
                lb_zamerhudkto2.Text = "";
                lb_zamerhuddata2.Text = "";
                lb_zamerhudvrem3.Text = "";
                lb_zamerhudskogo3.Text = "";
                lb_zamerhudkto3.Text = "";
                lb_zamerhuddata3.Text = "";
                lb_zamercehvrem1a.Text = "";
                lb_zamercehskogo1a.Text = "";
                lb_zamercehkto1a.Text = "";
                lb_zamercehdata1a.Text = "";
                lb_zamercehvrem2a.Text = "";
                lb_zamercehskogo2a.Text = "";
                lb_zamercehkto2a.Text = "";
                lb_zamercehdata2a.Text = "";
                lb_zamercehvrem3a.Text = "";
                lb_zamercehskogo3a.Text = "";
                lb_zamercehkto3a.Text = "";
                lb_zamercehdata3a.Text = "";
                lb_zamercehvrem1b.Text = "";
                lb_zamercehskogo1b.Text = "";
                lb_zamercehkto1b.Text = "";
                lb_zamercehdata1b.Text = "";
                lb_zamercehvrem2b.Text = "";
                lb_zamercehskogo2b.Text = "";
                lb_zamercehkto2b.Text = "";
                lb_zamercehdata2b.Text = "";
                lb_zamercehvrem3b.Text = "";
                lb_zamercehskogo3b.Text = "";
                lb_zamercehkto3b.Text = "";
                lb_zamercehdata3b.Text = "";
                lb_text2.Text = "";

            }
            else
            {
                foreach (DataRow dt in dt.Rows)
                {
                    if (dt["NOMEROPERACII"].ToString() == lb_operacii.SelectedItem.ToString())
                    {
                        buf_ID_OPER = Convert.ToInt32(dt["id"]);

                        lb_nomeroperacii.Text = dt["NOMEROPERACII"].ToString();
                        lb_naimoperacii.Text = dt["NAIMOPERACII"].ToString();
                        lb_vremaoperacii.Text = dt["VREMAOPERACII"].ToString();
                        lb_smenaschtuki.Text = dt["SMENASCHTUKI"].ToString();
                        lb_dlinschva.Text = dt["SHIRINASTEGKA"].ToString();
                        lb_naimoborud.Text = dt["NAIMOBORUD"].ToString();
                        lb_koefficient.Text = dt["KOEFFICIENT"].ToString();
                        lb_status.Text = dt["STATUS"].ToString();
                        lb_statusdata.Text = dt["STATUSDATA"].ToString();
                        lb_statusdolgnost.Text = dt["STATUSDOLGNOST"].ToString();
                        lb_statusfio.Text = dt["STATUSFIO"].ToString();
                        lb_razrabotdolgnost.Text = dt["RAZRABOTDOLGNOST"].ToString();
                        lb_razrabotfio.Text = dt["RAZRABOTFIO"].ToString();
                        lb_ruchnoevrema.Text = dt["RUCHNOEVREMA"].ToString();
                        lb_text.Text = dt["TEXT"].ToString();
                        lb_nomeroperdos.Text = dt["NOMEROPERDOS"].ToString();
                        lb_datadobavlenia.Text = dt["DATADOBAVLENIA"].ToString();
                        lb_vremishodoper.Text = dt["VREMISHODOPER"].ToString();                     
                        lb_dlinschva.Text = dt["DLINSCHVA"].ToString();
                        lb_kolsteg5sm.Text = dt["KOLSTEG5SM"].ToString();
                        lb_oborudkoeficient.Text = dt["OBORUDKOEFICIENT"].ToString();
                        lb_oborudvrem.Text = dt["OBORUDVREM"].ToString();                       
                        lb_polotnokoeficient.Text = dt["POLOTNOKOEFICIENT"].ToString();
                        lb_polotno.Text = dt["POLOTNO"].ToString();
                        lb_opispopravvrem1.Text = dt["OPISPOPRAVVREM1"].ToString();
                        lb_opispopravvrem2.Text = dt["OPISPOPRAVVREM2"].ToString();
                        lb_opispopravvrem3.Text = dt["OPISPOPRAVVREM3"].ToString();
                        lb_opispopravvrem4.Text = dt["OPISPOPRAVVREM4"].ToString();
                        lb_opispopravvrem5.Text = dt["OPISPOPRAVVREM5"].ToString();
                        lb_popravvrem1.Text = dt["POPRAVVREM1"].ToString();
                        lb_popravvrem2.Text = dt["POPRAVVREM2"].ToString();
                        lb_popravvrem3.Text = dt["POPRAVVREM3"].ToString();
                        lb_popravvrem4.Text = dt["POPRAVVREM4"].ToString();
                        lb_popravvrem5.Text = dt["POPRAVVREM5"].ToString();
                        lb_zamerhudvrem1.Text = dt["ZAMERHUDVREM1"].ToString();
                        lb_zamerhudskogo1.Text = dt["ZAMERHUDSKOGO1"].ToString();
                        lb_zamerhudkto1.Text = dt["ZAMERHUDKTO1"].ToString();
                        lb_zamerhuddata1.Text = dt["ZAMERHUDDATA1"].ToString();
                        lb_zamerhudvrem2.Text = dt["ZAMERHUDVREM2"].ToString();
                        lb_zamerhudskogo2.Text = dt["ZAMERHUDSKOGO2"].ToString();
                        lb_zamerhudkto2.Text = dt["ZAMERHUDKTO2"].ToString();
                        lb_zamerhuddata2.Text = dt["ZAMERHUDDATA2"].ToString();
                        lb_zamerhudvrem3.Text = dt["ZAMERHUDVREM3"].ToString();
                        lb_zamerhudskogo3.Text = dt["ZAMERHUDSKOGO3"].ToString();
                        lb_zamerhudkto3.Text = dt["ZAMERHUDKTO3"].ToString();
                        lb_zamerhuddata3.Text = dt["ZAMERHUDDATA3"].ToString();
                        lb_zamercehvrem1a.Text = dt["ZAMERCEHVREM1A"].ToString();
                        lb_zamercehskogo1a.Text = dt["ZAMERCEHSKOGO1A"].ToString(); 
                        lb_zamercehkto1a.Text = dt["ZAMERCEHKTO1A"].ToString();
                        lb_zamercehdata1a.Text = dt["ZAMERCEHDATA1A"].ToString();
                        lb_zamercehvrem2a.Text = dt["ZAMERCEHVREM2A"].ToString();
                        lb_zamercehskogo2a.Text = dt["ZAMERCEHSKOGO2A"].ToString();
                        lb_zamercehkto2a.Text = dt["ZAMERCEHKTO2A"].ToString();
                        lb_zamercehdata2a.Text = dt["ZAMERCEHDATA2A"].ToString();
                        lb_zamercehvrem3a.Text = dt["ZAMERCEHVREM3A"].ToString();
                        lb_zamercehskogo3a.Text = dt["ZAMERCEHSKOGO3A"].ToString();
                        lb_zamercehkto3a.Text = dt["ZAMERCEHKTO3A"].ToString();
                        lb_zamercehdata3a.Text = dt["ZAMERCEHDATA3A"].ToString();
                        lb_zamercehvrem1b.Text = dt["ZAMERCEHVREM1B"].ToString();
                        lb_zamercehskogo1b.Text = dt["ZAMERCEHSKOGO1B"].ToString();
                        lb_zamercehkto1b.Text = dt["ZAMERCEHKTO1B"].ToString();
                        lb_zamercehdata1b.Text = dt["ZAMERCEHDATA1B"].ToString();
                        lb_zamercehvrem2b.Text = dt["ZAMERCEHVREM2B"].ToString();
                        lb_zamercehskogo2b.Text = dt["ZAMERCEHSKOGO2B"].ToString();
                        lb_zamercehkto2b.Text = dt["ZAMERCEHKTO2B"].ToString();
                        lb_zamercehdata2b.Text = dt["ZAMERCEHDATA2B"].ToString();
                        lb_zamercehvrem3b.Text = dt["ZAMERCEHVREM3B"].ToString();
                        lb_zamercehskogo3b.Text = dt["ZAMERCEHSKOGO3B"].ToString();
                        lb_zamercehkto3b.Text = dt["ZAMERCEHKTO3B"].ToString();
                        lb_zamercehdata3b.Text = dt["ZAMERCEHDATA3B"].ToString();
                        lb_text2.Text = dt["TEXT2"].ToString();

                        lb_id_oper.Text = dt["id"].ToString(); //выводим текс из dataGridView1 ячейка 1 в label1

                    }
                }
            }
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        public void Lb_searh_TextChanged(object sender, EventArgs e)
        {
            
                lb_operacii.Items.Clear();
                lb_operacii.Items.Add("*Новая операция");
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["NOMEROPERACII"].ToString().Contains(lb_searh.Text))
                {
                    lb_operacii.Items.Add(dt.Rows[i]["NOMEROPERACII"].ToString());
                    lb_operacii.Items.Add(dt.Rows[i]["NAIMOPERACII"].ToString());
                }
            }



            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;
                for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)


                {

                    if (dataGridView1[j, i].Value.ToString().Contains(lb_searh.Text))


                    {
                        dataGridView1.Rows[i].Visible = true;
                        break;

                    }

                }
            }

        }

        private void Lb_nomeroperacii_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void Lb_vremaoperacii_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Lb_vremaoperacii_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void Lb_koefficient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void Lb_nomeroperacii_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lb_naimoperacii.Focus();
            }
        }

        private void Lb_naimoperacii_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lb_naimoperacii_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lb_vremaoperacii.Focus();
            }
        }

        private void Lb_vremaoperacii_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lb_koefficient.Focus();
            }
        }

        private void Lb_koefficient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lb_text.Focus();
            }
        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void But_refresh_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (lb_operacii.SelectedItem.ToString() == "*Новая операция")
                {
                    sql.Execute_write("INSERT INTO OPERACIIPOSHIVA (NOMEROPERACII,NAIMOPERACII,VREMAOPERACII,SMENASCHTUKI,SHIRINASTEGKA,NAIMOBORUD,KOEFFICIENT,STATUS,STATUSDATA,STATUSDOLGNOST,STATUSFIO," +
                                                  "RAZRABOTDOLGNOST,RAZRABOTFIO,RUCHNOEVREMA,TEXT,NOMEROPERDOS,DATADOBAVLENIA,VREMISHODOPER,DLINSCHVA,KOLSTEG5SM,OBORUDKOEFICIENT,OBORUDVREM," +
                                                  "POLOTNOKOEFICIENT,POLOTNO,OPISPOPRAVVREM1,OPISPOPRAVVREM2,OPISPOPRAVVREM3,OPISPOPRAVVREM4,OPISPOPRAVVREM5,POPRAVVREM1,POPRAVVREM2,POPRAVVREM3," +
                                                  "POPRAVVREM4,POPRAVVREM5,ZAMERHUDVREM1,ZAMERHUDSKOGO1,ZAMERHUDKTO1,ZAMERHUDDATA1,ZAMERHUDVREM2,ZAMERHUDSKOGO2,ZAMERHUDKTO2,ZAMERHUDDATA2," +
                                                  "ZAMERHUDVREM3,ZAMERHUDSKOGO3,ZAMERHUDKTO3,ZAMERHUDDATA3,ZAMERCEHVREM1A,ZAMERCEHSKOGO1A,ZAMERCEHKTO1A,ZAMERCEHDATA1A,ZAMERCEHVREM2A,ZAMERCEHSKOGO2A," +
                                                  "ZAMERCEHKTO2A,ZAMERCEHDATA2A,ZAMERCEHVREM3A,ZAMERCEHSKOGO3A,ZAMERCEHKTO3A,ZAMERCEHDATA3A," +
                                                  "ZAMERCEHVREM1B,ZAMERCEHSKOGO1B,ZAMERCEHKTO1B,ZAMERCEHDATA1B,ZAMERCEHVREM2B,ZAMERCEHSKOGO2B," +
                                                  "ZAMERCEHKTO2B,ZAMERCEHDATA2B,ZAMERCEHVREM3B,ZAMERCEHSKOGO3B,ZAMERCEHKTO3B,ZAMERCEHDATA3B,TEXT2,) values ('"
                                                                      + lb_nomeroperacii.Text + "','"
                                                                      + lb_naimoperacii.Text + "','"
                                                                      + lb_vremaoperacii.Text + "', "
                                                                      + lb_smenaschtuki.Text + "', "
                                                                      + lb_dlinschva.Text + "', "
                                                                      + lb_naimoborud.Text + "', "
                                                                      + lb_koefficient.Text + "', "
                                                                      + lb_status.Text + "', "
                                                                      + lb_statusdata.Text + "', "
                                                                      + lb_statusdolgnost.Text + "', "
                                                                      + lb_statusfio.Text + "', "
                                                                      + lb_razrabotdolgnost.Text + "', "
                                                                      + lb_razrabotfio.Text + "', "
                                                                      + lb_ruchnoevrema.Text + "', "
                                                                      + lb_text.Text + "', "
                                                                      + lb_nomeroperdos.Text + "', "
                                                                      + lb_datadobavlenia.Text + "', "
                                                                      + lb_vremishodoper.Text + "', "
                                                                      + lb_dlinschva.Text + "', "
                                                                      + lb_kolsteg5sm.Text + "', "
                                                                      + lb_oborudkoeficient.Text + "', "
                                                                      + lb_oborudvrem.Text + "', "
                                                                      + lb_polotnokoeficient.Text + "', "
                                                                      + lb_polotno.Text + "', "
                                                                      + lb_opispopravvrem1.Text + "', "
                                                                      + lb_opispopravvrem2.Text + "', "
                                                                      + lb_opispopravvrem3.Text + "', "
                                                                      + lb_opispopravvrem4.Text + "', "
                                                                      + lb_opispopravvrem5.Text + "', "
                                                                      + lb_popravvrem1.Text + "', "
                                                                      + lb_popravvrem2.Text + "', "
                                                                      + lb_popravvrem3.Text + "', "
                                                                      + lb_popravvrem4.Text + "', "
                                                                      + lb_popravvrem5.Text + "', "
                                                                      + lb_zamerhudvrem1.Text + "', "
                                                                      + lb_zamerhudskogo1.Text + "', "
                                                                      + lb_zamerhudkto1.Text + "', "
                                                                      + lb_zamerhuddata1.Text + "', "
                                                                      + lb_zamerhudvrem2.Text + "', "
                                                                      + lb_zamerhudskogo2.Text + "', "
                                                                      + lb_zamerhudkto2.Text + "', "
                                                                      + lb_zamerhuddata2.Text + "', "
                                                                      + lb_zamerhudvrem3.Text + "', "
                                                                      + lb_zamerhudskogo3.Text + "', "
                                                                      + lb_zamerhudkto3.Text + "', "
                                                                      + lb_zamerhuddata3.Text + "', "
                                                                      + lb_zamercehvrem1a.Text + "', "
                                                                      + lb_zamercehskogo1a.Text + "', "
                                                                      + lb_zamercehkto1a.Text + "', "
                                                                      + lb_zamercehdata1a.Text + "', "
                                                                      + lb_zamercehvrem2a.Text + "', "
                                                                      + lb_zamercehskogo2a.Text + "', "
                                                                      + lb_zamercehkto2a.Text + "', "
                                                                      + lb_zamercehdata2a.Text + "', "
                                                                      + lb_zamercehvrem3a.Text + "', "
                                                                      + lb_zamercehskogo3a.Text + "', "
                                                                      + lb_zamercehkto3a.Text + "', "
                                                                      + lb_zamercehdata3a.Text + "', "
                                                                        + lb_zamercehvrem1b.Text + "', "
                                                                      + lb_zamercehskogo1b.Text + "', "
                                                                      + lb_zamercehkto1b.Text + "', "
                                                                      + lb_zamercehdata1b.Text + "', "
                                                                      + lb_zamercehvrem2b.Text + "', "
                                                                      + lb_zamercehskogo2b.Text + "', "
                                                                      + lb_zamercehkto2b.Text + "', "
                                                                      + lb_zamercehdata2b.Text + "', "
                                                                      + lb_zamercehvrem3b.Text + "', "
                                                                      + lb_zamercehskogo3b.Text + "', "
                                                                      + lb_zamercehkto3b.Text + "', "
                                                                      + lb_zamercehdata3b.Text + "', "
                                                                      + lb_text2.Text + "') ");
                }
                else
                {
                    sql.Execute_write("UPDATE OPERACIIPOSHIVA set  NOMEROPERACII='" + lb_nomeroperacii.Text + "', " +
                                                                   "NAIMOPERACII='"+ lb_naimoperacii.Text + "', " +
                                                                   "VREMAOPERACII='" + lb_vremaoperacii.Text + "', " +
                                                                   "SMENASCHTUKI='" + lb_smenaschtuki.Text + "', " +
                                                                   "SHIRINASTEGKA='" + lb_dlinschva.Text + "', " +
                                                                   "NAIMOBORUD='" + lb_naimoborud.Text + "', " +
                                                                   "KOEFFICIENT='" + lb_koefficient.Text + "', " +
                                                                   "STATUS='" + lb_status.Text + "', " +
                                                                   "STATUSDATA='" + lb_statusdata.Text + "', " +
                                                                   "STATUSDOLGNOST='" + lb_statusdolgnost.Text + "', " +
                                                                   "STATUSFIO='" + lb_statusfio.Text + "', " +
                                                                   "RAZRABOTDOLGNOST='" + lb_razrabotdolgnost.Text + "', " +
                                                                   "RAZRABOTFIO='" + lb_razrabotfio.Text + "', " +
                                                                   "RUCHNOEVREMA='" + lb_ruchnoevrema.Text + "', " +
                                                                   "TEXT='" + lb_text.Text + "', " +
                                                                   "NOMEROPERDOS='" + lb_nomeroperdos.Text + "', " +
                                                                   "DATADOBAVLENIA='" + lb_datadobavlenia.Text + "', " +
                                                                   "VREMISHODOPER='" + lb_vremishodoper.Text + "', " +
                                                                   "DLINSCHVA='" + lb_dlinschva.Text + "', " +
                                                                   "KOLSTEG5SM='" + lb_kolsteg5sm.Text + "', " +
                                                                   "OBORUDKOEFICIENT='" + lb_oborudkoeficient.Text + "', " +
                                                                   "OBORUDVREM='" + lb_oborudvrem.Text + "', " +
                                                                   "POLOTNOKOEFICIENT='" + lb_polotnokoeficient.Text + "', " +
                                                                   "POLOTNO='" + lb_polotno.Text + "', " +
                                                                   "OPISPOPRAVVREM1='" + lb_opispopravvrem1.Text + "', " +
                                                                   "OPISPOPRAVVREM2='" + lb_opispopravvrem2.Text + "', " +
                                                                   "OPISPOPRAVVREM3='" + lb_opispopravvrem3.Text + "', " +
                                                                   "OPISPOPRAVVREM4='" + lb_opispopravvrem4.Text + "', " +
                                                                   "OPISPOPRAVVREM5='" + lb_opispopravvrem5.Text + "', " +
                                                                   "POPRAVVREM1='" + lb_popravvrem1.Text + "', " +
                                                                   "POPRAVVREM2='" + lb_popravvrem2.Text + "', " +
                                                                   "POPRAVVREM3='" + lb_popravvrem3.Text + "', " +
                                                                   "POPRAVVREM4='" + lb_popravvrem4.Text + "', " +
                                                                   "POPRAVVREM5='" + lb_popravvrem5.Text + "', " +
                                                                   "ZAMERHUDVREM1='" + lb_zamerhudvrem1.Text + "', " +
                                                                   "ZAMERHUDSKOGO1='" + lb_zamerhudskogo1.Text + "', " +
                                                                   "ZAMERHUDKTO1='" + lb_zamerhudkto1.Text + "', " +
                                                                   "ZAMERHUDDATA1='" + lb_zamerhuddata1.Text + "', " +
                                                                   "ZAMERHUDVREM2='" + lb_zamerhudvrem2.Text + "', " +
                                                                   "ZAMERHUDSKOGO2='" + lb_zamerhudskogo2.Text + "', " +
                                                                   "ZAMERHUDKTO2='" + lb_zamerhudkto2.Text + "', " +
                                                                   "ZAMERHUDDATA2='" + lb_zamerhuddata2.Text + "', " +
                                                                   "ZAMERHUDVREM3='" + lb_zamerhudvrem3.Text + "', " +
                                                                   "ZAMERHUDSKOGO3='" + lb_zamerhudskogo3.Text + "', " +
                                                                   "ZAMERHUDKTO3='" + lb_zamerhudkto3.Text + "', " +
                                                                   "ZAMERHUDDATA3='" + lb_zamerhuddata3.Text + "', " +
                                                                   "ZAMERCEHVREM1A='" + lb_zamercehvrem1a.Text + "', " +
                                                                   "ZAMERCEHSKOGO1A='" + lb_zamercehskogo1a.Text + "', " +
                                                                   "ZAMERCEHKTO1A='" + lb_zamercehkto1a.Text + "', " +
                                                                   "ZAMERCEHDATA1A='" + lb_zamercehdata1a.Text + "', " +
                                                                   "ZAMERCEHVREM2A='" + lb_zamercehvrem2a.Text + "', " +
                                                                   "ZAMERCEHSKOGO2A='" + lb_zamercehskogo2a.Text + "', " +
                                                                   "ZAMERCEHKTO2A='" + lb_zamercehkto2a.Text + "', " +
                                                                   "ZAMERCEHDATA2A='" + lb_zamercehdata2a.Text + "', " +
                                                                    "ZAMERCEHVREM3A='" + lb_zamercehvrem3a.Text + "', " +
                                                                   "ZAMERCEHSKOGO3A='" + lb_zamercehskogo3a.Text + "', " +
                                                                   "ZAMERCEHKTO3A='" + lb_zamercehkto3a.Text + "', " +
                                                                   "ZAMERCEHDATA3A='" + lb_zamercehdata3a.Text + "', " +
                                                                       "ZAMERCEHVREM1B='" + lb_zamercehvrem1b.Text + "', " +
                                                                   "ZAMERCEHSKOGO1B='" + lb_zamercehskogo1b.Text + "', " +
                                                                   "ZAMERCEHKTO1B='" + lb_zamercehkto1b.Text + "', " +
                                                                   "ZAMERCEHDATA1B='" + lb_zamercehdata1b.Text + "', " +
                                                                   "ZAMERCEHVREM2B='" + lb_zamercehvrem2b.Text + "', " +
                                                                   "ZAMERCEHSKOGO2B='" + lb_zamercehskogo2b.Text + "', " +
                                                                   "ZAMERCEHKTO2B='" + lb_zamercehkto2b.Text + "', " +
                                                                   "ZAMERCEHDATA2B='" + lb_zamercehdata2b.Text + "', " +
                                                                    "ZAMERCEHVREM3B='" + lb_zamercehvrem3b.Text + "', " +
                                                                   "ZAMERCEHSKOGO3B='" + lb_zamercehskogo3b.Text + "', " +
                                                                   "ZAMERCEHKTO3B='" + lb_zamercehkto3b.Text + "', " +
                                                                   "ZAMERCEHDATA3B='" + lb_zamercehdata3b.Text + "', " +
                                                                   "TEXT2='" + lb_text2.Text + "'  where id ='" + buf_ID_OPER + "';");

                }
            }
            else if (result == DialogResult.No)
            {

            }
            this.Controls.Clear();
            this.InitializeComponent();
            load_sql();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox18_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            lb_operacii.Items.Clear();
            lb_operacii.Items.Add("*Новая операция");
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["NAIMOPERACII"].ToString().Contains(lb_searh2.Text))
                {
                    lb_operacii.Items.Add(dt.Rows[i]["NOMEROPERACII"].ToString());
                    lb_operacii.Items.Add(dt.Rows[i]["NAIMOPERACII"].ToString());
                }
            }



            for (int i = 0; i < dataGridView1.Rows.Count - 3; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;
                for (int j = 0; j < dataGridView1.Columns.Count - 3; j++)


                {

                    if (dataGridView1[j, i].Value.ToString().Contains(lb_searh2.Text))


                    {
                        dataGridView1.Rows[i].Visible = true;
                        break;

                    }

                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Lb_vremishodoper_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void Lb_ruchnoevrema_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void Lb_koefficient_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void Lb_polotnokoeficient_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void Lb_oborudvrem_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void Lb_popravvrem1_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void Lb_popravvrem2_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void Lb_popravvrem3_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void Lb_popravvrem4_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void Lb_popravvrem5_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void Lb_vremaoperacii01_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
