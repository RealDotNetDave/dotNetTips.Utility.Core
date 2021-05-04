## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Deserialize()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize(System.String)
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE0],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1A846D83060
       mov       r8,[r8]
       mov       rdx,1A856D8D6D0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      System.IO.StringReader..ctor(System.String)
       mov       [rbp+0FFD8],rbx
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rdi+10]
       mov       rcx,[rdi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+0FFD8]
       call      System.Xml.Serialization.XmlSerializer.Deserialize(System.IO.TextReader)
       mov       rdx,rax
       mov       rcx,[rdi]
       call      CORINFO_HELP_CHKCASTANY
       mov       rsi,rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+10],eax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+14],eax
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+10],eax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+14],eax
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 284
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Deserialize()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize(System.String)
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE0],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,21B2E4D3060
       mov       r8,[r8]
       mov       rdx,21B2E4E1B38
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      System.IO.StringReader..ctor(System.String)
       mov       [rbp+0FFD8],rbx
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rdi+10]
       mov       rcx,[rdi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+0FFD8]
       call      System.Xml.Serialization.XmlSerializer.Deserialize(System.IO.TextReader)
       mov       rdx,rax
       mov       rcx,[rdi]
       call      CORINFO_HELP_CHKCASTANY
       mov       rsi,rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+10],eax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+14],eax
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+10],eax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+14],eax
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 284
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Deserialize()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize(System.String)
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE0],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,261C8523060
       mov       r8,[r8]
       mov       rdx,261A8521720
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      System.IO.StringReader..ctor(System.String)
       mov       [rbp+0FFD8],rbx
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rdi+10]
       mov       rcx,[rdi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+0FFD8]
       call      System.Xml.Serialization.XmlSerializer.Deserialize(System.IO.TextReader)
       mov       rdx,rax
       mov       rcx,[rdi]
       call      CORINFO_HELP_CHKCASTANY
       mov       rsi,rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+10],eax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+14],eax
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+10],eax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+14],eax
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 284
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Deserialize()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize(System.String)
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE0],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,20858D93060
       mov       r8,[r8]
       mov       rdx,20868D91720
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      System.IO.StringReader..ctor(System.String)
       mov       [rbp+0FFD8],rbx
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rdi+10]
       mov       rcx,[rdi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+0FFD8]
       call      System.Xml.Serialization.XmlSerializer.Deserialize(System.IO.TextReader)
       mov       rdx,rax
       mov       rcx,[rdi]
       call      CORINFO_HELP_CHKCASTANY
       mov       rsi,rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+10],eax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+14],eax
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+10],eax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+14],eax
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 284
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Deserialize()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize(System.String)
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE0],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,20CC5623060
       mov       r8,[r8]
       mov       rdx,20CE562F6E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      System.IO.StringReader..ctor(System.String)
       mov       [rbp+0FFD8],rbx
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rdi+10]
       mov       rcx,[rdi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+0FFD8]
       call      System.Xml.Serialization.XmlSerializer.Deserialize(System.IO.TextReader)
       mov       rdx,rax
       mov       rcx,[rdi]
       call      CORINFO_HELP_CHKCASTANY
       mov       rsi,rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+10],eax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+14],eax
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+10],eax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+14],eax
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 284
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Deserialize()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize(System.String)
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE0],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1B174453060
       mov       r8,[r8]
       mov       rdx,1B174461B38
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      System.IO.StringReader..ctor(System.String)
       mov       [rbp+0FFD8],rbx
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rdi+10]
       mov       rcx,[rdi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+0FFD8]
       call      System.Xml.Serialization.XmlSerializer.Deserialize(System.IO.TextReader)
       mov       rdx,rax
       mov       rcx,[rdi]
       call      CORINFO_HELP_CHKCASTANY
       mov       rsi,rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+10],eax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+14],eax
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+10],eax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+14],eax
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 284
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Deserialize()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize(System.String)
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Utility.Standard.Xml.XmlHelper.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE0],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,2CBF2A23060
       mov       r8,[r8]
       mov       rdx,2CBF2A31B38
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      System.IO.StringReader..ctor(System.String)
       mov       [rbp+0FFD8],rbx
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rdi+10]
       mov       rcx,[rdi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+0FFD8]
       call      System.Xml.Serialization.XmlSerializer.Deserialize(System.IO.TextReader)
       mov       rdx,rax
       mov       rcx,[rdi]
       call      CORINFO_HELP_CHKCASTANY
       mov       rsi,rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+10],eax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+14],eax
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+10],eax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+14],eax
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 284
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Serialize()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+58]
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.Serialize(System.Object)
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
; dotNetTips.Utility.Standard.Xml.XmlHelper.Serialize(System.Object)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       mov       r9,1B358FC3060
       mov       r9,[r9]
       mov       r8,1B338FCD638
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.IO.StringWriter..ctor()
       mov       [rbp+0FFE8],rdi
       mov       rcx,offset MT_System.Xml.XmlWriterSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Xml.XmlWriterSettings..ctor()
       mov       rcx,rdi
       mov       rdx,[rbp+0FFE8]
       cmp       [rcx],ecx
       call      System.Xml.XmlWriterSettings.CreateWriter(System.IO.TextWriter)
       mov       [rbp+0FFE0],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      00007FF8EA182020
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,[rbp+0FFE0]
       mov       r8,rsi
       xor       r9d,r9d
       call      System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rbp+0FFE8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9D7010]
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A590790
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9E0790]
       nop
M01_L00:
       mov       rcx,[rbp+0FFE8]
       mov       byte ptr [rcx+28],0
       mov       rcx,[rbp+0FFE8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L01
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A590790
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9E0790]
M01_L01:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE8]
       mov       byte ptr [rcx+28],0
       mov       rcx,[rbp+0FFE8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L02:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 407
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Serialize()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+58]
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.Serialize(System.Object)
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
; dotNetTips.Utility.Standard.Xml.XmlHelper.Serialize(System.Object)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       mov       r9,1F837563060
       mov       r9,[r9]
       mov       r8,1F837563AD8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.IO.StringWriter..ctor()
       mov       [rbp+0FFE8],rdi
       mov       rcx,offset MT_System.Xml.XmlWriterSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Xml.XmlWriterSettings..ctor()
       mov       rcx,rdi
       mov       rdx,[rbp+0FFE8]
       cmp       [rcx],ecx
       call      System.Xml.XmlWriterSettings.CreateWriter(System.IO.TextWriter)
       mov       [rbp+0FFE0],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      00007FF8EA182020
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,[rbp+0FFE0]
       mov       r8,rsi
       xor       r9d,r9d
       call      System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rbp+0FFE8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9E7010]
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5A0758
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9F0758]
       nop
M01_L00:
       mov       rcx,[rbp+0FFE8]
       mov       byte ptr [rcx+28],0
       mov       rcx,[rbp+0FFE8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L01
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5A0758
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9F0758]
M01_L01:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE8]
       mov       byte ptr [rcx+28],0
       mov       rcx,[rbp+0FFE8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L02:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 407
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Serialize()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+58]
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.Serialize(System.Object)
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
; dotNetTips.Utility.Standard.Xml.XmlHelper.Serialize(System.Object)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       mov       r9,1E8126F3060
       mov       r9,[r9]
       mov       r8,1E8326F1688
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.IO.StringWriter..ctor()
       mov       [rbp+0FFE8],rdi
       mov       rcx,offset MT_System.Xml.XmlWriterSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Xml.XmlWriterSettings..ctor()
       mov       rcx,rdi
       mov       rdx,[rbp+0FFE8]
       cmp       [rcx],ecx
       call      System.Xml.XmlWriterSettings.CreateWriter(System.IO.TextWriter)
       mov       [rbp+0FFE0],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      00007FF8EA182020
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,[rbp+0FFE0]
       mov       r8,rsi
       xor       r9d,r9d
       call      System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rbp+0FFE8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9F7010]
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5B0758
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA00758]
       nop
M01_L00:
       mov       rcx,[rbp+0FFE8]
       mov       byte ptr [rcx+28],0
       mov       rcx,[rbp+0FFE8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L01
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5B0758
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA00758]
M01_L01:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE8]
       mov       byte ptr [rcx+28],0
       mov       rcx,[rbp+0FFE8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L02:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 407
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Serialize()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+58]
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.Serialize(System.Object)
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
; dotNetTips.Utility.Standard.Xml.XmlHelper.Serialize(System.Object)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       mov       r9,1A6B99B3060
       mov       r9,[r9]
       mov       r8,1A6A99B1688
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.IO.StringWriter..ctor()
       mov       [rbp+0FFE8],rdi
       mov       rcx,offset MT_System.Xml.XmlWriterSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Xml.XmlWriterSettings..ctor()
       mov       rcx,rdi
       mov       rdx,[rbp+0FFE8]
       cmp       [rcx],ecx
       call      System.Xml.XmlWriterSettings.CreateWriter(System.IO.TextWriter)
       mov       [rbp+0FFE0],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      00007FF8EA182020
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,[rbp+0FFE0]
       mov       r8,rsi
       xor       r9d,r9d
       call      System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rbp+0FFE8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA17010]
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5C0810
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA10810]
       nop
M01_L00:
       mov       rcx,[rbp+0FFE8]
       mov       byte ptr [rcx+28],0
       mov       rcx,[rbp+0FFE8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L01
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5C0810
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA10810]
M01_L01:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE8]
       mov       byte ptr [rcx+28],0
       mov       rcx,[rbp+0FFE8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L02:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 407
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Serialize()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+58]
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.Serialize(System.Object)
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
; dotNetTips.Utility.Standard.Xml.XmlHelper.Serialize(System.Object)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       mov       r9,28564B03060
       mov       r9,[r9]
       mov       r8,28564B03AD8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.IO.StringWriter..ctor()
       mov       [rbp+0FFE8],rdi
       mov       rcx,offset MT_System.Xml.XmlWriterSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Xml.XmlWriterSettings..ctor()
       mov       rcx,rdi
       mov       rdx,[rbp+0FFE8]
       cmp       [rcx],ecx
       call      System.Xml.XmlWriterSettings.CreateWriter(System.IO.TextWriter)
       mov       [rbp+0FFE0],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      00007FF8EA182020
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,[rbp+0FFE0]
       mov       r8,rsi
       xor       r9d,r9d
       call      System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rbp+0FFE8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA07010]
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5C0758
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA10758]
       nop
M01_L00:
       mov       rcx,[rbp+0FFE8]
       mov       byte ptr [rcx+28],0
       mov       rcx,[rbp+0FFE8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L01
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5C0758
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA10758]
M01_L01:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE8]
       mov       byte ptr [rcx+28],0
       mov       rcx,[rbp+0FFE8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L02:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 407
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Serialize()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+58]
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.Serialize(System.Object)
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
; dotNetTips.Utility.Standard.Xml.XmlHelper.Serialize(System.Object)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       mov       r9,1DED13A3060
       mov       r9,[r9]
       mov       r8,1DEF13AD638
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.IO.StringWriter..ctor()
       mov       [rbp+0FFE8],rdi
       mov       rcx,offset MT_System.Xml.XmlWriterSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Xml.XmlWriterSettings..ctor()
       mov       rcx,rdi
       mov       rdx,[rbp+0FFE8]
       cmp       [rcx],ecx
       call      System.Xml.XmlWriterSettings.CreateWriter(System.IO.TextWriter)
       mov       [rbp+0FFE0],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      00007FF8EA182020
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,[rbp+0FFE0]
       mov       r8,rsi
       xor       r9d,r9d
       call      System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rbp+0FFE8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA07010]
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5B07F8
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA007F8]
       nop
M01_L00:
       mov       rcx,[rbp+0FFE8]
       mov       byte ptr [rcx+28],0
       mov       rcx,[rbp+0FFE8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L01
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5B07F8
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA007F8]
M01_L01:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE8]
       mov       byte ptr [rcx+28],0
       mov       rcx,[rbp+0FFE8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L02:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 407
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Serialize()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+58]
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.Serialize(System.Object)
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
; dotNetTips.Utility.Standard.Xml.XmlHelper.Serialize(System.Object)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       mov       r9,12FA8771048
       mov       r9,[r9]
       mov       r8,12FB877F650
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.IO.StringWriter..ctor()
       mov       [rbp+0FFE8],rdi
       mov       rcx,offset MT_System.Xml.XmlWriterSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Xml.XmlWriterSettings..ctor()
       mov       rcx,rdi
       mov       rdx,[rbp+0FFE8]
       cmp       [rcx],ecx
       call      System.Xml.XmlWriterSettings.CreateWriter(System.IO.TextWriter)
       mov       [rbp+0FFE0],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      00007FF8EA182020
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,[rbp+0FFE0]
       mov       r8,rsi
       xor       r9d,r9d
       call      System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rbp+0FFE8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA17010]
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5C0788
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA10788]
       nop
M01_L00:
       mov       rcx,[rbp+0FFE8]
       mov       byte ptr [rcx+28],0
       mov       rcx,[rbp+0FFE8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L01
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5C0788
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA10788]
M01_L01:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE8]
       mov       byte ptr [rcx+28],0
       mov       rcx,[rbp+0FFE8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L02:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 407
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.StringToXDocument()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_XmlPersonTestData()
       mov       rcx,rax
       xor       edx,edx
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.StringToXDocument(System.String, System.Xml.XmlResolver)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 48
```
```assembly
; dotNetTips.Utility.Benchmarks.Properties.Resources.get_XmlPersonTestData()
       sub       rsp,28
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,2AFB5E03E18
       mov       rdx,[rdx]
       mov       r8,2AFD5E08F40
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; dotNetTips.Utility.Standard.Xml.XmlHelper.StringToXDocument(System.String, System.Xml.XmlResolver)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2AFB5E03060
       mov       r8,[r8]
       mov       rdx,2AFD5E0F138
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Xml.XmlReaderSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       xor       edx,edx
       call      System.Xml.XmlReaderSettings.Initialize(System.Xml.XmlResolver)
       mov       rcx,rbx
       xor       edx,edx
       call      System.Xml.XmlReaderSettings.set_DtdProcessing(System.Xml.DtdProcessing)
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Xml.XmlReaderSettings.set_XmlResolver(System.Xml.XmlResolver)
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.IO.StringReader..ctor(System.String)
       mov       rcx,rbx
       mov       rdx,2AFB5E03060
       mov       r8,[rdx]
       mov       rdx,rdi
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      System.Xml.XmlReaderSettings.CreateReader(System.IO.TextReader, System.String, System.Xml.XmlParserContext)
       mov       [rbp+0FFE0],rax
       mov       rcx,[rbp+0FFE0]
       xor       edx,edx
       call      System.Xml.Linq.XDocument.Load(System.Xml.XmlReader, System.Xml.Linq.LoadOptions)
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A590740
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9D0740]
M02_L00:
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L01
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A590740
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9D0740]
M02_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 283
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.StringToXDocument()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_XmlPersonTestData()
       mov       rcx,rax
       xor       edx,edx
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.StringToXDocument(System.String, System.Xml.XmlResolver)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 48
```
```assembly
; dotNetTips.Utility.Benchmarks.Properties.Resources.get_XmlPersonTestData()
       sub       rsp,28
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,1DD72C23650
       mov       rdx,[rdx]
       mov       r8,1DD72C1B390
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; dotNetTips.Utility.Standard.Xml.XmlHelper.StringToXDocument(System.String, System.Xml.XmlResolver)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1DD72C13060
       mov       r8,[r8]
       mov       rdx,1DD72C21588
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Xml.XmlReaderSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       xor       edx,edx
       call      System.Xml.XmlReaderSettings.Initialize(System.Xml.XmlResolver)
       mov       rcx,rbx
       xor       edx,edx
       call      System.Xml.XmlReaderSettings.set_DtdProcessing(System.Xml.DtdProcessing)
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Xml.XmlReaderSettings.set_XmlResolver(System.Xml.XmlResolver)
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.IO.StringReader..ctor(System.String)
       mov       rcx,rbx
       mov       rdx,1DD72C13060
       mov       r8,[rdx]
       mov       rdx,rdi
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      System.Xml.XmlReaderSettings.CreateReader(System.IO.TextReader, System.String, System.Xml.XmlParserContext)
       mov       [rbp+0FFE0],rax
       mov       rcx,[rbp+0FFE0]
       xor       edx,edx
       call      System.Xml.Linq.XDocument.Load(System.Xml.XmlReader, System.Xml.Linq.LoadOptions)
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5B0758
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9F0758]
M02_L00:
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L01
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5B0758
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9F0758]
M02_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 283
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.StringToXDocument()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_XmlPersonTestData()
       mov       rcx,rax
       xor       edx,edx
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.StringToXDocument(System.String, System.Xml.XmlResolver)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 48
```
```assembly
; dotNetTips.Utility.Benchmarks.Properties.Resources.get_XmlPersonTestData()
       sub       rsp,28
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,1E554622A00
       mov       rdx,[rdx]
       mov       r8,1E57462B390
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; dotNetTips.Utility.Standard.Xml.XmlHelper.StringToXDocument(System.String, System.Xml.XmlResolver)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1E574623060
       mov       r8,[r8]
       mov       rdx,1E574631588
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Xml.XmlReaderSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       xor       edx,edx
       call      System.Xml.XmlReaderSettings.Initialize(System.Xml.XmlResolver)
       mov       rcx,rbx
       xor       edx,edx
       call      System.Xml.XmlReaderSettings.set_DtdProcessing(System.Xml.DtdProcessing)
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Xml.XmlReaderSettings.set_XmlResolver(System.Xml.XmlResolver)
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.IO.StringReader..ctor(System.String)
       mov       rcx,rbx
       mov       rdx,1E574623060
       mov       r8,[rdx]
       mov       rdx,rdi
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      System.Xml.XmlReaderSettings.CreateReader(System.IO.TextReader, System.String, System.Xml.XmlParserContext)
       mov       [rbp+0FFE0],rax
       mov       rcx,[rbp+0FFE0]
       xor       edx,edx
       call      System.Xml.Linq.XDocument.Load(System.Xml.XmlReader, System.Xml.Linq.LoadOptions)
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A590740
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9D0740]
M02_L00:
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L01
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A590740
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9D0740]
M02_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 283
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.StringToXDocument()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_XmlPersonTestData()
       mov       rcx,rax
       xor       edx,edx
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.StringToXDocument(System.String, System.Xml.XmlResolver)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 48
```
```assembly
; dotNetTips.Utility.Benchmarks.Properties.Resources.get_XmlPersonTestData()
       sub       rsp,28
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,222580819C8
       mov       rdx,[rdx]
       mov       r8,22268086F28
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; dotNetTips.Utility.Standard.Xml.XmlHelper.StringToXDocument(System.String, System.Xml.XmlResolver)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,22248083060
       mov       r8,[r8]
       mov       rdx,2226808D120
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Xml.XmlReaderSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       xor       edx,edx
       call      System.Xml.XmlReaderSettings.Initialize(System.Xml.XmlResolver)
       mov       rcx,rbx
       xor       edx,edx
       call      System.Xml.XmlReaderSettings.set_DtdProcessing(System.Xml.DtdProcessing)
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Xml.XmlReaderSettings.set_XmlResolver(System.Xml.XmlResolver)
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.IO.StringReader..ctor(System.String)
       mov       rcx,rbx
       mov       rdx,22248083060
       mov       r8,[rdx]
       mov       rdx,rdi
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      System.Xml.XmlReaderSettings.CreateReader(System.IO.TextReader, System.String, System.Xml.XmlParserContext)
       mov       [rbp+0FFE0],rax
       mov       rcx,[rbp+0FFE0]
       xor       edx,edx
       call      System.Xml.Linq.XDocument.Load(System.Xml.XmlReader, System.Xml.Linq.LoadOptions)
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5A0740
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9E0740]
M02_L00:
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L01
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5A0740
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9E0740]
M02_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 283
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.StringToXDocument()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_XmlPersonTestData()
       mov       rcx,rax
       xor       edx,edx
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.StringToXDocument(System.String, System.Xml.XmlResolver)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 48
```
```assembly
; dotNetTips.Utility.Benchmarks.Properties.Resources.get_XmlPersonTestData()
       sub       rsp,28
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,21A1B21E1B0
       mov       rdx,[rdx]
       mov       r8,21A1B216F28
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; dotNetTips.Utility.Standard.Xml.XmlHelper.StringToXDocument(System.String, System.Xml.XmlResolver)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,21A3B213060
       mov       r8,[r8]
       mov       rdx,21A1B21D120
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Xml.XmlReaderSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       xor       edx,edx
       call      System.Xml.XmlReaderSettings.Initialize(System.Xml.XmlResolver)
       mov       rcx,rbx
       xor       edx,edx
       call      System.Xml.XmlReaderSettings.set_DtdProcessing(System.Xml.DtdProcessing)
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Xml.XmlReaderSettings.set_XmlResolver(System.Xml.XmlResolver)
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.IO.StringReader..ctor(System.String)
       mov       rcx,rbx
       mov       rdx,21A3B213060
       mov       r8,[rdx]
       mov       rdx,rdi
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      System.Xml.XmlReaderSettings.CreateReader(System.IO.TextReader, System.String, System.Xml.XmlParserContext)
       mov       [rbp+0FFE0],rax
       mov       rcx,[rbp+0FFE0]
       xor       edx,edx
       call      System.Xml.Linq.XDocument.Load(System.Xml.XmlReader, System.Xml.Linq.LoadOptions)
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A590758
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9E0758]
M02_L00:
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L01
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A590758
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9E0758]
M02_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 283
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.StringToXDocument()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_XmlPersonTestData()
       mov       rcx,rax
       xor       edx,edx
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.StringToXDocument(System.String, System.Xml.XmlResolver)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 48
```
```assembly
; dotNetTips.Utility.Benchmarks.Properties.Resources.get_XmlPersonTestData()
       sub       rsp,28
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,140B37B2A00
       mov       rdx,[rdx]
       mov       r8,140C37B6F28
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; dotNetTips.Utility.Standard.Xml.XmlHelper.StringToXDocument(System.String, System.Xml.XmlResolver)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,140A37B3060
       mov       r8,[r8]
       mov       rdx,140C37BD120
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Xml.XmlReaderSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       xor       edx,edx
       call      System.Xml.XmlReaderSettings.Initialize(System.Xml.XmlResolver)
       mov       rcx,rbx
       xor       edx,edx
       call      System.Xml.XmlReaderSettings.set_DtdProcessing(System.Xml.DtdProcessing)
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Xml.XmlReaderSettings.set_XmlResolver(System.Xml.XmlResolver)
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.IO.StringReader..ctor(System.String)
       mov       rcx,rbx
       mov       rdx,140A37B3060
       mov       r8,[rdx]
       mov       rdx,rdi
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      System.Xml.XmlReaderSettings.CreateReader(System.IO.TextReader, System.String, System.Xml.XmlParserContext)
       mov       [rbp+0FFE0],rax
       mov       rcx,[rbp+0FFE0]
       xor       edx,edx
       call      System.Xml.Linq.XDocument.Load(System.Xml.XmlReader, System.Xml.Linq.LoadOptions)
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5C0740
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA00740]
M02_L00:
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L01
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5C0740
       cmp       [rcx],ecx
       call      qword ptr [7FF88AA00740]
M02_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 283
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.StringToXDocument()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_XmlPersonTestData()
       mov       rcx,rax
       xor       edx,edx
       call      dotNetTips.Utility.Standard.Xml.XmlHelper.StringToXDocument(System.String, System.Xml.XmlResolver)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 48
```
```assembly
; dotNetTips.Utility.Benchmarks.Properties.Resources.get_XmlPersonTestData()
       sub       rsp,28
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,21A6E59FA38
       mov       rdx,[rdx]
       mov       r8,21A5E52B390
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; dotNetTips.Utility.Standard.Xml.XmlHelper.StringToXDocument(System.String, System.Xml.XmlResolver)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,21A5E523060
       mov       r8,[r8]
       mov       rdx,21A5E531588
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Xml.XmlReaderSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       xor       edx,edx
       call      System.Xml.XmlReaderSettings.Initialize(System.Xml.XmlResolver)
       mov       rcx,rbx
       xor       edx,edx
       call      System.Xml.XmlReaderSettings.set_DtdProcessing(System.Xml.DtdProcessing)
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Xml.XmlReaderSettings.set_XmlResolver(System.Xml.XmlResolver)
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.IO.StringReader..ctor(System.String)
       mov       rcx,rbx
       mov       rdx,21A5E523060
       mov       r8,[rdx]
       mov       rdx,rdi
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      System.Xml.XmlReaderSettings.CreateReader(System.IO.TextReader, System.String, System.Xml.XmlParserContext)
       mov       [rbp+0FFE0],rax
       mov       rcx,[rbp+0FFE0]
       xor       edx,edx
       call      System.Xml.Linq.XDocument.Load(System.Xml.XmlReader, System.Xml.Linq.LoadOptions)
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5B0740
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9F0740]
M02_L00:
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L01
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FF88A5B0740
       cmp       [rcx],ecx
       call      qword ptr [7FF88A9F0740]
M02_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 283
```

