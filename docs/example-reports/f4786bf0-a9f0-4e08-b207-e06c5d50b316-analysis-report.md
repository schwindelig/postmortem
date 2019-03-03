# PostMortem Analysis Report for ``FULLDUMP_HangMode_w3wp.exe__9554_2019-03-03_15-22-18-755_9320.dmp``
Report generated: Sonntag, 3. März 2019 19:33:09

## General Information
Dump File Creation Time: Sonntag, 3. März 2019 15:22:18

Dump File Path: ``C:\Temp\crash-analysis\20190303_152218_Hang_Mode_HungWorker\FULLDUMP_HangMode_w3wp.exe__9554_2019-03-03_15-22-18-755_9320.dmp``

## Runtime Info
Pointer Size|Heap Count|Server Garbage Collector
|:---|:---|:---|
|8|8|True
|
## Memory Regions
Total Size|Count|Type
|:---|:---|:---|
|8’912’896|          16|``GCSegment``
|2’801’664|          39|``LowFrequencyLoaderHeap``
|1’073’152|          18|``HighFrequencyLoaderHeap``
|507’904|           3|``ResolveHeap``
|319’488|           3|``DispatchHeap``
|167’936|           5|``StubHeap``
|135’168|          16|``HandleTableChunk``
|57’344|           3|``IndcellHeap``
|57’344|           3|``CacheEntryHeap``
|40’960|           3|``LookupHeap``
## Heap Segments
Start|End|Committed End|Reserved End|Heap|Type
|:---|:---|:---|:---|:---|:---|
|``023ce24d1000``|``023ce264ffe8``|``023ce2652000``|``023d624d0000``|   0|``Ephemeral``
|``023d624d1000``|``023d6255ffe8``|``023d62562000``|``023de24d0000``|   1|``Ephemeral``
|``023de24d1000``|``023de262ffe8``|``023de2632000``|``023e624d0000``|   2|``Ephemeral``
|``023e624d1000``|``023e62533fe8``|``023e62542000``|``023ee24d0000``|   3|``Ephemeral``
|``023ee24d1000``|``023ee2501fe8``|``023ee2502000``|``023f624d0000``|   4|``Ephemeral``
|``023f624d1000``|``023f62571fe8``|``023f62572000``|``023fe24d0000``|   5|``Ephemeral``
|``023fe24d1000``|``023fe25e9fe8``|``023fe25f2000``|``0240624d0000``|   6|``Ephemeral``
|``0240624d1000``|``02406272dfe8``|``024062732000``|``0240e24d0000``|   7|``Ephemeral``
|``0240e24d1000``|``0240e250c668``|``0240e2512000``|``0240f24d0000``|   0|``Large``
|``0240f24d1000``|``0240f24d1018``|``0240f24d2000``|``0241024d0000``|   1|``Large``
|``0241024d1000``|``0241024d1018``|``0241024d2000``|``0241124d0000``|   2|``Large``
|``0241124d1000``|``0241124d1018``|``0241124d2000``|``0241224d0000``|   3|``Large``
|``0241224d1000``|``0241224d1018``|``0241224d2000``|``0241324d0000``|   4|``Large``
|``0241324d1000``|``0241324d1018``|``0241324d2000``|``0241424d0000``|   5|``Large``
|``0241424d1000``|``0241424d1018``|``0241424d2000``|``0241524d0000``|   6|``Large``
|``0241524d1000``|``0241524d1018``|``0241524d2000``|``0241624d0000``|   7|``Large``
## Heap Balance
Heap|Size in Bytes
|:---|:---|
| 0|1’812’048
| 1|585’728
| 2|1’437’696
| 3|405’504
| 4|200’704
| 5|659’456
| 6|1’150’976
| 7|2’478’080
## App Domains
### DefaultDomain
Loaded Modules:

1. C:\WINDOWS\Microsoft.Net\assembly\GAC_64\mscorlib\v4.0_4.0.0.0__b77a5c561934e089\mscorlib.dll
2. C:\WINDOWS\Microsoft.Net\assembly\GAC_64\System.Web\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.dll
3. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.Build.Utilities.v4.0\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.Build.Utilities.v4.0.dll
4. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Configuration\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Configuration.dll
5. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Core\v4.0_4.0.0.0__b77a5c561934e089\System.Core.dll
6. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Caching\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Runtime.Caching.dll
7. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.ApplicationServices\v4.0_4.0.0.0__31bf3856ad364e35\System.Web.ApplicationServices.dll
8. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.RegularExpressions\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.RegularExpressions.dll
9. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Xml\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.dll
10. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll
### /LM/W3SVC/12/ROOT-1-131960953103961343
Loaded Modules:

1. C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\Common7\IDE\Extensions\Microsoft\Web Tools\Page Inspector\Microsoft.VisualStudio.Web.PageInspector.Runtime.dll
2. C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\Common7\IDE\Extensions\Microsoft\Web Tools\Page Inspector\Microsoft.VisualStudio.Web.PageInspector.Tracing.dll
3. C:\WINDOWS\Microsoft.Net\assembly\GAC_64\mscorlib\v4.0_4.0.0.0__b77a5c561934e089\mscorlib.dll
4. C:\WINDOWS\Microsoft.Net\assembly\GAC_64\System.Data\v4.0_4.0.0.0__b77a5c561934e089\System.Data.dll
5. C:\WINDOWS\Microsoft.Net\assembly\GAC_64\System.EnterpriseServices\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.EnterpriseServices.dll
6. C:\WINDOWS\Microsoft.Net\assembly\GAC_64\System.Web\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.dll
7. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.Build.Utilities.v4.0\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.Build.Utilities.v4.0.dll
8. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.CSharp\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.CSharp.dll
9. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.JScript\v4.0_10.0.0.0__b03f5f7f11d50a3a\Microsoft.JScript.dll
10. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.VisualStudio.Web.PageInspector.Loader\v4.0_1.0.0.0__b03f5f7f11d50a3a\Microsoft.VisualStudio.Web.PageInspector.Loader.dll
11. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Activities\v4.0_4.0.0.0__31bf3856ad364e35\System.Activities.dll
12. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ComponentModel.DataAnnotations\v4.0_4.0.0.0__31bf3856ad364e35\System.ComponentModel.DataAnnotations.dll
13. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Configuration\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Configuration.dll
14. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Core\v4.0_4.0.0.0__b77a5c561934e089\System.Core.dll
15. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Data.DataSetExtensions\v4.0_4.0.0.0__b77a5c561934e089\System.Data.DataSetExtensions.dll
16. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Drawing\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Drawing.dll
17. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Dynamic\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Dynamic.dll
18. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.IdentityModel\v4.0_4.0.0.0__b77a5c561934e089\System.IdentityModel.dll
19. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Caching\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Runtime.Caching.dll
20. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Serialization\v4.0_4.0.0.0__b77a5c561934e089\System.Runtime.Serialization.dll
21. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel.Activation\v4.0_4.0.0.0__31bf3856ad364e35\System.ServiceModel.Activation.dll
22. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel.Activities\v4.0_4.0.0.0__31bf3856ad364e35\System.ServiceModel.Activities.dll
23. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel.Web\v4.0_4.0.0.0__31bf3856ad364e35\System.ServiceModel.Web.dll
24. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel\v4.0_4.0.0.0__b77a5c561934e089\System.ServiceModel.dll
25. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.ApplicationServices\v4.0_4.0.0.0__31bf3856ad364e35\System.Web.ApplicationServices.dll
26. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.DynamicData\v4.0_4.0.0.0__31bf3856ad364e35\System.Web.DynamicData.dll
27. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.Extensions\v4.0_4.0.0.0__31bf3856ad364e35\System.Web.Extensions.dll
28. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.Mobile\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.Mobile.dll
29. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.Mvc\v4.0_5.0.0.0__31bf3856ad364e35\System.Web.Mvc.dll
30. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.RegularExpressions\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.RegularExpressions.dll
31. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.Services\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.Services.dll
32. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.WorkflowServices\v4.0_4.0.0.0__31bf3856ad364e35\System.WorkflowServices.dll
33. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Xaml\v4.0_4.0.0.0__b77a5c561934e089\System.Xaml.dll
34. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Xml.Linq\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.Linq.dll
35. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Xml\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.dll
36. C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll
37. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\App_global.asax.oizf4iof.dll
38. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\App_Web_2rt3mxv1.dll
39. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\App_Web_nghn0amz.dll
40. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\0127b7a4\00f03fa5_d7bece01\System.Web.Razor.dll
41. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\0205495f\00313f77_80aece01\Microsoft.Owin.Security.Twitter.dll
42. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\022b356c\00313f77_80aece01\Microsoft.Owin.Security.MicrosoftAccount.dll
43. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\07379524\003c57d9_fe82ce01\WebGrease.dll
44. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\20cc9c87\00ae10f0_bdaece01\EntityFramework.SqlServer.dll
45. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\20d208d8\00d7dc74_80aece01\Microsoft.Owin.Security.dll
46. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\2b83bfc3\001d71a6_d7bece01\System.Web.WebPages.Deployment.dll
47. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\3c5bbf16\00ae10f0_bdaece01\EntityFramework.dll
48. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\57ee901c\00b4f9b4_4a6acd01\Microsoft.Web.Infrastructure.dll
49. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\57fd4579\001d71a6_d7bece01\System.Web.WebPages.dll
50. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\6dfbdfaf\001eaa54_d010ce01\Antlr3.Runtime.dll
51. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\6f3f0ed7\003d69b9_a962ce01\Newtonsoft.Json.dll
52. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\73b2022f\00040e76_80aece01\Microsoft.Owin.Security.Facebook.dll
53. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\890dd854\00040e76_80aece01\Microsoft.Owin.Security.Cookies.dll
54. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\8c44e592\003cc57a_05a9ce01\System.Web.Optimization.dll
55. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\96b4a914\001d71a6_d7bece01\System.Web.WebPages.Razor.dll
56. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\9bc25521\00e720c2_90c1cd01\Owin.dll
57. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\9e77250c\001d71a6_d7bece01\System.Web.Helpers.dll
58. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\a894e906\03cbedc1_bdd1d401\AspNetCrash.Web.dll
59. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\b9975a2d\00aaab73_80aece01\Microsoft.Owin.Host.SystemWeb.dll
60. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\bd0567de\009b593b_83aece01\Microsoft.AspNet.Identity.EntityFramework.dll
61. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\cc1f87d2\009b593b_83aece01\Microsoft.AspNet.Identity.Core.dll
62. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\de5f0144\00d7dc74_80aece01\Microsoft.Owin.dll
63. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\e75b4e4d\00040e76_80aece01\Microsoft.Owin.Security.Google.dll
64. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\e832913e\00313f77_80aece01\Microsoft.Owin.Security.OAuth.dll
65. C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files\root\56dc43e8\a0219328\assembly\dl3\f25a3633\009b593b_83aece01\Microsoft.AspNet.Identity.Owin.dll
## Threads
Total Threads: 42 (Alive: 25)

### Thread ``000000009fb0``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
### Thread ``00000000700c``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43AB2FF6A8``|``           0``|``DebuggerU2MCatchHandlerFrame``
### Thread ``0000000099b0``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
### Thread ``0000000042ec``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
### Thread ``000000009f74``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
### Thread ``000000007ff0``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
### Thread ``00000000c448``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
### Thread ``000000002720``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43AB6FEB18``|``           0``|``HelperMethodFrame``
|``  43AB6FEC10``|``7FFB5A2BC91A``|``System.Threading.Thread.Sleep(Int32)``
|``  43AB6FEC40``|``7FFB5A2F3A63``|``System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB6FED10``|``7FFB5A2F38F4``|``System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB6FED40``|``7FFB5A333993``|``System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()``
|``  43AB6FED80``|``7FFB5A332C72``|``System.Threading.ThreadPoolWorkQueue.Dispatch()``
|``  43AB6FF218``|``           0``|``DebuggerU2MCatchHandlerFrame``
|``  43AB6FF3A8``|``           0``|``ContextTransitionFrame``
|``  43AB6FF5D8``|``           0``|``DebuggerU2MCatchHandlerFrame``
### Thread ``000000009dec``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
### Thread ``000000000ca8``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43AB9FE4D8``|``           0``|``HelperMethodFrame``
|``  43AB9FE5D0``|``7FFB5A2BC91A``|``System.Threading.Thread.Sleep(Int32)``
|``  43AB9FE600``|``7FFB5A2F3A63``|``System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB9FE6D0``|``7FFB5A2F38F4``|``System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB9FE700``|``7FFB5A333993``|``System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()``
|``  43AB9FE740``|``7FFB5A332C72``|``System.Threading.ThreadPoolWorkQueue.Dispatch()``
|``  43AB9FEBD8``|``           0``|``DebuggerU2MCatchHandlerFrame``
|``  43AB9FED68``|``           0``|``ContextTransitionFrame``
|``  43AB9FEF98``|``           0``|``DebuggerU2MCatchHandlerFrame``
### Thread ``000000005e24``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
### Thread ``000000008034``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43AB7FE2E8``|``           0``|``HelperMethodFrame``
|``  43AB7FE3E0``|``7FFB5A2BC91A``|``System.Threading.Thread.Sleep(Int32)``
|``  43AB7FE410``|``7FFB5A2F3A63``|``System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB7FE4E0``|``7FFB5A2F38F4``|``System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB7FE510``|``7FFB5A333993``|``System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()``
|``  43AB7FE550``|``7FFB5A332C72``|``System.Threading.ThreadPoolWorkQueue.Dispatch()``
|``  43AB7FE9E8``|``           0``|``DebuggerU2MCatchHandlerFrame``
|``  43AB7FEB78``|``           0``|``ContextTransitionFrame``
|``  43AB7FEDA8``|``           0``|``DebuggerU2MCatchHandlerFrame``
### Thread ``00000000b8fc``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43AB77DE68``|``           0``|``HelperMethodFrame``
|``  43AB77DF60``|``7FFB5A2BC91A``|``System.Threading.Thread.Sleep(Int32)``
|``  43AB77DF90``|``7FFB5A2F3A63``|``System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB77E060``|``7FFB5A2F38F4``|``System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB77E090``|``7FFB5A333993``|``System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()``
|``  43AB77E0D0``|``7FFB5A332C72``|``System.Threading.ThreadPoolWorkQueue.Dispatch()``
|``  43AB77E568``|``           0``|``DebuggerU2MCatchHandlerFrame``
|``  43AB77E6F8``|``           0``|``ContextTransitionFrame``
|``  43AB77E928``|``           0``|``DebuggerU2MCatchHandlerFrame``
### Thread ``00000000662c``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43AA33E278``|``           0``|``HelperMethodFrame``
|``  43AA33E370``|``7FFB5A2BC91A``|``System.Threading.Thread.Sleep(Int32)``
|``  43AA33E3A0``|``7FFB5A2F3A63``|``System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AA33E470``|``7FFB5A2F38F4``|``System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AA33E4A0``|``7FFB5A333993``|``System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()``
|``  43AA33E4E0``|``7FFB5A332C72``|``System.Threading.ThreadPoolWorkQueue.Dispatch()``
|``  43AA33E978``|``           0``|``DebuggerU2MCatchHandlerFrame``
|``  43AA33EB08``|``           0``|``ContextTransitionFrame``
|``  43AA33ED38``|``           0``|``DebuggerU2MCatchHandlerFrame``
### Thread ``000000008428``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43AB47DE88``|``           0``|``HelperMethodFrame``
|``  43AB47DF80``|``7FFB5A2BC91A``|``System.Threading.Thread.Sleep(Int32)``
|``  43AB47DFB0``|``7FFB5A2F3A63``|``System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB47E080``|``7FFB5A2F38F4``|``System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB47E0B0``|``7FFB5A333993``|``System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()``
|``  43AB47E0F0``|``7FFB5A332C72``|``System.Threading.ThreadPoolWorkQueue.Dispatch()``
|``  43AB47E588``|``           0``|``DebuggerU2MCatchHandlerFrame``
|``  43AB47E718``|``           0``|``ContextTransitionFrame``
|``  43AB47E948``|``           0``|``DebuggerU2MCatchHandlerFrame``
### Thread ``00000000a978``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43AB8FDF18``|``           0``|``HelperMethodFrame``
|``  43AB8FE010``|``7FFB5A2BC91A``|``System.Threading.Thread.Sleep(Int32)``
|``  43AB8FE040``|``7FFB5A2F3A63``|``System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB8FE110``|``7FFB5A2F38F4``|``System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB8FE140``|``7FFB5A333993``|``System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()``
|``  43AB8FE180``|``7FFB5A332C72``|``System.Threading.ThreadPoolWorkQueue.Dispatch()``
|``  43AB8FE618``|``           0``|``DebuggerU2MCatchHandlerFrame``
|``  43AB8FE7A8``|``           0``|``ContextTransitionFrame``
|``  43AB8FE9D8``|``           0``|``DebuggerU2MCatchHandlerFrame``
### Thread ``000000008654``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43AB57DED8``|``           0``|``HelperMethodFrame``
|``  43AB57DFD0``|``7FFB5A2BC91A``|``System.Threading.Thread.Sleep(Int32)``
|``  43AB57E000``|``7FFB5A2F3A63``|``System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB57E0D0``|``7FFB5A2F38F4``|``System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB57E100``|``7FFB5A333993``|``System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()``
|``  43AB57E140``|``7FFB5A332C72``|``System.Threading.ThreadPoolWorkQueue.Dispatch()``
|``  43AB57E5D8``|``           0``|``DebuggerU2MCatchHandlerFrame``
|``  43AB57E768``|``           0``|``ContextTransitionFrame``
|``  43AB57E998``|``           0``|``DebuggerU2MCatchHandlerFrame``
### Thread ``00000000adc4``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43AA3BF038``|``           0``|``HelperMethodFrame``
|``  43AA3BF130``|``7FFB5A2BC91A``|``System.Threading.Thread.Sleep(Int32)``
|``  43AA3BF160``|``7FFB5A2F3A63``|``System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AA3BF230``|``7FFB5A2F38F4``|``System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AA3BF260``|``7FFB5A333993``|``System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()``
|``  43AA3BF2A0``|``7FFB5A332C72``|``System.Threading.ThreadPoolWorkQueue.Dispatch()``
|``  43AA3BF738``|``           0``|``DebuggerU2MCatchHandlerFrame``
|``  43AA3BF8C8``|``           0``|``ContextTransitionFrame``
|``  43AA3BFAF8``|``           0``|``DebuggerU2MCatchHandlerFrame``
### Thread ``000000005094``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43AACFF068``|``           0``|``HelperMethodFrame``
|``  43AACFF160``|``7FFB5A2BC91A``|``System.Threading.Thread.Sleep(Int32)``
|``  43AACFF190``|``7FFB5A2F3A63``|``System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AACFF260``|``7FFB5A2F38F4``|``System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AACFF290``|``7FFB5A333993``|``System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()``
|``  43AACFF2D0``|``7FFB5A332C72``|``System.Threading.ThreadPoolWorkQueue.Dispatch()``
|``  43AACFF768``|``           0``|``DebuggerU2MCatchHandlerFrame``
|``  43AACFF8F8``|``           0``|``ContextTransitionFrame``
|``  43AACFFB28``|``           0``|``DebuggerU2MCatchHandlerFrame``
### Thread ``000000003ca0``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43AB4FEA18``|``           0``|``HelperMethodFrame``
|``  43AB4FEB10``|``7FFB5A2BC91A``|``System.Threading.Thread.Sleep(Int32)``
|``  43AB4FEB40``|``7FFB5A2F3A63``|``System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB4FEC10``|``7FFB5A2F38F4``|``System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB4FEC40``|``7FFB5A333993``|``System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()``
|``  43AB4FEC80``|``7FFB5A332C72``|``System.Threading.ThreadPoolWorkQueue.Dispatch()``
|``  43AB4FF118``|``           0``|``DebuggerU2MCatchHandlerFrame``
|``  43AB4FF2A8``|``           0``|``ContextTransitionFrame``
|``  43AB4FF4D8``|``           0``|``DebuggerU2MCatchHandlerFrame``
### Thread ``000000008e2c``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43AB87ED58``|``           0``|``HelperMethodFrame``
|``  43AB87EE50``|``7FFB5A2BC91A``|``System.Threading.Thread.Sleep(Int32)``
|``  43AB87EE80``|``7FFB5A2F3A63``|``System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB87EF50``|``7FFB5A2F38F4``|``System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB87EF80``|``7FFB5A333993``|``System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()``
|``  43AB87EFC0``|``7FFB5A332C72``|``System.Threading.ThreadPoolWorkQueue.Dispatch()``
|``  43AB87F458``|``           0``|``DebuggerU2MCatchHandlerFrame``
|``  43AB87F5E8``|``           0``|``ContextTransitionFrame``
|``  43AB87F818``|``           0``|``DebuggerU2MCatchHandlerFrame``
### Thread ``00000000b8d0``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43AB97EA78``|``           0``|``HelperMethodFrame``
|``  43AB97EB70``|``7FFB5A2BC91A``|``System.Threading.Thread.Sleep(Int32)``
|``  43AB97EBA0``|``7FFB5A2F3A63``|``System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB97EC70``|``7FFB5A2F38F4``|``System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43AB97ECA0``|``7FFB5A333993``|``System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()``
|``  43AB97ECE0``|``7FFB5A332C72``|``System.Threading.ThreadPoolWorkQueue.Dispatch()``
|``  43AB97F178``|``           0``|``DebuggerU2MCatchHandlerFrame``
|``  43AB97F308``|``           0``|``ContextTransitionFrame``
|``  43AB97F538``|``           0``|``DebuggerU2MCatchHandlerFrame``
### Thread ``00000000ab28``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43ABA7ED98``|``           0``|``HelperMethodFrame``
|``  43ABA7EE90``|``7FFB5A2BC91A``|``System.Threading.Thread.Sleep(Int32)``
|``  43ABA7EEC0``|``7FFB5A2F3A63``|``System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43ABA7EF90``|``7FFB5A2F38F4``|``System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43ABA7EFC0``|``7FFB5A333993``|``System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()``
|``  43ABA7F000``|``7FFB5A332C72``|``System.Threading.ThreadPoolWorkQueue.Dispatch()``
|``  43ABA7F498``|``           0``|``DebuggerU2MCatchHandlerFrame``
|``  43ABA7F628``|``           0``|``ContextTransitionFrame``
|``  43ABA7F858``|``           0``|``DebuggerU2MCatchHandlerFrame``
### Thread ``000000004918``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43ABAFEA38``|``           0``|``HelperMethodFrame``
|``  43ABAFEB30``|``7FFB5A2BC91A``|``System.Threading.Thread.Sleep(Int32)``
|``  43ABAFEB60``|``7FFB5A2F3A63``|``System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43ABAFEC30``|``7FFB5A2F38F4``|``System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43ABAFEC60``|``7FFB5A333993``|``System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()``
|``  43ABAFECA0``|``7FFB5A332C72``|``System.Threading.ThreadPoolWorkQueue.Dispatch()``
|``  43ABAFF138``|``           0``|``DebuggerU2MCatchHandlerFrame``
|``  43ABAFF2C8``|``           0``|``ContextTransitionFrame``
|``  43ABAFF4F8``|``           0``|``DebuggerU2MCatchHandlerFrame``
### Thread ``000000003fa8``
#### Stack Trace
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  43ABB7EBB8``|``           0``|``HelperMethodFrame``
|``  43ABB7ECB0``|``7FFB5A2BC91A``|``System.Threading.Thread.Sleep(Int32)``
|``  43ABB7ECE0``|``7FFB5A2F3A63``|``System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43ABB7EDB0``|``7FFB5A2F38F4``|``System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object, Boolean)``
|``  43ABB7EDE0``|``7FFB5A333993``|``System.Threading.QueueUserWorkItemCallback.System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()``
|``  43ABB7EE20``|``7FFB5A332C72``|``System.Threading.ThreadPoolWorkQueue.Dispatch()``
|``  43ABB7F2B8``|``           0``|``DebuggerU2MCatchHandlerFrame``
|``  43ABB7F448``|``           0``|``ContextTransitionFrame``
|``  43ABB7F678``|``           0``|``DebuggerU2MCatchHandlerFrame``
## Top 1000 Objects by total size
Type|Implements IDisposable|Count|Total Size in bytes
|:---|:---|:---|:---|
|``System.String``|False|23’505|2’137’874
|``System.Char[]``|False|1’638|704’970
|``System.Object[]``|False|3’460|426’512
|``System.Reflection.RuntimeMethodInfo``|False|3’639|407’568
|``System.Collections.Hashtable+bucket[]``|False|1’126|272’112
|``System.Reflection.CustomAttributeRecord[]``|False|4’800|231’600
|``System.Int32[]``|False|2’659|227’880
|``System.Reflection.MethodInfo[]``|False|507|200’296
|``System.RuntimeMethodInfoStub``|False|1’543|148’128
|``System.Byte[]``|False|1’092|146’142
|``System.Reflection.RuntimeMethodInfo[]``|False|660|121’000
|``System.Web.Caching.UsageEntry[]``|False|27|111’240
|``System.String[]``|False|1’748|102’424
|``Free``|False|86|101’690
|``System.RuntimeType+RuntimeTypeCache``|False|431|68’960
|``System.Web.Caching.ExpiresEntry[]``|False|29|60’088
|``System.Collections.Hashtable``|False|749|59’920
|``Microsoft.CSharp.RuntimeBinder.Semantics.SYMTBL+Key``|False|1’816|58’112
|``System.Reflection.AssemblyName``|False|554|57’616
|``System.Threading.QueueUserWorkItemCallback``|False|1’437|57’480
|``System.Text.RegularExpressions.RegexNode``|False|788|50’432
|``System.Collections.ArrayList``|False|1’244|49’760
|``System.RuntimeType``|False|875|49’000
|``System.Configuration.FactoryRecord``|False|465|48’360
|``System.Threading.ExecutionContext``|True :warning:|537|47’256
|``System.Xml.NameTable+Entry``|False|1’174|46’960
|``System.Web.Caching.ExpiresBucket``|False|480|46’080
|``System.Reflection.RuntimeParameterInfo``|False|360|43’200
|``System.Collections.DictionaryEntry[]``|False|406|43’024
|``System.Security.PermissionSet``|False|670|42’880
|``System.Text.StringBuilder``|False|817|39’216
|``System.Type[]``|False|1’141|38’768
|``System.Runtime.Remoting.Messaging.LogicalCallContext``|False|533|38’376
|``System.IntPtr``|False|1’511|36’264
|``System.Signature``|False|445|35’600
|``System.Xml.XmlTextReaderImpl+NodeData``|False|267|34’176
|``System.Int32``|False|1’414|33’936
|``System.Configuration.ConfigurationProperty``|False|322|33’488
|``Microsoft.CSharp.RuntimeBinder.Semantics.CType[]``|False|1’060|33’136
|``System.Text.RegularExpressions.RegexNode[]``|False|585|33’048
|``System.Collections.Specialized.NameObjectCollectionBase+NameObjectEntry``|False|941|30’112
|``System.ConfigNode[]``|False|426|29’904
|``System.Threading.IThreadPoolWorkItem[]``|False|64|28’672
|``System.Reflection.ParameterInfo[]``|False|690|26’432
|``System.RuntimeType[]``|False|666|25’072
|``System.Attribute[]``|False|498|24’224
|``System.Globalization.CultureInfo``|False|187|23’936
|``System.Configuration.ConfigurationValue``|False|582|23’280
|``System.Xml.NameTable+Entry[]``|False|53|22’776
|``System.ConfigNode``|False|400|22’400
|``System.Collections.Generic.List<System.Text.RegularExpressions.RegexNode>``|False|549|21’960
|``System.Version``|False|662|21’184
|``System.Configuration.ConfigurationValues``|False|240|21’120
|``System.Web.Hosting.AspNetHostExecutionContextManager+AspNetHostExecutionContext``|True :warning:|520|20’800
|``System.Collections.ArrayList+ArrayListEnumeratorSimple``|False|399|19’152
|``System.Collections.Generic.Dictionary+Entry<System.String,System.Object>[]``|False|27|18’960
|``System.Reflection.RuntimeConstructorInfo``|False|166|18’592
|``System.Xml.XmlTextReaderImpl``|True :warning:|34|18’496
|``System.Collections.Generic.List<System.Object>``|False|461|18’440
|``System.Configuration.SectionXmlInfo``|False|136|17’408
|``System.Collections.Generic.List<System.ConfigNode>``|False|400|16’000
|``System.Collections.Generic.List<System.Collections.DictionaryEntry>``|False|400|16’000
|``System.Action``|False|239|15’296
|``System.Collections.Hashtable+HashtableEnumerator``|False|264|14’784
|``System.Object``|False|612|14’688
|``System.Text.RegularExpressions.RegexFC[]``|False|52|14’560
|``System.Configuration.SectionRecord``|False|199|14’328
|``System.Web.Caching.CacheEntry``|False|126|14’112
|``System.Security.Permissions.FileIOPermission``|False|186|13’392
|``System.Reflection.RuntimePropertyInfo``|False|125|13’000
|``System.Reflection.Emit.OpCode``|False|226|12’656
|``System.Runtime.Remoting.Messaging.CallContextSecurityData``|False|525|12’600
|``Microsoft.CSharp.RuntimeBinder.Semantics.AggregateSymbol``|False|55|12’320
|``Microsoft.CSharp.RuntimeBinder.Semantics.MethodSymbol``|False|46|12’144
|``System.Collections.Generic.Dictionary+Entry<System.String,System.Int32>[]``|False|101|11’424
|``System.Collections.Generic.Dictionary+Entry<Microsoft.CSharp.RuntimeBinder.Semantics.KeyPair<Microsoft.CSharp.RuntimeBinder.Semantics.AggregateSymbol,Microsoft.CSharp.RuntimeBinder.Syntax.Name>,Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType>[]``|False|6|11’344
|``System.Configuration.PropertySourceInfo``|False|340|10’880
|``System.Collections.Generic.List<System.Web.HttpApplication+IExecutionStep>[]``|False|38|10’640
|``System.Web.Caching.CacheKey``|False|326|10’432
|``System.Reflection.MemberInfo[]``|False|37|10’128
|``Microsoft.CSharp.RuntimeBinder.Syntax.NameTable+Entry``|False|247|9’880
|``Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType``|False|95|9’880
|``System.Web.VirtualPath``|False|245|9’800
|``System.Configuration.SectionInput``|False|136|9’792
|``System.Web.ApplicationImpersonationContext``|True :warning:|241|9’640
|``System.Security.Util.StringExpressionSet``|False|200|9’600
|``System.Configuration.SectionInformation``|False|59|9’440
|``System.Text.RegularExpressions.RegexInterpreter``|False|52|9’152
|``System.Security.AllowPartiallyTrustedCallersAttribute[]``|False|68|8’560
|``System.Collections.Generic.Dictionary+Entry<Microsoft.CSharp.RuntimeBinder.Semantics.SYMTBL+Key,Microsoft.CSharp.RuntimeBinder.Semantics.Symbol>[]``|False|6|8’544
|``System.Collections.Generic.Dictionary+Entry<System.String,Microsoft.CSharp.RuntimeBinder.Syntax.PredefinedType>[]``|False|6|8’544
|``System.Collections.Specialized.HybridDictionary``|False|210|8’400
|``System.Web.Util.DoubleLinkListEnumerator``|False|260|8’320
|``System.Reflection.MethodBase[]``|False|251|8’064
|``System.Configuration.PropertyInformation``|False|201|8’040
|``System.Boolean[]``|False|282|7’793
|``System.Collections.Generic.Dictionary<System.String,System.Int32>``|False|97|7’760
|``System.Web.Caching.UsageBucket``|False|80|7’680
|``System.Reflection.RuntimeEventInfo``|False|79|7’584
|``System.Text.RegularExpressions.RegexParser``|False|52|7’488
|``System.Xml.XmlNamespaceManager+NamespaceDeclaration[]``|False|34|7’344
|``System.IO.FileInfo``|False|70|7’280
|``System.Security.FrameSecurityDescriptor``|False|82|7’216
|``System.Web.Caching.CacheInsertOptions``|False|125|7’000
|``System.Web.Configuration.AssemblyInfo``|False|54|6’912
|``System.Web.UI.WebResourceAttribute``|False|106|6’784
|``System.Collections.Generic.List<System.String>``|False|167|6’680
|``System.Boolean``|False|278|6’672
|``Microsoft.CSharp.RuntimeBinder.Semantics.PredefinedTypeFacts+PredefinedTypeInfo``|False|138|6’624
|``System.Text.RegularExpressions.RegexCharClass+SingleRange[]``|False|92|6’624
|``System.Runtime.Serialization.ObjectHolder``|False|63|6’552
|``System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeConstructorInfo>``|False|115|6’440
|``System.Xml.XmlTextReaderImpl+NodeData[]``|False|53|6’392
|``System.Security.Permissions.FileIOAccess``|False|196|6’272
|``System.IO.DirectoryInfo``|False|60|6’240
|``System.Reflection.RuntimeConstructorInfo[]``|False|135|6’200
|``System.EventHandler``|False|95|6’080
|``System.Collections.Generic.Dictionary<System.String,System.Object>``|False|76|6’080
|``System.Reflection.RtFieldInfo``|False|75|6’000
|``System.Configuration.XmlUtilWriter``|False|107|5’992
|``System.Globalization.CultureData``|False|11|5’896
|``System.Collections.Specialized.ListDictionary+DictionaryNode``|False|146|5’840
|``System.Diagnostics.CodeAnalysis.SuppressMessageAttribute``|False|91|5’824
|``System.Configuration.ConfigurationElementCollection+Entry``|False|143|5’720
|``System.Reflection.RuntimePropertyInfo[]``|False|123|5’584
|``System.Text.RegularExpressions.Regex``|False|52|5’408
|``System.Collections.Generic.List<System.Reflection.MethodInfo>``|False|135|5’400
|``System.Web.Caching.ExpiresPage[]``|False|29|5’336
|``Microsoft.CSharp.RuntimeBinder.Semantics.PredefinedMethodInfo``|False|109|5’232
|``System.RuntimeType+ActivatorCacheEntry``|False|108|5’184
|``System.Reflection.FieldInfo[]``|False|92|5’176
|``System.Collections.Generic.Dictionary+Entry<Microsoft.CSharp.RuntimeBinder.Semantics.BSYMMGR+TypeArrayKey,Microsoft.CSharp.RuntimeBinder.Semantics.TypeArray>[]``|False|5|5’016
|``System.Web.Caching.UsagePage[]``|False|27|4’968
|``System.Threading.Tasks.Task<System.Object>``|True :warning:|62|4’960
|``System.Collections.Generic.Dictionary+Entry<System.String,System.Web.RequestNotification>[]``|False|12|4’896
|``System.Collections.Generic.Dictionary+Entry<System.String,System.Reflection.RuntimeEventInfo>[]``|False|12|4’896
|``System.Text.RegularExpressions.Match``|False|43|4’816
|``System.Int64[]``|False|45|4’744
|``System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>``|False|83|4’648
|``System.Linq.Enumerable+WhereSelectEnumerableIterator<System.Object,System.Web.WebPages.Instrumentation.PageExecutionListenerAdapter>``|True :warning:|72|4’608
|``System.Action<System.Web.WebPages.Instrumentation.PageExecutionListenerAdapter>``|False|72|4’608
|``System.Web.Configuration.BuildProvider``|False|38|4’560
|``System.Collections.Generic.List<Microsoft.CSharp.RuntimeBinder.Semantics.CType>``|False|114|4’560
|``System.Collections.Generic.List<System.Type>``|False|114|4’560
|``System.Web.FileChangeEventHandler``|False|71|4’544
|``System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.RuntimeType>``|False|81|4’536
|``System.Int32[][]``|False|131|4’528
|``System.Text.RegularExpressions.RegexCharClass``|False|92|4’416
|``System.Reflection.ConstructorInfo[]``|False|118|4’400
|``System.IntPtr[]``|False|68|4’320
|``System.Web.Caching.ExpiresBucket[]``|False|16|4’224
|``System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo``|False|33|4’224
|``System.Xml.XmlName``|False|58|4’176
|``System.Web.Caching.CacheDependency``|True :warning:|65|4’160
|``System.Action<System.Object,System.EventArgs>``|False|65|4’160
|``System.Text.RegularExpressions.RegexWriter``|False|52|4’160
|``System.Reflection.RuntimeModule``|False|64|4’096
|``System.Collections.Specialized.ListDictionary``|False|84|4’032
|``System.Web.AspNetSynchronizationContext+<>c__DisplayClass21_0``|False|165|3’960
|``System.Security.Util.TokenBasedSet``|False|70|3’920
|``System.Reflection.RuntimeAssembly``|False|70|3’920
|``System.Runtime.Serialization.SerializationInfo``|False|44|3’872
|``System.Collections.Generic.Dictionary+Entry<System.String,System.Collections.Generic.List<System.Reflection.RuntimePropertyInfo>>[]``|False|14|3’840
|``Microsoft.CSharp.RuntimeBinder.Syntax.NameManager+KnownName``|False|120|3’840
|``System.Xml.XmlName[]``|False|7|3’752
|``System.Text.RegularExpressions.RegexCode``|False|52|3’744
|``Microsoft.CSharp.RuntimeBinder.Syntax.NameTable+Entry[]``|False|6|3’728
|``System.Collections.Generic.List<System.Text.RegularExpressions.RegexCharClass+SingleRange>``|False|92|3’680
|``System.Collections.Generic.Dictionary+Entry<System.String,System.String>[]``|False|8|3’648
|``System.ComponentModel.TypeDescriptor+TypeDescriptionNode+DefaultTypeDescriptor``|False|89|3’560
|``System.ComponentModel.ReflectEventDescriptor``|False|25|3’400
|``System.Threading.Thread``|False|35|3’360
|``System.Collections.Hashtable+SyncHashtable``|False|38|3’344
|``System.Text.RegularExpressions.RegexTree``|False|52|3’328
|``System.Collections.Generic.List<System.Reflection.MethodBase>``|False|83|3’320
|``System.Web.FileMonitorTarget``|False|69|3’312
|``System.Collections.Generic.List<System.Attribute>``|False|81|3’240
|``System.Web.ProcessImpersonationContext``|True :warning:|80|3’200
|``System.Web.HttpApplication+IExecutionStep[]``|False|57|3’160
|``System.AsyncCallback``|False|49|3’136
|``System.Web.HttpApplication+<>c__DisplayClass285_1``|False|130|3’120
|``System.Text.RegularExpressions.RegexBoyerMoore``|False|43|3’096
|``System.Web.Util.FileAttributesData``|False|55|3’080
|``System.Collections.Generic.List+Enumerator<System.Web.Instrumentation.PageExecutionListener>``|True :warning:|77|3’080
|``System.Text.RegularExpressions.RegexPrefix``|False|96|3’072
|``Microsoft.CSharp.RuntimeBinder.Syntax.Name``|False|127|3’048
|``System.Linq.Enumerable+WhereArrayIterator<System.Object>``|True :warning:|54|3’024
|``System.Runtime.CompilerServices.InternalsVisibleToAttribute``|False|93|2’976
|``System.Collections.Generic.Dictionary+Entry<System.String,System.UriParser>[]``|False|4|2’880
|``System.Collections.Generic.List<System.Reflection.RuntimePropertyInfo>``|False|72|2’880
|``System.Web.HttpAsyncResult``|False|45|2’880
|``System.Collections.Generic.HashSet+Slot<System.String>[]``|False|25|2’792
|``System.Threading.ThreadPoolWorkQueue+WorkStealingQueue``|False|58|2’784
|``System.Threading.Tasks.Task<System.Tuple<System.Int32,System.Int32,System.Int32,System.Boolean>>``|True :warning:|34|2’720
|``System.Security.Principal.GenericIdentity``|False|20|2’720
|``System.Reflection.RuntimeFieldInfo[]``|False|42|2’712
|``System.TimeSpan``|False|112|2’688
|``System.Linq.Enumerable+<ZipIterator>d__61<System.Reflection.ParameterInfo,System.Reflection.ParameterInfo,System.Boolean>``|True :warning:|28|2’688
|``System.Web.FileMonitor``|False|30|2’640
|``System.Runtime.CompilerServices.IUnknownConstantAttribute[]``|False|107|2’632
|``System.Runtime.CompilerServices.IDispatchConstantAttribute[]``|False|107|2’632
|``System.Runtime.CompilerServices.DateTimeConstantAttribute[]``|False|107|2’632
|``System.Runtime.CompilerServices.DecimalConstantAttribute[]``|False|107|2’632
|``System.Runtime.Serialization.Formatters.Binary.SerObjectInfoCache``|False|40|2’560
|``System.Web.HttpContext``|False|6|2’544
|``Microsoft.CSharp.RuntimeBinder.Semantics.SubstContext``|False|52|2’496
|``System.Text.RegularExpressions.RegexFCD``|False|52|2’496
|``System.Reflection.RuntimeEventInfo[]``|False|17|2’480
|``System.Xml.XmlNamespaceManager``|False|34|2’448
|``System.Collections.DictionaryEntry``|False|76|2’432
|``System.Collections.Generic.HashSet<System.String>``|False|38|2’432
|``System.WeakReference``|False|101|2’424
|``Microsoft.CSharp.RuntimeBinder.Syntax.Name[]``|False|42|2’352
|``System.Linq.Enumerable+WhereArrayIterator<System.Reflection.MemberInfo>``|True :warning:|42|2’352
|``System.Web.HttpRequest``|False|6|2’352
|``System.Collections.Generic.Dictionary+Entry<System.Type,System.Runtime.Serialization.Formatters.Binary.TypeInformation>[]``|False|7|2’352
|``System.Text.RegularExpressions.RegexFC``|False|73|2’336
|``System.Threading.ThreadPoolWorkQueueThreadLocals``|False|58|2’320
|``System.ComponentModel.TypeDescriptionProviderAttribute[]``|False|73|2’304
|``System.Runtime.Versioning.FrameworkName``|False|48|2’304
|``System.Text.RegularExpressions.RegexCharClass+SingleRange``|False|95|2’280
|``System.Runtime.Serialization.ObjectHolder[]``|False|6|2’256
|``System.Web.Configuration.MapPathCacheInfo``|False|56|2’240
|``System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData``|False|28|2’240
|``System.Collections.Generic.List<System.Web.HttpApplication+IExecutionStep>``|False|56|2’240
|``System.Threading.TimerQueueTimer``|False|25|2’200
|``Microsoft.CSharp.RuntimeBinder.Semantics.NamespaceSymbol``|False|21|2’184
|``System.Runtime.Remoting.Metadata.SoapTypeAttribute[]``|False|77|2’168
|``System.Text.RegularExpressions.ExclusiveReference``|False|53|2’120
|``System.Collections.Generic.List<System.Text.RegularExpressions.RegexOptions>``|False|52|2’080
|``System.Web.HttpResponse``|False|6|2’064
|``Microsoft.CSharp.RuntimeBinder.Semantics.TypeParameterSymbol``|False|17|2’040
|``System.Web.HttpServerVarsCollectionEntry``|False|51|2’040
|``System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo[]``|False|44|2’024
|``System.Collections.Generic.Dictionary+Entry<System.String,System.Web.Hosting.LockableAppDomainContext>[]``|False|21|2’016
|``System.Configuration.ConfigurationElementCollection+Enumerator``|False|42|2’016
|``System.Reflection.PropertyInfo[]``|False|23|2’016
|``System.Web.WebPages.Instrumentation.InstrumentationService+<>c__DisplayClass4``|False|36|2’016
|``System.Web.WebPages.Instrumentation.InstrumentationService+<>c__DisplayClass1``|False|36|2’016
|``System.Reflection.RuntimeMethodInfo[][]``|False|25|2’000
|``Microsoft.CSharp.RuntimeBinder.Semantics.CONSTVAL[]``|False|49|1’968
|``System.Collections.Generic.List<Microsoft.CSharp.RuntimeBinder.Syntax.Name>``|False|49|1’960
|``System.Web.NotificationContext``|False|35|1’960
|``System.Globalization.NumberFormatInfo``|False|9|1’944
|``Microsoft.CSharp.RuntimeBinder.Semantics.TypeArray``|False|80|1’920
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Reflection.Assembly,System.String>``|False|40|1’920
|``System.Runtime.CompilerServices.TypeForwardedFromAttribute[]``|False|62|1’896
|``System.IO.FileStream``|True :warning:|18|1’872
|``System.Random``|False|58|1’856
|``System.String[,]``|False|1|1’832
|``System.Web.Configuration.BuildProvider+ConfigurationBuildProviderInfo``|False|38|1’824
|``System.SZArrayHelper+SZGenericArrayEnumerator<System.Reflection.ParameterInfo>``|True :warning:|57|1’824
|``Microsoft.CSharp.RuntimeBinder.Semantics.MethodSymbol[]``|False|2|1’792
|``System.Runtime.Serialization.Formatters.Binary.ReadObjectInfo``|False|14|1’792
|``System.Globalization.TextInfo``|False|20|1’760
|``System.Configuration.RuntimeConfigurationRecord``|False|11|1’760
|``System.Configuration.PropertyInformationCollection``|False|20|1’760
|``System.Security.Claims.Claim``|False|20|1’760
|``System.Configuration.ConfigurationPropertyCollection``|False|72|1’728
|``System.Xml.NameTable``|False|36|1’728
|``System.Xml.XmlTextReaderImpl+XmlContext``|False|36|1’728
|``System.Web.WebPages.Instrumentation.HttpContextAdapter``|False|72|1’728
|``System.Web.WebPages.Instrumentation.PageInstrumentationServiceAdapter``|False|72|1’728
|``System.Text.RegularExpressions.Group``|False|27|1’728
|``System.Func<System.Runtime.Serialization.MemberHolder,System.Reflection.MemberInfo[]>``|False|27|1’728
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Runtime.Serialization.MemberHolder,System.Reflection.MemberInfo[]>``|False|36|1’728
|``System.Web.Caching.CacheDependency+DepFileInfo[]``|False|54|1’720
|``System.Text.RegularExpressions.RegexCharClass+SingleRangeComparer``|False|71|1’704
|``System.Web.Caching.CacheDependency+DepFileInfo``|False|53|1’696
|``System.Text.RegularExpressions.SharedReference``|False|53|1’696
|``System.Collections.Generic.Dictionary<System.String,System.Web.Hosting.LockableAppDomainContext>``|False|21|1’680
|``System.UInt32[]``|False|7|1’680
|``System.Linq.Expressions.Compiler.LabelScopeInfo``|False|42|1’680
|``System.Collections.Generic.Dictionary+Enumerator<System.String,System.Object>``|True :warning:|30|1’680
|``System.CodeDom.Compiler.CompilerParameters``|False|15|1’680
|``System.Runtime.Remoting.ServerIdentity``|False|11|1’672
|``System.Threading.TimerCallback``|False|26|1’664
|``System.Web.Caching.CacheSingle``|True :warning:|16|1’664
|``System.Collections.Specialized.OrderedDictionary``|False|26|1’664
|``System.Func<System.Reflection.MemberInfo,System.Boolean>``|False|26|1’664
|``System.Runtime.Serialization.FixupHolder``|False|41|1’640
|``System.Runtime.InteropServices.ComVisibleAttribute``|False|68|1’632
|``System.Web.Configuration.Common.ModulesEntry``|False|51|1’632
|``System.Collections.Generic.Dictionary+Entry<System.Web.Util.AppVerifierErrorCode,System.String>[]``|False|4|1’632
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.String,System.Boolean>[]``|False|6|1’632
|``System.Collections.Generic.List+Enumerator<System.String>``|True :warning:|40|1’600
|``System.Threading.Tasks.ContinuationTaskFromTask``|True :warning:|20|1’600
|``Microsoft.Owin.Host.SystemWeb.CallEnvironment.AspNetDictionary``|False|5|1’600
|``System.Collections.Generic.HashSet+Slot<System.Type>[]``|False|18|1’584
|``System.Runtime.InteropServices.UnmanagedType[]``|False|49|1’572
|``Microsoft.Win32.RegistryKey``|True :warning:|28|1’568
|``Microsoft.CSharp.RuntimeBinder.Semantics.EXPRMEMGRP``|False|13|1’560
|``System.Web.Mvc.Async.SingleEntryGate``|False|65|1’560
|``System.ComponentModel.EventHandlerList+ListEntry``|False|39|1’560
|``System.Web.HttpRequestWrapper``|False|64|1’536
|``System.Collections.Generic.HashSet<Microsoft.CSharp.RuntimeBinder.Semantics.KAID>``|False|24|1’536
|``System.Collections.Generic.Dictionary<System.String,System.String>``|False|19|1’520
|``System.Xml.XmlDocument``|False|5|1’520
|``System.Web.Hosting.IIS7WorkerRequest``|False|5|1’520
|``System.Configuration.MgmtConfigurationRecord``|False|7|1’512
|``System.Web.PreApplicationStartMethodAttribute[]``|False|14|1’504
|``System.Runtime.Serialization.LongList``|False|37|1’480
|``System.AppDomain+CAPTCASearcher``|False|61|1’464
|``System.Security.AllowPartiallyTrustedCallersAttribute``|False|61|1’464
|``System.Collections.Generic.Dictionary+Entry<System.String,System.AppContext+SwitchValueState>[]``|False|6|1’440
|``System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Compiler.VariableStorageKind>``|False|18|1’440
|``System.Runtime.Remoting.Metadata.SoapTypeAttribute``|False|18|1’440
|``System.Collections.Generic.Dictionary<System.String,System.Web.Mvc.ModelState>``|False|18|1’440
|``System.Threading.Tasks.Task+ContingentProperties``|False|20|1’440
|``System.Globalization.TimeSpanParse+TimeSpanToken[]``|False|10|1’440
|``System.Web.Configuration.RegexWorker``|False|45|1’440
|``System.Runtime.Serialization.SerializationEvents``|False|30|1’440
|``System.Resources.NeutralResourcesLanguageAttribute``|False|44|1’408
|``System.Configuration.ConfigurationValues+ConfigurationElementsCollection+<System-Collections-IEnumerable-GetEnumerator>d__2``|True :warning:|35|1’400
|``System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>``|False|25|1’400
|``System.Threading.ThreadPoolWorkQueue+WorkStealingQueue[]``|False|5|1’400
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.String,System.Boolean>``|False|35|1’400
|``System.Reflection.RuntimePropertyInfo[][]``|False|17|1’392
|``System.Web.Mobile.MobileCapabilities``|False|3|1’392
|``System.Reflection.Emit.DynamicILGenerator``|False|9|1’368
|``System.AssemblyLoadEventArgs``|False|57|1’368
|``System.Web.HttpBrowserCapabilities``|False|3|1’368
|``System.Xml.XmlUrlResolver``|False|34|1’360
|``System.Text.UTF8Encoding+UTF8Decoder``|False|24|1’344
|``System.Runtime.Serialization.SerializationInfoEnumerator``|False|24|1’344
|``System.Collections.Generic.Dictionary+Entry<System.String,System.ComponentModel.EventDescriptor>[]``|False|2|1’344
|``System.Runtime.Serialization.Formatters.Binary.ObjectMap``|False|14|1’344
|``System.Text.RegularExpressions.GroupCollection``|False|33|1’320
|``System.Linq.Expressions.Expression[]``|False|34|1’304
|``System.Reflection.Assembly[]``|False|31|1’296
|``System.Runtime.Remoting.Metadata.RemotingTypeCachedData``|False|18|1’296
|``System.Runtime.CompilerServices.RuntimeCompatibilityAttribute``|False|54|1’296
|``System.Runtime.Serialization.MemberHolder``|False|27|1’296
|``System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimePropertyInfo>``|False|23|1’288
|``System.UriParser+BuiltInUriParser``|False|32|1’280
|``System.Web.HttpApplication+SyncEventExecutionStep``|False|40|1’280
|``System.CLSCompliantAttribute``|False|53|1’272
|``System.Runtime.CompilerServices.CompilationRelaxationsAttribute``|False|53|1’272
|``System.Diagnostics.DebuggableAttribute``|False|53|1’272
|``System.Reflection.AssemblyTitleAttribute``|False|53|1’272
|``System.Reflection.AssemblyDescriptionAttribute``|False|53|1’272
|``System.Text.RegularExpressions.RegexOptions[]``|False|32|1’264
|``System.Collections.Specialized.StringCollection``|False|52|1’248
|``System.Reflection.AssemblyCompanyAttribute``|False|52|1’248
|``System.Reflection.AssemblyCopyrightAttribute``|False|52|1’248
|``System.Reflection.AssemblyFileVersionAttribute``|False|52|1’248
|``System.Xml.XmlText``|False|31|1’240
|``System.Runtime.Serialization.Formatters.Binary.TypeInformation``|False|31|1’240
|``Microsoft.CSharp.RuntimeBinder.Semantics.EXPRCALL``|False|11|1’232
|``System.Reflection.AssemblyProductAttribute``|False|51|1’224
|``System.Func<System.Reflection.MethodInfo,System.Boolean>``|False|19|1’216
|``System.WeakReference[]``|False|14|1’200
|``System.Threading.Tasks.TaskCompletionSource<System.Object>``|False|50|1’200
|``System.Xml.XmlAttribute``|False|30|1’200
|``System.Collections.Generic.List+Enumerator<System.Web.Routing.PathSubsegment>``|True :warning:|30|1’200
|``System.Web.Configuration.EventMappingSettings``|False|10|1’200
|``System.Security.Claims.Claim[]``|False|22|1’168
|``System.AppDomainSetup``|False|9|1’152
|``System.Text.UTF8Encoding``|False|24|1’152
|``System.Configuration.BaseConfigurationRecord+ConfigRecordStreamInfo``|False|18|1’152
|``Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder+PfnBindBinOp``|False|18|1’152
|``System.Text.RegularExpressions.RegexCharClass+LowerCaseMapping[]``|False|1|1’152
|``System.Web.Mvc.VirtualPathProviderViewEngine+ViewLocation``|False|48|1’152
|``System.Collections.Generic.Dictionary+Entry<System.Type,System.Security.Policy.EvidenceTypeDescriptor>[]``|False|4|1’152
|``System.Reflection.AssemblyName[]``|False|13|1’128
|``Microsoft.CSharp.RuntimeBinder.Semantics.PredefinedTypeFacts+PredefinedTypeInfo[]``|False|1|1’128
|``Microsoft.CSharp.RuntimeBinder.Semantics.AggregateSymbol[]``|False|1|1’128
|``Microsoft.Win32.SafeHandles.SafeRegistryHandle``|True :warning:|35|1’120
|``System.ComponentModel.AttributeCollection``|False|28|1’120
|``System.Web.Configuration.ExpressionBuilder``|False|10|1’120
|``System.Web.Util.SynchronizationHelper+<>c__DisplayClass21_0``|False|35|1’120
|``System.Configuration.ConfigXmlAttribute``|False|20|1’120
|``System.Configuration.ConfigXmlText``|False|20|1’120
|``System.Collections.Generic.Dictionary+Enumerator<System.String,System.Web.Hosting.LockableAppDomainContext>``|True :warning:|20|1’120
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Runtime.Serialization.MemberHolder,System.Reflection.MemberInfo[]>[]``|False|3|1’104
|``System.Tuple<System.Int32,System.Int32,System.Int32,System.Boolean>``|False|34|1’088
|``System.Web.HttpHeaderCollection``|False|8|1’088
|``System.Runtime.Serialization.Formatters.Binary.NameInfo``|False|17|1’088
|``Microsoft.CSharp.RuntimeBinder.Semantics.EXPRCLASS``|False|15|1’080
|``System.Linq.Enumerable+WhereArrayIterator<System.Reflection.MethodInfo>``|True :warning:|19|1’064
|``System.Runtime.Serialization.Formatters.Binary.BinaryTypeEnum[]``|False|28|1’064
|``System.SZArrayHelper+SZGenericArrayEnumerator<System.Linq.Expressions.ParameterExpression>``|True :warning:|33|1’056
|``System.Reflection.TypeAttributes``|False|44|1’056
|``System.Runtime.Serialization.Formatters.Binary.ParseRecord``|False|4|1’056
|``System.Dynamic.Utils.CacheDict+Entry<System.Reflection.MethodBase,System.Reflection.ParameterInfo[]>[]``|False|1|1’048
|``System.Web.Util.DoubleLinkList``|False|26|1’040
|``System.Web.Caching.UsageBucket[]``|False|16|1’024
|``System.Action<System.Threading.Tasks.Task>``|False|16|1’024
|``System.Configuration.KeyValueConfigurationElement``|False|8|1’024
|``System.Collections.Generic.HashSet<System.Type>``|False|16|1’024
|``System.Runtime.Serialization.FixupHolder[]``|False|25|1’016
|``System.Collections.Generic.Dictionary+Entry<System.String,System.Object[]>[]``|False|5|1’008
|``System.Linq.Expressions.Compiler.LambdaCompiler``|False|9|1’008
|``System.Reflection.Emit.DynamicMethod``|False|9|1’008
|``Microsoft.CSharp.RuntimeBinder.Syntax.NameManager+KnownName[]``|False|2|1’008
|``System.Reflection.CerHashtable+Table<System.String,System.Reflection.RuntimeMethodInfo[]>``|False|25|1’000
|``System.Threading.Tasks.StandardTaskContinuation``|False|25|1’000
|``System.Web.Hosting.AspNetHostExecutionContextManager+<>c__DisplayClass3_1``|False|31|992
|``System.Runtime.Remoting.Identity``|False|11|968
|``System.Web.HttpApplication+AsyncEventExecutionStep``|False|11|968
|``System.Text.EncoderReplacementFallback``|False|30|960
|``System.Text.DecoderReplacementFallback``|False|30|960
|``System.Web.Configuration.CacheSection``|False|8|960
|``System.Collections.Generic.Dictionary<System.Linq.Expressions.LabelTarget,System.Linq.Expressions.Compiler.LabelInfo>``|False|12|960
|``System.Web.Hosting.AspNetHostExecutionContextManager+RevertAction``|False|15|960
|``System.Collections.Generic.HashSet+Slot<Microsoft.CSharp.RuntimeBinder.Semantics.KAID>[]``|False|16|960
|``Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder+BinOpSig``|False|20|960
|``System.Web.PipelineModuleStepContainer``|False|30|960
|``System.Text.RegularExpressions.MatchCollection``|False|15|960
|``System.Configuration.StreamInfo``|False|17|952
|``System.Security.Permissions.SecurityPermission``|False|39|936
|``System.Diagnostics.SourceSwitch``|False|13|936
|``System.Collections.Generic.List<System.Security.Claims.Claim>``|False|23|920
|``System.Collections.Generic.List<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>>``|False|23|920
|``System.Configuration.ConfigXmlReader``|True :warning:|19|912
|``System.Reflection.AssemblyInformationalVersionAttribute``|False|38|912
|``System.Web.HttpWriter``|True :warning:|6|912
|``System.Web.Caching.CacheExpires``|False|16|896
|``System.Configuration.RuntimeConfigurationRecord+RuntimeConfigurationFactory``|False|28|896
|``System.Runtime.Versioning.TargetFrameworkAttribute``|False|28|896
|``Microsoft.CSharp.RuntimeBinder.Semantics.PredefinedMethodInfo[]``|False|1|896
|``System.Func<System.String,System.Boolean>``|False|14|896
|``Microsoft.CSharp.RuntimeBinder.Semantics.EXPRLIST``|False|11|880
|``System.Diagnostics.DefaultTraceListener``|True :warning:|11|880
|``System.Web.Configuration.HttpRuntimeSection``|False|5|880
|``System.Runtime.Remoting.Proxies.RemotingProxy``|False|11|880
|``Microsoft.Win32.SafeHandles.SafeAccessTokenHandle``|True :warning:|27|864
|``System.SZArrayHelper+SZGenericArrayEnumerator<System.Type>``|True :warning:|27|864
|``System.Collections.Generic.Dictionary+Entry<System.Object,System.Linq.Expressions.Compiler.CompilerScope>[]``|False|9|864
|``System.Collections.Generic.Dictionary+Entry<System.Linq.Expressions.LambdaExpression,System.Linq.Expressions.Compiler.BoundConstants>[]``|False|9|864
|``System.Reflection.Emit.SignatureHelper``|False|18|864
|``System.Configuration.ProviderSettings``|False|6|864
|``System.Linq.Enumerable+<UnionIterator>d__67<System.String>``|True :warning:|9|864
|``System.UnitySerializationHolder``|False|12|864
|``System.IO.DirectoryInfo[]``|False|12|848
|``System.Configuration.ConfigurationValues+ConfigurationElementsCollection``|False|35|840
|``System.Linq.Expressions.ParameterExpression[]``|False|27|840
|``System.Web.Util.DisposableAction``|True :warning:|35|840
|``System.Web.Mvc.ViewDataDictionary<System.Object>``|False|15|840
|``System.Collections.Generic.Dictionary+Enumerator<System.String,System.Web.Mvc.ModelState>``|True :warning:|15|840
|``System.IO.FileInfo[]``|False|6|840
|``System.Web.Caching.CacheItemRemovedCallback``|False|13|832
|``System.Web.CachedPathData``|False|13|832
|``System.Collections.Specialized.OrderedDictionary+OrderedDictionaryKeyValueCollection``|False|26|832
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Reflection.Assembly,System.String>[]``|False|2|832
|``System.Delegate[]``|False|23|824
|``System.Threading.ManualResetEvent``|True :warning:|17|816
|``Microsoft.CSharp.RuntimeBinder.Semantics.TypeParameterType``|False|17|816
|``System.UInt64[]``|False|9|816
|``System.SByte[]``|False|6|816
|``System.Runtime.CompilerServices.ExtensionAttribute``|False|34|816
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.String,System.Object>``|False|17|816
|``System.Threading.Timer``|True :warning:|25|800
|``System.Configuration.ElementInformation``|False|20|800
|``System.Collections.Generic.Dictionary<System.String,System.Reflection.RuntimeEventInfo>``|False|10|800
|``System.Diagnostics.Stopwatch``|False|20|800
|``System.CodeDom.Compiler.CompilerInfo``|False|10|800
|``System.Security.Policy.EvidenceTypeDescriptor``|False|20|800
|``System.Linq.Expressions.Compiler.CompilerScope``|False|9|792
|``System.Configuration.ConfigXmlElement``|False|11|792
|``System.Runtime.Serialization.Formatters.Binary.ValueFixup``|False|11|792
|``System.IO.StringWriter``|True :warning:|14|784
|``System.Xml.XmlElement``|False|14|784
|``System.Collections.Specialized.NameValueCollection``|False|8|768
|``System.Collections.Generic.Dictionary+Entry<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Compiler.VariableStorageKind>[]``|False|8|768
|``System.Collections.Generic.Dictionary+Entry<System.Linq.Expressions.ParameterExpression,System.Int32>[]``|False|8|768
|``System.Collections.Generic.Dictionary+Entry<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Compiler.CompilerScope+Storage>[]``|False|8|768
|``System.Security.Permissions.SecurityPermissionAttribute``|False|24|768
|``System.Func<System.String,System.Diagnostics.TraceSource>``|False|12|768
|``System.Runtime.Serialization.FixupHolderList``|False|24|768
|``System.IO.StringReader``|True :warning:|19|760
|``System.Xml.XmlChildEnumerator``|False|19|760
|``System.Collections.ObjectModel.Collection<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>>``|False|23|736
|``System.Web.DirMonCompletion``|True :warning:|10|720
|``System.Configuration.ConfigurationSchemaErrors``|False|18|720
|``System.Web.Configuration.TrustSection``|False|6|720
|``System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>``|False|18|720
|``System.Collections.Generic.Dictionary<System.Object,System.Linq.Expressions.Compiler.CompilerScope>``|False|9|720
|``System.Collections.Generic.Dictionary<System.Linq.Expressions.LambdaExpression,System.Linq.Expressions.Compiler.BoundConstants>``|False|9|720
|``System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Linq.Expressions.Compiler.CompilerScope+Storage>``|False|9|720
|``System.Collections.Generic.Dictionary<System.Object,System.Int32>``|False|9|720
|``System.Collections.Generic.Dictionary<System.Linq.Expressions.Compiler.BoundConstants+TypedConstant,System.Int32>``|False|9|720
|``System.Collections.Generic.Dictionary<System.Linq.Expressions.Compiler.BoundConstants+TypedConstant,System.Reflection.Emit.LocalBuilder>``|False|9|720
|``System.Collections.Generic.Dictionary<System.Type,System.Collections.Generic.Queue<System.Reflection.Emit.LocalBuilder>>``|False|9|720
|``System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Reflection.RuntimePropertyInfo>>``|False|9|720
|``ASP._Page_Views_Home_Index_cshtml``|False|3|720
|``System.Collections.Generic.Dictionary+Entry<Microsoft.CSharp.RuntimeBinder.Semantics.TypeParameterSymbol,Microsoft.CSharp.RuntimeBinder.Semantics.TypeParameterType>[]``|False|3|720
|``Microsoft.Owin.Host.SystemWeb.OwinCallContext``|True :warning:|5|720
|``System.Linq.Enumerable+<ConcatIterator>d__59<System.String>``|True :warning:|10|720
|``ASP.global_asax``|True :warning:|3|720
|``System.ComponentModel.ReflectPropertyDescriptor``|False|3|720
|``System.Web.HttpCookieCollection``|False|6|720
|``System.Text.RegularExpressions.Group[]``|False|21|720
|``System.Reflection.MdFieldInfo``|False|10|720
|``System.CtorDelegate``|False|11|704
|``System.Runtime.Remoting.Messaging.IllogicalCallContext``|False|22|704
|``System.Runtime.Remoting.ObjRef``|False|11|704
|``System.Web.BeginEventHandler``|False|11|704
|``System.Web.EndEventHandler``|False|11|704
|``Microsoft.CSharp.RuntimeBinder.Semantics.PropertySymbol``|False|3|696
|``System.Web.Routing.RouteValueDictionary``|False|29|696
|``System.Web.Mvc.VirtualPathProviderViewEngine+ViewLocation[]``|False|13|696
|``System.Reflection.CerHashtable+Table<System.String,System.Reflection.RuntimePropertyInfo[]>``|False|17|680
|``AspNetCrash.Web.Controllers.HomeController``|True :warning:|5|680
|``System.Web.Mvc.Async.AsyncResultWrapper+WrappedAsyncResult<System.Web.Mvc.ActionResult,System.Web.Mvc.Async.AsyncControllerActionInvoker+ActionInvocation>``|False|5|680
|``System.Web.ModuleConfigurationInfo``|False|17|680
|``System.Linq.Expressions.Compiler.StackSpiller+ChildRewriter``|False|12|672
|``System.Linq.Expressions.Compiler.LabelInfo``|False|6|672
|``System.Xml.XmlAttributeCollection``|False|21|672
|``System.Resources.SatelliteContractVersionAttribute``|False|28|672
|``System.Reflection.AssemblySignatureKeyAttribute``|False|21|672
|``System.Reflection.AssemblyMetadataAttribute``|False|21|672
|``System.Configuration.ProviderSettingsCollection``|False|4|672
|``System.Security.SecurityElement``|False|12|672
|``System.Configuration.ErrorInfoXmlDocument``|False|2|656
|``System.Security.Principal.WindowsIdentity``|True :warning:|3|648
|``System.Linq.Expressions.StackGuard``|False|27|648
|``System.Reflection.Emit.DynamicResolver``|False|9|648
|``Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder+ImplicitConversion``|False|9|648
|``System.Reflection.AssemblyDefaultAliasAttribute``|False|27|648
|``System.Runtime.Serialization.FormatterServices+<>c__DisplayClass9_0``|False|27|648
|``System.Threading.WaitCallback``|False|10|640
|``System.Web.DirectoryMonitor``|True :warning:|10|640
|``System.Web.NativeFileChangeNotification``|False|10|640
|``System.Web.Caching.CacheUsage``|False|16|640
|``Microsoft.Win32.SafeHandles.SafeWaitHandle``|True :warning:|20|640
|``<>f__AnonymousType0<System.Collections.Hashtable,System.Web.Caching.CacheExpires,System.Web.Caching.CacheUsage>``|False|16|640
|``System.Configuration.XmlUtil``|True :warning:|10|640
|``System.Web.Configuration.TrustLevel``|False|5|640
|``System.Configuration.ConfigurationLockCollection``|False|10|640
|``System.Runtime.CompilerServices.TrueReadOnlyCollection<System.Linq.Expressions.ParameterExpression>``|False|20|640
|``System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Int32>``|False|8|640
|``Microsoft.Owin.Host.SystemWeb.IntegratedPipeline.StageAsyncResult``|False|10|640
|``System.Threading.ContextCallback``|False|10|640
|``System.Func<System.Threading.Tasks.Task<System.Threading.Tasks.TaskHelpersExtensions+AsyncVoid>>``|False|10|640
|``System.Configuration.AppSettingsSection``|False|5|640
|``Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder+UnaOpSig``|False|16|640
|``System.Security.Principal.GenericPrincipal``|False|10|640
|``System.Security.Claims.ClaimsIdentity[]``|False|12|640
|``System.Web.Mvc.Async.AsyncResultWrapper+WrappedAsyncVoid<System.Web.Mvc.MvcHandler+ProcessRequestState>``|False|5|640
|``System.Web.Mvc.Async.AsyncResultWrapper+WrappedAsyncVoid<System.Web.Mvc.Controller+ExecuteCoreState>``|False|5|640
|``System.Web.Mvc.Filter[]``|False|12|640
|``System.Web.Mvc.Async.BeginInvokeDelegate``|False|10|640
|``System.Func<System.Web.Mvc.ActionExecutedContext>``|False|10|640
|``System.Collections.Generic.List<System.Runtime.Serialization.SerializationFieldInfo>``|False|16|640
|``System.Collections.Generic.KeyValuePair<System.Type,System.Security.Policy.EvidenceTypeDescriptor>``|False|20|640
|``System.IO.UnmanagedMemoryStream``|True :warning:|6|624
|``Microsoft.CSharp.RuntimeBinder.Semantics.EXPRBINOP``|False|6|624
|``System.Security.SecurityRulesAttribute``|False|26|624
|``System.Reflection.AssemblyConfigurationAttribute``|False|26|624
|``System.AppDomainManager``|False|13|624
|``System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE``|False|26|624
|``System.Diagnostics.Tracing.EventSource+OverideEventProvider``|True :warning:|7|616
|``System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeEventInfo>``|False|11|616
|``System.Runtime.Remoting.Proxies.__TransparentProxy``|False|11|616
|``System.Int64[,]``|False|1|616
|``System.Collections.ArrayList[,]``|False|1|616
|``System.Threading.TimerHolder``|False|25|600
|``__DynamicallyInvokableAttribute``|False|25|600
|``System.Runtime.Versioning.FrameworkName[]``|False|5|600
|``System.Xml.XmlChildNodes``|True :warning:|25|600
|``System.Reflection.AssemblyDelaySignAttribute``|False|25|600
|``System.Reflection.AssemblyKeyFileAttribute``|False|25|600
|``System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute``|False|25|600
|``System.Reflection.AssemblyTrademarkAttribute``|False|25|600
|``System.Web.SessionState.SessionStateModule``|False|3|600
|``System.Text.RegularExpressions.MatchEnumerator``|False|15|600
|``System.Web.Routing.PathSubsegment[]``|False|11|584
|``System.Collections.Generic.Dictionary+Entry<System.String,System.Globalization.CultureData>[]``|False|4|576
|``System.Configuration.Internal.FileVersion``|False|12|576
|``System.Web.Util.HashCodeCombiner``|False|24|576
|``Microsoft.Win32.SafeHandles.SafeFileHandle``|True :warning:|18|576
|``System.Guid[]``|False|8|576
|``Microsoft.CSharp.RuntimeBinder.ExpressionTreeCallRewriter+ExpressionEXPR``|False|8|576
|``System.Linq.Expressions.UnaryExpression``|False|12|576
|``System.Collections.Generic.Dictionary+Entry<System.Linq.Expressions.LabelTarget,System.Linq.Expressions.Compiler.LabelInfo>[]``|False|6|576
|``System.Func<System.Linq.Expressions.ParameterExpression,System.Boolean>``|False|9|576
|``System.Collections.Generic.Dictionary+Entry<System.Linq.Expressions.Compiler.LabelScopeInfo,System.Object>[]``|False|6|576
|``System.Linq.Enumerable+<ConcatIterator>d__59<System.Reflection.MemberInfo>``|True :warning:|8|576
|``System.Uri``|False|8|576
|``System.Web.WebPages.DisplayModeProvider+<GetAvailableDisplayModesForContext>d__4``|True :warning:|6|576
|``System.Collections.Generic.Dictionary+Entry<System.RuntimeType,System.RuntimeType>[]``|False|2|576
|``System.Linq.Expressions.Compiler.CompilerScope+ArgumentStorage``|False|14|560
|``System.Collections.Generic.List<System.Linq.Expressions.Compiler.LambdaCompiler+WriteBack>``|False|14|560
|``System.Collections.Generic.List+Enumerator<System.Linq.Expressions.Compiler.LambdaCompiler+WriteBack>``|True :warning:|14|560
|``System.Web.SessionState.SessionStateItemCollection``|False|5|560
|``System.Web.Mvc.Async.AsyncResultWrapper+WrappedAsyncVoid<System.Web.Mvc.Controller>``|False|5|560
|``System.Runtime.Serialization.Formatters.Binary.ObjectMapInfo``|False|14|560
|``System.Diagnostics.SourceLevels``|False|23|552
|``System.Web.HttpRuntime``|False|2|544
|``System.Guid``|False|17|544
|``Microsoft.CSharp.RuntimeBinder.SymbolTable+NameHashKey``|False|17|544
|``Microsoft.CSharp.RuntimeBinder.Semantics.SymWithType``|False|17|544
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.String,System.Diagnostics.TraceSource>[]``|False|2|544
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.String,System.Object>[]``|False|2|544
|``System.Dynamic.Utils.CacheDict+Entry<System.Type,System.Reflection.MethodInfo>[]``|False|1|536
|``System.Runtime.InteropServices.GuidAttribute``|False|22|528
|``System.Linq.Expressions.Compiler.CompilerScope[]``|False|10|528
|``System.Linq.Expressions.Compiler.BoundConstants[]``|False|10|528
|``Microsoft.CSharp.RuntimeBinder.Semantics.LocalVariableSymbol``|False|6|528
|``System.Web.WebPages.WebPageContext``|False|6|528
|``System.Linq.Lookup+<GetEnumerator>d__12<System.String,System.Type>``|True :warning:|11|528
|``System.ComponentModel.AttributeCollection+AttributeEntry[]``|False|5|520
|``System.Dynamic.Utils.CacheDict+Entry<System.Reflection.MethodBase,System.Reflection.ParameterInfo[]>``|False|13|520
|``System.Runtime.Remoting.Messaging.ConstructorCallMessage``|False|5|520
|``System.Web.Mvc.FilterAttributeFilterProvider+<GetFilters>d__0``|True :warning:|5|520
|``System.Web.Mvc.Async.AsyncResultWrapper+WrappedAsyncResult<System.Boolean>``|False|5|520
|``System.Web.Mvc.Async.AsyncResultWrapper+WrappedAsyncResult<System.Web.Mvc.ActionExecutedContext>``|False|5|520
|``System.Web.Caching.SRef``|False|16|512
|``Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder+PfnBindUnaOp``|False|8|512
|``System.Threading.ReaderWriterLock``|False|8|512
|``System.Web.Configuration.CompilationSection``|False|3|504
|``System.Linq.Expressions.Compiler.VariableBinder``|False|9|504
|``System.Linq.Enumerable+WhereEnumerableIterator<System.Linq.Expressions.ParameterExpression>``|True :warning:|9|504
|``System.IO.BinaryReader``|True :warning:|7|504
|``System.Collections.Generic.HashSet+Slot<Microsoft.CSharp.RuntimeBinder.SymbolTable+NameHashKey>[]``|False|3|504
|``System.ComponentModel.EventDescriptor[]``|False|4|496
|``System.Int64``|False|20|480
|``System.Configuration.IntegerValidator``|False|15|480
|``Microsoft.CSharp.RuntimeBinder.Semantics.EXPRCONSTANT``|False|6|480
|``Microsoft.CSharp.RuntimeBinder.Semantics.CMemberLookupResults``|False|15|480
|``System.Threading.CompressedStack``|False|12|480
|``System.Collections.Generic.Dictionary<System.Linq.Expressions.Compiler.LabelScopeInfo,System.Object>``|False|6|480
|``System.Web.Hosting.AspNetHostExecutionContextManager+<>c__DisplayClass3_0``|False|15|480
|``System.Threading.Tasks.Task<System.Threading.Tasks.TaskHelpersExtensions+AsyncVoid>``|True :warning:|6|480
|``System.Collections.Generic.Dictionary+Entry<System.Linq.Expressions.ParameterExpression,System.Object>[]``|False|5|480
|``System.Web.HttpContextWrapper``|False|20|480
|``System.Collections.Specialized.ListDictionary+NodeEnumerator``|False|12|480
|``System.Security.Permissions.EnvironmentPermission``|False|12|480
|``System.Security.Permissions.EnvironmentStringExpressionSet``|False|10|480
|``System.SZArrayHelper+SZGenericArrayEnumerator<System.String>``|True :warning:|15|480
|``System.Collections.Generic.Dictionary+ValueCollection<System.String,System.Web.Hosting.LockableAppDomainContext>``|False|20|480
|``System.Windows.Markup.XmlnsDefinitionAttribute``|False|12|480
|``System.Web.RootedObjects``|False|5|480
|``System.Web.Mvc.Async.AsyncControllerActionInvoker+AsyncInvocationWithFilters``|False|5|480
|``System.Web.Configuration.DeploymentSection``|False|4|480
|``System.Reflection.EventInfo[]``|False|3|480
|``System.Collections.Generic.List<System.Web.Mvc.VirtualPathProviderViewEngine+ViewLocation>``|False|12|480
|``System.Web.Mvc.ViewEngineResult``|False|12|480
|``System.Runtime.Serialization.SerializationFieldInfo``|False|12|480
|``System.Web.Caching.CacheDependency+DepCacheInfo[]``|False|15|472
|``Microsoft.CSharp.RuntimeBinder.SymbolTable+<>c__DisplayClass59_0``|False|19|456
|``System.AttributeUsageAttribute``|False|19|456
|``System.Resources.ResourceManager``|False|3|456
|``System.Web.Configuration.HttpCapabilitiesBase``|False|1|456
|``System.Collections.Queue``|False|8|448
|``Microsoft.Win32.UnsafeNativeMethods+ManifestEtw+EtwEnableCallback``|False|7|448
|``System.Web.Caching.CacheDependency+DepCacheInfo``|False|14|448
|``System.Text.UTF8Encoding+UTF8Encoder``|False|8|448
|``System.IO.FileSystemEnumerableIterator<System.IO.DirectoryInfo>``|True :warning:|4|448
|``System.Web.PreApplicationStartMethodAttribute``|False|14|448
|``System.Func<System.String>``|False|7|448
|``System.Web.Configuration.BufferModeSettings``|False|4|448
|``System.Runtime.Serialization.Formatters.Binary.ObjectReader+TypeNAssembly``|False|14|448
|``Microsoft.CSharp.RuntimeBinder.Semantics.MethWithInst``|False|11|440
|``System.Linq.Expressions.InstanceMethodCallExpressionN``|False|11|440
|``System.Web.Util.SynchronizationHelper``|False|5|440
|``System.Web.ThreadContext``|False|5|440
|``System.Collections.Generic.List<System.Security.Claims.ClaimsIdentity>``|False|11|440
|``System.Linq.Lookup+Grouping+<GetEnumerator>d__7<System.String,System.Type>``|True :warning:|11|440
|``System.Threading.Tasks.ContinuationResultTaskFromTask<System.Boolean>``|True :warning:|5|440
|``System.Collections.Generic.List<System.Web.Mvc.Filter>``|False|11|440
|``System.Runtime.Serialization.ValueTypeFixupInfo``|False|11|440
|``System.AppDomain``|False|2|432
|``System.Web.Util.DisposableGCHandleRef<System.Threading.Timer>``|True :warning:|18|432
|``System.Security.Permissions.ReflectionPermission``|False|18|432
|``Microsoft.CSharp.RuntimeBinder.Semantics.EXPRTYPEOF``|False|6|432
|``System.Linq.Expressions.DefaultExpression``|False|18|432
|``System.Linq.Expressions.Compiler.StackSpiller+TempMaker``|False|9|432
|``System.Linq.Expressions.Compiler.BoundConstants``|False|9|432
|``System.Reflection.Emit.DynamicMethod+RTDynamicMethod``|False|9|432
|``System.Reflection.Emit.ScopeTree``|False|9|432
|``System.RuntimeMethodHandle``|False|18|432
|``System.Resources.ResourceFallbackManager+<GetEnumerator>d__5``|True :warning:|9|432
|``System.Web.Mvc.ModelStateDictionary``|False|18|432
|``System.Web.Mvc.HtmlHelper<System.Object>``|False|6|432
|``System.Web.HttpResponseWrapper``|False|18|432
|``System.Web.HttpApplication+AsyncAppEventHandler``|False|9|432
|``System.Globalization.CalendarData[]``|False|2|416
|``Microsoft.CSharp.RuntimeBinder.SymbolTable+<>c__DisplayClass18_1``|False|13|416
|``System.IO.StreamReader``|True :warning:|4|416
|``System.Resources.ResourceReader``|True :warning:|3|408
|``System.Linq.Set+Slot<System.String>[]``|False|3|408
|``System.Runtime.Serialization.Formatters.Binary.ObjectProgress``|False|3|408
|``System.Security.Principal.WindowsImpersonationContext``|True :warning:|10|400
|``Microsoft.CSharp.RuntimeBinder.Semantics.EXPRCAST``|False|5|400
|``System.Web.Hosting.MemoryBytes``|False|5|400
|``System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression,System.Object>``|False|5|400
|``System.Collections.Generic.List+Enumerator<System.Security.Claims.Claim>``|True :warning:|10|400
|``System.Collections.Generic.HashSet+Enumerator<System.Type>``|True :warning:|10|400
|``System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Threading.Tasks.TaskHelpersExtensions+AsyncVoid>>``|True :warning:|5|400
|``System.Threading.Tasks.UnwrapPromise<System.Threading.Tasks.TaskHelpersExtensions+AsyncVoid>``|True :warning:|5|400
|``System.Collections.Generic.List+Enumerator<System.Web.Mvc.Filter>``|True :warning:|10|400
|``System.Collections.Generic.List+Enumerator<System.Web.Mvc.Filters.IAuthenticationFilter>``|True :warning:|10|400
|``System.Web.Mvc.Async.AsyncControllerActionInvoker+AsyncInvocationWithFilters+<>c__DisplayClass41``|False|10|400
|``System.Web.Mvc.ActionExecutedContext``|False|5|400
|``System.Collections.Generic.List<System.Web.Routing.PathSubsegment>``|False|10|400
|``System.Security.Policy.Evidence+EvidenceUpgradeLockHolder``|True :warning:|10|400
|``System.Diagnostics.Tracing.EtwSession[]``|False|7|392
|``System.Globalization.CompareInfo``|False|6|384
|``System.Diagnostics.Tracing.FrameworkEventSource``|True :warning:|2|384
|``System.Reflection.MemberFilter``|False|6|384
|``System.SizedReference``|True :warning:|16|384
|``System.Web.Util.DisposableGCHandleRef<System.Web.Caching.CacheSingle>``|True :warning:|16|384
|``System.Web.TelemetryEventSource``|True :warning:|2|384
|``System.ParamArrayAttribute``|False|16|384
|``System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>``|False|12|384
|``System.Func<System.Web.HttpContextBase,System.Web.WebPages.Instrumentation.PageInstrumentationServiceAdapter>``|False|6|384
|``System.Func<System.String,System.IO.TextWriter,System.Int32,System.Int32,System.Boolean,System.Web.WebPages.Instrumentation.PageExecutionContextAdapter>``|False|6|384
|``System.Func<System.Threading.Tasks.CatchInfo,System.Threading.Tasks.CatchInfoBase+CatchResult<System.Threading.Tasks.Task>>``|False|6|384
|``System.Web.Compilation.PreservationFileReader``|False|8|384
|``System.Web.Mvc.AjaxHelper<System.Object>``|False|6|384
|``System.Func<System.String,System.Web.Mvc.ModelMetadata,System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule>>``|False|6|384
|``System.Threading.ThreadLocal+LinkedSlot<System.Collections.Concurrent.ConcurrentBag+ThreadLocalList<System.Web.HttpApplication>>``|False|8|384
|``System.Web.SessionState.HttpSessionStateContainer``|False|6|384
|``System.Collections.Concurrent.ConcurrentDictionary<System.String,System.Boolean>``|False|6|384
|``System.Func<System.Web.Mvc.IViewEngine,System.Web.Mvc.ViewEngineResult>``|False|6|384
|``System.Web.ValidateStringCallback``|False|6|384
|``System.Runtime.Serialization.SerializationEventHandler``|False|6|384
|``System.Runtime.Serialization.SerializationFieldInfo[]``|False|8|384
|``System.Web.Configuration.FolderLevelBuildProviderCollection``|False|2|368
|``Microsoft.CSharp.RuntimeBinder.Semantics.MemberLookup``|False|2|368
|``System.Globalization.DateTimeFormatInfo``|False|1|368
|``System.Collections.Generic.KeyValuePair<System.Type,System.Security.Policy.EvidenceTypeDescriptor>[]``|False|2|368
|``System.Web.Util.FindFileData``|False|9|360
|``System.Xml.XmlTextReader``|True :warning:|15|360
|``System.Linq.Expressions.Compiler.StackSpiller``|False|9|360
|``System.Linq.Expressions.Compiler.AnalyzedTree``|False|9|360
|``System.Collections.Generic.Stack<System.Linq.Expressions.Compiler.CompilerScope>``|False|9|360
|``System.Collections.Generic.Stack<System.Linq.Expressions.Compiler.BoundConstants>``|False|9|360
|``System.Linq.Expressions.LogicalBinaryExpression``|False|9|360
|``System.Reflection.Emit.__FixupData[]``|False|3|360
|``System.RuntimeTypeHandle``|False|15|360
|``System.Web.Mvc.ResultExecutedContext``|False|5|360
|``System.Web.ThreadContext+<>c__DisplayClass24_0``|False|15|360
|``System.Runtime.Serialization.Formatters.Binary.BinaryFormatter``|False|5|360
|``System.Collections.Generic.Dictionary+Entry<System.String,System.Resources.ResourceLocator>[]``|False|3|360
|``ASP._Page_Views__ViewStart_cshtml``|False|3|360
|``System.Web.Mvc.ReflectedActionDescriptor``|False|5|360
|``System.Web.Mvc.Filters.AuthenticationContext``|False|5|360
|``System.Web.Mvc.ActionExecutingContext``|False|5|360
|``System.Web.Mvc.ViewContext``|False|3|360
|``System.Runtime.Remoting.Messaging.StackBuilderSink``|False|11|352
|``System.Web.Util.AppVerifier+<>c__DisplayClass14_0``|False|11|352
|``System.Security.Policy.Evidence+EvidenceLockHolder``|True :warning:|11|352
|``System.Web.Caching.SRef[]``|False|6|336
|``System.Web.Configuration.AssemblyCollection``|False|2|336
|``System.Web.Configuration.BuildProviderCollection``|False|2|336
|``System.Web.Configuration.ExpressionBuilderCollection``|False|2|336
|``System.Net.Logging+NclTraceSource``|False|6|336
|``System.Diagnostics.SourceElementsCollection``|False|2|336
|``System.Diagnostics.SwitchElementsCollection``|False|2|336
|``System.Diagnostics.ListenerElementsCollection``|False|2|336
|``System.IO.FileSystemEnumerableIterator<System.String>``|True :warning:|3|336
|``System.Xml.DomNameTable``|False|7|336
|``System.Configuration.KeyValueConfigurationCollection``|False|2|336
|``System.Linq.Lookup+Grouping<System.String,System.Reflection.MethodInfo>``|False|6|336
|``System.Linq.Enumerable+<CastIterator>d__97<System.String>``|True :warning:|6|336
|``System.Int16[]``|False|6|336
|``System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>[]``|False|7|328
|``System.Web.Management.WebBaseEvent+SystemEventType[,]``|False|1|328
|``System.Threading.ThreadAbortException``|False|2|320
|``System.Globalization.CalendarData``|False|2|320
|``System.Security.PermissionToken[]``|False|2|320
|``Microsoft.Win32.SafeHandles.SafeLsaMemoryHandle``|True :warning:|8|320
|``System.Collections.Generic.Dictionary<System.String,System.UriParser>``|False|4|320
|``System.Configuration.Internal.StreamChangeCallback``|False|5|320
|``System.Runtime.CompilerServices.TrueReadOnlyCollection<System.Linq.Expressions.Expression>``|False|10|320
|``Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType[]``|False|8|320
|``System.Func<System.Threading.Tasks.Task,System.Threading.Tasks.Task<System.Threading.Tasks.TaskHelpersExtensions+AsyncVoid>>``|False|5|320
|``System.Func<System.Exception>``|False|5|320
|``System.Threading.Tasks.TaskHelpersExtensions+<>c__DisplayClass1``|False|10|320
|``System.Action<System.Action<System.Web.HttpContext>>``|False|5|320
|``System.Collections.Generic.List<System.IO.Directory+SearchData>``|False|8|320
|``System.IO.Directory+SearchData``|False|8|320
|``System.Runtime.Remoting.TypeInfo``|False|8|320
|``System.Runtime.InteropServices.ComCompatibleVersionAttribute``|False|10|320
|``System.Web.RequestTimeoutManager+RequestTimeoutEntry``|False|5|320
|``System.Func<System.Object>``|False|5|320
|``System.Action<System.Action<System.Object>,System.Object>``|False|5|320
|``System.Func<System.Threading.Tasks.Task,System.Object>``|False|5|320
|``System.Func<System.Threading.Tasks.Task,System.Boolean>``|False|5|320
|``System.Func<System.Web.HttpContext,System.AsyncCallback,System.Object,System.IAsyncResult>``|False|5|320
|``System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Object>,System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Object>,System.Boolean>,System.Boolean>``|False|5|320
|``System.Func<System.Web.Mvc.ControllerContext,System.Web.Mvc.ActionDescriptor,System.Collections.Generic.IEnumerable<System.Web.Mvc.Filter>>``|False|5|320
|``System.Web.Mvc.Async.ActionDescriptorCreator``|False|5|320
|``System.Web.Mvc.Async.EndInvokeDelegate<System.Boolean>``|False|5|320
|``System.Web.Mvc.AuthorizationContext``|False|5|320
|``System.Web.Mvc.Async.AsyncControllerActionInvoker+<>c__DisplayClass30``|False|5|320
|``System.Web.Mvc.Async.EndInvokeDelegate<System.Web.Mvc.ActionExecutedContext>``|False|5|320
|``System.Web.Mvc.Filters.AuthenticationChallengeContext``|False|5|320
|``System.Web.Mvc.ResultExecutingContext``|False|5|320
|``System.Collections.Specialized.NameObjectCollectionBase+NameObjectKeysEnumerator``|False|10|320
|``System.Configuration.Internal.InternalConfigRoot``|False|4|320
|``System.Web.Routing.ParameterSubsegment``|False|10|320
|``System.Func<System.Web.Mvc.IDependencyResolver>``|False|5|320
|``System.IO.MemoryStream``|True :warning:|4|320
|``System.Runtime.Serialization.Formatters.Binary.BinaryArray``|False|5|320
|``System.Web.Configuration.WebConfigurationHost``|False|3|312
|``System.Web.Mvc.Routing.IRouteInfoProvider[]``|False|13|312
|``System.Web.Mvc.IActionFilter[]``|False|6|304
|``System.Web.Mvc.Filters.IAuthenticationFilter[]``|False|6|304
|``System.Web.Mvc.IAuthorizationFilter[]``|False|6|304
|``System.Web.Mvc.IExceptionFilter[]``|False|6|304
|``System.Web.Mvc.IResultFilter[]``|False|6|304
|``System.RuntimeType+ActivatorCacheEntry[]``|False|2|304
|``System.Xml.SafeAsciiDecoder``|False|9|288
|``Microsoft.CSharp.RuntimeBinder.Semantics.EXPRARRINIT``|False|3|288
|``System.Collections.Generic.Dictionary+Entry<Microsoft.CSharp.RuntimeBinder.Semantics.EXPRCALL,System.Linq.Expressions.Expression>[]``|False|3|288
|``System.Dynamic.DynamicMetaObject``|False|6|288
|``System.Dynamic.BindingRestrictions+TestBuilder+AndNode[]``|False|4|288
|``System.Collections.Generic.Dictionary+Entry<System.Dynamic.BindingRestrictions,System.Object>[]``|False|3|288
|``System.Reflection.Emit.LineNumberInfo``|False|9|288
|``System.Runtime.CompilerServices.Closure``|False|9|288
|``System.Collections.Generic.Dictionary+Entry<System.Type,System.Object>[]``|False|3|288
|``Microsoft.CSharp.RuntimeBinder.Semantics.AggregateDeclaration``|False|3|288
|``Microsoft.CSharp.RuntimeBinder.RuntimeBinder+ArgumentObject[]``|False|7|288
|``System.Collections.Generic.Dictionary+Entry<System.Int32,Microsoft.CSharp.RuntimeBinder.Semantics.LocalVariableSymbol>[]``|False|3|288
|``System.Collections.Concurrent.ConcurrentBag+ThreadLocalList<System.Web.HttpApplication>``|False|4|288
|``System.Enum+ValuesAndNames``|False|9|288
|``System.Collections.Generic.Dictionary+Entry<System.String,System.Resources.ResourceSet>[]``|False|3|288
|``System.Web.HttpResponseStream``|True :warning:|6|288
|``System.Security.Util.URLString``|False|3|288
|``System.TimeZoneInfo``|False|4|288
|``System.Web.HttpModuleCollection``|False|3|288
|``System.Web.PipelineModuleStepContainer[]``|False|2|288
|``System.Threading.ReaderWriterLockSlim``|True :warning:|3|288
|``System.Collections.Generic.Dictionary+Entry<System.String,System.ComponentModel.PropertyDescriptor>[]``|False|1|288
|``System.Collections.Concurrent.ConcurrentDictionary+Tables<System.String,System.Boolean>``|False|6|288
|``System.Web.Mvc.RazorView``|False|3|288
|``System.Security.CodeAccessPermission[]``|False|4|288
|``System.Xml.XmlLoader``|False|7|280
|``System.Xml.XmlDeclaration``|False|5|280
|``System.Collections.Generic.List<System.Int32>``|False|7|280
|``Microsoft.Owin.Host.SystemWeb.CallContextAsyncResult``|False|5|280
|``System.Web.Mvc.Async.AsyncManager``|False|5|280
|``System.Web.Mvc.FilterInfo``|False|5|280
|``System.Web.Mvc.ControllerInstanceFilterProvider+<GetFilters>d__0``|True :warning:|5|280
|``System.Web.Mvc.Async.AsyncControllerActionInvoker+<>c__DisplayClass1e+<>c__DisplayClass28``|False|5|280
|``System.Web.ModuleConfigurationInfo[]``|False|1|280
|``System.Diagnostics.TraceSource``|False|5|280
|``System.Collections.Specialized.ListDictionary+NodeKeyValueCollection+NodeKeyValueEnumerator``|False|7|280
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Web.Hosting.CustomRuntimeManager+CustomRuntimeRegistration,System.Object>[]``|False|1|272
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Tuple<System.Type,System.Web.VirtualPath>,System.Configuration.ConfigurationSection>[]``|False|1|272
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Web.VirtualPath,System.Configuration.Configuration>[]``|False|1|272
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Object,System.Object>[]``|False|1|272
|``System.Diagnostics.Tracing.EventSourceAttribute[]``|False|8|272
|``System.Web.Configuration.ProfileSection``|False|2|272
|``System.Linq.Set+Slot<System.Reflection.MethodInfo>[]``|False|2|272
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.String,System.Int32>[]``|False|1|272
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Type,System.Web.SessionState.SessionStateBehavior>[]``|False|1|272
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Type,System.Object>[]``|False|1|272
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Type,System.Collections.Generic.IEnumerable<System.Object>>[]``|False|1|272
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Reflection.MethodInfo,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.ActionMethodSelectorAttribute>>[]``|False|1|272
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Reflection.MethodInfo,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.ActionNameSelectorAttribute>>[]``|False|1|272
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Reflection.MethodInfo,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.FilterAttribute>>[]``|False|1|272
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Type,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.FilterAttribute>>[]``|False|1|272
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Web.Hosting.ISuspendibleRegisteredObject,System.Object>[]``|False|1|272
|``System.DateTime``|False|11|264
|``Microsoft.CSharp.RuntimeBinder.Semantics.Scope``|False|3|264
|``Microsoft.CSharp.RuntimeBinder.Semantics.EXPRBLOCK``|False|3|264
|``System.Diagnostics.TraceListenerCollection``|False|11|264
|``System.Runtime.Remoting.ChannelInfo``|False|11|264
|``System.Runtime.Remoting.Messaging.ServerObjectTerminatorSink``|False|11|264
|``System.Web.Mvc.ParameterDescriptor[]``|False|11|264
|``System.Web.Util.DoubleLinkList[]``|False|2|256
|``System.Web.Caching.CacheSizeMonitor``|False|2|256
|``System.Web.Configuration.FolderLevelBuildProvider``|False|2|256
|``System.Func<System.Runtime.CompilerServices.CallSite,System.Object,System.Object>``|False|4|256
|``System.SZArrayHelper+SZGenericArrayEnumerator<System.Reflection.ConstructorInfo>``|True :warning:|8|256
|``Microsoft.Win32.SafeHandles.SafeFindHandle``|True :warning:|8|256
|``System.Web.Mvc.UrlHelper``|False|8|256
|``System.Func<System.Boolean>``|False|4|256
|``System.Security.Permissions.RegistryPermission``|False|4|256
|``System.Func<System.Reflection.MethodInfo,System.String>``|False|4|256
|``System.Web.Configuration.AuthenticationSection``|False|2|256
|``System.Web.Configuration.AuthorizationSection``|False|2|256
|``System.Func<System.Web.Mvc.IControllerFactory>``|False|4|256
|``System.Func<System.Web.Mvc.IViewPageActivator>``|False|4|256
|``System.Reflection.TypeFilter``|False|4|256
|``System.Threading.InternalCrossContextDelegate``|False|4|256
|``System.Web.Compilation.BuildManager``|False|1|248
|``System.Web.Hosting.HostingEnvironment``|False|1|248
|``System.Collections.Generic.Dictionary<System.String,System.Type>``|False|3|240
|``System.Nullable<System.Boolean>``|False|10|240
|``System.Web.Configuration.SecurityPolicySection``|False|2|240
|``System.Collections.Generic.Dictionary<Microsoft.CSharp.RuntimeBinder.Semantics.EXPRCALL,System.Linq.Expressions.Expression>``|False|3|240
|``System.Collections.Generic.Dictionary<System.Dynamic.BindingRestrictions,System.Object>``|False|3|240
|``System.Collections.Generic.List<System.Linq.Expressions.Compiler.LabelScopeInfo>``|False|6|240
|``System.Collections.Generic.Dictionary<System.Type,System.Object>``|False|3|240
|``System.Collections.Generic.List<System.Linq.Expressions.Expression>``|False|6|240
|``System.Collections.Generic.List+Enumerator<System.Linq.Expressions.Expression>``|True :warning:|6|240
|``System.Collections.Generic.Dictionary<System.Int32,Microsoft.CSharp.RuntimeBinder.Semantics.LocalVariableSymbol>``|False|3|240
|``Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder+ExplicitConversion``|False|3|240
|``Microsoft.CSharp.RuntimeBinder.Semantics.EXPRBOUNDLAMBDA``|False|3|240
|``Microsoft.CSharp.RuntimeBinder.Semantics.EXPRRETURN``|False|3|240
|``System.Web.WebPages.Instrumentation.InstrumentationService``|False|6|240
|``System.Web.HttpSessionStateWrapper``|False|10|240
|``System.Collections.Concurrent.ConcurrentBag+Node<System.Web.HttpApplication>``|False|6|240
|``System.Threading.ThreadPoolWorkQueue+QueueSegment``|False|6|240
|``System.Web.Configuration.ProcessModelSection``|False|2|240
|``System.Collections.Generic.Dictionary<System.String,System.Resources.ResourceSet>``|False|3|240
|``System.Resources.ResourceFallbackManager``|False|6|240
|``System.Collections.Generic.Dictionary<System.String,System.Resources.ResourceLocator>``|False|3|240
|``System.Web.Configuration.WebControlsSection``|False|2|240
|``System.Collections.Generic.Dictionary<System.String,System.Web.WebPages.SectionWriter>``|False|3|240
|``System.Collections.Generic.Dictionary<System.String,System.Web.WebPages.Html.ModelState>``|False|3|240
|``System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<System.Web.WebPages.IValidator>>``|False|3|240
|``System.Web.Security.CookielessHelperClass``|False|6|240
|``System.Security.Claims.RoleClaimProvider+<get_Claims>d__5``|True :warning:|5|240
|``System.Threading.ReaderWriterCount``|False|5|240
|``System.Web.Routing.RouteData``|False|5|240
|``System.Web.Mvc.ControllerContext``|False|5|240
|``System.Web.Mvc.FilterAttribute[]``|False|10|240
|``System.Diagnostics.Tracing.EventSourceAttribute``|False|6|240
|``System.Collections.Generic.List<System.Security.Policy.StrongName>``|False|6|240
|``System.Web.Configuration.HealthMonitoringSection``|False|2|240
|``System.Web.Configuration.RoleManagerSection``|False|2|240
|``System.Web.Configuration.UrlMappingsSection``|False|2|240
|``System.Web.UI.ScriptResourceAttribute``|False|6|240
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.String,System.Diagnostics.TraceSource>``|False|5|240
|``System.Collections.Generic.Dictionary<System.String,System.Web.RequestNotification>``|False|3|240
|``System.Collections.Generic.Dictionary<System.String,System.Web.Mvc.FieldValidationMetadata>``|False|3|240
|``System.Collections.Generic.Dictionary<System.String,System.Boolean>``|False|3|240
|``System.Runtime.Serialization.Formatters.Binary.SerStack``|False|6|240
|``System.Runtime.Remoting.Contexts.IContextProperty[]``|False|4|240
|``Microsoft.CSharp.RuntimeBinder.Semantics.BindingContext``|False|1|232
|``System.Security.PermissionToken``|False|7|224
|``System.Text.UnicodeEncoding``|False|4|224
|``System.Linq.Expressions.PropertyExpression``|False|7|224
|``System.Linq.Expressions.TypedParameterExpression``|False|7|224
|``System.Diagnostics.TraceSection``|False|2|224
|``System.Web.Hosting.HostingEnvironment+CultureContext``|True :warning:|7|224
|``System.SZArrayHelper+SZGenericArrayEnumerator<System.Web.PreApplicationStartMethodAttribute>``|True :warning:|7|224
|``System.Configuration.Configuration``|False|2|224
|``System.Web.Configuration.ProfileSettings``|False|2|224
|``System.Web.Configuration.RuleSettings``|False|2|224
|``System.Web.Routing.PathSegment[]``|False|4|224
|``System.Web.Optimization.BundleFileSetOrdering``|False|7|224
|``System.Collections.Specialized.ListDictionary+NodeKeyValueCollection``|False|7|224
|``System.Security.Util.Tokenizer``|False|2|224
|``Microsoft.CSharp.RuntimeBinder.Semantics.EXPRWRAP``|False|3|216
|``System.Linq.Expressions.Compiler.KeyedQueue<System.Type,System.Reflection.Emit.LocalBuilder>``|False|9|216
|``System.Reflection.Emit.DynamicScope``|False|9|216
|``System.Collections.Generic.Dictionary+ValueCollection<System.Linq.Expressions.LabelTarget,System.Linq.Expressions.Compiler.LabelInfo>``|False|9|216
|``System.Dynamic.DynamicMetaObject[]``|False|7|216
|``Microsoft.CSharp.RuntimeBinder.Semantics.EXPRLOCAL``|False|3|216
|``System.Threading.CancellationTokenSource``|True :warning:|3|216
|``System.Configuration.InfiniteIntConverter``|False|9|216
|``System.Resources.RuntimeResourceSet``|True :warning:|3|216
|``System.Uri+UriInfo``|False|3|216
|``System.Diagnostics.TraceSwitch``|False|3|216
|``Microsoft.Owin.Host.SystemWeb.IntegratedPipeline.IntegratedPipelineContext``|False|3|216
|``System.IO.BinaryWriter``|True :warning:|3|216
|``System.Web.Mvc.ViewResult``|False|3|216
|``System.Runtime.Serialization.Formatters.Binary.ObjectReader``|False|1|216
|``System.Web.FileChangesMonitor``|False|2|208
|``Microsoft.CSharp.RuntimeBinder.Semantics.EXPRPROP``|False|2|208
|``System.Runtime.Remoting.Contexts.Context``|False|2|208
|``System.Collections.Generic.List<System.WeakReference>``|False|5|200
|``System.Collections.Generic.List<System.Web.Instrumentation.PageExecutionListener>``|False|5|200
|``System.Web.HttpResponseUnmanagedBufferElement``|False|5|200
|``System.Collections.Generic.List<System.Web.WebPages.RequestResourceTracker+SecureWeakReference>``|False|5|200
|``System.Web.Hosting.RecycleLimitMonitor+RecycleLimitMonitorSingleton``|False|1|200
|``System.Threading.ThreadLocal+LinkedSlotVolatile<System.Collections.Concurrent.ConcurrentBag+ThreadLocalList<System.Web.HttpApplication>>[]``|False|6|200
|``System.Web.AspNetSynchronizationContext``|False|5|200
|``System.Web.AspNetSynchronizationContext+State``|False|5|200
|``System.Collections.Generic.Stack<System.IDisposable>``|False|5|200
|``System.Security.Claims.RoleClaimProvider``|False|5|200
|``System.Collections.Generic.List+Enumerator<System.Web.Routing.RouteBase>``|True :warning:|5|200
|``System.Web.SessionState.SessionStateStoreData``|False|5|200
|``Microsoft.Owin.Host.SystemWeb.IntegratedPipeline.IntegratedPipelineContextStage+<>c__DisplayClass7``|False|5|200
|``System.Collections.Generic.List<System.Tuple<System.Action<System.Object>,System.Object>>``|False|5|200
|``System.Threading.Tasks.TaskHelpersExtensions+<>c__DisplayClass11<System.Threading.Tasks.Task,System.Object>``|False|5|200
|``System.Threading.Tasks.TaskHelpersExtensions+<>c__DisplayClass9<System.Threading.Tasks.TaskHelpersExtensions+AsyncVoid>``|False|5|200
|``System.Web.Mvc.MvcHandler+<>c__DisplayClass9``|False|5|200
|``System.Web.Mvc.TempDataDictionary``|False|5|200
|``System.Collections.Generic.Dictionary+KeyCollection+Enumerator<System.String,System.Object>``|True :warning:|5|200
|``System.Web.Mvc.Controller+<>c__DisplayClass22``|False|5|200
|``System.Web.Mvc.Async.AsyncControllerActionInvoker``|False|5|200
|``System.Web.Mvc.Async.AsyncControllerActionInvoker+<>c__DisplayClass1c``|False|5|200
|``System.Web.Mvc.Async.AsyncControllerActionInvoker+<>c__DisplayClass1e``|False|5|200
|``System.Collections.Generic.List<System.Web.Mvc.IActionFilter>``|False|5|200
|``System.Collections.Generic.List<System.Web.Mvc.Filters.IAuthenticationFilter>``|False|5|200
|``System.Collections.Generic.List<System.Web.Mvc.IAuthorizationFilter>``|False|5|200
|``System.Collections.Generic.List<System.Web.Mvc.IExceptionFilter>``|False|5|200
|``System.Collections.Generic.List<System.Web.Mvc.IResultFilter>``|False|5|200
|``System.Collections.Generic.List+Enumerator<System.Web.Mvc.IAuthorizationFilter>``|True :warning:|5|200
|``System.Collections.Generic.List<System.Web.Mvc.ParameterDescriptor>``|False|5|200
|``System.Web.AspNetEventSource``|True :warning:|1|200
|``System.Collections.Generic.List+Enumerator<System.Type>``|True :warning:|5|200
|``System.Security.Policy.PolicyStatement``|False|5|200
|``System.Runtime.Serialization.Formatters.Binary.__BinaryParser``|False|1|200
|``System.__ComObject``|False|6|192
|``System.CultureAwareComparer``|False|6|192
|``Microsoft.Win32.Win32Native+OSVERSIONINFO``|False|4|192
|``System.Configuration.TimeSpanValidator``|False|4|192
|``System.ConfigTreeParser``|False|2|192
|``System.Security.Cryptography.RNGCryptoServiceProvider``|True :warning:|6|192
|``System.Web.Configuration.RuntimeConfig``|False|4|192
