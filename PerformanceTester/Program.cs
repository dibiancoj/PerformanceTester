using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTester
{
    class Program
    {

        // *** to run from command line prompt "dotnet run -c Release" ***

        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<PerformanceTest>();

            Console.WriteLine("Performance Test Complete. Press Any Key To Exit");
            Console.ReadLine();
        }
    }

}
