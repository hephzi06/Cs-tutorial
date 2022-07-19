class Program
{
    public static void Main(string[] args)
    {
        string first_name, last_name, sub1, sub2, sub3, sub4, sub5, grade1, grade2, grade3, grade4, grade5;
        int score1, score2, score3, score4, score5;
        grade1 = grade2 = grade3 = grade4 = grade5 = "F9";
        Console.Write("Firstname: ");
        first_name = Console.ReadLine();
        Console.Write("Lastname: ");
        last_name = Console.ReadLine();
        Console.Write("First subject name: ");
        sub1 = Console.ReadLine();
        Console.Write("First subject score: ");
        score1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second subject name: ");
        sub2 = Console.ReadLine();
        Console.Write("Second subject score: ");
        score2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Third subject name: ");
        sub3 = Console.ReadLine();
        Console.Write("Third subject score: ");
        score3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Fourth subject name: ");
        sub4 = Console.ReadLine();
        Console.Write("Fourth subject score: ");
        score4 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Fifth subject name: ");
        sub5 = Console.ReadLine();
        Console.Write("Fifth subject name: ");
        score5 = Convert.ToInt32(Console.ReadLine());
        if (score1 > 100)
        {
            Console.WriteLine("Score should be less than 100");
        }
        else if (score1 >= 80)
        {
            grade1 = "A1";
        }
        else if (score1 <= 79)
        {
            grade1 = "B2";
        }
        else if (score1 <= 74)
        {
            grade1 = "B3";
        }
        else if (score1 <= 69)
        {
            grade1 = "C4";
        }
        else if (score1 <= 64)
        {
            grade1 = "C5";
        }
        else if (score1 <= 59)
        {
            grade1 = "C6";
        }
        else if (score1 <= 49)
        {
            grade1 = "D7";
        }
        else if (score1 <= 44)
        {
            grade1 = "E8";
        }
        else if (score1 > 0)
        {
            grade1 = "F9";
        }
        else
        {
            Console.WriteLine("Invalid score");
        }
        if (score2 > 100)
        {
            Console.WriteLine("Score should be less than 100");
        }
        else if (score2 >= 80)
        {
            grade2 = "A1";
        }
        else if (score2 <= 79)
        {
            grade2 = "B2";
        }
        else if (score2 <= 74)
        {
            grade2 = "B3";
        }
        else if (score2 <= 69)
        {
            grade2 = "C4";
        }
        else if (score2 <= 64)
        {
            grade2 = "C5";
        }
        else if (score2 <= 59)
        {
            grade2 = "C6";
        }
        else if (score2 <= 49)
        {
            grade2 = "D7";
        }
        else if (score2 <= 44)
        {
            grade2 = "E8";
        }
        else if (score2 > 0)
        {
            grade2 = "F9";
        }
        else
        {
            Console.WriteLine("Invalid score");
        }
        if (score3 > 100)
        {
            Console.WriteLine("Score should be less than 100");
        }
        else if (score3 >= 80)
        {
            grade3 = "A1";
        }
        else if (score3 <= 79)
        {
            grade3 = "B2";
        }
        else if (score3 <= 74)
        {
            grade3 = "B3";
        }
        else if (score3 <= 69)
        {
            grade3 = "C4";
        }
        else if (score3 <= 64)
        {
            grade3 = "C5";
        }
        else if (score3 <= 59)
        {
            grade3 = "C6";
        }
        else if (score3 <= 49)
        {
            grade3 = "D7";
        }
        else if (score3 <= 44)
        {
            grade3 = "E8";
        }
        else if (score3 > 0)
        {
            grade3 = "F9";
        }
        else
        {
            Console.WriteLine("Invalid score");
        }
        if (score4 > 100)
        {
            Console.WriteLine("Score should be less than 100");
        }
        else if (score4 >= 80)
        {
            grade4 = "A1";
        }
        else if (score4 <= 79)
        {
            grade4 = "B2";
        }
        else if (score4 <= 74)
        {
            grade4 = "B3";
        }
        else if (score4 <= 69)
        {
            grade4 = "C4";
        }
        else if (score4 <= 64)
        {
            grade4 = "C5";
        }
        else if (score4 <= 59)
        {
            grade4 = "C6";
        }
        else if (score4 <= 49)
        {
            grade4 = "D7";
        }
        else if (score4 <= 44)
        {
            grade4 = "E8";
        }
        else if (score4 > 0)
        {
            grade4 = "F9";
        }
        else
        {
            Console.WriteLine("Invalid score");
        }
        if (score5 > 100)
        {
            Console.WriteLine("Score should be less than 100");
        }
        else if (score5 >= 80)
        {
            grade5 = "A1";
        }
        else if (score5 <= 79)
        {
            grade5 = "B2";
        }
        else if (score5 <= 74)
        {
            grade5 = "B3";
        }
        else if (score5 <= 69)
        {
            grade5 = "C4";
        }
        else if (score5 <= 64)
        {
            grade5 = "C5";
        }
        else if (score5 <= 59)
        {
            grade5 = "C6";
        }
        else if (score5 <= 49)
        {
            grade5 = "D7";
        }
        else if (score5 <= 44)
        {
            grade5 = "E8";
        }
        else if (score5 > 0)
        {
            grade5 = "F9";
        }
        else
        {
            Console.WriteLine("Invalid score");
        }
        Console.WriteLine($"{first_name} {last_name} \n ------------------------ \n {sub1}  = {score1} = {grade1} \n {sub2}  = {score2} = {grade2} \n {sub3}  = {score3} = {grade3} \n {sub4} = {score4} =  {grade4} \n {sub5}  = {score5} =  {grade5}");
    }
}