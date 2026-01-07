using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Media
    {
        private int ParentRate;

        public string Title { get; set; }
        public virtual void Play()
        {
            Console.WriteLine($"Playing {Title}");
        }

        protected bool ThisContentIsCorrectForThisAge(int age)
        {
            if (age >= ParentRate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            var mediaObject = (Media)obj;

            if (mediaObject.Title == this.Title)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}