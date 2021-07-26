using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace StockAnalyzer.AdvancedTopic
{
    class Program
    {
        static object syncRoot = new object();
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            decimal result = 0.0m;
            for (int i = 0; i < 100; i++)
            {
                result += Compute(i);
            }
            Console.WriteLine($"Sum is {result}, it took {stopWatch.ElapsedMilliseconds}ms to run");

            stopWatch.Restart();
            result = 0.0m;
            Parallel.For(0, 100, (i) =>
             {
                 var compute = Compute(i);
                 lock(syncRoot) // In lock only put the piece of code which has should run one at a time, If we call Compute(i) inside the lock, performance will degrade
                 {
                     result += compute;
                 }
             });
            Console.WriteLine($"Sum is {result}, it took {stopWatch.ElapsedMilliseconds}ms to run");
        }

        static Random random = new Random();
        static decimal Compute(int value)
        {
            var randomMilliseconds = random.Next(10, 50);
            var end = DateTime.Now + TimeSpan.FromMilliseconds(randomMilliseconds);
            while (DateTime.Now < end)
            {

            }
            return value + 0.05m;
        }
    }
}
