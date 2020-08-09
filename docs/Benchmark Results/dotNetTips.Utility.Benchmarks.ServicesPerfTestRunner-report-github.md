``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=Services  

```
|        Method |     Mean |   Error |  StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|-------------- |---------:|--------:|--------:|--------:|-------:|------:|----------:|
|   **AllServices** | **978.8 μs** | **5.55 μs** | **4.92 μs** |  **9.7656** | **3.9063** |     **-** | **105.06 KB** |
| **ServiceExists** | **977.2 μs** | **5.86 μs** | **5.19 μs** |  **9.7656** | **4.8828** |     **-** | **105.13 KB** |
| **ServiceStatus** | **970.7 μs** | **3.92 μs** | **3.47 μs** | **10.7422** | **4.8828** |     **-** | **105.13 KB** |
