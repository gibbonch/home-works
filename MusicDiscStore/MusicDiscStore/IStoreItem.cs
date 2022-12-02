using System;

namespace MusicDiscStore
{
    public interface IStoreItem
    {
        double Price { get; set; }

        void DiscountPrice(int percent) => Price = Price * percent / 100;
        
    }
}

