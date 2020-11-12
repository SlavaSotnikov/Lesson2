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

            Console.WriteLine($"Your order: {Storage.FindPrice(invoice.Article)}. " +
                $"Quantity: {invoice.Quantity}. Total: {invoice.CalculatePriceVAT()}.");

            Console.ReadLine();
        }
    }
}
