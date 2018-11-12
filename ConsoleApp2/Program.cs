using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string price;
            string date;
            Car car = new Car();
            Console.WriteLine("Enter price of car which you search");
            price= Console.ReadLine();
            int price2 = int.Parse(price);
            Console.WriteLine("Enter  date of car which you search");
            date = Console.ReadLine();
            DateTime date2 = DateTime.Parse(date);
            car.Shoping(price2, date2);
        }
    }
}
