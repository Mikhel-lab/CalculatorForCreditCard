using CalculatorForCreditCardInterest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorForCreditCardInterestTest
{
	[TestClass()]
	public class WalletTest
	{
        [TestMethod()]
        public void CalculateInterestTest()
        {
            List<CreditCard> creditCards = new List<CreditCard>();
            creditCards.Add(new CreditCard("Visa", 100));
            creditCards.Add(new CreditCard("MC", 100));

            Wallet wallet = new Wallet(creditCards);
            wallet.AddCard("Discover", 100);
            double walletInterest = wallet.CalculateInterest();
            Assert.AreEqual(16, walletInterest);
        }
    }
}
