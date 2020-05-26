``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Unknown processor
.NET Core SDK=3.1.200
  [Host] : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=CollectionExtensions  

```
|         Method | CollectionCount | Mean | Error |
|--------------- |---------------- |-----:|------:|
| AddIfNotExists |              25 |   NA |    NA |

Benchmarks with issues:
  CollectionExtensionsPerfTestRunner.AddIfNotExists: Job-KHIYCC(EvaluateOverhead=True, Server=True, Toolchain=.NET Core 3.0) [CollectionCount=25]
