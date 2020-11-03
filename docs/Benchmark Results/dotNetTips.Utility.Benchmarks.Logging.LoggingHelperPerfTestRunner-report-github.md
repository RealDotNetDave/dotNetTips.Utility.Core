``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=LoggingHelper  

```
|                       Method |     Mean |   Error |  StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------- |---------:|--------:|--------:|-------:|------:|------:|----------:|
| **RetrieveAllExceptionMessages** | **646.9 ns** | **6.65 ns** | **5.19 ns** | **0.0868** |     **-** |     **-** |     **824 B** |
|        **RetrieveAllExceptions** | **298.3 ns** | **3.55 ns** | **3.32 ns** | **0.0558** |     **-** |     **-** |     **528 B** |
