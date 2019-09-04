using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main()
    {

        int[] arr = Enumerable.Range(1, 10000).ToArray();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        IEnumerable<int> numbers1 = arr.Where(n => n % 2 == 0).Where(n => n % 5 == 0);
       
        foreach (var num in numbers1)
            Console.WriteLine(num);

        stopwatch.Stop();
        Console.WriteLine($"For enumerable {stopwatch.ElapsedMilliseconds}");

        stopwatch.Restart();

        IQueryable<int> numbers2 = arr.AsQueryable().Where(n => n % 2 == 0).Where(n => n % 5 == 0);
        
        foreach (var num in numbers2)
            Console.WriteLine(num);

        stopwatch.Stop();
        Console.WriteLine($"For queryable {stopwatch.ElapsedMilliseconds}");


        Console.ReadKey();
    }

  
}