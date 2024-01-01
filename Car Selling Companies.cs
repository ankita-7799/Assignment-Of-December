//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.ConstrainedExecution;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment_Of_December
//{
//    abstract class Cars
//    {
//        public string Model { get; set; }
//        public double Price { get; set; }

//        public Cars(string model, double price)
//        {
//            Model = model;
//            Price = price;
//        }

//        public abstract void DisplayDetails();
//    }

//    // Interface for company details
//    interface ICompany
//    {
//        void AddCar(Cars car);
//        void DisplayCars();
//    }

//    // Customer details
//    class Customer
//    {
//        public string Name { get; set; }
//        public string Contact { get; set; }
//    }

    
//    class Hyundai : ICompany
//    {
//        private List<Cars> cars = new List<Cars>();

//        public void AddCar(Cars car)
//        {
//            cars.Add(car);
//        }

//        public void DisplayCars()
//        {
//            foreach (Cars car in cars)
//            {
//                car.DisplayDetails();
//            }
//        }
//    }

//    class Honda : ICompany
//    {
//        private List<Cars> cars = new List<Cars>();

//        public void AddCar(Cars car)
//        {
//            cars.Add(car);
//        }

//        public void DisplayCars()
//        {
//            foreach (Cars car in cars)
//            {
//                car.DisplayDetails();
//            }
//        }
//    }

//    class Maruti : ICompany
//    {
//        private List<Cars> cars = new List<Cars>();

//        public void AddCar(Cars car)
//        {
//            cars.Add(car);
//        }

//        public void DisplayCars()
//        {
//            foreach (Cars car in cars)
//            {
//                car.DisplayDetails();
//            }
//        }
//    }


//    class HyundaiCar : Cars
//    {
//        public string FuelType { get; set; }

//        public HyundaiCar(string model, double price, string fuelType) : base(model, price)
//        {
//            FuelType = fuelType;
//        }

//        public override void DisplayDetails()
//        {
//            Console.WriteLine($"Hyundai {Model}, Price: ${Price}, Fuel Type: {FuelType}");
//        }
//    }

//    class HondaCar : Cars
//    {
//        public string Color { get; set; }

//        public HondaCar(string model, double price, string color) : base(model, price)
//        {
//            Color = color;
//        }

//        public override void DisplayDetails()
//        {
//            Console.WriteLine($"Honda {Model}, Price: ${Price}, Color: {Color}");
//        }
//    }

//    class MarutiCar : Cars
//    {
//        public int Year { get; set; }

//        public MarutiCar(string model, double price, int year) : base(model, price)
//        {
//            Year = year;
//        }

//        public override void DisplayDetails()
//        {
//            Console.WriteLine($"Maruti {Model}, Price: ${Price}, Year: {Year}");
//        }
//    }

   
//    class CarManagement
//    {
//        private Dictionary<string, ICompany> companies = new Dictionary<string, ICompany>();

//        public void AddCompany(string name, ICompany company)
//        {
//            companies.Add(name, company);
//        }

//        public void DisplayCarsByCompany(string companyName)
//        {
//            if (companies.ContainsKey(companyName))
//            {
//                Console.WriteLine($"{companyName} cars:");
//                companies[companyName].DisplayCars();
//            }
//            else
//            {
//                Console.WriteLine("Company not found.");
//            }
//        }
//    }

    
//    class Program2



//    {
//        static void Main(string[] args)
//        {
//            CarManagement carManagement = new CarManagement();

//            Hyundai hyundai = new Hyundai();
//            hyundai.AddCar(new HyundaiCar("i20", 15000, "Petrol"));
//            hyundai.AddCar(new HyundaiCar("Creta", 25000, "Diesel"));
//            carManagement.AddCompany("Hyundai", hyundai);

//            Honda honda = new Honda();
//            honda.AddCar(new HondaCar("Accord", 30000, "Red"));
//            honda.AddCar(new HondaCar("Civic", 20000, "Blue"));
//            carManagement.AddCompany("Honda", honda);

//            Maruti maruti = new Maruti();
//            maruti.AddCar(new MarutiCar("Swift", 12000, 2019));
//            maruti.AddCar(new MarutiCar("Baleno", 18000, 2020));
//            carManagement.AddCompany("Maruti", maruti);

//            string selectedCompany = "Hyundai"; 

//            switch (selectedCompany)
//            {
//                case "Hyundai":
//                case "Honda":
//                case "Maruti":
//                    carManagement.DisplayCarsByCompany(selectedCompany);
//                    break;
//                default:
//                    Console.WriteLine("Invalid company name.");
//                    break;
//            }



//}   }   }
