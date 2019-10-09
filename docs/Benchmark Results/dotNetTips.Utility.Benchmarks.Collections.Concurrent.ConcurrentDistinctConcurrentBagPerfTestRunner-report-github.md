``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctConcurrentBag,GenericCollections  

```
|                        Method | CollectionCount |        Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------ |---------------- |------------:|----------:|----------:|-------:|------:|------:|----------:|
| **&#39;Creating Using Constructor.&#39;** |              **25** |  **6,830.2 ns** |  **95.76 ns** |  **84.89 ns** | **0.0076** |     **-** |     **-** |    **1912 B** |
| &#39;Creating Using Constructor.&#39; |              50 | 12,295.1 ns | 133.26 ns | 118.13 ns | 0.0153 |     - |     - |    3928 B |
| &#39;Creating Using Constructor.&#39; |             100 | 24,186.3 ns |  88.38 ns |  78.34 ns | 0.0305 |     - |     - |    8184 B |
| &#39;Creating Using Constructor.&#39; |             250 | 57,051.4 ns | 473.71 ns | 443.11 ns | 0.0610 |     - |     - |   17208 B |
|   **&#39;Creating Using ForEach().&#39;** |              **25** |  **6,061.0 ns** | **119.87 ns** | **275.41 ns** |      **-** |     **-** |     **-** |    **1960 B** |
|   &#39;Creating Using ForEach().&#39; |              50 | 12,131.1 ns | 137.26 ns | 128.40 ns |      - |     - |     - |    3994 B |
|   &#39;Creating Using ForEach().&#39; |             100 | 23,331.5 ns | 184.36 ns | 153.95 ns | 0.0305 |     - |     - |    8232 B |
|   &#39;Creating Using ForEach().&#39; |             250 | 56,447.7 ns | 157.90 ns | 139.98 ns | 0.0610 |     - |     - |   17256 B |
|     **&#39;Looping with foreach().&#39;** |              **25** |    **313.5 ns** |   **0.67 ns** |   **0.63 ns** | **0.0281** |     **-** |     **-** |     **264 B** |
|     &#39;Looping with foreach().&#39; |              50 |    506.6 ns |   1.29 ns |   1.21 ns | 0.0496 |     - |     - |     464 B |
|     &#39;Looping with foreach().&#39; |             100 |    937.9 ns |  11.67 ns |  10.92 ns | 0.0925 |     - |     - |     864 B |
|     &#39;Looping with foreach().&#39; |             250 |  2,369.7 ns |   4.33 ns |   4.05 ns | 0.2213 |     - |     - |    2064 B |
