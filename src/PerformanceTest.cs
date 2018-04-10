using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTester
{

    //CLR = Full Framework
    //Core = Dot Net Core
    [ClrJob, CoreJob]
    [MemoryDiagnoser]
    public class PerformanceTest
    {

        //notes:
        //1. benchmark dot net is only comp with dot net core 1.1. That is why csproj contains <TargetFrameworks>netcoreapp1.1;net46</TargetFrameworks>

        // *** to run from command line prompt "dotnet run -c Release --framework net46" *** (using net46 because you need to specify a framework. However, both jobs will run)

        [GlobalSetup]
        public void Init()
        {
        }

        private const int TestData = 2;

        [Benchmark(Baseline = true)]
        public Task<int> Task_Test()
        {
            return Task.FromResult(TestData);
        }

        [Benchmark]
        public ValueTask<int> ValueTask_Test()
        {
            return new ValueTask<int>(TestData);
        }

    }

}
