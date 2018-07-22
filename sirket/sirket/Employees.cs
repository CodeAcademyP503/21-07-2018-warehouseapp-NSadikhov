using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirket
{
    public enum Vezife
    {
        satici = 500,
        magazaMeneceri = 1500,
        saticiKomekcisi = 250,
        basSatici = 1000
    }

    public class Employees
    {
        public string name { get; set; }
        public string surname { get; set; }
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (value.IndexOf('@')>0)
                {
                    email = value;
                }
            }
        }
        public int emekHaqqi { get; set; }
        public Markets markets { get; set; }
        public Vezife vezife { get; set; }
        
    }
}
