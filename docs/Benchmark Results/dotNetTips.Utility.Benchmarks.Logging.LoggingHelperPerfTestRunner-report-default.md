
BenchmarkDotNet=v0.11.5.1191-nightly, OS=Windows 10.0.17763.775 (1809/October2018Update/Redstone5)
Unknown processor
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-RGRUUZ : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=LoggingHelper  

                       Method |     Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
----------------------------- |---------:|----------:|----------:|-------:|------:|------:|----------:|
 **RetrieveAllExceptionMessages** | **2.881 us** | **0.0107 us** | **0.0095 us** | **0.1183** |     **-** |     **-** |    **1120 B** |
        **RetrieveAllExceptions** | **1.734 us** | **0.0148 us** | **0.0139 us** | **0.0896** |     **-** |     **-** |     **848 B** |
