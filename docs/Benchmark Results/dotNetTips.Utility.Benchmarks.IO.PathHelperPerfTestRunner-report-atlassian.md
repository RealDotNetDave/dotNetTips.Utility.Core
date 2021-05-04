{noformat}

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.300-preview.21180.15
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  Job-SOGKAI : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Namespace=dotNetTips.Utility.Benchmarks.IO  Categories=PathHelper  

{noformat}
||               Method ||    Mean ||  Error || StdDev || StdErr ||     Min ||      Q1 ||  Median ||      Q3 ||     Max ||       Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size || Gen 0 ||Gen 1 ||Gen 2 ||Allocated ||
|   *EnsureTrailingSlash* | *182.6 ns* | *0.63 ns* | *0.56 ns* | *0.15 ns* | *181.7 ns* | *182.3 ns* | *182.6 ns* | *183.0 ns* | *183.7 ns* | *5,476,603.1* |      *0.6321 ns* |      *14.00* |    *2.084* |  *2.000* |   *0.1656* |    *2* |            *** |       *No* |     *463 B* | *0.0806* |     *-* |     *-* |     *760 B* |
| *HasInvalidFilterChars* | *882.3 ns* | *4.49 ns* | *3.75 ns* | *1.04 ns* | *870.7 ns* | *882.4 ns* | *883.0 ns* | *883.5 ns* | *886.7 ns* | *1,133,387.2* |      *4.4893 ns* |      *13.00* |    *7.136* |  *2.000* |  *-2.0918* |    *4* |            *** |       *No* |     *259 B* | *0.0610* |     *-* |     *-* |     *568 B* |
|  *PathContainsWildcard* | *152.9 ns* | *0.53 ns* | *0.50 ns* | *0.13 ns* | *152.4 ns* | *152.6 ns* | *152.7 ns* | *153.2 ns* | *153.9 ns* | *6,538,406.8* |      *0.5305 ns* |      *15.00* |    *1.853* |  *2.000* |   *0.5334* |    *1* |            *** |       *No* |     *461 B* | *0.0386* |     *-* |     *-* |     *368 B* |
|   *PathHasInvalidChars* | *734.2 ns* | *2.02 ns* | *1.89 ns* | *0.49 ns* | *731.3 ns* | *732.6 ns* | *734.3 ns* | *735.5 ns* | *737.4 ns* | *1,362,032.0* |      *2.0216 ns* |      *15.00* |    *1.761* |  *2.000* |   *0.0511* |    *3* |            *** |       *No* |     *422 B* | *0.0925* |     *-* |     *-* |     *864 B* |
