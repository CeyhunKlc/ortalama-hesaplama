using System;

namespace ortalamahesaplama
{ 
    class program
    { 
        static void Main(string[]args)
        { 
            double sinav1,sinav2,sinav3,ortalama;
            Console.WriteLine("1.sınav notunu giriniz:");
            sinav1=Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("2.sınav notunu giriniz:");
            sinav2=Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("3.sınav notunu giriniz:");
            sinav3=Convert.ToDouble(Console.ReadLine());
            ortalama= (sinav1+sinav2+sinav3)/3;
            Console.WriteLine(ortalama);
        }
    }
}
