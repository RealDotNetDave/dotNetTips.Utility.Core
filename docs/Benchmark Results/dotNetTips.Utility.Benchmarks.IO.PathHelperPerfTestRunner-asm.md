## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.PathHelperPerfTestRunner.EnsureTrailingSlashTest()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      System.Environment.get_CurrentDirectoryCore()
       mov       rcx,rax
       call      dotNetTips.Utility.Standard.IO.PathHelper.EnsureTrailingSlash(System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 46
```
```assembly
; System.Environment.get_CurrentDirectoryCore()
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+8],rax
       mov       [rbp+18],rax
       mov       rax,92EBA18DA487
       mov       [rbp],rax
       add       rsp,20
       test      esp,[rsp]
       sub       rsp,210
       sub       rsp,20
       lea       rcx,[rsp+20]
       xor       edx,edx
       mov       [rbp+8],rdx
       lea       rdx,[rbp+18]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],104
       xor       ecx,ecx
       mov       [rbp+10],ecx
       jmp       short M01_L01
M01_L00:
       cmp       edx,[rbp+20]
       jle       short M01_L01
       sub       edx,[rbp+10]
       lea       rcx,[rbp+8]
       call      System.Text.ValueStringBuilder.Grow(Int32)
M01_L01:
       mov       ecx,[rbp+20]
       lea       rdx,[rbp+18]
       mov       rdx,[rdx]
       call      Interop+Kernel32.GetCurrentDirectory(UInt32, Char ByRef)
       mov       edx,eax
       mov       ecx,edx
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       rcx,rax
       jg        short M01_L00
       test      edx,edx
       je        short M01_L05
       mov       [rbp+10],edx
       mov       r8d,[rbp+10]
       mov       ecx,r8d
       mov       edx,[rbp+20]
       cmp       rcx,rdx
       ja        near ptr M01_L06
       mov       rcx,[rbp+18]
       mov       edx,7E
       call      System.SpanHelpers.Contains(Char ByRef, Char, Int32)
       test      eax,eax
       jne       short M01_L03
       lea       rcx,[rbp+8]
       call      System.Text.ValueStringBuilder.ToString()
       mov       rcx,92EBA18DA487
       cmp       [rbp],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rsi
       pop       rbp
       ret
M01_L03:
       lea       rcx,[rbp+8]
       xor       edx,edx
       call      System.IO.PathHelper.TryExpandShortFileName(System.Text.ValueStringBuilder ByRef, System.String)
       mov       rcx,92EBA18DA487
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+28]
       pop       rsi
       pop       rbp
       ret
M01_L05:
       call      00007FF8EA1BD940
       mov       esi,eax
       mov       ecx,2EB
       mov       rdx,7FF88A5B4020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      System.IO.Win32Marshal.GetExceptionForWin32Error(Int32, System.String)
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L06:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 305
```
```assembly
; dotNetTips.Utility.Standard.IO.PathHelper.EnsureTrailingSlash(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       r8,201C83B3060
       mov       r8,[r8]
       mov       rdx,201E83BD738
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       eax,[rsi+8]
       lea       ecx,[rax+0FFFF]
       cmp       ecx,eax
       jae       short M02_L01
       movsxd    rax,ecx
       cmp       word ptr [rsi+rax*2+0C],5C
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
M02_L00:
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       rdx,rax
       mov       word ptr [rdx+0C],5C
       mov       rcx,rsi
       call      System.String.Concat(System.String, System.String)
       nop
       add       rsp,20
       pop       rsi
       ret
M02_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 112
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.PathHelperPerfTestRunner.HasInvalidFilterChars()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,0F
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rcx,rax
       call      dotNetTips.Utility.Standard.IO.PathHelper.HasInvalidFilterChars(System.String)
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 39
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
; 			Encapsulation.TryValidateParam(length, minimumValue: 1, paramName: nameof(length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var returnValue = GenerateWord(length, DefaultMinCharacter, DefaultMaxCharacter);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return returnValue;
; 			^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rdx,18CB62E3060
       mov       rsi,[rdx]
       test      ecx,ecx
       jle       short M01_L00
       cmp       ecx,7FFFFFFF
       setle     dl
       movzx     edx,dl
       test      edx,edx
       je        short M01_L00
       mov       edx,41
       mov       r8d,7A
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32, Char, Char)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       jne       short M01_L01
       call      dotNetTips.Utility.Standard.Properties.Resources.get_NumberNotInRange()
       mov       rsi,rax
M01_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,6B
       mov       rdx,7FF88A98F440
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 137
```
```assembly
; dotNetTips.Utility.Standard.IO.PathHelper.HasInvalidFilterChars(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       r8,18CB62E3060
       mov       r8,[r8]
       mov       rdx,18CB62F1C38
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       call      dotNetTips.Utility.Standard.IO.PathHelper.get_InvalidFilterChars()
       mov       rdx,rax
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
; Total bytes of code 83
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.PathHelperPerfTestRunner.PathContainsWildcardTest()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      System.Environment.get_CurrentDirectoryCore()
       mov       rcx,rax
       call      dotNetTips.Utility.Standard.IO.PathHelper.PathContainsWildcard(System.String)
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; System.Environment.get_CurrentDirectoryCore()
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+8],rax
       mov       [rbp+18],rax
       mov       rax,0DE35DAF70DEC
       mov       [rbp],rax
       add       rsp,20
       test      esp,[rsp]
       sub       rsp,210
       sub       rsp,20
       lea       rcx,[rsp+20]
       xor       edx,edx
       mov       [rbp+8],rdx
       lea       rdx,[rbp+18]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],104
       xor       ecx,ecx
       mov       [rbp+10],ecx
       jmp       short M01_L01
M01_L00:
       cmp       edx,[rbp+20]
       jle       short M01_L01
       sub       edx,[rbp+10]
       lea       rcx,[rbp+8]
       call      System.Text.ValueStringBuilder.Grow(Int32)
M01_L01:
       mov       ecx,[rbp+20]
       lea       rdx,[rbp+18]
       mov       rdx,[rdx]
       call      Interop+Kernel32.GetCurrentDirectory(UInt32, Char ByRef)
       mov       edx,eax
       mov       ecx,edx
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       rcx,rax
       jg        short M01_L00
       test      edx,edx
       je        short M01_L05
       mov       [rbp+10],edx
       mov       r8d,[rbp+10]
       mov       ecx,r8d
       mov       edx,[rbp+20]
       cmp       rcx,rdx
       ja        near ptr M01_L06
       mov       rcx,[rbp+18]
       mov       edx,7E
       call      System.SpanHelpers.Contains(Char ByRef, Char, Int32)
       test      eax,eax
       jne       short M01_L03
       lea       rcx,[rbp+8]
       call      System.Text.ValueStringBuilder.ToString()
       mov       rcx,0DE35DAF70DEC
       cmp       [rbp],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rsi
       pop       rbp
       ret
M01_L03:
       lea       rcx,[rbp+8]
       xor       edx,edx
       call      System.IO.PathHelper.TryExpandShortFileName(System.Text.ValueStringBuilder ByRef, System.String)
       mov       rcx,0DE35DAF70DEC
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+28]
       pop       rsi
       pop       rbp
       ret
M01_L05:
       call      00007FF8EA1BD940
       mov       esi,eax
       mov       ecx,2EB
       mov       rdx,7FF88A594020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      System.IO.Win32Marshal.GetExceptionForWin32Error(Int32, System.String)
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L06:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 305
```
```assembly
; dotNetTips.Utility.Standard.IO.PathHelper.PathContainsWildcard(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       r8,16B72623060
       mov       r8,[r8]
       mov       rdx,16B9262D738
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       test      rsi,rsi
       je        short M02_L00
       lea       rcx,[rsi+0C]
       mov       r8d,[rsi+8]
       mov       edx,2A
       call      System.SpanHelpers.IndexOf(Char ByRef, Char, Int32)
       cmp       eax,0FFFFFFFF
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M02_L00
       lea       rcx,[rsi+0C]
       mov       r8d,[rsi+8]
       mov       edx,3F
       call      System.SpanHelpers.IndexOf(Char ByRef, Char, Int32)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,20
       pop       rsi
       ret
M02_L00:
       mov       eax,1
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 122
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.IO.PathHelperPerfTestRunner.PathHasInvalidCharsTest()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      System.Environment.get_CurrentDirectoryCore()
       mov       rcx,rax
       call      dotNetTips.Utility.Standard.IO.PathHelper.PathHasInvalidChars(System.String)
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 34
```
```assembly
; System.Environment.get_CurrentDirectoryCore()
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+8],rax
       mov       [rbp+18],rax
       mov       rax,82E00DBD7EF4
       mov       [rbp],rax
       add       rsp,20
       test      esp,[rsp]
       sub       rsp,210
       sub       rsp,20
       lea       rcx,[rsp+20]
       xor       edx,edx
       mov       [rbp+8],rdx
       lea       rdx,[rbp+18]
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],104
       xor       ecx,ecx
       mov       [rbp+10],ecx
       jmp       short M01_L01
M01_L00:
       cmp       edx,[rbp+20]
       jle       short M01_L01
       sub       edx,[rbp+10]
       lea       rcx,[rbp+8]
       call      System.Text.ValueStringBuilder.Grow(Int32)
M01_L01:
       mov       ecx,[rbp+20]
       lea       rdx,[rbp+18]
       mov       rdx,[rdx]
       call      Interop+Kernel32.GetCurrentDirectory(UInt32, Char ByRef)
       mov       edx,eax
       mov       ecx,edx
       mov       eax,[rbp+20]
       movsxd    rax,eax
       cmp       rcx,rax
       jg        short M01_L00
       test      edx,edx
       je        short M01_L05
       mov       [rbp+10],edx
       mov       r8d,[rbp+10]
       mov       ecx,r8d
       mov       edx,[rbp+20]
       cmp       rcx,rdx
       ja        near ptr M01_L06
       mov       rcx,[rbp+18]
       mov       edx,7E
       call      System.SpanHelpers.Contains(Char ByRef, Char, Int32)
       test      eax,eax
       jne       short M01_L03
       lea       rcx,[rbp+8]
       call      System.Text.ValueStringBuilder.ToString()
       mov       rcx,82E00DBD7EF4
       cmp       [rbp],rcx
       je        short M01_L02
       call      CORINFO_HELP_FAIL_FAST
M01_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rsi
       pop       rbp
       ret
M01_L03:
       lea       rcx,[rbp+8]
       xor       edx,edx
       call      System.IO.PathHelper.TryExpandShortFileName(System.Text.ValueStringBuilder ByRef, System.String)
       mov       rcx,82E00DBD7EF4
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+28]
       pop       rsi
       pop       rbp
       ret
M01_L05:
       call      00007FF8EA1BD940
       mov       esi,eax
       mov       ecx,2EB
       mov       rdx,7FF88A594020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      System.IO.Win32Marshal.GetExceptionForWin32Error(Int32, System.String)
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L06:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 305
```
```assembly
; dotNetTips.Utility.Standard.IO.PathHelper.PathHasInvalidChars(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       r8,2607B833060
       mov       r8,[r8]
       mov       rdx,2607B833BD8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       call      dotNetTips.Utility.Standard.IO.PathHelper.get_InvalidPathNameChars()
       mov       rdx,rax
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
; Total bytes of code 83
```

