# Welcome to dotNetTips.Utility for .NET Core & .NET Standard

![dotNetTips.com](https://dotnettips.files.wordpress.com/2020/03/2020-dotnettips.com-logo-earth400.75x.png)
This repository is for the dotNetTips.Utility code for .NET Core & .NET Standard (formerly in a different repository).

Much of this code is documented on <a href="https://dotnettips.wordpress.com/tag/dotnettips-utility/" target="_blank">dotNetTips.com</a>.

## Projects
Below is the list of current projects in this repository:
### .NET Core
*  	[dotNetTips.Utility.Core.EntityFramework][1] (preview): Common code for Entity Framework Core.
*   [dotNetTips.Utility.Core.Windows][2]: Common code for Windows.
### .NET Standard
*   [dotNetTips.Utility.Standard][3]: Main assembly for common code.
*   [dotNetTips.Utility.Standard.Extensions][4]: Common extension methods.
*   [dotNetTips.Utility.Standard.Tester][5]: Code for use in unit tests/ benchmarks. For article and video on how to use this assembly, go to: [https://dotnettips.wordpress.com/2020/03/27/unit-testing-with-random-data](https://dotnettips.wordpress.com/2020/03/27/unit-testing-with-random-data)

## Benchmark Tests
Here are the results from the current benchmark tests:

* [App][6]
* [Collections.DistinctBlockingCollection<T>][7]
* [Collections.Generic.FastSortedList<T>][8]
* [Collections.Generic.Concurrent.DistinctConcurrentBag<T>][9]
* [Collections.Generic.Concurrent.ConcurrentHashSet<T>][10]
* [Devices.Clock][11]
* [Extensions.CollectionExtensions][12]
* [Extensions.EnumExtensions][13]
* [Extensions.ObjectExtensions][14]
* [Extensions.StringExtensions][15]
* [IO.DirectoryHelper][16]
* [IO.DriveHelper][17]
* [IO.FileHelper][18]
* [IO.FileProcessor][19]
* [IO.PathHelper][20]
* [Logging.LoggingHelper][21]
* Security.EncryptionHelper
* [Services][22]
* Serializer.JsonSerializer
* [TypeHelper][23]
* Xml.XmlHelper

## Your Support Is Needed
Do you have code you would like to submit to these repositories? Submit a pull request or submit an issue. I promise to take a look and include it if I like it!

  [1]: https://github.com/RealDotNetDave/dotNetTips.Utility.Core/tree/master/src/Core/dotNetTips.Utility.Core.EntityFramework
  [2]: https://github.com/RealDotNetDave/dotNetTips.Utility.Core/tree/master/src/Core/dotNetTips.Utility.Core.Windows
  [3]: https://github.com/RealDotNetDave/dotNetTips.Utility.Core/tree/master/src/Standard/dotNetTips.Utility.Standard
  [4]: https://github.com/RealDotNetDave/dotNetTips.Utility.Core/tree/master/src/Standard/dotNetTips.Utility.Standard.Extensions
  [5]: https://github.com/RealDotNetDave/dotNetTips.Utility.Core/tree/master/src/Standard/dotNetTips.Utility.Standard.Tester
  [6]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.AppPerfTestRunner-report-github.md
  [7]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Collections.Concurrent.DistinctBlockingCollectionPerfTestRunner-report-github.md
  [8]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Collections.Concurrent.FastSortedListPerfTestRunner-report-github.md
  [9]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentDistinctConcurrentBagPerfTestRunner-report-github.md
  [10]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Collections.Concurrent.ConcurrentHashSetPerfTestRunner-report-github.md
  [11]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Devices.ClockPerfTestRunner-report-github.md
  [12]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Extensions.CollectionExtensionsPerfTestRunner-report-github.md
  [13]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Extensions.EnumExtensionsPerfTestRunner-report-github.md
  [14]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Extensions.ObjectExtensionsPerfTestRunner-report-github.md
  [15]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Extensions.StringExtensionsPerfTestRunner-report-github.md
  [16]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.IO.DirectoryHelperPerfTestRunner-report-github.md
  [17]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.IO.DriveHelperPerfTestRunner-report-github.md
  [18]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.IO.FileHelperPerfTestRunner-report-github.md
  [19]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.IO.FileProcessorPerfTestRunner-report-github.md
  [20]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.IO.PathHelperPerfTestRunner-report-github.md
  [21]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.Logging.LoggingHelperPerfTestRunner-report-github.md
  [22]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.ServicesPerfTestRunner-report-github.md
  [23]: docs%2FBenchmark%20Results%2FdotNetTips.Utility.Benchmarks.TypeHelperPerfTestRunner-report-github.md
