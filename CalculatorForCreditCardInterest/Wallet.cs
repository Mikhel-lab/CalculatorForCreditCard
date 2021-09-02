using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorForCreditCardInterest
{
	 public class Wallet
     {
        List<CreditCard> _creditCards;
        public Wallet()
        {
            _creditCards = new List<CreditCard>();
        }

        public Wallet(List<CreditCard> creditCards)
        {
            _creditCards = creditCards;
        }
       

        public void AddCard(string cardType, double balance)
        {
            _creditCards.Add(new CreditCard(cardType, balance));
        }

        public double CalculateInterest()
        {
            double walletInterest = 0.0;
            double cardInterest = 0.0;
            
            foreach (CreditCard card in _creditCards)
            {
                cardInterest = card.CalculateInterestRate();
                Console.WriteLine($"Interest for card type {card.CardType} is {cardInterest:C}");
                walletInterest += cardInterest;
            }

            return walletInterest;
        }
     
    }
}
