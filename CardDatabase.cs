using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class CardDatabase
    {
        public List<Card> Cards = new List<Card>();

        public CardDatabase()
        {
            Cards.Add(new Card("1", 0001, "Frank", "Omlid", 1000.50));
            Cards.Add(new Card("753572077828782", 0002, "Joakim", "Etternavn", 850.12));
            Cards.Add(new Card("442579592759237", 0003, "Benjamin", "Etternavn", 25000.85));
            Cards.Add(new Card("567252765065342", 0004, "Therese", "Etternavn", 900000.03));
            Cards.Add(new Card("327856268265001", 0005, "Eskil", "Etternavn", 36538750));
        }
        
    }
}
