using System.Globalization;
using System;

class Program
{

    public static void Main(string[] args)
    {
        var titleInfo = CultureInfo.CurrentCulture.TextInfo;
        var maizeDisease = new[]{
            new {name = "grey leaf", observation1="lesion are pale brown or gery to tan", observation2="start on lower leaf and moving upward", observation3="Lesion merging forming grey blotches"},
            new {name = "northern corn leaf blight", observation1="long elliptical, grayish-green or tan lesion ", observation2="grey apperance that resembles frost or drought injury ", observation3="ahmadu umaru fintiri"},
            new {name = "northern corn leaf spot", observation1="produces circular or oval foliar lesion", observation2="lesions having reddish-brown appearance", observation3="infected kernels developing black feltlike mold"},
            new {name = "common rust", observation1="produces brown to brick-red pustules on both upper and lower leaf", observation2="", observation3=""},
            new {name = "southern rust", observation1="produces pustules that are bright orange", observation2="pustules are more oval to round", observation3=""},
            new {name="eyespot",    observation1="numerous round to oval spot" ,  observation2="upper leaf wither and die prematurely" , observation3=""},



        };
        Console.WriteLine("Welcome to Maize disases Wiki \n Search using \" Disases name or by using your observations\" \n Search by \n 1. Disease name \n 2. Observation  ");
        int pick = Convert.ToInt32(Console.ReadLine());
        if (pick == 1)
        {
            string option = Console.ReadLine().ToLower();
            for (int i = 0; i < maizeDisease.Length; i++)
            {
                if (option == maizeDisease[i].name)
                {
                    Console.WriteLine($" {titleInfo.ToTitleCase(maizeDisease[i].name)} {titleInfo.ToTitleCase(maizeDisease[i].observation1)} {titleInfo.ToTitleCase(maizeDisease[i].observation2)} {titleInfo.ToTitleCase(maizeDisease[i].observation3)}");
                    break;
                }
                // else
                // {
                //     System.Console.WriteLine("Invalid name");
                // }
            }
        }
        else if (pick == 2)
        {
            Console.WriteLine("How many obervation do you have but it must not be more than 3:  ");
            int observe = Convert.ToInt32(Console.ReadLine());
            if (observe <= 3)
            {
                for (int i = 1; i <= observe; i++)
                {
                    Console.WriteLine($"observation{i}:  ");
                    string option = Console.ReadLine().ToLower();
                    for (int j = 0; j < maizeDisease.Length; j++)
                    {
                        if (option == maizeDisease[j].observation1 || option == maizeDisease[j].observation1 || option == maizeDisease[j].observation3)
                        {
                            Console.WriteLine($" {titleInfo.ToTitleCase(maizeDisease[j].name)} {titleInfo.ToTitleCase(maizeDisease[j].observation1)} {titleInfo.ToTitleCase(maizeDisease[j].observation2)} {titleInfo.ToTitleCase(maizeDisease[j].observation3)}");
                            break;
                        }
                        // else
                        // {
                        //     System.Console.WriteLine("Invalid name");
                        // }
                    }
                }
            }
            else
            {
                System.Console.WriteLine("Observation must not be less than 3");
            }
        }
        else
        {
            System.Console.WriteLine("Invalid name");
        }
    }
}
