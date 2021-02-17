using System;
using System.Linq;
using MathLibrary;

namespace Lab_2_integrationTest
{
    class Program
    {
        private static int round = 3;
        private static string strSpace = "";
        static void Main(string[] args)
        {

            Console.WriteLine("Sin: ,|| Cos: ,|| Cot: ,|| Sec: ");
            for (double i = 30; i <= 90; i += 15)
            {
                GetMathStr(i, Math.Sin(MathLib.GetRadAngle(i)), MathLib.GetSin(i));

                Console.Write("  ||  ");
                GetMathStr(i, Math.Cos(MathLib.GetRadAngle(i)), MathLib.GetCos(i));
                
                Console.Write("  ||  ");
                GetMathStr(i, (1 / Math.Tan(MathLib.GetRadAngle(i))), MathLib.GetCot(i));

                Console.Write("  ||  ");
                GetMathStr(i, (1 / Math.Cos(MathLib.GetRadAngle(i))), MathLib.GetSec(i));          

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("End: ");
            for (double i = 10; i <= 180; i+= 20)
            {
                GetMathStr(i, MathLib.GetBigFormWithMath(i), MathLib.GetBigForm(i));
                Console.WriteLine();
            }
        }

        public static void GetMathStr(double i, double math, double myMath)
        {
            try
            {
                double myMathRound = Math.Round(myMath, round);
                double mathRound = Math.Round(math, round);
                

                if (myMathRound.ToString().Length < 6)
                {
                    GetStrSpace(myMathRound.ToString().Length);
                }
                Console.Write(strSpace + myMathRound);
                if (mathRound.ToString().Length < 6)
                {
                    GetStrSpace(mathRound.ToString().Length);
                }
                Console.Write(" -- " + strSpace + mathRound);

                strSpace = "";
            }
            catch(Exception e)
            {
                Console.WriteLine("Error!!!");
            }
            
        }
        public static string GetStrSpace(int strLenght)
        {
            strSpace = string.Concat(Enumerable.Repeat(" ", 5 - strLenght));
            return strSpace;
        }

    }
}
