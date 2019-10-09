
BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FastSortedList,GenericCollections  

                       Method | CollectionCount |         Mean |      Error |     StdDev |       Median |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
----------------------------- |---------------- |-------------:|-----------:|-----------:|-------------:|-------:|-------:|------:|----------:|
 **'Creating Using Constructor'** |              **25** |     **52.69 ns** |   **1.755 ns** |   **4.833 ns** |     **50.23 ns** | **0.0284** |      **-** |     **-** |     **264 B** |
 'Creating Using Constructor' |              50 |     72.30 ns |   0.274 ns |   0.256 ns |     72.28 ns | 0.0494 |      - |     - |     456 B |
 'Creating Using Constructor' |             100 |    103.09 ns |   0.345 ns |   0.306 ns |    103.11 ns | 0.0917 | 0.0001 |     - |     856 B |
 'Creating Using Constructor' |             250 |    217.67 ns |   2.423 ns |   2.266 ns |    218.42 ns | 0.2248 | 0.0010 |     - |    2064 B |
       **'Creating Using for()'** |              **25** |    **280.62 ns** |   **2.039 ns** |   **1.907 ns** |    **280.16 ns** | **0.0753** |      **-** |     **-** |     **704 B** |
       'Creating Using for()' |              50 |    488.67 ns |   2.738 ns |   2.561 ns |    488.89 ns | 0.1326 |      - |     - |    1240 B |
       'Creating Using for()' |             100 |    818.76 ns |   8.771 ns |   8.204 ns |    812.97 ns | 0.2460 |      - |     - |    2288 B |
       'Creating Using for()' |             250 |  1,619.80 ns |   4.269 ns |   3.333 ns |  1,620.66 ns | 0.4673 | 0.0019 |     - |    4360 B |
     **'Looping with ForEach()'** |              **25** |    **101.55 ns** |   **0.647 ns** |   **0.606 ns** |    **101.64 ns** | **0.0068** |      **-** |     **-** |      **64 B** |
     'Looping with ForEach()' |              50 |    185.22 ns |   0.596 ns |   0.529 ns |    185.03 ns | 0.0067 |      - |     - |      64 B |
     'Looping with ForEach()' |             100 |    329.26 ns |   0.839 ns |   0.701 ns |    329.28 ns | 0.0067 |      - |     - |      64 B |
     'Looping with ForEach()' |             250 |    794.53 ns |   1.252 ns |   1.171 ns |    794.37 ns | 0.0067 |      - |     - |      64 B |
                       **Sort()** |              **25** |  **3,044.20 ns** |   **3.074 ns** |   **2.725 ns** |  **3,043.31 ns** |      **-** |      **-** |     **-** |         **-** |
                       Sort() |              50 |  8,672.08 ns |  16.895 ns |  14.977 ns |  8,669.51 ns |      - |      - |     - |         - |
                       Sort() |             100 | 23,477.71 ns |  57.975 ns |  48.411 ns | 23,463.07 ns |      - |      - |     - |         - |
                       Sort() |             250 | 72,831.10 ns | 130.977 ns | 122.516 ns | 72,825.04 ns |      - |      - |     - |         - |
  **'Sort(delegate) on Country'** |              **25** |  **2,921.27 ns** |   **2.372 ns** |   **2.102 ns** |  **2,920.20 ns** |      **-** |      **-** |     **-** |         **-** |
  'Sort(delegate) on Country' |              50 |  8,521.52 ns |  10.518 ns |   9.324 ns |  8,522.49 ns |      - |      - |     - |         - |
  'Sort(delegate) on Country' |             100 | 21,483.53 ns |  21.029 ns |  17.561 ns | 21,482.45 ns |      - |      - |     - |         - |
  'Sort(delegate) on Country' |             250 | 72,656.39 ns | 134.499 ns | 112.313 ns | 72,615.81 ns |      - |      - |     - |         - |
