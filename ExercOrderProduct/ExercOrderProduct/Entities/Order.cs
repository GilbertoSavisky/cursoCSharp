using System;
using System.Collections.Generic;
using ExercOrderProduct.Entities.Enums;
using System.Text;
using System.Globalization;

namespace ExercOrderProduct.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Client = client;
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n\nOrder Sumary:");
            sb.AppendLine("Order moment: "+ Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: "+ Status.ToString());
            sb.AppendLine("Client: "+ Client.Name+ " (" + Client.BirthDate + ") - " + Client.Email);
            
            sb.AppendLine("\n\nOrder Items:");
            
            foreach (OrderItem c in Items)
            {
                sb.Append($"{c.Product.Name}, " +
                    $"${c.Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                    $"\tQuantity: {c.Quantity}, " +
                    $"\tSubtotal: " +
                    $"\t${c.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
