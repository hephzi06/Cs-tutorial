using System.Globalization;


class Program
{

    public static void Main(string[] args){
        var titleInfo = CultureInfo.CurrentCulture.TextInfo;
        var stateCapital = new[]{
            new {name = "", capital="umuahia", slogan="god's own state", governor="okezie ikpeazu"},
            new {name = "adamawa state", capital="yola", slogan="land of beauty", governor="ahmadu umaru fintiri"},
            new {name = "akwa ibom state", capital="uyo", slogan="land of promise", governor="udom gabriel emmanuel"},
            new {name = "anambra state", capital="awka", slogan="light of the nation", governor="charles soludo"},
            new {name = "bauchi state", capital="bauchi", slogan="pearl of tourism", governor="bala abdulkadir mohammed"},
            new {name="bayelsa State",    capital="yenagoa" ,  slogan="glory of all lands" ,        governor="douye diri"},
            


        };
        Console.Write("Welcome to Nigeria Wiki \n Search using \" State name , Capital name , Slogan , Governor's name\" \n Enter name :  ");

        string option = Console.ReadLine().ToLower();
        for (int i = 0; i <= stateCapital.Length - 1; i++)
        {
                if(option  == stateCapital[i].name || option == stateCapital[i].capital || option == stateCapital[i].slogan ||option == stateCapital[i].governor ){
                    Console.WriteLine($"{titleInfo.ToTitleCase(stateCapital[i].name)}  {titleInfo.ToTitleCase(stateCapital[i].capital)} {titleInfo.ToTitleCase(stateCapital[i].slogan)} {titleInfo.ToTitleCase(stateCapital[i].governor)} ");
                }
        }
    }
}
