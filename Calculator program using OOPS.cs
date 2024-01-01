//using System;

//namespace Assignment_Of_December
//{
//    public interface ICalculator
//    {
//        double Add(double x, double y);
//        double Subtract(double x, double y);
//        double Multiply(double x, double y);
//        double Divide(double x, double y);
//    }

    
//    public class BasicCalculator : ICalculator
//    {
//        public double Add(double x, double y)
//        {
//            return x + y;
//        }

//        public double Subtract(double x, double y)
//        {
//            return x - y;
//        }

//        public double Multiply(double x, double y)
//        {
//            return x * y;
//        }

//        public double Divide(double x, double y)
//        {
//            if (y == 0)
//            {
//                Console.WriteLine("Cannot divide by zero!");
//                return double.NaN; // NaN (Not a Number) 
//            }
//            return x / y;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Creating an object of the BasicCalculator
//            ICalculator calculator = new BasicCalculator();

//            Console.WriteLine("Simple Calculator:");
//            Console.WriteLine("Enter two numbers:");

//            Console.Write("Enter first number: ");
//            double num1 = Convert.ToDouble(Console.ReadLine());

//            Console.Write("Enter second number: ");
//            double num2 = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Choose an operation:");
//            Console.WriteLine("1 - Addition");
//            Console.WriteLine("2 - Subtraction");
//            Console.WriteLine("3 - Multiplication");
//            Console.WriteLine("4 - Division");

//            Console.Write("Enter your choice (1-4): ");
//            int choice = Convert.ToInt32(Console.ReadLine());

//            double result = 0;

            
//            switch (choice)
//            {
//                case 1:
//                    result = calculator.Add(num1, num2);
//                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
//                    break;
//                case 2:
//                    result = calculator.Subtract(num1, num2);
//                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
//                    break;
//                case 3:
//                    result = calculator.Multiply(num1, num2);
//                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
//                    break;
//                case 4:
//                    result = calculator.Divide(num1, num2);
//                    if (!double.IsNaN(result))
//                    {
//                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
//                    }
//                    break;
//                default:
//                    Console.WriteLine("Invalid choice!");
//                    break;
//            }

//            Console.ReadLine();
//        }
//}   }