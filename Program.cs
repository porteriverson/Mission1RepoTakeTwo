// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

public class Program
{
    private static void Main(string[] args)
    {
        Printer pr = new Printer();
        string name = "";
        int blah = 0;
        // random changes to view in github

        Console.WriteLine("Please enter your name");
        name = Console.ReadLine();

        pr.PrintName(name);
    }
}