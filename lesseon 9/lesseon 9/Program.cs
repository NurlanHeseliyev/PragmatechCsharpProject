using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace lesseon_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack stack = new Stack();
            //stack.Push(2); //add edirsen
            //stack.Push("Nurlan");
            //stack.Push(true);
            //stack.Push(12);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //    Console.ReadLine();
            //}

            //Queue queue = new Queue();
            //queue.Enqueue("Mehemmed");
            //queue.Enqueue("Emin");
            //queue.Enqueue("Resulzade");
            //queue.Enqueue("31.01.1884");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //    Console.ReadLine();
            //}
            //Console.WriteLine(queue.Dequeue() + "remuve";

            Hashtable hashtable = new Hashtable();
            hashtable.Add(1,"Mehemmed" );
            hashtable.Add(2,"Emin");
            hashtable.Add(3,"Resulzade");
            hashtable.Add(4,"31.01.1884");
            hashtable.Add(5,"06.03.1955");

            foreach (var item in hashtable)
            {
                Console.WriteLine(item);
            }

        }

    }
}
 