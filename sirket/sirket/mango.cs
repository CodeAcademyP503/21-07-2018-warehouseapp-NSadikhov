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
    public partial class mango : Form
    {
        public int clickCount = 0;
        static public string[] strMango = new string[4];
        static public string[] strMangoName = new string[4];
        static public string plankMango;
        static public int percent;
 
        public mango()
        {
            InitializeComponent();
            fill();
            mangoPlank.Text = plankMango;
            textBox1.Text = Convert.ToString(percent);
            for (int i = 0; i < strMango.Length; i++)
            {
                if (strMango[i] != null)
                {
                    cedvelMango.Rows.Add();
                    cedvelMango.Rows[i].Cells[0].Value = strMangoName[i];
                    cedvelMango.Rows[i].Cells[1].Value = strMango[i];
                }
            }
        }

        public void fill()
        {
            foreach (var item in admin.dataCedvel)
            {
                if (item.employees.markets.name == MarketName.Mango)
                {
                    comboBox1.Items.Add(item.employees.name);
                }
            }
        }

        private void btnMango_Click(object sender, EventArgs e)
        {

            plankMango = mangoPlank.Text;
            if (textBox1.Text == "")
            {
                percent = 0;
            }
            else
            {
                percent = Convert.ToInt32(textBox1.Text);
            }
            if (comboBox1.Text != "" && satilmisMango.Text != "")
            {
               
                bool check = false;
                int numb = 0;

                if (strMango[0] != null)
                {
                    for (int i = 0; i < strMango.Length; i++)
                    {
                        if (strMango[i] != null && comboBox1.Text == Convert.ToString(cedvelMango.Rows[i].Cells[0].Value))
                        {
                            check = true;
                            numb = i;
                            break;
                        }
                    }
                }

                if (check == true)
                {
                    cedvelMango.Rows[numb].Cells[1].Value = satilmisMango.Text;
                }
                else
                {
                    cedvelMango.Rows.Add();
                    cedvelMango.Rows[clickCount].Cells[0].Value = comboBox1.Text;
                    cedvelMango.Rows[clickCount].Cells[1].Value = satilmisMango.Text;
                    strMango[clickCount] = Convert.ToString(cedvelMango.Rows[clickCount].Cells[1].Value);
                    strMangoName[clickCount] = Convert.ToString(cedvelMango.Rows[clickCount].Cells[0].Value);
                    clickCount++;
                }

            }
        }
    }
}
