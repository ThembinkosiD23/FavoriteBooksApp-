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

        //write the favBooks to the file called books
        string pathfile = "C:\\Users\\ThembinkosiDladla\\OneDrive - Prosus-Naspers\\Desktop\\LEARN25\\C#\\Fundamentals\\Projects\\MyFavoriteBooks\\Files\\Books.txt";

        //chek if the file is there
        if (!File.Exists(pathfile))
        {
            //create the file and write on it
            using StreamWriter writer = new StreamWriter(pathfile);
            //write the list of favBook in the file
            foreach (string favBook in favBooks)
            {
                writer.WriteLine(favBook);
            }

        }
        else
        {
            Console.WriteLine("The file is already there!");
        }

    }
}