using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Song : Media
    {
        public long Seconds { get; set; }

        public ShelvePosition Position { get; set; }

        public string Category { get; set; }

        public List<Artist> Artists { get; set; }

        public int Visits { get; set; }

        public override void Play()
        {
            Console.WriteLine("Increase volumen");
            base.Play();
        }



        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Title: {Title} Duration: {Seconds}";
        }
    }
}