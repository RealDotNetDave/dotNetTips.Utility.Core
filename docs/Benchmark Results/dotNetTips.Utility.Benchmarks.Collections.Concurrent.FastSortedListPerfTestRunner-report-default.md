
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FastSortedList,GenericCollections  

                       Method | CollectionCount |         Mean |      Error |     StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
----------------------------- |---------------- |-------------:|-----------:|-----------:|-------:|-------:|------:|----------:|
 **'Creating Using Constructor'** |              **25** |     **45.73 ns** |   **0.063 ns** |   **0.049 ns** | **0.0269** |      **-** |     **-** |     **256 B** |
 'Creating Using Constructor' |              50 |     65.80 ns |   0.215 ns |   0.201 ns | 0.0490 |      - |     - |     464 B |
 'Creating Using Constructor' |             100 |     99.55 ns |   0.373 ns |   0.349 ns | 0.0917 | 0.0001 |     - |     864 B |
 'Creating Using Constructor' |             250 |    213.02 ns |   3.181 ns |   2.975 ns | 0.2215 | 0.0012 |     - |    2064 B |
       **'Creating Using for()'** |              **25** |    **276.28 ns** |   **5.442 ns** |   **8.632 ns** | **0.0744** |      **-** |     **-** |     **704 B** |
       'Creating Using for()' |              50 |    444.30 ns |   1.363 ns |   1.138 ns | 0.1302 |      - |     - |    1240 B |
       'Creating Using for()' |             100 |    772.10 ns |   1.814 ns |   1.697 ns | 0.2413 |      - |     - |    2288 B |
       'Creating Using for()' |             250 |  1,682.53 ns |   3.241 ns |   3.031 ns | 0.4692 | 0.0038 |     - |    4360 B |
     **'Looping with ForEach()'** |              **25** |     **99.38 ns** |   **1.753 ns** |   **1.640 ns** | **0.0067** |      **-** |     **-** |      **64 B** |
     'Looping with ForEach()' |              50 |    186.13 ns |   0.430 ns |   0.403 ns | 0.0067 |      - |     - |      64 B |
     'Looping with ForEach()' |             100 |    371.73 ns |   7.446 ns |  18.264 ns | 0.0067 |      - |     - |      64 B |
     'Looping with ForEach()' |             250 |    796.69 ns |   1.448 ns |   1.354 ns | 0.0067 |      - |     - |      64 B |
                       **Sort()** |              **25** |  **3,212.05 ns** |   **4.010 ns** |   **3.555 ns** |      **-** |      **-** |     **-** |         **-** |
                       Sort() |              50 |  8,349.33 ns |  10.516 ns |   9.837 ns |      - |      - |     - |         - |
                       Sort() |             100 | 27,133.91 ns | 367.563 ns | 343.819 ns |      - |      - |     - |         - |
                       Sort() |             250 | 75,295.94 ns | 100.433 ns |  93.945 ns |      - |      - |     - |         - |
  **'Sort(delegate) on Country'** |              **25** |  **2,696.79 ns** |   **7.815 ns** |   **6.526 ns** |      **-** |      **-** |     **-** |         **-** |
  'Sort(delegate) on Country' |              50 |  8,146.88 ns |  13.240 ns |  12.385 ns |      - |      - |     - |         - |
  'Sort(delegate) on Country' |             100 | 22,392.01 ns |  20.165 ns |  17.876 ns |      - |      - |     - |         - |
  'Sort(delegate) on Country' |             250 | 67,890.73 ns |  73.707 ns |  65.339 ns |      - |      - |     - |         - |
