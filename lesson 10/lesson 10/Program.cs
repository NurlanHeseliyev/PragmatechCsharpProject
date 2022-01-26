using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            student student = new student("Mehemmed Emin", "Resulzade", 138);
            student.Name = "Mehemmed Emin";
            student.Sorname =  "Resulzade";
            student.Years = 138;
            Console.WriteLine( student);
            Console.ReadLine();
        }

    }
}
