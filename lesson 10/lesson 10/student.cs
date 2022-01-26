using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10
{
    class student
    {
        public string Name;
        public string Sorname;
        public int Years;
        public List<student> students;
        public static int caunt;
       public student (string name,string sorname,int years)
        {
            Name = name;
            Sorname = sorname;
            Years = years;
            students = new List<student>();
            caunt++;

            Console.WriteLine ($"{caunt} adam qeydiyatdan kecdi" );
            Console.ReadLine();
        }
        
    }
    
}
