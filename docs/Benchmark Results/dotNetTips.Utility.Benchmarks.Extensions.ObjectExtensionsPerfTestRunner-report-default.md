
BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=ObjectExtensions  

            Method |        Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
------------------ |------------:|----------:|----------:|-------:|-------:|------:|----------:|
             **Clone** |  **4,298.9 ns** |  **18.45 ns** |  **17.26 ns** | **0.8469** |      **-** |     **-** |    **7792 B** |
    **ComputeMD5Hash** |  **5,385.4 ns** |  **46.48 ns** |  **41.20 ns** | **0.4730** |      **-** |     **-** |    **4688 B** |
 **ComputeSha256Hash** |  **8,351.0 ns** | **204.71 ns** | **603.60 ns** | **0.5722** |      **-** |     **-** |    **5480 B** |
          **FromJson** | **11,363.0 ns** |  **16.59 ns** |  **15.51 ns** | **1.4191** | **0.0153** |     **-** |   **13328 B** |
       **HasProperty** |    **267.5 ns** |   **0.43 ns** |   **0.40 ns** | **0.0267** |      **-** |     **-** |     **248 B** |
            **ToJson** |  **3,402.1 ns** |   **6.55 ns** |   **5.81 ns** | **0.3471** |      **-** |     **-** |    **3232 B** |
