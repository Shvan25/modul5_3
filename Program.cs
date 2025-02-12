using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "Евгения";

        GetName(ref name);
        Console.WriteLine(name);
    }
    static void GetName(ref string name)
    {
        Console.WriteLine("Введите имя");
        name = Console.ReadLine();

    }
}