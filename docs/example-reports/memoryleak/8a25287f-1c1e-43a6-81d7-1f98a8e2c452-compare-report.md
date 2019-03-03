# PostMortem Compare Report for ``FULLDUMP_HangMode_w3wp.exe__2850_2019-03-03_21-27-42-750_a9cc.dmp`` and ``FULLDUMP_HangMode_w3wp.exe__2884_2019-03-03_21-27-51-606_a9cc.dmp``
Report generated: Sonntag, 3. März 2019 21:29:29

## General Information
Older Dump File Creation Time: Sonntag, 3. März 2019 21:27:42

Older Dump File Path: ``C:\Temp\crash-analysis\20190303_212742_Hang_Mode_leak1\FULLDUMP_HangMode_w3wp.exe__2850_2019-03-03_21-27-42-750_a9cc.dmp``

Newer Dump File Creation Time: Sonntag, 3. März 2019 21:27:51

Newer Dump File Path: ``C:\Temp\crash-analysis\20190303_212750_Hang_Mode_leak2\FULLDUMP_HangMode_w3wp.exe__2884_2019-03-03_21-27-51-606_a9cc.dmp``

## Matching Threads
### :snowflake:  Thread ``0000000083d4``
==Both stack traces seem to be equal==

#### Matching stack frames
Stack Pointer|Instruction Pointer|Display String
|:---|:---|:---|
|``  C9182FFBD8``|``           0``|``DebuggerU2MCatchHandlerFrame``
## Object Count Differences
Type|Implements IDisposable|Change
|:---|:---|:---|
|``System.String``|False|+20760 :arrow_up_small:
|``System.Char[]``|False|+15642 :arrow_up_small:
|``System.Text.StringBuilder``|False|+8692 :arrow_up_small:
|``System.Object[]``|False|+6960 :arrow_up_small:
|``System.Collections.ArrayList``|False|+6955 :arrow_up_small:
|``System.Collections.Hashtable+bucket[]``|False|+6946 :arrow_up_small:
|``System.Collections.Hashtable``|False|+6944 :arrow_up_small:
|``System.Byte[]``|False|+5213 :arrow_up_small:
|``System.Reflection.CustomAttributeRecord[]``|False|+5208 :arrow_up_small:
|``System.Attribute[]``|False|+5208 :arrow_up_small:
|``System.Collections.Hashtable+HashtableEnumerator``|False|+5206 :arrow_up_small:
|``System.String[]``|False|+3486 :arrow_up_small:
|``System.Xml.XmlTextWriter+Namespace[]``|False|+1737 :arrow_up_small:
|``System.Xml.XmlTextWriter``|True :warning:|+1737 :arrow_up_small:
|``System.Xml.Serialization.TempAssemblyCacheKey``|False|+1737 :arrow_up_small:
|``System.Xml.Serialization.XmlSerializer``|False|+1737 :arrow_up_small:
|``System.Text.UTF8Encoding+UTF8Encoder``|False|+1737 :arrow_up_small:
|``System.IO.StreamWriter``|True :warning:|+1737 :arrow_up_small:
|``System.Xml.XmlTextWriter+TagInfo[]``|False|+1737 :arrow_up_small:
|``System.IO.MemoryStream``|True :warning:|+1737 :arrow_up_small:
|``Microsoft.Xml.Serialization.GeneratedAssembly.XmlSerializationWriterProduct``|False|+1737 :arrow_up_small:
|``System.Xml.XmlTextEncoder``|False|+1737 :arrow_up_small:
|``AspNetCrash.Web.Models.Product``|False|+1737 :arrow_up_small:
|``System.Xml.Serialization.XmlTypeMapping``|False|+1737 :arrow_up_small:
|``System.Xml.Serialization.ElementAccessor``|False|+1737 :arrow_up_small:
|``System.Xml.Serialization.XmlAttributes``|False|+1736 :arrow_up_small:
|``System.Collections.Generic.List<System.Attribute>``|False|+1736 :arrow_up_small:
|``System.Xml.Serialization.XmlAnyElementAttributes``|False|+1736 :arrow_up_small:
|``System.Xml.Serialization.XmlArrayItemAttributes``|False|+1736 :arrow_up_small:
|``System.Xml.Serialization.XmlElementAttributes``|False|+1736 :arrow_up_small:
|``System.Random``|False|+1736 :arrow_up_small:
|``System.Xml.Serialization.XmlRootAttribute[]``|False|+1736 :arrow_up_small:
|``System.Xml.Serialization.TypeDesc``|False|+1736 :arrow_up_small:
|``System.ObsoleteAttribute[]``|False|+1736 :arrow_up_small:
|``System.Type[]``|False|+1736 :arrow_up_small:
|``System.Xml.Serialization.TypeScope``|False|+1736 :arrow_up_small:
|``System.Int32``|False|+1736 :arrow_up_small:
|``System.Int32[]``|False|+1736 :arrow_up_small:
|``System.Action``|False|+45 :arrow_up_small:
|``System.Web.AspNetSynchronizationContext+<>c__DisplayClass21_0``|False|+32 :arrow_up_small:
|``System.Web.HttpApplication+<>c__DisplayClass285_1``|False|+25 :arrow_up_small:
|``System.Threading.Tasks.Task<System.Object>``|True :warning:|+12 :arrow_up_small:
|``System.Threading.Tasks.TaskCompletionSource<System.Object>``|False|+10 :arrow_up_small:
|``System.Web.HttpAsyncResult``|False|+8 :arrow_up_small:
|``System.Object``|False|+8 :arrow_up_small:
|``System.Web.Util.DisposableAction``|True :warning:|+7 :arrow_up_small:
|``System.Web.Util.SynchronizationHelper+<>c__DisplayClass21_0``|False|+7 :arrow_up_small:
|``System.Web.NotificationContext``|False|+7 :arrow_up_small:
|``System.Threading.ExecutionContext``|True :warning:|+6 :arrow_up_small:
|``System.Collections.Specialized.NameObjectCollectionBase+NameObjectEntry``|False|+5 :arrow_up_small:
|``System.Runtime.Remoting.Messaging.LogicalCallContext``|False|+5 :arrow_up_small:
|``System.Runtime.Remoting.Messaging.CallContextSecurityData``|False|+5 :arrow_up_small:
|``System.Threading.Tasks.StandardTaskContinuation``|False|+5 :arrow_up_small:
|``System.Runtime.Remoting.Messaging.IllogicalCallContext``|False|+4 :arrow_up_small:
|``System.Security.Claims.Claim[]``|False|+4 :arrow_up_small:
|``System.Collections.Generic.List<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>>``|False|+4 :arrow_up_small:
|``System.Collections.ObjectModel.Collection<System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>>``|False|+4 :arrow_up_small:
|``System.Collections.Generic.List<System.Security.Claims.Claim>``|False|+4 :arrow_up_small:
|``System.Threading.Tasks.Task+ContingentProperties``|False|+4 :arrow_up_small:
|``System.Web.Hosting.AspNetHostExecutionContextManager+AspNetHostExecutionContext``|True :warning:|+4 :arrow_up_small:
|``System.Web.HttpContextWrapper``|False|+4 :arrow_up_small:
|``System.Security.Claims.Claim``|False|+4 :arrow_up_small:
|``System.Security.Principal.GenericIdentity``|False|+4 :arrow_up_small:
|``System.Threading.Tasks.ContinuationTaskFromTask``|True :warning:|+4 :arrow_up_small:
|``System.Action<System.Threading.Tasks.Task>``|False|+3 :arrow_up_small:
|``System.Web.Hosting.AspNetHostExecutionContextManager+RevertAction``|False|+3 :arrow_up_small:
|``System.Web.ThreadContext+<>c__DisplayClass24_0``|False|+3 :arrow_up_small:
|``System.Web.Hosting.AspNetHostExecutionContextManager+<>c__DisplayClass3_0``|False|+3 :arrow_up_small:
|``System.Web.Hosting.AspNetHostExecutionContextManager+<>c__DisplayClass3_1``|False|+3 :arrow_up_small:
|``System.Web.Caching.CacheInsertOptions``|False|+3 :arrow_up_small:
|``System.Web.HttpRequestWrapper``|False|+3 :arrow_up_small:
|``System.Security.Util.StringExpressionSet``|False|+3 :arrow_up_small:
|``System.Security.Permissions.FileIOAccess``|False|+3 :arrow_up_small:
|``System.Security.Permissions.FileIOPermission``|False|+3 :arrow_up_small:
|``System.Web.Routing.RouteValueDictionary``|False|+2 :arrow_up_small:
|``System.Web.Caching.CacheDependency+DepFileInfo[]``|False|+2 :arrow_up_small:
|``System.Collections.Generic.List<System.String>``|False|+2 :arrow_up_small:
|``System.Threading.Tasks.StackGuard``|False|+2 :arrow_up_small:
|``Microsoft.Owin.Host.SystemWeb.IntegratedPipeline.StageAsyncResult``|False|+2 :arrow_up_small:
|``System.Collections.Generic.List<System.Security.Claims.ClaimsIdentity>``|False|+2 :arrow_up_small:
|``System.Security.Claims.ClaimsIdentity[]``|False|+2 :arrow_up_small:
|``System.Collections.Concurrent.ConcurrentBag+ThreadLocalList<System.Web.HttpApplication>``|False|+2 :arrow_up_small:
|``System.Threading.ThreadLocal+FinalizationHelper<System.Collections.Concurrent.ConcurrentBag+ThreadLocalList<System.Web.HttpApplication>>``|False|+2 :arrow_up_small:
|``System.Threading.ThreadLocal+LinkedSlotVolatile<System.Collections.Concurrent.ConcurrentBag+ThreadLocalList<System.Web.HttpApplication>>[]``|False|+2 :arrow_up_small:
|``System.Threading.ThreadLocal+LinkedSlot<System.Collections.Concurrent.ConcurrentBag+ThreadLocalList<System.Web.HttpApplication>>``|False|+2 :arrow_up_small:
|``System.Threading.Tasks.TaskHelpersExtensions+<>c__DisplayClass1``|False|+2 :arrow_up_small:
|``System.Func<System.Threading.Tasks.Task<System.Threading.Tasks.TaskHelpersExtensions+AsyncVoid>>``|False|+2 :arrow_up_small:
|``System.Collections.Generic.Dictionary<System.String,System.Object>``|False|+2 :arrow_up_small:
|``System.Security.Principal.GenericPrincipal``|False|+2 :arrow_up_small:
|``System.Web.HttpResponseWrapper``|False|+1 :arrow_up_small:
|``System.Web.Caching.CacheDependency+DepCacheInfo[]``|False|+1 :arrow_up_small:
|``System.Web.Util.HashCodeCombiner``|False|+1 :arrow_up_small:
|``System.Collections.Generic.List<System.Object>``|False|+1 :arrow_up_small:
|``System.Threading.Tasks.Task<System.Threading.Tasks.TaskHelpersExtensions+AsyncVoid>``|True :warning:|+1 :arrow_up_small:
|``System.Threading.Tasks.TaskCompletionSource<System.Threading.Tasks.TaskHelpersExtensions+AsyncVoid>``|False|+1 :arrow_up_small:
|``System.Collections.Generic.IEnumerable<System.Security.Claims.Claim>[]``|False|+1 :arrow_up_small:
|``System.Threading.ReaderWriterCount``|False|+1 :arrow_up_small:
|``Microsoft.Owin.Host.SystemWeb.IntegratedPipeline.IntegratedPipelineContext+<>c__DisplayClass6``|False|+1 :arrow_up_small:
|``System.Security.Util.TokenBasedSet``|False|+1 :arrow_up_small:
|``System.Web.VirtualPath``|False|+1 :arrow_up_small:
|``System.Collections.Concurrent.ConcurrentBag+Node<System.Web.HttpApplication>``|False|+1 :arrow_up_small:
|``System.Uri``|False|+1 :arrow_up_small:
|``System.Threading.Tasks.UnwrapPromise<System.Threading.Tasks.TaskHelpersExtensions+AsyncVoid>``|True :warning:|+1 :arrow_up_small:
|``System.Threading.Tasks.ContinuationResultTaskFromTask<System.Boolean>``|True :warning:|+1 :arrow_up_small:
|``System.Func<System.Threading.Tasks.Task,System.Boolean>``|False|+1 :arrow_up_small:
|``System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Threading.Tasks.TaskHelpersExtensions+AsyncVoid>>``|True :warning:|+1 :arrow_up_small:
|``System.Threading.Tasks.TaskCompletionSource<System.Threading.Tasks.Task<System.Threading.Tasks.TaskHelpersExtensions+AsyncVoid>>``|False|+1 :arrow_up_small:
|``System.Threading.Tasks.TaskHelpersExtensions+<>c__DisplayClass9<System.Threading.Tasks.TaskHelpersExtensions+AsyncVoid>``|False|+1 :arrow_up_small:
|``System.Threading.Tasks.TaskHelpersExtensions+<>c__DisplayClass11<System.Threading.Tasks.Task,System.Object>``|False|+1 :arrow_up_small:
|``System.Func<System.Threading.Tasks.Task,System.Object>``|False|+1 :arrow_up_small:
|``System.Threading.Tasks.TaskHelpersExtensions+<>c__DisplayClassd<System.Object>``|False|+1 :arrow_up_small:
|``System.Action<System.Action<System.Object>,System.Object>``|False|+1 :arrow_up_small:
|``Microsoft.Owin.Host.SystemWeb.CallHeaders.AspNetResponseHeaders``|False|+1 :arrow_up_small:
|``Microsoft.Owin.Host.SystemWeb.CallHeaders.AspNetRequestHeaders``|False|+1 :arrow_up_small:
|``Microsoft.Owin.Host.SystemWeb.CallEnvironment.AspNetDictionary``|False|+1 :arrow_up_small:
|``Microsoft.Owin.Host.SystemWeb.CallContextAsyncResult``|False|+1 :arrow_up_small:
|``System.Collections.Generic.List<System.Tuple<System.Action<System.Object>,System.Object>>``|False|+1 :arrow_up_small:
|``Microsoft.Owin.Host.SystemWeb.CallHeaders.SendingHeadersEvent``|False|+1 :arrow_up_small:
|``Microsoft.Owin.Host.SystemWeb.OwinCallContext``|True :warning:|+1 :arrow_up_small:
|``Microsoft.Owin.Host.SystemWeb.IntegratedPipeline.IntegratedPipelineContextStage+<>c__DisplayClass7``|False|+1 :arrow_up_small:
|``System.Web.Routing.RequestContext``|False|+1 :arrow_up_small:
|``System.Web.Routing.RouteData``|False|+1 :arrow_up_small:
|``System.Func<System.String>``|False|+1 :arrow_up_small:
|``System.Action<System.Action<System.Web.HttpContext>>``|False|+1 :arrow_up_small:
|``System.Collections.Generic.List<System.Web.WebPages.RequestResourceTracker+SecureWeakReference>``|False|+1 :arrow_up_small:
|``System.Collections.Generic.List+Enumerator<System.Web.Instrumentation.PageExecutionListener>``|True :warning:|+1 :arrow_up_small:
|``System.Collections.Generic.List<System.Web.Instrumentation.PageExecutionListener>``|False|+1 :arrow_up_small:
|``System.Web.Instrumentation.PageInstrumentationService``|False|+1 :arrow_up_small:
|``System.Func<System.Threading.Tasks.CatchInfo,System.Threading.Tasks.CatchInfoBase+CatchResult<System.Threading.Tasks.Task>>``|False|+1 :arrow_up_small:
|``System.Func<System.Exception>``|False|+1 :arrow_up_small:
|``System.Threading.Tasks.TaskHelpersExtensions+<>c__DisplayClass49``|False|+1 :arrow_up_small:
|``System.Func<System.Threading.Tasks.Task,System.Threading.Tasks.Task<System.Threading.Tasks.TaskHelpersExtensions+AsyncVoid>>``|False|+1 :arrow_up_small:
|``System.Threading.Tasks.TaskHelpersExtensions+<>c__DisplayClass27``|False|+1 :arrow_up_small:
|``System.Web.RequestTimeoutManager+RequestTimeoutEntry``|False|+1 :arrow_up_small:
|``System.Security.Claims.RoleClaimProvider+<get_Claims>d__5``|True :warning:|+1 :arrow_up_small:
|``System.Security.Claims.RoleClaimProvider``|False|+1 :arrow_up_small:
|``System.Threading.SynchronizationContext``|False|+1 :arrow_up_small:
|``System.Web.ThreadContext``|False|+1 :arrow_up_small:
|``System.IDisposable[]``|False|+1 :arrow_up_small:
|``System.Collections.Generic.Stack<System.IDisposable>``|False|+1 :arrow_up_small:
|``System.Web.AspNetSynchronizationContext+State``|False|+1 :arrow_up_small:
|``System.Web.Util.SynchronizationHelper``|False|+1 :arrow_up_small:
|``System.Web.AspNetSynchronizationContext``|False|+1 :arrow_up_small:
|``System.Web.HttpHeaderCollection``|False|+1 :arrow_up_small:
|``System.Web.Util.CountdownTask``|False|+1 :arrow_up_small:
|``System.Web.HttpResponseStream``|True :warning:|+1 :arrow_up_small:
|``System.Web.HttpWriter``|True :warning:|+1 :arrow_up_small:
|``System.Web.RootedObjects``|False|+1 :arrow_up_small:
|``System.Web.Security.CookielessHelperClass``|False|+1 :arrow_up_small:
|``System.Web.HttpResponse``|False|+1 :arrow_up_small:
|``System.Web.HttpRequest``|False|+1 :arrow_up_small:
|``System.Web.HttpContext``|False|+1 :arrow_up_small:
|``System.Web.Hosting.IIS7WorkerRequest``|False|+1 :arrow_up_small:
|``System.Security.PermissionSet``|False|+1 :arrow_up_small:
|``Microsoft.Xml.Serialization.GeneratedAssembly.XmlSerializerContract``|False|0
|``System.Xml.Serialization.XmlSerializerNamespaces``|False|0
|``System.IO.Stream+NullStream``|True :warning:|0
|``System.Xml.XmlTextWriter+State[]``|False|0
|``System.Xml.Serialization.TempAssembly+TempMethod``|False|0
|``System.Xml.Serialization.TempAssembly+TempMethodDictionary``|False|0
|``System.Collections.Generic.Dictionary+Entry<System.String,System.Text.RegularExpressions.Regex>[]``|False|0
|``System.Collections.Generic.Dictionary<System.String,System.Text.RegularExpressions.Regex>``|False|0
|``System.Lazy<System.Reflection.MethodInfo>``|False|0
|``System.Xml.Serialization.SourceInfo+<>c``|False|0
|``System.Func<System.Reflection.MethodInfo>``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Tuple<System.Type,System.String>>``|False|0
|``System.Reflection.Emit.OpCode[]``|False|0
|``System.Xml.Serialization.Configuration.RootedPathValidator``|False|0
|``System.Xml.Serialization.Configuration.XmlSerializerSection``|False|0
|``System.Xml.Serialization.TempAssembly``|False|0
|``Microsoft.Win32.UnsafeNativeMethods+<>c``|False|0
|``System.Xml.Serialization.TempAssemblyCache``|False|0
|``System.Reflection.Emit.ResWriterData[]``|False|0
|``System.Reflection.Emit.ModuleBuilder[]``|False|0
|``System.Reflection.Emit.InternalModuleBuilder``|False|0
|``System.Reflection.Emit.InternalAssemblyBuilder``|False|0
|``System.Reflection.Emit.CustomAttributeBuilder[]``|False|0
|``System.Func<System.Linq.Expressions.ParameterExpression,System.Type>``|False|0
|``System.Linq.Expressions.Compiler.LambdaCompiler+<>c``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Linq.Expressions.LabelTarget>``|False|0
|``System.Collections.Generic.GenericEqualityComparer<System.Linq.Expressions.Compiler.BoundConstants+TypedConstant>``|False|0
|``System.Dynamic.Utils.ReferenceEqualityComparer<System.Object>``|False|0
|``System.Linq.Expressions.Compiler.BoundConstants[]``|False|0
|``System.Linq.Expressions.Compiler.CompilerScope[]``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Linq.Expressions.LambdaExpression>``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Linq.Expressions.ParameterExpression>``|False|0
|``System.Dynamic.Utils.CacheDict+Entry<System.Type,System.Reflection.MethodInfo>[]``|False|0
|``System.Dynamic.Utils.CacheDict<System.Type,System.Reflection.MethodInfo>``|False|0
|``System.Dynamic.Utils.CacheDict+Entry<System.Reflection.MethodBase,System.Reflection.ParameterInfo[]>[]``|False|0
|``System.Dynamic.Utils.CacheDict<System.Reflection.MethodBase,System.Reflection.ParameterInfo[]>``|False|0
|``System.Runtime.CompilerServices.TrueReadOnlyCollection<System.Linq.Expressions.Expression>``|False|0
|``System.Web.Mvc.ActionMethodDispatcher``|False|0
|``System.Func<System.Reflection.MethodInfo,System.Web.Mvc.ActionMethodDispatcher>``|False|0
|``System.Web.Mvc.ActionSelector[]``|False|0
|``System.Collections.Generic.Dictionary<System.Reflection.MethodInfo,System.Web.Mvc.ActionMethodDispatcher>``|False|0
|``System.Web.Mvc.ActionMethodDispatcherCache``|False|0
|``System.Web.Mvc.Async.BeginInvokeDelegate<System.Web.Mvc.Async.AsyncControllerActionInvoker+ActionInvocation>``|False|0
|``System.Web.Mvc.Async.EndInvokeDelegate<System.Web.Mvc.Async.AsyncControllerActionInvoker+ActionInvocation,System.Web.Mvc.ActionResult>``|False|0
|``System.Web.Mvc.ParameterDescriptor[]``|False|0
|``System.Func<System.Reflection.ParameterInfo,System.Web.Mvc.ActionDescriptorHelper+CreateDescriptorState,System.Web.Mvc.ParameterDescriptor>``|False|0
|``System.Func<System.Web.Mvc.ActionDescriptorHelper+CreateDescriptorState,System.Reflection.ParameterInfo[]>``|False|0
|``System.Web.Mvc.IResultFilter[]``|False|0
|``System.Web.Mvc.IExceptionFilter[]``|False|0
|``System.Web.Mvc.IAuthorizationFilter[]``|False|0
|``System.Web.SameSiteMode``|False|0
|``System.Web.SessionState.SessionStateMode``|False|0
|``System.Web.Configuration.OutputCacheSection``|False|0
|``System.ComponentModel.EventHandlerList``|True :warning:|0
|``System.Web.HttpApplication+AsyncAppEventHandlersTable``|False|0
|``System.Web.Optimization.HttpContextCache``|False|0
|``System.Web.Optimization.IgnoreList+SuffixMatch``|False|0
|``System.Web.Optimization.BundleFileSetOrdering``|False|0
|``System.Web.Optimization.FileExtensionReplacementList+Entry``|False|0
|``System.Web.Optimization.FileExtensionReplacementList+Entry[]``|False|0
|``System.Collections.Generic.List<System.Web.Optimization.FileExtensionReplacementList+Entry>``|False|0
|``System.Web.Optimization.FileExtensionReplacementList``|False|0
|``System.Web.Optimization.IgnoreList+IgnoreMatch[]``|False|0
|``System.Collections.Generic.List<System.Web.Optimization.IgnoreList+IgnoreMatch>``|False|0
|``System.Collections.Generic.HashSet<System.String>``|False|0
|``System.Web.Optimization.IgnoreList``|False|0
|``System.Web.Optimization.BundleFileSetOrdering[]``|False|0
|``System.Collections.Generic.List<System.Web.Optimization.BundleFileSetOrdering>``|False|0
|``System.Collections.Generic.Dictionary<System.String,System.Web.Optimization.DynamicFolderBundle>``|False|0
|``System.Collections.Generic.Dictionary<System.String,System.Web.Optimization.Bundle>``|False|0
|``System.Web.Optimization.BundleCollection``|False|0
|``System.Collections.Generic.Dictionary+Entry<System.String,System.Web.Routing.RouteBase>[]``|False|0
|``System.ComponentModel.PropertyDescriptorCollection``|False|0
|``System.Diagnostics.TraceSwitch``|False|0
|``System.ComponentModel.ReflectPropertyDescriptor``|False|0
|``System.ComponentModel.PropertyDescriptor[]``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Web.Mvc.UrlParameter>``|False|0
|``System.Web.Routing.Route``|False|0
|``System.Web.Mvc.MvcRouteHandler``|False|0
|``System.Web.Mvc.UrlParameter``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Web.Routing.RouteBase>``|False|0
|``System.Reflection.AssemblyName[]``|False|0
|``Microsoft.Internal.Web.Utils.PhysicalFileSystem``|False|0
|``System.Func<System.Collections.Generic.IDictionary<System.Object,System.Object>>``|False|0
|``System.Web.WebPages.Scope.StaticScopeStorageProvider``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Tables<System.Object,System.Object>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Object,System.Object>[]``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Object>``|False|0
|``System.Web.WebPages.Scope.ScopeStorageComparer``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary<System.Object,System.Object>``|False|0
|``System.Lazy<System.Collections.Generic.Dictionary<System.Object,System.Object>>``|False|0
|``System.Func<System.Collections.Generic.Dictionary<System.Object,System.Object>>``|False|0
|``System.Web.WebPages.Scope.WebConfigScopeDictionary+<>c__DisplayClass2``|False|0
|``System.Web.WebPages.Scope.WebConfigScopeDictionary``|False|0
|``System.Web.WebPages.Scope.ApplicationScopeStorageDictionary``|False|0
|``System.Func<System.Boolean>``|False|0
|``System.Web.WebPages.Scope.AspNetRequestScopeStorageProvider``|False|0
|``System.Diagnostics.AssertSection``|False|0
|``System.Configuration.Internal.ConfigurationManagerInternal``|False|0
|``System.Net.Logging+NclTraceSource``|False|0
|``System.Net.DefaultCertPolicy``|False|0
|``System.Net.CertPolicyValidationCallback``|False|0
|``System.Collections.Generic.LinkedListNode<System.WeakReference>``|False|0
|``System.Net.TimerThread+TimerNode``|True :warning:|0
|``System.Net.TimerThread+TimerQueue``|False|0
|``System.Threading.WaitHandle[]``|False|0
|``System.Collections.Generic.LinkedList<System.WeakReference>``|False|0
|``System.Net.TimerThread+Callback``|False|0
|``System.Net.SocketPermission``|False|0
|``System.Net.WebPermission``|False|0
|``System.Security.Permissions.KeyContainerPermissionAccessEntryCollection``|False|0
|``System.Security.Permissions.KeyContainerPermission``|False|0
|``System.Web.Configuration.ProcessModelSection``|False|0
|``System.Web.Configuration.CodeSubDirectoriesCollection``|False|0
|``System.Web.Configuration.CompilerCollection``|False|0
|``System.Web.Compilation.CompilationMutex``|True :warning:|0
|``Microsoft.Win32.SafeHandles.SafeFileMappingHandle``|True :warning:|0
|``Microsoft.Win32.SafeHandles.SafeViewOfFileHandle``|True :warning:|0
|``System.Text.InternalDecoderBestFitFallback``|False|0
|``System.Text.InternalEncoderBestFitFallback``|False|0
|``System.Text.SBCSCodePageEncoding``|False|0
|``System.Configuration.KeyValueInternalCollection``|False|0
|``System.Configuration.ConfigurationLockCollection``|False|0
|``System.Configuration.ConfigurationElementCollection+Entry``|False|0
|``System.Configuration.KeyValueConfigurationElement``|False|0
|``System.Configuration.ConfigurationValue``|False|0
|``System.Configuration.PropertySourceInfo``|False|0
|``System.Configuration.KeyValueConfigurationCollection``|False|0
|``System.Configuration.AppSettingsSection``|False|0
|``System.Reflection.DefaultMemberAttribute``|False|0
|``System.Runtime.InteropServices.ComVisibleAttribute``|False|0
|``System.SerializableAttribute``|False|0
|``System.ComponentModel.ReflectTypeDescriptionProvider+ReflectedTypeData``|False|0
|``System.ComponentModel.TypeDescriptor+TypeDescriptionNode``|False|0
|``System.ComponentModel.ReflectTypeDescriptionProvider``|False|0
|``System.Guid[]``|False|0
|``System.Diagnostics.BooleanSwitch``|False|0
|``System.Web.Mvc.ResultExecutingContext``|False|0
|``System.Collections.Generic.List+Enumerator<System.Web.Mvc.Filters.IAuthenticationFilter>``|True :warning:|0
|``System.Web.Mvc.Filters.AuthenticationChallengeContext``|False|0
|``System.Web.Mvc.ContentResult``|False|0
|``System.CtorDelegate``|False|0
|``System.Configuration.SectionInformation``|False|0
|``System.Configuration.ConfigurationValues``|False|0
|``System.Web.Hosting.ISAPIApplicationHost``|False|0
|``System.Threading.ThreadPoolWorkQueue+WorkStealingQueue[]``|False|0
|``System.Threading.ThreadPoolWorkQueue+SparseArray<System.Threading.ThreadPoolWorkQueue+WorkStealingQueue>``|False|0
|``<>f__AnonymousType0<System.Collections.Hashtable,System.Web.Caching.CacheExpires,System.Web.Caching.CacheUsage>``|False|0
|``System.Threading.ManualResetEvent``|True :warning:|0
|``System.Web.Caching.UsageBucket``|False|0
|``System.Web.Caching.UsageBucket[]``|False|0
|``System.Threading.TimerQueue+AppDomainTimerSafeHandle``|True :warning:|0
|``System.Collections.Generic.List<System.WeakReference>``|False|0
|``Microsoft.Win32.UnsafeNativeMethods+ManifestEtw+EtwEnableCallback``|False|0
|``System.Diagnostics.Tracing.EventSource+OverideEventProvider``|True :warning:|0
|``System.Reflection.RuntimeMethodInfo[][]``|False|0
|``System.Reflection.CerHashtable+Table<System.String,System.Reflection.RuntimeMethodInfo[]>``|False|0
|``System.Text.DecoderReplacementFallback``|False|0
|``System.Runtime.Remoting.Contexts.DynamicPropertyHolder``|False|0
|``System.Reflection.RuntimeMethodInfo``|False|0
|``System.Runtime.Remoting.ObjectHandle``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Tables<System.Web.Hosting.ISuspendibleRegisteredObject,System.Object>``|False|0
|``System.Web.Hosting.HostingEnvironment``|False|0
|``System.Globalization.TextInfo``|False|0
|``System.Security.Util.DirectoryString``|False|0
|``System.Reflection.MemberInfo[]``|False|0
|``System.Web.RegularExpressions.BrowserCapsRefRegexRunner23``|False|0
|``System.Web.RegularExpressions.BrowserCapsRefRegexFactory23``|False|0
|``System.Web.RegularExpressions.BrowserCapsRefRegex``|False|0
|``System.Collections.Generic.ArraySortHelper<System.Text.RegularExpressions.RegexCharClass+SingleRange>``|False|0
|``System.Collections.Generic.ObjectComparer<System.Text.RegularExpressions.RegexCharClass+SingleRange>``|False|0
|``System.Web.Configuration.BrowserCapabilitiesFactory``|False|0
|``System.Web.Configuration.HttpCapabilitiesDefaultProvider``|False|0
|``System.Web.Configuration.HttpCapabilitiesSectionHandler``|False|0
|``System.Web.WebPages.CookieBrowserOverrideStore``|False|0
|``System.Web.WebPages.BrowserOverrideStores``|False|0
|``System.Func<System.Web.HttpContextBase,System.Boolean>``|False|0
|``System.Web.WebPages.DefaultDisplayMode``|False|0
|``System.Web.WebPages.IDisplayMode[]``|False|0
|``System.Collections.Generic.List<System.Web.WebPages.IDisplayMode>``|False|0
|``System.Web.WebPages.DisplayModeProvider``|False|0
|``System.Web.Mvc.VirtualPathProviderViewEngine+ViewLocation[]``|False|0
|``System.Web.Mvc.RazorViewEngine``|False|0
|``System.Lazy<System.Web.Mvc.IViewPageActivator>``|False|0
|``System.Web.Mvc.SingleServiceResolver<System.Web.Mvc.IViewPageActivator>``|False|0
|``System.Web.Mvc.BuildManagerViewEngine+DefaultViewPageActivator``|False|0
|``System.Func<System.Web.Mvc.IViewPageActivator>``|False|0
|``System.Web.Mvc.NullViewLocationCache``|False|0
|``System.Func<System.String,System.String>``|False|0
|``System.Web.Mvc.WebFormViewEngine``|False|0
|``System.Web.Mvc.IViewEngine[]``|False|0
|``System.Collections.Generic.List<System.Web.Mvc.IViewEngine>``|False|0
|``System.Web.Mvc.ViewEngineCollection``|False|0
|``System.Collections.Generic.Dictionary+Entry<System.Reflection.MethodInfo,System.Web.Mvc.ActionMethodDispatcher>[]``|False|0
|``System.Web.Mvc.ActionMethodDispatcher+ActionExecutor``|False|0
|``System.Linq.Expressions.Compiler.LambdaCompiler+WriteBack[]``|False|0
|``System.Reflection.Emit.OpCode``|False|0
|``System.Reflection.Emit.MethodBuilder[]``|False|0
|``System.Web.AspNetEventSource+WriteEventWithRelatedActivityIdCoreDelegate``|False|0
|``System.Web.AspNetEventSource``|True :warning:|0
|``System.Web.Util.ActivityIdHelper``|False|0
|``System.Web.Util.ActivityIdHelper+SetAndPreserveDelegate``|False|0
|``System.Web.Util.ActivityIdHelper+SetAndDestroyDelegate``|False|0
|``System.Web.Util.ActivityIdHelper+GetCurrentDelegate``|False|0
|``System.Lazy+Boxed<System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Assembly,System.String>>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Assembly,System.String>``|False|0
|``System.Func<System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Assembly,System.String>>``|False|0
|``System.Lazy+<>c<System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Assembly,System.String>>``|False|0
|``System.Collections.Generic.GenericEqualityComparer<System.Char>``|False|0
|``Owin.Loader.NullLoader``|False|0
|``System.Web.Configuration.UrlMappingCollection``|False|0
|``System.Web.Configuration.UrlMappingsSection``|False|0
|``System.Web.Configuration.AnonymousIdentificationSection``|False|0
|``System.Web.HttpCookieMode``|False|0
|``System.Web.Configuration.RoleManagerSection``|False|0
|``System.Web.Security.CookieProtection``|False|0
|``System.Configuration.GenericEnumConverter``|False|0
|``System.Web.Configuration.AuthenticationSection``|False|0
|``System.Web.Configuration.AuthenticationMode``|False|0
|``System.Nullable<System.Web.Configuration.AuthenticationMode>``|False|0
|``System.Web.SessionState.SessionIDManager``|False|0
|``System.Web.SessionState.InProcSessionStateStore``|False|0
|``System.Collections.Generic.Dictionary+Entry<System.Web.Util.AppVerifierErrorCode,System.String>[]``|False|0
|``System.Collections.Generic.EnumEqualityComparer<System.Web.Util.AppVerifierErrorCode>``|False|0
|``System.Collections.Generic.Dictionary<System.Web.Util.AppVerifierErrorCode,System.String>``|False|0
|``System.Web.SessionState.HttpSessionStateContainer``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Tables<System.String,System.Int32>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.String,System.Int32>[]``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary<System.String,System.Int32>``|False|0
|``System.Web.Configuration.SessionStateSection``|False|0
|``System.Collections.Concurrent.ConcurrentBag<System.Web.HttpApplication>``|False|0
|``System.Web.HttpApplicationFactory``|False|0
|``System.Collections.Generic.Dictionary+Entry<System.String,System.TimeZoneInfo>[]``|False|0
|``System.Collections.Generic.Dictionary<System.String,System.TimeZoneInfo>``|False|0
|``System.TimeZoneInfo+AdjustmentRule[]``|False|0
|``System.TimeZoneInfo``|False|0
|``System.TimeZoneInfo+OffsetAndRule``|False|0
|``System.TimeZoneInfo+AdjustmentRule``|False|0
|``System.TimeZoneInfo+CachedData``|False|0
|``System.Web.Compilation.BuildResultCompiledGlobalAsaxType``|False|0
|``System.Xml.XmlDownloadManager``|False|0
|``System.Runtime.CompilerServices.RuntimeHelpers+CleanupCode``|False|0
|``System.Runtime.CompilerServices.RuntimeHelpers+TryCode``|False|0
|``System.Collections.Generic.Dictionary+Entry<System.String,System.Web.Compilation.AssemblyReferenceInfo>[]``|False|0
|``System.Web.Compilation.AssemblyReferenceInfo``|False|0
|``System.Collections.Generic.Dictionary<System.String,System.Web.Compilation.AssemblyReferenceInfo>``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Reflection.Assembly>``|False|0
|``System.Collections.Generic.HashSet<System.Reflection.Assembly>``|False|0
|``System.Collections.Generic.List<System.Reflection.Assembly>``|False|0
|``System.Web.Compilation.BuildManager``|False|0
|``System.Net.Configuration.ConnectionManagementElementCollection``|False|0
|``System.Net.Configuration.ConnectionManagementSection``|False|0
|``System.Diagnostics.TraceOptions``|False|0
|``System.Diagnostics.ListenerElement``|False|0
|``System.Diagnostics.SystemDiagnosticsSection``|False|0
|``System.Diagnostics.ListenerElementsCollection``|False|0
|``System.Diagnostics.TraceSection``|False|0
|``System.Diagnostics.SwitchElementsCollection``|False|0
|``System.Diagnostics.SharedListenerElementsCollection``|False|0
|``System.Diagnostics.SourceElementsCollection``|False|0
|``System.Diagnostics.PerfCounterSection``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.PointerType``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.SYMTBL+Key``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.AggregateSymbol``|False|0
|``System.Collections.Generic.List<Microsoft.CSharp.RuntimeBinder.Syntax.Name>``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.MethodSymbol``|False|0
|``System.Func<System.Reflection.ParameterInfo,System.Reflection.ParameterInfo,System.Boolean>``|False|0
|``Microsoft.CSharp.RuntimeBinder.Syntax.Name[]``|False|0
|``Microsoft.CSharp.RuntimeBinder.Syntax.NameTable+Entry``|False|0
|``Microsoft.CSharp.RuntimeBinder.Syntax.Name``|False|0
|``System.Runtime.InteropServices.UnmanagedType[]``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.CType[]``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.CONSTVAL[]``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.TypeArray``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType``|False|0
|``Microsoft.CSharp.RuntimeBinder.Syntax.NameTable+Entry[]``|False|0
|``System.Collections.Generic.Dictionary+KeyCollection<System.String,System.String>``|False|0
|``System.ComponentModel.StringConverter``|False|0
|``System.ComponentModel.TypeConverterAttribute``|False|0
|``System.ComponentModel.AttributeCollection+AttributeEntry[]``|False|0
|``System.Runtime.CompilerServices.TypeDependencyAttribute``|False|0
|``System.Runtime.InteropServices.GuidAttribute``|False|0
|``System.CLSCompliantAttribute``|False|0
|``System.ComponentModel.AttributeCollection``|False|0
|``__DynamicallyInvokableAttribute``|False|0
|``System.Web.Configuration.CacheSection``|False|0
|``System.Configuration.RuntimeConfigurationRecord+RuntimeConfigurationFactory``|False|0
|``System.Configuration.ClientConfigPaths``|False|0
|``System.Configuration.ClientConfigurationHost``|False|0
|``System.Configuration.ClientConfigurationSystem``|False|0
|``System.Web.Configuration.ClientRuntimeConfig``|False|0
|``System.Configuration.ConfigurationPermission``|False|0
|``System.Configuration.BaseConfigurationRecord+IndirectLocationInputComparer``|False|0
|``System.Xml.XmlTextReaderImpl+NodeData``|False|0
|``System.Xml.XmlCharType``|False|0
|``System.Configuration.OverrideModeSetting``|False|0
|``System.Globalization.CodePageDataItem``|False|0
|``System.Configuration.Internal.InternalConfigHost``|False|0
|``System.Threading.TimerQueue``|False|0
|``System.Web.Util.DoubleLinkList``|False|0
|``System.Web.Util.DoubleLinkList[]``|False|0
|``System.LocalDataStore[]``|False|0
|``System.Collections.Generic.List<System.LocalDataStore>``|False|0
|``System.Boolean[]``|False|0
|``System.LocalDataStoreMgr``|False|0
|``System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.RuntimeType>``|False|0
|``System.Runtime.Remoting.DynamicTypeInfo``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Web.Hosting.ISuspendibleRegisteredObject,System.Object>[]``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Web.Hosting.ISuspendibleRegisteredObject>``|False|0
|``System.Security.Util.LocalSiteString``|False|0
|``System.Reflection.MethodInfo[]``|False|0
|``System.Collections.Generic.Dictionary+Entry<System.Type,System.Runtime.Serialization.Formatters.Binary.TypeInformation>[]``|False|0
|``System.Security.Policy.Url``|False|0
|``System.Threading.ThreadAbortException``|False|0
|``System.Collections.Generic.Dictionary+Entry<System.String,System.Boolean>[]``|False|0
|``System.LocalAppContext+TryGetSwitchDelegate``|False|0
|``System.Collections.Generic.Dictionary<System.String,System.Boolean>``|False|0
|``System.Xml.Schema.XmlSchemaObjectCollection``|False|0
|``System.Xml.Schema.XmlSchemaSimpleTypeRestriction``|False|0
|``System.Xml.Schema.XmlSchemaPatternFacet``|False|0
|``System.Xml.Serialization.NameKey``|False|0
|``System.Xml.XmlQualifiedName``|False|0
|``System.Xml.Schema.XmlSchemaSimpleType``|False|0
|``System.Xml.Serialization.NameTable``|False|0
|``System.Web.Mvc.ActionExecutedContext``|False|0
|``System.Func<System.Web.Mvc.ActionExecutedContext>``|False|0
|``System.Web.Mvc.Async.SimpleAsyncResult``|False|0
|``System.Web.Mvc.Async.AsyncResultWrapper+WrappedAsyncResult<System.Web.Mvc.ActionResult,System.Web.Mvc.Async.AsyncControllerActionInvoker+ActionInvocation>``|False|0
|``System.Web.Mvc.Async.AsyncControllerActionInvoker+AsyncInvocationWithFilters+<>c__DisplayClass45``|False|0
|``System.Web.Mvc.Async.AsyncControllerActionInvoker+AsyncInvocationWithFilters+<>c__DisplayClass41``|False|0
|``System.Web.Mvc.ActionExecutingContext``|False|0
|``System.Web.Mvc.Async.AsyncControllerActionInvoker+AsyncInvocationWithFilters``|False|0
|``System.Web.Mvc.Async.AsyncResultWrapper+WrappedAsyncResult<System.Web.Mvc.ActionExecutedContext>``|False|0
|``System.Web.Mvc.Async.EndInvokeDelegate<System.Web.Mvc.ActionExecutedContext>``|False|0
|``System.Web.Mvc.Async.AsyncControllerActionInvoker+<>c__DisplayClass30``|False|0
|``System.Web.Mvc.Async.AsyncControllerActionInvoker+<>c__DisplayClass1e+<>c__DisplayClass28``|False|0
|``System.Web.Mvc.AuthorizationContext``|False|0
|``System.Web.Mvc.Async.AsyncControllerActionInvoker+<>c__DisplayClass1e+<>c__DisplayClass24``|False|0
|``System.Web.Mvc.Filters.AuthenticationContext``|False|0
|``System.Web.Mvc.Async.AsyncControllerActionInvoker+<>c__DisplayClass1e+<>c__DisplayClass20``|False|0
|``System.Web.Mvc.Async.AsyncResultWrapper+WrappedAsyncResult<System.Boolean>``|False|0
|``System.Web.Mvc.Async.EndInvokeDelegate<System.Boolean>``|False|0
|``System.Web.Mvc.Async.BeginInvokeDelegate``|False|0
|``System.Collections.Generic.List<System.Web.Mvc.IResultFilter>``|False|0
|``System.Collections.Generic.List<System.Web.Mvc.IExceptionFilter>``|False|0
|``System.Collections.Generic.List<System.Web.Mvc.IAuthorizationFilter>``|False|0
|``System.Web.Mvc.Filters.IAuthenticationFilter[]``|False|0
|``System.Web.Mvc.IActionFilter[]``|False|0
|``System.Collections.Generic.ArraySortHelper<System.Web.Mvc.Filter>``|False|0
|``System.Collections.Generic.ObjectComparer<System.Web.Mvc.Filter>``|False|0
|``System.Web.Mvc.FilterProviderCollection+FilterComparer``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Reflection.MethodInfo,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.FilterAttribute>>``|False|0
|``System.Func<System.Reflection.MethodInfo,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.FilterAttribute>>``|False|0
|``System.SZArrayHelper+SZGenericArrayEnumerator<System.Web.Mvc.FilterAttribute>``|True :warning:|0
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Type,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.FilterAttribute>>``|False|0
|``System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.FilterAttribute>``|False|0
|``System.Web.Mvc.FilterAttribute[]``|False|0
|``System.Func<System.Type,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.FilterAttribute>>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Reflection.MethodInfo,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.ActionMethodSelectorAttribute>>``|False|0
|``System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.ActionMethodSelectorAttribute>``|False|0
|``System.Web.Mvc.ActionMethodSelectorAttribute[]``|False|0
|``System.Func<System.Reflection.MethodInfo,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.ActionMethodSelectorAttribute>>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Tables<System.Type,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.FilterAttribute>>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Type,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.FilterAttribute>>[]``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.FilterAttribute>>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Tables<System.Reflection.MethodInfo,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.FilterAttribute>>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Reflection.MethodInfo,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.FilterAttribute>>[]``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.MethodInfo,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.FilterAttribute>>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Tables<System.Reflection.MethodInfo,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.ActionNameSelectorAttribute>>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Reflection.MethodInfo,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.ActionNameSelectorAttribute>>[]``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.MethodInfo,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.ActionNameSelectorAttribute>>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Tables<System.Reflection.MethodInfo,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.ActionMethodSelectorAttribute>>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Reflection.MethodInfo,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.ActionMethodSelectorAttribute>>[]``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.MethodInfo,System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Mvc.ActionMethodSelectorAttribute>>``|False|0
|``System.Collections.Generic.Dictionary+Entry<System.Type,System.Web.Mvc.ControllerDescriptor>[]``|False|0
|``System.Linq.Lookup+Grouping<System.String,System.Reflection.MethodInfo>``|False|0
|``System.SZArrayHelper+SZGenericArrayEnumerator<System.Reflection.MethodInfo>``|True :warning:|0
|``System.Linq.Lookup+Grouping<System.String,System.Reflection.MethodInfo>[]``|False|0
|``System.Web.Routing.ParsedRoute``|False|0
|``System.Web.Routing.SeparatorPathSegment``|False|0
|``System.Web.Routing.ContentPathSegment``|False|0
|``System.Web.Routing.LiteralSubsegment``|False|0
|``System.Web.Routing.ParameterSubsegment``|False|0
|``System.Collections.Generic.List<System.Web.Routing.PathSubsegment>``|False|0
|``System.Web.Routing.PathSegment[]``|False|0
|``System.Collections.Generic.List<System.Web.Routing.PathSegment>``|False|0
|``System.Func<System.Web.Routing.PathSubsegment,System.Boolean>``|False|0
|``System.Web.Routing.RouteParser+<>c``|False|0
|``System.Web.Routing.PathSubsegment[]``|False|0
|``System.Web.Routing.StopRoutingHandler``|False|0
|``System.Web.Mvc.RouteCollectionExtensions+IgnoreRouteInternal``|False|0
|``System.Web.Mvc.Filter``|False|0
|``System.Web.Mvc.HandleErrorAttribute``|False|0
|``System.Web.Mvc.Filter[]``|False|0
|``System.Collections.Generic.List<System.Web.Mvc.Filter>``|False|0
|``System.Web.Mvc.GlobalFilterCollection``|False|0
|``System.Web.Routing.RouteBase[]``|False|0
|``System.Collections.Generic.List<System.Web.Routing.RouteBase>``|False|0
|``System.Threading.ReaderWriterLockSlim``|True :warning:|0
|``System.Collections.Generic.Dictionary<System.String,System.Web.Routing.RouteBase>``|False|0
|``System.Web.Routing.RouteCollection``|False|0
|``System.EventArgs``|False|0
|``System.Web.Management.WebApplicationLifetimeEvent``|False|0
|``System.Web.Management.WebBaseEvent+SystemEventTypeInfo``|False|0
|``System.Collections.Specialized.NameValueCollection``|False|0
|``System.Web.Management.EventLogWebEventProvider``|False|0
|``System.Web.Management.RuleFiringRecord``|False|0
|``System.Web.Configuration.HealthMonitoringSectionHelper+RuleInfo``|False|0
|``System.Collections.ArrayList[,]``|False|0
|``System.Web.Configuration.WebBaseEventKeyComparer``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Web.VirtualPath>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary<System.Web.VirtualPath,System.Configuration.Configuration>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Tables<System.Tuple<System.Type,System.Web.VirtualPath>,System.Configuration.ConfigurationSection>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Tuple<System.Type,System.Web.VirtualPath>,System.Configuration.ConfigurationSection>[]``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Tuple<System.Type,System.Web.VirtualPath>>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary<System.Tuple<System.Type,System.Web.VirtualPath>,System.Configuration.ConfigurationSection>``|False|0
|``System.Web.Compilation.StandardDiskBuildResultCache``|False|0
|``System.AssemblyLoadEventHandler``|False|0
|``System.Web.Compilation.MemoryBuildResultCache``|False|0
|``System.Collections.Generic.Dictionary+Entry<System.String,System.String>[]``|False|0
|``System.CodeDom.Compiler.CompilerInfo``|False|0
|``System.Collections.Specialized.StringCollection``|False|0
|``System.CodeDom.Compiler.CompilerParameters``|False|0
|``System.Threading.ThreadPoolWorkQueue+QueueSegment``|False|0
|``System.Threading.ThreadPoolWorkQueue``|False|0
|``System.Action<System.IDisposable>``|False|0
|``System.Web.RootedObjects+<>c``|False|0
|``System.Char[][]``|False|0
|``System.Web.Util.CancellationTokenHelper``|True :warning:|0
|``System.Func<System.Web.Util.CancellationTokenHelper>``|False|0
|``System.Web.HttpContext+<>c``|False|0
|``System.Action<System.Web.WebPages.RequestResourceTracker+SecureWeakReference>``|False|0
|``System.Web.WebPages.RequestResourceTracker+SecureWeakReference[]``|False|0
|``System.Dynamic.Utils.CacheDict+Entry<System.Type,System.Reflection.MethodInfo>``|False|0
|``System.Func<System.Reflection.MemberInfo,System.Reflection.MethodInfo>``|False|0
|``System.Linq.Expressions.Expression+<>c``|False|0
|``System.Threading.ContextCallback``|False|0
|``System.IntPtr[][]``|False|0
|``System.Reflection.MdFieldInfo``|False|0
|``System.Collections.Generic.List<System.Type>``|False|0
|``System.SZArrayHelper+SZGenericArrayEnumerator<System.Security.Policy.EvidenceBase>``|True :warning:|0
|``System.Reflection.RuntimeFieldInfo[]``|False|0
|``System.Reflection.RtFieldInfo``|False|0
|``System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Runtime.Serialization.MemberHolder>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary<System.Runtime.Serialization.MemberHolder,System.Reflection.MemberInfo[]>``|False|0
|``System.Collections.Generic.Dictionary<System.Type,System.Runtime.Serialization.Formatters.Binary.TypeInformation>``|False|0
|``System.Security.Util.Tokenizer+StringMaker``|False|0
|``System.SZArrayHelper+SZGenericArrayEnumerator<System.Security.Policy.StrongName>``|True :warning:|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Type>``|False|0
|``System.Collections.Generic.GenericArraySortHelper<System.String>``|False|0
|``System.Collections.Generic.GenericComparer<System.String>``|False|0
|``System.Web.TelemetryEventSource``|True :warning:|0
|``System.Web.Util.BinaryCompatibility``|False|0
|``System.ComponentModel.WeakHashtable+WeakKeyComparer``|False|0
|``System.ComponentModel.WeakHashtable``|False|0
|``System.Text.UnicodeEncoding``|False|0
|``System.Web.Configuration.FcnMode``|False|0
|``System.Configuration.WhiteSpaceTrimStringConverter``|False|0
|``System.Web.Configuration.VersionConverter``|False|0
|``System.Web.Configuration.RegexMatchTimeoutValidator``|False|0
|``System.Web.Configuration.AsyncPreloadModeFlags``|False|0
|``System.Configuration.ConfigurationValues+EmptyCollection+EmptyCollectionEnumerator``|False|0
|``System.Configuration.ConfigurationValues+EmptyCollection``|False|0
|``System.Configuration.IntegerValidator``|False|0
|``System.Configuration.LongValidator``|False|0
|``System.Int64``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>``|False|0
|``System.Collections.Generic.Dictionary+Entry<System.RuntimeType,System.RuntimeType>[]``|False|0
|``System.Collections.Generic.Dictionary<System.RuntimeType,System.RuntimeType>``|False|0
|``System.Web.Caching.CacheUsage``|False|0
|``System.Web.Caching.ExpiresBucket``|False|0
|``System.Web.Caching.ExpiresBucket[]``|False|0
|``System.Web.Caching.CacheExpires``|False|0
|``System.Web.Caching.CacheKeyComparer``|False|0
|``System.Web.Caching.CacheSingle``|True :warning:|0
|``System.Web.Util.DisposableGCHandleRef<System.Web.Caching.CacheSingle>[]``|False|0
|``System.Web.Caching.CacheMultiple``|True :warning:|0
|``System.Diagnostics.Tracing.ActivityTracker``|False|0
|``System.Diagnostics.Tracing.EtwSession[]``|False|0
|``System.Guid``|False|0
|``System.Diagnostics.Tracing.FrameworkEventSource``|True :warning:|0
|``System.Text.EncoderReplacementFallback``|False|0
|``System.Text.UTF8Encoding+UTF8EncodingSealed``|False|0
|``System.Runtime.Remoting.Metadata.RemotingMethodCachedData``|False|0
|``System.Collections.Generic.Dictionary<System.String,System.LocalDataStoreSlot>``|False|0
|``System.Runtime.Remoting.Messaging.ObjRefSurrogate``|False|0
|``System.Runtime.Remoting.Messaging.RemotingSurrogate``|False|0
|``System.Runtime.Serialization.FormatterConverter``|False|0
|``System.Runtime.Serialization.StreamingContext``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary<System.Web.Hosting.ISuspendibleRegisteredObject,System.Object>``|False|0
|``System.Web.Hosting.SuspendManager``|False|0
|``System.Collections.Generic.List<System.Reflection.MethodInfo>``|False|0
|``System.Security.Util.URLString``|False|0
|``System.Security.Policy.EvidenceTypeDescriptor``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Runtime.Serialization.MemberHolder,System.Reflection.MemberInfo[]>``|False|0
|``System.Exception``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.AssemblyQualifiedNamespaceSymbol``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.NamespaceSymbol``|False|0
|``System.Collections.Generic.GenericEqualityComparer<Microsoft.CSharp.RuntimeBinder.Semantics.BSYMMGR+TypeArrayKey>``|False|0
|``System.Collections.Generic.Dictionary<Microsoft.CSharp.RuntimeBinder.Semantics.BSYMMGR+TypeArrayKey,Microsoft.CSharp.RuntimeBinder.Semantics.TypeArray>``|False|0
|``System.Collections.Generic.EnumEqualityComparer<Microsoft.CSharp.RuntimeBinder.Semantics.KAID>``|False|0
|``System.Collections.Generic.HashSet<Microsoft.CSharp.RuntimeBinder.Semantics.KAID>``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.InputFile``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.AidContainer[]``|False|0
|``System.Collections.Generic.List<Microsoft.CSharp.RuntimeBinder.Semantics.AidContainer>``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.MiscSymFactory``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.SymFactory``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<Microsoft.CSharp.RuntimeBinder.Semantics.SYMTBL+Key>``|False|0
|``System.Collections.Generic.Dictionary<Microsoft.CSharp.RuntimeBinder.Semantics.SYMTBL+Key,Microsoft.CSharp.RuntimeBinder.Semantics.Symbol>``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.SYMTBL``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.BSYMMGR``|False|0
|``System.Collections.Generic.List<Microsoft.CSharp.RuntimeBinder.Semantics.TypeParameterType>``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.TypeManager+StdTypeVarColl``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.ArgumentListType``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.MethodGroupType``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.BoundLambdaType``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.OpenTypePlaceholderType``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.NullType``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.VoidType``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.ErrorType``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<Microsoft.CSharp.RuntimeBinder.Semantics.TypeParameterSymbol>``|False|0
|``System.Collections.Generic.Dictionary<Microsoft.CSharp.RuntimeBinder.Semantics.TypeParameterSymbol,Microsoft.CSharp.RuntimeBinder.Semantics.TypeParameterType>``|False|0
|``System.Collections.Generic.Dictionary<Microsoft.CSharp.RuntimeBinder.Semantics.CType,Microsoft.CSharp.RuntimeBinder.Semantics.NullableType>``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<Microsoft.CSharp.RuntimeBinder.Semantics.CType>``|False|0
|``System.Collections.Generic.Dictionary<Microsoft.CSharp.RuntimeBinder.Semantics.CType,Microsoft.CSharp.RuntimeBinder.Semantics.PointerType>``|False|0
|``System.Collections.Generic.Dictionary<Microsoft.CSharp.RuntimeBinder.Semantics.KeyPair<Microsoft.CSharp.RuntimeBinder.Semantics.CType,Microsoft.CSharp.RuntimeBinder.Syntax.Name>,Microsoft.CSharp.RuntimeBinder.Semantics.ParameterModifierType>``|False|0
|``System.Collections.Generic.Dictionary<Microsoft.CSharp.RuntimeBinder.Semantics.KeyPair<Microsoft.CSharp.RuntimeBinder.Semantics.CType,Microsoft.CSharp.RuntimeBinder.Syntax.Name>,Microsoft.CSharp.RuntimeBinder.Semantics.ArrayType>``|False|0
|``System.Collections.Generic.GenericEqualityComparer<Microsoft.CSharp.RuntimeBinder.Semantics.KeyPair<Microsoft.CSharp.RuntimeBinder.Semantics.CType,Microsoft.CSharp.RuntimeBinder.Syntax.Name>>``|False|0
|``System.Web.HttpApplication+PipelineStepManager``|False|0
|``Microsoft.Owin.Host.SystemWeb.IntegratedPipeline.IntegratedPipelineContextStage``|False|0
|``Microsoft.Owin.Host.SystemWeb.IntegratedPipeline.IntegratedPipelineContext``|False|0
|``System.Web.HttpApplication+AsyncEventExecutionStep``|False|0
|``System.Web.EndEventHandler``|False|0
|``System.Web.BeginEventHandler``|False|0
|``System.Web.HttpApplication+IExecutionStep[]``|False|0
|``System.Collections.Generic.List<System.Web.HttpApplication+IExecutionStep>``|False|0
|``System.Collections.Generic.List<System.Web.HttpApplication+IExecutionStep>[]``|False|0
|``System.Web.HttpApplication+SyncEventExecutionStep``|False|0
|``System.Web.PipelineModuleStepContainer``|False|0
|``System.Web.PipelineModuleStepContainer[]``|False|0
|``System.Collections.Generic.Stack<System.IntPtr[]>``|False|0
|``System.Web.SimpleBufferAllocator<System.IntPtr>``|False|0
|``System.Collections.Generic.Stack<System.Int32[]>``|False|0
|``System.Web.SimpleBufferAllocator<System.Int32>``|False|0
|``System.Collections.Generic.Stack<System.Char[]>``|False|0
|``System.Web.SimpleBufferAllocator<System.Char>``|False|0
|``System.Web.AllocatorProvider``|False|0
|``System.Lazy+Boxed<System.Web.Util.RequestValidator>``|False|0
|``System.Web.Util.RequestValidator``|False|0
|``System.Func<System.Web.Util.RequestValidator>``|False|0
|``System.Lazy+<>c<System.Web.Util.RequestValidator>``|False|0
|``System.Lazy<System.Web.Util.RequestValidator>``|False|0
|``System.Lazy+Boxed<System.Web.Util.HttpEncoder>``|False|0
|``System.Func<System.Web.Util.HttpEncoder>``|False|0
|``System.Lazy+<>c<System.Web.Util.HttpEncoder>``|False|0
|``System.Web.Util.HttpEncoder``|False|0
|``System.Lazy<System.Web.Util.HttpEncoder>``|False|0
|``System.Web.Configuration.TraceSection``|False|0
|``System.Web.Configuration.TraceDisplayMode``|False|0
|``System.Web.RequestQueue``|False|0
|``System.Web.Configuration.HealthMonitoringSectionHelper+ProviderInstances``|False|0
|``System.Web.Configuration.EventMappingSettings``|False|0
|``System.Web.Configuration.EventMappingSettingsCollection``|False|0
|``System.Web.Configuration.RuleSettings``|False|0
|``System.Web.Configuration.RuleSettingsCollection``|False|0
|``System.ComponentModel.Int32Converter``|False|0
|``System.Web.Configuration.ProfileSettings``|False|0
|``System.Web.Configuration.ProfileSettingsCollection``|False|0
|``System.Globalization.TimeSpanParse+TimeSpanToken``|False|0
|``System.Globalization.TimeSpanFormat+FormatLiterals``|False|0
|``System.Globalization.GregorianCalendar``|False|0
|``System.Globalization.DateTimeFormatInfo``|False|0
|``System.ComponentModel.TimeSpanConverter``|False|0
|``System.Web.Configuration.BufferModeSettings``|False|0
|``System.Web.Configuration.BufferModesCollection``|False|0
|``System.Web.Configuration.HealthMonitoringSection``|False|0
|``System.CodeDom.Compiler.CodeDomCompilationConfiguration``|False|0
|``System.Xml.Schema.XmlSchemaInfo``|False|0
|``System.Xml.EmptyEnumerator``|False|0
|``System.CodeDom.Compiler.CodeDomConfigurationHandler``|False|0
|``System.Runtime.Versioning.FrameworkName[]``|False|0
|``System.Collections.Generic.List<System.Runtime.Versioning.FrameworkName>``|False|0
|``System.IO.DirectoryInfo[]``|False|0
|``System.IO.Directory+SearchData[]``|False|0
|``System.Collections.Generic.GenericArraySortHelper<System.UInt64>``|False|0
|``Microsoft.Build.Shared.DirectoryExists``|False|0
|``Microsoft.Build.Shared.GetDirectories``|False|0
|``System.ResolveEventHandler``|False|0
|``System.Web.Util.SimpleRecyclingCache``|False|0
|``System.RuntimeMethodInfoStub``|False|0
|``System.Reflection.Emit.DynamicResolver``|False|0
|``System.Runtime.CompilerServices.Closure``|False|0
|``System.Reflection.Emit.GenericMethodInfo``|False|0
|``System.RuntimeTypeHandle``|False|0
|``System.RuntimeMethodHandle``|False|0
|``System.Reflection.Emit.__FixupData[]``|False|0
|``System.Linq.Expressions.Compiler.LabelScopeInfo[]``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Linq.Expressions.Compiler.LabelScopeInfo>``|False|0
|``System.Reflection.Emit.DynamicScope``|False|0
|``System.Reflection.Emit.SignatureHelper``|False|0
|``System.Reflection.Emit.LineNumberInfo``|False|0
|``System.Reflection.Emit.ScopeTree``|False|0
|``System.Reflection.Emit.DynamicILGenerator``|False|0
|``System.Reflection.Emit.DynamicMethod+RTDynamicMethod``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.PredefinedMethodInfo``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.PredefinedMethodInfo[]``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.PredefinedPropertyInfo``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.PredefinedPropertyInfo[]``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.LocalVariableSymbol``|False|0
|``System.Collections.Generic.HashSet+Slot<Microsoft.CSharp.RuntimeBinder.SymbolTable+NameHashKey>[]``|False|0
|``Microsoft.CSharp.RuntimeBinder.SymbolTable+NameHashKey``|False|0
|``System.Collections.Generic.Dictionary+Entry<Microsoft.CSharp.RuntimeBinder.Semantics.CType,Microsoft.CSharp.RuntimeBinder.Semantics.PointerType>[]``|False|0
|``System.Web.HttpWorkerRequest+EndOfSendNotification``|False|0
|``System.AsyncCallback``|False|0
|``System.StubHelpers.CleanupWorkListElement[]``|False|0
|``System.Runtime.Remoting.Messaging.ServerContextTerminatorSink``|False|0
|``System.Runtime.Remoting.Channels.CrossContextChannel``|False|0
|``System.Runtime.Remoting.Metadata.RemotingTypeCachedData+LastCalledMethodClass``|False|0
|``System.Runtime.Remoting.ServerIdentity+LastCalledType``|False|0
|``Microsoft.Win32.SafeHandles.SafeWaitHandle``|True :warning:|0
|``System.Threading.AutoResetEvent``|True :warning:|0
|``System.Threading.TimerCallback``|False|0
|``System.Runtime.Remoting.Lifetime.LeaseManager``|False|0
|``System.Runtime.CompilerServices.ConditionalWeakTable+Entry<System.Object,System.Runtime.Serialization.SerializationInfo>[]``|False|0
|``System.Runtime.CompilerServices.ConditionalWeakTable<System.Object,System.Runtime.Serialization.SerializationInfo>``|False|0
|``System.Runtime.Serialization.Formatters.Binary.MessageEnd``|False|0
|``System.Runtime.Serialization.SerializationFieldInfo``|False|0
|``System.Security.Policy.Zone``|False|0
|``System.Threading.ThreadPoolWorkQueueThreadLocals``|False|0
|``System.ExecutionEngineException``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder+UnaOpSig``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder+PfnBindUnaOp``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder+UnaOpSig[]``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder+BinOpSig``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder+PfnBindBinOp``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder+BinOpSig[]``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.CNullable``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.ExpressionBinder``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.BindingContext``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.NameGenerator``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.OutputContext``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.ConstValFactory``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.ExprFactory``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.AggregateSymbol[]``|False|0
|``System.Func<System.Reflection.ConstructorInfo,System.Boolean>``|False|0
|``Microsoft.CSharp.RuntimeBinder.SymbolTable+<>c``|False|0
|``System.SZArrayHelper+SZGenericArrayEnumerator<System.Type>``|True :warning:|0
|``System.Collections.Generic.ObjectEqualityComparer<Microsoft.CSharp.RuntimeBinder.SymbolTable+NameHashKey>``|False|0
|``System.Collections.Generic.HashSet<Microsoft.CSharp.RuntimeBinder.SymbolTable+NameHashKey>``|False|0
|``System.Collections.Generic.HashSet<System.Type>``|False|0
|``Microsoft.CSharp.RuntimeBinder.SymbolTable``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.PropertySymbol[]``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.MethodSymbol[]``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.PredefinedMembers``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.SymbolLoader``|False|0
|``Microsoft.CSharp.RuntimeBinder.Errors.ErrorHandling``|False|0
|``Microsoft.CSharp.RuntimeBinder.Errors.UserStringBuilder``|False|0
|``System.Collections.Generic.Dictionary+Entry<System.String,Microsoft.CSharp.RuntimeBinder.Syntax.PredefinedType>[]``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.PredefinedTypeFacts+PredefinedTypeInfo``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.PredefinedTypeFacts+PredefinedTypeInfo[]``|False|0
|``System.Collections.Generic.Dictionary<System.String,Microsoft.CSharp.RuntimeBinder.Syntax.PredefinedType>``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.PredefinedTypes``|False|0
|``System.Func<System.Type,System.String>``|False|0
|``System.Web.Mvc.BuildManagerWrapper``|False|0
|``System.Lazy+Boxed<System.Web.Mvc.IControllerFactory>``|False|0
|``System.Func<System.Type,System.Collections.Generic.IEnumerable<System.Object>>``|False|0
|``System.Func<System.Type,System.Object>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Tables<System.Type,System.Collections.Generic.IEnumerable<System.Object>>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Type,System.Collections.Generic.IEnumerable<System.Object>>[]``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Collections.Generic.IEnumerable<System.Object>>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Tables<System.Type,System.Object>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Type,System.Object>[]``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Object>``|False|0
|``System.Web.Mvc.DependencyResolver+CacheDependencyResolver``|False|0
|``System.Web.Mvc.DependencyResolver+DefaultDependencyResolver``|False|0
|``System.Web.Mvc.DependencyResolver``|False|0
|``System.Lazy+<>c<System.Web.Mvc.IControllerFactory>``|False|0
|``System.Lazy<System.Web.Mvc.IControllerFactory>``|False|0
|``System.Web.Mvc.SingleServiceResolver<System.Web.Mvc.IControllerFactory>``|False|0
|``System.Lazy<System.Web.Mvc.IControllerActivator>``|False|0
|``System.Web.Mvc.SingleServiceResolver<System.Web.Mvc.IControllerActivator>``|False|0
|``System.Func<System.Web.Mvc.IDependencyResolver>``|False|0
|``System.Web.Mvc.DefaultControllerFactory+DefaultControllerActivator``|False|0
|``System.Func<System.Web.Mvc.IControllerActivator>``|False|0
|``System.Web.Mvc.ControllerTypeCache``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Tables<System.Type,System.Web.SessionState.SessionStateBehavior>``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary+Node<System.Type,System.Web.SessionState.SessionStateBehavior>[]``|False|0
|``System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Web.SessionState.SessionStateBehavior>``|False|0
|``System.Web.Mvc.DefaultControllerFactory``|False|0
|``System.Func<System.Web.Mvc.IControllerFactory>``|False|0
|``System.Web.Mvc.ControllerBuilder``|False|0
|``System.Web.Routing.ContentPathSegment+<>c``|False|0
|``System.Web.Management.WebSuccessAuditEvent``|False|0
|``System.Action<System.Type>``|False|0
|``System.Version[]``|False|0
|``System.Collections.Generic.Dictionary+Entry<System.String,System.Web.Compilation.BuildProviderInfo>[]``|False|0
|``System.Collections.Generic.Dictionary<System.String,System.Web.Compilation.BuildProviderInfo>``|False|0
|``System.Web.Compilation.BuildProvider+CompilationBuildProviderInfo``|False|0
|``System.Func<System.Web.UI.RenderTraceListener>[]``|False|0
|``System.Collections.Generic.List<System.Func<System.Web.UI.RenderTraceListener>>``|False|0
|``System.Web.UI.RenderTraceListener+NullRenderTraceListener``|False|0
|``System.Func<System.Web.UI.RenderTraceListener>``|False|0
|``System.Func<System.Web.UI.ParseRecorder>[]``|False|0
|``System.Collections.Generic.List<System.Func<System.Web.UI.ParseRecorder>>``|False|0
|``System.Web.UI.ParseRecorder+NullParseRecorder``|False|0
|``System.Func<System.Web.UI.ParseRecorder>``|False|0
|``Microsoft.VisualStudio.Web.PageInspector.Runtime.Loader.InstalledBrowserLinkModule[]``|False|0
|``Microsoft.VisualStudio.Web.PageInspector.Runtime.Loader.RegisteredBrowserLinkModule[]``|False|0
|``System.Web.Configuration.DeploymentSection``|False|0
|``System.Web.DynamicModuleRegistryEntry[]``|False|0
|``System.Collections.Generic.List<System.Web.DynamicModuleRegistryEntry>``|False|0
|``System.Web.DynamicModuleRegistry``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Reflection.MethodInfo>``|False|0
|``System.Func<System.Reflection.MethodInfo,System.String>``|False|0
|``System.Web.Compilation.BuildManager+<>c``|False|0
|``System.Web.Configuration.ProfilePropertySettingsCollection``|False|0
|``System.Web.Configuration.GlobalizationSection``|False|0
|``System.Web.Configuration.ProfileGroupSettingsCollection``|False|0
|``System.Web.Configuration.RootProfilePropertySettingsCollection``|False|0
|``System.Configuration.ProviderSettings``|False|0
|``System.Configuration.ProviderSettingsCollection``|False|0
|``System.Web.Configuration.ProfileSection``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Web.Hosting.RecycleLimitMonitor>``|False|0
|``System.Collections.Generic.Dictionary<System.Web.Hosting.RecycleLimitMonitor,System.String>``|False|0
|``System.Web.Hosting.RecycleLimitMonitor+RecycleLimitMonitorSingleton``|False|0
|``System.Web.Configuration.ProcessModelComImpersonationLevel``|False|0
|``System.Web.Configuration.ProcessModelComAuthenticationLevel``|False|0
|``System.Web.Configuration.ProcessModelLogLevel``|False|0
|``System.Configuration.InfiniteIntConverter``|False|0
|``System.Configuration.CallbackValidator``|False|0
|``System.Configuration.ValidatorCallback``|False|0
|``System.Web.Configuration.HostingEnvironmentSection``|False|0
|``System.ComponentModel.BooleanConverter``|False|0
|``System.Web.Configuration.WebContext``|False|0
|``System.Configuration.ContextInformation``|False|0
|``System.Web.Configuration.ExpressionBuilder``|False|0
|``System.Web.Configuration.ExpressionBuilderCollection``|False|0
|``System.Web.Configuration.FolderLevelBuildProvider``|False|0
|``System.Web.Configuration.FolderLevelBuildProviderCollection``|False|0
|``System.Web.Configuration.BuildProvider+ConfigurationBuildProviderInfo``|False|0
|``System.Web.Configuration.BuildProvider``|False|0
|``System.Nullable<System.Int32>``|False|0
|``System.Web.Hosting.ApplicationMonitors+AppMonitorRegisteredObject``|False|0
|``System.Collections.Generic.Dictionary+Entry<System.Web.Hosting.RecycleLimitMonitor,System.String>[]``|False|0
|``System.Web.Hosting.AspNetMemoryMonitor+<>c__DisplayClass32_0``|False|0
|``System.Web.Hosting.LowPhysicalMemoryObserver``|False|0
|``System.IObserver<System.Web.Hosting.LowPhysicalMemoryInfo>[]``|False|0
|``System.Collections.Generic.List<System.IObserver<System.Web.Hosting.LowPhysicalMemoryInfo>>``|False|0
|``System.Web.Hosting.LowPhysicalMemoryMonitor``|False|0
|``System.Web.Hosting.AspNetMemoryMonitor+Unsubscriber``|True :warning:|0
|``System.IObserver<System.Web.Hosting.RecycleLimitInfo>[]``|False|0
|``System.Web.Hosting.AspNetMemoryMonitor+<>c__DisplayClass33_0``|False|0
|``System.Web.Hosting.RecycleLimitObserver``|False|0
|``System.Collections.Generic.Dictionary<System.Type,System.Security.Policy.EvidenceTypeDescriptor>``|False|0
|``System.Security.Policy.Evidence``|False|0
|``System.Runtime.Remoting.Services.ITrackingHandler[]``|False|0
|``System.Runtime.Remoting.RemotingConfigHandler+RemotingConfigInfo``|False|0
|``System.Web.Hosting.MemoryBytes``|False|0
|``System.Web.HttpResponseUnmanagedBufferElement``|False|0
|``System.Web.HttpSessionStateWrapper``|False|0
|``System.Collections.Generic.Dictionary+Enumerator<System.String,System.Object>``|True :warning:|0
|``System.Web.Mvc.ResultExecutedContext``|False|0
|``System.Reflection.RuntimeConstructorInfo[]``|False|0
|``System.Reflection.RuntimeConstructorInfo``|False|0
|``System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeConstructorInfo>``|False|0
|``System.Collections.Queue``|False|0
|``System.Security.PermissionToken``|False|0
|``System.Security.PermissionToken[]``|False|0
|``System.Security.PermissionTokenFactory``|False|0
|``System.Web.Configuration.WebConfigurationHost``|False|0
|``System.Configuration.Internal.InternalConfigRoot``|False|0
|``System.Configuration.Internal.ConfigSystem``|False|0
|``System.Web.Configuration.ProcessHostMapPath``|False|0
|``System.Web.FileChangesMonitor``|False|0
|``System.Web.PerfInstanceDataHandle``|True :warning:|0
|``System.Web.PerfCounters+PerfCountersInstance``|False|0
|``System.Reflection.RuntimeMethodInfo[]``|False|0
|``System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>``|False|0
|``System.Runtime.Remoting.Lifetime.LeaseSink``|False|0
|``System.DateTime``|False|0
|``System.Runtime.Remoting.Lifetime.Lease``|False|0
|``System.Threading.TimerHolder``|False|0
|``System.Threading.TimerQueueTimer``|False|0
|``System.Threading.Timer``|True :warning:|0
|``System.Runtime.Remoting.Proxies.ProxyAttribute``|False|0
|``System.Collections.Comparer``|False|0
|``System.Collections.Generic.Dictionary+Entry<System.Type,System.Security.Policy.EvidenceTypeDescriptor>[]``|False|0
|``System.Runtime.Serialization.Formatters.Binary.ObjectReader+TypeNAssembly``|False|0
|``System.Threading.ThreadPoolWorkQueue+WorkStealingQueue``|False|0
|``System.Threading.Thread``|False|0
|``System.Web.Hosting.PrincipalFunctionDelegate``|False|0
|``System.Web.Hosting.RoleFunctionDelegate``|False|0
|``System.Collections.Generic.Dictionary<Microsoft.CSharp.RuntimeBinder.Semantics.KeyPair<Microsoft.CSharp.RuntimeBinder.Semantics.CType,Microsoft.CSharp.RuntimeBinder.Syntax.Name>,Microsoft.CSharp.RuntimeBinder.Semantics.ErrorType>``|False|0
|``System.Collections.Generic.GenericEqualityComparer<Microsoft.CSharp.RuntimeBinder.Semantics.KeyPair<Microsoft.CSharp.RuntimeBinder.Semantics.AssemblyQualifiedNamespaceSymbol,Microsoft.CSharp.RuntimeBinder.Syntax.Name>>``|False|0
|``System.Collections.Generic.Dictionary<Microsoft.CSharp.RuntimeBinder.Semantics.KeyPair<Microsoft.CSharp.RuntimeBinder.Semantics.AssemblyQualifiedNamespaceSymbol,Microsoft.CSharp.RuntimeBinder.Syntax.Name>,Microsoft.CSharp.RuntimeBinder.Semantics.ErrorType>``|False|0
|``System.Collections.Generic.GenericEqualityComparer<Microsoft.CSharp.RuntimeBinder.Semantics.KeyPair<Microsoft.CSharp.RuntimeBinder.Semantics.AggregateSymbol,Microsoft.CSharp.RuntimeBinder.Syntax.Name>>``|False|0
|``System.Collections.Generic.Dictionary<Microsoft.CSharp.RuntimeBinder.Semantics.KeyPair<Microsoft.CSharp.RuntimeBinder.Semantics.AggregateSymbol,Microsoft.CSharp.RuntimeBinder.Syntax.Name>,Microsoft.CSharp.RuntimeBinder.Semantics.AggregateType>``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.TypeTable``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.TypeFactory``|False|0
|``System.Collections.Generic.ObjectEqualityComparer<System.Tuple<System.Reflection.Assembly,System.Reflection.Assembly>>``|False|0
|``System.Collections.Generic.Dictionary<System.Tuple<System.Reflection.Assembly,System.Reflection.Assembly>,System.Boolean>``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.TypeManager``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.GlobalSymbolContext``|False|0
|``Microsoft.CSharp.RuntimeBinder.Semantics.LangCompiler``|False|0
|``Microsoft.CSharp.RuntimeBinder.Syntax.NameManager+KnownName``|False|0
|``Microsoft.CSharp.RuntimeBinder.Syntax.NameManager+KnownName[]``|False|0
|``Microsoft.CSharp.RuntimeBinder.Syntax.NameTable``|False|0
|``Microsoft.CSharp.RuntimeBinder.Syntax.NameManager``|False|0
|``Microsoft.CSharp.RuntimeBinder.Errors.CErrorFactory``|False|0
|``Microsoft.CSharp.RuntimeBinder.RuntimeBinderController``|False|0
|``Microsoft.CSharp.RuntimeBinder.RuntimeBinder``|False|0
|``System.Action<System.Boolean>``|False|0
|``System.SZArrayHelper+SZGenericArrayEnumerator<System.Linq.Expressions.ParameterExpression>``|True :warning:|0
|``System.Web.WebPages.ITemplateFile[]``|False|0
|``System.Collections.Generic.Dictionary<System.String,System.Web.WebPages.SectionWriter>[]``|False|0
|``System.IO.TextWriter[]``|False|0
|``System.Web.Compilation.InstantiateObject``|False|0
|``System.Web.Caching.AggregateCacheDependency``|True :warning:|0
|``System.Web.Compilation.BuildResultCompiledType``|False|0
|``System.Lazy+Boxed<System.Web.Mvc.IViewPageActivator>``|False|0
|``System.Lazy+<>c<System.Web.Mvc.IViewPageActivator>``|False|0
|``System.Web.SR``|False|0
|``System.Configuration.CommaDelimitedStringCollection``|False|0
|``System.Configuration.CommaDelimitedStringCollectionConverter``|False|0
|``System.Web.Configuration.AuthorizationRule``|False|0
|``System.Web.Configuration.AuthorizationRuleCollection``|False|0
|``System.Web.Configuration.AuthorizationSection``|False|0
|``System.Web.Configuration.ScriptingAuthenticationServiceSection``|False|0
|``System.Web.Handlers.ScriptResourceHandler+RuntimeScriptResourceHandler``|False|0
|``System.Security.Principal.WindowsPrincipal``|False|0
|``System.Security.Principal.WindowsIdentity``|True :warning:|0
|``System.Threading.Tasks.TplEtwProvider``|True :warning:|0
|``System.EventHandler<Windows.Foundation.Diagnostics.TracingStatusChangedEventArgs>``|False|0
|``System.Threading.Tasks.ThreadPoolTaskScheduler``|False|0
|``System.Predicate<System.Object>``|False|0
|``System.Predicate<System.Threading.Tasks.Task>``|False|0
|``System.Threading.Tasks.Task+<>c``|False|0
|``System.Func<System.Threading.Tasks.Task+ContingentProperties>``|False|0
|``System.Action<System.Object>``|False|0
|``System.Collections.Generic.GenericEqualityComparer<System.Int32>``|False|0
|``System.Collections.Generic.Dictionary<System.Int32,System.Threading.Tasks.Task>``|False|0
|``System.Threading.Tasks.TaskFactory``|False|0
|``System.Action<System.Threading.Tasks.Task,System.Object>``|False|0
|``System.Web.HttpApplicationFactory+<>c``|False|0
|``System.Web.HttpApplication+CallFilterExecutionStep``|False|0
