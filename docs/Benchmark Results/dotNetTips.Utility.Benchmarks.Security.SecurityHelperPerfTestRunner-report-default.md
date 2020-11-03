
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=SecurityHelper,String,Security  

                   Method |         Mean |     Error |    StdDev |  Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------- |-------------:|----------:|----------:|-------:|--------:|-------:|------:|------:|----------:|
     **CompareSecureStrings** | **138,186.5 ns** | **306.98 ns** | **256.34 ns** | **289.86** |    **4.17** |      **-** |     **-** |     **-** |     **656 B** |
         **LoadSecureString** |  **65,829.1 ns** | **237.97 ns** | **222.60 ns** | **137.76** |    **2.08** |      **-** |     **-** |     **-** |     **256 B** |
 **'Read String Characters'** |     **478.0 ns** |   **7.77 ns** |   **7.27 ns** |   **1.00** |    **0.00** | **0.1717** |     **-** |     **-** |    **1632 B** |
         **ReadSecureString** |  **70,652.3 ns** | **400.67 ns** | **355.18 ns** | **148.01** |    **2.17** |      **-** |     **-** |     **-** |     **328 B** |
