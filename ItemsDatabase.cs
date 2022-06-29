using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ItemsDatabase
    {
        // Denne klassa skal ligne en del på Card Database
        public List<Item> Items = new List<Item>();

        public ItemsDatabase()
        {
            Items.Add(new Item("Apekatt", 1000));
            Items.Add(new Item("Potet", 20));
            Items.Add(new Item("Rusten spiker", 5));
            Items.Add(new Item("Vodka", 250));
            Items.Add(new Item("Sofa", 2000));
            Items.Add(new Item("Kokosnøtt", 35));
        }
    }
}
