# PostMortem

A basic analyzer for memory dumps containing managed code. Reports are provided as `.md` and `.html` files.

The console app is targeting .net core 2.2, while the `PostMorem.Core` and `PostMorem.Markdown` libraries target .net standard 2.0.

The idea and analysing code is heavily inspired (if not just copy-pasted) from the [ClrMD project](https://github.com/Microsoft/dotnet-samples/tree/master/Microsoft.Diagnostics.Runtime/CLRMD).

## Examples

Examples are based on memory dumps generated on the [aspnet-crash website](https://github.com/dougrathbone/aspnet-crash)

### Hang

Worker Processes hanging in `Thread.Sleep`

- Analysis Report 1 [HTML](https://htmlpreview.github.io/?https://github.com/schwindelig/postmortem/blob/master/docs/example-reports/hung-workers/1216b609-3c4a-4dba-9515-9a156e99a1f6-analysis-report.html) | [Markdown](docs/example-reports/hung-workers/1216b609-3c4a-4dba-9515-9a156e99a1f6-analysis-report.md)
- Analysis Report 2 [HTML](https://htmlpreview.github.io/?https://github.com/schwindelig/postmortem/blob/master/docs/example-reports/hung-workers/f4786bf0-a9f0-4e08-b207-e06c5d50b316-analysis-report.html) | [Markdown](docs/example-reports/hung-workers/f4786bf0-a9f0-4e08-b207-e06c5d50b316-analysis-report.md)
- Compare Report [HTML](https://htmlpreview.github.io/?https://github.com/schwindelig/postmortem/blob/master/docs/example-reports/hung-workers/8c48119f-5303-48ea-91aa-1b6cf809d5ef-compare-report.html) | [Markdown](docs/example-reports/hung-workers/8c48119f-5303-48ea-91aa-1b6cf809d5ef-compare-report.md)

### Crash

`StackOverflowException` by recursion and creating thousands of `SomeData` instances

- Analysis Report [HTML](https://htmlpreview.github.io/?https://github.com/schwindelig/postmortem/blob/master/docs/example-reports/stackoverflow/e397f00b-1516-4995-9e43-b2c456429871-analysis-report.html) | [Markdown](docs/example-reports/stackoverflow/e397f00b-1516-4995-9e43-b2c456429871-analysis-report.md)

### Memory Leak

Caused by not disposing `MemoryStream`s and `XmlSerializer`s

- Analysis Report 1 [HTML](https://htmlpreview.github.io/?https://github.com/schwindelig/postmortem/blob/master/docs/example-reports/memoryleak/abf0841f-11ad-4cf3-88c8-530c9af3c783-analysis-report.html) | [Markdown](docs/example-reports/memoryleak/abf0841f-11ad-4cf3-88c8-530c9af3c783-analysis-report.md)
- Analysis Report 2 [HTML](https://htmlpreview.github.io/?https://github.com/schwindelig/postmortem/blob/master/docs/example-reports/memoryleak/626456c3-6685-4828-bf75-2d3e16f64c5f-analysis-report.html) | [Markdown](docs/example-reports/memoryleak/626456c3-6685-4828-bf75-2d3e16f64c5f-analysis-report.md)
- Compare Report [HTML](https://htmlpreview.github.io/?https://github.com/schwindelig/postmortem/blob/master/docs/example-reports/memoryleak/8a25287f-1c1e-43a6-81d7-1f98a8e2c452-compare-report.html) | [Markdown](docs/example-reports/memoryleak/8a25287f-1c1e-43a6-81d7-1f98a8e2c452-compare-report.md)

## Libraries used

- [ClrMD](https://github.com/Microsoft/dotnet-samples/tree/master/Microsoft.Diagnostics.Runtime/CLRMD)
- [ClrMD.Extensions](https://github.com/JeffCyr/ClrMD.Extensions)
- [MarkDig](https://github.com/lunet-io/markdig)
- [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json)
- [Serilog](https://github.com/serilog/serilog)
- [Serilog.Sinks.Console](https://github.com/serilog/serilog-sinks-console)
- [CommandLineParser](https://github.com/commandlineparser/commandline)

## Usage

Clone this repository, run `dotnet restore` and publish it. In the published directory, run
```bash
dotnet .\PostMortem.dll
```
with the following parameters

```bash
  -p, --path          Required. Path to the memory dump

  -v, --verbose       (Default: false) Verbose output

  -o, --output-dir    Required. Directory where the results should be saved

  -s, --path2         Path to the second memory dump

  --help              Display this help screen.

  --version           Display version information.
```

## Features

### Analysis Report

The analysis report provides the following information:

#### Runtime Info

- Pointer Size
- Heap Count
- Flag indicating if Server Garbage Collection is in use

#### Memory Regions

- Total Size
- Count
- Type

#### Heap Segments

- Start
- End
- Committed End
- Reserved End
- Heap
- Type

#### Heap Balance

- Heap
- Size in Bytes

#### App Domains

- Name
- Loaded Modules

#### Threads

- Indication if thread contains exception
- Information about exception, such as type, message and hresult
- Stack trace
  - Stack Pointer
  - Instruction Pointer
  - Method Display String

#### Top Objects

- Displays top 1000 objects by total size
  - Type
  - Indicator if type directly implements `IDisposable`
  - Count / number of instances
  - Total size in bytes

### Compare Report

PostMortem allows you to compare two memory dumps. See the `--help` details, on which parameters to use.

#### Matching Threads

Displays threads where the thread id within both dumps matches.

Matching stack traces are displayed in the table below. A visual indication (:snowflake:) is given when both stack traces seem to be equal.

#### Object Count Diff

Displays a list of the most common objects, order by the difference in instances between the two dumps.

If a type directly implements `IDisposable` a visual indication (:warning:) is displayed in the `Implements IDisposable` column.
