using System;

namespace Task4
{
    class Program
    {
        static void Main()
        {
            Invoice invoice = new Invoice(01234, "Smith", "Horns & Hooves") 
            {
                Article = "iPhone", 
                Quantity = 3
            };
            
            Console.WriteLine($"Customer: {invoice.customer}, {invoice.account}. Provider: {invoice.provider}.");
            invoice.ShowPriceNDS();

            Console.ReadLine();
        }
    }
}
