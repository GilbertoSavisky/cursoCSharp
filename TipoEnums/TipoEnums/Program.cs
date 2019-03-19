using System;
using TipoEnums.Entities;
using TipoEnums.Entities.Enums;

namespace TipoEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment
            };

            Console.WriteLine(order);
        }
    }
}
