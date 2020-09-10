using System;

namespace SummerWorkTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            string product;
            double cost=0;
            int numberOfProducts = 0;
            double costLeastExpensive, costMostExpensive;
            string leastExpensiveProduct, mostExpensiveProduct;
            double totalCost=0;
            const double VAT = 0.20;

            do
            {
                Console.WriteLine("Product: ");
                product = Console.ReadLine();
            } while (product == String.Empty);
            if (product != "None")
            {
                string costAsString;
                do
                {
                    Console.WriteLine("Cost: ");
                    costAsString = Console.ReadLine();
                } while (!Double.TryParse(costAsString, out cost));
                
                mostExpensiveProduct = leastExpensiveProduct = product;
                costMostExpensive = costLeastExpensive = cost;

                while (product != "None")
                {
                    numberOfProducts++;
                    totalCost += cost;
                    do
                    {
                        Console.WriteLine("Product: ");
                        product = Console.ReadLine();
                    } while (product == String.Empty);

                    if (product == "None") { break; }
                    
                    do
                    {
                        Console.WriteLine("Cost: ");
                        costAsString = Console.ReadLine();
                    } while (!Double.TryParse(costAsString, out cost));

                    if (cost > costMostExpensive)
                    {
                        mostExpensiveProduct = product;
                        costMostExpensive = cost;
                    }
                    else if (cost < costLeastExpensive)
                    {
                        leastExpensiveProduct = product;
                        costLeastExpensive = cost;
                    }
                }

                double averageCost = totalCost / numberOfProducts;
                Console.WriteLine("The average price is £" + averageCost.ToString("0.00"));
                Console.WriteLine("The most expensive product is "+ mostExpensiveProduct+" and it costs £" + costMostExpensive.ToString("0.00"));
                Console.WriteLine("The least expensive product is " + leastExpensiveProduct + " and it costs £" + costLeastExpensive.ToString("0.00"));
                
                double discount = 0.05;
                if (totalCost > 50)
                {
                    totalCost -= totalCost * discount;
                }
                totalCost += totalCost * VAT;
                Console.WriteLine("The total cost is £" + totalCost.ToString("0.00") + " VAT included");
            }

        }
    }
}
