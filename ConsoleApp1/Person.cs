using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Person
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected DateTime Day { get; set; }
        protected string Fakul { get; set; }


        public Person() { }
        public Person(string name, string surname, DateTime day, string fakul)
        {
            this.Name = name;
            this.Surname = surname;
            this.Day = day;
            this.Fakul = fakul;
        }
        abstract public void Print();

        public int AgeNow()
        {
            return DateTime.Now.Year - Day.Year;
        }

    }
}
