{noformat}

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.300-preview.21180.15
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  Job-SOGKAI : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Namespace=dotNetTips.Utility.Benchmarks.Extensions  Categories=EnumExtensions  

{noformat}
||        Method ||      Mean ||   Error ||  StdDev || StdErr ||       Min ||        Q1 ||    Median ||        Q3 ||       Max ||       Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size || Gen 0 ||Gen 1 ||Gen 2 ||Allocated ||
| *GetDescription* |   *330.0 ns* |  *1.36 ns* |  *1.21 ns* | *0.32 ns* |   *326.4 ns* |   *329.9 ns* |   *330.1 ns* |   *330.3 ns* |   *331.8 ns* | *3,030,380.2* |       *1.361 ns* |      *14.00* |    *6.009* |  *2.000* |  *-1.5699* |    *1* |            *** |       *No* |     *329 B* | *0.0024* |     *-* |     *-* |      *24 B* |
|       *GetItems* | *4,577.2 ns* | *16.60 ns* | *13.86 ns* | *3.85 ns* | *4,558.9 ns* | *4,566.3 ns* | *4,576.9 ns* | *4,583.0 ns* | *4,611.2 ns* |   *218,473.8* |      *16.603 ns* |      *13.00* |    *3.268* |  *2.000* |   *0.8156* |    *2* |            *** |       *No* |     *449 B* | *0.0916* |     *-* |     *-* |     *872 B* |
