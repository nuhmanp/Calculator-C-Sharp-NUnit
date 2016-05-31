using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /*
         * Identifier: 1.1
         * Description: Testing 0/13 = 0
         * inputs: 0,13
         * Action: do the division
         * Expected result: it will give 0
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to divide 0/13
        */

        public void Test0DivideBy13()
        {

            //Initialize
            double i = 0;
            double j = 13;

            //Act
            double result = Calculator.Form1.division(i, j);

            //Report
            Assert.AreEqual(0, result);

        }
        [TestMethod]
        /*
         * Identifier: 1.2
         * Description: Testing 0/0 = 0
         * inputs: 0,0
         * Action: do the division
         * Expected result: it will give NaN
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to divide 0/0
        */
        public void Test0DivideBy0()
        {

            //Initialize
            double i = 0;
            double j = 0;

            //Act
            double result = Calculator.Form1.division(i, j);

            //Report
            Assert.AreEqual(Double.NaN, result);

        }
        [TestMethod]
        /*
         * Identifier: 1.3
         * Description: Testing -5/10 = -0.5
         * inputs: -5,10
         * Action: do the division
         * Expected result: it will give -0.5
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to divide -5/10
        */
        public void TestMinus5DivideBy10()
        {

            //Initialize
            double i = -5;
            double j = 10;

            //Act
            double result = Calculator.Form1.division(i, j);

            //Report
            Assert.AreEqual(-0.5, result);

        }
        [TestMethod]
        /*
         * Identifier: 1.4
         * Description: Testing -5/-5 = 1
         * inputs: -5,-5
         * Action: do the division
         * Expected result: it will give 1
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to divide -5/-5
        */
        public void TestMinus5DivideByMinus5()
        {

            //Initialize
            double i = -5;
            double j = -5;

            //Act
            double result = Calculator.Form1.division(i, j);

            //Report
            Assert.AreEqual(1, result);

        }
        [TestMethod]
        /*
         * Identifier: 1.5
         * Description: Testing 8/0= infinity
         * inputs: 8,0
         * Action: do the division
         * Expected result: it will give infinity
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to divide 8/0
        */
        public void Test8DivideBy0()
        {

            //Initialize
            double i = 8;
            double j = 0;

            //Act
            double result = Calculator.Form1.division(i, j);

            //Report
            Assert.AreEqual(double.PositiveInfinity, result);

        }
        [TestMethod]
        /*
         * Identifier: 2.1
         * Description: Testing 9*0= 0
         * inputs: 9,0
         * Action: do the multiplication
         * Expected result: it will give zero
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to multiply 8*0
        */
        public void Test9MultiplyBy0()
        {

            //Initialize
            double i = 9;
            double j = 0;

            //Act
            double result = Calculator.Form1.multiplication(i, j);

            //Report
            Assert.AreEqual(0, result);

        }
        [TestMethod]
        /*
         * Identifier: 2.2
         * Description: Testing 0*0= 0
         * inputs: 0,0
         * Action: do the multiplication
         * Expected result: it will give zero
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to multipy 0*0
        */
        public void Test0MultiplyBy0()
        {

            //Initialize
            double i = 0;
            double j = 0;

            //Act
            double result = Calculator.Form1.multiplication(i, j);

            //Report
            Assert.AreEqual(0, result);

        }
        [TestMethod]
        /*
         * Identifier: 2.3
         * Description: Testing -4*-8= 32
         * inputs: -4,0
         * Action: do the multiplication
         * Expected result: it will give 32
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to multipy -4*-8
        */
        public void TestMinus4MultiplyByMinus8()
        {

            //Initialize
            double i = -4;
            double j = -8;

            //Act
            double result = Calculator.Form1.multiplication(i, j);

            //Report
            Assert.AreEqual(32, result);

        }
        [TestMethod]
        /*
         * Identifier: 2.4
         * Description: Testing -5*7= 35
         * inputs: -5,7
         * Action: do the multiplication
         * Expected result: it will give -35
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to multipy -5*7
        */
        public void TestMinus5MultiplyBy7()
        {

            //Initialize
            double i = -5;
            double j = 7;

            //Act
            double result = Calculator.Form1.multiplication(i, j);

            //Report
            Assert.AreEqual(-35, result);

        }
        [TestMethod]
        /*
         * Identifier: 2.5
         * Description: Testing -0*0= 0
         * inputs: -0,0
         * Action: do the multiplication
         * Expected result: it will give 0
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to multipy -0*0
        */
        public void TestMinus0MultiplyBy0()
        {

            //Initialize
            double i = -0;
            double j = 0;

            //Act
            double result = Calculator.Form1.multiplication(i, j);

            //Report
            Assert.AreEqual(0, result);

        }
        [TestMethod]
        /*
         * Identifier: 3.1
         * Description: Testing 0+0= 0
         * inputs: 0,0
         * Action: do the addition
         * Expected result: it will give 0
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to add 0+0
        */
        public void Test0Plus0()
        {

            //Initialize
            double i = 0;
            double j = 0;

            //Act
            double result = Calculator.Form1.addition(i, j);

            //Report
            Assert.AreEqual(0, result);

        }
        [TestMethod]
        /*
         * Identifier: 3.2
         * Description: Testing -1+1= 0
         * inputs: -1,1
         * Action: do the addition
         * Expected result: it will give 0
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to add -1+1
        */
        public void TestMinus1Plus1()
        {

            //Initialize
            double i = -1;
            double j = 1;

            //Act
            double result = Calculator.Form1.addition(i, j);

            //Report
            Assert.AreEqual(0, result);

        }
        [TestMethod]
        /*
         * Identifier: 3.3
         * Description: Testing -1+1= 0
         * inputs: -1,1
         * Action: do the addition
         * Expected result: it will give 0
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to add -1+1
        */
        public void TestMinus0Plus0()
        {

            //Initialize
            double i = -0;
            double j = 0;

            //Act
            double result = Calculator.Form1.addition(i, j);

            //Report
            Assert.AreEqual(0, result);

        }
        [TestMethod]
        /*
         * Identifier: 3.4
         * Description: Testing -7+-7= 0
         * inputs: -7,-7
         * Action: do the addition
         * Expected result: it will give -14
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to add -7+-7
        */
        public void TestMinus7PlusMinus7()
        {

            //Initialize
            double i = -7;
            double j = -7;

            //Act
            double result = Calculator.Form1.addition(i, j);

            //Report
            Assert.AreEqual(-14, result);

        }
        [TestMethod]
        /*
         * Identifier: 3.5
         * Description: Testing -340+40= 0
         * inputs: -340,-40
         * Action: do the addition
         * Expected result: it will give -340
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to add -340+40
        */
        public void TestMinus340Plus40()
        {

            //Initialize
            double i = -340;
            double j = 40;

            //Act
            double result = Calculator.Form1.addition(i, j);

            //Report
            Assert.AreEqual(-300, result);

        }
        [TestMethod]
        /*
         * Identifier: 4.1
         * Description: Testing 0-0= 0
         * inputs: 0,0
         * Action: do the subtraction
         * Expected result: it will give 0
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to subtract 0-0
        */
        public void Test0Minus0()
        {

            //Initialize
            double i = 0;
            double j = 0;

            //Act
            double result = Calculator.Form1.subtraction(i, j);

            //Report
            Assert.AreEqual(0, result);

        }
        [TestMethod]
        /*
         * Identifier: 4.2
         * Description: Testing 456-56= 400
         * inputs: 456,56
         * Action: do the subtraction
         * Expected result: it will give 400
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to subtract 456-56
        */
        public void Test456Minus56()
        {

            //Initialize
            double i = 456;
            double j = 56;

            //Act
            double result = Calculator.Form1.subtraction(i, j);

            //Report
            Assert.AreEqual(400, result);

        }
        [TestMethod]
        /*
         * Identifier: 4.3
         * Description: Testing 8-8= 0
         * inputs: 8,8
         * Action: do the subtraction
         * Expected result: it will give 0
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to subtract 8-8
        */
        public void Test8Minus8()
        {

            //Initialize
            double i = 8;
            double j = 8;

            //Act
            double result = Calculator.Form1.subtraction(i, j);

            //Report
            Assert.AreEqual(0, result);

        }
        [TestMethod]
        /*
         * Identifier: 4.4
         * Description: Testing -100-100= -200
         * inputs: -100,100
         * Action: do the subtraction
         * Expected result: it will give -200
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to subtract -100-100
        */
        public void TestMinus100Minus100()
        {

            //Initialize
            double i = -100;
            double j = 100;

            //Act
            double result = Calculator.Form1.subtraction(i, j);

            //Report
            Assert.AreEqual(-200, result);

        }
        [TestMethod]
        /*
         * Identifier: 4.5
         * Description: Testing 0-70= -70
         * inputs: 0,70
         * Action: do the subtraction
         * Expected result: it will give -70
         * Actual result: will be reported
         * Failed action: Alert the user that the user failed to subtract 0-70
        */
        public void Test0Minus70()
        {

            //Initialize
            double i = 0;
            double j = 70;

            //Act
            double result = Calculator.Form1.subtraction(i, j);

            //Report
            Assert.AreEqual(-70, result);

        }

    }
}
