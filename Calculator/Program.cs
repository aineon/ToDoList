
Console.WriteLine("Hello");
Console.WriteLine("Input the first number:");
string number1 =  Console.ReadLine();
int firstNumber =  int.Parse(number1);

Console.WriteLine("Input the second number:");
string number2 = Console.ReadLine();
int secondNumber = int.Parse(number2);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string userSelection = Console.ReadLine().ToUpper(); ;
int result;

if (userSelection == "A")
    {
    
    Add(firstNumber, secondNumber);
    Console.WriteLine(firstNumber + " + " + secondNumber + " = " + result);
}
    else if (userSelection == "S")
    {
        Subtract(firstNumber, secondNumber);
    Console.WriteLine(firstNumber + " - " + secondNumber + " = " + result);
}
    else if (userSelection == "M")
    {
        Multiply(firstNumber, secondNumber);
    Console.WriteLine(firstNumber + " * " + secondNumber + " = " + result);
}
    else 
    {
        Console.WriteLine("Invalid Option");
    }


int Add(int a, int b)
{
    
    return result = a + b; 
}

int Subtract(int a, int b)
{
    return result = a - b;
    
}

int Multiply(int a, int b)
{
    return result = a * b; 
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();