using System;
using ClassLibrary1;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[0];
            int len = 0;
            l1:
            Class1.PrintMenu();
            int UserReqem = Convert.ToInt32(Console.ReadLine());
            switch (UserReqem)
            {
                case 1:
                    
                    Student student = new Student();
                    student.Name = Console.ReadLine();
                    student.Surname = Console.ReadLine();
                    student.Adress = Console.ReadLine();
                    Array.Resize(ref students, students.Length + 1);
                    len = students.Length - 1;
                    students[len] = student;
                    int subMenu = Convert.ToInt32(Console.ReadLine());
                    if (subMenu == 2)
                    {
                        goto l1;
                    }
                        break;

                case 2:
                    foreach (var item in students)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Geti Donus Et 3");
                    int subMenu1 = Convert.ToInt32(Console.ReadLine());
                    if (subMenu1 == 3)
                    {
                        goto l1;
                    }

                    break;
                    
                    

                default:
                    break;
            }
        }
    }
}
