using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Teacher:Person
    {
        string Position { get; set; }
        int Experience { get; set; }

        public Teacher() { }

        public Teacher(string name, string surname, DateTime day, string fakul, string position, int experience) : base(name, surname, day, fakul)
        {
            this.Position = position;
            this.Experience = experience;
        }

        public override void Print()
        {
            Console.WriteLine($"Имя-{Name}\nФамилия-{Surname}\nДата рождения-{Day}\nФакультет-{Fakul}\nДолжность-{Position}\nСтаж-{Experience}");
        }

        public int AgeNow()
        {
            return DateTime.Now.Year - Day.Year;
        }

        public static Teacher InPut()
        {
            Console.WriteLine("Введите имя:");
            String name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            String surname = Console.ReadLine();
            Console.WriteLine("Введите дату рождения:");
            DateTime day = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите факультет:");
            string fakul = Console.ReadLine();
            Console.WriteLine("Введите должность");
            string position = Console.ReadLine();
            Console.WriteLine("Введите стаж");
            int experience = int.Parse(Console.ReadLine());
            return new Teacher (name, surname, day, fakul, position, experience);
        }
    }
}
