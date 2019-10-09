``` ini

BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=DirectoryHelper  

```
|              Method |     Mean |    Error |   StdDev |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |---------:|---------:|---------:|--------:|------:|------:|----------:|
|           **LoadFiles** | **34.03 ms** | **0.378 ms** | **0.354 ms** | **66.6667** |     **-** |     **-** | **1256188 B** |
|      **LoadFilesAsync** | **36.02 ms** | **0.270 ms** | **0.252 ms** | **71.4286** |     **-** |     **-** | **1155629 B** |
| **SafeDirectorySearch** | **42.63 ms** | **0.272 ms** | **0.241 ms** |       **-** |     **-** |     **-** |     **760 B** |
