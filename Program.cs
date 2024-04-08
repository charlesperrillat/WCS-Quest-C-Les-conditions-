// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a minimum number:");
int limit1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a maximum number:");
int limit2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter an in-between number:");
int integer = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Limit 1: " + limit1);
Console.WriteLine("Limit 2: " + limit2);
Console.WriteLine("Integer to limit: " + integer);

if (integer < limit1)
{
    Console.WriteLine("You have entered " + integer + " which is lower than " + limit1 + " which is the minimum");
    Console.WriteLine("Resulting integer: " + limit1);
}
else if (integer > limit2)
{
    Console.WriteLine("You have entered " + integer + " which is greater than " + limit2 + " which is the maximum");
    Console.WriteLine("Resulting integer: " + limit2);
}
else
    Console.WriteLine("Good job!");


