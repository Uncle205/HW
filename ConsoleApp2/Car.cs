using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    partial class Car
    {
        private static int Count { get; set; }
        private string Name { get; set; }
        private string ConstructorCompany { get; set; }
        private int Price { get; set; }
        private DateTime DateofCreation { get; set; }
        private bool Sale;
        public string Country { get; set; }
        public void Shoping(int Price, DateTime neww)
        {
            if (Sale == true)
            {
                Console.WriteLine("Введите сумму которую можете потратить ");
                string price = Console.ReadLine();
                int price2 = int.Parse(price);
                if (price2 < Price && DateofCreation < neww)
                {
                    Console.WriteLine("Congrats homie you can take your car");
                }

            }
            else
            {
                Console.WriteLine("Не продается");
            }
        }
        public void Constructor(string NameOfConstructor)
        {
            if (ConstructorCompany == NameOfConstructor)
            {
                Console.WriteLine("Вы нашли что искали");
            }
            else
            {
                Console.WriteLine("Huh not today bro ;(");
            }
        }
        public void ChooseOfCountry(string CountryWhereWeAre)
        {
            if (Country == CountryWhereWeAre)
            {
                Console.WriteLine("You and your car are located at the same country");
            }
            else
            {
                Console.WriteLine("Your car at the another country ");
            }
        }
        static Car()
        {
            Count = 0;
        }
        public Car()
        {
            this.Country = "China";
            this.DateofCreation = new DateTime(2018, 01, 20);
            this.ConstructorCompany = "Toyta";
            this.Name = "Camry";
            this.Price = 20000000;
            this.Sale = true;
            Count++;
        }
        public Car(string Name, string ConstructorCompany, int Price, string Country)
        {
            this.Price = Price;
            this.Name = Name;
            this.ConstructorCompany = ConstructorCompany;
            this.Country = Country;
            Count++;
        }
        public Car(ref Car car)
        {
            this.Country = car.Country;
            this.DateofCreation = car.DateofCreation;
            this.ConstructorCompany = car.ConstructorCompany;
            this.Name = car.Name;
            this.Sale = car.Sale;
            Count++;
        }
    }
}
