using System;
using System.Threading;
using static System.Console;
namespace OrderingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Write("Please enter the customer id to place the order: ");
                var customerName = ReadLine();

                if (string.IsNullOrEmpty(customerName)) break;

                var orderId = Guid.NewGuid();
                WriteLine($"Placing order for Customer {customerName} with Order {orderId}");
                Thread.Sleep(3000);

                WriteLine($"Order {orderId} has been placed!");
            }
        }
    }
}
