using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.vm;

namespace com.vm.test
{
    [TestClass]
    public class CalcTest
    {
        [DataTestMethod]
        [DataRow(4, 5)]
        [DataRow(-1, 10)]
        //[DataRow(5, 4)]
        public void Testadd(int m, int n)
        {
            Assert.AreEqual(Calc.Add(m,n), 9);
        }

        [DataTestMethod]
        [DataRow(5, 4)]
        [DataRow(1, 0)]
        [DataRow(0, -1)]
        public void Testsub(int m, int n)
        {
            Assert.AreEqual(Calc.Sub(m, n), 1);
        }

        [DataTestMethod]
        [DataRow(5, 4)]
        [DataRow(10, 2)]
        [DataRow(20, 1)]
        public void Testmul(int m, int n)
        {
            Assert.AreEqual(Calc.Mul(m, n), 20);
        }

        [DataTestMethod]
        [DataRow(10, 5)]
        [DataRow(8, 4)]
        [DataRow(30, 15)]
        public void Testdiv(int m, int n)
        {
            Assert.AreEqual(Calc.Div(m, n),2);
        }
    }
}
