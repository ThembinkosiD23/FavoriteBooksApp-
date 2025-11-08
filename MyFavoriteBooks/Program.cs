using System.IO;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the FavoriteBooksApp!");
        Console.WriteLine("Please enter your 5 favorite books, separated by commas (e.g. Book1, Book2, Book3, Book4, Book5):");
        string listNames = Console.ReadLine();

        //convet the string to the list
        List<string> favBooks = listNames.Split(',').Select(listNames => listNames).ToList();

        //write the favBooks to the file called books
        string filePath = "C:\\Users\\ThembinkosiDladla\\OneDrive - Prosus-Naspers\\Desktop\\LEARN25\\C#\\Fundamentals\\Projects\\MyFavoriteBooks\\Files\\Books.txt";

        //chek if the file is there
        if (!File.Exists(filePath))
        {
            //create the file and write on it
            using StreamWriter writer = new StreamWriter(filePath);
            //write the list of favBook in the file
            foreach (string favBook in favBooks)
            {
                writer.WriteLine(favBook);
                Console.WriteLine("Your Favorite Books has been added to the file!");
            }

        }

        // --- READ AND DISPLAY FILE CONTENT ---
        Console.WriteLine("Here is the list of your favorite books:");
        using (StreamReader reader = new StreamReader(filePath))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }

        //APPEND ADDITIONAL BOOKS 
        Console.WriteLine("\nNow, please enter 3 more favorite books (separated by commas):");
        string newBooksInput = Console.ReadLine();

        List<string> newBooks = newBooksInput.Split(',').Select(book => book.Trim()).ToList();

        // Append new books to the existing file
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            foreach (string book in newBooks)
            {
                writer.WriteLine(book);
            }
            Console.WriteLine("\n New books have been added successfully!\n");

        }
    }
}