Pulled from Microsofts c# programming samples
Found at:  https://github.com/dotnet/samples.git


# .NET Core parallel programming samples

The sample source code is a .NET Core Console application written in C#, that implements ["grep"](https://en.wikipedia.org/wiki/Grep) functionality across a file system using PLINQ.

## Sample prerequisites

This sample is written in C# and targets .NET Core 3.1. It requires the [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1).

## Types and members in use

The sample source code uses the following types and members:

- `ThreadLocal`
- `.AsParallel()`
- `.AsOrdered()`
- `.WithMergeOptions(ParallelMergeOptions.NotBuffered)`


# .NET Standard parallel extensions extras

In 2010, [Stephen Toub](https://devblogs.microsoft.com/pfxteam/author/toub/) authored a blog series called ["A Tour of ParallelExtensionsExtras"](https://devblogs.microsoft.com/pfxteam/a-tour-of-parallelextensionsextras/). At the time, there was a companion library of extensions that was based on .NET Framework 4. The sample source code has been ported from the original to .NET Standard 2.1.

---
languages:
- csharp
products:
- dotnet
- dotnet-core
- windows-wpf
page_type: sample
name: ".NET Core parallel interactive reversi game"
urlFragment: "parallel-programming-wpf-raytracer-cs"
description: "A .NET Core WPF application that demonstrates AI algorithms using minimax with alpha-beta pruning and parallel AI."
---

# .NET Core parallel programming with PLINQ

The sample source code is a .NET Core WPF application written in C#, that demonstrates AI algorithms using minimax with alpha-beta pruning, and the parallel AI (light player) uses Tasks and CancellationTokens to achieve speedup via parallelism. For more information, see [.NET Core 3 for Windows Desktop](https://devblogs.microsoft.com/dotnet/net-core-3-for-windows-desktop/).

## Demo

![Demo raytracer app](assets/demo.png)

## Sample prerequisites

This sample is written in C# and targets .NET Core 3.1. It requires the [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1).

## Types and members in use

The sample source code uses the following types and members:

- `Monitor.Enter`
- `Monitor.Exit`
- `CancellationTokenSource`
- `CancellationToken`
- `Queue<Task>`
- `Task.WaitAll`
- `Task.Run`
- `Task.Factory.StartNew`
- `TaskScheduler.FromCurrentSynchronizationContext`

# .NET Core parallel computation of PI

The sample source code is a .NET Core Console application written in C#, that estimates the value of PI using a variety of both serial and parallel implementations. The sample demonstrates elapsed time comparisons between serial execution and parallel functional equivalents. The parallel implementations make use of PLINQ and the `Parallel` class.

## Sample prerequisites

This sample is written in C# and targets .NET Core 3.1. It requires the [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1).

## Types and members in use

The sample source code uses the following types and members:

- `ParallelEnumerable.Range`
- `Parallel.For`
- `Parallel.ForEach`
- `Partitioner.Create`


# .NET Core parallel wavefront algorithm sample

The sample source code is a .NET Core Console application written in C#, that uses `Task` to parallelize a dynamic programming problem. The dynamic programming problem is computing the ["edit distance"](https://en.wikipedia.org/wiki/Edit_distance) between two strings.

## Sample prerequisites

This sample is written in C# and targets .NET Core 3.1. It requires the [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1).

## Types and members in use

The sample source code uses the following types and members:

- `ParallelEnumerable.Range`
- `ParallelAlgorithms.Wavefront`
  - [Details of the Wavefront algorithm](https://en.wikipedia.org/wiki/Wavefront)
- `Environment.ProcessorCount`




# .NET Core parallel programming with PLINQ

The sample source code is a .NET Core Console application written in C#, that demonstrates some of the ways PLINQ query execution may be controlled and configured.

## Sample prerequisites

This sample is written in C# and targets .NET Core 3.1. It requires the [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1).

## Types and members in use

The sample source code uses the following types and members:

- `ParallelEnumerable.Range`
  - `.WithMergedOptions()`
    - `ParallelMergeOptions.FullyBuffered`
    - `ParallelMergeOptions.NotBuffered`
  - `.WithCancellation()`
  - `.WithDegreeOfParallelism()`
  
  
  
# .NET Core parallel animated ray-traced bouncing ball

The sample source code is a .NET Core WinForms application written in C#, that provides an animated, ray-traced bouncing ball. Sequential and parallel implementations are provided, as is a special parallel implementation that colors the animated image based on which thread was used to calculate which regions. For more information, see [Updates on .NET Core Windows Forms designer](https://devblogs.microsoft.com/dotnet/updates-on-net-core-windows-forms-designer/).

## Demo

![Demo raytracer app](assets/demo.gif)

## Sample prerequisites

This sample is written in C# and targets .NET Core 3.1. It requires the [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1).

## Types and members in use

The sample source code uses the following types and members:

- `Parallel.For`
- `ParallelOptions`
  - `CancellationToken`
  - `MaxDegreeOfParallelism`