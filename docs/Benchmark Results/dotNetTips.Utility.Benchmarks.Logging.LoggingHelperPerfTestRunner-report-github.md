``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=LoggingHelper  

```
|                       Method |     Mean |   Error |  StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------- |---------:|--------:|--------:|-------:|------:|------:|----------:|
| **RetrieveAllExceptionMessages** | **633.5 ns** | **3.35 ns** | **2.97 ns** | **0.0877** |     **-** |     **-** |     **824 B** |
|        **RetrieveAllExceptions** | **291.2 ns** | **0.66 ns** | **0.58 ns** | **0.0563** |     **-** |     **-** |     **528 B** |
