﻿using System;
using CalculatorMachine;

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

            var cal = new Calculator();

            Console.WriteLine(); // tambahkan baris kosong
            Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, cal.Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, cal.Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian: {0} x {1} = {2}", a, b, cal.Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian: {0} / {1} = {2}", a, b, Calculator.Pembagian(a, b));
            Console.WriteLine("Hasil Pangkat: {0} x {1} = {2}", a, b, cal.Pangkat(a, b));
            Console.WriteLine("Hasil Modulo: {0} / {1} = {2}", a, b, Calculator.Modulo(a, b));
            Console.ReadKey();
        }
    }
}
