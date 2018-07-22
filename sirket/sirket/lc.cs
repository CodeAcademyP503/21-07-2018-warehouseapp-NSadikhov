using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sirket
{
    public partial class lc : Form
    {
        public int clickCount = 0;
        static public string[] strLcName = new string[4];
        static public string[] strLc = new string[4];
        static public string plankLc;
        static public int percent;

        public lc()
        {
            InitializeComponent();
            fill();
            lcPlanka.Text = plankLc;
            textBox1.Text = Convert.ToString(percent);
            for (int i = 0; i < strLc.Length; i++)
            {
                if (strLc[i] != null)
                {
                    cedvelLc.Rows.Add();
                    cedvelLc.Rows[i].Cells[0].Value = strLcName[i];
                    cedvelLc.Rows[i].Cells[1].Value = strLc[i];
                }
            }

        }

        public void fill()
        {
            foreach (var item in admin.dataCedvel)
            {
                if (item.employees.markets.name == MarketName.LcWaikiki)
                {
                    comboBox4.Items.Add(item.employees.name);
                }
            }
        }

        private void btnLc_Click(object sender, EventArgs e)
        {
            plankLc = lcPlanka.Text;
            if (textBox1.Text == "")
            {
                percent = 0;
            }
            else
            {
                percent = Convert.ToInt32(textBox1.Text);
            }
            if (comboBox4.Text != "" && satilmisLC.Text != "")
            {
                
                bool check = false;
                int numb = 0;

                if (strLc[0] != null)
                {
                    for (int i = 0; i < strLc.Length; i++)
                    {
                        if (strLc[i] != null && comboBox4.Text == Convert.ToString(cedvelLc.Rows[i].Cells[0].Value))
                        {
                            check = true;
                            numb = i;
                            break;
                        }
                    }
                }

                if (check == true)
                {
                    cedvelLc.Rows[numb].Cells[1].Value = satilmisLC.Text;
                }
                else
                {
                    cedvelLc.Rows.Add();
                    cedvelLc.Rows[clickCount].Cells[0].Value = comboBox4.Text;
                    cedvelLc.Rows[clickCount].Cells[1].Value = satilmisLC.Text;
                    strLcName[clickCount] = Convert.ToString(cedvelLc.Rows[clickCount].Cells[0].Value);
                    strLc[clickCount] = Convert.ToString(cedvelLc.Rows[clickCount].Cells[1].Value);
                    clickCount++;
                }
            }
        }
    }

}
