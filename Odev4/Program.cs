using System;
using System.Collections.Generic;

namespace Odev4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> ogrenciler = new MyDictonary<int, string>();
            ogrenciler.Add(383034, "Ebru");
            ogrenciler.Add(383034, "Ebru");
            ogrenciler.Add(383034, "Ebru");
            ogrenciler.Add(383034, "Ebru");
            Console.WriteLine(ogrenciler.Count);

        }

        
    }
}
