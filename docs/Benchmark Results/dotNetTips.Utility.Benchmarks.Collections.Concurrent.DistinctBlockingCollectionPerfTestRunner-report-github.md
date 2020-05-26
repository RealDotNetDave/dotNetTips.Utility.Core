``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.200
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  Job-KHIYCC : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctBlockingCollection,GenericCollections  

```
|                             Method | CollectionCount |         Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------- |---------------- |-------------:|----------:|----------:|-------:|------:|------:|----------:|
|      **&#39;Creating Using Constructor.&#39;** |              **25** |  **2,782.00 ns** |  **5.748 ns** |  **5.096 ns** | **0.1526** |     **-** |     **-** |    **1440 B** |
|      &#39;Creating Using Constructor.&#39; |              50 |  5,505.69 ns | 18.700 ns | 16.577 ns | 0.1678 |     - |     - |    1640 B |
|      &#39;Creating Using Constructor.&#39; |             100 | 10,529.96 ns | 65.454 ns | 61.226 ns | 0.2136 |     - |     - |    2040 B |
|      &#39;Creating Using Constructor.&#39; |             250 | 25,429.63 ns | 48.607 ns | 40.589 ns | 0.3357 |     - |     - |    3240 B |
|            **&#39;Creating Using for().&#39;** |              **25** |  **2,867.77 ns** | **90.565 ns** | **88.947 ns** | **0.1259** |     **-** |     **-** |    **1208 B** |
|            &#39;Creating Using for().&#39; |              50 |  5,192.01 ns | 17.084 ns | 15.145 ns | 0.1297 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             100 | 10,085.57 ns | 42.139 ns | 35.188 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             250 | 25,003.94 ns | 52.550 ns | 46.584 ns | 0.1221 |     - |     - |    1208 B |
|          **&#39;Looping with foreach().&#39;** |              **25** |     **47.98 ns** |  **0.334 ns** |  **0.312 ns** | **0.0085** |     **-** |     **-** |      **80 B** |
|          &#39;Looping with foreach().&#39; |              50 |     41.02 ns |  0.166 ns |  0.155 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             100 |     40.64 ns |  0.759 ns |  0.710 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             250 |     41.50 ns |  0.314 ns |  0.294 ns | 0.0085 |     - |     - |      80 B |
| **&#39;Looping with Parallel.ForEach().&#39;** |              **25** |  **2,255.04 ns** |  **4.023 ns** |  **3.763 ns** | **0.7019** |     **-** |     **-** |    **5167 B** |
| &#39;Looping with Parallel.ForEach().&#39; |              50 |  2,292.27 ns |  5.223 ns |  4.630 ns | 0.7019 |     - |     - |    5167 B |
| &#39;Looping with Parallel.ForEach().&#39; |             100 |  2,270.98 ns |  3.470 ns |  3.246 ns | 0.6981 |     - |     - |    5170 B |
| &#39;Looping with Parallel.ForEach().&#39; |             250 |  2,221.81 ns | 44.219 ns | 49.149 ns | 0.6828 |     - |     - |    5166 B |
