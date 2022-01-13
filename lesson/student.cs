using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    class student
    {
        public string fullname;
        public string GrupNo;
        public int AGE;
        public student(string Fullname, string grupNo,int age)
        {
            fullname = Fullname;
            GrupNo = grupNo;
            AGE= age;
        }
        public void GetBirthYear(student student)
        {
            int year = DateTime.Now.Year - student.AGE;
            Console.WriteLine(year);
            Console.ReadLine();
        }
    }
}
