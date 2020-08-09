``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DriveHelper  

```
|             Method |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |---------:|---------:|---------:|-------:|------:|------:|----------:|
|     **GetFixedDrives** | **20.20 μs** | **0.091 μs** | **0.076 μs** | **0.0610** |     **-** |     **-** |     **608 B** |
| **GetRemovableDrives** | **19.49 μs** | **0.113 μs** | **0.100 μs** | **0.0305** |     **-** |     **-** |     **528 B** |
