using System;
using System.Xml.Linq;

namespace MusicDiscStore
{
    public class DVD : Disc
    {
        private string _producer;
        private string _filmCompany;
        private int _minutesCount;

        public DVD(string producer, string filmCompany, int minutesCount, string name, string genre)
            : base(name, genre)
        {
            _producer = producer;
            _filmCompany = filmCompany;
            _minutesCount = minutesCount;
        }

        private int _discSize;
        public override int DiscSize
        {
            get => _minutesCount / 64 * 2;
            set => _discSize = value;
        }

        public override void Burn(params string[] values)
        {
            _name = values[0];
            _genre = values[1];
            _producer = values[2];
            _filmCompany = values[3];
            try
            {
                _minutesCount = Int32.Parse(values[4]);
            }
            catch (FormatException) { }

            _burnCount++;
        }

        public override string ToString()
        {
            return $"DVD disc INFO:\n\tName: {_name}, Genre: {_genre}, Producer: {_producer}, Film Company: {_filmCompany}, " +
                $"Minutes: {_minutesCount}, Burns: {_burnCount}\n";
        }
    }
}

