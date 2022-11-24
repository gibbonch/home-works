using System;
namespace AutoPark
{
    public class PassengerCar : Car
    {
        public int _passengerNum;
        public Dictionary<string, int> _reapairBook = new Dictionary<string, int>();

        public PassengerCar(string brand, int power, int year, int pass, Dictionary<string, int> book)
            : base(brand, power, year)
        {
            _passengerNum = pass;
            _reapairBook = book;
        }

        public void AddDetail(string detName, int repYear)
        {
            _reapairBook.Add(detName, repYear);
        }

        public int RepairYear(string det)
        {
            return _reapairBook[det];
        }

        public void PrintBook()
        {
            Console.WriteLine("РЕМОНТНАЯ КНИЖКА");
            foreach (KeyValuePair<string, int> regpair in _reapairBook)
            {
                Console.WriteLine($"Запчасть: {regpair.Key}, год замены: {regpair.Value}");
            }
        }

        public override string ToString() => $"Марка авто: {_brand}, мощность: {_power}, год производства: {_yearOfProduction}, " +
            $"количество пассажиров: {_passengerNum}";
    }
}

