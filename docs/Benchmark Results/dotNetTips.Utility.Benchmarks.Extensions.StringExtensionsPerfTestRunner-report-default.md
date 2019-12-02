
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=StringExtensions  

            Method |         Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
------------------ |-------------:|----------:|----------:|-------:|-------:|------:|----------:|
 **ComputeSha256Hash** | **6,117.450 ns** | **9.4944 ns** | **7.9283 ns** | **0.2899** |      **-** |     **-** |    **2760 B** |
            **Concat** |   **574.711 ns** | **4.4002 ns** | **4.1160 ns** | **0.6418** | **0.0048** |     **-** |    **6064 B** |
       **ContainsAny** |    **65.489 ns** | **0.3795 ns** | **0.3550 ns** | **0.0170** |      **-** |     **-** |     **160 B** |
          **HasValue** |     **6.278 ns** | **0.0411 ns** | **0.0365 ns** |      **-** |      **-** |     **-** |         **-** |
            **Indent** |   **442.707 ns** | **0.8873 ns** | **0.8299 ns** | **0.4330** | **0.0024** |     **-** |    **4088 B** |
   **ToTrimmedString** |   **216.676 ns** | **2.2588 ns** | **2.1129 ns** | **0.2069** | **0.0005** |     **-** |    **1960 B** |
