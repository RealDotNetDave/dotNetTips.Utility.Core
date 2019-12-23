``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  Job-QYQXQL : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DriveHelper  

```
|              Method |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|---------:|---------:|-------:|------:|------:|----------:|
|      **GetFixedDrives** | **13.27 us** | **0.051 us** | **0.048 us** | **0.0610** |     **-** |     **-** |     **608 B** |
| **GetRemoveableDrives** | **12.96 us** | **0.038 us** | **0.034 us** | **0.0458** |     **-** |     **-** |     **528 B** |
