using System;
namespace TourOfCsharp;

class Program {
    static void Main()
    {
        ulong tam = 1000000000;
        Console.WriteLine(Pi(tam));
        Console.WriteLine("Fim");
    }

    static double Pi(ulong n){
        double x = 0f;

        for (ulong i = 0; i <= n; i++)
        {
            x += (Math.Pow(-1, i) / (2 * i + 1));
        }
        return x*4;
    }
    

}