using System;

namespace AutoPark
{
    public class Truck : Car
    {
        private protected double _maxWeight;
        private protected string _driverInfo;
        public Dictionary<string, int> _cargo = new();

        public Truck(string brand, int power, int year, double weight, string driver, Dictionary<string, int> cargo) : base(brand, power, year)
        {
            _maxWeight = weight;
            _driverInfo = driver;
            _cargo = cargo;
        }

        public void ChangeDriver(string newName)
        {
            _driverInfo = newName;
        }

        public void AddCargo(string cargo, int weight)
        {
            _cargo.Add(cargo, weight);
        }

        public void DeleteCargo(string cargo)
        {
            _cargo.Remove(cargo);
        }

        public void PrintCargo()
        {
            Console.WriteLine("ТЕКУЩИЕ ГРУЗЫ");
            foreach (KeyValuePair<string, int> regpair in _cargo)
            {
                Console.WriteLine($"Название товара: {regpair.Key}, вес: {regpair.Value}");
            }
        }

        public override string ToString() => $"Марка авто: {_brand}, мощность: {_power}, год производства: {_yearOfProduction}, " +
            $"максимальная грузоподъемность: {_maxWeight}, информация о водителе: {_driverInfo}";
    }
}

