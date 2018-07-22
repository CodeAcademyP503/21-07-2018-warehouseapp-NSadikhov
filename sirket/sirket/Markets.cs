using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirket
{ 
    public enum MarketName{
        LcWaikiki,
        Mango,
        HugoBoss,
        NewYorker
    }

    public class Markets
    {

        public MarketName name { get; set; }
        public string adress { get; set; }
        public Employees[] employees = new Employees[4];
    }
}
