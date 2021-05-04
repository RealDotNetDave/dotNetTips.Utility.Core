
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.300-preview.21180.15
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  Job-SOGKAI : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.1  
Namespace=dotNetTips.Utility.Benchmarks.IO  Categories=DirectoryHelper  

              Method |         Mean |       Error |      StdDev |    StdErr |          Min |           Q1 |       Median |           Q3 |          Max |      Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size |    Gen 0 | Gen 1 | Gen 2 | Allocated |
-------------------- |-------------:|------------:|------------:|----------:|-------------:|-------------:|-------------:|-------------:|-------------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|---------:|------:|------:|----------:|
           **LoadFiles** | **294,124.8 μs** | **2,671.17 μs** | **2,367.92 μs** | **632.85 μs** | **291,586.1 μs** | **292,214.5 μs** | **293,442.8 μs** | **295,863.3 μs** | **299,075.5 μs** |     **3.400** |   **2,671.166 μs** |      **14.00** |    **2.063** |  **2.000** |   **0.6615** |    **3** |            ***** |       **No** |    **2887 B** |        **-** |     **-** |     **-** | **5040016 B** |
      **LoadFilesAsync** |           **NA** |          **NA** |          **NA** |        **NA** |           **NA** |           **NA** |           **NA** |           **NA** |           **NA** |        **NA** |             **NA** |         **NA** |       **NA** |     **NA** |       **NA** |    **?** |            ***** |       **No** |         **-** |        **-** |     **-** |     **-** |         **-** |
 **SafeDirectorySearch** |     **888.6 μs** |     **4.15 μs** |     **3.68 μs** |   **0.98 μs** |     **880.7 μs** |     **887.0 μs** |     **888.8 μs** |     **890.0 μs** |     **896.6 μs** | **1,125.339** |       **4.148 μs** |      **14.00** |    **3.339** |  **2.000** |   **0.0339** |    **1** |            ***** |       **No** |    **1796 B** |        **-** |     **-** |     **-** |     **761 B** |
      **SafeFileSearch** |  **90,541.5 μs** |   **529.31 μs** |   **469.22 μs** | **125.40 μs** |  **89,171.3 μs** |  **90,412.7 μs** |  **90,609.4 μs** |  **90,781.2 μs** |  **91,166.9 μs** |    **11.045** |     **529.306 μs** |      **14.00** |    **5.506** |  **2.000** |  **-1.5408** |    **2** |            ***** |       **No** |    **1058 B** | **166.6667** |     **-** |     **-** | **2092315 B** |

Benchmarks with issues:
  DirectoryHelperPerfTestRunner.LoadFilesAsync: Job-SOGKAI(EvaluateOverhead=True, Server=True, Toolchain=.NET Core 3.1)
