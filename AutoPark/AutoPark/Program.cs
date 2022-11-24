using System;

namespace AutoPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> repairBook1 = new Dictionary<string, int>()
            {
                { "Аккумулятор", 2021 },
                { "Двигатель", 2020 },
                { "Подушки безопасности", 2020 },
                { "Передний бампер", 2022 }
            };
            PassengerCar car1 = new PassengerCar("BMW", 200, 2020, 4, repairBook1);

            Dictionary<string, int> repairBook2 = new Dictionary<string, int>()
            {
                { "Переднее правое крыло", 2018 },
                { "Задний бампер", 2019 },
            };
            PassengerCar car2 = new PassengerCar("Ford", 120, 2015, 4, repairBook2);

            Dictionary<string, int> repairBook3 = new Dictionary<string, int>();
            PassengerCar car3 = new PassengerCar("Mercdes Benz", 240, 2022, 4, repairBook3);

            Dictionary<string, int> repairBook4 = new Dictionary<string, int>()
            {
                { "Капот", 2019 },
                { "Заднее левое крыло", 2021 },
                { "Задний бампер, 2021", 2021 }
            };
            PassengerCar car4 = new PassengerCar("Audi", 160, 2017, 4, repairBook4);

            Dictionary<string, int> cargo1 = new Dictionary<string, int>()
            {
                { "Песок", 18 }
            };
            Truck car5 = new Truck("Kamaz", 160, 2010, 23, "Иванов И.И.", cargo1);

            Dictionary<string, int> cargo2 = new Dictionary<string, int>()
            {
                { "Мебель", 2 },
                { "Строй материалы", 1 }
            };
            Truck car6 = new Truck("Gazel", 120, 2016, 3, "Петров П.П.", cargo2);

            List<Car> list = new List<Car>() { car1, car2, car3, car4, car5, car6 };

            Autopark autopark = new Autopark("Московский автопарк", list);

            Console.WriteLine(autopark.ToString());

            Console.WriteLine(car1.ToString());
            car1.PrintBook();
            Console.WriteLine();
            Console.WriteLine(car6.ToString());
            car6.PrintCargo();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}