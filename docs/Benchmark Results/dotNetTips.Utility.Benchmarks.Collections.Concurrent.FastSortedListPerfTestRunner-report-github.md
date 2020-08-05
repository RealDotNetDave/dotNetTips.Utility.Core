``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.388 (2004/?/20H1)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.302
  [Host]     : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT
  Job-GMGNJH : .NET Core 3.1.6 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.31603), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FastSortedList,GenericCollections  

```
|                       Method | CollectionCount |          Mean |        Error |       StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------------- |---------------- |--------------:|-------------:|-------------:|-------:|-------:|------:|----------:|
| **&#39;Creating Using Constructor&#39;** |              **25** |      **58.78 ns** |     **1.583 ns** |     **4.491 ns** | **0.0281** |      **-** |     **-** |     **264 B** |
| &#39;Creating Using Constructor&#39; |              50 |      74.53 ns |     1.518 ns |     3.201 ns | 0.0495 |      - |     - |     464 B |
| &#39;Creating Using Constructor&#39; |             100 |     124.88 ns |     2.530 ns |     5.763 ns | 0.0923 |      - |     - |     864 B |
| &#39;Creating Using Constructor&#39; |             250 |     242.21 ns |     4.841 ns |     9.442 ns | 0.2208 | 0.0010 |     - |    2064 B |
| &#39;Creating Using Constructor&#39; |             500 |     455.60 ns |     9.066 ns |    15.395 ns | 0.4363 |      - |     - |    4064 B |
|       **&#39;Creating Using for()&#39;** |              **25** |     **288.51 ns** |     **5.806 ns** |    **11.728 ns** | **0.0749** |      **-** |     **-** |     **704 B** |
|       &#39;Creating Using for()&#39; |              50 |     571.86 ns |     9.907 ns |     8.273 ns | 0.1316 |      - |     - |    1240 B |
|       &#39;Creating Using for()&#39; |             100 |     930.47 ns |    18.367 ns |    35.823 ns | 0.2441 |      - |     - |    2288 B |
|       &#39;Creating Using for()&#39; |             250 |   2,153.58 ns |    43.004 ns |    80.772 ns | 0.4616 |      - |     - |    4360 B |
|       &#39;Creating Using for()&#39; |             500 |   4,347.14 ns |    85.270 ns |   151.568 ns | 0.9079 |      - |     - |    8480 B |
|     **&#39;Looping with ForEach()&#39;** |              **25** |      **99.74 ns** |     **2.006 ns** |     **3.003 ns** | **0.0067** |      **-** |     **-** |      **64 B** |
|     &#39;Looping with ForEach()&#39; |              50 |     186.91 ns |     3.533 ns |     5.179 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             100 |     353.11 ns |     4.672 ns |     4.798 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             250 |     804.33 ns |    15.085 ns |    13.372 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             500 |   1,601.67 ns |    31.357 ns |    46.934 ns | 0.0057 |      - |     - |      64 B |
|                       **Sort()** |              **25** |   **3,594.71 ns** |    **71.587 ns** |   **109.321 ns** |      **-** |      **-** |     **-** |         **-** |
|                       Sort() |              50 |   9,664.26 ns |   155.562 ns |   246.737 ns |      - |      - |     - |         - |
|                       Sort() |             100 |  27,016.42 ns |   537.879 ns | 1,225.022 ns |      - |      - |     - |         - |
|                       Sort() |             250 |  92,290.08 ns | 1,516.163 ns | 1,344.039 ns |      - |      - |     - |         - |
|                       Sort() |             500 | 198,172.20 ns | 3,877.523 ns | 6,688.537 ns |      - |      - |     - |         - |
|  **&#39;Sort(delegate) on Country&#39;** |              **25** |   **3,178.72 ns** |    **59.192 ns** |   **111.177 ns** |      **-** |      **-** |     **-** |         **-** |
|  &#39;Sort(delegate) on Country&#39; |              50 |   9,623.48 ns |   176.099 ns |   172.953 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             100 |  23,853.11 ns |   416.872 ns |   463.352 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             250 |  76,068.71 ns | 1,458.478 ns | 2,044.583 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             500 | 191,383.27 ns | 3,710.972 ns | 4,557.407 ns |      - |      - |     - |         - |
