using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class General
    {
        public string Name;
        public string ResPerson;
        public int Appeals;
        public int RKKs;
        public int Total;

        public General(string name, string resPerson, int appeals, int rkks)
        {
            Name = name;
            ResPerson = resPerson;
            Appeals = appeals;
            RKKs = rkks;
            Total = Appeals + RKKs;
        }

        public override string ToString()
        {
            return $"{ResPerson}\t\t\t\t\t{RKKs}\t\t\t\t\t{Appeals}\t\t\t\t\t\t{Total}";
        }
    }
}
