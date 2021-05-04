``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.300-preview.21180.15
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  Job-SOGKAI : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Namespace=dotNetTips.Utility.Benchmarks.IO  Categories=DriveHelper  

```
|             Method |     Mean |    Error |   StdDev |   StdErr |      Min |       Q1 |   Median |       Q3 |      Max |     Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|------:|------:|----------:|
|     **GetFixedDrives** | **31.21 μs** | **0.226 μs** | **0.200 μs** | **0.054 μs** | **30.74 μs** | **31.16 μs** | **31.24 μs** | **31.37 μs** | **31.45 μs** | **32,037.7** |      **0.2261 μs** |      **14.00** |    **2.957** |  **2.000** |  **-0.8686** |    **1** |            ***** |       **No** |     **230 B** | **0.0610** |     **-** |     **-** |     **680 B** |
| **GetRemovableDrives** | **31.23 μs** | **0.127 μs** | **0.112 μs** | **0.030 μs** | **30.97 μs** | **31.16 μs** | **31.21 μs** | **31.31 μs** | **31.39 μs** | **32,016.9** |      **0.1267 μs** |      **14.00** |    **2.636** |  **2.000** |  **-0.5096** |    **1** |            ***** |       **No** |     **230 B** | **0.0610** |     **-** |     **-** |     **680 B** |
