﻿using System;

namespace diziler2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort sıralama işlemi
            int[] sayiDizisi={23,12,86,4,72,11,9,42};

            Console.WriteLine("***Sırasız Dizi ****");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

             Console.WriteLine("***Sıralı Dizi ***");
                Array.Sort(sayiDizisi);

             foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Clear
            Console.WriteLine("*** Array Clear ***");
            // sayiDizisi elemanlarını kullanarak 2 .indexten itibaren 2 tane elemanı sıfırlar
            Array.Clear(sayiDizisi,2,2);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Reverse
            Console.WriteLine("*** Array Reverse ***");
            Array.Reverse(sayiDizisi);
             foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //IndexOf
            Console.WriteLine("*** Array IndexOf ***");
             Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize
            Console.WriteLine("*** Array Resize ***");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


        }
    }
}