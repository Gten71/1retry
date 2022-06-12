using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    internal class Class1
    {
        public double A { get; set; }
        public double B { get; set; }

        public Class1(double a, double b)
        {
            A = a;
            B = b;
        }
        public double Raznost()
        {
            return Math.Sqrt(A - B /2 );
        }
    }
}