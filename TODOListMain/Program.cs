

List<string> todos = new List<string>();
string userChoice;
Console.WriteLine("Hello");

do
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    Console.WriteLine();
    Console.WriteLine();

    userChoice = Console.ReadLine().ToUpper();

    switch (userChoice)
    {
        case "S":
            SeeAllTodos(todos);
            break;
        case "A":
            AddTodo(todos);
            break;
        case "R":
            RemoveTodo(todos);
            break;
        case "E":
            Exit();
            break;
        default:
            Console.WriteLine("invalid choice");
            break;
    }
} while (userChoice != "E");

    // method to print all todos - print numbered list of all todos
static void SeeAllTodos(List<string> todos)
    {
        foreach (var todo in todos)
        {
            if (todos.Count > 0)
            {
                Console.WriteLine((todos.IndexOf(todo) + 1) + ". " + todo);
            }
            else
            {
                Console.WriteLine("No TODOs have been added yet.");
            }
            Console.WriteLine();
        }
    }

// method to add todos
static void AddTodo(List<string> todos)
{
    Console.WriteLine("Enter the TODO Description: ");
    string todoDescription = Console.ReadLine();

    if (string.IsNullOrEmpty(todoDescription))
    {
        Console.WriteLine("Description cannot be empty!");
    }
    else if (todos.Contains(todoDescription))
    {
        Console.WriteLine("The descripton must be unique!");
    } else
    {
        todos.Add(todoDescription);
        Console.WriteLine("TODO successfully added: " + todoDescription);
    }
  
}

//method to delete todos
static void RemoveTodo(List<string> todos) 
{
    if (todos.Count == 0) 
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }

    while (true)
    {
        Console.WriteLine("Select the index of the TODO you want to remove:");
        for(int i = 0; i < todos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todos[i]}");
        }

        string selectedIndex = Console.ReadLine();

        if(string.IsNullOrEmpty(selectedIndex))
        {
            Console.WriteLine("Selected index cannot be empty!");
        }
        else if (int.TryParse(selectedIndex, out int todoIndex) && todoIndex >= 1 && todoIndex <= todos.Count)
        {
            string removedTodo = todos[todoIndex - 1];
            todos.RemoveAt(todoIndex -1);
            Console.WriteLine($"TODO Removed: {removedTodo}");
        }
        else
        {
            Console.WriteLine("The given index is not valid");
            break;
        }
    }
};


//method to exit program
 static void Exit()
 {
    Console.WriteLine("Goodbye!");
    Environment.Exit(0);
 }

 Console.ReadKey();