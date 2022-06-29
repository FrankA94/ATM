using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Item
    {

        //Properties
        public string ItemName { get; set; }
        public int Price { get; set; }
  

        //Field
        //public string name;



        //Constructor
        public Item(string itemName, int price)
        {
            ItemName = itemName;
            Price = price;
        


    }
}
}
