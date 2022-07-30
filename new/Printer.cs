using System;
namespace PrinterNamespace
{
    public static class GreaterNumber
    {
        public static void isHiger(this int num1, int num2)
        {

            bool ans = (num1 > num2);
            Console.WriteLine(ans);
        }
    }
}