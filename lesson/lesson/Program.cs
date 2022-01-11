using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    class Program
    {

        static void Main(string[] args)
        {
            //int[] evenNums = { 2, 4, 6, 8, 10 };

            //string[] cities = { "Baki", "London", "New York" };
            //Console.WriteLine(cities[0]);
            //Console.ReadLine();

            //int[] a = { 5 };
            //string [] b = { "men" };
            //Console.WriteLine(b[0]);
            //Console.ReadLine();


            //STARING & STRING BUILDER

            //string FirstNameLastName = "MEHEMMED EMIN";
            //FirstNameLastName = FirstNameLastName + " ";
            //FirstNameLastName = FirstNameLastName + "RESULZADE";
            //Console.WriteLine(FirstNameLastName);
            //Console.ReadLine();


            //StringBuilder stringbuilder = new StringBuilder;
            //stringbuilder.Append("Mehemmed Emin");
            //stringbuilder.Append(" ");
            //stringbuilder.Append("Resulzade");
            //Console.WriteLine(stringbuilder);
            //Console.ReadLine();

            student student = new student("Mehemmde Emin");
            student.Name = "Mehemmed Emin";
            student.Lastname = "Resulzade";
            student.years = 138;
            student.qrup = 6;
            Console.WriteLine();
            Console.ReadLine();
        }
       
    }
}
