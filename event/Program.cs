namespace Work

{
    // creating a delegates
    public delegate double CalcVolume(double a);
    public delegate double CalcArea(double b);
    // our class

    class Program
    {
        //  our methods for addition
        static double volumeCube(double a){
          return(a*a*a);
        }
         static double AreaSquare(double a){
          return(a*a);
        }

        public static void Main(string[] args)
        {
            // variables
           double vol = 10d;
           double area = 5d;


          CalcArea areaDel = new CalcArea(AreaSquare);
          Console.WriteLine(areaDel(area));
          CalcVolume volDel = new CalcVolume(volumeCube);
          Console.WriteLine(volDel(vol));





        }


    }
}
