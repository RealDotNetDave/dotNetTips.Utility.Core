
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  Job-QYQXQL : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FileHelper  

        Method |        Mean |     Error |      StdDev |   Gen 0 | Gen 1 | Gen 2 | Allocated |
-------------- |------------:|----------:|------------:|--------:|------:|------:|----------:|
      **CopyFile** |    **899.3 us** |  **16.84 us** |    **14.93 us** |  **2.9297** |     **-** |     **-** |  **37.74 KB** |
 **CopyFileAsync** |    **961.5 us** |  **12.15 us** |    **10.14 us** |  **3.9063** |     **-** |     **-** |     **39 KB** |
   **DeleteFiles** | **39,198.7 us** | **776.68 us** | **1,138.45 us** | **83.3333** |     **-** |     **-** | **985.82 KB** |
      **MoveFile** |  **1,069.0 us** |  **20.42 us** |    **53.43 us** |  **0.9766** |     **-** |     **-** |  **14.16 KB** |
