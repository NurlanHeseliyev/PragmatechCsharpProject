using System;
using System.Collections;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)

        {

            //Console.WriteLine("bir eded daxil   et");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(x + "befor");
            //Console.WriteLine(changernumber(ref x));
            //Console.WriteLine(x + "after");
            //arry
            //int[] number = new int[5];
            int[] number = { 1, 2, 3, 4, 5 };
            number[5] = 75;
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }

        }


        #region  /////lesson 2 home work
        public static int changernumber(ref int input)
        {
            int result = 0;
            int sum = 0;
            for (int i = 1; i < 9; i++)
            {
                result = i * input;
                sum += result;

            }
            return sum;
        }
        #endregion


        ////string ad = "Mehemmed Emin Resulzade";
        ////string x = ad.Trim();
        ////Console.WriteLine();



        ////teyin olunan cumlede olan sozlerin axtarisi eyni formatda olan sozlere aiddi sebeb olarag aski cedvelinde her gerfin ozne mexsus yeri var 
        //string ad = "Mehemmed Emin Resulzade"
        //    bool result = ad.Contains("Resulzade")
        //    Console.WriteLine(result);




        // teyin olun cumlede olan sozlerin kicik ve yaxud boyuk herfle yazilisinda axtarisi
        //string cumle = "Mehemmed Emin Resulzade";
        //string yeniCumle = cumle.ToUpper();
        //string soz = "emin".ToUpper();
        //Console.WriteLine(yeniCumle.Contains(soz);




        // teyin olunan cumledeki sozleri istediyin formada keserek netice elde ede bilirsen
        //string sentence = "Bir Kere Yukselen Bayrak Bir Daha Enmez";
        // Console.WriteLine(sentence.Substring(9.29);



        // teyin olunmuw cumlede ki, sizleri alt-alta duzuluwunu teyin edir
        //string sentence = "subhesizdir ki, bir gun heqiqet parliyacaq";
        //string[] dividedWords = sentence.Split('')


        /// teyin olunmus cumlede sozleri deyisdirilmesini temin edir
        //string sentence = "subhesizdir ki, iki gun heqiqet parliyacaq";
        //Console.WriteLine(sentence.Replace("iki"."bir"));


        // cumledeki teyin etdiyin herifleri necenci idex da oldugunu gosterir
        // string sentence = "Salam Dunya";
        //int nomre = sentence.IndexOf("a");
        // int nomre2= sentence.LastIndexOf("a")
        //     Console.WriteLine( nomre2);
        // Console.WriteLine(nomre);



        //userin qeydiyyat zamani verdiyi bowluglarin yoxlanilmasi
        //string userad = "  ";
        //Console.WriteLine(string.IsNullOrEmpty(userad));


    }

}
