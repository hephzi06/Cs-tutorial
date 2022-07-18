class Program
{
  public static void Main(string[] args)
  {
   string first_name,last_name;
   double salary,condition , loan_amount;
   int loan_duration, company_duration;

   Console.Write("Firstname: ");
   first_name = Console.ReadLine();
   Console.Write("Lastname: ");
   last_name = Console.ReadLine();
   Console.Write("Company Duration: ");
   company_duration = Convert.ToInt32(Console.ReadLine());
   if (company_duration < 12){
     Console.WriteLine("Duration at the company should be more than 12 months");
   }else{
     Console.Write("Salary: ");
    salary = Convert.ToDouble(Console.ReadLine());
    Console.Write("Loan amount: ");
    loan_amount = Convert.ToDouble(Console.ReadLine());
    Console.Write("Loan Duration: ");
    loan_duration = Convert.ToInt32(Console.ReadLine());
    condition = (salary * loan_duration) / 2;
    if (loan_amount > condition) {
      Console.WriteLine($"Sorry conditions is not met \n Supposed loan amount is {condition} \n Do you accept (Y)es or (N)o ");

      string pick = Console.ReadLine().ToLower();
      if (pick == "yes") {
        Console.Write("Account number: ");
        long account_number = Convert.ToInt64(Console.ReadLine());
        Console.Write($" Firstname = {first_name}  \n Lastname = {last_name} \n Loan amount = {condition} \n Loan duration = {loan_duration} \n Account number = {account_number}");
      }else if (pick == "no") {
        Console.WriteLine("Thanks");
      }
      else{
        Console.WriteLine("Invalid choice");
      }
    }else {
      Console.Write("Account number: ");
      long account_number = Convert.ToInt64(Console.ReadLine());
      Console.Write($" Firstname = {first_name}  \n Lastname = {last_name} \n Loan amount = {loan_amount} \n Loan duration = {loan_duration} \n Account number = {account_number}");

    }
   }
  }
}
