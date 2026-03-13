using Lab7.Strategy;
using Lab7.TemplateMethod;
using System;

namespace MyApp
{
    internal class Program
    {

        static void Bai1()
        {
            Console.WriteLine("********************Bai1*********************");
            var normalStrategy = new NormalStrategy();
            var happyHourStrategy = new HappyHourStrategy();


            var firstCustomer = new CustomerBill(normalStrategy);


            // Normal billing
            firstCustomer.Add(1.0, 1);


            // Start Happy Hour
            firstCustomer.Strategy = happyHourStrategy;
            firstCustomer.Add(1.0, 2);


            // New Customer
            CustomerBill secondCustomer = new CustomerBill(happyHourStrategy);
            secondCustomer.Add(0.8, 1);
            // The Customer pays
            firstCustomer.Print();


            // End Happy Hour
            secondCustomer.Strategy = normalStrategy;
            secondCustomer.Add(1.3, 2);
            secondCustomer.Add(2.5, 1);
            secondCustomer.Print();

        }
        static void Bai2()
        {
            Console.WriteLine("\n********************Bai2*********************");

            Sourdough sourdough = new Sourdough();
            sourdough.Make();


            TwelveGrain twelveGrain = new TwelveGrain();
            twelveGrain.Make();


            WholeWheat wholeWheat = new WholeWheat();
            wholeWheat.Make();


            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            Bai1();
            Bai2();
        }
    }
}