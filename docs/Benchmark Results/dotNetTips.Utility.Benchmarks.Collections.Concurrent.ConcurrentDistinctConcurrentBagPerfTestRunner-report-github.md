``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-preview.8.20417.9
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-RATGHQ : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctConcurrentBag,GenericCollections  

```
|                        Method | CollectionCount |         Mean |       Error |      StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------ |---------------- |-------------:|------------:|------------:|-------:|------:|------:|----------:|
| **&#39;Creating Using Constructor.&#39;** |              **25** |   **6,007.9 ns** |   **114.62 ns** |   **117.71 ns** | **0.0076** |     **-** |     **-** |    **2192 B** |
| &#39;Creating Using Constructor.&#39; |              50 |  12,001.1 ns |   174.67 ns |   163.39 ns | 0.0153 |     - |     - |    4408 B |
| &#39;Creating Using Constructor.&#39; |             100 |  22,029.2 ns |    80.97 ns |    75.74 ns | 0.0305 |     - |     - |    9056 B |
| &#39;Creating Using Constructor.&#39; |             250 |  54,963.6 ns |   404.29 ns |   358.40 ns | 0.0610 |     - |     - |   19288 B |
| &#39;Creating Using Constructor.&#39; |             500 | 112,970.7 ns |   666.82 ns |   623.74 ns | 0.1221 |     - |     - |   40169 B |
| &#39;Creating Using Constructor.&#39; |            1000 | 225,368.7 ns | 1,648.33 ns | 1,541.85 ns | 0.2441 |     - |     - |   83338 B |
|   **&#39;Creating Using ForEach().&#39;** |              **25** |   **5,820.6 ns** |   **112.26 ns** |   **137.87 ns** | **0.0076** |     **-** |     **-** |    **1960 B** |
|   &#39;Creating Using ForEach().&#39; |              50 |  11,419.4 ns |    67.44 ns |    59.79 ns | 0.0153 |     - |     - |    3976 B |
|   &#39;Creating Using ForEach().&#39; |             100 |  22,422.3 ns |    78.87 ns |    69.91 ns | 0.0305 |     - |     - |    8232 B |
|   &#39;Creating Using ForEach().&#39; |             250 |  54,519.1 ns |   153.97 ns |   144.03 ns | 0.0610 |     - |     - |   17256 B |
|   &#39;Creating Using ForEach().&#39; |             500 | 113,528.4 ns |   922.13 ns |   817.44 ns | 0.1221 |     - |     - |   36136 B |
|   &#39;Creating Using ForEach().&#39; |            1000 | 219,087.8 ns | 1,211.61 ns | 1,133.34 ns | 0.2441 |     - |     - |   75304 B |
|     **&#39;Looping with foreach().&#39;** |              **25** |     **295.3 ns** |     **5.79 ns** |     **5.42 ns** | **0.0277** |     **-** |     **-** |     **264 B** |
|     &#39;Looping with foreach().&#39; |              50 |     502.4 ns |     1.60 ns |     1.49 ns | 0.0486 |     - |     - |     464 B |
|     &#39;Looping with foreach().&#39; |             100 |     974.0 ns |     1.89 ns |     1.68 ns | 0.0916 |     - |     - |     864 B |
|     &#39;Looping with foreach().&#39; |             250 |   2,263.4 ns |     6.80 ns |     5.68 ns | 0.2174 |     - |     - |    2064 B |
|     &#39;Looping with foreach().&#39; |             500 |   4,381.8 ns |     4.59 ns |     3.58 ns | 0.4272 |     - |     - |    4064 B |
|     &#39;Looping with foreach().&#39; |            1000 |   8,952.9 ns |     9.55 ns |     7.97 ns | 0.8545 |     - |     - |    8056 B |
