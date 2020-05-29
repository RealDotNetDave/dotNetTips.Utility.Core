``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.300
  [Host]     : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT
  Job-LAEGID : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=EnumExtensions  

```
|         Method |       Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------- |-----------:|----------:|----------:|-------:|------:|------:|----------:|
| **GetDescription** |   **455.4 ns** |   **9.07 ns** |  **23.09 ns** | **0.0024** |     **-** |     **-** |      **24 B** |
|       **GetItems** | **6,162.3 ns** | **122.46 ns** | **255.61 ns** | **0.0916** |     **-** |     **-** |     **872 B** |
