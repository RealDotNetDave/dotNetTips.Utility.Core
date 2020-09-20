``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Unknown processor
.NET Core SDK=5.0.100-preview.8.20417.9
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-RATGHQ : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=CollectionExtensions  

```
|                          Method | CollectionCount |        Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------- |---------------- |------------:|----------:|----------:|-------:|------:|------:|----------:|
|                  **AddFirst:Array** |              **25** | **6,793.69 ns** | **22.210 ns** | **20.775 ns** | **0.3357** |     **-** |     **-** |    **3179 B** |
| **&#39;AddIfNotExists:Dup Parm Array&#39;** |              **25** |          **NA** |        **NA** |        **NA** |      **-** |     **-** |     **-** |         **-** |
|     **&#39;AddIfNotExists:Parm Array&#39;** |              **25** |    **49.26 ns** |  **0.269 ns** |  **0.238 ns** | **0.0346** |     **-** |     **-** |     **328 B** |

Benchmarks with issues:
  CollectionExtensionsPerfTestRunner.'AddIfNotExists:Dup Parm Array': Job-RATGHQ(EvaluateOverhead=True, Server=True, Toolchain=.NET Core 3.0) [CollectionCount=25]
