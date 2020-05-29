``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.300
  [Host]     : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT
  Job-LAEGID : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=Services  

```
|        Method |     Mean |     Error |    StdDev |   Median |  Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|-------------- |---------:|----------:|----------:|---------:|-------:|-------:|-------:|----------:|
|   **AllServices** | **1.482 ms** | **0.0577 ms** | **0.1673 ms** | **1.439 ms** | **9.7656** | **3.9063** | **1.9531** | **104.34 KB** |
| **ServiceExists** | **1.493 ms** | **0.0613 ms** | **0.1738 ms** | **1.441 ms** | **9.7656** | **3.9063** |      **-** | **104.41 KB** |
| **ServiceStatus** | **1.495 ms** | **0.0600 ms** | **0.1683 ms** | **1.454 ms** | **9.7656** | **3.9063** |      **-** | **104.41 KB** |
