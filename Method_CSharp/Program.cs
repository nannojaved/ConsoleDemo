// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Topic: Method in C#
// Elements / Components of a Method
// 1- Access specifier
// 2- return type
// 3- Name
// 4- Parameters
// 5- body

using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi");
        SayHellow("2IT-BHV");
        Add(5, 7);
    }

    static void SayHellow(string userInput)
    {
        Console.WriteLine("Hi mr. " + userInput);
    }

    static void Add(int tall1, int tall2)
    {
        Console.WriteLine("1- Pluss av begge tallene er: " + (tall1 + tall2));
        int sum = tall1 + tall2;
        Console.WriteLine("2- Pluss av begge tallene er: " + sum);
        Console.WriteLine(tall1 + tall2);
        
    }
}

