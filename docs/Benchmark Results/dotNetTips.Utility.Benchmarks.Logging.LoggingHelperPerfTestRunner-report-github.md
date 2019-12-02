``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=LoggingHelper  

```
|                       Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
| **RetrieveAllExceptionMessages** | **2.843 us** | **0.0031 us** | **0.0027 us** | **0.1259** |     **-** |     **-** |    **1216 B** |
|        **RetrieveAllExceptions** | **1.665 us** | **0.0036 us** | **0.0033 us** | **0.0896** |     **-** |     **-** |     **848 B** |
