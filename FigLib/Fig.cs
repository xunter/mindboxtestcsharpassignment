using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigLib
{
    public class Fig
    {
        public static double CalcCircleArea(double r)
        {
            return Math.PI * r * r;
        }

        public static double CalcTriangleArea(double a, double b, double c)
        {
            //https://keisan.casio.com/exec/system/1223267646

            double s = (a + b + c) / 2.0f;
            double sa = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return sa;
        }
    }
}
