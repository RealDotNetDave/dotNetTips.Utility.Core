## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.ObjectExtensionsPerfTestRunner.As()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Extensions.ObjectExtensions.As(System.Object)
       call      dotNetTips.Utility.Standard.Extensions.ObjectExtensions.As[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 52
```
```assembly
; dotNetTips.Utility.Standard.Extensions.ObjectExtensions.As[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rsi
       sub       rsp,30
       mov       [rsp+28],rcx
       test      rdx,rdx
       je        short M01_L00
       mov       rcx,[rcx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_CHKCASTANY
       nop
       add       rsp,30
       pop       rsi
       ret
M01_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0BF
       mov       rdx,7FF88A9712D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 92
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.ObjectExtensionsPerfTestRunner.Clone()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Utility.Standard.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 52
```
```assembly
; dotNetTips.Utility.Standard.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L01
       mov       rcx,rdx
       call      dotNetTips.Utility.Standard.Extensions.JsonSerializer.Serialize(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M01_L00
       mov       rcx,rsi
       mov       rdx,7FF88AB1E468
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L00:
       mov       rdx,rdi
       mov       rax,offset dotNetTips.Utility.Standard.Extensions.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M01_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0B27
       mov       rdx,7FF88A9812D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 144
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.ObjectExtensionsPerfTestRunner.ComputeSha256Hash()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       call      dotNetTips.Utility.Standard.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Utility.Standard.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFD8],rax
       mov       [rbp+0FFC0],rsp
       mov       rsi,rcx
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFC8],rdi
       mov       rcx,2489C241820
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA33A68]
       mov       rdx,rax
       mov       rcx,[rbp+0FFC8]
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rsi,rax
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rdx,2489C242448
       mov       r8,[rdx]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,248AC241608
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M01_L01
       xor       eax,eax
       xor       r9d,r9d
       jmp       short M01_L02
M01_L01:
       mov       eax,[rdx]
       mov       rax,rdx
       cmp       [rax],eax
       add       rax,0C
       mov       r9d,[rdx+8]
M01_L02:
       lea       rdx,[rbp+0FFD0]
       mov       [rdx],rax
       mov       [rdx+8],r9d
       lea       rdx,[rbp+0FFD0]
       call      System.Number.FormatUInt32(UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       r14d,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       call      qword ptr [7FF88AA37010]
       mov       rsi,rax
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [7FF88AA2F708]
       mov       rax,rsi
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
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L04
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [7FF88AA2F708]
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 370
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.ObjectExtensionsPerfTestRunner.DisposeFields()
       push      rsi
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rdx,1A779891608
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Data.DataTable..ctor(System.String)
       mov       rcx,rsi
       mov       rax,offset dotNetTips.Utility.Standard.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 65
```
```assembly
; System.Data.DataTable..ctor(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      System.Data.DataTable..ctor()
       test      rdi,rdi
       je        short M01_L00
       mov       rdx,rdi
       jmp       short M01_L01
M01_L00:
       mov       rdx,1A769893060
       mov       rdx,[rdx]
M01_L01:
       lea       rcx,[rsi+70]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 60
```
```assembly
; dotNetTips.Utility.Standard.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       je        near ptr M02_L05
       mov       rcx,rsi
       call      00007FF8EA182020
       mov       rcx,rax
       call      System.Reflection.RuntimeReflectionExtensions.GetRuntimeFields(System.Type)
       mov       rdi,rax
       mov       rcx,7FF88A971C68
       mov       edx,4A
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A7898978F0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M02_L00
       mov       rcx,offset MT_System.Func`2[[System.Reflection.FieldInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1A7898978E8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M02_L06
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Standard.Extensions.ObjectExtensions+<>c.<DisposeFields>b__5_0(System.Reflection.FieldInfo)
       mov       [rbx+18],rdx
       mov       rcx,1A7898978F0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M02_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Where(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       xor       edi,edi
       cmp       dword ptr [rbx+10],0
       jle       short M02_L04
M02_L01:
       cmp       edi,[rbx+10]
       jae       near ptr M02_L07
       mov       rcx,[rbx+8]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L08
       movsxd    rdx,edi
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rbp,rax
       test      rbp,rbp
       je        short M02_L03
       mov       rdx,rbp
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L02
       mov       rcx,rax
       xor       edx,edx
       call      dotNetTips.Utility.Standard.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       jmp       short M02_L03
M02_L02:
       mov       rdx,rbp
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L03
       mov       rcx,rax
       call      dotNetTips.Utility.Standard.Extensions.CollectionExtensions.ProcessCollectionToDispose(System.Collections.IEnumerable)
M02_L03:
       inc       edi
       cmp       edi,[rbx+10]
       jl        short M02_L01
M02_L04:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0B27
       mov       rdx,7FF88A9712D8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B2F
       mov       rdx,7FF88A9712D8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L06:
       mov       rcx,rbx
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M02_L07:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M02_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 444
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.ObjectExtensionsPerfTestRunner.FromJson()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+28]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Extensions.JsonSerializer.Deserialize(System.String)
       call      dotNetTips.Utility.Standard.Extensions.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 52
```
```assembly
; dotNetTips.Utility.Standard.Extensions.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+90]
       mov       [rbp+0FFC0],rsp
       mov       [rbp+0FFD8],rcx
       mov       rsi,rdx
       mov       rdi,[rcx+10]
       mov       rax,[rdi+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FF88AAFE510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L00:
       mov       rcx,rax
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbx,rax
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,2476B561820
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      qword ptr [7FF88AA33A68]
       mov       rdx,rax
       mov       rcx,r14
       mov       r8d,1
       call      System.IO.MemoryStream..ctor(Byte[], Boolean)
       mov       [rbp+0FFD0],r14
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbx
       call      00007FF8EA182020
       mov       rbx,rax
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializerImpl
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [rsp+20],7FFFFFFF
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],ecx
       mov       [rsp+38],ecx
       xor       ecx,ecx
       mov       [rsp+40],rcx
       xor       ecx,ecx
       mov       [rsp+48],ecx
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.Runtime.Serialization.Json.DataContractJsonSerializerImpl.Initialize(System.Type, System.Xml.XmlDictionaryString, System.Collections.Generic.IEnumerable`1<System.Type>, Int32, Boolean, System.Runtime.Serialization.EmitTypeInformation, Boolean, System.Runtime.Serialization.DateTimeFormat, Boolean)
       lea       rcx,[rsi+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+28]
       mov       rdx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA3A2D0]
       mov       rdx,rax
       mov       rsi,[rdi]
       mov       rcx,rsi
       call      CORINFO_HELP_ISINSTANCEOFANY
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHKCASTANY
       mov       rbx,rax
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88AA36AE0]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rbx
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
       sub       rsp,60
       mov       rbp,[rcx+50]
       mov       [rsp+50],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L01
       mov       rcx,[rbp+0FFD0]
       mov       edx,1
       call      qword ptr [7FF88AA36AE0]
       mov       rcx,[rbp+0FFD0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L01:
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 391
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.ObjectExtensionsPerfTestRunner.HasProperty()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       mov       rdx,24779D4FE08
       mov       rdx,[rdx]
       call      dotNetTips.Utility.Standard.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Utility.Standard.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Extensions.ObjectExtensions+<>c__DisplayClass8_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M01_L02
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      00007FF8EA182020
       mov       rcx,rax
       call      System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(System.Type)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset dotNetTips.Utility.Standard.Extensions.ObjectExtensions+<>c__DisplayClass8_0.<HasProperty>b__0(System.Reflection.PropertyInfo)
       mov       [rdi+18],r9
       lea       r9,[rsp+28]
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       test      rax,rax
       je        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0B27
       mov       rdx,7FF88A9712D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 232
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.ObjectExtensionsPerfTestRunner.IsNotNull()
       mov       rax,[rcx+30]
       test      rax,rax
       setne     al
       movzx     eax,al
       mov       rdx,[rcx+8]
       mov       [rdx+44],al
       ret
; Total bytes of code 21
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.ObjectExtensionsPerfTestRunner.IsNull()
       mov       rax,[rcx+30]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+8]
       mov       [rdx+44],al
       ret
; Total bytes of code 21
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.ObjectExtensionsPerfTestRunner.StripNull()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       test      rcx,rcx
       je        short M00_L00
       call      qword ptr [7FF88AA306B8]
       jmp       short M00_L01
M00_L00:
       mov       rax,1864C103060
       mov       rax,[rax]
M00_L01:
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; dotNetTips.Utility.Standard.Tester.Models.PersonProper.ToString()
;         public override string ToString() => this.Id.ToString(CultureInfo.CurrentCulture);
;                                              ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+48]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       eax,[rsi]
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.ObjectExtensionsPerfTestRunner.ToJson()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       call      dotNetTips.Utility.Standard.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Utility.Standard.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       jne       short M01_L00
       mov       rcx,1F7BE431630
       mov       rcx,[rcx]
       call      dotNetTips.Utility.Standard.Common.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rsi
       mov       rax,offset dotNetTips.Utility.Standard.Extensions.JsonSerializer.Serialize(System.Object)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 52
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Extensions.ObjectExtensionsPerfTestRunner.TryDispose()
       push      rsi
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rdx,24C0D9A1608
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Data.DataTable..ctor(System.String)
       mov       rcx,rsi
       xor       edx,edx
       mov       rax,offset dotNetTips.Utility.Standard.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 67
```
```assembly
; System.Data.DataTable..ctor(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      System.Data.DataTable..ctor()
       test      rdi,rdi
       je        short M01_L00
       mov       rdx,rdi
       jmp       short M01_L01
M01_L00:
       mov       rdx,24BFD9A3060
       mov       rdx,[rdx]
M01_L01:
       lea       rcx,[rsi+70]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 60
```
```assembly
; dotNetTips.Utility.Standard.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFE0],rsp
       mov       [rbp+18],edx
       mov       rsi,rcx
       test      rsi,rsi
       je        short M02_L02
       mov       rdx,rsi
       mov       rcx,offset MT_System.IAsyncDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L00
       lea       rdx,[rbp+0FFE8]
       mov       rcx,rax
       mov       r11,7FF88A5C0558
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA60558]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       r11,7FF88A5C0550
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA60550]
       nop
M02_L01:
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0B27
       mov       rdx,7FF88A9912D8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       cmp       byte ptr [rbp+18],0
       je        short M02_L03
       call      CORINFO_HELP_RETHROW
M02_L03:
       lea       rax,[7FF88AA6126C]
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 217
```

