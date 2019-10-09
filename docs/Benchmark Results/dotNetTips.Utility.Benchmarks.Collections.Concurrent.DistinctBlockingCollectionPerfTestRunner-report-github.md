``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctBlockingCollection,GenericCollections  

```
|                             Method | CollectionCount |         Mean |      Error |     StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------- |---------------- |-------------:|-----------:|-----------:|-------:|------:|------:|----------:|
|      **&#39;Creating Using Constructor.&#39;** |              **25** |  **2,811.89 ns** |   **4.647 ns** |   **4.347 ns** | **0.1259** |     **-** |     **-** |    **1160 B** |
|      &#39;Creating Using Constructor.&#39; |              50 |  5,735.51 ns |  25.597 ns |  23.944 ns | 0.1221 |     - |     - |    1160 B |
|      &#39;Creating Using Constructor.&#39; |             100 | 10,911.08 ns |  51.105 ns |  47.804 ns | 0.1221 |     - |     - |    1160 B |
|      &#39;Creating Using Constructor.&#39; |             250 | 26,877.46 ns | 284.566 ns | 266.184 ns | 0.1221 |     - |     - |    1160 B |
|            **&#39;Creating Using for().&#39;** |              **25** |  **2,647.80 ns** |   **4.331 ns** |   **3.616 ns** | **0.1297** |     **-** |     **-** |    **1208 B** |
|            &#39;Creating Using for().&#39; |              50 |  5,298.57 ns |  14.862 ns |  13.902 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             100 | 10,218.70 ns |  23.351 ns |  20.700 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             250 | 25,462.46 ns | 205.534 ns | 171.630 ns | 0.1221 |     - |     - |    1208 B |
|          **&#39;Looping with foreach().&#39;** |              **25** |     **40.63 ns** |   **0.185 ns** |   **0.145 ns** | **0.0085** |     **-** |     **-** |      **80 B** |
|          &#39;Looping with foreach().&#39; |              50 |     40.60 ns |   0.118 ns |   0.110 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             100 |     41.74 ns |   0.212 ns |   0.199 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             250 |     44.66 ns |   0.066 ns |   0.055 ns | 0.0086 |     - |     - |      80 B |
| **&#39;Looping with Parallel.ForEach().&#39;** |              **25** |  **2,343.53 ns** |  **35.751 ns** |  **33.441 ns** | **0.6714** |     **-** |     **-** |    **5175 B** |
| &#39;Looping with Parallel.ForEach().&#39; |              50 |  2,176.87 ns |   3.407 ns |   3.020 ns | 0.6828 |     - |     - |    5177 B |
| &#39;Looping with Parallel.ForEach().&#39; |             100 |  2,285.98 ns |   8.490 ns |   7.941 ns | 0.6599 |     - |     - |    5168 B |
| &#39;Looping with Parallel.ForEach().&#39; |             250 |  2,159.38 ns |   3.207 ns |   2.843 ns | 0.6981 |     - |     - |    5169 B |
