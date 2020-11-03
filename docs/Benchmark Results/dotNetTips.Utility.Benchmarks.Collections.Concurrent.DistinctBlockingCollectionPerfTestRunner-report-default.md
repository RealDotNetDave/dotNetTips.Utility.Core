
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.572 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-rc.2.20479.15
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  Job-TZRVGS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Categories=DistinctBlockingCollection,GenericCollections  

                             Method | CollectionCount |          Mean |        Error |       StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
----------------------------------- |---------------- |--------------:|-------------:|-------------:|-------:|------:|------:|----------:|
      **'Creating Using Constructor.'** |              **25** |   **2,798.62 ns** |     **6.815 ns** |     **6.042 ns** | **0.1488** |     **-** |     **-** |    **1440 B** |
      'Creating Using Constructor.' |              50 |   5,155.68 ns |    49.184 ns |    43.600 ns | 0.1678 |     - |     - |    1632 B |
      'Creating Using Constructor.' |             100 |  10,672.77 ns |   206.109 ns |   237.355 ns | 0.2136 |     - |     - |    2040 B |
      'Creating Using Constructor.' |             250 |  24,586.63 ns |    54.836 ns |    51.294 ns | 0.3357 |     - |     - |    3240 B |
      'Creating Using Constructor.' |             500 |  49,474.02 ns |   325.087 ns |   304.087 ns | 0.5493 |     - |     - |    5232 B |
      'Creating Using Constructor.' |            1000 | 109,827.82 ns | 1,789.141 ns | 1,673.564 ns | 0.9766 |     - |     - |    9241 B |
            **'Creating Using for().'** |              **25** |   **2,635.44 ns** |     **4.420 ns** |     **3.918 ns** | **0.1259** |     **-** |     **-** |    **1208 B** |
            'Creating Using for().' |              50 |   5,206.80 ns |    43.885 ns |    41.050 ns | 0.1221 |     - |     - |    1208 B |
            'Creating Using for().' |             100 |  11,070.36 ns |    83.795 ns |   161.444 ns | 0.1221 |     - |     - |    1208 B |
            'Creating Using for().' |             250 |  24,777.54 ns |    60.964 ns |    57.026 ns | 0.1221 |     - |     - |    1208 B |
            'Creating Using for().' |             500 |  51,629.50 ns |   654.666 ns |   612.375 ns | 0.1221 |     - |     - |    1208 B |
            'Creating Using for().' |            1000 | 107,183.34 ns | 1,608.683 ns | 1,504.763 ns | 0.1221 |     - |     - |    1208 B |
          **'Looping with foreach().'** |              **25** |      **40.72 ns** |     **0.067 ns** |     **0.059 ns** | **0.0084** |     **-** |     **-** |      **80 B** |
          'Looping with foreach().' |              50 |      42.27 ns |     0.282 ns |     0.250 ns | 0.0084 |     - |     - |      80 B |
          'Looping with foreach().' |             100 |      43.26 ns |     0.196 ns |     0.174 ns | 0.0085 |     - |     - |      80 B |
          'Looping with foreach().' |             250 |      42.05 ns |     0.384 ns |     0.320 ns | 0.0084 |     - |     - |      80 B |
          'Looping with foreach().' |             500 |      42.29 ns |     0.571 ns |     0.534 ns | 0.0085 |     - |     - |      80 B |
          'Looping with foreach().' |            1000 |      42.20 ns |     0.315 ns |     0.279 ns | 0.0083 |     - |     - |      80 B |
 **'Looping with Parallel.ForEach().'** |              **25** |   **2,381.02 ns** |    **47.613 ns** |    **89.429 ns** | **0.6828** |     **-** |     **-** |    **5178 B** |
 'Looping with Parallel.ForEach().' |              50 |   2,415.22 ns |     7.203 ns |     6.738 ns | 0.6790 |     - |     - |    5177 B |
 'Looping with Parallel.ForEach().' |             100 |   2,241.50 ns |     4.512 ns |     4.220 ns | 0.7172 |     - |     - |    5168 B |
 'Looping with Parallel.ForEach().' |             250 |   2,249.48 ns |     3.406 ns |     3.019 ns | 0.6828 |     - |     - |    5170 B |
 'Looping with Parallel.ForEach().' |             500 |   2,416.93 ns |     7.788 ns |     7.285 ns | 0.6905 |     - |     - |    5175 B |
 'Looping with Parallel.ForEach().' |            1000 |   2,234.88 ns |     4.996 ns |     4.674 ns | 0.6981 |     - |     - |    5168 B |
