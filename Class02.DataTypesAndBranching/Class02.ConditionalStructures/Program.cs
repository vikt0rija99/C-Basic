// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, World!");

// Exercise 1
//● Declare two double variables
//● Initialize them and divide them in a new variable
//● Declare two integer variables
//● Initialize them and divide them in a new variable
//● Print the results in the console and compare


double a = 2.3;
double b = 1.1;
double resultDouble = a / b;
Console.WriteLine(resultDouble);

int aa = 10;
int bb = 2;
int resultInt = aa / bb;
Console.WriteLine(resultInt);

// Exercise 2
//● Declare two string variables
//● Initialize them and concatenate them in a new variable
//● Declare two string variables
//● Initialize them with the number 9 and 3
//● Concatenate them in a new variable
//● Print the results in the console


string fName = "Viktorija";
string lName = "Zhivkovska";
string fullName = fName + " " + lName;
Console.WriteLine(fullName);

string fN = "9";
string sN = "3";
string NN = fN + sN;
Console.WriteLine(NN);

//Exercise 3
//● Declare an integer and a string variable
//● Initialize them and concatenate them in a new variable
//● Print the result in the console

int number = 0;
string test = "Zero";
string resultC = number + test;
Console.WriteLine(resultC);

//Exercise 4
//● You have n credits on your mobile bill. One SMS costs m credits.
//How many SMS messages you can send?
//● n = 102
//● m = 5
//● Result = ?

int nn = 102;
int mm = 5;
int sms = nn / mm;
Console.WriteLine(sms);

//Exercise 5
//Solve the following problem. On one tree there are 12 branches
//with n apples on them. One basket can hold m apples. If a user
//enters number of trees find out how many baskets does it take to
//collect all the apples from the trees?
//● n = 8
//● m = 5
//Result = ?

Console.Write("Please enter number of trees: ");
int trees = int.Parse(Console.ReadLine());
int n = 8;
int m = 5;
int treeApples = n * 12 * trees;
int result;

if (treeApples % m == 0)
{
    result = treeApples / m;
}
else
{
    result = treeApples / m + 1;
}
Console.WriteLine("You would need :" + result + " baskets!");

//Exercise 6
//● Create two variables and initialize them with a keyboard input
//● Write code that can test which number is larger
//● Write code that can test the numbers whether they are even or
//odd
//● Write the larger number from the two in the console
//● After that write if the number is even or odd

Console.WriteLine("Please enter 2 numbers");
string num1 = Console.ReadLine();
string num2 = Console.ReadLine();

// parse numbers
int number1;
int.TryParse(num1, out number1);
int number2;
int.TryParse(num2, out number2);


int larger = 0;
if (number1 > number2)
{
    larger = number1;
    Console.WriteLine("Number one is larger");
}
else if (number2 > number1)
{
    larger = number2;
    Console.WriteLine("Number two is larger");
}
else
{
    larger = number1;
    Console.WriteLine("They are equal");
}

if (larger != 0)
{
    if (larger % 2 == 0)
    {
        Console.WriteLine("Number is even");
    }
    else
    {
        Console.WriteLine("Number is odd");
    }
}
else
{
    Console.WriteLine("You entered Zero, That is not even nore odd !");
}

//Exercise 7  
//● Ask the user to enter a number from 1 to 3
//● If the user enters “1” write “You got a new car!”
//● If the user enters “2” write “You got a new plane!”
//● If the user enter “3” write “You got a new bike!”
//● If the user enters a wrong number or character write an error
//message in the console

Console.WriteLine("Enter a number from 1 to 3: ");
bool isUserInputParsed = int.TryParse(Console.ReadLine(), out int userInput);
if (isUserInputParsed)
{
    switch (userInput)
    {
        case 1:
            Console.WriteLine("You got a new car!");
            break;
        case 2:
            Console.WriteLine("You got a new plane!");
            break;
        case 3:
            Console.WriteLine("You got a new bike");
            break;
        default:
            Console.WriteLine("There is no such number");
            break;
    }
}
else
{
    Console.WriteLine("Not a valid input");
}