``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.200
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  Job-KHIYCC : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=TypeHelper  

```
|                  Method |              Mean |          Error |          StdDev |            Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |------------------:|---------------:|----------------:|------------------:|-------:|------:|------:|----------:|
|                  **Create** |        **42.5959 ns** |      **0.6707 ns** |       **0.5946 ns** |        **42.8516 ns** | **0.0127** |     **-** |     **-** |     **120 B** |
| **DoesObjectEqualInstance** |    **12,466.9006 ns** |     **29.4715 ns** |      **27.5676 ns** |    **12,461.4105 ns** | **0.5798** |     **-** |     **-** |    **5446 B** |
|        **FindDerivedTypes** | **2,103,529.3478 ns** | **65,282.8448 ns** | **184,131.4220 ns** | **2,010,600.0000 ns** |      **-** |     **-** |     **-** |  **152024 B** |
|              **GetDefault** |         **0.0010 ns** |      **0.0020 ns** |       **0.0018 ns** |         **0.0002 ns** |      **-** |     **-** |     **-** |         **-** |
|     **GetInstanceHashCode** |     **2,134.0024 ns** |     **42.2568 ns** |      **41.5018 ns** |     **2,113.0064 ns** | **0.0458** |     **-** |     **-** |     **432 B** |
