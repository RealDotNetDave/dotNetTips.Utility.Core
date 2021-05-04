{noformat}

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.300-preview.21180.15
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  Job-SOGKAI : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Namespace=dotNetTips.Utility.Benchmarks.Extensions  Categories=ExceptionExtensions  

{noformat}
||        Method ||    Mean ||  Error || StdDev || StdErr ||     Min ||      Q1 ||  Median ||      Q3 ||     Max ||       Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size || Gen 0 ||Gen 1 ||Gen 2 ||Allocated ||
| GetAllMessages | 290.4 ns | 2.25 ns | 2.11 ns | 0.54 ns | 287.9 ns | 288.2 ns | 291.1 ns | 292.2 ns | 293.5 ns | 3,443,513.4 |       2.252 ns |      15.00 |    1.244 |  2.000 |   0.0556 |    1 |            * |       No |     766 B | 0.0887 |     - |     - |     840 B |
