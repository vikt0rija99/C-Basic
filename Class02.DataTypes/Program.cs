// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int num = 5;
string words = "Hello people";
char letter = 'P';
bool falsy = false;
double deci = 0.2;
//num = "Hey";   -   This will be marked as an error
Console.WriteLine(num.GetType());// Find out what type some variable is




var implicitInt = 23;
var implicitString = "Hello";

implicitInt = 33; // We can change the value of the same type
                  // implicitInt = "Hey";   -  This will lead to compilation error.We can't change the type any more




// Data Entry

Console.WriteLine("Enter your name");
string name = Console.ReadLine();
Console.WriteLine("Hello there " + name + "!");



// Data Conversion

// Using Parse method

int parseInt = int.Parse("23");
double parseDouble = double.Parse("23.5");
 

// Using Convert method

int convertInt = Convert.ToInt32("23");
double convertDouble = Convert.ToDouble("23.5");

// Using TryParse method
// If the converting is successful the value will be written here

int ifParsedValue;

// A boolean variable that will keep info if the parsing was successful or not
bool parsingSuccess = int.TryParse("25", out ifParsedValue);
Console.WriteLine(parsingSuccess); // true

int parsedInteger = 0;
bool isValidParsing = int.TryParse("2", out parsedInteger);

Console.WriteLine(isValidParsing);
Console.WriteLine(parsedInteger);

bool isValidNumber = int.TryParse("5", out int value);

Console.WriteLine(isValidNumber);
Console.WriteLine(value);