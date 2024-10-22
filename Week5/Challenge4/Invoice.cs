using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    public class Invoice
    {
        public string ItemName;
        public int Quantity;
        public double UnitPrice;
        public double TotalAmount
        {
            get
            {
                return UnitPrice * Quantity;
            }
        }

       public Invoice(string itemName, int quantity, double unitPrice)
        {

            ItemName = itemName;
            Quantity = quantity;
            UnitPrice = unitPrice;

        }

        public void DisplayInfo()
        {

            Console.WriteLine("Invoice Details: ");
            Console.WriteLine($"Item Name: {ItemName}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Unit Price: {UnitPrice}");
            Console.WriteLine($"Total Amount: {TotalAmount}");

        }

    }
}
