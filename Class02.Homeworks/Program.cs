// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

//Task 1
//Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25

Console.WriteLine("Please enter the first number: ");
bool isFirstNumberParsed = int.TryParse(Console.ReadLine(), out int firstNumber);

Console.WriteLine("Please enter the second number: ");
bool isSecondNumberParsed = int.TryParse(Console.ReadLine(), out int secondNumber);

Console.WriteLine("Please choose the operation ( +, - , * , / ): ");
bool isOperationParsed = char.TryParse(Console.ReadLine(), out char operation);


if (isFirstNumberParsed && isSecondNumberParsed && isOperationParsed)
{
    int result = 0;
    switch (operation)
    {
        case '+':
            result = firstNumber + secondNumber;
            break;
        case '-':
            result = firstNumber - secondNumber;
            break;
        case '*':
            result = firstNumber * secondNumber;
            break;
        case '/':
            result = firstNumber / secondNumber;
            break;
        default:
            Console.WriteLine("Choose the right operation");
            break;
    }
    Console.WriteLine("The result is: " + result);

}
else
{
    Console.WriteLine("Not a valid input!");
}


//Task 2
//Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30
//Expected Output:
//The average of 10, 15, 20 and 30 is: 18

Console.Write("Please enter the first number: ");
bool isFirstNumberrParsed = double.TryParse(Console.ReadLine(), out double firstNumberr);

Console.Write("Please enter the second number: ");
bool isSecondNumberrParsed = double.TryParse(Console.ReadLine(), out double secondNumberr);

Console.Write("Please enter the third number: ");
bool isThirdNumberParsed = double.TryParse(Console.ReadLine(), out double thirdNumber);

Console.Write("Please enter the fourth number: ");
bool isFourthNumberParsed = double.TryParse(Console.ReadLine(), out double fourthNumber);


if (isFirstNumberParsed && isSecondNumberParsed && isThirdNumberParsed && isFourthNumberParsed)
{
    double average = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
    Console.WriteLine("The average of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + " and  " + fourthNumber + " is: " + average);
}
else
{
    Console.WriteLine("Invalid number!");
}

//Task 3:
//Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:

//Test Data:
//Input the First Number: 5
//Input the Second Number: 8
//Expected Output:
//After Swapping:
//First Number: 8
//Second Number: 5

Console.Write("Input the first number: ");
bool isNumber1Parsed = int.TryParse(Console.ReadLine(), out int number1);

Console.Write("Input the Second number: ");
bool isNumber2Parsed = int.TryParse(Console.ReadLine(), out int number2);

if (isNumber1Parsed && isNumber2Parsed)
{
    Console.WriteLine("After Swapping:");
    int number = number1;
    number1 = number2;
    number2 = number;

    Console.WriteLine("First number: " + number1);
    Console.WriteLine("Second number: " + number2);

}
else
{
    Console.WriteLine("Please enter a valid input!");
}