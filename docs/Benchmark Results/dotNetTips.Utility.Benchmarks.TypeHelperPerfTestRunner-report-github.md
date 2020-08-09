``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=TypeHelper  

```
|                      Method |              Mean |          Error |          StdDev |            Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |------------------:|---------------:|----------------:|------------------:|-------:|------:|------:|----------:|
|                      **Create** |        **43.0231 ns** |      **0.7326 ns** |       **0.6853 ns** |        **42.7089 ns** | **0.0126** |     **-** |     **-** |     **120 B** |
|     **DoesObjectEqualInstance** |    **12,517.0423 ns** |     **32.8696 ns** |      **25.6624 ns** |    **12,511.1259 ns** | **0.5646** |     **-** |     **-** |    **5446 B** |
|            **FindDerivedTypes** | **2,669,953.7634 ns** | **88,282.9760 ns** | **250,444.1088 ns** | **2,564,100.0000 ns** |      **-** |     **-** |     **-** |  **180368 B** |
|                  **GetDefault** |         **0.0269 ns** |      **0.0050 ns** |       **0.0044 ns** |         **0.0265 ns** |      **-** |     **-** |     **-** |         **-** |
|         **GetInstanceHashCode** |     **2,162.6412 ns** |      **7.0928 ns** |       **5.9228 ns** |     **2,163.2399 ns** | **0.0458** |     **-** |     **-** |     **432 B** |
|     **GetTypeDisplayName:Type** |       **188.2240 ns** |      **2.1856 ns** |       **2.0444 ns** |       **187.2692 ns** | **0.0415** |     **-** |     **-** |     **392 B** |
| **GetTypeDisplayName:Variable** |       **135.4992 ns** |      **2.5664 ns** |       **2.5206 ns** |       **137.0704 ns** | **0.0417** |     **-** |     **-** |     **392 B** |
