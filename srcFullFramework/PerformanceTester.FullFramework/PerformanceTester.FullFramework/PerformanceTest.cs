﻿using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTester.FullFramework
{

    [MemoryDiagnoser]
    public class PerformanceTest
    {

        // *** to run from command line prompt "dotnet run -c Release" ***

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