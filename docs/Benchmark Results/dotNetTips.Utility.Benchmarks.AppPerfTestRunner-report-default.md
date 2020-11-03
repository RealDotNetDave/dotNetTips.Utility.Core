
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=App  

                  Method |           Mean |         Error |         StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
------------------------ |---------------:|--------------:|---------------:|--------:|-------:|------:|----------:|
 **GetEnvironmentVariables** |  **20,366.240 ns** |   **105.5947 ns** |     **93.6070 ns** |  **1.3733** |      **-** |     **-** |   **13160 B** |
        **IsProcessRunning** | **282,692.178 ns** | **5,587.5769 ns** | **12,146.9324 ns** | **11.2305** | **0.9766** |     **-** |  **107649 B** |
               **IsRunning** | **523,427.708 ns** | **2,857.5637 ns** |  **2,672.9668 ns** | **11.7188** | **0.9766** |     **-** |  **111945 B** |
     **IsRunningFromAspNet** |       **1.282 ns** |     **0.0358 ns** |      **0.0335 ns** |       **-** |      **-** |     **-** |         **-** |
    **ReferencedAssemblies** |  **79,533.802 ns** |   **106.1595 ns** |     **94.1076 ns** |  **3.4180** |      **-** |     **-** |   **32424 B** |
              **StackTrace** |  **70,646.756 ns** |   **568.1312 ns** |    **503.6335 ns** |  **2.1973** |      **-** |     **-** |   **21095 B** |
              **WorkingSet** |     **173.784 ns** |     **0.3632 ns** |      **0.3220 ns** |       **-** |      **-** |     **-** |         **-** |
