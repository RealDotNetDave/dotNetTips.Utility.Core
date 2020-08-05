``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.302
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GMGNJH : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=Services  

```
|        Method |     Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|-------------- |---------:|----------:|----------:|-------:|-------:|------:|----------:|
|   **AllServices** | **1.265 ms** | **0.0243 ms** | **0.0610 ms** | **9.7656** | **3.9063** |     **-** | **105.06 KB** |
| **ServiceExists** | **1.293 ms** | **0.0257 ms** | **0.0620 ms** | **9.7656** | **3.9063** |     **-** | **105.13 KB** |
| **ServiceStatus** | **1.269 ms** | **0.0250 ms** | **0.0450 ms** | **9.7656** | **3.9063** |     **-** | **105.13 KB** |
