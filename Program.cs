using System;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int m = int.Parse(input[0]);
        int n = int.Parse(input[1]);

        if ((m * n) % 2 == 0)
            Console.WriteLine("[:=[first]");
        else
            Console.WriteLine("[second]=:]");
    }
}
