using CalculatorForCreditCardInterest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorForCreditCardInterestTest
{
	[TestClass()]
	public class PersonTest
	{
        [TestMethod()]
        public void CalculateInterestTest()
        {
            List<CreditCard> creditCards1 = new List<CreditCard>();
            creditCards1.Add(new CreditCard("Visa", 100));
            creditCards1.Add(new CreditCard("MC", 100));

            List<CreditCard> creditCards2 = new List<CreditCard>();
            creditCards2.Add(new CreditCard("Discover", 100));

            List<Wallet> wallets = new List<Wallet>();
            wallets.Add(new Wallet(creditCards1));
            wallets.Add(new Wallet(creditCards2));

            Person person = new Person(wallets, "Person");

            double personInterest = person.CalculateInterest();

            Assert.AreEqual(16, personInterest);
        }
    }
}
