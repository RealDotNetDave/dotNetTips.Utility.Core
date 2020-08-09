``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=EnumExtensions  

```
|         Method |       Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------- |-----------:|---------:|---------:|-------:|------:|------:|----------:|
| **GetDescription** |   **317.5 ns** |  **1.90 ns** |  **1.68 ns** | **0.0024** |     **-** |     **-** |      **24 B** |
|       **GetItems** | **4,281.8 ns** | **36.18 ns** | **30.21 ns** | **0.0916** |     **-** |     **-** |     **872 B** |
