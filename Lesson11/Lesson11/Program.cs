using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Lesson11
{
    class Program
    {
       public static void Main(string[] args)
        {
           
            
        }

    }
}
class Human
{
    public string Name;
    public string Sorname;
    public int age;
    public Human(String nm,String sorname, int Age)
    {
        Name = nm;
        Sorname = sorname;
        this.age = Age;


    }
    public void getFullName()
    {
        Console.WriteLine(this.Name + " " + this.Sorname);
        Console.ReadLine();
    }
}

class Men : Woman
{


    public int Beardlength;
    public Men(string ad, byte yas, int berardlength) : base (ad, yas)
    {
        Beardlength = berardlength;
    }

}
class Woman : Human
   
{
    public Woman(string Names, int ages): base (Names, ages) { }
    public string Nailscolor;
    public int HairLength;

}
