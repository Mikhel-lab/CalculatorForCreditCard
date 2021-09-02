using System;
using System.Collections.Generic;

namespace CalculatorForCreditCardInterest
{
	class Program
	{
        static void Main(string[] args)
        {
            /*•	1 person has 1 wallet and 3 cards (1 Visa, 1 MC 1 Discover) – Each Card has a balance of $100 – calculate the total interest (simple interest) for this person and per card. 
            */
            Console.WriteLine("Case 1:");
            List<CreditCard> cardTypesCase1 = new List<CreditCard>();
            cardTypesCase1.Add(new CreditCard("Visa", 100));
            cardTypesCase1.Add(new CreditCard("MC", 100));
            cardTypesCase1.Add(new CreditCard("Discover", 100));

            List<Wallet> walletsCase1 = new List<Wallet>();
            walletsCase1.Add(new Wallet(cardTypesCase1));

            Person mike = new Person(walletsCase1, "Michael");

            double mikeInterest = mike.CalculateInterest();
            Console.WriteLine($"Total interest for Michael is {mikeInterest:C}");
            Console.WriteLine("..............################......................");

            /* • 1 person has 2 wallets  Wallet 1 has a Visa and Discover , wallet 2 a MC -  each card has $100 balance - calculate the total interest(simple interest) for this person and interest per wallet
            */
            Console.WriteLine("Case 2:");
            List<CreditCard> cardTypesWallet1 = new List<CreditCard>();
            cardTypesWallet1.Add(new CreditCard("Visa", 100));
            cardTypesWallet1.Add(new CreditCard("Discover", 100));

            List<CreditCard> cardTypesWallet2 = new List<CreditCard>();
            cardTypesWallet2.Add(new CreditCard("MC", 100));

            List<Wallet> walletsCase2 = new List<Wallet>();
            walletsCase2.Add(new Wallet(cardTypesWallet1));
            walletsCase2.Add(new Wallet(cardTypesWallet2));

            Person aiyetan = new Person(walletsCase2, "Aiyetan");

            double aiyetanInterest = aiyetan.CalculateInterest();
            Console.WriteLine($"Total interest for Aiyetan is {aiyetanInterest:C}");
            Console.WriteLine("..............################......................");


            /* • 2 people have 1 wallet each,  person 1 has 1 wallet , with 2 cards MC and visa person 2 has 1 wallet – 1 visa and 1 MC -  each card has $100 balance - calculate the total interest(simple interest) for each person and interest per wallet
            */
            Console.WriteLine("Case 3:");

            List<CreditCard> cardTypesCase3Wallet1 = new List<CreditCard>();
            cardTypesCase3Wallet1.Add(new CreditCard("MC", 100));
            cardTypesCase3Wallet1.Add(new CreditCard("Visa", 100));

            List<Wallet> walletsCase3Person1 = new List<Wallet>();
            walletsCase3Person1.Add(new Wallet(cardTypesCase3Wallet1));

            Person johnson = new Person(walletsCase3Person1, "Johnson");

            List<CreditCard> cardTypesCase3Wallet2 = new List<CreditCard>();
            cardTypesCase3Wallet2.Add(new CreditCard("MC", 100));
            cardTypesCase3Wallet2.Add(new CreditCard("Visa", 100));

            List<Wallet> walletsCase3Person2 = new List<Wallet>();
            walletsCase3Person2.Add(new Wallet(cardTypesCase3Wallet2));

            Person james = new Person(walletsCase3Person2, "James");

            double johnsonInterest = johnson.CalculateInterest();
            double jamesInterest = james.CalculateInterest();

            Console.WriteLine($"Total interest for Johnson is {johnsonInterest:C}");
            Console.WriteLine($"Total interest for James is {jamesInterest:C}");
            Console.WriteLine("..............################......................");
        }
    }
}
