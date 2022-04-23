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
        public string ResPerson;
        public int Appeals;
        public int RKKs;
        public int Total;

        public General(string resPerson, int appeals, int rkks)
        {
            ResPerson = resPerson;
            Appeals = appeals;
            RKKs = rkks;
            Total = Appeals + RKKs;
        }

        public override string ToString()
        {
            if (ResPerson == "Баль Н.Г.")
            {
                return $"{ResPerson}\t\t\t{RKKs}\t\t\t{Appeals}\t\t\t{Total}";
            }
            else
            {
                return $"{ResPerson}\t\t{RKKs}\t\t\t{Appeals}\t\t\t{Total}";
            }
        }
    }
}
