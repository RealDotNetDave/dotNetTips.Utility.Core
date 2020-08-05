``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.302
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GMGNJH : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=TypeHelper  

```
|                      Method |              Mean |           Error |          StdDev |            Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |------------------:|----------------:|----------------:|------------------:|-------:|------:|------:|----------:|
|                      **Create** |        **56.9023 ns** |       **1.1594 ns** |       **2.1200 ns** |        **56.9289 ns** | **0.0127** |     **-** |     **-** |     **120 B** |
|     **DoesObjectEqualInstance** |    **14,965.1391 ns** |     **294.7119 ns** |     **458.8309 ns** |    **15,029.8180 ns** | **0.5646** |     **-** |     **-** |    **5446 B** |
|            **FindDerivedTypes** | **3,570,485.4167 ns** | **156,345.1905 ns** | **451,091.6224 ns** | **3,484,950.0000 ns** |      **-** |     **-** |     **-** |  **174128 B** |
|                  **GetDefault** |         **0.0174 ns** |       **0.0189 ns** |       **0.0315 ns** |         **0.0000 ns** |      **-** |     **-** |     **-** |         **-** |
|         **GetInstanceHashCode** |     **2,542.3980 ns** |      **50.1103 ns** |      **73.4510 ns** |     **2,540.9809 ns** | **0.0458** |     **-** |     **-** |     **432 B** |
|     **GetTypeDisplayName:Type** |       **262.9406 ns** |       **9.6584 ns** |      **28.1741 ns** |       **254.7821 ns** | **0.0410** |     **-** |     **-** |     **392 B** |
| **GetTypeDisplayName:Variable** |       **167.4144 ns** |       **3.3627 ns** |       **8.7996 ns** |       **167.8437 ns** | **0.0415** |     **-** |     **-** |     **392 B** |
