# dotNetTips.Utility Core Benchmark Tests
Below are the current benchmark tests for the dotNetTips.Utility assemblies for .NET Core. Benchmark test run on: December 02, 2019
# ConcurrentHashSet:
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=ConcurrentHashSet,GenericCollections  

```
|                      Method | CollectionCount |        Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------------------- |---------------- |------------:|----------:|----------:|-------:|-------:|------:|----------:|
| **&#39;Create Using Constructor.&#39;** |              **25** |  **5,227.3 ns** |   **9.31 ns** |   **8.71 ns** | **0.3586** |      **-** |     **-** |    **3384 B** |
| &#39;Create Using Constructor.&#39; |              50 | 10,846.9 ns | 128.17 ns | 119.89 ns | 0.8392 |      - |     - |    7936 B |
| &#39;Create Using Constructor.&#39; |             100 | 21,259.2 ns | 235.76 ns | 208.99 ns | 1.7395 | 0.0305 |     - |   16512 B |
| &#39;Create Using Constructor.&#39; |             250 | 58,301.5 ns |  56.38 ns |  49.98 ns | 5.8594 | 0.4272 |     - |   55097 B |
|   **&#39;Create Using ForEach().&#39;** |              **25** |  **5,452.7 ns** |  **11.11 ns** |  **10.39 ns** | **0.3586** |      **-** |     **-** |    **3432 B** |
|   &#39;Create Using ForEach().&#39; |              50 | 10,967.7 ns |  21.37 ns |  19.99 ns | 0.8087 |      - |     - |    7584 B |
|   &#39;Create Using ForEach().&#39; |             100 | 22,491.0 ns |  26.31 ns |  23.32 ns | 1.7395 |      - |     - |   16480 B |
|   &#39;Create Using ForEach().&#39; |             250 | 60,863.6 ns | 294.30 ns | 275.29 ns | 5.7373 | 0.4272 |     - |   54465 B |
|   **&#39;Looping with foreach().&#39;** |              **25** |    **470.1 ns** |   **5.92 ns** |   **5.54 ns** | **0.0057** |      **-** |     **-** |      **56 B** |
|   &#39;Looping with foreach().&#39; |              50 |  1,666.9 ns |  22.61 ns |  21.15 ns | 0.0057 |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             100 |  2,145.3 ns |   3.88 ns |   3.44 ns | 0.0038 |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             250 |  7,902.2 ns |  11.35 ns |  10.61 ns |      - |      - |     - |      56 B |

# DistinctConcurrentBag
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctConcurrentBag,GenericCollections  

```
|                        Method | CollectionCount |        Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------ |---------------- |------------:|----------:|----------:|-------:|------:|------:|----------:|
| **&#39;Creating Using Constructor.&#39;** |              **25** |  **6,260.9 ns** |  **15.89 ns** |  **12.41 ns** | **0.0076** |     **-** |     **-** |    **2192 B** |
| &#39;Creating Using Constructor.&#39; |              50 | 11,842.0 ns |  41.52 ns |  38.84 ns | 0.0153 |     - |     - |    4408 B |
| &#39;Creating Using Constructor.&#39; |             100 | 22,774.3 ns | 265.60 ns | 248.44 ns | 0.0305 |     - |     - |    9064 B |
| &#39;Creating Using Constructor.&#39; |             250 | 54,775.6 ns | 748.04 ns | 699.72 ns | 0.0610 |     - |     - |   19288 B |
|   **&#39;Creating Using ForEach().&#39;** |              **25** |  **6,056.3 ns** |  **65.43 ns** |  **58.00 ns** |      **-** |     **-** |     **-** |    **1978 B** |
|   &#39;Creating Using ForEach().&#39; |              50 | 12,110.9 ns |  63.37 ns |  59.28 ns |      - |     - |     - |    3994 B |
|   &#39;Creating Using ForEach().&#39; |             100 | 22,753.9 ns | 183.41 ns | 162.58 ns | 0.0305 |     - |     - |    8232 B |
|   &#39;Creating Using ForEach().&#39; |             250 | 55,334.6 ns | 153.39 ns | 135.97 ns | 0.0610 |     - |     - |   17256 B |
|     **&#39;Looping with foreach().&#39;** |              **25** |    **292.0 ns** |   **2.97 ns** |   **2.48 ns** | **0.0277** |     **-** |     **-** |     **264 B** |
|     &#39;Looping with foreach().&#39; |              50 |    537.0 ns |   2.44 ns |   2.29 ns | 0.0486 |     - |     - |     464 B |
|     &#39;Looping with foreach().&#39; |             100 |    934.3 ns |  11.25 ns |  10.53 ns | 0.0925 |     - |     - |     864 B |
|     &#39;Looping with foreach().&#39; |             250 |  2,223.0 ns |   4.26 ns |   3.32 ns | 0.2213 |     - |     - |    2064 B |

# DistinctBlockingCollection
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctBlockingCollection,GenericCollections  

```
|                             Method | CollectionCount |         Mean |      Error |     StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------- |---------------- |-------------:|-----------:|-----------:|-------:|------:|------:|----------:|
|      **&#39;Creating Using Constructor.&#39;** |              **25** |  **2,788.38 ns** |  **13.771 ns** |  **12.208 ns** | **0.1488** |     **-** |     **-** |    **1440 B** |
|      &#39;Creating Using Constructor.&#39; |              50 |  5,290.47 ns |  12.207 ns |  11.418 ns | 0.1755 |     - |     - |    1640 B |
|      &#39;Creating Using Constructor.&#39; |             100 | 10,361.55 ns | 200.764 ns | 214.815 ns | 0.2136 |     - |     - |    2040 B |
|      &#39;Creating Using Constructor.&#39; |             250 | 25,243.51 ns | 283.724 ns | 265.396 ns | 0.3357 |     - |     - |    3240 B |
|            **&#39;Creating Using for().&#39;** |              **25** |  **2,757.80 ns** |   **5.245 ns** |   **4.650 ns** | **0.1297** |     **-** |     **-** |    **1208 B** |
|            &#39;Creating Using for().&#39; |              50 |  5,235.70 ns |   6.187 ns |   5.167 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             100 | 10,304.99 ns | 114.942 ns | 101.893 ns | 0.1221 |     - |     - |    1208 B |
|            &#39;Creating Using for().&#39; |             250 | 25,207.36 ns |  51.886 ns |  45.995 ns | 0.1221 |     - |     - |    1208 B |
|          **&#39;Looping with foreach().&#39;** |              **25** |     **40.23 ns** |   **0.521 ns** |   **0.407 ns** | **0.0085** |     **-** |     **-** |      **80 B** |
|          &#39;Looping with foreach().&#39; |              50 |     41.58 ns |   0.281 ns |   0.263 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             100 |     42.27 ns |   0.301 ns |   0.282 ns | 0.0085 |     - |     - |      80 B |
|          &#39;Looping with foreach().&#39; |             250 |     41.95 ns |   0.126 ns |   0.118 ns | 0.0085 |     - |     - |      80 B |
| **&#39;Looping with Parallel.ForEach().&#39;** |              **25** |  **2,250.10 ns** |   **3.393 ns** |   **3.173 ns** | **0.6943** |     **-** |     **-** |    **5165 B** |
| &#39;Looping with Parallel.ForEach().&#39; |              50 |  2,310.94 ns |  26.051 ns |  24.368 ns | 0.6828 |     - |     - |    5162 B |
| &#39;Looping with Parallel.ForEach().&#39; |             100 |  2,270.76 ns |   3.505 ns |   3.107 ns | 0.7133 |     - |     - |    5164 B |
| &#39;Looping with Parallel.ForEach().&#39; |             250 |  2,250.07 ns |   4.677 ns |   4.375 ns | 0.6981 |     - |     - |    5167 B |

# FastSortedList
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FastSortedList,GenericCollections  

```
|                       Method | CollectionCount |         Mean |      Error |     StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------------- |---------------- |-------------:|-----------:|-----------:|-------:|-------:|------:|----------:|
| **&#39;Creating Using Constructor&#39;** |              **25** |     **45.73 ns** |   **0.063 ns** |   **0.049 ns** | **0.0269** |      **-** |     **-** |     **256 B** |
| &#39;Creating Using Constructor&#39; |              50 |     65.80 ns |   0.215 ns |   0.201 ns | 0.0490 |      - |     - |     464 B |
| &#39;Creating Using Constructor&#39; |             100 |     99.55 ns |   0.373 ns |   0.349 ns | 0.0917 | 0.0001 |     - |     864 B |
| &#39;Creating Using Constructor&#39; |             250 |    213.02 ns |   3.181 ns |   2.975 ns | 0.2215 | 0.0012 |     - |    2064 B |
|       **&#39;Creating Using for()&#39;** |              **25** |    **276.28 ns** |   **5.442 ns** |   **8.632 ns** | **0.0744** |      **-** |     **-** |     **704 B** |
|       &#39;Creating Using for()&#39; |              50 |    444.30 ns |   1.363 ns |   1.138 ns | 0.1302 |      - |     - |    1240 B |
|       &#39;Creating Using for()&#39; |             100 |    772.10 ns |   1.814 ns |   1.697 ns | 0.2413 |      - |     - |    2288 B |
|       &#39;Creating Using for()&#39; |             250 |  1,682.53 ns |   3.241 ns |   3.031 ns | 0.4692 | 0.0038 |     - |    4360 B |
|     **&#39;Looping with ForEach()&#39;** |              **25** |     **99.38 ns** |   **1.753 ns** |   **1.640 ns** | **0.0067** |      **-** |     **-** |      **64 B** |
|     &#39;Looping with ForEach()&#39; |              50 |    186.13 ns |   0.430 ns |   0.403 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             100 |    371.73 ns |   7.446 ns |  18.264 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             250 |    796.69 ns |   1.448 ns |   1.354 ns | 0.0067 |      - |     - |      64 B |
|                       **Sort()** |              **25** |  **3,212.05 ns** |   **4.010 ns** |   **3.555 ns** |      **-** |      **-** |     **-** |         **-** |
|                       Sort() |              50 |  8,349.33 ns |  10.516 ns |   9.837 ns |      - |      - |     - |         - |
|                       Sort() |             100 | 27,133.91 ns | 367.563 ns | 343.819 ns |      - |      - |     - |         - |
|                       Sort() |             250 | 75,295.94 ns | 100.433 ns |  93.945 ns |      - |      - |     - |         - |
|  **&#39;Sort(delegate) on Country&#39;** |              **25** |  **2,696.79 ns** |   **7.815 ns** |   **6.526 ns** |      **-** |      **-** |     **-** |         **-** |
|  &#39;Sort(delegate) on Country&#39; |              50 |  8,146.88 ns |  13.240 ns |  12.385 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             100 | 22,392.01 ns |  20.165 ns |  17.876 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             250 | 67,890.73 ns |  73.707 ns |  65.339 ns |      - |      - |     - |         - |

# Clock
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=Clock  

```
|                Method |       Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-----------:|----------:|----------:|------:|------:|------:|----------:|
|    **DaysInCurrentMonth** | **458.011 ns** | **0.5243 ns** | **0.4648 ns** |     **-** |     **-** |     **-** |         **-** |
| **DaysInCurrentUtcMonth** | **165.229 ns** | **0.1647 ns** | **0.1460 ns** |     **-** |     **-** |     **-** |         **-** |
|             **LocalTime** | **216.149 ns** | **0.2759 ns** | **0.2580 ns** |     **-** |     **-** |     **-** |         **-** |
|             **TickCount** |   **1.787 ns** | **0.0036 ns** | **0.0034 ns** |     **-** |     **-** |     **-** |         **-** |
|               **UtcTime** |  **65.497 ns** | **0.9254 ns** | **0.8656 ns** |     **-** |     **-** |     **-** |         **-** |

# CollectionExtensions
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=CollectionExtensions  

```
|            Method | CollectionCount |            Mean |        Error |       StdDev |          Median |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------ |---------------- |----------------:|-------------:|-------------:|----------------:|--------:|-------:|------:|----------:|
|          **AddRange** |              **25** |   **122,413.82 ns** |   **389.047 ns** |   **363.914 ns** |   **122,276.03 ns** |  **2.4414** |      **-** |     **-** |   **23417 B** |
|          AddRange |              50 |   245,129.17 ns |   672.683 ns |   596.316 ns |   244,994.97 ns |  4.3945 |      - |     - |   45976 B |
|          AddRange |             100 |   476,121.79 ns | 1,239.038 ns | 1,158.996 ns |   476,073.90 ns |  9.2773 |      - |     - |   91113 B |
|          AddRange |             250 | 1,192,544.94 ns | 3,481.288 ns | 3,086.071 ns | 1,191,545.12 ns | 23.4375 |      - |     - |  225963 B |
|           **FastAny** |              **25** |       **530.27 ns** |     **1.408 ns** |     **1.248 ns** |       **529.86 ns** |  **0.0038** |      **-** |     **-** |      **40 B** |
|           FastAny |              50 |     1,030.10 ns |    20.418 ns |    33.547 ns |     1,045.89 ns |  0.0038 |      - |     - |      40 B |
|           FastAny |             100 |     2,039.63 ns |     7.586 ns |     6.725 ns |     2,038.87 ns |  0.0038 |      - |     - |      40 B |
|           FastAny |             250 |     5,406.91 ns |    68.263 ns |    63.853 ns |     5,366.48 ns |       - |      - |     - |      40 B |
|         **FastCount** |              **25** |       **315.29 ns** |     **1.069 ns** |     **1.000 ns** |       **315.22 ns** |       **-** |      **-** |     **-** |         **-** |
|         FastCount |              50 |       593.89 ns |     2.389 ns |     1.995 ns |       594.35 ns |       - |      - |     - |         - |
|         FastCount |             100 |     1,266.61 ns |     3.722 ns |     2.906 ns |     1,265.52 ns |       - |      - |     - |         - |
|         FastCount |             250 |     3,810.43 ns |    10.929 ns |     8.533 ns |     3,811.67 ns |       - |      - |     - |         - |
|          **HasItems** |              **25** |        **12.66 ns** |     **0.020 ns** |     **0.017 ns** |        **12.66 ns** |       **-** |      **-** |     **-** |         **-** |
|          HasItems |              50 |        12.85 ns |     0.013 ns |     0.012 ns |        12.85 ns |       - |      - |     - |         - |
|          HasItems |             100 |        12.66 ns |     0.016 ns |     0.014 ns |        12.66 ns |       - |      - |     - |         - |
|          HasItems |             250 |        12.41 ns |     0.024 ns |     0.022 ns |        12.41 ns |       - |      - |     - |         - |
|        **PickRandom** |              **25** |        **33.96 ns** |     **0.708 ns** |     **1.221 ns** |        **33.20 ns** |  **0.0094** |      **-** |     **-** |      **88 B** |
|        PickRandom |              50 |        34.27 ns |     0.140 ns |     0.124 ns |        34.22 ns |  0.0094 |      - |     - |      88 B |
|        PickRandom |             100 |        35.43 ns |     0.513 ns |     0.480 ns |        35.59 ns |  0.0093 |      - |     - |      88 B |
|        PickRandom |             250 |        34.38 ns |     0.091 ns |     0.086 ns |        34.37 ns |  0.0094 |      - |     - |      88 B |
|         **Randomize** |              **25** |        **20.64 ns** |     **0.066 ns** |     **0.055 ns** |        **20.64 ns** |  **0.0060** |      **-** |     **-** |      **56 B** |
|         Randomize |              50 |        20.29 ns |     0.258 ns |     0.241 ns |        20.14 ns |  0.0060 |      - |     - |      56 B |
|         Randomize |             100 |        21.59 ns |     0.272 ns |     0.254 ns |        21.72 ns |  0.0060 |      - |     - |      56 B |
|         Randomize |             250 |        20.89 ns |     0.285 ns |     0.267 ns |        20.95 ns |  0.0059 |      - |     - |      56 B |
| **ToDelimitedString** |              **25** |     **1,141.08 ns** |     **4.480 ns** |     **4.190 ns** |     **1,141.19 ns** |  **0.5474** | **0.0038** |     **-** |    **5152 B** |
| ToDelimitedString |              50 |     2,120.47 ns |     8.727 ns |     8.163 ns |     2,123.18 ns |  1.0338 | 0.0114 |     - |    9720 B |
| ToDelimitedString |             100 |     3,934.10 ns |    11.634 ns |    10.313 ns |     3,932.93 ns |  2.0065 | 0.0458 |     - |   18792 B |
| ToDelimitedString |             250 |    10,009.77 ns |    38.022 ns |    35.566 ns |    10,009.54 ns |  5.6763 | 0.3967 |     - |   57824 B |

# EnumExtensions
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=EnumExtensions  

```
|   Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
| GetItems | 4.273 us | 0.0225 us | 0.0211 us | 0.0916 |     - |     - |     872 B |

# ObjectExtensions
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=ObjectExtensions  

```
|            Method |        Mean |    Error |   StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------ |------------:|---------:|---------:|-------:|-------:|------:|----------:|
|             **Clone** |  **4,380.0 ns** | **16.11 ns** | **15.07 ns** | **0.8316** |      **-** |     **-** |    **7792 B** |
|    **ComputeMD5Hash** |  **5,722.9 ns** | **12.33 ns** | **10.30 ns** | **0.4959** |      **-** |     **-** |    **4696 B** |
| **ComputeSha256Hash** |  **7,592.7 ns** | **11.35 ns** | **10.06 ns** | **0.5569** |      **-** |     **-** |    **5440 B** |
|          **FromJson** | **11,642.6 ns** | **22.08 ns** | **19.57 ns** | **1.4343** | **0.0153** |     **-** |   **13480 B** |
|       **HasProperty** |    **260.0 ns** |  **2.80 ns** |  **2.62 ns** | **0.0262** |      **-** |     **-** |     **248 B** |
|            **ToJson** |  **3,348.7 ns** |  **6.72 ns** |  **5.96 ns** | **0.3433** |      **-** |     **-** |    **3240 B** |

# StringExtensions
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=StringExtensions  

```
|            Method |         Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------ |-------------:|----------:|----------:|-------:|-------:|------:|----------:|
| **ComputeSha256Hash** | **6,117.450 ns** | **9.4944 ns** | **7.9283 ns** | **0.2899** |      **-** |     **-** |    **2760 B** |
|            **Concat** |   **574.711 ns** | **4.4002 ns** | **4.1160 ns** | **0.6418** | **0.0048** |     **-** |    **6064 B** |
|       **ContainsAny** |    **65.489 ns** | **0.3795 ns** | **0.3550 ns** | **0.0170** |      **-** |     **-** |     **160 B** |
|          **HasValue** |     **6.278 ns** | **0.0411 ns** | **0.0365 ns** |      **-** |      **-** |     **-** |         **-** |
|            **Indent** |   **442.707 ns** | **0.8873 ns** | **0.8299 ns** | **0.4330** | **0.0024** |     **-** |    **4088 B** |
|   **ToTrimmedString** |   **216.676 ns** | **2.2588 ns** | **2.1129 ns** | **0.2069** | **0.0005** |     **-** |    **1960 B** |

# DirectoryHelper
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DirectoryHelper  

```
|              Method |        Mean |    Error |   StdDev |    Gen 0 |   Gen 1 | Gen 2 | Allocated |
|-------------------- |------------:|---------:|---------:|---------:|--------:|------:|----------:|
|           **LoadFiles** | **30,379.6 us** | **49.59 us** | **46.38 us** |  **62.5000** | **31.2500** |     **-** | **1349626 B** |
|      **LoadFilesAsync** | **19,096.7 us** | **44.28 us** | **41.42 us** | **125.0000** |       **-** |     **-** | **1188552 B** |
| **SafeDirectorySearch** |    **377.4 us** |  **1.19 us** |  **1.11 us** |        **-** |       **-** |     **-** |     **760 B** |

# DriveHelper
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DriveHelper  

```
|         Method |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------- |---------:|---------:|---------:|-------:|------:|------:|----------:|
| GetFixedDrives | 13.63 us | 0.160 us | 0.149 us | 0.0610 |     - |     - |     608 B |

# FileHelper
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FileHelper  

```
|        Method |        Mean |     Error |      StdDev |      Median |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------- |------------:|----------:|------------:|------------:|--------:|------:|------:|----------:|
|      **CopyFile** |    **907.5 us** |  **17.95 us** |    **34.58 us** |    **890.0 us** |  **2.9297** |     **-** |     **-** |  **37.74 KB** |
| **CopyFileAsync** |    **958.7 us** |  **10.74 us** |     **9.52 us** |    **956.9 us** |  **3.9063** |     **-** |     **-** |     **39 KB** |
|   **DeleteFiles** | **39,174.9 us** | **841.49 us** | **2,231.52 us** | **38,924.3 us** | **76.9231** |     **-** |     **-** | **989.84 KB** |
|      **MoveFile** |    **956.1 us** |  **19.08 us** |    **18.74 us** |    **951.9 us** |       **-** |     **-** |     **-** |   **14.2 KB** |

# LoggingHelper
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=LoggingHelper  

```
|                       Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
| **RetrieveAllExceptionMessages** | **2.843 us** | **0.0031 us** | **0.0027 us** | **0.1259** |     **-** |     **-** |    **1216 B** |
|        **RetrieveAllExceptions** | **1.665 us** | **0.0036 us** | **0.0033 us** | **0.0896** |     **-** |     **-** |     **848 B** |

# TypeHelper
``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=TypeHelper  

```
|              Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
| GetInstanceHashCode | 2.331 us | 0.0331 us | 0.0310 us | 0.0458 |     - |     - |     432 B |
