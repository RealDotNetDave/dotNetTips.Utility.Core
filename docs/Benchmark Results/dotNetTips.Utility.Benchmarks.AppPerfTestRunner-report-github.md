``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.302
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GMGNJH : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=App  

```
|                  Method |             Mean |          Error |         StdDev |   Gen 0 |   Gen 1 | Gen 2 | Allocated |
|------------------------ |-----------------:|---------------:|---------------:|--------:|--------:|------:|----------:|
| **GetEnvironmentVariables** |    **26,955.668 ns** |    **533.8959 ns** |    **892.0201 ns** |  **1.5259** |  **0.0305** |     **-** |   **14696 B** |
|        **IsProcessRunning** | **1,339,931.669 ns** | **23,459.2241 ns** | **20,795.9911 ns** | **35.1563** |  **9.7656** |     **-** |  **337140 B** |
|               **IsRunning** | **2,496,906.159 ns** | **40,468.4915 ns** | **37,854.2521 ns** | **35.1563** | **11.7188** |     **-** |  **339891 B** |
|     **IsRunningFromAspNet** |         **1.219 ns** |      **0.0571 ns** |      **0.0999 ns** |       **-** |       **-** |     **-** |         **-** |
|    **ReferencedAssemblies** |    **94,615.614 ns** |  **1,866.3820 ns** |  **3,640.2348 ns** |  **3.2959** |       **-** |     **-** |   **32424 B** |
|              **StackTrace** |    **83,283.799 ns** |  **1,648.7733 ns** |  **3,254.5177 ns** |  **2.1973** |       **-** |     **-** |   **21094 B** |
|              **WorkingSet** |       **201.343 ns** |      **3.8243 ns** |      **6.3895 ns** |       **-** |       **-** |     **-** |         **-** |
