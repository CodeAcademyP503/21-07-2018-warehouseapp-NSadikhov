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
    public partial class hugo : Form
    {
        public int clickCount = 0;
        static public string[] strHugo = new string[4];
        static public string[] strHugoName = new string[4];
        static public string plankHugo;
        static public int percent;

        public hugo()
        {
            InitializeComponent();
            fill();
            hugoPlanka.Text = plankHugo;
            textBox1.Text = Convert.ToString(percent);
            for (int i = 0; i < strHugo.Length; i++)
            {
                if (strHugo[i] != null)
                {
                    cedvelHugo.Rows.Add();
                    cedvelHugo.Rows[i].Cells[0].Value = strHugoName[i];
                    cedvelHugo.Rows[i].Cells[1].Value = strHugo[i];
                }
            }

        }

        public void fill()
        {
            foreach (var item in admin.dataCedvel)
            {
                if (item.employees.markets.name == MarketName.HugoBoss)
                {
                    comboBox3.Items.Add(item.employees.name);
                }
            }
        }

        private void btnHugo_Click(object sender, EventArgs e)
        {
            plankHugo = hugoPlanka.Text;
            if (textBox1.Text == "")
            {
                percent = 0;
            }
            else
            {
                percent = Convert.ToInt32(textBox1.Text);
            }
            if (comboBox3.Text != "" && satilmisHUGO.Text != "")
            {
                bool check = false;
                int numb = 0;

                if (strHugo[0] != null)
                {
                    for (int i = 0; i < strHugo.Length; i++)
                    {
                        if (strHugo[i] != null && comboBox3.Text == Convert.ToString(cedvelHugo.Rows[i].Cells[0].Value))
                        {
                            check = true;
                            numb = i;
                            break;
                        }
                    }
                }

                if (check == true)
                {
                    cedvelHugo.Rows[numb].Cells[1].Value = satilmisHUGO.Text;
                }
                else
                {
                    cedvelHugo.Rows.Add();
                    cedvelHugo.Rows[clickCount].Cells[0].Value = comboBox3.Text;
                    cedvelHugo.Rows[clickCount].Cells[1].Value = satilmisHUGO.Text;
                    strHugoName[clickCount] = Convert.ToString(cedvelHugo.Rows[clickCount].Cells[0].Value);
                    strHugo[clickCount] = Convert.ToString(cedvelHugo.Rows[clickCount].Cells[1].Value);
                    clickCount++;
                }
            }
        }

        
    }
}
