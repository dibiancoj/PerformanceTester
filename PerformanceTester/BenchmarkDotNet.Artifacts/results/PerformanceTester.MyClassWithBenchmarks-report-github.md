``` ini

BenchmarkDotNet=v0.10.11, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.125)
Processor=AMD FX(tm)-8120 Eight-Core Processor, ProcessorCount=8
Frequency=14318180 Hz, Resolution=69.8413 ns, Timer=HPET
.NET Core SDK=2.1.2
  [Host]     : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT


```
| Method |     Mean |    Error |   StdDev |     Gen 0 |  Allocated |
|------- |---------:|---------:|---------:|----------:|-----------:|
|    Old | 654.7 us | 5.156 us | 4.823 us | 1811.5234 | 2787.16 KB |
|    New | 109.7 us | 2.728 us | 2.801 us |   29.5410 |   45.55 KB |
