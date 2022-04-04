using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st10085288_PROG_ICE_Task1
{
    internal class Item
    {

        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public Item(string itemName, double itemPrice)
        {
            this.ItemName = itemName;
            this.ItemPrice = itemPrice;
        }
        public Item()
        {
        }
        public virtual String ToString()
        {
            return base.ToString();
        }

    }
}
