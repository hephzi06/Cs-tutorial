// namespace Work
// {
//     public delegate void PrintDetails();
//     class TestEvent
//     {
//         event PrintDetails Print;
//      void show ()
//         {
//             Console.Write("The purpose illustrates how to subscribe ");
//         }
//         public static void Main(string[] args)
//         {
//             TestEvent objtest  = new TestEvent();
//             objtest.Print  += new PrintDetails(objtest.show);
//             objtest.Print();

//         }
//     }
// }