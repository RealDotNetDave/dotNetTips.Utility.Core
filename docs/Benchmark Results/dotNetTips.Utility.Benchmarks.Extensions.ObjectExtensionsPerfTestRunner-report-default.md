
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=ObjectExtensions  

            Method |        Mean |    Error |   StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
------------------ |------------:|---------:|---------:|-------:|-------:|------:|----------:|
             **Clone** |  **4,380.0 ns** | **16.11 ns** | **15.07 ns** | **0.8316** |      **-** |     **-** |    **7792 B** |
    **ComputeMD5Hash** |  **5,722.9 ns** | **12.33 ns** | **10.30 ns** | **0.4959** |      **-** |     **-** |    **4696 B** |
 **ComputeSha256Hash** |  **7,592.7 ns** | **11.35 ns** | **10.06 ns** | **0.5569** |      **-** |     **-** |    **5440 B** |
          **FromJson** | **11,642.6 ns** | **22.08 ns** | **19.57 ns** | **1.4343** | **0.0153** |     **-** |   **13480 B** |
       **HasProperty** |    **260.0 ns** |  **2.80 ns** |  **2.62 ns** | **0.0262** |      **-** |     **-** |     **248 B** |
            **ToJson** |  **3,348.7 ns** |  **6.72 ns** |  **5.96 ns** | **0.3433** |      **-** |     **-** |    **3240 B** |
