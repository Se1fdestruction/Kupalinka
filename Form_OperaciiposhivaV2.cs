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
    public partial class Form_OperaciiposhivaV2 : Form
    {
        public Form_OperaciiposhivaV2()
        {
            InitializeComponent();
        }
        SQLConnect sql = new SQLConnect();
        DataTable dt = new DataTable();
        private void Form_OperaciiposhivaV2_Load(object sender, EventArgs e)
        {
            load_sql();
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
          
            foreach (DataRow dr in dt.Rows)
            {             
                dataGridView1.Rows.Add(dr["NOMEROPERACII"].ToString(), dr["NOMEROPERDOS"].ToString(), dr["NAIMOPERACII"].ToString(), dr["VREMAOPERACII"].ToString(), dr["SMENASCHTUKI"].ToString(), dr["VREMISHODOPER"].ToString(),
                                       dr["POLOTNOKOEFICIENT"].ToString(), dr["OBORUDVREM"].ToString(), dr["OBORUDKOEFICIENT"].ToString(),
                                       dr["POPRAVVREM1"].ToString(), dr["POPRAVVREM2"].ToString(), dr["POPRAVVREM3"].ToString(), dr["POPRAVVREM4"].ToString(), dr["POPRAVVREM5"].ToString(), dr["KOEFFICIENT"].ToString(), dr["DATADOBAVLENIA"].ToString());
            }

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string data1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string data2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lb_nomeroperacii.Text = data1;
            lb_naimoperacii.Text = data2;

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {
                    }

        private void Lb_searh_TextChanged(object sender, EventArgs e)
        {
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
    }
}
