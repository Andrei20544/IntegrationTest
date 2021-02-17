using System;
using Xunit;
using MathLibrary;

namespace XUnitIntegrationTest
{
    public class UnitTest1
    {
        private int angle = 15;
        private double angleRad = MathLib.GetRadAngle(15);

        public void GetAssert(int round, double ActData, double Data)
        {
            Assert.Equal(Math.Round(Data, round, MidpointRounding.ToNegativeInfinity),
                Math.Round(ActData, round, MidpointRounding.ToNegativeInfinity), round);
        }

        //Sin Test
        [Fact]
        public void TestSin()
        {
            double sinAct = Math.Sin(angleRad);
            double mySin = MathLib.GetSin(angle);


            GetAssert(4, sinAct, mySin);
            //Assert.Equal(Math.Round(mySin, 2, MidpointRounding.ToNegativeInfinity), 
            //    Math.Round(sinAct, 2, MidpointRounding.ToNegativeInfinity), 2);
        }

        //Cos Test
        [Fact]
        public void TestCos()
        {
            double cosAct = Math.Cos(angleRad);
            double myCos = MathLib.GetCos(angle);

            GetAssert(4, cosAct, myCos);
            //Assert.Equal(Math.Round(myCos, 3, MidpointRounding.ToNegativeInfinity),
            //    Math.Round(cosAct, 3, MidpointRounding.ToNegativeInfinity), 3);
        }

        //Cot Test
        [Fact]
        public void TestCot()
        {
            double cotAct = Math.Cos(angleRad) / Math.Sin(angleRad);
            double myCot = MathLib.GetCot(angle);

            GetAssert(4, cotAct, myCot);
        }

        //Sec Test
        [Fact]
        public void TestSec()
        {
            double secAct = 1 / Math.Cos(angleRad);
            double mySec = MathLib.GetSec(angle);

            GetAssert(4, secAct, mySec);
        }

        //BigFormul Test
        [Fact]
        public void TestBigForm()
        {
            double formAct = MathLib.GetBigFormWithMath(angle);
            double myForm = MathLib.GetBigForm(angle);

            GetAssert(4, formAct, myForm);
        }
    }
}
