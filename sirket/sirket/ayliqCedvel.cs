using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirket
{
    public enum planka
    {
        G0M ,
        G0NY ,
        G0HB ,
        G0LW 
    }

    public class ayliqCedvel
    {
        public Employees employees; 
        public planka planka { get; set; }
        public int bonus { get; set; }
        public int totalMebleg { get; set; }
    }
}
