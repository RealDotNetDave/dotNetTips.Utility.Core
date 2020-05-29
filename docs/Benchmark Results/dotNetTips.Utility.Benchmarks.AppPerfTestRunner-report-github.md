``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.300
  [Host]     : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT
  Job-LAEGID : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=App  

```
|                  Method |             Mean |          Error |          StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------------ |-----------------:|---------------:|----------------:|--------:|-------:|------:|----------:|
| **GetEnvironmentVariables** |    **37,652.245 ns** |  **1,294.8576 ns** |   **3,756.6168 ns** |  **1.5259** |      **-** |     **-** |   **14696 B** |
|        **IsProcessRunning** | **1,270,430.823 ns** | **24,996.1314 ns** |  **65,410.5192 ns** | **31.2500** | **7.8125** |     **-** |  **288614 B** |
|               **IsRunning** | **2,362,970.855 ns** | **47,061.2842 ns** | **104,284.5551 ns** | **27.3438** | **3.9063** |     **-** |  **289655 B** |
|     **IsRunningFromAspNet** |         **1.449 ns** |      **0.0747 ns** |       **0.1955 ns** |       **-** |      **-** |     **-** |         **-** |
|    **ReferencedAssemblies** |   **129,966.028 ns** |  **3,883.7292 ns** |  **11,205.4469 ns** |  **3.4180** |      **-** |     **-** |   **32424 B** |
|              **StackTrace** |   **117,865.114 ns** |  **5,113.2124 ns** |  **14,915.4806 ns** |  **2.1973** |      **-** |     **-** |   **21071 B** |
|              **WorkingSet** |       **303.741 ns** |     **13.8017 ns** |      **40.0412 ns** |       **-** |      **-** |     **-** |         **-** |
