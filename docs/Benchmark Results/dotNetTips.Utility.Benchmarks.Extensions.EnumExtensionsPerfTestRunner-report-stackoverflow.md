
    BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
    Unknown processor
    .NET Core SDK=5.0.200-preview.21079.7
      [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
      Job-HTSMCU : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT

    EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
    Namespace=dotNetTips.Utility.Benchmarks.Extensions  Categories=EnumExtensions  

             Method |       Mean |    Error |   StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |  Gen 0 | Gen 1 | Gen 2 | Allocated |
    --------------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|-------:|------:|------:|----------:|
     **GetDescription** |   **319.7 ns** |  **2.31 ns** |  **2.16 ns** | **0.56 ns** |   **313.8 ns** |   **318.6 ns** |   **320.3 ns** |   **321.1 ns** |   **322.1 ns** | **3,128,257.6** |       **2.305 ns** |      **15.00** |    **3.947** |  **2.000** |  **-1.1685** |    **1** |            ***** |       **No** |     **329 B** | **0.0024** |     **-** |     **-** |      **24 B** |
           **GetItems** | **4,333.2 ns** | **35.84 ns** | **33.52 ns** | **8.66 ns** | **4,283.2 ns** | **4,309.4 ns** | **4,340.4 ns** | **4,348.3 ns** | **4,397.3 ns** |   **230,776.8** |      **35.840 ns** |      **15.00** |    **2.043** |  **2.000** |   **0.2556** |    **2** |            ***** |       **No** |     **449 B** | **0.0916** |     **-** |     **-** |     **872 B** |
