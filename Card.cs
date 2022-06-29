using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    //hele driten herfra å ned er classe din dust
    internal class Card
    {
        //Properties
        public string CardNum { get; set; }
        public int Pin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }
        
        //Field
        //public string name;

        
        
        //Constructor
        public Card(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            CardNum = cardNum;
            Pin = pin;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }


    }
}
