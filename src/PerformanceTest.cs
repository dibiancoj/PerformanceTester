using BenchmarkDotNet.Attributes;
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
        //1. benchmark dot net is only comp with dot net core 1.1. That is why csproj contains <TargetFrameworks>netcoreapp2.1;net46</TargetFrameworks>

        // *** to run from command line prompt "dotnet run -c Release --framework netcoreapp2.1" *** (using net46 because you need to specify a framework. However, both jobs will run)

        [GlobalSetup]
        public void Init()
        {
        }

        private const int TestData = 2;

        [Benchmark(Baseline = true)]
        public async Task<int> Task_Test()
        {
            return await Task.FromResult(TestData);
        }

        [Benchmark]
        public async ValueTask<int> ValueTask_Test()
        {
            return await new ValueTask<int>(TestData);
        }

    }

}
