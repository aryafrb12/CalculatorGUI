using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMachine
{
    public class Calculator
    {
        public float Penambahan(float a, float b)
        {
            return a + b;
        }

        public float Pengurangan(float a, float b)
        {
            return a - b;
        }

        public float Perkalian(float a, float b)
        {
            return a * b;
        }

        public static float Pembagian(float a, float b)
        {
            return a / b;
        }

        public float Pangkat(float a, float b)
        {
            return (float)Math.Pow(a, b);
        }

        public static float Modulo(float a, float b)
        {
            return a % b;
        }
    }
}
