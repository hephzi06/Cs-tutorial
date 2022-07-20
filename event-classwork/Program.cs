
// Creating a delegate

public delegate void BuyData(string ussd);
public delegate void BuyAirtime(string ussd);
class Program
{
    static void rechargeData(string ussd)
    {
        
        // If statements......
        if (ussd.Equals("*131#"))
        {
            Console.WriteLine("1. Daily Plan \n 2. Weekly Plan \n 3. Monthly Plan");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("1. #50 for 40mb \n 2. #100 for 100mb \n 3. #200 for 200mb");
                    int secOption = Convert.ToInt32(Console.ReadLine());
                    if (secOption == 1)
                    {
                        Console.WriteLine("You will be charged #50 for the purchase of 40mb daily plan. To proceed, select: \n 1. Auto-renew \n 2. One-off");
                        int sel1_option = Convert.ToInt32(Console.ReadLine());
                        if (sel1_option == 1)
                        {
                            Console.WriteLine("Purchase of 40mb daily plan Successfull Auto-renewal");
                        }
                        else if (sel1_option == 2)
                        {
                            Console.WriteLine("Purchase of 40mb daily plan Successfull one-off");
                        }
                        else
                        {
                            Console.WriteLine("Connection Problem or invalid MMI code");
                        }
                    }
                    else if (secOption == 2)
                    {
                        Console.WriteLine("You will be charged #100 for the purchase of 100mb daily plan. To proceed, select: \n 1. Auto-renew \n 2. One-off");
                        int sel2_option = Convert.ToInt32(Console.ReadLine());
                        if (sel2_option == 1)
                        {
                            Console.WriteLine("Purchase of 100mb daily plan Successfull Auto-renew");
                        }
                        else if (sel2_option == 2)
                        {
                            Console.WriteLine("Purchase of 100mb daily plan Successfull One-off");
                        }
                        else
                        {
                            Console.WriteLine("Connection Problem or invalid MMI code");
                        }
                    }
                    else if (secOption == 3)
                    {
                        Console.WriteLine("You will be charged #200 for the purchase of 200mb daily plan. To proceed, select:  \n 1. Auto-renew \n 2. One-off ");

                        int sel3_option = Convert.ToInt32(Console.ReadLine());
                        if (sel3_option == 1)
                        {
                            Console.WriteLine("Purchase of 200mb daily plan Successfull Auto-renew");
                        }
                        else if (sel3_option == 2)
                        {
                            Console.WriteLine("Purchase of 200mb daily plan Successfull One-off");
                        }
                        else
                        {
                            Console.WriteLine("Connection Problem or invalid MMI code");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Connection Problem or invalid MMI code");
                    }
                    break;
                case 2:
                    Console.WriteLine("1. #200 for 1gb \n 2. #300 for 350mb \n 3. #500 for 1.5gb");
                    int second_option = Convert.ToInt32(Console.ReadLine());
                    if (second_option == 1)
                    {
                        Console.WriteLine("You will be charged #200 for the purchase of 1gb weekly plan. To proceed, select: \n 1. Auto-renew \n 2. One-off");

                        int third_option = Convert.ToInt32(Console.ReadLine());
                        if (third_option == 1)
                        {
                            Console.WriteLine("Purchase of 1gb weekly plan Successfull Auto-renew");
                        }
                        else if (third_option == 2)
                        {
                            Console.WriteLine("Purchase of 1gb weekly plan Successfull One-off");
                        }
                        else
                        {
                            Console.WriteLine("Connection Problem or invalid MMI code");
                        }
                    }
                    else if (second_option == 2)
                    {
                        Console.WriteLine("You will be charged #300 for the purchase of 350mb weekly plan. To proceed, select: \n 1. Auto-renew \n 2. One-off");

                        int third_option = Convert.ToInt32(Console.ReadLine());
                        if (third_option == 1)
                        {
                            Console.WriteLine("Purchase of 350mb daily plan Successfull Auto-renew");
                        }
                        else if (third_option == 2)
                        {
                            Console.WriteLine("Purchase of 350mb daily plan Successfull One-off");
                        }
                        else
                        {
                            Console.WriteLine("Connection Problem or invalid MMI code");
                        }
                    }
                    else if (second_option == 3)
                    {
                        Console.WriteLine("You will be charged #500 for the purchase of 1.5gb weekly plan. To proceed, select: \n  1. Auto-renew \n 2. One-off");

                        int third_option = Convert.ToInt32(Console.ReadLine());
                        if (third_option == 1)
                        {
                            Console.WriteLine("Purchase of 1.5gb weekly plan Successfull Auto-renew");
                        }
                        else if (third_option == 2)
                        {
                            Console.WriteLine("Purchase of 1.5gb weekly plan Successfull One-off");
                        }
                        else
                        {
                            Console.WriteLine("Connection Problem or invalid MMI code");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Connection Problem or invalid MMI code");
                    }
                    break;
                case 3:
                    Console.WriteLine("1. #1000 for 1.5gb \n 2. #1200 for 2gb \n 3. #1500 for 3gb");
                    int last_option = Convert.ToInt32(Console.ReadLine());
                    if (last_option == 1)
                    {
                        Console.WriteLine("You will be charged #1000 for the purchase of 1.5gb monthly plan. To proceed, select: \n 1. Auto-renew \n 2. One-off ");

                        int third_option = Convert.ToInt32(Console.ReadLine());
                        if (third_option == 1)
                        {
                            Console.WriteLine("Purchase of 1.5gb monthly plan Successfull Auto-renew");
                        }
                        else if (third_option == 2)
                        {
                            Console.WriteLine("Purchase of 1.5gb monthly plan Successfull One-off");
                        }
                        else
                        {
                            Console.WriteLine("Connection Problem or invalid MMI code");
                        }
                    }
                    else if (last_option == 2)
                    {
                        Console.WriteLine("You will be charged #1200 for the purchase of 2gb monthly plan. To proceed, select: \n 1. Auto-renew \n 2. One-off");

                        int third_option = Convert.ToInt32(Console.ReadLine());
                        if (third_option == 1)
                        {
                            Console.WriteLine("Purchase of 2gb monthly plan Successfull Auto-renew");
                        }
                        else if (third_option == 2)
                        {
                            Console.WriteLine("Purchase of 2gb monthly plan Successfull One-off");
                        }
                        else
                        {
                            Console.WriteLine("Connection Problem or invalid MMI code");
                        }
                    }
                    else if (last_option == 3)
                    {
                        Console.WriteLine("You will be charged #1500 for the purchase of 3gb monthly plan. To proceed, select: \n 1. Auto-renew \n 2. One-off");

                        int third_option = Convert.ToInt32(Console.ReadLine());
                        if (third_option == 1)
                        {
                            Console.WriteLine("Purchase of 3gb monthly plan Successfull Auto-renew");
                        }
                        else if (third_option == 2)
                        {
                            Console.WriteLine("Purchase of 3gb monthly plan Successfull One-off");
                        }
                        else
                        {
                            Console.WriteLine("Connection Problem or invalid MMI code");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Connection Problem or invalid MMI code");
                    }
                    break;
                default:
                    Console.WriteLine("Connection Problem or invalid MMI code");
                    break;
            }


        }


    }


    // Our main method 
    public static void Main(string[] args)
{
    // variables
    Console.WriteLine("Enter ussd code");
    string ussd = Console.ReadLine();
    BuyData data1 = new BuyData(rechargeData);


    data1(ussd);


}
}