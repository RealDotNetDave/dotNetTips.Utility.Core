``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=App  

```
|                  Method |           Mean |         Error |        StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------------ |---------------:|--------------:|--------------:|--------:|-------:|------:|----------:|
| **GetEnvironmentVariables** |  **23,862.821 ns** |    **28.1458 ns** |    **23.5030 ns** |  **1.5564** | **0.0610** |     **-** |   **14504 B** |
|        **IsProcessRunning** | **389,030.340 ns** | **1,370.8598 ns** | **1,215.2315 ns** | **14.6484** | **2.4414** |     **-** |  **139598 B** |
|               **IsRunning** | **759,586.126 ns** | **4,700.1252 ns** | **4,396.5000 ns** | **15.6250** | **1.9531** |     **-** |  **154700 B** |
|     **IsRunningFromAspNet** |       **1.376 ns** |     **0.0046 ns** |     **0.0039 ns** |       **-** |      **-** |     **-** |         **-** |
|    **ReferencedAssemblies** |  **79,972.674 ns** |   **737.4467 ns** |   **575.7499 ns** |  **3.4180** |      **-** |     **-** |   **32424 B** |
|              **StackTrace** |  **70,834.458 ns** |   **214.5141 ns** |   **179.1290 ns** |  **2.1973** |      **-** |     **-** |   **21095 B** |
|              **WorkingSet** |     **175.798 ns** |     **0.4807 ns** |     **0.4497 ns** |       **-** |      **-** |     **-** |         **-** |
