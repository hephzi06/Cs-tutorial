using System;
namespace Mighty
{
    public static class Formula
    {
        public static void alFormula(this int a , int b , int c)
        {
                double d = Math.Sqrt((b*b) - (4*a*c));
               Console.WriteLine($" Ans: {((-b) + d)/2*a}  or {((-b) - d)/2*a}");

        }
    }
}