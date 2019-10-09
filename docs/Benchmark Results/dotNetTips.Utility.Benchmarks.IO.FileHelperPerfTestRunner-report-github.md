``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=FileHelper  

```
|        Method |        Mean |     Error |    StdDev |      Median |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------- |------------:|----------:|----------:|------------:|---------:|------:|------:|----------:|
|      **CopyFile** |    **901.4 us** |   **5.80 us** |   **4.85 us** |    **900.9 us** |   **2.9297** |     **-** |     **-** |  **37.74 KB** |
| **CopyFileAsync** |    **910.4 us** |  **17.95 us** |  **43.36 us** |    **915.4 us** |   **3.9063** |     **-** |     **-** |     **39 KB** |
|   **DeleteFiles** | **45,742.8 us** | **896.67 us** | **880.65 us** | **45,838.4 us** | **125.0000** |     **-** |     **-** | **983.96 KB** |
|      **MoveFile** |    **847.8 us** |  **17.84 us** |  **41.35 us** |    **833.4 us** |        **-** |     **-** |     **-** |  **14.16 KB** |
