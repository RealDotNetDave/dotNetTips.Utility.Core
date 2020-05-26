``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.200
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  Job-KHIYCC : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctConcurrentBag,GenericCollections  

```
|                        Method | CollectionCount |        Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------ |---------------- |------------:|----------:|----------:|-------:|------:|------:|----------:|
| **&#39;Creating Using Constructor.&#39;** |              **25** |  **5,975.3 ns** |  **22.35 ns** |  **20.91 ns** | **0.0076** |     **-** |     **-** |    **2192 B** |
| &#39;Creating Using Constructor.&#39; |              50 | 11,920.0 ns |  99.94 ns |  93.49 ns | 0.0153 |     - |     - |    4408 B |
| &#39;Creating Using Constructor.&#39; |             100 | 22,259.9 ns |  66.53 ns |  58.98 ns | 0.0305 |     - |     - |    9064 B |
| &#39;Creating Using Constructor.&#39; |             250 | 55,340.4 ns | 222.99 ns | 186.21 ns | 0.0610 |     - |     - |   19288 B |
|   **&#39;Creating Using ForEach().&#39;** |              **25** |  **5,928.4 ns** |  **48.89 ns** |  **45.73 ns** |      **-** |     **-** |     **-** |    **1978 B** |
|   &#39;Creating Using ForEach().&#39; |              50 | 11,985.1 ns |  80.13 ns |  74.96 ns | 0.0153 |     - |     - |    3976 B |
|   &#39;Creating Using ForEach().&#39; |             100 | 22,335.0 ns | 128.10 ns | 113.56 ns | 0.0305 |     - |     - |    8232 B |
|   &#39;Creating Using ForEach().&#39; |             250 | 54,526.6 ns | 276.10 ns | 258.26 ns | 0.0610 |     - |     - |   17256 B |
|     **&#39;Looping with foreach().&#39;** |              **25** |    **288.4 ns** |   **0.88 ns** |   **0.82 ns** | **0.0277** |     **-** |     **-** |     **264 B** |
|     &#39;Looping with foreach().&#39; |              50 |    527.0 ns |   1.61 ns |   1.42 ns | 0.0486 |     - |     - |     464 B |
|     &#39;Looping with foreach().&#39; |             100 |    908.2 ns |   1.29 ns |   1.07 ns | 0.0916 |     - |     - |     864 B |
|     &#39;Looping with foreach().&#39; |             250 |  2,379.2 ns |   3.61 ns |   3.20 ns | 0.2174 |     - |     - |    2064 B |
