using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st10085288_PROG_ICE_Task1
{
    class Cart : Item
    {

        private double totalPrice;
        private double totalVat;
        private Item[] ItemArr = new Item[5];

        public double TotalPrice1 { get => totalPrice; set => totalPrice = value; }
        public double TotalVat1 { get => totalVat; set => totalVat = value; }
        public Item[] ItemArr1 { get => ItemArr; set => ItemArr = value; }

        public Cart(Item[] ItemArr) 
        {                         
            this.ItemArr1 = ItemArr;
            TotalPrice();
            TotalVat();
        }

        public  void TotalPrice()
        {
            foreach (Item item in ItemArr1)
            {
                this.TotalPrice1 += item.ItemPrice;
            }           
        }

        public  void TotalVat()
        {
            this.TotalVat1 = Math.Round(this.TotalPrice1 * 0.14, 2);
        }

        public  double GrandTotal()
        {
              return this.TotalPrice1 + this.TotalVat1;
        }


        public override String ToString()
        {
            string text = "------------------------------------------------------------------------------------------------------";
            
            foreach (Item i in ItemArr1)
            {
                text +=  "\nItem " + i.ItemName + " R" + i.ItemPrice;

            }
            text += $"\n-------------------\n Total R {this.TotalPrice1} " +
                   $"\n + VAT R {this.TotalVat1 } \n------------------------------" +
                   $"\n Grand Total: R {GrandTotal()}" +
                   $"\n------------------------------ ";

            return text;
        }
    }
}
