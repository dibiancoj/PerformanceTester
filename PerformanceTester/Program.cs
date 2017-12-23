using BenchmarkDotNet.Attributes;
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
            var summary = BenchmarkRunner.Run<MyClassWithBenchmarks>();

            Console.WriteLine("Performance Test Complete. Press Any Key To Exit");
            Console.ReadLine();
        }
    }

    // *** to run from command line prompt "dotnet run -c Release" ***

    [MemoryDiagnoser]
    public class MyClassWithBenchmarks
    {

        [GlobalSetup]
        public void Init()
        {
        }

        private Guid MyProperties { get; set; } = Guid.NewGuid();

        [Benchmark]
        public Task<Guid> Task_Test()
        {
            return Task.FromResult(MyProperties);
        }

        [Benchmark]
        public ValueTask<Guid> ValueTask_Test()
        {
            return new ValueTask<Guid>(MyProperties);
        }

    }

}
