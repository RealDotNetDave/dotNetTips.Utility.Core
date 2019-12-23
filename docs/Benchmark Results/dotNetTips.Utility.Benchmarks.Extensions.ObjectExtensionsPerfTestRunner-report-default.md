
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  Job-QYQXQL : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=ObjectExtensions  

            Method |        Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------ |------------:|---------:|---------:|-------:|------:|------:|----------:|
             **Clone** |  **4,668.3 ns** | **13.77 ns** | **12.88 ns** | **0.8392** |     **-** |     **-** |    **7792 B** |
    **ComputeMD5Hash** |  **5,684.0 ns** | **15.82 ns** | **14.02 ns** | **0.4807** |     **-** |     **-** |    **4688 B** |
 **ComputeSha256Hash** |  **7,083.5 ns** |  **9.83 ns** |  **9.19 ns** | **0.5493** |     **-** |     **-** |    **5360 B** |
          **FromJson** | **11,483.7 ns** | **30.56 ns** | **28.59 ns** | **1.4038** |     **-** |     **-** |   **13160 B** |
       **HasProperty** |    **259.7 ns** |  **0.57 ns** |  **0.54 ns** | **0.0262** |     **-** |     **-** |     **248 B** |
            **ToJson** |  **3,288.6 ns** |  **8.28 ns** |  **7.74 ns** | **0.3471** |     **-** |     **-** |    **3240 B** |
