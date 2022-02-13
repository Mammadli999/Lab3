using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        public int Id;
        public string Name;
        public string Surname;
        public string Adress;
        public static int counter = 0;

        public Student()
        {
            counter++;
            Id = counter;
        }
        public override string ToString()
        {
            return $"No{Id}\n" +
                   $"Ad{Name} \n" +
                   $"Soyad{Surname} \n" +
                   $"Adres{Adress}";
        }
    }
}
