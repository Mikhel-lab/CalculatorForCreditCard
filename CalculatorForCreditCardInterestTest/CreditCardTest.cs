using CalculatorForCreditCardInterest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorForCreditCardInterestTest
{
    [TestClass()]
    public class CreditCardTest
	{
        [TestMethod()]
        public void CalculateInterestTest()
        {
           CreditCard visa = new CreditCard("Visa", 100);
           CreditCard MC = new CreditCard("MC", 100);
           CreditCard Discovery = new CreditCard("Discover", 100);

            double visaInterest = visa.CalculateInterestRate();
            double mcInterest = MC.CalculateInterestRate();
            double discoveryInterest = Discovery.CalculateInterestRate();

            Assert.AreEqual((double)10, visaInterest);
            Assert.AreEqual((double)5, mcInterest);
            Assert.AreEqual((double)1, discoveryInterest);
        }
    }
}
