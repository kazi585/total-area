// # total-area
using System;

class Circle

{

    static void Main()
    {

        Console.WriteLine(DateTime.Now);

        double a, b;

        Console.WriteLine("введите сторону 'a' в см.");
        a = double.Parse (Console.ReadLine());

        Console.WriteLine("введите сторону 'b' в см.");
        b = double.Parse (Console.ReadLine());

        Console.WriteLine("общая площадь равнв " + (a * b) + "см2");

        Console.WriteLine(DateTime.Now);
    }
}
