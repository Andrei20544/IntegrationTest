using System;

namespace MathLibrary
{
    public class MathLib
    {
        private static double cos, sin, cot, sec, endForm, withMath;
       
        public static double GetRadAngle(double angle)
        {
            double rad = 180 / Math.PI;
            return angle / rad;
        }

        public static double GetCos(double x)
        {
            double doubPI = (Math.PI * Math.PI);
            double TwoPI = Math.PI * 2;
            double doubX = x * x;

            //cos = (doubPI - 4 * doubX) / doubPI + doubX;
            //cos = 1 - ((20 * doubX) / ((4 * doubX) + (TwoPI * TwoPI)));
            cos = Math.Sqrt(1 - Math.Pow(GetSin(x), 2));

            return cos;
        }
        public static double GetSin(double x)
        {
            sin = (Math.Pow((x * (Math.PI / 180)), 5) / 120) -
                (Math.Pow((x * (Math.PI / 180)), 3) / 6) + x * (Math.PI / 180);
            return sin;
        }

        public static double GetCot(double x)
        {           
            cot = GetCos(x) / GetSin(x);
            return cot;
        }

        public static double GetSec(double x)
        {
            sec = 1 / GetCos(x);
            return sec;
        }

        public static double GetBigForm(double x)
        {
            endForm = ((Math.Pow(((GetCos(x) * GetSin(x)) * GetCot(x)), 2)) * GetCot(x)) - (GetSec(x) / GetCot(x));
            return endForm;
        }

        public static double GetBigFormWithMath(double x)
        {
            double angle = GetRadAngle(x);
            double cot = Math.Cos(angle) / Math.Sin(angle);

            withMath = ((Math.Pow(((Math.Cos(angle) * Math.Sin(angle)) * cot), 2)) * cot) - ((1 / Math.Cos(angle)) / cot);
            return withMath;
        }
    }
}
