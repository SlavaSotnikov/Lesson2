using System;

namespace Task4
{
    class Invoice
    {
        readonly public string customer, provider;
        readonly public int account;
        readonly int quantity = 1;
        const byte nds = 20;  //NDS tax in Ukraine.
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        int CalculateNDS()
        {
            return Storage.price * nds / 100;
        }

        int CalculatePriceNDS()
        {
            return Storage.price * quantity + CalculateNDS();
        }
        int CalculatePrice()
        {
            return Storage.price * quantity;
        }

        public void ShowPriceNDS()
        {
            Console.WriteLine($"Your order: {Storage.label}. Quantity: {quantity}. Total: {CalculatePriceNDS()}.");
        }
        public void ShowPrice()
        {
            Console.WriteLine($"Your order: {Storage.label}. Quantity: {quantity}. Total no NDS: {CalculatePrice()}.");
        }
    }
}
