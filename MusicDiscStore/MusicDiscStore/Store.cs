using System;
using System.Collections;
using System.Diagnostics;

namespace MusicDiscStore
{
    public class Store
    {
        private string _storeName;
        private string _adress;

        private List<Audio> _audios = new List<Audio>();
        public List<Audio> Audios
        {
            set => _audios = value;
        }

        private List<DVD> _dvds = new List<DVD>();
        public List<DVD> Dvds
        {
            set => _dvds = value;
        }


        public Store(string storeName, string adress)
        {
            _storeName = storeName;
            _adress = adress;
        }


       public static Store operator +(Store store, Audio audio)//test this and rename st
        {
            Store tempStore = new Store(store._storeName, store._adress);
            tempStore._audios.Add(audio);
            tempStore._dvds = store._dvds;
            tempStore._audios.AddRange(store._audios);
            return tempStore;
        }

        public static Store operator -(Store store, Audio audio)
        {
            Store tempStore = new Store(store._storeName, store._adress);
            tempStore._audios.AddRange(store._audios);
            tempStore._dvds = store._dvds;
            tempStore._audios.Remove(audio);
            return tempStore;
        }

        public static Store operator +(Store store, DVD dvd)
        {
            Store tempStore = new Store(store._storeName, store._adress);
            tempStore._dvds.Add(dvd);
            tempStore._audios = store._audios;
            tempStore._dvds.AddRange(store._dvds);
            return tempStore;
        }

        public static Store operator -(Store store, DVD dvd)
        {
            Store tempStore = new Store(store._storeName, store._adress);
            tempStore._dvds.AddRange(store._dvds);
            tempStore._audios = store._audios;
            tempStore._dvds.Remove(dvd);
            return tempStore;
        }

        public string PrintSizes()
        {
            string sAudio = "";
            string sDvd = "";
            foreach (DVD i in _dvds)
                sDvd += $"{i.Name} -> {i.DiscSize}\n";
            foreach (Audio i in _audios)
                sAudio += $"{i.Name} -> {i.DiscSize}\n";
            return $"DVD disk sizes:\n{sDvd}\nAUDIO disc sizes:\n{sAudio}\n";
        }

        public override string ToString()
        {
            string sAudio = "";
            string sDvd = "";
            foreach(Audio i in _audios)
                sAudio += i.ToString();
            foreach (DVD i in _dvds)
                sDvd += i.ToString();
            return $"Store name: {_storeName}\nadress: {_adress}\n" +
                $"\n========DVD DISCS:========\n{sDvd}\n ========AUDIO DISKS:========\n{sAudio}";
        }
    }
}

 