``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.300
  [Host]     : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT
  Job-LAEGID : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctBlockingCollection,GenericCollections  

```
|                             Method | CollectionCount |         Mean |        Error |       StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------- |---------------- |-------------:|-------------:|-------------:|-------:|------:|------:|----------:|
|      **&#39;Creating Using Constructor.&#39;** |              **25** |  **7,535.19 ns** |   **149.216 ns** |   **420.868 ns** | **0.1373** |     **-** |     **-** |    **1440 B** |
|      &#39;Creating Using Constructor.&#39; |              50 | 13,725.28 ns |   433.280 ns | 1,270.736 ns | 0.1678 |     - |     - |    1640 B |
|      &#39;Creating Using Constructor.&#39; |             100 | 26,918.04 ns |   855.401 ns | 2,508.742 ns | 0.1831 |     - |     - |    2040 B |
|      &#39;Creating Using Constructor.&#39; |             250 | 63,506.73 ns | 1,988.430 ns | 5,862.931 ns | 0.2441 |     - |     - |    3240 B |
|            **&#39;Creating Using for().&#39;** |              **25** |  **7,245.97 ns** |   **137.865 ns** |   **348.402 ns** | **0.1221** |     **-** |     **-** |    **1208 B** |
|            &#39;Creating Using for().&#39; |              50 | 14,638.20 ns |   317.525 ns |   931.245 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             100 | 27,174.04 ns | 1,003.745 ns | 2,959.564 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             250 | 68,453.89 ns | 1,094.894 ns | 1,024.165 ns | 0.1221 |     - |     - |    1208 B |
|          **&#39;Looping with foreach().&#39;** |              **25** |    **105.44 ns** |     **2.131 ns** |     **2.771 ns** | **0.0085** |     **-** |     **-** |      **80 B** |
|          &#39;Looping with foreach().&#39; |              50 |    100.66 ns |     2.061 ns |     2.956 ns | 0.0083 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             100 |     97.26 ns |     1.989 ns |     4.448 ns | 0.0083 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             250 |     97.21 ns |     1.995 ns |     3.389 ns | 0.0083 |     - |     - |      80 B |
| **&#39;Looping with Parallel.ForEach().&#39;** |              **25** |  **2,841.05 ns** |    **55.459 ns** |    **72.112 ns** | **0.6256** |     **-** |     **-** |    **5170 B** |
| &#39;Looping with Parallel.ForEach().&#39; |              50 |  2,825.20 ns |    56.453 ns |   128.573 ns | 0.6104 |     - |     - |    5170 B |
| &#39;Looping with Parallel.ForEach().&#39; |             100 |  2,837.95 ns |    55.848 ns |    88.580 ns | 0.6409 |     - |     - |    5169 B |
| &#39;Looping with Parallel.ForEach().&#39; |             250 |  2,870.75 ns |    57.150 ns |    97.045 ns | 0.6409 |     - |     - |    5173 B |
