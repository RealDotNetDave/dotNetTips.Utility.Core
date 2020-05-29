``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.300
  [Host]     : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT
  Job-LAEGID : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DriveHelper  

```
|             Method |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |---------:|---------:|---------:|-------:|------:|------:|----------:|
|     **GetFixedDrives** | **30.05 μs** | **0.598 μs** | **1.636 μs** | **0.0610** |     **-** |     **-** |     **608 B** |
| **GetRemovableDrives** | **29.79 μs** | **0.588 μs** | **0.700 μs** | **0.0305** |     **-** |     **-** |     **528 B** |
