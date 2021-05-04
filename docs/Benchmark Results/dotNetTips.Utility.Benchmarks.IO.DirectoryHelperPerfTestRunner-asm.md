## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.DirectoryHelperPerfTestRunner.LoadDirectoryFiles()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC8],rsp
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.IO.FileSystem]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,7FF88A690020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,16992F08D48
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2B
       xor       edx,edx
       call      System.Environment.GetFolderPath(SpecialFolder, SpecialFolderOption)
       mov       r14,rax
       mov       dword ptr [rbx+20],0FFFFFFFF
       mov       rcx,r14
       call      System.IO.Path.GetFullPath(System.String)
       mov       r8,rax
       mov       dword ptr [rsp+20],1
       mov       rdx,r14
       mov       rcx,rbx
       xor       r9d,r9d
       call      System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L00
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L01
M00_L00:
       mov       rcx,rdi
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2C
       xor       edx,edx
       call      System.Environment.GetFolderPath(SpecialFolder, SpecialFolderOption)
       mov       r14,rax
       mov       dword ptr [rbx+20],0FFFFFFFF
       mov       rcx,r14
       call      System.IO.Path.GetFullPath(System.String)
       mov       r8,rax
       mov       dword ptr [rsp+20],1
       mov       rdx,r14
       mov       rcx,rbx
       xor       r9d,r9d
       call      System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L03
M00_L02:
       mov       rcx,rdi
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       ecx,ecx
       xor       edx,edx
       call      System.Environment.GetFolderPath(SpecialFolder, SpecialFolderOption)
       mov       r14,rax
       mov       dword ptr [rbx+20],0FFFFFFFF
       mov       rcx,r14
       call      System.IO.Path.GetFullPath(System.String)
       mov       r8,rax
       mov       dword ptr [rsp+20],1
       mov       rdx,r14
       mov       rcx,rbx
       xor       r9d,r9d
       call      System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L04
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L05
M00_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L05:
       mov       rdx,16992F11488
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,1
       call      dotNetTips.Utility.Standard.IO.DirectoryHelper.LoadFiles(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>, System.String, System.IO.SearchOption)
       mov       rcx,rax
       mov       r11,7FF88A5A0440
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C0440]
       mov       [rbp+0FFD8],rax
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FF88A5A0448
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C0448]
       test      eax,eax
       je        short M00_L07
M00_L06:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FF88A5A0450
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C0450]
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FF88A5A0448
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C0448]
       test      eax,eax
       jne       short M00_L06
M00_L07:
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FF88A5A0458
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C0458]
       nop
       lea       rsp,[rbp+0FFE0]
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
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L08
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FF88A5A0458
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9C0458]
M00_L08:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 672
```
```assembly
; System.Environment.GetFolderPath(SpecialFolder, SpecialFolderOption)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       edi,ecx
       mov       esi,edx
       mov       rcx,offset MT_System.Environment+SpecialFolder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Environment+SpecialFolder
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [rbx+8],edi
       mov       rdx,rbx
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       je        short M01_L01
       test      esi,esi
       je        short M01_L00
       mov       rcx,offset MT_System.Environment+SpecialFolderOption
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Environment+SpecialFolderOption
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [rbx+8],esi
       mov       rdx,rbx
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       je        near ptr M01_L02
M01_L00:
       mov       ecx,edi
       mov       edx,esi
       mov       rax,offset System.Environment.GetFolderPathCore(SpecialFolder, SpecialFolderOption)
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       rax
M01_L01:
       mov       rcx,offset MT_System.Environment+SpecialFolder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsi+8],edi
       mov       rcx,offset MT_System.Environment+SpecialFolder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2C54
       mov       rdx,7FF88A594020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,16992F03060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rbp,rax
       mov       [rbx+8],edi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,2A1
       mov       rdx,7FF88A594020
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      System.SR.Format(System.String, System.Object)
       mov       r9,rax
       mov       rdx,r14
       mov       r8,rsi
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.Object, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       rcx,offset MT_System.Environment+SpecialFolderOption
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rdi+8],esi
       mov       rcx,offset MT_System.Environment+SpecialFolderOption
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,2C54
       mov       rdx,7FF88A594020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,16992F03060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rbp,rax
       mov       [rbx+8],esi
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,2AF
       mov       rdx,7FF88A594020
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      System.SR.Format(System.String, System.Object)
       mov       r9,rax
       mov       rdx,r14
       mov       r8,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.Object, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 478
```
```assembly
; System.IO.Path.GetFullPath(System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short M02_L01
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
       lea       rdx,[rsp+28]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+28]
       call      System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M02_L02
       lea       rcx,[rsi+0C]
       mov       r8d,[rsi+8]
       xor       edx,edx
       call      System.SpanHelpers.Contains(Char ByRef, Char, Int32)
       test      eax,eax
       jne       near ptr M02_L03
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
       lea       rdx,[rsp+28]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+28]
       call      System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       je        short M02_L00
       mov       rax,rsi
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rcx,rsi
       call      System.IO.PathHelper.Normalize(System.String)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,15517
       mov       rdx,7FF88A594020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,3F26
       mov       rdx,7FF88A594020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,16992F03060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       ecx,15517
       mov       rdx,7FF88A594020
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,6726
       mov       rdx,7FF88A594020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,16992F03060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       ecx,15517
       mov       rdx,7FF88A594020
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 404
```
```assembly
; System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,10
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
       mov       r14d,[rsp+0B0]
       mov       rdx,rbx
       test      rdx,rdx
       je        near ptr M03_L12
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       short M03_L00
       mov       rsi,rbx
M03_L00:
       test      r14b,r14b
       jne       short M03_L01
       mov       rcx,rsi
       call      System.IO.Path.GetFullPath(System.String)
       jmp       short M03_L02
M03_L01:
       mov       rax,rsi
M03_L02:
       mov       rsi,rax
       mov       rdx,rbp
       test      rdx,rdx
       jne       near ptr M03_L11
       test      rsi,rsi
       jne       short M03_L03
       xor       ecx,ecx
       xor       ebx,ebx
       jmp       short M03_L04
M03_L03:
       lea       rcx,[rsi+0C]
       mov       ebx,[rsi+8]
M03_L04:
       mov       eax,ebx
       lea       rdx,[rsp+20]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+20]
       call      System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,ebx
       je        short M03_L07
       test      rsi,rsi
       jne       short M03_L05
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M03_L06
M03_L05:
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
M03_L06:
       lea       rax,[rsp+30]
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rax
       lea       rdx,[rsp+20]
       call      System.IO.Path.TrimEndingDirectorySeparator(System.ReadOnlySpan`1<Char>)
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+20]
       mov       rax,[rsp+30]
       mov       [rdx],rax
       mov       eax,[rsp+38]
       mov       [rdx+8],eax
       lea       rdx,[rsp+20]
       call      System.IO.Path.GetFileName(System.ReadOnlySpan`1<Char>)
       jmp       short M03_L10
M03_L07:
       test      rsi,rsi
       jne       short M03_L08
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M03_L09
M03_L08:
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
M03_L09:
       mov       [rsp+40],rcx
       mov       [rsp+48],eax
M03_L10:
       mov       rcx,[rsp+40]
       mov       [rsp+50],rcx
       mov       ecx,[rsp+48]
       mov       [rsp+58],ecx
       lea       rcx,[rsp+50]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rdx,rax
M03_L11:
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+50],r14b
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L12:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,615
       mov       rdx,7FF88A8F2450
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 397
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].EnsureCapacity(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
```
```assembly
; dotNetTips.Utility.Standard.IO.DirectoryHelper.LoadFiles(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>, System.String, System.IO.SearchOption)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,0B0
       lea       rbp,[rsp+0C0]
       mov       rsi,rcx
       lea       rdi,[rbp+0FF60]
       mov       ecx,24
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       rcx,offset MT_dotNetTips.Utility.Standard.IO.DirectoryHelper+<>c__DisplayClass7_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD8],rax
       mov       rcx,[rbp+0FFD8]
       call      dotNetTips.Utility.Standard.IO.DirectoryHelper+<>c__DisplayClass7_0..ctor()
       mov       rdx,[rbp+0FFD8]
       mov       [rbp+0FFE8],rdx
       mov       rdx,[rbp+0FFE8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp+0FFE8]
       mov       edx,[rbp+20]
       mov       [r8+18],edx
       mov       r8,16992F03060
       mov       r8,[r8]
       mov       rdx,16992F11618
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,[rbp+0FFE8]
       mov       rcx,[rcx+8]
       mov       rdx,16992F11620
       mov       rdx,[rdx]
       mov       r8,16992F03060
       mov       r8,[r8]
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       mov       rcx,[rbp+0FFE8]
       mov       ecx,[rcx+18]
       mov       rdx,[rbp+0FFD0]
       mov       [rdx+8],ecx
       mov       rcx,[rbp+0FFD0]
       mov       rdx,16992F11628
       mov       rdx,[rdx]
       mov       r8,16992F03060
       mov       r8,[r8]
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.Enum, System.String, System.String)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.FileInfo, System.IO.FileSystem]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFC8],rax
       mov       rcx,[rbp+0FFC8]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp+0FFE8]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp+0FFC8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF88A973818
       mov       edx,6D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16992F0BBA8
       mov       rcx,[rcx]
       mov       [rbp+0FFC0],rcx
       mov       rcx,[rbp+10]
       mov       [rbp+0FFB8],rcx
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB0],rcx
       cmp       qword ptr [rbp+0FFC0],0
       jne       near ptr M05_L00
       mov       rcx,offset MT_System.Func`2[[System.IO.DirectoryInfo, System.IO.FileSystem],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FF78],rax
       mov       rcx,7FF88A973818
       mov       edx,6D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,16992F0BBA0
       mov       rdx,[rdx]
       mov       [rbp+0FF70],rdx
       mov       rdx,[rbp+0FF70]
       mov       r8,offset dotNetTips.Utility.Standard.IO.DirectoryHelper+<>c.<LoadFiles>b__7_0(System.IO.DirectoryInfo)
       mov       rcx,[rbp+0FF78]
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF88A973818
       mov       edx,6D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16992F0BBA8
       mov       rdx,[rbp+0FF78]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,[rbp+0FF78]
       mov       [rbp+0FFB0],r8
M05_L00:
       mov       r8,[rbp+0FFB0]
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MD_System.Linq.Enumerable.Where(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp+0FFA0],rax
       mov       rcx,7FF88A973818
       mov       edx,6D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16992F0BBB0
       mov       rcx,[rcx]
       mov       [rbp+0FFA8],rcx
       mov       rcx,[rbp+0FFA0]
       mov       [rbp+0FF98],rcx
       mov       rcx,[rbp+0FFA8]
       mov       [rbp+0FF90],rcx
       cmp       qword ptr [rbp+0FFA8],0
       jne       near ptr M05_L01
       mov       rcx,offset MT_System.Func`2[[System.IO.DirectoryInfo, System.IO.FileSystem],[System.IO.DirectoryInfo, System.IO.FileSystem]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FF80],rax
       mov       rcx,7FF88A973818
       mov       edx,6D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,16992F0BBA0
       mov       rdx,[rdx]
       mov       [rbp+0FF68],rdx
       mov       rdx,[rbp+0FF68]
       mov       r8,offset dotNetTips.Utility.Standard.IO.DirectoryHelper+<>c.<LoadFiles>b__7_1(System.IO.DirectoryInfo)
       mov       rcx,[rbp+0FF80]
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,7FF88A973818
       mov       edx,6D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16992F0BBB0
       mov       rdx,[rbp+0FF80]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,[rbp+0FF80]
       mov       [rbp+0FF90],r8
M05_L01:
       mov       r8,[rbp+0FF90]
       mov       rdx,[rbp+0FF98]
       mov       rcx,offset MD_System.Linq.Enumerable.Select(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp+0FF60],rax
       mov       rdx,[rbp+0FF60]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp+0FFE0],rax
       mov       rcx,offset MT_System.Action`1[[System.IO.DirectoryInfo, System.IO.FileSystem]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FF88],rax
       mov       r8,offset dotNetTips.Utility.Standard.IO.DirectoryHelper+<>c__DisplayClass7_0.<LoadFiles>b__2(System.IO.DirectoryInfo)
       mov       rcx,[rbp+0FF88]
       mov       rdx,[rbp+0FFE8]
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+0FFE0]
       mov       rdx,[rbp+0FF88]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rdx,[rbp+0FFE8]
       mov       rdx,[rdx+10]
       mov       rcx,offset MD_System.Linq.Enumerable.AsEnumerable(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.AsEnumerable[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 879
```

## 
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_543.__ForDisassemblyDiagnoser__()

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.DirectoryHelperPerfTestRunner.SafeDirectorySearch()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+28]
       mov       dword ptr [rdi+20],0FFFFFFFF
       mov       rcx,rbx
       call      System.IO.Path.GetFullPath(System.String)
       mov       r8,rax
       mov       dword ptr [rsp+20],1
       mov       rdx,rbx
       mov       rcx,rdi
       xor       r9d,r9d
       call      System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       mov       rdx,20AE03418A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       xor       r8d,r8d
       call      dotNetTips.Utility.Standard.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
```
```assembly
; System.IO.Path.GetFullPath(System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short M01_L01
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
       lea       rdx,[rsp+28]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+28]
       call      System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M01_L02
       lea       rcx,[rsi+0C]
       mov       r8d,[rsi+8]
       xor       edx,edx
       call      System.SpanHelpers.Contains(Char ByRef, Char, Int32)
       test      eax,eax
       jne       near ptr M01_L03
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
       lea       rdx,[rsp+28]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+28]
       call      System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,rsi
       call      System.IO.PathHelper.Normalize(System.String)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,15517
       mov       rdx,7FF88A594020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,3F26
       mov       rdx,7FF88A594020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,20AB0343060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       ecx,15517
       mov       rdx,7FF88A594020
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,6726
       mov       rdx,7FF88A594020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,20AB0343060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       ecx,15517
       mov       rdx,7FF88A594020
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 404
```
```assembly
; System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,10
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
       mov       r14d,[rsp+0B0]
       mov       rdx,rbx
       test      rdx,rdx
       je        near ptr M02_L12
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       short M02_L00
       mov       rsi,rbx
M02_L00:
       test      r14b,r14b
       jne       short M02_L01
       mov       rcx,rsi
       call      System.IO.Path.GetFullPath(System.String)
       jmp       short M02_L02
M02_L01:
       mov       rax,rsi
M02_L02:
       mov       rsi,rax
       mov       rdx,rbp
       test      rdx,rdx
       jne       near ptr M02_L11
       test      rsi,rsi
       jne       short M02_L03
       xor       ecx,ecx
       xor       ebx,ebx
       jmp       short M02_L04
M02_L03:
       lea       rcx,[rsi+0C]
       mov       ebx,[rsi+8]
M02_L04:
       mov       eax,ebx
       lea       rdx,[rsp+20]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+20]
       call      System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,ebx
       je        short M02_L07
       test      rsi,rsi
       jne       short M02_L05
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M02_L06
M02_L05:
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
M02_L06:
       lea       rax,[rsp+30]
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rax
       lea       rdx,[rsp+20]
       call      System.IO.Path.TrimEndingDirectorySeparator(System.ReadOnlySpan`1<Char>)
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+20]
       mov       rax,[rsp+30]
       mov       [rdx],rax
       mov       eax,[rsp+38]
       mov       [rdx+8],eax
       lea       rdx,[rsp+20]
       call      System.IO.Path.GetFileName(System.ReadOnlySpan`1<Char>)
       jmp       short M02_L10
M02_L07:
       test      rsi,rsi
       jne       short M02_L08
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M02_L09
M02_L08:
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
M02_L09:
       mov       [rsp+40],rcx
       mov       [rsp+48],eax
M02_L10:
       mov       rcx,[rsp+40]
       mov       [rsp+50],rcx
       mov       ecx,[rsp+48]
       mov       [rsp+58],ecx
       lea       rcx,[rsp+50]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rdx,rax
M02_L11:
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+50],r14b
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L12:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,615
       mov       rdx,7FF88A8F2450
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 397
```
```assembly
; dotNetTips.Utility.Standard.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD8],rax
       mov       [rbp+0FFC8],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       r8,20AB0343060
       mov       r8,[r8]
       mov       rdx,20AE03418B0
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.IO.DirectoryInfo, System.String, System.String)
       mov       rcx,20AB0343060
       mov       rsi,[rcx]
       cmp       qword ptr [rbp+18],0
       je        near ptr M03_L08
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.IO.FileSystem]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FF88A690020
       mov       edx,27
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,20AB0348D48
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       short M03_L00
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       mov       r8,[rbp+10]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L01:
       mov       [rbp+0FFE0],rsi
       xor       ecx,ecx
       mov       [rbp+0FFEC],ecx
       jmp       near ptr M03_L07
M03_L02:
       mov       ecx,[rbp+20]
       call      System.IO.EnumerationOptions.FromSearchOption(System.IO.SearchOption)
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+8]
       mov       rcx,[rbp+10]
       mov       r8,[rbp+18]
       mov       r9d,2
       call      System.IO.DirectoryInfo.InternalEnumerateInfos(System.String, System.String, System.IO.SearchTarget, System.IO.EnumerationOptions)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.IO.DirectoryInfo, System.IO.FileSystem]]
       call      CORINFO_HELP_CHKCASTANY
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       ecx,[rax+8]
       cmp       [rbp+0FFEC],ecx
       jae       short M03_L03
       mov       ecx,[rbp+0FFEC]
       movsxd    rcx,ecx
       mov       rcx,[rax+rcx*8+10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      dotNetTips.Utility.Standard.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       mov       rsi,rax
       test      rsi,rsi
       jne       short M03_L04
       xor       edi,edi
       jmp       short M03_L05
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M03_L04:
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.Extensions.CollectionExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M03_L05:
       test      edi,edi
       je        short M03_L06
       mov       r8,rsi
       mov       rdx,[rbp+0FFE0]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, Boolean)
       mov       r9d,1
       call      dotNetTips.Utility.Standard.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean)
       nop
M03_L06:
       mov       eax,[rbp+0FFEC]
       inc       eax
       mov       [rbp+0FFEC],eax
M03_L07:
       mov       rcx,[rbp+10]
       mov       ecx,[rcx]
       mov       ecx,[rbp+20]
       call      System.IO.EnumerationOptions.FromSearchOption(System.IO.SearchOption)
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+8]
       mov       rcx,[rbp+10]
       mov       r8,[rbp+18]
       mov       r9d,2
       call      System.IO.DirectoryInfo.InternalEnumerateInfos(System.String, System.String, System.IO.SearchTarget, System.IO.EnumerationOptions)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.IO.DirectoryInfo, System.IO.FileSystem]]
       call      CORINFO_HELP_CHKCASTANY
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       ecx,[rax+8]
       cmp       ecx,[rbp+0FFEC]
       jg        near ptr M03_L02
       mov       rax,[rbp+0FFE0]
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L08:
       test      rsi,rsi
       jne       short M03_L09
       call      dotNetTips.Utility.Standard.Properties.Resources.get_StringIsEmpty()
       mov       rsi,rax
M03_L09:
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Common.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       ecx,0E5D
       mov       rdx,7FF88A973048
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rdi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80070057
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+60]
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdx,rax
       test      rdx,rdx
       jne       short M03_L10
       xor       eax,eax
       jmp       near ptr M03_L13
M03_L10:
       mov       [rbp+0FFD8],rdx
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M03_L11
       mov       rdx,[rbp+0FFD8]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M03_L11
       mov       rdx,[rbp+0FFD8]
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M03_L11
       mov       rdx,[rbp+0FFD8]
       mov       rcx,offset MT_System.IO.DirectoryNotFoundException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M03_L11
       mov       rdx,[rbp+0FFD8]
       mov       rcx,offset MT_System.UnauthorizedAccessException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       setne     al
       movzx     eax,al
       jmp       short M03_L12
M03_L11:
       mov       eax,1
M03_L12:
       test      eax,eax
       setne     al
       movzx     eax,al
M03_L13:
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFD8]
       mov       rax,[rbp+0FFD8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rcx,rax
       call      System.Diagnostics.Trace.WriteLine(System.String)
       lea       rax,[7FF88A9C4764]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 872
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.DirectoryHelperPerfTestRunner.SafeFileSearch()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+28]
       mov       dword ptr [rdi+20],0FFFFFFFF
       mov       rcx,rbx
       call      System.IO.Path.GetFullPath(System.String)
       mov       r8,rax
       mov       dword ptr [rsp+20],1
       mov       rdx,rbx
       mov       rcx,rdi
       xor       r9d,r9d
       call      System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       mov       rdx,1D04DB31070
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8d,1
       call      dotNetTips.Utility.Standard.IO.DirectoryHelper.SafeFileSearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 126
```
```assembly
; System.IO.Path.GetFullPath(System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short M01_L01
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
       lea       rdx,[rsp+28]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+28]
       call      System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M01_L02
       lea       rcx,[rsi+0C]
       mov       r8d,[rsi+8]
       xor       edx,edx
       call      System.SpanHelpers.Contains(Char ByRef, Char, Int32)
       test      eax,eax
       jne       near ptr M01_L03
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
       lea       rdx,[rsp+28]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+28]
       call      System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,rsi
       call      System.IO.PathHelper.Normalize(System.String)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,15517
       mov       rdx,7FF88A5A4020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,3F26
       mov       rdx,7FF88A5A4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1D01DB33060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       ecx,15517
       mov       rdx,7FF88A5A4020
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,6726
       mov       rdx,7FF88A5A4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,1D01DB33060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       ecx,15517
       mov       rdx,7FF88A5A4020
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 404
```
```assembly
; System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,10
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
       mov       r14d,[rsp+0B0]
       mov       rdx,rbx
       test      rdx,rdx
       je        near ptr M02_L12
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       short M02_L00
       mov       rsi,rbx
M02_L00:
       test      r14b,r14b
       jne       short M02_L01
       mov       rcx,rsi
       call      System.IO.Path.GetFullPath(System.String)
       jmp       short M02_L02
M02_L01:
       mov       rax,rsi
M02_L02:
       mov       rsi,rax
       mov       rdx,rbp
       test      rdx,rdx
       jne       near ptr M02_L11
       test      rsi,rsi
       jne       short M02_L03
       xor       ecx,ecx
       xor       ebx,ebx
       jmp       short M02_L04
M02_L03:
       lea       rcx,[rsi+0C]
       mov       ebx,[rsi+8]
M02_L04:
       mov       eax,ebx
       lea       rdx,[rsp+20]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+20]
       call      System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,ebx
       je        short M02_L07
       test      rsi,rsi
       jne       short M02_L05
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M02_L06
M02_L05:
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
M02_L06:
       lea       rax,[rsp+30]
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rax
       lea       rdx,[rsp+20]
       call      System.IO.Path.TrimEndingDirectorySeparator(System.ReadOnlySpan`1<Char>)
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+20]
       mov       rax,[rsp+30]
       mov       [rdx],rax
       mov       eax,[rsp+38]
       mov       [rdx+8],eax
       lea       rdx,[rsp+20]
       call      System.IO.Path.GetFileName(System.ReadOnlySpan`1<Char>)
       jmp       short M02_L10
M02_L07:
       test      rsi,rsi
       jne       short M02_L08
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M02_L09
M02_L08:
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
M02_L09:
       mov       [rsp+40],rcx
       mov       [rsp+48],eax
M02_L10:
       mov       rcx,[rsp+40]
       mov       [rsp+50],rcx
       mov       ecx,[rsp+48]
       mov       [rsp+58],ecx
       lea       rcx,[rsp+50]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rdx,rax
M02_L11:
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+50],r14b
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L12:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,615
       mov       rdx,7FF88A902450
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 397
```
```assembly
; dotNetTips.Utility.Standard.IO.DirectoryHelper.SafeFileSearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.IO.FileSystem]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1D01DB38D48
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M03_L00
       lea       r8d,[rdx+1]
       mov       [rbp+10],r8d
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M03_L01
M03_L00:
       mov       rcx,rbp
       mov       rdx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L01:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       mov       rax,offset dotNetTips.Utility.Standard.IO.DirectoryHelper.SafeFileSearch(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>, System.String, System.IO.SearchOption)
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 131
```

