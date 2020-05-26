``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.200
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  Job-KHIYCC : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=Services  

```
|        Method |       Mean |   Error |  StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|-------------- |-----------:|--------:|--------:|-------:|-------:|------:|----------:|
|   **AllServices** | **1,005.4 us** | **9.40 us** | **8.33 us** | **9.7656** | **3.9063** |     **-** | **103.52 KB** |
| **ServiceExists** |   **999.4 us** | **1.57 us** | **1.31 us** | **9.7656** | **3.9063** |     **-** | **103.59 KB** |
| **ServiceStatus** |   **994.6 us** | **5.56 us** | **4.65 us** | **9.7656** | **3.9063** |     **-** | **103.59 KB** |
