using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
class ReadOnly
{
    public static void Main(string[] args)
    {
        List<string> objlist = new List<string>();
        objlist.Add("Duyile");
        objlist.Add("Thompson");
        objlist.Add("Hephzibah");
        objlist.Add("Lanre");
        objlist.Add("Emma");
        objlist.Add("Chrsiti");
        ReadOnlyCollection<string> obj2 = new ReadOnlyCollection<string>(objlist);
        foreach (string item in obj2)
        {
            Console.WriteLine($"{item}");
        }Console.WriteLine("The total number of items in the list is : {obj2.Count} ");
        if (objlist.Contains("hephzi"))
        {
            objlist.Insert(2, "Jude");
        }
    }
}