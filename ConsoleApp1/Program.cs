using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            while (true)
            {
                Console.WriteLine("Введите название");
                string s = Console.ReadLine();
                switch (s)
                {
                    case "Абитуриент":list.Add( Abitur.InPut());
                        break;
                    case "Студент":list.Add(Student.InPut());
                        break;
                    case "Учитель":list.Add(Student.InPut());
                        break;
                }
            }

            Console.WriteLine("Введите нижнюю границу");
            int minAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите верхнюю границу");
            int maxAge = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<list.Count; i++)
            {
                if (list[i].AgeNow() > minAge && list[i].AgeNow() < maxAge)
                {
                    list[i].Print();
                }
            }
           
        }
    }
}
