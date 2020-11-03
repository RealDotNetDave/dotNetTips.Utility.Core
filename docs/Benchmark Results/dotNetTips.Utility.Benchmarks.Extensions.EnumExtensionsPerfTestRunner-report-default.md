
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=EnumExtensions  

         Method |       Mean |   Error |  StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------- |-----------:|--------:|--------:|-------:|------:|------:|----------:|
 **GetDescription** |   **315.1 ns** | **0.66 ns** | **0.55 ns** | **0.0024** |     **-** |     **-** |      **24 B** |
       **GetItems** | **4,306.9 ns** | **6.88 ns** | **6.10 ns** | **0.0916** |     **-** |     **-** |     **872 B** |
