``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FileProcessor  

```
|        Method |     Mean |    Error |   StdDev |   Gen 0 | Gen 1 | Gen 2 |  Allocated |
|-------------- |---------:|---------:|---------:|--------:|------:|------:|-----------:|
|     **CopyFiles** | **64.29 ms** | **1.274 ms** | **2.093 ms** |       **-** |     **-** |     **-** |  **141.99 KB** |
|   **DeleteFiles** | **43.37 ms** | **0.678 ms** | **1.075 ms** | **90.9091** |     **-** |     **-** | **1025.45 KB** |
| **DeleteFolders** | **44.51 ms** | **0.879 ms** | **0.977 ms** |       **-** |     **-** |     **-** |  **111.32 KB** |
