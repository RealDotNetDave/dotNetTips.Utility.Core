
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
  Job-QYQXQL : .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=CollectionExtensions  

            Method | CollectionCount |            Mean |        Error |       StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
------------------ |---------------- |----------------:|-------------:|-------------:|--------:|-------:|------:|----------:|
          **AddRange** |              **25** |   **117,839.67 ns** |   **240.917 ns** |   **225.354 ns** |  **2.4414** |      **-** |     **-** |   **23416 B** |
          AddRange |              50 |   236,556.49 ns |   337.777 ns |   315.957 ns |  4.6387 |      - |     - |   45976 B |
          AddRange |             100 |   473,932.65 ns | 1,160.281 ns | 1,085.328 ns |  9.2773 |      - |     - |   91112 B |
          AddRange |             250 | 1,195,265.52 ns | 5,692.907 ns | 5,325.149 ns | 23.4375 |      - |     - |  225963 B |
           **FastAny** |              **25** |       **514.22 ns** |     **2.415 ns** |     **2.259 ns** |  **0.0038** |      **-** |     **-** |      **40 B** |
           FastAny |              50 |     1,072.96 ns |    13.591 ns |    12.713 ns |  0.0038 |      - |     - |      40 B |
           FastAny |             100 |     2,274.11 ns |     5.879 ns |     5.211 ns |  0.0038 |      - |     - |      40 B |
           FastAny |             250 |     5,404.57 ns |     3.432 ns |     3.042 ns |       - |      - |     - |      40 B |
         **FastCount** |              **25** |       **305.49 ns** |     **1.183 ns** |     **0.988 ns** |       **-** |      **-** |     **-** |         **-** |
         FastCount |              50 |       637.17 ns |     3.009 ns |     2.667 ns |       - |      - |     - |         - |
         FastCount |             100 |     1,272.67 ns |     5.623 ns |     4.696 ns |       - |      - |     - |         - |
         FastCount |             250 |     3,598.33 ns |    40.551 ns |    35.947 ns |       - |      - |     - |         - |
          **HasItems** |              **25** |        **12.39 ns** |     **0.013 ns** |     **0.012 ns** |       **-** |      **-** |     **-** |         **-** |
          HasItems |              50 |        12.56 ns |     0.013 ns |     0.011 ns |       - |      - |     - |         - |
          HasItems |             100 |        12.43 ns |     0.028 ns |     0.025 ns |       - |      - |     - |         - |
          HasItems |             250 |        20.97 ns |     0.095 ns |     0.089 ns |       - |      - |     - |         - |
        **PickRandom** |              **25** |        **34.32 ns** |     **0.190 ns** |     **0.178 ns** |  **0.0094** |      **-** |     **-** |      **88 B** |
        PickRandom |              50 |        34.32 ns |     0.226 ns |     0.212 ns |  0.0094 |      - |     - |      88 B |
        PickRandom |             100 |        34.62 ns |     0.485 ns |     0.453 ns |  0.0093 |      - |     - |      88 B |
        PickRandom |             250 |        34.85 ns |     0.264 ns |     0.247 ns |  0.0094 |      - |     - |      88 B |
         **Randomize** |              **25** |        **20.67 ns** |     **0.308 ns** |     **0.288 ns** |  **0.0059** |      **-** |     **-** |      **56 B** |
         Randomize |              50 |        20.82 ns |     0.076 ns |     0.071 ns |  0.0060 |      - |     - |      56 B |
         Randomize |             100 |        20.43 ns |     0.091 ns |     0.085 ns |  0.0060 |      - |     - |      56 B |
         Randomize |             250 |        20.40 ns |     0.113 ns |     0.105 ns |  0.0060 |      - |     - |      56 B |
 **ToDelimitedString** |              **25** |     **1,132.99 ns** |     **3.008 ns** |     **2.814 ns** |  **0.5493** | **0.0038** |     **-** |    **5152 B** |
 ToDelimitedString |              50 |     2,057.42 ns |    11.522 ns |    10.777 ns |  1.0300 | 0.0114 |     - |    9720 B |
 ToDelimitedString |             100 |     3,985.60 ns |    12.254 ns |    10.863 ns |  1.9913 | 0.0381 |     - |   18792 B |
 ToDelimitedString |             250 |    10,085.09 ns |    53.954 ns |    50.469 ns |  5.7068 | 0.3662 |     - |   57824 B |
