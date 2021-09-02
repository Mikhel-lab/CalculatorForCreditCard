using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorForCreditCardInterest
{
    public class Person
    {
        private List<Wallet> _wallets;
        private string _name;

        public List<Wallet> Wallets
        {
            get
            {
                return _wallets;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public Person(string name)
        {
            _wallets = new List<Wallet>();
            _name = name;
        }

        public Person(List<Wallet> newWallets, string name)
        {
            _wallets = newWallets;
            _name = name;
        }

        public void AddWallet(Wallet newWallet)
        {
            Wallets.Add(newWallet);
        }

        public double CalculateInterest()
        {
            Console.WriteLine($"Interest calculation for {Name}");

            double sumInterest = 0.0;
            double interestPerWallet = 0.0;
            int walletCount = 1;
            foreach (Wallet wallet in Wallets)
            {
                Console.WriteLine($"Interest for wallet {walletCount}:");
                interestPerWallet = wallet.CalculateInterest();
                Console.WriteLine($"total interest for wallet {walletCount} is {interestPerWallet:C}");
                walletCount++;

                sumInterest += interestPerWallet;
            }

            return sumInterest;
        }
    }
}