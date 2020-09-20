``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-preview.8.20417.9
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-RATGHQ : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=App  

```
|                  Method |           Mean |         Error |        StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------------ |---------------:|--------------:|--------------:|--------:|-------:|------:|----------:|
| **GetEnvironmentVariables** |  **19,470.877 ns** |    **35.0385 ns** |    **32.7750 ns** |  **1.3733** |      **-** |     **-** |   **12944 B** |
|        **IsProcessRunning** | **301,895.029 ns** | **6,018.8975 ns** | **5,911.3622 ns** | **11.7188** | **0.9766** |     **-** |  **111150 B** |
|               **IsRunning** | **532,943.125 ns** | **3,519.6882 ns** | **3,292.3185 ns** | **11.7188** | **0.9766** |     **-** |  **113889 B** |
|     **IsRunningFromAspNet** |       **1.233 ns** |     **0.0039 ns** |     **0.0035 ns** |       **-** |      **-** |     **-** |         **-** |
|    **ReferencedAssemblies** |  **78,172.499 ns** |   **262.4290 ns** |   **232.6365 ns** |  **3.4180** |      **-** |     **-** |   **32425 B** |
|              **StackTrace** |  **66,535.828 ns** |   **257.2996 ns** |   **240.6782 ns** |  **2.1973** |      **-** |     **-** |   **21094 B** |
|              **WorkingSet** |     **171.964 ns** |     **0.4733 ns** |     **0.3953 ns** |       **-** |      **-** |     **-** |         **-** |
