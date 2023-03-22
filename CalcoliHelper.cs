using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {   
        public static int Somma(int a, int b) => a + b;
        public static double Somma(double a, double b) => a + b;
        public static int Differenza(int a, int b) => a - b;
        public static double Differenza(double a, double b) => a - b;
        public static int Moltiplicazione(int a, int b) => a * b;
        public static double Moltiplicazione(double a, double b) => a * b;
        public static int ValoreAssoluto(int a) => a >= 0 ? a : -a;
        public static double ValoreAssoluto(double a) => a >= 0 ? a : -a;
        public static int NumMin(int a, int b)/* => Math.Min(a, b);*/ => a > b ? b : a;
        public static double NumMin(double a, in double b) => a > b ? b : a;
        public static int NumMax(int a, int b) => a > b ? a : b;
        public static double NumMax(double a, double b) => a < b ? b : a;
//- Massimo tra due numeri interi
//- Massimo tra due numeri double

    }
}
