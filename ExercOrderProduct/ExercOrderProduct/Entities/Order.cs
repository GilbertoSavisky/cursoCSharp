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
                sum += item.Price;
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Sumary:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (");
            sb.Append(Client.Email);
            sb.Append(") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order Items:");
            foreach (OrderItem c in Items)
            {
                sb.Append($"{c.Product.Name}, " +
                    $"${c.Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                    $"Quantity: {c.Quantity}, " +
                    $"Subtotal: " +
                    $"${c.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
