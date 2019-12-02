
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FileHelper  

        Method |        Mean |     Error |      StdDev |      Median |   Gen 0 | Gen 1 | Gen 2 | Allocated |
-------------- |------------:|----------:|------------:|------------:|--------:|------:|------:|----------:|
      **CopyFile** |    **907.5 us** |  **17.95 us** |    **34.58 us** |    **890.0 us** |  **2.9297** |     **-** |     **-** |  **37.74 KB** |
 **CopyFileAsync** |    **958.7 us** |  **10.74 us** |     **9.52 us** |    **956.9 us** |  **3.9063** |     **-** |     **-** |     **39 KB** |
   **DeleteFiles** | **39,174.9 us** | **841.49 us** | **2,231.52 us** | **38,924.3 us** | **76.9231** |     **-** |     **-** | **989.84 KB** |
      **MoveFile** |    **956.1 us** |  **19.08 us** |    **18.74 us** |    **951.9 us** |       **-** |     **-** |     **-** |   **14.2 KB** |
