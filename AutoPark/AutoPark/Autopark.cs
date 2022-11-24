using System;
namespace AutoPark
{
    public class Autopark
    {
        private protected string _name;
        private protected List<Car> _allCars;

        public Autopark(string name, List<Car> allCars)
        {
            _name = name;
            _allCars = allCars;
        }

        private string ListProcessing(List<Car> list)
        {
            string s = "";
            foreach (Car i in list)
            {
                s += i.ToString() + "\n";
            }
            return s;
        }

        public override string ToString()
        {
            return $"Название автопарка: {_name}\n\n{ListProcessing(_allCars)}";
        }
    }
}

