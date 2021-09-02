using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorForCreditCardInterest
{
	public class CreditCard
	{
		private Dictionary<string, double> cardTypesWithInterest;
		private string cardtypes;
		private double interest;
		private double balance;

		public CreditCard(string cardtype, double bal)
		{
			if (CardTypesWithInterest.ContainsKey(cardtype))
			{
				cardtypes = cardtype;
				interest = CardTypesWithInterest[cardtypes];
				balance = bal;
			}
			else
			{
				throw new Exception($"Cannot find {cardtype}");
			}
		}
		public Dictionary<string, double> CardTypesWithInterest
		{
			get 
			{
				if (cardTypesWithInterest == null)
				{
					cardTypesWithInterest = new Dictionary<string, double>();
					cardTypesWithInterest.Add("Visa", 0.1);
					cardTypesWithInterest.Add("MC", 0.05);
					cardTypesWithInterest.Add("Discover", 0.01);
				}
				return cardTypesWithInterest;
			}
		}

		public string CardType
		{
			get
			{
				return cardtypes;
			}
		}

		public double Interest
		{
			get
			{
				return interest;
			}
		}
		public double Balance
		{
			get
			{
				return balance;
			}
		}

		public double CalculateInterestRate()
		{
			return (balance * interest);
		}
	}
}
