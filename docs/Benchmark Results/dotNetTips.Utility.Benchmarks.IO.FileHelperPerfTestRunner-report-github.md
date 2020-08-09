``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FileHelper  

```
|              Method |            Mean |           Error |          StdDev |          Median |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |----------------:|----------------:|----------------:|----------------:|--------:|------:|------:|----------:|
|            **CopyFile** |    **935,639.4 ns** |     **9,979.31 ns** |     **8,846.40 ns** |    **934,390.7 ns** |  **3.9063** |     **-** |     **-** |   **38648 B** |
|       **CopyFileAsync** |  **1,025,763.1 ns** |    **14,164.49 ns** |    **12,556.45 ns** |  **1,023,125.0 ns** |  **3.9063** |     **-** |     **-** |   **39937 B** |
|         **DeleteFiles** | **42,186,964.3 ns** | **1,070,861.55 ns** | **3,072,502.52 ns** | **41,148,425.0 ns** | **83.3333** |     **-** |     **-** | **1016975 B** |
| **FileHasInvalidChars** |        **616.0 ns** |         **3.60 ns** |         **3.19 ns** |        **616.2 ns** |  **0.0277** |     **-** |     **-** |     **264 B** |
|            **MoveFile** |    **969,095.5 ns** |    **18,857.13 ns** |    **20,959.65 ns** |    **967,063.0 ns** |       **-** |     **-** |     **-** |   **14504 B** |
