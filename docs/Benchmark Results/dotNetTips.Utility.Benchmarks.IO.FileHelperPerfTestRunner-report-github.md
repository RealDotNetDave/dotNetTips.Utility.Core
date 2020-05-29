``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.300
  [Host]     : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT
  Job-LAEGID : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FileHelper  

```
|        Method |      Mean |     Error |    StdDev |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------- |----------:|----------:|----------:|---------:|------:|------:|----------:|
|      **CopyFile** |  **1.326 ms** | **0.0261 ms** | **0.0330 ms** |   **3.9063** |     **-** |     **-** |  **37.74 KB** |
| **CopyFileAsync** |  **1.400 ms** | **0.0205 ms** | **0.0192 ms** |   **3.9063** |     **-** |     **-** |     **39 KB** |
|   **DeleteFiles** | **49.214 ms** | **0.9819 ms** | **2.1346 ms** | **100.0000** |     **-** |     **-** | **985.17 KB** |
|      **MoveFile** |  **1.615 ms** | **0.0322 ms** | **0.0746 ms** |        **-** |     **-** |     **-** |  **14.16 KB** |
