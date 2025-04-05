
var todos = new List<string>();

bool shallExit = false;

Console.WriteLine("Hello");

while (!shallExit)
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    Console.WriteLine();


    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "S":
        case "s":
            SeeAllTodos();
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R":
        case "r":
            RemoveTodo();
            break;
        case "E":
        case "e":
            shallExit = true;
            break;
        default:
            Console.WriteLine("invalid choice");
            break;
    }
}

Console.ReadKey();
void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;   // return statement eliminates need for else statement as for loop will not run unless condition is met
    }

    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }
}


void AddTodo()
{
    string description;

    do
    {
        Console.WriteLine("Enter the TODO Description: ");
        description = Console.ReadLine();

    } while (!IsDescriptionValid(description));

    todos.Add(description);
}

bool IsDescriptionValid(string description)
{
    if (description == "")
    {
        Console.WriteLine("Description cannot be empty!");
        return false;
    }
    else if (todos.Contains(description))
    {
        Console.WriteLine("The descripton must be unique!");
        return false;
    }
    return true;
}

void RemoveTodo()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessage();
        return;
    }

    int index; ;
    do
    {
        Console.WriteLine("Select the index of the TODO you want to remove:");
        SeeAllTodos();

    } while (!TryReadIndex(out index));

    RemoveToDoAtIndex(index - 1);

}

void RemoveToDoAtIndex(int index)
{
    var todoToBeRemoved = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine("TODO removed: " + todoToBeRemoved);
}

bool TryReadIndex(out int index)
{
    var userInput = Console.ReadLine();

    if (userInput == "")
    {
        index = 0;
        Console.WriteLine("Selected index cannot be empty!");
        return false;
    }

    if (int.TryParse(userInput, out index) && index >= 1 && index <= todos.Count)
    {
        return true;
    }

    Console.WriteLine("The given index is not valid");
    return false;
}

static void ShowNoTodosMessage()
{
    Console.WriteLine("No TODOs have been added yet.");
}