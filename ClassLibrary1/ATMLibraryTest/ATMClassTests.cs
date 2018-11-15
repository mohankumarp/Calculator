using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.vm;


namespace com.vm.test
{
    [TestClass]
    public class ATMClassTest
    {

        [TestMethod]
        public void Test_invallid_pin()
        {
            ATMClass.StatusCode result = ATMClass.Transaction(2115, 1, 100);
            Assert.AreEqual(result, ATMClass.StatusCode.INVALID_PIN);
        }

        [TestMethod]
        public void Test_withdraw_cash()
        {
            ATMClass.StatusCode result = ATMClass.Transaction(3551, 2, 100);
            Assert.AreEqual(result, ATMClass.StatusCode.SUCCESS);
        }

        [TestMethod]
        public void Test_withdraw_cash_invalid_denomination()
        {
            Assert.AreEqual(ATMClass.Transaction(3551, 2, 102), ATMClass.StatusCode.INVALID_DENOMINATION);
        }

        [TestMethod]
        public void Test_deposit_cash()
        {
            Assert.AreEqual(ATMClass.Transaction(3551, 3, 100), ATMClass.StatusCode.SUCCESS);
        }
    }
}
