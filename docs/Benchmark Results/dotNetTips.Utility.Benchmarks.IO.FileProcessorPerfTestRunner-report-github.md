``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=FileProcessor  

```
|        Method |     Mean |    Error |   StdDev |   Gen 0 | Gen 1 | Gen 2 |  Allocated |
|-------------- |---------:|---------:|---------:|--------:|------:|------:|-----------:|
|     **CopyFiles** | **63.68 ms** | **1.251 ms** | **2.380 ms** |       **-** |     **-** |     **-** |  **141.98 KB** |
|   **DeleteFiles** | **41.93 ms** | **0.820 ms** | **1.415 ms** | **90.9091** |     **-** |     **-** | **1025.45 KB** |
| **DeleteFolders** | **42.53 ms** | **0.495 ms** | **0.386 ms** |       **-** |     **-** |     **-** |  **111.31 KB** |
