// See https://aka.ms/new-console-template for more information

//Task 1
//Make a console application called SumOfEven. Inside it create an array of 6 integers. Get numbers from the input, find and print the sum of the even numbers from the array:

//Test Data:
//Enter integer no.1:
//4
//Enter integer no.1:
//3
//Enter integer no.1:
//7
//Enter integer no.1:
//3
//Enter integer no.1:
//2
//Enter integer no.1:
//8
//Expected Output:
//The result is: 14


int[] intNumbers = new int[6];
int sum  = 0;
for (int i = 0; i < intNumbers.Length; i++)
{
    Console.WriteLine("Enter integer number  " + (i + 1));
    bool isInputParsed = int.TryParse(Console.ReadLine(), out int numberFromInput);

    if (isInputParsed)
    {
        intNumbers[i] = numberFromInput;

        if(numberFromInput % 2 == 0)
        {
            sum += numberFromInput;
        }
        if(i == intNumbers.Length - 1)
        {
            Console.WriteLine("The result is " + sum);
        }
    }
    else
    {
        Console.WriteLine("Not a valid input");
        break;
    }
}


//Task 2
//Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names (strings).
//Get a number from the console between 1 and 2 and print the students from that group in the console.

//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]

//Test Data:
//Enter student group: (there are 1 and 2 )
//1

//Expected Output:
//The Students in G1 are:
//Zdravko
//Petko
//Stanko
//Branko
//Trajko

string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentG2 = new string[] {"Darko", "Marko", "Vlajko", "Trajco", "Stanco" };

Console.WriteLine("Enter student group: ( there are 1 and 2 )");
bool isUserInputParsed = int.TryParse(Console.ReadLine(), out int userInput);

if (isUserInputParsed)
{
    if (userInput == 1)
    {
        Console.WriteLine("The Students in G1 are: ");
        foreach(string student in studentsG1)
        {
            Console.WriteLine($"{student}");
        }
    }
    else if(userInput == 2)
    {
        Console.WriteLine("The Student in G2 are: ");
        foreach(string student in studentG2 )
        {
            Console.WriteLine($"{student}");
        }
    }
    else
    {
        Console.WriteLine("There choose 1 or 2");
    }
}
else
{
    Console.WriteLine("Not a valid input");
}