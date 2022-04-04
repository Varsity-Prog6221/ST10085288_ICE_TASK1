using System;

namespace st10085288_PROG_ICE_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool blcontinue = true;
            Console.WriteLine("TAKE 5 \n===================");
            Item[] item = new Item[5];
            
          
            while (blcontinue == true)
                {
                try
                {
                    
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("ENTER ITEM NAME: ");
                        string itemName = Console.ReadLine();
                        Console.Write("ENTER ITEM PRICE: R");
                        double itemPrice = Double.Parse(Console.ReadLine());
                        if (itemPrice < 0)
                            throw new ApplicationException("Number can’t be negative");
                        item[i] = new Item(itemName, itemPrice);                        
                    }

                    Cart ObjCart = new Cart(item);
                    Console.WriteLine(ObjCart.ToString());    

                    Console.WriteLine("Do you want to continue? \n(Y/y) for YES \nAny other key for N");
                    string sContinue = Console.ReadLine().ToUpper();
                    if (sContinue.Equals("Y"))
                    {
                        blcontinue = true;
                    }
                    else
                    {
                        blcontinue = false;
                        Environment.Exit(0);

                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("PLEASE ENTER A NUMBER AT THE PRICE FIELD");
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }


            
        }

        
    }
}
