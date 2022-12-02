using System;

namespace MusicDiscStore
{
    public class Disc : IStoreItem
    {
        private protected string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        private protected string _genre;
        private protected int _burnCount;

        public Disc(string name, string genre)
        {
            _name = name;
            _genre = genre;
        }

        public virtual int DiscSize { get; set; }
        private double _price;
        public double Price { get => _price; set => _price = value; }
        public void DiscountPrice(int percent) => Price = Price * percent / 100;
        public virtual void Burn(params string[] values) { }
    }
}

