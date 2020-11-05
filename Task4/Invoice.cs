using System;

namespace Task4
{
    public class Invoice
    {
        readonly public string customer, provider;
        readonly public int account;
        const byte nds = 20;  //NDS tax in Ukraine.
        public byte Quantity { get; set; }
        public string Article { get; set; }        
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        int CalculateNDS()
        {
            return Storage.FindOutPrice(Article) * nds / 100;
        }

        int CalculatePriceNDS()
        {
            return Storage.FindOutPrice(Article) * Quantity + CalculateNDS();
        }
        int CalculatePrice()
        {
            return Storage.FindOutPrice(Article) * Quantity;
        }

        public void ShowPriceNDS()
        {
            Console.WriteLine($"Your order: {Storage.FindOutPrice(Article)}. " +
                $"Quantity: {Quantity}. Total: {CalculatePriceNDS()}.");
        }
        public void ShowPrice()
        {
            Console.WriteLine($"Your order: {Storage.FindOutPrice(Article)}. " +
                $"Quantity: {Quantity}. Total no NDS: {CalculatePrice()}.");
        }
    }
}
