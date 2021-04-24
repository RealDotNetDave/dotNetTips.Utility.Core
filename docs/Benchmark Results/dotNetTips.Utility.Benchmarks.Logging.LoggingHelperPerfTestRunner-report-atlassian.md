{noformat}

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  Job-HTSMCU : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Namespace=dotNetTips.Utility.Benchmarks.Logging  Categories=LoggingHelper  

{noformat}
||                      Method ||    Mean ||  Error || StdDev || StdErr ||     Min ||      Q1 ||  Median ||      Q3 ||     Max ||       Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size || Gen 0 ||Gen 1 ||Gen 2 ||Allocated ||
| *RetrieveAllExceptionMessages* | *688.3 ns* | *8.26 ns* | *7.72 ns* | *1.99 ns* | *675.8 ns* | *683.6 ns* | *686.8 ns* | *692.6 ns* | *705.9 ns* | *1,452,879.7* |       *8.257 ns* |      *15.00* |    *2.666* |  *2.000* |   *0.5214* |    *2* |            *** |       *No* |     *412 B* | *0.0868* |     *-* |     *-* |     *824 B* |
|        *RetrieveAllExceptions* | *298.4 ns* | *1.82 ns* | *1.42 ns* | *0.41 ns* | *297.1 ns* | *297.5 ns* | *298.1 ns* | *298.6 ns* | *302.4 ns* | *3,351,057.1* |       *1.816 ns* |      *12.00* |    *5.438* |  *2.000* |   *1.7506* |    *1* |            *** |       *No* |    *1830 B* | *0.0563* |     *-* |     *-* |     *528 B* |
