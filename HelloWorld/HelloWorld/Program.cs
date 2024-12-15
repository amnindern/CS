internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        Console.WriteLine("[S]ee all TODOs");
        Console.WriteLine("[A]dd a TODO");
        Console.WriteLine("[R]emove a TODO");
        Console.WriteLine("[E]xit");

        string userChoice = Console.ReadLine();
        Console.WriteLine("User Input:" + userChoice);

        if(userChoice == "S")
        {
            PrintSelectedOption("See all TODOs");
        }
        else if(userChoice == "A")
        {
            PrintSelectedOption("Add a TODO");
        }else if(userChoice == "R")
        {
            PrintSelectedOption("Remove a TODO");
        }else if(userChoice == "E")
        {
            PrintSelectedOption("Exit");
        }
        Console.ReadKey();



        void PrintSelectedOption(string SelectedOption)
        {
            Console.WriteLine("Selected Option:" + SelectedOption);
        }

        int Add(int a, int b)
        {
            return a + b;
        }
        
    }
}

