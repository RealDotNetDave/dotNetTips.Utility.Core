
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=DirectoryHelper  

              Method |         Mean |       Error |      StdDev |    Gen 0 | Gen 1 | Gen 2 | Allocated |
-------------------- |-------------:|------------:|------------:|---------:|------:|------:|----------:|
           **LoadFiles** | **228,264.0 μs** | **1,553.20 μs** | **1,452.86 μs** |        **-** |     **-** |     **-** | **4160376 B** |
      **LoadFilesAsync** | **114,063.0 μs** |   **443.55 μs** |   **414.89 μs** | **200.0000** |     **-** |     **-** | **3642381 B** |
 **SafeDirectorySearch** |     **893.3 μs** |     **3.63 μs** |     **3.39 μs** |        **-** |     **-** |     **-** |     **774 B** |
      **SafeFileSearch** |  **43,775.0 μs** |   **145.98 μs** |   **129.41 μs** |  **83.3333** |     **-** |     **-** | **1569855 B** |
