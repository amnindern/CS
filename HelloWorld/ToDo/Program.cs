// See https://aka.ms/new-console-template for more information


bool isExit = false;

List<string> todoList = new List<string>();

Console.WriteLine("Hello");
Console.WriteLine("");
do
{

    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    string userChoice = Console.ReadLine();
    //Console.WriteLine("User Input:" + userChoice);

    //todoList.Add("Element One");
    //todoList.Add("Element two");

    switch (userChoice)
    {
        case "S":
        case "s":
            {
                SeeAll(todoList);
                break;
            }
        case "A":
        case "a":
            {
                AddTodo(todoList);
                break;
            }
        case "R":
        case "r":
            {
                RemoveTodo(todoList);
                break;
            }
        case "E":
        case "e":
            {
                isExit = true;
                break;
            }
        default:
            {
                Console.WriteLine("Invalid choice");
                Console.WriteLine("");
                break;
            }
    }
}
while (!isExit);

//Console.ReadKey();

void SeeAll(List<String> todoList)
{
    int indexNumber = 1;
    foreach (var word in todoList)
    {
        Console.WriteLine($"{indexNumber}. {word}");
        indexNumber++;
    }
}

void AddTodo(List<string> todoList)
{
    var inputDescription = "";
    bool isUnique = true;
    do
    {
        Console.WriteLine("Enter the TODO description:");
        inputDescription = Console.ReadLine();
        foreach (var word in todoList)
        {
            if (word.ToUpper() == inputDescription.ToUpper())
            {
                isUnique = false;
                break;
            }
            else
            {
                isUnique = true;
            }
        }
        if (inputDescription != "")
        {
            if (isUnique)
            {
                todoList.Add(inputDescription);

            }
            else
            {
                Console.WriteLine("The desription must be unique.");
            }
        }
        else
        {
            Console.WriteLine("The Description cannot be empty");
        }
    } while (inputDescription == "" || !isUnique);
}

void RemoveTodo(List<string> todoList)
{
    string inputNumber;
    if (todoList.Count <= 0)
    {
        Console.WriteLine("List is empty");
        return;
    }

    do
    {
        Console.WriteLine("Select number to delete");
        inputNumber = Console.ReadLine();
        if (int.Parse(inputNumber) > todoList.Count)
        {
            Console.WriteLine("Invalid Number");
        }
        else
        {
            todoList.RemoveAt(int.Parse(inputNumber) - 1);
        }
    } while (int.Parse(inputNumber) !< todoList.Count);
    
}

