``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=TypeHelper  

```
|                      Method |              Mean |          Error |          StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |------------------:|---------------:|----------------:|-------:|------:|------:|----------:|
|     **DoesObjectEqualInstance** |    **12,391.3101 ns** |     **24.5113 ns** |      **22.9279 ns** | **0.5646** |     **-** |     **-** |    **5446 B** |
|            **FindDerivedTypes** | **3,204,300.0000 ns** | **63,735.8525 ns** | **178,722.1636 ns** |      **-** |     **-** |     **-** |  **192024 B** |
|                  **GetDefault** |         **0.0227 ns** |      **0.0034 ns** |       **0.0032 ns** |      **-** |     **-** |     **-** |         **-** |
|         **GetInstanceHashCode** |     **2,112.9804 ns** |      **4.6336 ns** |       **4.1076 ns** | **0.0458** |     **-** |     **-** |     **432 B** |
|     **GetTypeDisplayName:Type** |       **191.2926 ns** |      **0.2386 ns** |       **0.2115 ns** | **0.0412** |     **-** |     **-** |     **392 B** |
| **GetTypeDisplayName:Variable** |       **137.4205 ns** |      **0.2095 ns** |       **0.1749 ns** | **0.0412** |     **-** |     **-** |     **392 B** |
