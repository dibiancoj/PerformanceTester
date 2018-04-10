using BenchmarkDotNet.Running;
using System;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<PerformanceTest>();

            Console.WriteLine("Performance Test Complete. Press Any Key To Exit.");
            Console.ReadKey();
        }
    }

}
