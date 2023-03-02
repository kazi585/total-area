using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Timers;

class Circle
    // total area (общая площадь)

{

    static void Main(string[] args)
    {

        Console.WriteLine(DateTime.Today);

        double  a,b;

        Console.WriteLine("введите сторону ''a'' в см.");
        a = double. Parse (Console.ReadLine());

        Console.WriteLine(DateTime.Now);

        Console.WriteLine("введите сторону ''b'' в см.");
        b = double. Parse (Console.ReadLine());

        Console.WriteLine(DateTime.Now);

        Console.WriteLine("общая площадь равнв "+(a*b)+"см2");

        Console.WriteLine(DateTime.Now );
    }
}