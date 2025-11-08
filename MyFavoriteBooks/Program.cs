using System.IO;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the FavoriteBooksApp!");
        Console.WriteLine("Please Enter your 5 Favarite Books, separate them by comma \",\"");
        string listNames = Console.ReadLine();

        //convet the string to the list
        List<string> favBooks = listNames.Split(',').Select(listNames => listNames).ToList();


    }
}