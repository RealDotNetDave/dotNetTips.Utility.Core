
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-UEOGOB : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DistinctConcurrentBag,GenericCollections  

                        Method | CollectionCount |        Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------------ |---------------- |------------:|----------:|----------:|-------:|------:|------:|----------:|
 **'Creating Using Constructor.'** |              **25** |  **6,260.9 ns** |  **15.89 ns** |  **12.41 ns** | **0.0076** |     **-** |     **-** |    **2192 B** |
 'Creating Using Constructor.' |              50 | 11,842.0 ns |  41.52 ns |  38.84 ns | 0.0153 |     - |     - |    4408 B |
 'Creating Using Constructor.' |             100 | 22,774.3 ns | 265.60 ns | 248.44 ns | 0.0305 |     - |     - |    9064 B |
 'Creating Using Constructor.' |             250 | 54,775.6 ns | 748.04 ns | 699.72 ns | 0.0610 |     - |     - |   19288 B |
   **'Creating Using ForEach().'** |              **25** |  **6,056.3 ns** |  **65.43 ns** |  **58.00 ns** |      **-** |     **-** |     **-** |    **1978 B** |
   'Creating Using ForEach().' |              50 | 12,110.9 ns |  63.37 ns |  59.28 ns |      - |     - |     - |    3994 B |
   'Creating Using ForEach().' |             100 | 22,753.9 ns | 183.41 ns | 162.58 ns | 0.0305 |     - |     - |    8232 B |
   'Creating Using ForEach().' |             250 | 55,334.6 ns | 153.39 ns | 135.97 ns | 0.0610 |     - |     - |   17256 B |
     **'Looping with foreach().'** |              **25** |    **292.0 ns** |   **2.97 ns** |   **2.48 ns** | **0.0277** |     **-** |     **-** |     **264 B** |
     'Looping with foreach().' |              50 |    537.0 ns |   2.44 ns |   2.29 ns | 0.0486 |     - |     - |     464 B |
     'Looping with foreach().' |             100 |    934.3 ns |  11.25 ns |  10.53 ns | 0.0925 |     - |     - |     864 B |
     'Looping with foreach().' |             250 |  2,223.0 ns |   4.26 ns |   3.32 ns | 0.2213 |     - |     - |    2064 B |
