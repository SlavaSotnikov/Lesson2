using System;

namespace Task4
{
    public class Invoice
    {
        readonly public string customer, provider;
        readonly public int account;
        const int VAT = 20;  //VAT in Ukraine.
        public int Quantity { get; set; }
        public string Article { get; set; }        
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        private int CalculateVAT()
        {
            return Storage.FindPrice(Article) * VAT/ 100;
        }

        public int CalculatePriceVAT()
        {
            return Storage.FindPrice(Article) * Quantity + CalculateVAT();
        }
        public int CalculatePrice()
        {
            return Storage.FindPrice(Article) * Quantity;
        }




        /*public void ShowPriceVAT()
        {
            Console.WriteLine($"Your order: {Storage.FindPrice(Article)}. " +
                $"Quantity: {Quantity}. Total: {CalculatePriceVAT()}.");
        }
        public void ShowPrice()
        {
            Console.WriteLine($"Your order: {Storage.FindPrice(Article)}. " +
                $"Quantity: {Quantity}. Total no VAT: {CalculatePrice()}.");
        }
        */
    }
}
