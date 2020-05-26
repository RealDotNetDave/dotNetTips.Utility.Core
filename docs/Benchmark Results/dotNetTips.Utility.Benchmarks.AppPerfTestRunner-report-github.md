``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.200
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  Job-KHIYCC : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=App  

```
|                  Method |           Mean |         Error |        StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------------ |---------------:|--------------:|--------------:|--------:|-------:|------:|----------:|
| **GetEnvironmentVariables** |  **23,506.566 ns** |    **48.1175 ns** |    **40.1803 ns** |  **1.5259** | **0.0305** |     **-** |   **14504 B** |
|        **IsProcessRunning** | **370,173.398 ns** | **1,564.2891 ns** | **1,463.2370 ns** | **13.1836** | **1.4648** |     **-** |  **128800 B** |
|               **IsRunning** | **729,797.598 ns** | **1,734.3867 ns** | **1,622.3464 ns** | **15.6250** | **1.9531** |     **-** |  **149472 B** |
|     **IsRunningFromAspNet** |       **1.299 ns** |     **0.0412 ns** |     **0.0385 ns** |       **-** |      **-** |     **-** |         **-** |
|    **ReferencedAssemblies** | **105,343.074 ns** | **1,378.1771 ns** | **1,221.7181 ns** |  **4.3945** |      **-** |     **-** |   **42544 B** |
|              **StackTrace** |  **67,755.902 ns** |   **135.4476 ns** |   **120.0708 ns** |  **2.1973** |      **-** |     **-** |   **21071 B** |
|              **WorkingSet** |     **185.872 ns** |     **0.3724 ns** |     **0.3301 ns** |       **-** |      **-** |     **-** |         **-** |
