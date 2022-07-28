namespace Name
{
    class Program{
        public static void Main(string[] args){
            string demo = "Hello World Eche";
            demo.Say();
        }
    }

    public static class ExtensionMethod{
        public static void Say(this string message){
            Console.WriteLine(message);
        }
    }
}
