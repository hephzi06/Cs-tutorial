class Program
{
public static void Main(string[] args)
{
  Grading grade = new Grading();

  Console.Write("Firstname: ");
  grade.first_name = Console.ReadLine();
  Console.Write("Lastname: ");
  grade.last_name = Console.ReadLine();
  Console.Write("First subject name: ");
  grade.sub1 = Console.ReadLine();
  Console.Write("First subject score: ");
  grade.score1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Second subject name: ");
  grade.sub2 = Console.ReadLine();
  Console.Write("Second subject score: ");
  grade.score2 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Third subject name: ");
  grade.sub3 = Console.ReadLine();
  Console.Write("Third subject score: ");
  grade.score3 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Fourth subject name: ");
  grade.sub4 = Console.ReadLine();
  Console.Write("Fourth subject score: ");
  grade.score4 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Fifth subject name: ");
  grade.sub5 = Console.ReadLine();
Console.Write("Fifth subject name: ");
grade.score5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{grade.first_name} {grade.last_name} \n ------------------------ \n {grade.sub1}  = {grade.score1} = {grade.grades(grade.score1)} \n {grade.sub2}  = {grade.score2} = {grade.grades(grade.score2)} \n {grade.sub3}  = {grade.score3} = {grade.grades(grade.score3)} \n {grade.sub4} = {grade.score4} =  {grade.grades(grade.score4)} \n {grade.sub5}  = {grade.score5} =  {grade.grades(grade.score5)}");
Console.WriteLine($"");


}
}
