``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-preview.8.20417.9
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-RATGHQ : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctBlockingCollection,GenericCollections  

```
|                             Method | CollectionCount |          Mean |        Error |       StdDev |        Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------- |---------------- |--------------:|-------------:|-------------:|--------------:|-------:|------:|------:|----------:|
|      **&#39;Creating Using Constructor.&#39;** |              **25** |   **2,706.73 ns** |     **2.758 ns** |     **2.445 ns** |   **2,706.30 ns** | **0.1488** |     **-** |     **-** |    **1440 B** |
|      &#39;Creating Using Constructor.&#39; |              50 |   5,346.81 ns |    30.815 ns |    25.732 ns |   5,339.70 ns | 0.1678 |     - |     - |    1640 B |
|      &#39;Creating Using Constructor.&#39; |             100 |  10,437.40 ns |    71.583 ns |    66.959 ns |  10,411.24 ns | 0.2136 |     - |     - |    2040 B |
|      &#39;Creating Using Constructor.&#39; |             250 |  26,131.40 ns |    33.894 ns |    30.046 ns |  26,129.90 ns | 0.3357 |     - |     - |    3240 B |
|      &#39;Creating Using Constructor.&#39; |             500 |  49,366.45 ns |   115.373 ns |   107.920 ns |  49,393.26 ns | 0.5493 |     - |     - |    5240 B |
|      &#39;Creating Using Constructor.&#39; |            1000 |  99,968.59 ns |   530.180 ns |   495.930 ns |  99,904.22 ns | 0.9766 |     - |     - |    9232 B |
|            **&#39;Creating Using for().&#39;** |              **25** |   **2,644.06 ns** |     **4.420 ns** |     **3.919 ns** |   **2,643.23 ns** | **0.1259** |     **-** |     **-** |    **1208 B** |
|            &#39;Creating Using for().&#39; |              50 |   5,181.25 ns |    48.434 ns |    45.305 ns |   5,187.22 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             100 |  10,597.55 ns |   210.601 ns |   242.529 ns |  10,700.75 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             250 |  26,043.76 ns |    33.941 ns |    31.748 ns |  26,037.56 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             500 |  50,246.94 ns |   101.630 ns |    84.865 ns |  50,243.06 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |            1000 | 108,407.74 ns | 2,107.984 ns | 3,343.485 ns | 108,099.17 ns | 0.1221 |     - |     - |    1208 B |
|          **&#39;Looping with foreach().&#39;** |              **25** |      **42.41 ns** |     **0.871 ns** |     **1.303 ns** |      **43.21 ns** | **0.0085** |     **-** |     **-** |      **80 B** |
|          &#39;Looping with foreach().&#39; |              50 |      42.48 ns |     0.537 ns |     0.476 ns |      42.28 ns | 0.0084 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             100 |      45.34 ns |     0.774 ns |     0.724 ns |      45.67 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             250 |      44.20 ns |     0.619 ns |     0.579 ns |      44.35 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             500 |      42.99 ns |     0.880 ns |     1.421 ns |      41.99 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |            1000 |      42.32 ns |     0.202 ns |     0.189 ns |      42.28 ns | 0.0085 |     - |     - |      80 B |
| **&#39;Looping with Parallel.ForEach().&#39;** |              **25** |   **2,475.91 ns** |     **3.403 ns** |     **3.183 ns** |   **2,476.36 ns** | **0.6790** |     **-** |     **-** |    **5175 B** |
| &#39;Looping with Parallel.ForEach().&#39; |              50 |   2,497.13 ns |    10.902 ns |    10.198 ns |   2,496.99 ns | 0.6828 |     - |     - |    5178 B |
| &#39;Looping with Parallel.ForEach().&#39; |             100 |   2,282.67 ns |     4.370 ns |     3.874 ns |   2,282.88 ns | 0.6790 |     - |     - |    5167 B |
| &#39;Looping with Parallel.ForEach().&#39; |             250 |   2,281.03 ns |     6.880 ns |     6.436 ns |   2,282.20 ns | 0.6752 |     - |     - |    5168 B |
| &#39;Looping with Parallel.ForEach().&#39; |             500 |   2,477.58 ns |     8.838 ns |     8.267 ns |   2,478.75 ns | 0.6905 |     - |     - |    5177 B |
| &#39;Looping with Parallel.ForEach().&#39; |            1000 |   2,352.06 ns |    46.883 ns |    90.327 ns |   2,389.14 ns | 0.6981 |     - |     - |    5177 B |
