using Assignment_Of_December;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Of_December
{
    public class Sweet
    {
        public string Name { get; }
        public double Price { get; }

        public Sweet(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
    class Order
    {
        public Sweet OrderedSweet { get; }
        public int Quantity { get; }

        public Order(Sweet sweet, int quantity)
        {
            OrderedSweet = sweet;
            Quantity = quantity;
        }

        public double CalculateTotalPrice()
        {
            return Quantity * OrderedSweet.Price;
        }
    }
    class SweetShop
    {
        private List<Sweet> sweets;
        private List<Order> orders;

        public SweetShop()
        {
            sweets = new List<Sweet>
            {
                new Sweet("Chocolate Bar", 2.5),
                new Sweet("Cupcake", 1.8),
                new Sweet("Lollipop", 0.5)
            };
            orders = new List<Order>();
        }

        public void DisplaySweets()
        {
            Console.WriteLine("Available Sweets:");
            for (int i = 0; i < sweets.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {sweets[i].Name} - ${sweets[i].Price}");
            }
        }

        public void PlaceOrder(int sweetIndex, int quantity)
        {
            if (sweetIndex >= 0 && sweetIndex < sweets.Count && quantity > 0)
            {
                Order newOrder = new Order(sweets[sweetIndex], quantity);
                orders.Add(newOrder);
                Console.WriteLine("Order placed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }

        public void GenerateBill()
        {
            double totalAmount = 0;

            Console.WriteLine("Bill Summary:");
            foreach (var order in orders)
            {
                Console.WriteLine($"{order.OrderedSweet.Name} - Quantity: {order.Quantity} - Total Price: ${order.CalculateTotalPrice()}");
                totalAmount += order.CalculateTotalPrice();
            }

            Console.WriteLine($"Total Amount: ${totalAmount}");
        }


        public void PlaceOrderOnline()
        {
            Console.WriteLine("Home Delivery placed successfully!");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SweetShop shop = new SweetShop();

            Console.WriteLine("Welcome to the Sweet Shop!");
            bool shopping = true;

            while (shopping)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Display Available Sweets");
                Console.WriteLine("2. Place an Order");
                Console.WriteLine("3. Generate Bill");
                Console.WriteLine("4. Place Order for Home Delivery");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            shop.DisplaySweets();
                            break;
                        case 2:
                            Console.Write("Enter the sweet number: ");
                            int sweetIndex = int.Parse(Console.ReadLine()) - 1;
                            Console.Write("Enter the quantity: ");
                            int quantity = int.Parse(Console.ReadLine());
                            shop.PlaceOrder(sweetIndex, quantity);
                            break;

                    }

                }
            }
            Console.ReadLine();

        }
    }
}