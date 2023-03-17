using System;
using Course12Enums.Entities;
using Course12Enums.Entities.Enums;

namespace Course12Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            string txt = OrderStatus.PendingPayment.ToString(); // Converte o enumerador para texto

            //OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");     // Converte o texto para enumerador

            Console.WriteLine(order);
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
