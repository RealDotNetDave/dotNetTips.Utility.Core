``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  Job-HTSMCU : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Namespace=dotNetTips.Utility.Benchmarks.Extensions  Categories=ExceptionExtensions  

```
|         Method |     Mean |   Error |  StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|------:|------:|----------:|
| GetAllMessages | 265.2 ns | 0.84 ns | 0.75 ns | 0.20 ns | 263.7 ns | 264.9 ns | 265.2 ns | 265.5 ns | 266.4 ns | 3,771,203.4 |      0.8408 ns |      14.00 |    2.491 |  2.000 |  -0.3470 |    1 |            * |       No |     766 B | 0.0892 |     - |     - |     840 B |
