using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Strategy
{
    internal class CustomerBill
    {
        private IList<double> drinks;


        // Get/Set Strategy
        public IBillingStrategy Strategy { get; set; }


        public CustomerBill(IBillingStrategy strategy)
        {
            this.drinks = new List<double>();
            this.Strategy = strategy;
        }


        public void Add(double price, int quantity)
        {
            this.drinks.Add(this.Strategy.GetActPrice(price * quantity));
        }


        // Payment of bill
        public void Print()
        {
            double sum = 0;
            foreach (var drinkCost in this.drinks)
            {
                sum += drinkCost;
            }
            Console.WriteLine($"Total due: {sum}.");
            this.drinks.Clear();
        }

    }
}
