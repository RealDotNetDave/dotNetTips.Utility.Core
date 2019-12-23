``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  Job-QYQXQL : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctBlockingCollection,GenericCollections  

```
|                             Method | CollectionCount |         Mean |      Error |     StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------- |---------------- |-------------:|-----------:|-----------:|-------:|------:|------:|----------:|
|      **&#39;Creating Using Constructor.&#39;** |              **25** |  **3,008.72 ns** |  **11.169 ns** |  **10.448 ns** | **0.1526** |     **-** |     **-** |    **1440 B** |
|      &#39;Creating Using Constructor.&#39; |              50 |  5,268.90 ns |  23.518 ns |  21.998 ns | 0.1678 |     - |     - |    1640 B |
|      &#39;Creating Using Constructor.&#39; |             100 | 10,147.74 ns |  39.908 ns |  37.330 ns | 0.2136 |     - |     - |    2040 B |
|      &#39;Creating Using Constructor.&#39; |             250 | 26,098.45 ns | 138.675 ns | 129.717 ns | 0.3357 |     - |     - |    3240 B |
|            **&#39;Creating Using for().&#39;** |              **25** |  **2,706.22 ns** |  **10.256 ns** |   **8.564 ns** | **0.1259** |     **-** |     **-** |    **1208 B** |
|            &#39;Creating Using for().&#39; |              50 |  5,095.07 ns |  57.199 ns |  50.705 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             100 | 10,009.67 ns | 117.604 ns | 110.007 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             250 | 26,111.76 ns | 100.449 ns |  89.045 ns | 0.1221 |     - |     - |    1208 B |
|          **&#39;Looping with foreach().&#39;** |              **25** |     **40.87 ns** |   **0.379 ns** |   **0.336 ns** | **0.0085** |     **-** |     **-** |      **80 B** |
|          &#39;Looping with foreach().&#39; |              50 |     41.66 ns |   0.570 ns |   0.533 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             100 |     41.62 ns |   0.169 ns |   0.132 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             250 |     41.73 ns |   0.173 ns |   0.162 ns | 0.0085 |     - |     - |      80 B |
| **&#39;Looping with Parallel.ForEach().&#39;** |              **25** |  **2,269.09 ns** |   **5.429 ns** |   **5.079 ns** | **0.6752** |     **-** |     **-** |    **5168 B** |
| &#39;Looping with Parallel.ForEach().&#39; |              50 |  2,280.97 ns |   9.154 ns |   8.562 ns | 0.6981 |     - |     - |    5168 B |
| &#39;Looping with Parallel.ForEach().&#39; |             100 |  2,254.93 ns |  42.830 ns |  45.827 ns | 0.7019 |     - |     - |    5167 B |
| &#39;Looping with Parallel.ForEach().&#39; |             250 |  2,281.66 ns |   2.714 ns |   2.406 ns | 0.7095 |     - |     - |    5166 B |
