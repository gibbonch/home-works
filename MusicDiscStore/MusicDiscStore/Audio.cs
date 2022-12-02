using System;
using System.Collections;

namespace MusicDiscStore
{
    public class Audio : Disc
    {
        private string _artist;
        private string _recordingStudio;
        private int _songsNumber;

        public Audio(string artist, string recordingStudio, int songsNumber, string name, string genre)
            : base(name, genre)
        {
            _artist = artist;
            _recordingStudio = recordingStudio;
            _songsNumber = songsNumber;
        }

        private int _discSize;
        public override int DiscSize
        {
            get => _songsNumber * 8;
            set => _discSize = value;
        }

        public override void Burn(params string[] values)
        {
            _name = values[0];
            _genre = values[1];
            _artist = values[2];
            _recordingStudio = values[3];
            try
            {
                _songsNumber = Int32.Parse(values[4]);
            }
            catch (FormatException){ }
            
            _burnCount++;
        }

        public override string ToString()
        {
            return $"Audio disc INFO:\n\tName: {_name}, Genre: {_genre}, Artist: {_artist}, " +
                $"Recording Studio: {_recordingStudio}, Songs Number: {_songsNumber}, Burns: {_burnCount}\n"; 
        }
    }
}

