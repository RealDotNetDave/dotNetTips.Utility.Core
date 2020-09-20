``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-preview.8.20417.9
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-RATGHQ : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=TypeHelper  

```
|                      Method |              Mean |           Error |          StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |------------------:|----------------:|----------------:|-------:|------:|------:|----------:|
|                      **Create** |        **41.8332 ns** |       **0.2125 ns** |       **0.1884 ns** | **0.0126** |     **-** |     **-** |     **120 B** |
|     **DoesObjectEqualInstance** |    **13,174.9808 ns** |     **253.7991 ns** |     **282.0970 ns** | **0.5646** |     **-** |     **-** |    **5446 B** |
|            **FindDerivedTypes** | **3,771,381.0526 ns** | **111,915.5530 ns** | **321,106.7007 ns** |      **-** |     **-** |     **-** |  **181920 B** |
|                  **GetDefault** |         **0.0357 ns** |       **0.0249 ns** |       **0.0195 ns** |      **-** |     **-** |     **-** |         **-** |
|         **GetInstanceHashCode** |     **2,287.8879 ns** |      **24.2726 ns** |      **21.5170 ns** | **0.0458** |     **-** |     **-** |     **432 B** |
|     **GetTypeDisplayName:Type** |       **191.9798 ns** |       **0.4984 ns** |       **0.4162 ns** | **0.0412** |     **-** |     **-** |     **392 B** |
| **GetTypeDisplayName:Variable** |       **145.3857 ns** |       **1.4702 ns** |       **1.2277 ns** | **0.0412** |     **-** |     **-** |     **392 B** |
