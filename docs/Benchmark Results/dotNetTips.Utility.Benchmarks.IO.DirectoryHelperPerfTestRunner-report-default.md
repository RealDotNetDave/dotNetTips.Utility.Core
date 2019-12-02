
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DirectoryHelper  

              Method |        Mean |    Error |   StdDev |    Gen 0 |   Gen 1 | Gen 2 | Allocated |
-------------------- |------------:|---------:|---------:|---------:|--------:|------:|----------:|
           **LoadFiles** | **30,379.6 us** | **49.59 us** | **46.38 us** |  **62.5000** | **31.2500** |     **-** | **1349626 B** |
      **LoadFilesAsync** | **19,096.7 us** | **44.28 us** | **41.42 us** | **125.0000** |       **-** |     **-** | **1188552 B** |
 **SafeDirectorySearch** |    **377.4 us** |  **1.19 us** |  **1.11 us** |        **-** |       **-** |     **-** |     **760 B** |
