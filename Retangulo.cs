using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOex1
{
    internal class Retangulo
    {
        
        private double h;
        private double b;
        private double a;

        public void seth(double ba)
        {
            h = ba;

        }
        public void setb(double ba)
        {
            b = ba;

        }
        public double geth()
        {
            return h;
        }
        public double getb()
        {
            return b;
        }

        public double geta()
        {
            return a;
        }

        public void calcular()
        {
            a = b * h;
        }


    }

}
