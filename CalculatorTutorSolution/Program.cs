Console.WriteLine("Hello");
Console.WriteLine("Input the first number:");
var firstAsText = Console.ReadLine();
var number1 = int.Parse(firstAsText);

Console.WriteLine("Input the second number:");
var secondAsText  = Console.ReadLine();
var number2 = int.Parse(secondAsText);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

var choice = Console.ReadLine();

if(EqualsCaseInssenstive(choice, "A"))
{
    var sum = number1 + number2;
    //Console.WriteLine(number1 + " + " + number2 + " = " + sum);
    PrintFinalEquation(number1, number2, sum, "+");
}
else if (EqualsCaseInssenstive(choice, "S"))
{
    var subtract = number1 - number2;
    //Console.WriteLine(number1 + " - " + number2 + " = " + subtract);
    PrintFinalEquation(number1, number2, subtract, "-");
}
else if(EqualsCaseInssenstive(choice, "M"))
{
    var multiply = number1 * number2;
    //  Console.WriteLine(number1 + " * " + number2 + " = " + multiply);
    PrintFinalEquation(number1, number2, multiply, "*");
}
else
{
    Console.WriteLine("Invalid Option");
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

void PrintFinalEquation(int number1, int number2, int result, string @operator)
{
    Console.WriteLine(number1 + " " + @operator + " " + number2 + " = " + result);
}

bool EqualsCaseInssenstive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}