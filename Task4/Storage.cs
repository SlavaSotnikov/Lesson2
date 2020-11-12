using System;
namespace Task4
{
    public class Storage
    {
        public static int FindPrice(string article)
        {
            int price;
            switch (article)
            {
                case "iPhone":
                    return price = 3000;
                case "Samsung":
                    return price = 2000;
                case "Huawei":
                    return price = 1000;
                
            }
            return 0;
        }
    }
}
