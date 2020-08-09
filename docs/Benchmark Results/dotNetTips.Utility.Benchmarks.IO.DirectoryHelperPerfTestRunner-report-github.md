``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DirectoryHelper  

```
|              Method |          Mean |      Error |     StdDev |    Gen 0 | Gen 1 | Gen 2 |  Allocated |
|-------------------- |--------------:|-----------:|-----------:|---------:|------:|------:|-----------:|
|           **LoadFiles** |     **270.28 ms** |   **2.953 ms** |   **2.762 ms** |        **-** |     **-** |     **-** |  **4493000 B** |
|      **LoadFilesAsync** |     **145.18 ms** |   **1.040 ms** |   **1.021 ms** | **250.0000** |     **-** |     **-** |  **3983804 B** |
| **SafeDirectorySearch** |      **29.78 ms** |   **0.117 ms** |   **0.098 ms** |        **-** |     **-** |     **-** |      **760 B** |
|      **SafeFileSearch** | **122,978.66 ms** | **545.734 ms** | **455.712 ms** |        **-** |     **-** |     **-** | **49825232 B** |
