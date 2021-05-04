
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.300-preview.21180.15
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  Job-SOGKAI : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Namespace=dotNetTips.Utility.Benchmarks.IO  Categories=FileProcessor  

        Method |     Mean |    Error |   StdDev |   StdErr |   Median |      Min |       Q1 |       Q3 |      Max |  Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |   Gen 0 | Gen 1 | Gen 2 |  Allocated |
-------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|--------:|------:|------:|-----------:|
     **CopyFiles** | **65.76 ms** | **1.300 ms** | **2.243 ms** | **0.364 ms** | **65.78 ms** | **60.65 ms** | **64.34 ms** | **67.13 ms** | **71.72 ms** | **15.21** |      **1.3003 ms** |      **38.00** |    **3.131** |  **2.000** |   **0.0481** |    **3** |            ***** |       **No** |    **2.5 KB** |       **-** |     **-** |     **-** |  **141.98 KB** |
   **DeleteFiles** | **38.17 ms** | **0.742 ms** | **1.500 ms** | **0.212 ms** | **37.89 ms** | **36.30 ms** | **37.08 ms** | **38.71 ms** | **41.91 ms** | **26.20** |      **0.7425 ms** |      **50.00** |    **3.285** |  **2.316** |   **1.0783** |    **1** |            ***** |       **No** |   **1.64 KB** | **76.9231** |     **-** |     **-** | **1025.44 KB** |
 **DeleteFolders** | **44.61 ms** | **0.888 ms** | **2.293 ms** | **0.260 ms** | **43.54 ms** | **41.78 ms** | **42.76 ms** | **46.72 ms** | **50.07 ms** | **22.42** |      **0.8884 ms** |      **78.00** |    **1.989** |  **2.880** |   **0.6663** |    **2** |            ***** |       **No** |   **2.27 KB** |       **-** |     **-** |     **-** |  **111.31 KB** |
