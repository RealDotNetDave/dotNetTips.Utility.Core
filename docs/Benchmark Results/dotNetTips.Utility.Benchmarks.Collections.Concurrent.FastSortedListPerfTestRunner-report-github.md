``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Unknown processor
.NET Core SDK=3.1.400
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GUNMTB : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FastSortedList,GenericCollections  

```
|                       Method | CollectionCount |          Mean |        Error |     StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------------- |---------------- |--------------:|-------------:|-----------:|-------:|-------:|------:|----------:|
| **&#39;Creating Using Constructor&#39;** |              **25** |      **45.38 ns** |     **0.320 ns** |   **0.283 ns** | **0.0271** |      **-** |     **-** |     **256 B** |
| &#39;Creating Using Constructor&#39; |              50 |      70.18 ns |     0.898 ns |   0.840 ns | 0.0492 |      - |     - |     464 B |
| &#39;Creating Using Constructor&#39; |             100 |     101.64 ns |     0.797 ns |   0.745 ns | 0.0917 | 0.0001 |     - |     864 B |
| &#39;Creating Using Constructor&#39; |             250 |     211.76 ns |     2.640 ns |   2.469 ns | 0.2210 | 0.0017 |     - |    2056 B |
| &#39;Creating Using Constructor&#39; |             500 |     399.04 ns |     7.486 ns |   7.003 ns | 0.4368 | 0.0057 |     - |    4064 B |
| &#39;Creating Using Constructor&#39; |            1000 |     783.26 ns |    11.626 ns |  10.875 ns | 0.8602 | 0.0210 |     - |    8056 B |
|       **&#39;Creating Using for()&#39;** |              **25** |     **245.64 ns** |     **1.401 ns** |   **1.170 ns** | **0.0758** |      **-** |     **-** |     **704 B** |
|       &#39;Creating Using for()&#39; |              50 |     447.25 ns |     4.707 ns |   4.403 ns | 0.1321 |      - |     - |    1240 B |
|       &#39;Creating Using for()&#39; |             100 |     762.89 ns |     1.831 ns |   1.529 ns | 0.2470 |      - |     - |    2288 B |
|       &#39;Creating Using for()&#39; |             250 |   1,617.36 ns |     4.293 ns |   3.806 ns | 0.4635 |      - |     - |    4360 B |
|       &#39;Creating Using for()&#39; |             500 |   3,076.80 ns |     9.247 ns |   7.722 ns | 0.9003 | 0.0076 |     - |    8480 B |
|       &#39;Creating Using for()&#39; |            1000 |   6,151.54 ns |    18.416 ns |  16.325 ns | 1.8311 | 0.0229 |     - |   16696 B |
|     **&#39;Looping with ForEach()&#39;** |              **25** |      **97.64 ns** |     **0.227 ns** |   **0.201 ns** | **0.0067** |      **-** |     **-** |      **64 B** |
|     &#39;Looping with ForEach()&#39; |              50 |     160.72 ns |     0.389 ns |   0.303 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             100 |     302.86 ns |     1.428 ns |   1.266 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             250 |     898.14 ns |     5.772 ns |   5.399 ns | 0.0057 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             500 |   1,915.37 ns |     8.847 ns |   8.276 ns | 0.0057 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |            1000 |   2,870.19 ns |    30.921 ns |  28.923 ns | 0.0038 |      - |     - |      64 B |
|                       **Sort()** |              **25** |   **3,456.10 ns** |    **15.816 ns** |  **14.021 ns** |      **-** |      **-** |     **-** |         **-** |
|                       Sort() |              50 |   9,321.55 ns |    85.831 ns |  67.011 ns |      - |      - |     - |         - |
|                       Sort() |             100 |  24,449.84 ns |    34.564 ns |  30.640 ns |      - |      - |     - |         - |
|                       Sort() |             250 |  74,804.48 ns |   107.189 ns |  89.508 ns |      - |      - |     - |         - |
|                       Sort() |             500 | 184,360.45 ns |   401.674 ns | 356.073 ns |      - |      - |     - |         - |
|                       Sort() |            1000 | 446,791.15 ns | 1,140.613 ns | 890.516 ns |      - |      - |     - |       2 B |
|  **&#39;Sort(delegate) on Country&#39;** |              **25** |   **3,450.64 ns** |     **3.446 ns** |   **2.690 ns** |      **-** |      **-** |     **-** |         **-** |
|  &#39;Sort(delegate) on Country&#39; |              50 |   8,546.18 ns |     5.744 ns |   4.484 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             100 |  21,955.29 ns |    83.715 ns |  65.359 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             250 |  70,353.86 ns |    41.596 ns |  34.734 ns |      - |      - |     - |       1 B |
|  &#39;Sort(delegate) on Country&#39; |             500 | 182,754.26 ns |   234.772 ns | 208.119 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |            1000 | 417,702.77 ns |   808.790 ns | 631.450 ns |      - |      - |     - |       3 B |
