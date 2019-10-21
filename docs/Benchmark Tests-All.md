# dotNetTips.Utility Core Benchmark Tests
Below are the current benchmark tests for the dotNetTips.Utility assemblies for .NET Core.
# ConcurrentHashSet:
``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=ConcurrentHashSet,GenericCollections  

```
|                      Method | CollectionCount |        Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------------------- |---------------- |------------:|----------:|----------:|-------:|-------:|------:|----------:|
| **&#39;Create Using Constructor.&#39;** |              **25** |  **5,339.4 ns** |   **9.52 ns** |   **7.95 ns** | **0.3433** |      **-** |     **-** |    **3224 B** |
| &#39;Create Using Constructor.&#39; |              50 |  9,985.0 ns |  15.13 ns |  13.41 ns | 0.4578 |      - |     - |    4344 B |
| &#39;Create Using Constructor.&#39; |             100 | 21,496.2 ns | 172.32 ns | 161.19 ns | 1.4648 |      - |     - |   13792 B |
| &#39;Create Using Constructor.&#39; |             250 | 54,273.9 ns | 523.28 ns | 489.48 ns | 3.6011 |      - |     - |   33897 B |
|   **&#39;Create Using ForEach().&#39;** |              **25** |  **5,315.9 ns** |  **11.89 ns** |  **10.54 ns** | **0.3510** |      **-** |     **-** |    **3312 B** |
|   &#39;Create Using ForEach().&#39; |              50 | 10,292.4 ns | 111.47 ns |  98.82 ns | 0.4730 |      - |     - |    4432 B |
|   &#39;Create Using ForEach().&#39; |             100 | 21,785.6 ns |  29.33 ns |  26.00 ns | 1.6785 | 0.0305 |     - |   15760 B |
|   &#39;Create Using ForEach().&#39; |             250 | 53,798.5 ns | 181.08 ns | 151.21 ns | 3.5400 | 0.1831 |     - |   33385 B |
|   **&#39;Looping with foreach().&#39;** |              **25** |    **481.5 ns** |   **3.99 ns** |   **3.73 ns** | **0.0057** |      **-** |     **-** |      **56 B** |
|   &#39;Looping with foreach().&#39; |              50 |    687.4 ns |   8.74 ns |   8.17 ns | 0.0057 |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             100 |  2,242.8 ns |   5.60 ns |   5.24 ns | 0.0038 |      - |     - |      56 B |
|   &#39;Looping with foreach().&#39; |             250 |  7,834.3 ns |  15.92 ns |  14.12 ns |      - |      - |     - |      56 B |
# DistinctConcurrentBag
``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctConcurrentBag,GenericCollections  

```
|                        Method | CollectionCount |        Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------ |---------------- |------------:|----------:|----------:|-------:|------:|------:|----------:|
| **&#39;Creating Using Constructor.&#39;** |              **25** |  **6,830.2 ns** |  **95.76 ns** |  **84.89 ns** | **0.0076** |     **-** |     **-** |    **1912 B** |
| &#39;Creating Using Constructor.&#39; |              50 | 12,295.1 ns | 133.26 ns | 118.13 ns | 0.0153 |     - |     - |    3928 B |
| &#39;Creating Using Constructor.&#39; |             100 | 24,186.3 ns |  88.38 ns |  78.34 ns | 0.0305 |     - |     - |    8184 B |
| &#39;Creating Using Constructor.&#39; |             250 | 57,051.4 ns | 473.71 ns | 443.11 ns | 0.0610 |     - |     - |   17208 B |
|   **&#39;Creating Using ForEach().&#39;** |              **25** |  **6,061.0 ns** | **119.87 ns** | **275.41 ns** |      **-** |     **-** |     **-** |    **1960 B** |
|   &#39;Creating Using ForEach().&#39; |              50 | 12,131.1 ns | 137.26 ns | 128.40 ns |      - |     - |     - |    3994 B |
|   &#39;Creating Using ForEach().&#39; |             100 | 23,331.5 ns | 184.36 ns | 153.95 ns | 0.0305 |     - |     - |    8232 B |
|   &#39;Creating Using ForEach().&#39; |             250 | 56,447.7 ns | 157.90 ns | 139.98 ns | 0.0610 |     - |     - |   17256 B |
|     **&#39;Looping with foreach().&#39;** |              **25** |    **313.5 ns** |   **0.67 ns** |   **0.63 ns** | **0.0281** |     **-** |     **-** |     **264 B** |
|     &#39;Looping with foreach().&#39; |              50 |    506.6 ns |   1.29 ns |   1.21 ns | 0.0496 |     - |     - |     464 B |
|     &#39;Looping with foreach().&#39; |             100 |    937.9 ns |  11.67 ns |  10.92 ns | 0.0925 |     - |     - |     864 B |
|     &#39;Looping with foreach().&#39; |             250 |  2,369.7 ns |   4.33 ns |   4.05 ns | 0.2213 |     - |     - |    2064 B |
# DistinctBlockingCollection
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
# FastSortedList
``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FastSortedList,GenericCollections  

```
|                       Method | CollectionCount |         Mean |      Error |     StdDev |       Median |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|----------------------------- |---------------- |-------------:|-----------:|-----------:|-------------:|-------:|-------:|------:|----------:|
| **&#39;Creating Using Constructor&#39;** |              **25** |     **52.69 ns** |   **1.755 ns** |   **4.833 ns** |     **50.23 ns** | **0.0284** |      **-** |     **-** |     **264 B** |
| &#39;Creating Using Constructor&#39; |              50 |     72.30 ns |   0.274 ns |   0.256 ns |     72.28 ns | 0.0494 |      - |     - |     456 B |
| &#39;Creating Using Constructor&#39; |             100 |    103.09 ns |   0.345 ns |   0.306 ns |    103.11 ns | 0.0917 | 0.0001 |     - |     856 B |
| &#39;Creating Using Constructor&#39; |             250 |    217.67 ns |   2.423 ns |   2.266 ns |    218.42 ns | 0.2248 | 0.0010 |     - |    2064 B |
|       **&#39;Creating Using for()&#39;** |              **25** |    **280.62 ns** |   **2.039 ns** |   **1.907 ns** |    **280.16 ns** | **0.0753** |      **-** |     **-** |     **704 B** |
|       &#39;Creating Using for()&#39; |              50 |    488.67 ns |   2.738 ns |   2.561 ns |    488.89 ns | 0.1326 |      - |     - |    1240 B |
|       &#39;Creating Using for()&#39; |             100 |    818.76 ns |   8.771 ns |   8.204 ns |    812.97 ns | 0.2460 |      - |     - |    2288 B |
|       &#39;Creating Using for()&#39; |             250 |  1,619.80 ns |   4.269 ns |   3.333 ns |  1,620.66 ns | 0.4673 | 0.0019 |     - |    4360 B |
|     **&#39;Looping with ForEach()&#39;** |              **25** |    **101.55 ns** |   **0.647 ns** |   **0.606 ns** |    **101.64 ns** | **0.0068** |      **-** |     **-** |      **64 B** |
|     &#39;Looping with ForEach()&#39; |              50 |    185.22 ns |   0.596 ns |   0.529 ns |    185.03 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             100 |    329.26 ns |   0.839 ns |   0.701 ns |    329.28 ns | 0.0067 |      - |     - |      64 B |
|     &#39;Looping with ForEach()&#39; |             250 |    794.53 ns |   1.252 ns |   1.171 ns |    794.37 ns | 0.0067 |      - |     - |      64 B |
|                       **Sort()** |              **25** |  **3,044.20 ns** |   **3.074 ns** |   **2.725 ns** |  **3,043.31 ns** |      **-** |      **-** |     **-** |         **-** |
|                       Sort() |              50 |  8,672.08 ns |  16.895 ns |  14.977 ns |  8,669.51 ns |      - |      - |     - |         - |
|                       Sort() |             100 | 23,477.71 ns |  57.975 ns |  48.411 ns | 23,463.07 ns |      - |      - |     - |         - |
|                       Sort() |             250 | 72,831.10 ns | 130.977 ns | 122.516 ns | 72,825.04 ns |      - |      - |     - |         - |
|  **&#39;Sort(delegate) on Country&#39;** |              **25** |  **2,921.27 ns** |   **2.372 ns** |   **2.102 ns** |  **2,920.20 ns** |      **-** |      **-** |     **-** |         **-** |
|  &#39;Sort(delegate) on Country&#39; |              50 |  8,521.52 ns |  10.518 ns |   9.324 ns |  8,522.49 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             100 | 21,483.53 ns |  21.029 ns |  17.561 ns | 21,482.45 ns |      - |      - |     - |         - |
|  &#39;Sort(delegate) on Country&#39; |             250 | 72,656.39 ns | 134.499 ns | 112.313 ns | 72,615.81 ns |      - |      - |     - |         - |
# Clock
``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=Clock  

```
|                Method |       Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-----------:|----------:|----------:|------:|------:|------:|----------:|
|    **DaysInCurrentMonth** | **506.637 ns** | **0.7172 ns** | **0.6708 ns** |     **-** |     **-** |     **-** |         **-** |
| **DaysInCurrentUtcMonth** | **170.533 ns** | **0.2128 ns** | **0.1886 ns** |     **-** |     **-** |     **-** |         **-** |
|             **LocalTime** | **241.918 ns** | **0.5220 ns** | **0.4628 ns** |     **-** |     **-** |     **-** |         **-** |
|             **TickCount** |   **1.738 ns** | **0.0442 ns** | **0.0414 ns** |     **-** |     **-** |     **-** |         **-** |
|               **UtcTime** |  **67.108 ns** | **0.2167 ns** | **0.2027 ns** |     **-** |     **-** |     **-** |         **-** |
# CollectionExtensions
``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=CollectionExtensions  

```
|            Method | CollectionCount |          Mean |        Error |       StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------ |---------------- |--------------:|-------------:|-------------:|--------:|-------:|------:|----------:|
|          **AddRange** |              **25** |  **78,277.49 ns** |   **303.904 ns** |   **284.272 ns** |  **1.5869** |      **-** |     **-** |   **15632 B** |
|          AddRange |              50 | 152,785.55 ns |   599.922 ns |   561.168 ns |  3.1738 |      - |     - |   29512 B |
|          AddRange |             100 | 325,273.46 ns | 1,131.292 ns | 1,058.212 ns |  6.3477 |      - |     - |   59649 B |
|          AddRange |             250 | 809,529.77 ns | 1,814.074 ns | 1,608.129 ns | 15.6250 |      - |     - |  150105 B |
|           **FastAny** |              **25** |     **501.02 ns** |     **2.210 ns** |     **2.067 ns** |  **0.0038** |      **-** |     **-** |      **40 B** |
|           FastAny |              50 |   1,090.58 ns |     2.386 ns |     2.115 ns |  0.0038 |      - |     - |      40 B |
|           FastAny |             100 |   2,019.93 ns |    11.781 ns |    11.020 ns |  0.0038 |      - |     - |      40 B |
|           FastAny |             250 |   5,749.52 ns |    10.021 ns |     9.374 ns |       - |      - |     - |      40 B |
|         **FastCount** |              **25** |     **299.33 ns** |     **0.514 ns** |     **0.481 ns** |       **-** |      **-** |     **-** |         **-** |
|         FastCount |              50 |     584.72 ns |     0.925 ns |     0.866 ns |       - |      - |     - |         - |
|         FastCount |             100 |   1,319.60 ns |     2.274 ns |     2.016 ns |       - |      - |     - |         - |
|         FastCount |             250 |   3,642.93 ns |     7.494 ns |     6.644 ns |       - |      - |     - |         - |
|          **HasItems** |              **25** |      **12.46 ns** |     **0.012 ns** |     **0.011 ns** |       **-** |      **-** |     **-** |         **-** |
|          HasItems |              50 |      12.54 ns |     0.020 ns |     0.019 ns |       - |      - |     - |         - |
|          HasItems |             100 |      12.45 ns |     0.017 ns |     0.015 ns |       - |      - |     - |         - |
|          HasItems |             250 |      20.35 ns |     0.038 ns |     0.036 ns |       - |      - |     - |         - |
|        **PickRandom** |              **25** |      **34.49 ns** |     **0.076 ns** |     **0.071 ns** |  **0.0095** |      **-** |     **-** |      **88 B** |
|        PickRandom |              50 |      34.86 ns |     0.079 ns |     0.070 ns |  0.0095 |      - |     - |      88 B |
|        PickRandom |             100 |      34.81 ns |     0.090 ns |     0.075 ns |  0.0095 |      - |     - |      88 B |
|        PickRandom |             250 |      34.52 ns |     0.432 ns |     0.404 ns |  0.0094 |      - |     - |      88 B |
|         **Randomize** |              **25** |      **20.11 ns** |     **0.212 ns** |     **0.198 ns** |  **0.0060** |      **-** |     **-** |      **56 B** |
|         Randomize |              50 |      21.13 ns |     0.433 ns |     0.425 ns |  0.0060 |      - |     - |      56 B |
|         Randomize |             100 |      21.28 ns |     0.441 ns |     0.413 ns |  0.0060 |      - |     - |      56 B |
|         Randomize |             250 |      19.62 ns |     0.104 ns |     0.097 ns |  0.0060 |      - |     - |      56 B |
| **ToDelimitedString** |              **25** |   **1,154.05 ns** |     **4.274 ns** |     **3.998 ns** |  **0.5150** | **0.0019** |     **-** |    **4840 B** |
| ToDelimitedString |              50 |   2,187.42 ns |     9.879 ns |     9.241 ns |  0.9766 | 0.0076 |     - |    9120 B |
| ToDelimitedString |             100 |   4,235.80 ns |     8.326 ns |     7.381 ns |  1.9302 | 0.0305 |     - |   17880 B |
| ToDelimitedString |             250 |   9,668.96 ns |    21.275 ns |    19.900 ns |  4.0436 |      - |     - |   39464 B |
# EnumExtensions
``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=EnumExtensions  

```
|   Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
| GetItems | 4.211 us | 0.0272 us | 0.0254 us | 0.0916 |     - |     - |     872 B |
# ObjectExtensions
``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=ObjectExtensions  

```
|            Method |        Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------ |------------:|----------:|----------:|-------:|-------:|------:|----------:|
|             **Clone** |  **4,298.9 ns** |  **18.45 ns** |  **17.26 ns** | **0.8469** |      **-** |     **-** |    **7792 B** |
|    **ComputeMD5Hash** |  **5,385.4 ns** |  **46.48 ns** |  **41.20 ns** | **0.4730** |      **-** |     **-** |    **4688 B** |
| **ComputeSha256Hash** |  **8,351.0 ns** | **204.71 ns** | **603.60 ns** | **0.5722** |      **-** |     **-** |    **5480 B** |
|          **FromJson** | **11,363.0 ns** |  **16.59 ns** |  **15.51 ns** | **1.4191** | **0.0153** |     **-** |   **13328 B** |
|       **HasProperty** |    **267.5 ns** |   **0.43 ns** |   **0.40 ns** | **0.0267** |      **-** |     **-** |     **248 B** |
|            **ToJson** |  **3,402.1 ns** |   **6.55 ns** |   **5.81 ns** | **0.3471** |      **-** |     **-** |    **3232 B** |
# StringExtensions
``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=StringExtensions  

```
|            Method |         Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------ |-------------:|----------:|----------:|-------:|-------:|------:|----------:|
| **ComputeSha256Hash** | **6,125.108 ns** | **5.9780 ns** | **5.2994 ns** | **0.2823** |      **-** |     **-** |    **2760 B** |
|            **Concat** |   **600.308 ns** | **2.9490 ns** | **2.6142 ns** | **0.6523** | **0.0048** |     **-** |    **6096 B** |
|       **ContainsAny** |    **54.823 ns** | **0.1742 ns** | **0.1544 ns** | **0.0172** |      **-** |     **-** |     **160 B** |
|          **HasValue** |     **6.715 ns** | **0.0664 ns** | **0.0621 ns** |      **-** |      **-** |     **-** |         **-** |
|            **Indent** |   **439.382 ns** | **1.4687 ns** | **1.3739 ns** | **0.4368** | **0.0019** |     **-** |    **4088 B** |
|   **ToTrimmedString** |   **218.482 ns** | **2.1108 ns** | **1.9745 ns** | **0.2108** | **0.0005** |     **-** |    **1960 B** |
# DirectoryHelper
``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DirectoryHelper  

```
|              Method |     Mean |    Error |   StdDev |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|---------:|---------:|--------:|------:|------:|----------:|
|           **LoadFiles** | **34.03 ms** | **0.378 ms** | **0.354 ms** | **66.6667** |     **-** |     **-** | **1256188 B** |
|      **LoadFilesAsync** | **36.02 ms** | **0.270 ms** | **0.252 ms** | **71.4286** |     **-** |     **-** | **1155629 B** |
| **SafeDirectorySearch** | **42.63 ms** | **0.272 ms** | **0.241 ms** |       **-** |     **-** |     **-** |     **760 B** |
# DriveHelper
``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DriveHelper  

```
|         Method |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------- |---------:|---------:|---------:|-------:|------:|------:|----------:|
| GetFixedDrives | 15.20 us | 0.062 us | 0.055 us | 0.0610 |     - |     - |     632 B |
# FileHelper
``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FileHelper  

```
|        Method |        Mean |     Error |    StdDev |      Median |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------- |------------:|----------:|----------:|------------:|---------:|------:|------:|----------:|
|      **CopyFile** |    **901.4 us** |   **5.80 us** |   **4.85 us** |    **900.9 us** |   **2.9297** |     **-** |     **-** |  **37.74 KB** |
| **CopyFileAsync** |    **910.4 us** |  **17.95 us** |  **43.36 us** |    **915.4 us** |   **3.9063** |     **-** |     **-** |     **39 KB** |
|   **DeleteFiles** | **45,742.8 us** | **896.67 us** | **880.65 us** | **45,838.4 us** | **125.0000** |     **-** |     **-** | **983.96 KB** |
|      **MoveFile** |    **847.8 us** |  **17.84 us** |  **41.35 us** |    **833.4 us** |        **-** |     **-** |     **-** |  **14.16 KB** |
# LoggingHelper
``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=LoggingHelper  

```
|                       Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
| **RetrieveAllExceptionMessages** | **2.881 us** | **0.0107 us** | **0.0095 us** | **0.1183** |     **-** |     **-** |    **1120 B** |
|        **RetrieveAllExceptions** | **1.734 us** | **0.0148 us** | **0.0139 us** | **0.0896** |     **-** |     **-** |     **848 B** |
# TypeHelper
``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=TypeHelper  

```
|              Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
| GetInstanceHashCode | 2.386 us | 0.0414 us | 0.0367 us | 0.0458 |     - |     - |     432 B |
