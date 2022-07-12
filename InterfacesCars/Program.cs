using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.exercisescsharp.com/oop/interfaces
// what is a builder in the Car class?
namespace InterfacesCars
{
    public interface IVehiculo
    {
        public void Drive();
        public bool Refuel(int gasolineAmount);
    }
    public class Car : IVehiculo
    {
        public int Gasoline { get; set; } // is that prop necessary?
        public Car(int gasolineAmount)
        {
            this.Gasoline = gasolineAmount;
        }

        public void Drive()
        {
            Console.WriteLine("Driving");
            //throw new NotImplementedException();
        }

        public bool Refuel(int gasolineAmount) // why bool?
        {
            if (gasolineAmount > 0)
            {
                Drive();
            }
            else
            {
                Console.WriteLine("Refueling");
            }
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of gasoline: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            var car = new Car(userInput);
            car.Refuel(); 

        }
    }
}