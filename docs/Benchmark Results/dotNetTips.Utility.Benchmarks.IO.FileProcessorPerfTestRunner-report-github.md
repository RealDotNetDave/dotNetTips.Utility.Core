``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  Job-QYQXQL : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FileProcessor  

```
|        Method |      Mean |     Error |    StdDev |    Median |     Gen 0 | Gen 1 | Gen 2 |   Allocated |
|-------------- |----------:|----------:|----------:|----------:|----------:|------:|------:|------------:|
|     **CopyFiles** | **555.61 ms** | **17.343 ms** | **51.137 ms** | **537.42 ms** |         **-** |     **-** |     **-** |  **1415.13 KB** |
|   **DeleteFiles** | **473.09 ms** | **19.407 ms** | **56.916 ms** | **459.01 ms** | **1000.0000** |     **-** |     **-** | **11813.41 KB** |
| **DeleteFolders** |  **30.19 ms** |  **0.952 ms** |  **2.807 ms** |  **28.62 ms** |         **-** |     **-** |     **-** |    **111.3 KB** |
