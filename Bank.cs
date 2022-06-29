using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Bank
    {
        public Card CurrentCard;

        public Bank(Card kort)
        {
            CurrentCard = kort;
        }

        public void Deposit()
        {
            Console.Clear();
            Console.WriteLine("Hvor mye ønsker du å sette inn: ");
            double deposit = Double.Parse(Console.ReadLine());
            CurrentCard.Balance = CurrentCard.Balance + deposit;
            Console.WriteLine("Innskudd var vellykket, din nye saldo er: " + CurrentCard.Balance);
        }


        public void Withdraw()
        {
            Console.Clear();
            Console.WriteLine("Hvor mye ønsker du å ta ut: ");
            double withdraw = Double.Parse(Console.ReadLine());
            // Skjekke om bruker har nok penger til å ta ut
            if (CurrentCard.Balance < withdraw)
            {
                Console.WriteLine("Du har ikke nok penger på kontoen :(");
            }
            else
            {
                CurrentCard.Balance = CurrentCard.Balance - withdraw;
                Console.WriteLine("Uttak vellykket :)");
            }


        }

        public void Balance()
        {
            Console.Clear();
            Console.WriteLine("Saldo: " + CurrentCard.Balance);
        }



    }
}
