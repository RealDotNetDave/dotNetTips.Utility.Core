{noformat}

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.300-preview.21180.15
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  Job-SOGKAI : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Namespace=dotNetTips.Utility.Benchmarks.Extensions  Categories=StringBuilderExtensions  

{noformat}
||           Method ||    Mean ||   Error ||  StdDev ||  StdErr ||     Min ||      Q1 ||  Median ||      Q3 ||     Max ||    Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 || Gen 1 ||Gen 2 ||Allocated ||Code Size ||
|       *AppendBytes* | *48.76 μs* | *0.510 μs* | *0.477 μs* | *0.123 μs* | *48.14 μs* | *48.37 μs* | *48.52 μs* | *49.12 μs* | *49.64 μs* | *20,509.9* |      *0.5103 μs* |      *15.00* |    *1.604* |  *2.000* |   *0.4276* |    *1* |            *** |       *No* | *4.9438* | *0.0610* |     *-* |  *45.69 KB* |    *0.9 KB* |
|        *AppendJoin* | *51.13 μs* | *0.226 μs* | *0.200 μs* | *0.053 μs* | *50.58 μs* | *51.10 μs* | *51.20 μs* | *51.27 μs* | *51.30 μs* | *19,556.7* |      *0.2258 μs* |      *14.00* |    *4.639* |  *2.000* |  *-1.5554* |    *2* |            *** |       *No* | *5.1880* | *0.1221* |     *-* |   *47.6 KB* |   *0.98 KB* |
| *AppendJoin:Params* | *51.94 μs* | *0.178 μs* | *0.166 μs* | *0.043 μs* | *51.57 μs* | *51.82 μs* | *51.96 μs* | *52.04 μs* | *52.23 μs* | *19,253.1* |      *0.1777 μs* |      *15.00* |    *2.685* |  *2.000* |  *-0.4909* |    *3* |            *** |       *No* | *5.1880* | *0.0610* |     *-* |   *47.6 KB* |   *0.98 KB* |
