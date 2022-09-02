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
    public partial class Form_Tomodel : Form
    {
        public Form_Tomodel()
        {
            InitializeComponent();
        }
        SQLConnect sql = new SQLConnect();
        DataTable dt = new DataTable();





        private void Tomodel_Load(object sender, EventArgs e)
        {

            load_sql();
        }
        private void load_sql()
        {
            
                dt = sql.Execute_read("select ID_MOD,GOTOVO,HODOVAIA,MODEL,MODEL_ZAK,NI,AK,KIK,VREMA,SCALA,RAZMFIGURY1,RAZMFIGURY2,KOLLECIA,GOST,PRIMECANIE,IGLANOMER,VNIMANIE1,VNIMANIE2,NAIMK1,NAIMK2,TOBYNOMER,TOBYGOD,UTVERZDATA,VEDENIDATA,DATASOZDMOD,DRUGIEMODELI,HUDOZNIK,KONSTRUKTOR,TEHNOLOG,ASSORTIMENT,KUDAMODEL,SPECZAKAZKTO,GOST1,GOST2,GOST3,GOST4,GOST5,GOST6,NAIM1,NAIM2,NAIM3,NAIM4,NAIM5,NAIM6,POL1,POL2,POL3,POL4,POL5,POL6,POLO1,POLO2,POLO3,POLO4,POLO5,POLO6 from TOMODEL");
             foreach (DataRow dr in dt.Rows)
            //DataView dv = new DataView(dt);
            {
              dataGridView1.Rows.Add(dr["ID_MOD"].ToString(), dr["GOTOVO"].ToString(), dr["HODOVAIA"].ToString(), dr["MODEL"].ToString(), dr["NI"].ToString(), dr["VEDENIDATA"].ToString());
               // dataGridView1.DataSource = dv;



            }

        }



        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Search(DataGridView dgw)
        {


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            //DataView dv = new DataView(dt);
            //dv.RowFilter = string.Format("MODEL LIKE '%{0}%'", textBox1.Text);

            //dataGridView1.DataSource = dv;
           // naimmod.Text = dataGridView1.Rows[0].Cells[1].Value.ToString(); //выводим текс из dataGridView1 ячейка 1 в label1
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                  

                {

                    if (dataGridView1[j, i].Value.ToString().Contains(textBox1.Text))


                    {
                        dataGridView1.Rows[i].Visible = true;
                        break;
                        
                    }

                }
            }

             }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form_KorTomodel fr = new Form_KorTomodel();
            fr.Show();
        }



        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void GroupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
   



        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Form_KorTomodel fr = new Form_KorTomodel();
            fr.Show();
            this.Hide();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


    }
