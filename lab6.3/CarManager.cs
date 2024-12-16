using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._3
{
    internal class CarManager
    {
        private List<Car> cars;

        public CarManager()
        {
            // Khởi tạo danh sách 10 xe Car
            cars = new List<Car>
            {
                new Car("Toyota", "Red"),
                new Car("Honda", "Blue"),
                new Car("Ford", "Red"),
                new Car("BMW", "Black"),
                new Car("Mercedes", "White"),
                new Car("Kia", "Red"),
                new Car("Hyundai", "Green"),
                new Car("Nissan", "Blue"),
                new Car("Chevrolet", "Yellow"),
                new Car("Mazda", "Red")
            };
        }

        // Xóa các xe có màu Red
        public void RemoveRedCars()
        {
            cars.RemoveAll(car => car.Color.Equals("Red", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Removed all cars with color Red.\n");
        }

        // In danh sách các xe
        public void DisplayCars()
        {
            Console.WriteLine("Car List:");
            foreach (var car in cars)
            {
                car.Display();
            }
        }

    }
}
