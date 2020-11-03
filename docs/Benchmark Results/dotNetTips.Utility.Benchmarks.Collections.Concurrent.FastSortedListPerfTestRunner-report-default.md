
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=FastSortedList,GenericCollections  

                       Method | CollectionCount |          Mean |        Error |       StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
----------------------------- |---------------- |--------------:|-------------:|-------------:|-------:|-------:|------:|----------:|
 **'Creating Using Constructor'** |              **25** |      **46.98 ns** |     **0.686 ns** |     **0.642 ns** | **0.0279** |      **-** |     **-** |     **264 B** |
 'Creating Using Constructor' |              50 |      67.62 ns |     0.296 ns |     0.277 ns | 0.0490 |      - |     - |     464 B |
 'Creating Using Constructor' |             100 |     102.56 ns |     1.009 ns |     0.944 ns | 0.0910 | 0.0002 |     - |     864 B |
 'Creating Using Constructor' |             250 |     215.63 ns |     2.190 ns |     2.048 ns | 0.2182 | 0.0010 |     - |    2064 B |
 'Creating Using Constructor' |             500 |     394.61 ns |     6.806 ns |     6.366 ns | 0.4306 | 0.0057 |     - |    4064 B |
 'Creating Using Constructor' |            1000 |     829.73 ns |     8.010 ns |     7.493 ns | 0.8535 |      - |     - |    8064 B |
       **'Creating Using for()'** |              **25** |     **256.13 ns** |     **0.609 ns** |     **0.540 ns** | **0.0749** |      **-** |     **-** |     **704 B** |
       'Creating Using for()' |              50 |     437.78 ns |     2.527 ns |     2.111 ns | 0.1311 |      - |     - |    1240 B |
       'Creating Using for()' |             100 |     791.18 ns |    15.532 ns |    17.887 ns | 0.2413 |      - |     - |    2288 B |
       'Creating Using for()' |             250 |   1,645.35 ns |     2.421 ns |     2.264 ns | 0.4578 | 0.0019 |     - |    4360 B |
       'Creating Using for()' |             500 |   3,258.79 ns |    65.066 ns |   103.201 ns | 0.9079 | 0.0038 |     - |    8480 B |
       'Creating Using for()' |            1000 |   6,348.20 ns |     8.203 ns |     7.272 ns | 1.8463 |      - |     - |   16696 B |
     **'Looping with ForEach()'** |              **25** |     **101.04 ns** |     **0.469 ns** |     **0.439 ns** | **0.0067** |      **-** |     **-** |      **64 B** |
     'Looping with ForEach()' |              50 |     185.57 ns |     2.449 ns |     2.291 ns | 0.0067 |      - |     - |      64 B |
     'Looping with ForEach()' |             100 |     385.23 ns |     5.075 ns |     4.748 ns | 0.0067 |      - |     - |      64 B |
     'Looping with ForEach()' |             250 |     798.68 ns |     0.682 ns |     0.604 ns | 0.0067 |      - |     - |      64 B |
     'Looping with ForEach()' |             500 |   1,474.67 ns |    12.995 ns |    12.155 ns | 0.0057 |      - |     - |      64 B |
     'Looping with ForEach()' |            1000 |   3,586.65 ns |    48.848 ns |    94.113 ns | 0.0038 |      - |     - |      64 B |
                       **Sort()** |              **25** |     **880.31 ns** |    **14.557 ns** |    **13.617 ns** |      **-** |      **-** |     **-** |         **-** |
                       Sort() |              50 |   2,491.96 ns |     5.393 ns |     4.781 ns |      - |      - |     - |         - |
                       Sort() |             100 |   6,831.60 ns |    99.384 ns |    92.963 ns |      - |      - |     - |         - |
                       Sort() |             250 |  21,617.17 ns |    32.169 ns |    30.091 ns |      - |      - |     - |         - |
                       Sort() |             500 | 121,702.08 ns | 1,347.123 ns | 1,194.189 ns |      - |      - |     - |       1 B |
                       Sort() |            1000 | 152,153.45 ns |   275.307 ns |   244.052 ns |      - |      - |     - |         - |
  **'Sort(delegate) on Country'** |              **25** |   **3,037.18 ns** |    **44.257 ns** |    **41.398 ns** |      **-** |      **-** |     **-** |         **-** |
  'Sort(delegate) on Country' |              50 |   8,819.89 ns |   105.602 ns |    98.781 ns |      - |      - |     - |         - |
  'Sort(delegate) on Country' |             100 |  24,377.47 ns |   345.544 ns |   323.222 ns |      - |      - |     - |         - |
  'Sort(delegate) on Country' |             250 |  77,064.87 ns |   899.477 ns |   841.371 ns |      - |      - |     - |       1 B |
  'Sort(delegate) on Country' |             500 | 227,456.28 ns |   107.930 ns |    84.264 ns |      - |      - |     - |       1 B |
  'Sort(delegate) on Country' |            1000 | 499,029.29 ns | 2,454.085 ns | 2,049.272 ns |      - |      - |     - |       5 B |
