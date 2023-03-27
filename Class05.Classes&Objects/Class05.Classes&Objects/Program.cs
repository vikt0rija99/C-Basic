// See https://aka.ms/new-console-template for more information
using Class05.Classes_Objects;

Console.WriteLine("Hello, World!");

//Task 1
//Create a class Human
//Add properties: FirstName, LastName, Age
//Create a method called GetPersonDetails that returns the full name of the human as well as their age
//Create an object human by asking the user to fill the required information (take first name, last name and age from user input)
//Call the GetPersonDetails method and print the result in the console after the object is created

Human human = new Human();

Console.WriteLine("Enter firstname: ");
human.FirstName = Console.ReadLine();

Console.WriteLine("Enter lastname: ");
human.LastName = Console.ReadLine();

Console.WriteLine("Enter age: ");
human.Age  = int.Parse(Console.ReadLine());

string humanDetails = human.GetPersonalDetails();
Console.WriteLine(humanDetails);