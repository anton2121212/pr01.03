using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student:Person
    {
        int Course { get; set; }
        public Student() { }
        public Student(string name, string surname, DateTime day, string fakul, int course) : base(name, surname, day, fakul)
        {
            this.Course = course;
        }

        public override void Print()
        {
            Console.WriteLine($"Имя-{Name}\nФамилия-{Surname}\nДата рождения-{Day}\nФакультет-{Fakul}\nКурс-{Course}");
        }

        public int AgeNow()
        {
            return DateTime.Now.Year - Day.Year;
        }

        public static Student InPut()
        {
            Console.WriteLine("Введите имя:");
            String name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            String surname = Console.ReadLine();
            Console.WriteLine("Введите дату рождения:");
            DateTime day = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите факультет:");
            string fakul = Console.ReadLine();
            Console.WriteLine("Введите курс:");
            int course = int.Parse(Console.ReadLine());
            return new Student(name, surname, day, fakul,course);
        }
    }
}
