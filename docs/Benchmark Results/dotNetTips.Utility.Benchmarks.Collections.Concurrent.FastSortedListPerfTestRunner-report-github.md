``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-preview.8.20417.9
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-RATGHQ : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FastSortedList,GenericCollections  

```
|                       Method | CollectionCount |          Mean |        Error |       StdDev |        Median |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------------- |---------------- |--------------:|-------------:|-------------:|--------------:|-------:|-------:|------:|----------:|
| **&#39;Creating Using Constructor&#39;** |              **25** |      **49.42 ns** |     **0.636 ns** |     **0.595 ns** |      **49.33 ns** | **0.0278** |      **-** |     **-** |     **264 B** |
| &#39;Creating Using Constructor&#39; |              50 |      67.92 ns |     0.555 ns |     0.492 ns |      67.76 ns | 0.0490 |      - |     - |     464 B |
| &#39;Creating Using Constructor&#39; |             100 |     103.57 ns |     0.880 ns |     0.823 ns |     103.39 ns | 0.0912 | 0.0001 |     - |     864 B |
| &#39;Creating Using Constructor&#39; |             250 |     217.82 ns |     0.674 ns |     0.526 ns |     217.78 ns | 0.2184 | 0.0010 |     - |    2064 B |
| &#39;Creating Using Constructor&#39; |             500 |     410.92 ns |     2.877 ns |     2.691 ns |     411.42 ns | 0.4306 | 0.0048 |     - |    4064 B |
| &#39;Creating Using Constructor&#39; |            1000 |     840.27 ns |     8.618 ns |     7.197 ns |     841.73 ns | 0.8545 |      - |     - |    8064 B |
|       **&#39;Creating Using for()&#39;** |              **25** |     **271.73 ns** |     **3.071 ns** |     **2.873 ns** |     **272.46 ns** | **0.0749** |      **-** |     **-** |     **704 B** |
|       &#39;Creating Using for()&#39; |              50 |     471.76 ns |     3.297 ns |     3.084 ns |     473.47 ns | 0.1311 |      - |     - |    1240 B |
|       &#39;Creating Using for()&#39; |             100 |     812.47 ns |    13.170 ns |    11.675 ns |     816.94 ns | 0.2403 |      - |     - |    2288 B |
|       &#39;Creating Using for()&#39; |             250 |   1,747.26 ns |    34.402 ns |    50.426 ns |   1,762.41 ns | 0.4616 |      - |     - |    4360 B |
|       &#39;Creating Using for()&#39; |             500 |   3,108.31 ns |    11.804 ns |    11.041 ns |   3,111.22 ns | 0.8965 | 0.0038 |     - |    8480 B |
|       &#39;Creating Using for()&#39; |            1000 |   6,578.91 ns |   130.582 ns |   128.249 ns |   6,635.08 ns | 1.8311 |      - |     - |   16696 B |
|     **&#39;Looping with ForEach()&#39;** |              **25** |     **102.40 ns** |     **0.681 ns** |     **0.569 ns** |     **102.36 ns** | **0.0068** |      **-** |     **-** |      **64 B** |
|     &#39;Looping with ForEach()&#39; |              50 |     167.88 ns |     1.989 ns |     1.860 ns |     168.35 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             100 |     330.61 ns |     2.493 ns |     2.332 ns |     331.43 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             250 |     920.27 ns |    24.270 ns |    71.179 ns |     908.30 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             500 |   1,717.61 ns |    31.119 ns |    29.109 ns |   1,703.32 ns | 0.0057 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |            1000 |   4,003.62 ns |   152.651 ns |   450.094 ns |   3,839.01 ns | 0.0038 |      - |     - |      64 B |
|                       **Sort()** |              **25** |   **3,137.63 ns** |    **39.247 ns** |    **36.711 ns** |   **3,141.42 ns** |      **-** |      **-** |     **-** |         **-** |
|                       Sort() |              50 |   9,438.10 ns |    11.422 ns |     9.538 ns |   9,440.60 ns |      - |      - |     - |         - |
|                       Sort() |             100 |  25,484.47 ns |    14.643 ns |    13.697 ns |  25,482.07 ns |      - |      - |     - |         - |
|                       Sort() |             250 |  80,800.56 ns |    28.670 ns |    26.818 ns |  80,800.84 ns |      - |      - |     - |         - |
|                       Sort() |             500 | 211,376.13 ns | 3,185.508 ns | 2,979.726 ns | 209,254.15 ns |      - |      - |     - |         - |
|                       Sort() |            1000 | 431,297.24 ns |   323.926 ns |   303.000 ns | 431,348.54 ns |      - |      - |     - |       1 B |
|  **&#39;Sort(delegate) on Country&#39;** |              **25** |   **2,970.28 ns** |     **2.309 ns** |     **1.928 ns** |   **2,969.82 ns** |      **-** |      **-** |     **-** |         **-** |
|  &#39;Sort(delegate) on Country&#39; |              50 |   8,432.99 ns |    10.433 ns |     9.759 ns |   8,428.14 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             100 |  23,073.92 ns |    19.239 ns |    15.021 ns |  23,068.79 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             250 |  76,227.63 ns |    82.292 ns |    72.950 ns |  76,204.19 ns |      - |      - |     - |       1 B |
|  &#39;Sort(delegate) on Country&#39; |             500 | 187,280.18 ns | 3,690.571 ns | 3,452.162 ns | 185,657.89 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |            1000 | 512,233.45 ns |   185.169 ns |   154.625 ns | 512,256.98 ns |      - |      - |     - |       1 B |
