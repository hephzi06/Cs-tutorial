namespace partying
{
    public delegate void party_entry();
    class Parties
    {
        event party_entry party;
        void allowed()
        {
            Console.Write("You are allowed");
        }
        void not_allowed()
        {
            Console.Write("You  not are allowed");
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Parties user = new Parties();
            if (age < 18 && age > 0){
                user.party += new party_entry(user.not_allowed);
                user.party();
            }else if(age >= 18&& age < 100){
                user.party += new party_entry(user.allowed);
                user.party();
            }else{
                Console.Write("Your daddy is mad ");
            }
        }
    }
}