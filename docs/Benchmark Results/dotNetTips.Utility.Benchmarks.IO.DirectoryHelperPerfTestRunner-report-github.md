``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  Job-QYQXQL : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DirectoryHelper  

```
|              Method |        Mean |    Error |   StdDev |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |------------:|---------:|---------:|---------:|------:|------:|----------:|
|           **LoadFiles** | **30,120.0 us** | **53.44 us** | **44.62 us** |  **31.2500** |     **-** |     **-** | **1349350 B** |
|      **LoadFilesAsync** | **19,186.1 us** | **61.87 us** | **57.87 us** | **125.0000** |     **-** |     **-** | **1188312 B** |
| **SafeDirectorySearch** |    **311.0 us** |  **0.78 us** |  **0.65 us** |        **-** |     **-** |     **-** |     **760 B** |
