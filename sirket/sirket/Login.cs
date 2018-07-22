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
    public partial class Login : Form
    {
        public User userAdmin = new User("admin", "12345");
        public User[] userMenecers = new User[]
        {
            new User("mango", "mango123"),
            new User("lcwaikiki", "lc123"),
            new User("hugo", "hugo123"),
            new User("newyorker", "ny123")
        };

        static public string selectedMenecer;

        public Login()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool checkerAdmin = false;
            bool checkerMenecer = false;
            
            for (int i = 0; i < userMenecers.Length; i++)
            {
                if (userName.Text == userAdmin.name && userPassword.Text == userAdmin.password)
                {
                    checkerAdmin = true;
                }
                else if (userName.Text == userMenecers[i].name && userPassword.Text == userMenecers[i].password)
                {
                    checkerMenecer = true;
                    selectedMenecer = userName.Text;
                }
            }

            if (checkerAdmin)
            {
                admin adm = new admin();
                adm.ShowDialog();
            }
            else if (checkerMenecer)
            {
                if (selectedMenecer == "mango")
                {
                    mango man = new mango();
                    man.ShowDialog();
                }
                else if (selectedMenecer == "newyorker")
                {
                    newYorker newy = new newYorker();
                    newy.ShowDialog();
                }
                else if (selectedMenecer == "hugo")
                {
                    hugo hugo = new hugo();
                    hugo.ShowDialog();
                }
                else if (selectedMenecer == "lcwaikiki")
                {
                    lc lc = new lc();
                    lc.ShowDialog();
                }

            }
            
        }
       
    }
}
