``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  Job-HTSMCU : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Namespace=dotNetTips.Utility.Benchmarks.IO  Categories=DriveHelper  

```
|             Method |     Mean |    Error |   StdDev |   StdErr |      Min |       Q1 |   Median |       Q3 |      Max |     Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|------:|------:|----------:|
|     **GetFixedDrives** | **31.20 μs** | **0.225 μs** | **0.211 μs** | **0.054 μs** | **30.47 μs** | **31.20 μs** | **31.23 μs** | **31.29 μs** | **31.36 μs** | **32,056.2** |      **0.2253 μs** |      **15.00** |    **9.500** |  **2.000** |  **-2.6677** |    **2** |            ***** |       **No** |     **230 B** | **0.0610** |     **-** |     **-** |     **680 B** |
| **GetRemovableDrives** | **30.48 μs** | **0.055 μs** | **0.048 μs** | **0.013 μs** | **30.38 μs** | **30.44 μs** | **30.47 μs** | **30.51 μs** | **30.56 μs** | **32,813.1** |      **0.0546 μs** |      **14.00** |    **2.030** |  **2.000** |   **0.0204** |    **1** |            ***** |       **No** |     **230 B** | **0.0610** |     **-** |     **-** |     **680 B** |
