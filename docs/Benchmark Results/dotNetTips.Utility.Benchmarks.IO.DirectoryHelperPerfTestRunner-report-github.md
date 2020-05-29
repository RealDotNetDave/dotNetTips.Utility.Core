``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.300
  [Host]     : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT
  Job-LAEGID : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DirectoryHelper  

```
|              Method |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 |  Allocated |
|-------------------- |---------:|---------:|---------:|------:|------:|------:|-----------:|
|           **LoadFiles** | **94.99 ms** | **1.876 ms** | **2.505 ms** |     **-** |     **-** |     **-** |  **1367785 B** |
|      **LoadFilesAsync** | **80.41 ms** | **1.532 ms** | **1.703 ms** |     **-** |     **-** |     **-** |  **1220913 B** |
| **SafeDirectorySearch** | **12.71 ms** | **0.248 ms** | **0.323 ms** |     **-** |     **-** |     **-** |      **760 B** |
|      **SafeFileSearch** | **59.57 ms** | **1.188 ms** | **2.453 ms** |     **-** |     **-** |     **-** | **12790703 B** |
