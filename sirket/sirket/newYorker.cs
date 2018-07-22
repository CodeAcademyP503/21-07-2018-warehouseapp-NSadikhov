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
    public partial class newYorker : Form
    {
        public int clickCount = 0;
        static public string[] strNew = new string[4];
        static public string[] strNewName = new string[4];
        static public string plankNew;
        static public int percent;

        public newYorker()
        {
            InitializeComponent();
            fill();
            newPlanka.Text = plankNew;
            textBox1.Text = Convert.ToString(percent);
            for (int i = 0; i < strNew.Length; i++)
            {
                if (strNew[i] != null)
                {
                    cedvelNew.Rows.Add();
                    cedvelNew.Rows[i].Cells[0].Value = strNewName[i];
                    cedvelNew.Rows[i].Cells[1].Value = strNew[i];
                }
            }

        }

        public void fill()
        {
            foreach (var item in admin.dataCedvel)
            {
                if (item.employees.markets.name == MarketName.NewYorker)
                {
                    comboBox2.Items.Add(item.employees.name);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            plankNew = newPlanka.Text;
            if (textBox1.Text == "")
            {
                percent = 0;
            }
            else
            {
                percent = Convert.ToInt32(textBox1.Text);
            }
            if (comboBox2.Text != "" && satilmisNEW.Text != "")
            {
               
                bool check = false;
                int numb = 0;

                if (strNew[0] != null)
                {
                    for (int i = 0; i < strNew.Length; i++)
                    {
                        if (strNew[i] != null && comboBox2.Text == Convert.ToString(cedvelNew.Rows[i].Cells[0].Value))
                        {
                            check = true;
                            numb = i;
                            break;
                        }
                    }
                }

                if (check == true)
                {
                    cedvelNew.Rows[numb].Cells[1].Value = satilmisNEW.Text;
                }
                else
                {
                    cedvelNew.Rows.Add();
                    cedvelNew.Rows[clickCount].Cells[0].Value = comboBox2.Text;
                    cedvelNew.Rows[clickCount].Cells[1].Value = satilmisNEW.Text;
                    strNewName[clickCount] = Convert.ToString(cedvelNew.Rows[clickCount].Cells[0].Value);
                    strNew[clickCount] = Convert.ToString(cedvelNew.Rows[clickCount].Cells[1].Value);
                    clickCount++;
                }
            }
        }
    }
}
