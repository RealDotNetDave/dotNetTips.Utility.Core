## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Deserialize()
;             var result = XmlHelper.Deserialize<PersonCollection<PersonProper>>(this._xml);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;             Encapsulation.TryValidateParam(xml, nameof(xml));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var sr = new StringReader(xml))
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 var xs = new XmlSerializer(typeof(TResult));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return (TResult)xs.Deserialize(sr);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
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
       mov       r8,1C712013060
       mov       r8,[r8]
       mov       rdx,1C702011720
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Deserialize()
;             var result = XmlHelper.Deserialize<PersonCollection<PersonProper>>(this._xml);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;             Encapsulation.TryValidateParam(xml, nameof(xml));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var sr = new StringReader(xml))
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 var xs = new XmlSerializer(typeof(TResult));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return (TResult)xs.Deserialize(sr);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
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
       mov       r8,143D1013060
       mov       r8,[r8]
       mov       rdx,143E1011720
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Deserialize()
;             var result = XmlHelper.Deserialize<PersonCollection<PersonProper>>(this._xml);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;             Encapsulation.TryValidateParam(xml, nameof(xml));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var sr = new StringReader(xml))
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 var xs = new XmlSerializer(typeof(TResult));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return (TResult)xs.Deserialize(sr);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
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
       mov       r8,2977D6B3060
       mov       r8,[r8]
       mov       rdx,2979D6B1720
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Deserialize()
;             var result = XmlHelper.Deserialize<PersonCollection<PersonProper>>(this._xml);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;             Encapsulation.TryValidateParam(xml, nameof(xml));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var sr = new StringReader(xml))
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 var xs = new XmlSerializer(typeof(TResult));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return (TResult)xs.Deserialize(sr);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
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
       mov       r8,1DFA8B53060
       mov       r8,[r8]
       mov       rdx,1DFC8B51720
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Deserialize()
;             var result = XmlHelper.Deserialize<PersonCollection<PersonProper>>(this._xml);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;             Encapsulation.TryValidateParam(xml, nameof(xml));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var sr = new StringReader(xml))
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 var xs = new XmlSerializer(typeof(TResult));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return (TResult)xs.Deserialize(sr);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
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
       mov       r8,232C7363060
       mov       r8,[r8]
       mov       rdx,232B7361720
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Deserialize()
;             var result = XmlHelper.Deserialize<PersonCollection<PersonProper>>(this._xml);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;             Encapsulation.TryValidateParam(xml, nameof(xml));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var sr = new StringReader(xml))
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 var xs = new XmlSerializer(typeof(TResult));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return (TResult)xs.Deserialize(sr);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
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
       mov       r8,1E7FFD93060
       mov       r8,[r8]
       mov       rdx,1E82FD91720
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Deserialize()
;             var result = XmlHelper.Deserialize<PersonCollection<PersonProper>>(this._xml);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;             Encapsulation.TryValidateParam(xml, nameof(xml));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var sr = new StringReader(xml))
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 var xs = new XmlSerializer(typeof(TResult));
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return (TResult)xs.Deserialize(sr);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
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
       mov       r8,21E9B203060
       mov       r8,[r8]
       mov       rdx,21E9B211B38
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Serialize()
;             var result = XmlHelper.Serialize(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;             Encapsulation.TryValidateParam<ArgumentNullException>(obj != null, nameof(obj));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var writer = new StringWriter())
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 using (var xmlWriter = XmlWriter.Create(writer))
;                        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     var serializer = new XmlSerializer(obj.GetType());
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     serializer.Serialize(xmlWriter, obj);
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     return writer.ToString();
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
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
       mov       r9,2226DB73060
       mov       r9,[r9]
       mov       r8,2224DB71688
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
       call      00007FFFC03F1F60
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
       call      qword ptr [7FFF60C47010]
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFF60800760
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50760]
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
       mov       r11,7FFF60800760
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50760]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Serialize()
;             var result = XmlHelper.Serialize(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;             Encapsulation.TryValidateParam<ArgumentNullException>(obj != null, nameof(obj));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var writer = new StringWriter())
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 using (var xmlWriter = XmlWriter.Create(writer))
;                        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     var serializer = new XmlSerializer(obj.GetType());
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     serializer.Serialize(xmlWriter, obj);
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     return writer.ToString();
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
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
       mov       r9,19A098E3060
       mov       r9,[r9]
       mov       r8,19A098F1AA0
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
       call      00007FFFC03F1F60
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
       call      qword ptr [7FFF60C57010]
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFF60810760
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C60760]
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
       mov       r11,7FFF60810760
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C60760]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Serialize()
;             var result = XmlHelper.Serialize(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;             Encapsulation.TryValidateParam<ArgumentNullException>(obj != null, nameof(obj));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var writer = new StringWriter())
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 using (var xmlWriter = XmlWriter.Create(writer))
;                        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     var serializer = new XmlSerializer(obj.GetType());
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     serializer.Serialize(xmlWriter, obj);
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     return writer.ToString();
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
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
       mov       r9,1CC4AFB3060
       mov       r9,[r9]
       mov       r8,1CC7AFB36A0
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
       call      00007FFFC03F1F60
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
       call      qword ptr [7FFF60C47010]
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFF60800768
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50768]
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
       mov       r11,7FFF60800768
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50768]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Serialize()
;             var result = XmlHelper.Serialize(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;             Encapsulation.TryValidateParam<ArgumentNullException>(obj != null, nameof(obj));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var writer = new StringWriter())
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 using (var xmlWriter = XmlWriter.Create(writer))
;                        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     var serializer = new XmlSerializer(obj.GetType());
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     serializer.Serialize(xmlWriter, obj);
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     return writer.ToString();
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
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
       mov       r9,1B330983060
       mov       r9,[r9]
       mov       r8,1B330991AA0
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
       call      00007FFFC03F1F60
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
       call      qword ptr [7FFF60E17010]
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFF60800848
       cmp       [rcx],ecx
       call      qword ptr [7FFF60E20848]
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
       mov       r11,7FFF60800848
       cmp       [rcx],ecx
       call      qword ptr [7FFF60E20848]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Serialize()
;             var result = XmlHelper.Serialize(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;             Encapsulation.TryValidateParam<ArgumentNullException>(obj != null, nameof(obj));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var writer = new StringWriter())
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 using (var xmlWriter = XmlWriter.Create(writer))
;                        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     var serializer = new XmlSerializer(obj.GetType());
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     serializer.Serialize(xmlWriter, obj);
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     return writer.ToString();
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
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
       mov       r9,23D32C13060
       mov       r9,[r9]
       mov       r8,23D22C1D638
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
       call      00007FFFC03F1F60
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
       call      qword ptr [7FFF60C47010]
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFF60800760
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50760]
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
       mov       r11,7FFF60800760
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50760]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.Serialize()
;             var result = XmlHelper.Serialize(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;             Encapsulation.TryValidateParam<ArgumentNullException>(obj != null, nameof(obj));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var writer = new StringWriter())
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 using (var xmlWriter = XmlWriter.Create(writer))
;                        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     var serializer = new XmlSerializer(obj.GetType());
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     serializer.Serialize(xmlWriter, obj);
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     return writer.ToString();
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
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
       mov       r9,133F8053060
       mov       r9,[r9]
       mov       r8,133F8053AD8
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
       call      00007FFFC03F1F60
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
       call      qword ptr [7FFF60C87010]
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFF60830810
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C80810]
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
       mov       r11,7FFF60830810
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C80810]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
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
;             var result = XmlHelper.Serialize(base.personProperCollection);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; Total bytes of code 42
```
```assembly
; dotNetTips.Utility.Standard.Xml.XmlHelper.Serialize(System.Object)
;             Encapsulation.TryValidateParam<ArgumentNullException>(obj != null, nameof(obj));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var writer = new StringWriter())
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 using (var xmlWriter = XmlWriter.Create(writer))
;                        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     var serializer = new XmlSerializer(obj.GetType());
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     serializer.Serialize(xmlWriter, obj);
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     return writer.ToString();
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
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
       mov       r9,2D87AF83060
       mov       r9,[r9]
       mov       r8,2D87AF91AA0
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
       call      00007FFFC03F1F60
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
       call      qword ptr [7FFF60C47010]
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFF607F0810
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C40810]
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
       mov       r11,7FFF607F0810
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C40810]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.StringToXDocument()
;             var result = XmlHelper.StringToXDocument(Resources.XmlPersonTestData);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;                 return ResourceManager.GetString("XmlPersonTestData", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,2A297543650
       mov       rdx,[rdx]
       mov       r8,2A29753B390
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
;             Encapsulation.TryValidateParam(input, nameof(input));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var options = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = resolver };
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var reader = XmlReader.Create(new StringReader(input), options))
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return XDocument.Load(reader);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2A297533060
       mov       r8,[r8]
       mov       rdx,2A297541588
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
       mov       rdx,2A297533060
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
       mov       r11,7FFF60810740
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50740]
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
       mov       r11,7FFF60810740
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50740]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.StringToXDocument()
;             var result = XmlHelper.StringToXDocument(Resources.XmlPersonTestData);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;                 return ResourceManager.GetString("XmlPersonTestData", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,1A83D152A00
       mov       rdx,[rdx]
       mov       r8,1A85D15B390
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
;             Encapsulation.TryValidateParam(input, nameof(input));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var options = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = resolver };
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var reader = XmlReader.Create(new StringReader(input), options))
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return XDocument.Load(reader);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1A85D153060
       mov       r8,[r8]
       mov       rdx,1A84D151170
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
       mov       rdx,1A85D153060
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
       mov       r11,7FFF60820740
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C60740]
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
       mov       r11,7FFF60820740
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C60740]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.StringToXDocument()
;             var result = XmlHelper.StringToXDocument(Resources.XmlPersonTestData);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;                 return ResourceManager.GetString("XmlPersonTestData", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,28FF8C7D978
       mov       rdx,[rdx]
       mov       r8,28FF8C76F28
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
;             Encapsulation.TryValidateParam(input, nameof(input));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var options = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = resolver };
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var reader = XmlReader.Create(new StringReader(input), options))
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return XDocument.Load(reader);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,28FE8C73060
       mov       r8,[r8]
       mov       rdx,28FD8C73188
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
       mov       rdx,28FE8C73060
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
       mov       r11,7FFF60810758
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C60758]
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
       mov       r11,7FFF60810758
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C60758]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.StringToXDocument()
;             var result = XmlHelper.StringToXDocument(Resources.XmlPersonTestData);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;                 return ResourceManager.GetString("XmlPersonTestData", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,17C1F6C4E50
       mov       rdx,[rdx]
       mov       r8,17C3F6C6F28
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
;             Encapsulation.TryValidateParam(input, nameof(input));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var options = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = resolver };
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var reader = XmlReader.Create(new StringReader(input), options))
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return XDocument.Load(reader);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,17C1F6C3060
       mov       r8,[r8]
       mov       rdx,17C3F6CD120
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
       mov       rdx,17C1F6C3060
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
       mov       r11,7FFF60800740
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C40740]
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
       mov       r11,7FFF60800740
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C40740]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.StringToXDocument()
;             var result = XmlHelper.StringToXDocument(Resources.XmlPersonTestData);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;                 return ResourceManager.GetString("XmlPersonTestData", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,1ED88573650
       mov       rdx,[rdx]
       mov       r8,1ED8856B390
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
;             Encapsulation.TryValidateParam(input, nameof(input));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var options = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = resolver };
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var reader = XmlReader.Create(new StringReader(input), options))
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return XDocument.Load(reader);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1ED88563060
       mov       r8,[r8]
       mov       rdx,1ED88571588
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
       mov       rdx,1ED88563060
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
       mov       r11,7FFF60820740
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C60740]
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
       mov       r11,7FFF60820740
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C60740]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.StringToXDocument()
;             var result = XmlHelper.StringToXDocument(Resources.XmlPersonTestData);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;                 return ResourceManager.GetString("XmlPersonTestData", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,2DB736876A0
       mov       rdx,[rdx]
       mov       r8,2DB93686F28
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
;             Encapsulation.TryValidateParam(input, nameof(input));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var options = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = resolver };
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var reader = XmlReader.Create(new StringReader(input), options))
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return XDocument.Load(reader);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2DB73683060
       mov       r8,[r8]
       mov       rdx,2DB736855D8
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
       mov       rdx,2DB73683060
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
       mov       r11,7FFF60810740
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50740]
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
       mov       r11,7FFF60810740
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C50740]
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

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Xml.XmlHelperPerfTestRunner.StringToXDocument()
;             var result = XmlHelper.StringToXDocument(Resources.XmlPersonTestData);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
;                 return ResourceManager.GetString("XmlPersonTestData", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      dotNetTips.Utility.Benchmarks.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,2807A450270
       mov       rdx,[rdx]
       mov       r8,2808A3DB390
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
;             Encapsulation.TryValidateParam(input, nameof(input));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var options = new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = resolver };
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             using (var reader = XmlReader.Create(new StringReader(input), options))
;                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 return XDocument.Load(reader);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;         }
;         ^
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2808A3D3060
       mov       r8,[r8]
       mov       rdx,2807A3D1170
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
       mov       rdx,2808A3D3060
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
       mov       r11,7FFF60810748
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C60748]
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
       mov       r11,7FFF60810748
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C60748]
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

