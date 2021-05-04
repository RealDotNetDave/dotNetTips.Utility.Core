## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.FileHelperPerfTestRunner.CopyFileTest()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+28]
       mov       rdx,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Extensions.CollectionExtensions.PickRandom(System.Collections.Generic.IEnumerable`1<!!0>)
       call      dotNetTips.Utility.Standard.Extensions.CollectionExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rax
       mov       rdx,rdi
       call      dotNetTips.Utility.Standard.IO.FileHelper.CopyFile(System.IO.FileInfo, System.IO.DirectoryInfo)
       mov       rdx,[rsi+8]
       mov       ecx,[rdx]
       add       rdx,20
       mov       [rdx],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 63
```
```assembly
; dotNetTips.Utility.Standard.Extensions.CollectionExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Random
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      System.Random.GenerateSeed()
       mov       edx,eax
       mov       rcx,rbx
       call      System.Random..ctor(Int32)
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.Extensions.CollectionExtensions.Count(System.Collections.IEnumerable)
       lea       r8d,[rax+0FFFF]
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF88A9BE0B8]
       mov       ebx,eax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,rsi
       mov       rdx,7FF88AA2DBD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L00:
       mov       rdx,rdi
       mov       r8d,ebx
       mov       rax,offset System.Linq.Enumerable.ElementAt[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 136
```
```assembly
; dotNetTips.Utility.Standard.IO.FileHelper.CopyFile(System.IO.FileInfo, System.IO.DirectoryInfo)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFD8],rax
       mov       [rbp+0FFC8],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1FA50AC3060
       mov       r8,[r8]
       mov       rdx,1FA50AD1CB8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.IO.FileInfo, System.String, System.String)
       mov       r8,1FA50AC3060
       mov       r8,[r8]
       mov       rdx,1FA50AD1CC0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.IO.DirectoryInfo, System.String, System.String)
       mov       rcx,[rdi+8]
       mov       rdx,[rsi+18]
       call      System.IO.Path.Combine(System.String, System.String)
       mov       rdi,rax
       mov       rbx,[rsi+8]
       mov       rcx,offset MT_System.IO.FileStream
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       mov       rdx,rbx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],1000
       mov       [rsp+30],ecx
       mov       rcx,r14
       mov       r8d,3
       mov       r9d,3
       call      System.IO.FileStream..ctor(System.String, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare, Int32, System.IO.FileOptions)
       mov       [rbp+0FFD8],r14
       mov       rcx,rdi
       call      System.IO.File.Exists(System.String)
       test      eax,eax
       je        short M02_L00
       mov       rcx,rdi
       call      System.IO.File.Delete(System.String)
M02_L00:
       mov       rcx,offset MT_System.IO.FileStream
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rdx,rdi
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],1000
       mov       [rsp+30],ecx
       mov       rcx,rbx
       mov       r8d,2
       mov       r9d,3
       call      System.IO.FileStream..ctor(System.String, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare, Int32, System.IO.FileOptions)
       mov       [rbp+0FFD0],rbx
       mov       rcx,[rbp+0FFD8]
       call      System.IO.Stream.GetCopyBufferSize()
       mov       r8d,eax
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFD0]
       call      qword ptr [7FF88A9C6628]
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF88A9C69E0]
       nop
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF88A9C6638]
       nop
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FF88A9C6638]
       mov       rcx,rsi
       mov       rax,offset System.IO.FileInfo.get_Length()
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       jmp       rax
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M02_L01
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FF88A9C6638]
M02_L01:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rbp,[rcx+38]
       mov       [rsp+38],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M02_L02
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FF88A9C6638]
M02_L02:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 453
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.FileHelperPerfTestRunner.CopyFileAsyncTest()
       push      rdi
       push      rsi
       sub       rsp,48
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,0A
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Utility.Benchmarks.IO.FileHelperPerfTestRunner+<CopyFileAsyncTest>d__5, dotNetTips.Utility.Benchmarks]](<CopyFileAsyncTest>d__5 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       jne       short M00_L00
       lea       rcx,[rsp+30]
       call      System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].InitializeTaskAsPromise()
M00_L00:
       nop
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 84
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       eax,[rcx+34]
       and       eax,11000000
       cmp       eax,1000000
       je        short M02_L00
       mov       rax,offset System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       jmp       rax
M02_L00:
       ret
; Total bytes of code 32
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[dotNetTips.Utility.Benchmarks.IO.FileHelperPerfTestRunner+<CopyFileAsyncTest>d__5, dotNetTips.Utility.Benchmarks]](<CopyFileAsyncTest>d__5 ByRef)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       movsx     rcx,byte ptr [rsi]
       mov       rcx,7FF88A6B0020
       mov       edx,1E2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M03_L00
       call      System.Threading.Thread.InitializeCurrentThread()
M03_L00:
       mov       [rbp+0FFF0],rax
       mov       rcx,[rax+8]
       mov       [rbp+0FFE8],rcx
       mov       rcx,[rax+10]
       mov       [rbp+0FFE0],rcx
       mov       rcx,rsi
       call      dotNetTips.Utility.Benchmarks.IO.FileHelperPerfTestRunner+<CopyFileAsyncTest>d__5.MoveNext()
       nop
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L01
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L01:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L02
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L02:
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp+0FFE0]
       mov       rsi,[rbp+0FFF0]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFF0]
       cmp       rcx,[rax+10]
       je        short M03_L03
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M03_L03:
       mov       rdx,[rbp+0FFE8]
       mov       r8,[rsi+8]
       cmp       [rbp+0FFE8],r8
       je        short M03_L04
       mov       rcx,rsi
       call      System.Threading.ExecutionContext.RestoreChangedContextToThread(System.Threading.Thread, System.Threading.ExecutionContext, System.Threading.ExecutionContext)
M03_L04:
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 226
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+34]
       test      ecx,1600000
       jne       short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       mov       rcx,rsi
       call      System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov       ecx,[rsi+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L01
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(System.Threading.Tasks.Task)
M04_L01:
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 75
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].InitializeTaskAsPromise()

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.FileHelperPerfTestRunner.DeleteFilesTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       lea       rcx,[rsp+20]
       mov       edx,64
       mov       r8d,0A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateFiles(Int32, Int32)
       mov       rcx,[rsp+28]
       call      dotNetTips.Utility.Standard.IO.FileHelper.DeleteFiles(System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateFiles(Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
; 			Encapsulation.TryValidateParam(count, 1, int.MaxValue, nameof(count));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,1B1EA963060
       mov       rbp,[rcx]
       mov       r14,rbp
       test      esi,esi
       jle       near ptr M01_L04
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L04
; 			Encapsulation.TryValidateParam(fileLength, 1, int.MaxValue, nameof(fileLength));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edi,edi
       jle       near ptr M01_L06
       cmp       edi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L06
; 			var files = new List<string>(count);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
; 			for (var fileCount = 0; fileCount < count; fileCount++)
; 			     ^^^^^^^^^^^^^^^^^
       xor       ebp,ebp
       test      esi,esi
       jle       short M01_L02
M01_L00:
       mov       ecx,edi
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateTempFile(Int32)
       mov       r8,rax
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L03
       lea       eax,[rdx+1]
       mov       [r14+10],eax
       call      CORINFO_HELP_ARRADDR_ST
M01_L01:
       inc       ebp
       cmp       ebp,esi
       jl        short M01_L00
M01_L02:
       call      System.IO.Path.GetTempPath()
       mov       rdx,rax
; 			return (Path.GetTempPath(), files.AsEnumerable());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,r14
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L01
M01_L04:
       test      r14,r14
       jne       short M01_L05
       call      dotNetTips.Utility.Standard.Properties.Resources.get_NumberNotInRange()
       mov       r14,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF88A9926A8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       test      rbp,rbp
       jne       short M01_L07
       call      dotNetTips.Utility.Standard.Properties.Resources.get_NumberNotInRange()
       mov       rbp,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,2F
       mov       rdx,7FF88A9926A8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 371
```
```assembly
; dotNetTips.Utility.Standard.IO.FileHelper.DeleteFiles(System.Collections.Generic.IEnumerable`1<System.String>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.IO.FileHelper+<>c__DisplayClass6_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       test      rsi,rsi
       je        short M02_L00
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.Extensions.CollectionExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
M02_L00:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1B1FA9668F0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Utility.Standard.IO.FileHelper+<>c__DisplayClass6_0.<DeleteFiles>b__0(System.String)
       mov       [rbx+18],rcx
       lea       rcx,[rsp+28]
       mov       r9,rbx
       mov       r8,rsi
       mov       rdx,offset MD_System.Threading.Tasks.Parallel.ForEach(System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      System.Threading.Tasks.Parallel.ForEach[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       mov       rax,[rdi+8]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 214
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.FileHelperPerfTestRunner.FileHasInvalidCharsTest()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       call      System.IO.Path.GetTempPath()
       mov       rdi,rax
       call      System.IO.Path.GetRandomFileName()
       mov       rdx,rax
       mov       rcx,rdi
       call      System.IO.Path.Combine(System.String, System.String)
       mov       rcx,rax
       mov       rsi,[rsi+8]
       call      dotNetTips.Utility.Standard.IO.FileHelper.FileHasInvalidChars(System.String)
       movzx     eax,al
       mov       [rsi+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 58
```
```assembly
; System.IO.Path.GetTempPath()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       vzeroupper
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+10],rax
       mov       [rbp+20],rax
       mov       rax,63440C97341
       mov       [rbp+8],rax
       add       rsp,20
       test      esp,[rsp]
       sub       rsp,210
       sub       rsp,20
       lea       rcx,[rsp+20]
       xor       eax,eax
       mov       [rbp+10],rax
       lea       rax,[rbp+20]
       mov       [rax],rcx
       mov       dword ptr [rax+8],104
       xor       ecx,ecx
       mov       [rbp+18],ecx
       lea       rcx,[rbp+10]
       call      System.IO.Path.GetTempPath(System.Text.ValueStringBuilder ByRef)
       lea       rcx,[rbp+10]
       call      System.IO.PathHelper.Normalize(System.Text.ValueStringBuilder ByRef)
       mov       rsi,rax
       mov       rdi,[rbp+10]
       lea       rcx,[rbp+10]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+10],xmm0
       test      rdi,rdi
       je        short M01_L00
       mov       rcx,7FF88A6A0020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,11BE7D748D8
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9B0198]
M01_L00:
       mov       rax,rsi
       mov       rcx,63440C97341
       cmp       [rbp+8],rcx
       je        short M01_L01
       call      CORINFO_HELP_FAIL_FAST
M01_L01:
       nop
       lea       rsp,[rbp+30]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 214
```
```assembly
; System.IO.Path.GetRandomFileName()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rax,63440C97341
       mov       [rsp+30],rax
       lea       rsi,[rsp+28]
       mov       rcx,rsi
       mov       edx,8
       call      Interop.GetRandomBytes(Byte*, Int32)
       mov       rcx,11BF7D722F0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M02_L00
       mov       rcx,offset MT_System.Buffers.SpanAction`2[[System.Char, System.Private.CoreLib],[System.IntPtr, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,11BF7D722E8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M02_L02
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset System.IO.Path+<>c.<GetRandomFileName>b__16_0(System.Span`1<Char>, IntPtr)
       mov       [rdi+18],rdx
       mov       rcx,11BF7D722F0
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rdi
M02_L00:
       mov       ecx,0C
       mov       rdx,rsi
       call      System.String.Create[[System.IntPtr, System.Private.CoreLib]](Int32, IntPtr, System.Buffers.SpanAction`2<Char,IntPtr>)
       mov       rcx,63440C97341
       cmp       [rsp+30],rcx
       je        short M02_L01
       call      CORINFO_HELP_FAIL_FAST
M02_L01:
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 189
```
```assembly
; System.IO.Path.Combine(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       je        short M03_L00
       test      rdx,rdx
       je        short M03_L00
       mov       rax,offset System.IO.Path.CombineInternal(System.String, System.String)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M03_L00:
       test      rcx,rcx
       je        short M03_L01
       mov       rcx,11BE7D7D020
       mov       rsi,[rcx]
       jmp       short M03_L02
M03_L01:
       mov       rcx,11BE7D7D028
       mov       rsi,[rcx]
M03_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 106
```
```assembly
; dotNetTips.Utility.Standard.IO.FileHelper.FileHasInvalidChars(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       r8,11BF7D73060
       mov       r8,[r8]
       mov       rdx,11BF7D734B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       r9,11BE7D77688
       mov       rdx,[r9]
       mov       r9d,[rsi]
       mov       r9d,[rsi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 88
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.FileHelperPerfTestRunner.MoveFileTest()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       call      System.IO.Path.GetTempPath()
       mov       rdi,rax
       call      System.IO.Path.GetRandomFileName()
       mov       rdx,rax
       mov       rcx,rdi
       call      System.IO.Path.Combine(System.String, System.String)
       mov       rdi,rax
       mov       ecx,[rsi+3C]
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateTempFile(Int32)
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,offset dotNetTips.Utility.Standard.IO.FileHelper.MoveFile(System.String, System.String)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 69
```
```assembly
; System.IO.Path.GetTempPath()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       vzeroupper
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+10],rax
       mov       [rbp+20],rax
       mov       rax,0C2E188407955
       mov       [rbp+8],rax
       add       rsp,20
       test      esp,[rsp]
       sub       rsp,210
       sub       rsp,20
       lea       rcx,[rsp+20]
       xor       eax,eax
       mov       [rbp+10],rax
       lea       rax,[rbp+20]
       mov       [rax],rcx
       mov       dword ptr [rax+8],104
       xor       ecx,ecx
       mov       [rbp+18],ecx
       lea       rcx,[rbp+10]
       call      System.IO.Path.GetTempPath(System.Text.ValueStringBuilder ByRef)
       lea       rcx,[rbp+10]
       call      System.IO.PathHelper.Normalize(System.Text.ValueStringBuilder ByRef)
       mov       rsi,rax
       mov       rdi,[rbp+10]
       lea       rcx,[rbp+10]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       vmovdqu   xmmword ptr [rcx+10],xmm0
       test      rdi,rdi
       je        short M01_L00
       mov       rcx,7FF88A6B0020
       mov       edx,26
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,27D9ABD48D8
       mov       rcx,[rcx]
       mov       rdx,rdi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9CAA40]
M01_L00:
       mov       rax,rsi
       mov       rcx,0C2E188407955
       cmp       [rbp+8],rcx
       je        short M01_L01
       call      CORINFO_HELP_FAIL_FAST
M01_L01:
       nop
       lea       rsp,[rbp+30]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 214
```
```assembly
; System.IO.Path.GetRandomFileName()
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rax,0C2E188407955
       mov       [rsp+30],rax
       lea       rsi,[rsp+28]
       mov       rcx,rsi
       mov       edx,8
       call      Interop.GetRandomBytes(Byte*, Int32)
       mov       rcx,27D8ABD22F0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M02_L00
       mov       rcx,offset MT_System.Buffers.SpanAction`2[[System.Char, System.Private.CoreLib],[System.IntPtr, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,27D8ABD22E8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M02_L02
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset System.IO.Path+<>c.<GetRandomFileName>b__16_0(System.Span`1<Char>, IntPtr)
       mov       [rdi+18],rdx
       mov       rcx,27D8ABD22F0
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rdi
M02_L00:
       mov       ecx,0C
       mov       rdx,rsi
       call      System.String.Create[[System.IntPtr, System.Private.CoreLib]](Int32, IntPtr, System.Buffers.SpanAction`2<Char,IntPtr>)
       mov       rcx,0C2E188407955
       cmp       [rsp+30],rcx
       je        short M02_L01
       call      CORINFO_HELP_FAIL_FAST
M02_L01:
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 189
```
```assembly
; System.IO.Path.Combine(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       je        short M03_L00
       test      rdx,rdx
       je        short M03_L00
       mov       rax,offset System.IO.Path.CombineInternal(System.String, System.String)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M03_L00:
       test      rcx,rcx
       je        short M03_L01
       mov       rcx,27D7ABD1070
       mov       rsi,[rcx]
       jmp       short M03_L02
M03_L01:
       mov       rcx,27D7ABD1078
       mov       rsi,[rcx]
M03_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 106
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateTempFile(Int32)
; 			Encapsulation.TryValidateParam(fileLength, 1, int.MaxValue, nameof(fileLength));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var fileName = GenerateRandomFileName();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var fakeText = GenerateWord(fileLength);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			File.WriteAllText(fileName, fakeText);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return fileName;
; 			^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       esi,ecx
       mov       rax,27D8ABD3060
       mov       rdi,[rax]
       test      esi,esi
       jle       short M04_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       je        short M04_L00
       call      System.IO.Path.GetTempPath()
       mov       rdi,rax
       call      System.IO.Path.GetRandomFileName()
       mov       rdx,rax
       mov       rcx,rdi
       call      System.IO.Path.Combine(System.String, System.String)
       mov       rdi,rax
       mov       ecx,esi
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.IO.File.WriteAllText(System.String, System.String)
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M04_L00:
       test      rdi,rdi
       jne       short M04_L01
       call      dotNetTips.Utility.Standard.Properties.Resources.get_NumberNotInRange()
       mov       rdi,rax
M04_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,2F
       mov       rdx,7FF88A9926A8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 170
```
```assembly
; dotNetTips.Utility.Standard.IO.FileHelper.MoveFile(System.String, System.String)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       r8,27D8ABD3060
       mov       r8,[r8]
       mov       rdx,27D6ABD1068
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       r8,27D8ABD3060
       mov       r8,[r8]
       mov       rdx,27D6ABD1070
       mov       rdx,[rdx]
       mov       rcx,[rbp+18]
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,[rbp+10]
       call      System.IO.File.Exists(System.String)
       mov       esi,eax
       mov       rcx,27D6ABD1068
       mov       rdi,[rcx]
       mov       rcx,27D6ABD1078
       mov       rcx,[rcx]
       mov       r8,27D6ABD1080
       mov       r8,[r8]
       mov       rdx,[rbp+10]
       call      System.String.Concat(System.String, System.String, System.String)
       mov       r9,rax
       mov       r8,rdi
       mov       edx,esi
       mov       rcx,offset MD_dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ecx,ecx
       mov       [rbp+0FFEC],ecx
M05_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      System.IO.File.Move(System.String, System.String, Boolean)
       jmp       short M05_L01
       mov       ecx,[rbp+0FFEC]
       inc       ecx
       lea       ecx,[rcx+rcx*4]
       shl       ecx,1
       call      System.Threading.Thread.SleepInternal(Int32)
       mov       edx,[rbp+0FFEC]
       inc       edx
       mov       [rbp+0FFEC],edx
       cmp       dword ptr [rbp+0FFEC],0A
       jl        short M05_L00
M05_L01:
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       mov       rcx,offset MT_System.IO.IOException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M05_L02
       xor       eax,eax
       jmp       short M05_L03
M05_L02:
       cmp       dword ptr [rbp+0FFEC],9
       setl      al
       movzx     eax,al
       test      eax,eax
       setne     al
       movzx     eax,al
M05_L03:
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       lea       rax,[7FF88A9CBB97]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       mov       rcx,offset MT_System.UnauthorizedAccessException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M05_L04
       xor       eax,eax
       jmp       short M05_L05
M05_L04:
       cmp       dword ptr [rbp+0FFEC],9
       setl      al
       movzx     eax,al
       test      eax,eax
       setne     al
       movzx     eax,al
M05_L05:
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       lea       rax,[7FF88A9CBB97]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 446
```

