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
        public void Test_add(int m, int n)
        {
            Calc Objcalc = new Calc();
            Assert.AreEqual(Objcalc.Add(m,n), 9);
        }

        [DataTestMethod]
        [DataRow(5, 4)]
        [DataRow(1, 0)]
        [DataRow(0, -1)]
        public void Test_sub(int m, int n)
        {
            Calc Objcalc = new Calc();
            Assert.AreEqual(Objcalc.Sub(m, n), 1);
        }

        [DataTestMethod]
        [DataRow(5, 4)]
        [DataRow(10, 2)]
        [DataRow(20, 1)]
        public void Test_mul(int m, int n)
        {
            Calc Objcalc = new Calc();
            Assert.AreEqual(Objcalc.Mul(m, n), 20);
        }

        [DataTestMethod]
        [DataRow(10, 5)]
        [DataRow(8, 4)]
        [DataRow(30, 15)]
        public void Test_div(int m, int n)
        {
            Calc Objcalc = new Calc();
            Assert.AreEqual(Objcalc.Div(m, n),2);
        }
    }
}
