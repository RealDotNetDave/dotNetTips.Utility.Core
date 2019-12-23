``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  Job-QYQXQL : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=LoggingHelper  

```
|                       Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
| **RetrieveAllExceptionMessages** | **2.810 us** | **0.0029 us** | **0.0026 us** | **0.1259** |     **-** |     **-** |    **1216 B** |
|        **RetrieveAllExceptions** | **1.672 us** | **0.0046 us** | **0.0043 us** | **0.0896** |     **-** |     **-** |     **848 B** |
