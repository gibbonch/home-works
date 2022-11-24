using System;

namespace AutoPark
{
    public class Car
    {
        private protected string _brand;
        private protected int _power;
        private protected int _yearOfProduction;

        public Car(string brand, int power, int year)
        {
            _brand = brand;
            _power = power;
            _yearOfProduction = year;
        }

        public override string ToString() => $"Марка авто: {_brand}, мощность: {_power}, год производства: {_yearOfProduction}";
    }
}

