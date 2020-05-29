``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.836 (1909/November2018Update/19H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.300
  [Host]     : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT
  Job-LAEGID : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 3.0  
Categories=StringExtensions  

```
|               Method |          Mean |       Error |      StdDev |        Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |--------------:|------------:|------------:|--------------:|-------:|------:|------:|----------:|
|    **ComputeSha256Hash** | **11,047.885 ns** | **290.1044 ns** | **855.3795 ns** | **10,765.823 ns** | **0.2899** |     **-** |     **-** |    **2760 B** |
|               **Concat** |    **782.155 ns** |  **29.6608 ns** |  **87.4554 ns** |    **745.278 ns** | **0.6399** |     **-** |     **-** |    **6064 B** |
|          **ContainsAny** |    **101.968 ns** |   **2.0852 ns** |   **5.3451 ns** |    **101.581 ns** | **0.0168** |     **-** |     **-** |     **160 B** |
|        **DefaultIfNull** |      **2.004 ns** |   **0.0826 ns** |   **0.1830 ns** |      **2.028 ns** |      **-** |     **-** |     **-** |         **-** |
| **DefaultIfNullOrEmpty** |      **2.202 ns** |   **0.0821 ns** |   **0.1178 ns** |      **2.205 ns** |      **-** |     **-** |     **-** |         **-** |
|             **HasValue** |      **8.954 ns** |   **0.2206 ns** |   **0.4701 ns** |      **8.954 ns** |      **-** |     **-** |     **-** |         **-** |
|               **Indent** |    **646.336 ns** |  **12.5862 ns** |  **34.0275 ns** |    **649.892 ns** | **0.4330** |     **-** |     **-** |    **4088 B** |
|      **ToTrimmedString** |    **310.242 ns** |   **6.2072 ns** |  **12.9568 ns** |    **311.276 ns** | **0.2069** |     **-** |     **-** |    **1960 B** |
