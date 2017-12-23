using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTester
{

    [MemoryDiagnoser]
    public class PerformanceTest
    {

        // *** to run from command line prompt "dotnet run -c Release" ***

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
