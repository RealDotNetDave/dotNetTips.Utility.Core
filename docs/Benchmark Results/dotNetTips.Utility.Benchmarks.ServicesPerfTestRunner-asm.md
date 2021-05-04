## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.ServicesPerfTestRunner.AllServices()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Utility.Standard.Services.AllServices()
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 38
```
```assembly
; dotNetTips.Utility.Standard.Services.AllServices()
       push      rdi
       push      rsi
       sub       rsp,28
       call      System.ServiceProcess.ServiceController.GetServices()
       mov       rsi,rax
       mov       rcx,2E3D14A7698
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L00
       mov       rcx,offset MT_System.Func`2[[System.ServiceProcess.ServiceController, System.ServiceProcess.ServiceController],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2E3D14A7690
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M01_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Standard.Services+<>c.<AllServices>b__0_0(System.ServiceProcess.ServiceController)
       mov       [rdi+18],rdx
       mov       rcx,2E3D14A7698
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rdi
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 147
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.ServicesPerfTestRunner.ServiceExists()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      dotNetTips.Utility.Standard.Services.LoadService(System.String)
       test      rax,rax
       jne       short M00_L00
       xor       eax,eax
       jmp       short M00_L01
M00_L00:
       mov       eax,1
M00_L01:
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
```
```assembly
; dotNetTips.Utility.Standard.Services.LoadService(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Services+<>c__DisplayClass8_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func`2[[System.ServiceProcess.ServiceController, System.ServiceProcess.ServiceController],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.ServiceProcess.ServiceController.GetServices()
       mov       rbx,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset dotNetTips.Utility.Standard.Services+<>c__DisplayClass8_0.<LoadService>b__0(System.ServiceProcess.ServiceController)
       mov       [rsi+18],r9
       lea       r9,[rsp+28]
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 134
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.ServicesPerfTestRunner.ServiceStatus()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      dotNetTips.Utility.Standard.Services.ServiceStatus(System.String)
       mov       [rsp+28],eax
       mov       rcx,[rsi+8]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.ServiceProcess.ServiceControllerStatus, System.ServiceProcess.ServiceController]](System.ServiceProcess.ServiceControllerStatus ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
; dotNetTips.Utility.Standard.Services.ServiceStatus(System.String)
       push      rsi
       sub       rsp,20
       call      dotNetTips.Utility.Standard.Services.LoadService(System.String)
       mov       rsi,rax
       test      rsi,rsi
       je        short M01_L00
       mov       rcx,rsi
       call      System.ServiceProcess.ServiceController.GenerateStatus()
       mov       eax,[rsi+60]
       add       rsp,20
       pop       rsi
       ret
M01_L00:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      dotNetTips.Utility.Standard.Properties.Resources.get_ServiceNotFound()
       mov       rdx,rax
       mov       rcx,rsi
       call      System.InvalidOperationException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.ServiceProcess.ServiceControllerStatus, System.ServiceProcess.ServiceController]](System.ServiceProcess.ServiceControllerStatus ByRef)
       sub       rsp,28
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.ServiceProcess.ServiceControllerStatus, System.ServiceProcess.ServiceController]](System.ServiceProcess.ServiceControllerStatus ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 15
```

