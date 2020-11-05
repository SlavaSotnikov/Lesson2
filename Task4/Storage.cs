using System;
namespace Task4
{
    public class Storage
    {
        public static int FindOutPrice(string article)
        {
            int cost;
            switch (article)
            {
                case "iPhone":
                    return cost = 3000;
                case "Samsung":
                    return cost = 2000;
                case "Huawei":
                    return cost = 1000;
                
            }
            return 0;
        }
    }
}
