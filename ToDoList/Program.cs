
//Console.WriteLine("Hello");
//Console.WriteLine("What do you want to do?");
//Console.WriteLine("[S]ee all TODOs");
//Console.WriteLine("[A]dd a TODO");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");

//string userChoice = Console.ReadLine().ToUpper();

//switch(userChoice)
//{
//    case "S": 
//        PrintSelectedOption("See all TODOs");
//        break;
//    case "a":
//    case "A":
//        PrintSelectedOption("Add a TODO");
//        break;
//    case "R":
//        PrintSelectedOption("Remove a TODO");
//        break;
//    case "E":
//        PrintSelectedOption("Exit");
//        break;
//    default:
//        Console.WriteLine("invalid choice");
//        break;

//}

//if (userChoice == "S")
//{
//    PrintSelectedOption("See all TODOs");
//}
//else if (userChoice == "A")
//{
//    PrintSelectedOption("Add a TODO");
//}
//else if (userChoice == "R")
//{
//    PrintSelectedOption("Remove a TODO");
//}
//else if (userChoice == "E")
//{
//    PrintSelectedOption("Exit");
//}
//else
//{
//    Console.WriteLine("invalid choice");
//}


//void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine("Selected option: " + selectedOption);
//}

//char ConvertPointsoGrade(int points)
//{

//    switch (points)
//    {
//        case 10:
//        case 9:
//            return 'A';
//        case 8:
//        case 7:
//            return 'B';
//        case 5:
//        case 4:
//        case 3:
//            return 'C';
//        case 2:
//        case 1:
//            return 'D';
//        case 0:
//            return 'E';
//        default:
//            return '!';
//    }

//}

//// String Interpolation
//int a = 4, b = 2, c = 10;

//Console.WriteLine("First is: " + a + ", second is: " + b + ", third is: " + c);
//Console.WriteLine($"First is: {a}, second is: {b}, third is: {c}");`


// WHILE LOOP
//var number = 0;

//while(number < 10)
//{
//   // number += 1;
//    number++;
//    Console.WriteLine($"Number is: {number}");
//}


//Console.WriteLine("Enter a word:");
//var userInput = Console.ReadLine();

//while(userInput.Length < 15)
//{
//    userInput += 'a';
//    Console.WriteLine(userInput);
//}


// DO WHILE LOOP
//string word;

//do
//{
//    Console.WriteLine("Enter a word longer than 10 letters");
//    word = Console.ReadLine();
//}
//while (word.Length <= 10);

//int userNumber;
//do
//{
//    Console.WriteLine("Enter a number larger than 10;");
//    var userInput = Console.ReadLine();

//    if(userInput == "stop")
//    {
//        break;
//    }
    
//    bool isParsabelToInt = userInput.All(char.IsDigit);
//    if(!isParsabelToInt)
//    {
//        userNumber = 0;
//        continue;
//    }
//    userNumber = int.Parse(userInput);
//} while (userNumber <= 10);


// Arrays

//int[] numbers = new int[5];
//numbers[0] = 5;
//numbers[1] = 6;
//numbers[2] = 5;
//numbers[3] = 17;
//numbers[4] = 22;

//var firstFromEnd = numbers[^1];
//var secondFromEnd = numbers[^2];

int[] digits = new int[] { 2, 6, 1, 6, 19 };
// or
var didgits = new [] { 2, 6, 1, 6, 19 };

var sum = 0;
for (var i = 0; i < digits.Length; i++)
{
  sum += digits[i];
}
Console.WriteLine("sum of elements is: " + sum);

//Multi-Dimensional Array

char[,] letters = new char[2, 3];
letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';


var height = letters.GetLength(0); // need to use GetLength for multi-dimensional array  - .length won't work - it will get the length of all the elements.
var width = letters.GetLength(1);
Console.WriteLine("Height is " + height);
Console.WriteLine("Width is " + width);

for (var i = 0; i < height; i++)
{
    Console.WriteLine("i is " + i);
    for (var j = 0; j < width; j++)
    {
        Console.WriteLine("j is " + j);
        Console.WriteLine("element is " + letters[i,j]);
    }
}

    var letters2 = new char[,]
{
    {'A', 'B', 'C' },
    {'D', 'E', 'F' },
};

//FOREACH LOOP

//var words = new[] { "one", "two", "three", "four" };

//foreach(var word in words)
//{
//    Console.WriteLine(word);
//}


// LISTS
List<string> words = new List<string>();
words.Add("hello");

//or 
var moreWords = new List<string>
{
    "one",
    "two",
};

foreach (var word in moreWords)
{
    Console.WriteLine(word);
}
Console.WriteLine(words.Count);

moreWords.Remove("two");
moreWords.RemoveAt(0);  //remove element at a specific index

var evenMoreWords = new[] { "three", "four", "five" };
moreWords.AddRange(evenMoreWords);
// or 
moreWords.AddRange(new[] { "three", "four", "five" });

Console.WriteLine("Index of element 'four' is " + moreWords.IndexOf("four"));

Console.WriteLine("COntains 'five'?: " + moreWords.Contains("five"));
Console.WriteLine("COntains 'seven'?: " + moreWords.Contains("seven"));

words.Clear(); // Removes all elements from list

// OUT KEYWORD
var numbers = new[] { 10, -8, 2, 12, -17 };
int nonPositiveCount;

//select and return positive numbers
var onlyPostive = GetOnlyPositive(numbers, out nonPositiveCount);
foreach(var positiveNum in onlyPostive)
{
    Console.WriteLine( positiveNum);
}
Console.WriteLine("Count of non positive: " + nonPositiveCount);
List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
    // out keyword must be assigned a value
{
    countOfNonPositive = 0;
    var result = new List<int>();

    foreach(var number in numbers)
    {
        if (number > 0)
        {
            result.Add(number);
        }
        else
        {
            countOfNonPositive++;
        }
    }
  return result;
}


// TRYPARSE



bool isParsingSuccess;
do
{
    Console.WriteLine("Enter a number: ");
    var userInput = Console.ReadLine();

    isParsingSuccess = int.TryParse(userInput, out int number);
    if (isParsingSuccess)
    {
        Console.WriteLine("Parsing successful, numbr is " + number);
    }
    else
    {
        Console.WriteLine("Parsing failed");
    }
}while (!isParsingSuccess);







Console.ReadKey();