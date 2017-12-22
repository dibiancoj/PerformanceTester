using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Text;

namespace PerformanceTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<MyClassWithBenchmarks>();

            Console.ReadLine();
        }
    }

    [MemoryDiagnoser]
    public class MyClassWithBenchmarks
    {

        [GlobalSetup]
        public void Init()
        {
        }

        //private string MyProperties { get; set; }

        [Benchmark]
        public string Old()
        {
            string s = "";

            for (int i = 0; i < 1000; i++)
            {
                s += i.ToString();
            }

            return s;
        }

        [Benchmark]
        public string New()
        {
            var s = new StringBuilder();

            for (int i = 0; i < 1000; i++)
            {
                s.Append(i);
            }

            return s.ToString();
        }

    }

}
