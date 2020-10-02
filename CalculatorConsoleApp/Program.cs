using System;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator Versi Console";
            Console.Write("Inputkan nilai a = ");
            float a = float.Parse(Console.ReadLine()); // casting
            Console.Write("Inputkan nilai b = ");
            float b = float.Parse(Console.ReadLine()); // casting
            Console.WriteLine(); // tambahkan baris kosong
            Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian: {0} x {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian: {0} / {1} = {2}", a, b, Pembagian(a, b));
            Console.ReadKey();
        }

        static float Penambahan(float a, float b)
        {
            return a + b;
        }
        
        static float Pengurangan(float a, float b)
        {
            return a - b;
        }

        static float Perkalian(float a, float b)
        {
            return a * b;
        }

        static float Pembagian(float a, float b)
        {
            return a / b;
        }
    }
}
