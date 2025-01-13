namespace ConsoleApp2;

internal class Printer
{
    private string language;
    // Constructor
    public Printer ()
    {
        // Nothing passed in
        language = "EN";
    }
    public Printer(string temp)
    {
        language = temp;
    }
    public void PrintName(string firstname)
    {
        if (language == "EN")
        {
            System.Console.WriteLine("Hello, " + firstname + "!!");
        }

        if (language == "SP")
        {
            System.Console.WriteLine("Hola, " + firstname + "!!");
        }
        
    }    
}