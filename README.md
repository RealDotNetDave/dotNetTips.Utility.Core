# Welcome to dotNetTips.Utility for .NET Core & .NET Standard

![dotNetTips.com](docs/Graphics/2020%20-%20dotNetTips%20-%20KLOS@0.25x.png)

This repository is for the dotNetTips.Utility code for .NET Core & .NET Standard (formerly in a different repository).

Much of this code is documented on <a href="https://dotnettips.wordpress.com/tag/dotnettips-utility/" target="_blank">dotNetTips.com</a>.

## Projects
![Assembly Layout](docs/Graphics/Assembly%20Layout.jpg)
Below is the list of current projects in this repository
### .NET Core
*  	[dotNetTips.Utility.Core.EntityFramework][1] (preview): Common code for Entity Framework Core.
*   [dotNetTips.Utility.Core.Windows][2]: Common code for Windows.
### .NET Standard
*   [dotNetTips.Utility.Standard][3]: Main assembly for common code.
*   dotNetTips.Utility.Standard.Common: Common code used in all the other .NET Core and .NET Standard assemblies.
*   [dotNetTips.Utility.Standard.Extensions][4]: Common extension methods.
*   [dotNetTips.Utility.Standard.Tester][5]: Code for use in unit tests/ benchmarks. For article and video on how to use this assembly, go to: [https://dotnettips.wordpress.com/2020/03/27/unit-testing-with-random-data](https://dotnettips.wordpress.com/2020/03/27/unit-testing-with-random-data)

## Benchmark Tests
Here are the results from the current benchmark tests that takes over 3 hours to run:

* [App][6]
* [Collections.DistinctBlockingCollection<T>][7]
* [Collections.Generic.Concurrent.ConcurrentHashSet<T>][8]
* [Collections.Generic.Concurrent.DistinctBlockingCollection][9]
* [Collections.Generic.Concurrent.DistinctConcurrentBag<T>][10]
* [Collections.Generic.FastSortedList<T>][11]
* [Devices.Clock][12]
* [Extensions.CollectionExtensions][13]
* [Extensions.ExceptionExtensions][14]
* [Extensions.EnumExtensions][15]
* [Extensions.ObjectExtensions][16]
* [Extensions.StringBuilderExtensions][17]
* [Extensions.StringExtensions][18]
* [IO.DirectoryHelper][19]
* [IO.DriveHelper][20]
* [IO.FileHelper][21]
* [IO.FileProcessor][22]
* [IO.PathHelper][23]
* [Logging.LoggingHelper][24]
* [Security.EncryptionHelper][25]
* [Security.SecurityHelper][26]
* [Serializer.JsonSerializer][27]
* [Services][28]
* [TypeHelper][29]
* [Xml.XmlHelper][30]

## Your Support Is Needed
Do you have code you would like to submit to these repositories? Submit a pull request or submit an issue. I promise to take a look and include it if I like it!

  [1]: https://github.com/RealDotNetDave/dotNetTips.Utility.Core/tree/master/src/Core/dotNetTips.Utility.Core.EntityFramework
  [2]: https://github.com/RealDotNetDave/dotNetTips.Utility.Core/tree/master/src/Core/dotNetTips.Utility.Core.Windows
  [3]: https://github.com/RealDotNetDave/dotNetTips.Utility.Core/tree/master/src/Standard/dotNetTips.Utility.Standard
  [4]: https://github.com/RealDotNetDave/dotNetTips.Utility.Core/tree/master/src/Standard/dotNetTips.Utility.Standard.Extensions
  [5]: https://github.com/RealDotNetDave/dotNetTips.Utility.Core/tree/master/src/Standard/dotNetTips.Utility.Standard.Tester
  [6]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.AppPerfTestRunner-report-github.md
  [7]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner-report-github.md
  [8]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner-report-github.md
  [9]: docs%2FBenchmark%2520Results%2FdotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner-report-github.md
  [10]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner-report-github.md
  [11]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner-report-github.md
  [12]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Devices.ClockPerfTestRunner-report-github.md
  [13]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Extensions.CollectionExtensionsPerfTestRunner-report-github.md
  [14]: docs/Benchmark%20Results/dotNetTips.Utility.Benchmarks.Extensions.ExceptionExtensionsPerfTestRunner-report-github.md
  [15]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Extensions.EnumExtensionsPerfTestRunner-report-github.md
  [16]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Extensions.ObjectExtensionsPerfTestRunner-report-github.md
  [17]: docs/Benchmark%20Results/dotNetTips.Utility.Benchmarks.Extensions.StringBuilderExtensionsPerfTestRunner-report-github.md
  [18]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner-report-github.md
  [19]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.IO.DirectoryHelperPerfTestRunner-report-github.md
  [20]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.IO.DriveHelperPerfTestRunner-report-github.md
  [21]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.IO.FileHelperPerfTestRunner-report-github.md
  [22]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.IO.FileProcessorPerfTestRunner-report-github.md
  [23]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.IO.PathHelperPerfTestRunner-report-github.md
  [24]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Logging.LoggingHelperPerfTestRunner-report-github.md
  [25]: docs/Benchmark%20Results/dotNetTips.Utility.Benchmarks.Security.EncryptionHelperPerfTestRunner-report-github.md
  [26]: docs/Benchmark%20Results/dotNetTips.Utility.Benchmarks.Security.SecurityHelperPerfTestRunner-report-github.md
  [27]: docs/Benchmark%20Results/dotNetTips.Utility.Benchmarks.Serialization.JsonSerializerPerfTestRunner-report-github.md
  [28]: docs/Benchmark%20Results/dotNetTips.Utility.Benchmarks.ServicesPerfTestRunner-report-github.md
  [29]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.TypeHelperPerfTestRunner-report-github.md
  [30]: docs/Benchmark%20Results/dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner-report-github.md
