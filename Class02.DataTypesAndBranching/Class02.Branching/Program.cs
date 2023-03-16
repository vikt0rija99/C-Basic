// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// If / Else 

if (5 > 3)
{
    Console.WriteLine("5 is larger than 3");
}
else
{
    Console.WriteLine("5 is not larger than 3");
}

//Switch
int day = 3;

switch(day)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Work day :(");
        break;
    case 6:
    case 7:
        Console.WriteLine("Weekend! WOHO!");
        break;
    default:
        Console.WriteLine("There is no such day!Sorry!");
    break;
}