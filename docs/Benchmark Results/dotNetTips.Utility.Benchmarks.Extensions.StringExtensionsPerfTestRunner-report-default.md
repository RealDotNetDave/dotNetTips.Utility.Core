
BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=StringExtensions  

            Method |         Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
------------------ |-------------:|----------:|----------:|-------:|-------:|------:|----------:|
 **ComputeSha256Hash** | **6,125.108 ns** | **5.9780 ns** | **5.2994 ns** | **0.2823** |      **-** |     **-** |    **2760 B** |
            **Concat** |   **600.308 ns** | **2.9490 ns** | **2.6142 ns** | **0.6523** | **0.0048** |     **-** |    **6096 B** |
       **ContainsAny** |    **54.823 ns** | **0.1742 ns** | **0.1544 ns** | **0.0172** |      **-** |     **-** |     **160 B** |
          **HasValue** |     **6.715 ns** | **0.0664 ns** | **0.0621 ns** |      **-** |      **-** |     **-** |         **-** |
            **Indent** |   **439.382 ns** | **1.4687 ns** | **1.3739 ns** | **0.4368** | **0.0019** |     **-** |    **4088 B** |
   **ToTrimmedString** |   **218.482 ns** | **2.1108 ns** | **1.9745 ns** | **0.2108** | **0.0005** |     **-** |    **1960 B** |
