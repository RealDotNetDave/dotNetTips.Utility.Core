``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctBlockingCollection,GenericCollections  

```
|                             Method | CollectionCount |          Mean |      Error |     StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------- |---------------- |--------------:|-----------:|-----------:|-------:|------:|------:|----------:|
|      **&#39;Creating Using Constructor.&#39;** |              **25** |   **2,804.82 ns** |   **6.510 ns** |   **5.771 ns** | **0.1526** |     **-** |     **-** |    **1440 B** |
|      &#39;Creating Using Constructor.&#39; |              50 |   5,204.02 ns |  21.462 ns |  19.026 ns | 0.1678 |     - |     - |    1640 B |
|      &#39;Creating Using Constructor.&#39; |             100 |  10,519.75 ns |  51.642 ns |  45.779 ns | 0.2136 |     - |     - |    2040 B |
|      &#39;Creating Using Constructor.&#39; |             250 |  27,660.60 ns |  95.304 ns |  84.485 ns | 0.3357 |     - |     - |    3240 B |
|      &#39;Creating Using Constructor.&#39; |             500 |  51,171.42 ns | 153.605 ns | 128.267 ns | 0.5493 |     - |     - |    5240 B |
|      &#39;Creating Using Constructor.&#39; |            1000 | 114,139.75 ns | 795.627 ns | 705.303 ns | 0.9766 |     - |     - |    9240 B |
|            **&#39;Creating Using for().&#39;** |              **25** |   **2,744.33 ns** |  **11.655 ns** |   **9.733 ns** | **0.1297** |     **-** |     **-** |    **1208 B** |
|            &#39;Creating Using for().&#39; |              50 |   5,111.04 ns |  45.557 ns |  40.385 ns | 0.1297 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             100 |  12,247.52 ns | 187.761 ns | 175.632 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             250 |  27,081.20 ns |  44.386 ns |  39.347 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             500 |  52,317.18 ns |  92.204 ns |  81.736 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |            1000 | 102,608.09 ns | 266.567 ns | 236.304 ns | 0.1221 |     - |     - |    1208 B |
|          **&#39;Looping with foreach().&#39;** |              **25** |      **41.80 ns** |   **0.279 ns** |   **0.261 ns** | **0.0085** |     **-** |     **-** |      **80 B** |
|          &#39;Looping with foreach().&#39; |              50 |      42.10 ns |   0.857 ns |   0.917 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             100 |      45.62 ns |   0.390 ns |   0.326 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             250 |      42.97 ns |   0.224 ns |   0.198 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             500 |      41.86 ns |   0.235 ns |   0.288 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |            1000 |      41.65 ns |   0.242 ns |   0.214 ns | 0.0085 |     - |     - |      80 B |
| **&#39;Looping with Parallel.ForEach().&#39;** |              **25** |   **2,263.66 ns** |   **8.620 ns** |   **8.063 ns** | **0.6828** |     **-** |     **-** |    **5171 B** |
| &#39;Looping with Parallel.ForEach().&#39; |              50 |   2,459.37 ns |  30.746 ns |  28.760 ns | 0.6790 |     - |     - |    5177 B |
| &#39;Looping with Parallel.ForEach().&#39; |             100 |   2,253.22 ns |  36.846 ns |  34.466 ns | 0.7095 |     - |     - |    5165 B |
| &#39;Looping with Parallel.ForEach().&#39; |             250 |   2,366.92 ns |  15.041 ns |  14.069 ns | 0.6676 |     - |     - |    5169 B |
| &#39;Looping with Parallel.ForEach().&#39; |             500 |   2,317.08 ns |  29.052 ns |  25.754 ns | 0.6714 |     - |     - |    5168 B |
| &#39;Looping with Parallel.ForEach().&#39; |            1000 |   2,273.88 ns |   5.143 ns |   4.810 ns | 0.6943 |     - |     - |    5167 B |
