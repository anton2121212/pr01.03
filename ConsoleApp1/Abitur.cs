using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Abitur:Person
    {
        public Abitur(string name, string surname, DateTime day, string fakul) : base(name, surname, day, fakul)
        {

        }

        public override void Print()
        {

            Console.WriteLine($"Имя-{Name}\nФамилия-{Surname}\nДата рождения-{Day}\nФакультет-{Fakul}");
        }
        public int AgeNow()
        {
            return DateTime.Now.Year - Day.Year;
        }
        public static Abitur InPut()
        {
            Console.WriteLine("Введите имя:");
            String name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            String surname = Console.ReadLine();
            Console.WriteLine("Введите дату рождения:");
            DateTime day = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите факультет:");
            string fakul = Console.ReadLine();
            return new Abitur(name, surname, day, fakul);
        }

    }
}

