using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Atm
    {
        public Card CurrentCard;
        public CardDatabase CardDatabase;
        public Bank Bank;

        public Atm()
        {
            CardDatabase = new CardDatabase();
            CurrentCard = Login();
            Bank = new Bank(CurrentCard);
        }

        public Card Login()
        {
            string debitCardNum = "";


            Console.WriteLine("Velkommen til Simple-ATM\n\n");
            Console.WriteLine("Venligst oppgi kort.nr: ");

            Card card;

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    // Sjekke opp mot database
                    card = CardDatabase.Cards.FirstOrDefault(a => a.CardNum == debitCardNum);
                    if (card != null) { break; }
                    else { Console.WriteLine("Kjenner ikke igjen kort.nr, vennligst prøv igjen"); }
                }
                catch { Console.WriteLine("Kjenner ikke igjen kort.nr, vennligst prøv igjen"); }
            }
            Console.Clear();

            Console.WriteLine("Skriv inn pin-kode: ");
            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    // Sjekke opp mot database
                    if (card.Pin == userPin) 
                    {
                        return card;
                    }
                    else { Console.WriteLine("Feil pin-kode, prøv igjen"); }
                }
                catch { Console.WriteLine("Feil pin-kode, prøv igjen"); }
            }
            
        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("Velkommen " + CurrentCard.FirstName + " :)");
            int option = 0;
            do
            {
                printOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if (option == 1) { Bank.Deposit(); }
                else if (option == 2) { Bank.Withdraw(); }
                else if (option == 3) { Bank.Balance(); }
               // else if (option == 4) { Store.Butikk(); }
                else if (option == 5) { break; }
                else { option = 0; }
            }
            while (option != 5);
            Console.WriteLine("\nTakk, ha en fin dag! :)");
        }

        private void printOptions()
        {
            Console.WriteLine("Venligst velg et av alternativene...");
            Console.WriteLine("1. Innskudd");
            Console.WriteLine("2. Uttak");
            Console.WriteLine("3. Vis Saldo");
            //TEST
            Console.WriteLine("4. Kjøp noe");
            //TEST
            Console.WriteLine("5. Avslutt");
        }


        
    }
}
