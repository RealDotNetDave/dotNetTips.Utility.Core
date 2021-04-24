
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  Job-HTSMCU : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Namespace=dotNetTips.Utility.Benchmarks.IO  Categories=FileProcessor  

        Method |     Mean |    Error |   StdDev |   StdErr |   Median |      Min |       Q1 |       Q3 |      Max |  Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |   Gen 0 | Gen 1 | Gen 2 |  Allocated |
-------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|--------:|------:|------:|-----------:|
     **CopyFiles** | **64.12 ms** | **1.264 ms** | **2.436 ms** | **0.359 ms** | **63.86 ms** | **59.49 ms** | **62.32 ms** | **65.32 ms** | **69.70 ms** | **15.60** |      **1.2644 ms** |      **46.00** |    **2.716** |  **3.222** |   **0.6326** |    **2** |            ***** |       **No** |    **2.5 KB** |       **-** |     **-** |     **-** |  **141.98 KB** |
   **DeleteFiles** | **45.71 ms** | **1.545 ms** | **4.555 ms** | **0.456 ms** | **43.44 ms** | **40.98 ms** | **42.21 ms** | **49.81 ms** | **56.56 ms** | **21.88** |      **1.5449 ms** |     **100.00** |    **2.276** |  **2.627** |   **0.8980** |    **1** |            ***** |       **No** |   **1.64 KB** | **76.9231** |     **-** |     **-** | **1025.44 KB** |
 **DeleteFolders** | **43.07 ms** | **0.560 ms** | **0.550 ms** | **0.138 ms** | **42.86 ms** | **42.43 ms** | **42.73 ms** | **43.34 ms** | **44.38 ms** | **23.22** |      **0.5604 ms** |      **16.00** |    **2.726** |  **2.000** |   **0.8503** |    **1** |            ***** |       **No** |   **2.27 KB** |       **-** |     **-** |     **-** |  **111.31 KB** |
