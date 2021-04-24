## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.DriveHelperPerfTestRunner.GetFixedDrives()
;             var result = DriveHelper.GetFixedDrives();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Utility.Standard.IO.DriveHelper.GetFixedDrives()
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
; dotNetTips.Utility.Standard.IO.DriveHelper.GetFixedDrives()
;             return DriveInfo.GetDrives()
;             ^^^^^^^^^^^^^^^^^^^^^^^
;                 .Where(p => p.DriveType == DriveType.Fixed & p.IsReady)
;             ^^^^^^^^^^^^^^^^^^^^^^^
;                 .Distinct()
;             ^^^^^^^^^^^^^^^^^^^^^^^
;                 .ToImmutableList();
;             ^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       call      System.IO.DriveInfo.GetDrives()
       mov       rsi,rax
       mov       rcx,16243C07740
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L00
       mov       rcx,offset MT_System.Func`2[[System.IO.DriveInfo, System.IO.FileSystem.DriveInfo],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,16243C07738
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M01_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Standard.IO.DriveHelper+<>c.<GetFixedDrives>b__1_0(System.IO.DriveInfo)
       mov       [rdi+18],rdx
       mov       rcx,16243C07740
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rdi
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Where(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.Distinct(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEqualityComparer`1<!!0>)
       xor       r8d,r8d
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Immutable.ImmutableList.ToImmutableList(System.Collections.Generic.IEnumerable`1<!!0>)
       mov       rax,offset System.Collections.Immutable.ImmutableList.ToImmutableList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 192
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.DriveHelperPerfTestRunner.GetRemovableDrives()
;             var result = DriveHelper.GetRemovableDrives();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Utility.Standard.IO.DriveHelper.GetRemovableDrives()
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
; dotNetTips.Utility.Standard.IO.DriveHelper.GetRemovableDrives()
;             return DriveInfo.GetDrives()
;             ^^^^^^^^^^^^^^^^^^^^^^^
;                 .Where(p => p.DriveType == DriveType.Removable & p.IsReady)
;             ^^^^^^^^^^^^^^^^^^^^^^^
;                 .Distinct()
;             ^^^^^^^^^^^^^^^^^^^^^^^
;                 .ToImmutableList();
;             ^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       call      System.IO.DriveInfo.GetDrives()
       mov       rsi,rax
       mov       rcx,23DFCFB7748
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L00
       mov       rcx,offset MT_System.Func`2[[System.IO.DriveInfo, System.IO.FileSystem.DriveInfo],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,23DFCFB7738
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M01_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Standard.IO.DriveHelper+<>c.<GetRemovableDrives>b__2_0(System.IO.DriveInfo)
       mov       [rdi+18],rdx
       mov       rcx,23DFCFB7748
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rdi
M01_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Where(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.Distinct(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEqualityComparer`1<!!0>)
       xor       r8d,r8d
       call      System.Linq.Enumerable.Distinct[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_System.Collections.Immutable.ImmutableList.ToImmutableList(System.Collections.Generic.IEnumerable`1<!!0>)
       mov       rax,offset System.Collections.Immutable.ImmutableList.ToImmutableList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 192
```

