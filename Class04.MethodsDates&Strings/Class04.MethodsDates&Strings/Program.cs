// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Task 1
//Take one string from the input and print its last 5 characters.

Console.WriteLine("Please write smth");
string input = Console.ReadLine();
bool isNumber = int.TryParse(input, out int number);

if (!isNumber)
{
    if(input.Length > 5)
    {
        string lastFiveChar = input.Substring(input.Length - 5);
        Console.WriteLine($"The last 5 characters are: {lastFiveChar}");
    }
    else
    {
        Console.WriteLine("The string must be larger than 5 characters!");
    }
}
else
{
    Console.WriteLine("Not a valid input!");
}

//Task 2
//Take a sentence as input and print its words.

Console.WriteLine("Please write a sentence");
string userSentence = Console.ReadLine();

string[] words = userSentence.Split(' ');
Console.WriteLine("Words in the sentence are:");

foreach (string word in words)
{
    Console.WriteLine(word);
}

//Task 3
//Create a function that takes a number as input.
//This method should return the sum of the digits in the number.


void sumOfDigits()
{
    Console.WriteLine("Enter a number");
    string userInput = Console.ReadLine();

    char[] chars = userInput.ToCharArray();
    int sum = 0;
    foreach (char number in chars)
    {
        sum += int.Parse(number.ToString());
    }
    Console.WriteLine($"The sum of the digits in the number is: {sum}");
}
sumOfDigits();

//Task 
//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today

int ageCalculator (DateTime birthdayDate)
{
    DateTime today = DateTime.Today;
    int age = (today.Year - birthdayDate.Year) - 1;

    if(today.Month >= birthdayDate.Month && today.Day >= birthdayDate.Day)
    {
        age += 1;
    }
    return age;
}
DateTime myBirthday = new DateTime(1992, 06, 10);
Console.WriteLine($"You are {ageCalculator(myBirthday)} years");