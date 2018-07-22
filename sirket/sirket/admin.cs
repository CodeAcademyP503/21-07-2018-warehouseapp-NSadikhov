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
    public partial class admin : Form
    {
         static public ayliqCedvel[] dataCedvel = new ayliqCedvel[] {
                new ayliqCedvel()
                {
                    employees = new Employees(){
                        name = "Kerim",
                        surname = "Necefov",
                        Email = "kerim1221gmail.com",
                        emekHaqqi = (int)Vezife.saticiKomekcisi,
                        vezife = Vezife.saticiKomekcisi,
                        markets = new Markets()
                        {
                            name = MarketName.Mango
                        }
                    },
                    planka = planka.G0M,
                    bonus = 0,
                    totalMebleg = 0,

                },
                new ayliqCedvel()
                {
                     employees = new Employees(){
                         name = "Saleh",
                         surname = "Memmedov",
                         Email = "seleh2000@gmail.com",
                         emekHaqqi = (int)Vezife.basSatici,
                         vezife = Vezife.basSatici,
                         markets = new Markets()
                         {
                             name = MarketName.LcWaikiki
                         }
                     },
                     planka = planka.G0LW,

                },
                new ayliqCedvel()
                {
                     employees = new Employees(){
                         name = "Memmed",
                         surname = "Resulzade",
                         Email = "memed3169@gmail.com",
                         emekHaqqi = (int)Vezife.satici,
                         vezife = Vezife.satici,
                         markets = new Markets()
                         {
                             name = MarketName.NewYorker
                         }
                    },
                     planka = planka.G0NY,
                },
                new ayliqCedvel()
                {
                    employees = new Employees(){
                        name = "Vusal",
                        surname = "Nuredddinov",
                        Email = "nuraddinov1905@gmail.com",
                        emekHaqqi = (int)Vezife.magazaMeneceri,
                        vezife = Vezife.magazaMeneceri,
                        markets = new Markets()
                        {
                            name = MarketName.HugoBoss
                        }
                    },
                    planka = planka.G0HB,
                },
                new ayliqCedvel()
                {
                    employees = new Employees(){
                        name = "Shahin",
                        surname = "Cabbarov",
                        Email = "shahinyj@code.edu.az",
                        emekHaqqi = (int)Vezife.magazaMeneceri,
                        vezife = Vezife.magazaMeneceri,
                        markets = new Markets()
                        {
                            name = MarketName.NewYorker,
                        }
                    },
                    planka = planka.G0NY,
                },
                new ayliqCedvel()
                {
                    employees = new Employees(){
                        name = "Mirze",
                        surname = "Elekberov",
                        Email = "elekberov2000@code.edu.az",
                        emekHaqqi = (int)Vezife.satici,
                        vezife = Vezife.satici,
                        markets = new Markets()
                        {
                            name = MarketName.HugoBoss,
                        }
                    },
                    planka = planka.G0HB,
                },
                new ayliqCedvel()
                {
                    employees = new Employees(){
                        name = "Amal",
                        surname = "Ceferov",
                        Email = "amalcf@code.edu.az",
                        emekHaqqi = (int)Vezife.basSatici,
                        vezife = Vezife.basSatici,
                        markets = new Markets()
                        {
                            name = MarketName.NewYorker,
                        }
                    },
                    planka = planka.G0NY,
                },
                new ayliqCedvel()
                {
                    employees = new Employees(){
                        name = "Kamal",
                        surname = "Shukurov",
                        Email = "kamal2000@code.edu.az",
                        emekHaqqi = (int)Vezife.saticiKomekcisi,
                        vezife = Vezife.saticiKomekcisi,
                        markets = new Markets()
                        {
                            name = MarketName.HugoBoss,
                        }
                    },
                    planka = planka.G0HB,
                },
                new ayliqCedvel()
                {
                    employees = new Employees(){
                        name = "Ekber",
                        surname = "Sixiyev",
                        Email = "sixi3333@code.edu.az",
                        emekHaqqi = (int)Vezife.basSatici,
                        vezife = Vezife.basSatici,
                        markets = new Markets()
                        {
                            name = MarketName.HugoBoss,
                        }
                    },
                    planka = planka.G0HB,
                },
                new ayliqCedvel()
                {
                     employees = new Employees(){
                         name = "Vuqar",
                         surname = "Memmedov",
                         Email = "vuqarmd@gmail.com",
                         emekHaqqi = (int)Vezife.saticiKomekcisi,
                         vezife = Vezife.saticiKomekcisi,
                         markets = new Markets()
                         {
                             name = MarketName.LcWaikiki
                         }
                     },
                     planka = planka.G0LW,

                },
                new ayliqCedvel()
                {
                     employees = new Employees(){
                         name = "Kenan",
                         surname = "Muzefferov",
                         Email = "keko1221@gmail.com",
                         emekHaqqi = (int)Vezife.satici,
                         vezife = Vezife.satici,
                         markets = new Markets()
                         {
                             name = MarketName.LcWaikiki
                         }
                     },
                     planka = planka.G0LW,

                },
                new ayliqCedvel()
                {
                    employees = new Employees(){
                        name = "Rufet",
                        surname = "Ehrimanov",
                        Email = "rufo333.com",
                        emekHaqqi = (int)Vezife.magazaMeneceri,
                        vezife = Vezife.magazaMeneceri,
                        markets = new Markets()
                        {
                            name = MarketName.Mango
                        }
                    },
                    planka = planka.G0M,
                    bonus = 0,
                    totalMebleg = 0,

                },
                new ayliqCedvel()
                {
                    employees = new Employees(){
                        name = "Ali",
                        surname = "Aliyev",
                        Email = "ali9067.com",
                        emekHaqqi = (int)Vezife.satici,
                        vezife = Vezife.satici,
                        markets = new Markets()
                        {
                            name = MarketName.Mango
                        }
                    },
                    planka = planka.G0M,
                    bonus = 0,
                    totalMebleg = 0,

                },
                new ayliqCedvel()
                {
                     employees = new Employees(){
                         name = "Elsad",
                         surname = "Recebov",
                         Email = "receb1221@gmail.com",
                         emekHaqqi = (int)Vezife.magazaMeneceri,
                         vezife = Vezife.magazaMeneceri,
                         markets = new Markets()
                         {
                             name = MarketName.LcWaikiki
                         }
                     },
                     planka = planka.G0LW,
                },
                new ayliqCedvel()
                {
                    employees = new Employees(){
                        name = "Nicat",
                        surname = "Eliyev",
                        Email = "niko1221.com",
                        emekHaqqi = (int)Vezife.basSatici,
                        vezife = Vezife.basSatici,
                        markets = new Markets()
                        {
                            name = MarketName.Mango
                        }
                    },
                    planka = planka.G0M,
                    bonus = 0,
                    totalMebleg = 0,
                },
                new ayliqCedvel()
                {
                    employees = new Employees(){
                        name = "Senan",
                        surname = "Muzefferov",
                        Email = "seko1221@code.edu.az",
                        emekHaqqi = (int)Vezife.saticiKomekcisi,
                        vezife = Vezife.saticiKomekcisi,
                        markets = new Markets()
                        {
                            name = MarketName.NewYorker,
                        }
                    },
                    planka = planka.G0NY,
                },
            };
        public admin()
        {
            InitializeComponent();
            create();
        } 
        public void create()
        {

            for (int i = 0; i < dataCedvel.Length; i++)
            {
                cedvel.Rows.Add();
                cedvel.Rows[i].Cells[0].Value = dataCedvel[i].employees.name;
                cedvel.Rows[i].Cells[1].Value = dataCedvel[i].employees.surname;
                cedvel.Rows[i].Cells[2].Value = dataCedvel[i].employees.vezife;
                cedvel.Rows[i].Cells[3].Value = dataCedvel[i].employees.emekHaqqi;
                cedvel.Rows[i].Cells[4].Value = dataCedvel[i].employees.markets.name;
                cedvel.Rows[i].Cells[5].Value = dataCedvel[i].planka;
                cedvel.Rows[i].Cells[6].Value = dataCedvel[i].bonus;
                cedvel.Rows[i].Cells[7].Value = dataCedvel[i].totalMebleg;
            }
        }
       
        private void btnHesabla_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataCedvel.Length; i++)
            {
                if (Convert.ToString(cedvel.Rows[i].Cells[4].Value) == Convert.ToString(MarketName.Mango) && Convert.ToString(cedvel.Rows[i].Cells[8].Value) == "True")
                {
                    int sum = 0;
                    foreach (string item in mango.strMango)
                    {
                        sum += Convert.ToInt32(item);
                    }
                    if (Convert.ToInt32(mango.plankMango) != 0 && sum >= Convert.ToInt32(mango.plankMango))
                    {

                        cedvel.Rows[i].Cells[6].Value = Convert.ToInt32(cedvel.Rows[i].Cells[3].Value) * mango.percent / 100;
                        cedvel.Rows[i].Cells[7].Value = Convert.ToInt32(cedvel.Rows[i].Cells[6].Value) + Convert.ToInt32(cedvel.Rows[i].Cells[3].Value);
                    }
                }
                else if (Convert.ToString(cedvel.Rows[i].Cells[4].Value) == Convert.ToString(MarketName.LcWaikiki) && Convert.ToString(cedvel.Rows[i].Cells[8].Value) == "True")
                {
                    int sum = 0;
                    foreach (string item in lc.strLc)
                    {
                        sum += Convert.ToInt32(item);
                    }
                    if (Convert.ToInt32(lc.plankLc) != 0 && sum >= Convert.ToInt32(lc.plankLc))
                    {
                        cedvel.Rows[i].Cells[6].Value = Convert.ToInt32(cedvel.Rows[i].Cells[3].Value) * lc.percent / 100;
                        cedvel.Rows[i].Cells[7].Value = Convert.ToInt32(cedvel.Rows[i].Cells[6].Value) + Convert.ToInt32(cedvel.Rows[i].Cells[3].Value);
                    }
                }
                else if (Convert.ToString(cedvel.Rows[i].Cells[4].Value) == Convert.ToString(MarketName.NewYorker) && Convert.ToString(cedvel.Rows[i].Cells[8].Value) == "True")
                {
                    int sum = 0;
                    foreach (string item in newYorker.strNew)
                    {
                        sum += Convert.ToInt32(item);
                    }
                    if (Convert.ToInt32(newYorker.plankNew) != 0 && sum >= Convert.ToInt32(newYorker.plankNew))
                    {
                        cedvel.Rows[i].Cells[6].Value = Convert.ToInt32(cedvel.Rows[i].Cells[3].Value) * newYorker.percent / 100;
                        cedvel.Rows[i].Cells[7].Value = Convert.ToInt32(cedvel.Rows[i].Cells[6].Value) + Convert.ToInt32(cedvel.Rows[i].Cells[3].Value);
                    }
                }
                else if (Convert.ToString(cedvel.Rows[i].Cells[4].Value) == Convert.ToString(MarketName.HugoBoss) && Convert.ToString(cedvel.Rows[i].Cells[8].Value) == "True")
                {
                    int sum = 0;
                    foreach (string item in hugo.strHugo)
                    {
                        sum += Convert.ToInt32(item);
                    }
                    if (Convert.ToInt32(hugo.plankHugo) != 0 && sum >= Convert.ToInt32(hugo.plankHugo))
                    {
                        cedvel.Rows[i].Cells[6].Value = Convert.ToInt32(cedvel.Rows[i].Cells[3].Value) * hugo.percent / 100;
                        cedvel.Rows[i].Cells[7].Value = Convert.ToInt32(cedvel.Rows[i].Cells[6].Value) + Convert.ToInt32(cedvel.Rows[i].Cells[3].Value);
                    }
                }

            }

        }
    }
}
