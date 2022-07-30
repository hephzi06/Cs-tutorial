using Mighty;
namespace Work
{
    class HelloWorld
    {
        static void Main()
        {
            Console.Write("A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("C: ");
            int C = Convert.ToInt32(Console.ReadLine());
            A.alFormula(B, C);
        }
    }


}