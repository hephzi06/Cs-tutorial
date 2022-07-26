using System;
using System.Globalization;
public delegate void NumChecker();

class Program
{
    public static void Main(string[] args)
    {
        var textInfo = CultureInfo.CurrentCulture.TextInfo;
        var state = new[] {
        new {statename = "ogun state", state_capital = "abeoukta",governor = "abiodun"},
        new {statename = "lagos state", state_capital = "ikeja",governor = "sanwo-Olu"},
        new {statename = "oyo state", state_capital = "ibadan",governor = "makinde"}
        };
        Console.WriteLine("Welcome to state wiki");
        Console.Write("Enter a state name: ");
        string option = Console.ReadLine().ToLower();
        for (int i = 0; i <= state.Length; i++)
        {
            if (state[i].statename == option)
            {
                Console.WriteLine($" {textInfo.ToTitleCase(state[i].statename)} {state[i].state_capital} {state[i].governor}");
                break;
            }
        }


    }
}