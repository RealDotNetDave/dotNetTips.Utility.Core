
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.300-preview.21180.15
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  Job-SOGKAI : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Namespace=dotNetTips.Utility.Benchmarks.Security  Categories=EncryptionHelper  

        Method |     Mean |     Error |    StdDev |    StdErr |      Min |       Q1 |   Median |       Q3 |      Max |      Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
-------------- |---------:|----------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|-------:|------:|----------:|
 AesEncryption | 8.642 μs | 0.0647 μs | 0.0505 μs | 0.0146 μs | 8.523 μs | 8.649 μs | 8.660 μs | 8.669 μs | 8.680 μs | 115,707.4 |      0.0647 μs |      12.00 |    3.491 |  2.000 |   -1.442 |    1 |            * |       No |   2.62 KB | 2.0294 | 0.0153 |     - |  18.84 KB |
