## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.TypeHelperPerfTestRunner.DoesObjectEqualInstance()
;             var person1 = RandomData.GeneratePerson<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var person2 = RandomData.GeneratePerson<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var result = TypeHelper.DoesObjectEqualInstance(person1, person2);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       mov       rsi,rcx
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Tester.RandomData.GeneratePerson(Int32, Int32, Int32, Int32, Int32, Int32)
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      dotNetTips.Utility.Standard.Tester.RandomData.GeneratePerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdi,rax
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       rcx,offset MD_dotNetTips.Utility.Standard.Tester.RandomData.GeneratePerson(Int32, Int32, Int32, Int32, Int32, Int32)
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      dotNetTips.Utility.Standard.Tester.RandomData.GeneratePerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32)
       cmp       rdi,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rsi+8]
       mov       [rdx+44],al
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 147
```
```assembly
; dotNetTips.Utility.Standard.Tester.RandomData.GeneratePerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32)
;             var person = new T
;             ^^
;             {
;             ^^
;                 Id = RandomData.GenerateKey(),
;             ^^
;                 Address1 = RandomData.GenerateWord(addressLength),
;             ^^
;                 Address2 = RandomData.GenerateWord(addressLength),
;             ^^
;                 BornOn = DateTimeOffset.Now.Subtract(new TimeSpan(365 * GenerateInteger(1, 75), 0, 0, 0)),
;             ^^
;                 CellPhone = GeneratePhoneNumberUSA(),
;             ^^
;                 City = RandomData.GenerateWord(cityLength),
;             ^^
;                 Country = RandomData.GenerateWord(countryLength),
;             ^^
;                 Email = RandomData.GenerateEmailAddress(),
;             ^^
;                 FirstName = RandomData.GenerateWord(firstNameLength),
;             ^^
;                 HomePhone = GeneratePhoneNumberUSA(),
;             ^^
;                 LastName = RandomData.GenerateWord(lastNameLength),
;             ^^
;                 PostalCode = RandomData.GenerateNumber(postalCodeLength)
;             ^^
;             };
;             ^^
;             return person;
;             ^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       vzeroupper
       xor       eax,eax
       mov       [rsp+90],rax
       mov       [rsp+98],rax
       mov       [rsp+0A0],rcx
       mov       esi,edx
       mov       edi,r8d
       mov       ebx,r9d
       mov       rdx,[rcx+10]
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M01_L00
       mov       rdx,7FFF60BDDD88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L00:
       mov       rcx,rax
       call      System.Activator.CreateInstance[[System.__Canon, System.Private.CoreLib]]()
       mov       rbp,rax
       lea       rcx,[rsp+68]
       call      System.Guid.NewGuid()
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       lea       rcx,[rsp+48]
       call      dotNetTips.Utility.Standard.Extensions.GuidExtensions.ToDigits(System.Guid)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF608104A8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C204A8]
       mov       ecx,esi
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF608104B0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C204B0]
       mov       ecx,esi
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF608104B8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C204B8]
       lea       rax,[rsp+58]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       call      System.DateTime.get_Now()
       mov       rdx,rax
       lea       rcx,[rsp+58]
       call      System.DateTimeOffset..ctor(System.DateTime)
       vmovdqu   xmm0,xmmword ptr [rsp+58]
       vmovdqu   xmmword ptr [rsp+90],xmm0
       xor       ecx,ecx
       mov       [rsp+88],rcx
       mov       ecx,1
       mov       edx,4B
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      edx,eax,16D
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       lea       rcx,[rsp+88]
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.TimeSpan..ctor(Int32, Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+90]
       lea       rdx,[rsp+78]
       mov       r8,[rsp+88]
       call      System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovdqu   xmm0,xmmword ptr [rsp+78]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       rcx,rbp
       lea       rdx,[rsp+38]
       mov       r11,7FFF608104C0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C204C0]
       call      dotNetTips.Utility.Standard.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF608104C8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C204C8]
       mov       ecx,edi
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF608104D0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C204D0]
       mov       ecx,ebx
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF608104D8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C204D8]
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateEmailAddress()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF608104E0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C204E0]
       mov       ecx,[rsp+0F0]
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF608104E8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C204E8]
       call      dotNetTips.Utility.Standard.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF608104F0
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C204F0]
       mov       ecx,[rsp+0F8]
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF608104F8
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C204F8]
       mov       ecx,[rsp+100]
       call      dotNetTips.Utility.Standard.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r11,7FFF60810500
       cmp       [rcx],ecx
       call      qword ptr [7FFF60C20500]
       mov       rax,rbp
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 647
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.TypeHelperPerfTestRunner.FindDerivedTypes()
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp+0FFF8],rax
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFE0],rax
       mov       [rbp+10],rcx
;             var result = TypeHelper.FindDerivedTypes(typeof(PersonProper), true);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Tester.Models.PersonProper
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [rbp+0FFF0],rax
       mov       rcx,[rbp+0FFF0]
       call      System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
       mov       [rbp+0FFE8],rax
       mov       rcx,[rbp+0FFE8]
       mov       edx,1
       call      dotNetTips.Utility.Standard.TypeHelper.FindDerivedTypes(System.Type, Boolean)
       mov       [rbp+0FFF8],rax
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       call      dotNetTips.Utility.Benchmarks.PerfTestRunner.get_Consumer()
       mov       [rbp+0FFE0],rax
       mov       rcx,[rbp+0FFE0]
       mov       r8,[rbp+0FFF8]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume(!!0)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       nop
       lea       rsp,[rbp]
       pop       rbp
       ret
; Total bytes of code 127
```
```assembly
; dotNetTips.Utility.Standard.TypeHelper.FindDerivedTypes(System.Type, Boolean)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+0FFF8],rax
       mov       [rbp+0FFF0],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
;             var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       call      System.Reflection.Assembly.GetEntryAssembly()
       mov       [rbp+0FFF0],rax
       mov       rcx,[rbp+0FFF0]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       call      System.IO.Path.GetDirectoryName(System.String)
       mov       [rbp+0FFF8],rax
;             return FindDerivedTypes(path, SearchOption.TopDirectoryOnly, baseType, classOnly);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       r9d,[rbp+18]
       movzx     r9d,r9b
       mov       rcx,[rbp+0FFF8]
       mov       r8,[rbp+10]
       xor       edx,edx
       call      dotNetTips.Utility.Standard.TypeHelper.FindDerivedTypes(System.String, System.IO.SearchOption, System.Type, Boolean)
       nop
       lea       rsp,[rbp]
       pop       rbp
       ret
; Total bytes of code 96
```
```assembly
; dotNetTips.Utility.Benchmarks.PerfTestRunner.get_Consumer()
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
;         protected Consumer Consumer => this._consumer;
;                                        ^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax+8]
       pop       rbp
       ret
; Total bytes of code 18
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rdx,[rbp+10]
       cmp       [rdx],edx
       mov       rdx,[rbp+10]
       add       rdx,10
       mov       r8,[rbp+20]
       mov       rcx,offset MD_System.Threading.Volatile.Write(!!0 ByRef, !!0)
       call      System.Threading.Volatile.Write[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon)
       nop
       lea       rsp,[rbp]
       pop       rbp
       ret
; Total bytes of code 62
```
**Extern method**
System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.TypeHelperPerfTestRunner.GetDefault()
;             var result = TypeHelper.GetDefault<PersonProper>();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+8]
       mov       edx,[rax]
       add       rax,10
       xor       edx,edx
       mov       [rax],rdx
       ret
; Total bytes of code 16
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.TypeHelperPerfTestRunner.GetInstanceHashCode()
;             var result = TypeHelper.GetInstanceHashCode(this._personProper);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      dotNetTips.Utility.Standard.TypeHelper.GetInstanceHashCode(System.Object)
       mov       rdx,[rsi+8]
       mov       [rdx+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 30
```
```assembly
; dotNetTips.Utility.Standard.TypeHelper.GetInstanceHashCode(System.Object)
;             Encapsulation.TryValidateParam<ArgumentNullException>(instance != null, nameof(instance));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var hash = -1;
;             ^^^^^^^^^^^^^^
;             hash = instance.GetType().GetRuntimeProperties().Where(p => p != null).Select(prop => prop.GetValue(instance)).Where(value => value != null).Aggregate(-1, (accumulator, value) => accumulator ^ value.GetHashCode());
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return hash;
;             ^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.TypeHelper+<>c__DisplayClass11_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rdi+8],0
       setne     dl
       movzx     edx,dl
       mov       r9,221D00C3060
       mov       r9,[r9]
       mov       r8,221D00D1468
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Utility.Standard.OOP.Encapsulation.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,[rdi+8]
       call      00007FFFC03F1F60
       mov       rcx,rax
       call      System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(System.Type)
       mov       rsi,rax
       mov       rcx,221D00CBB60
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M01_L00
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,221D00CBB58
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L03
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Standard.TypeHelper+<>c.<GetInstanceHashCode>b__11_0(System.Reflection.PropertyInfo)
       mov       [rbx+18],rdx
       mov       rcx,221D00CBB60
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L00:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Object, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r8,rbx
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Where(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rsi,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset dotNetTips.Utility.Standard.TypeHelper+<>c__DisplayClass11_0.<GetInstanceHashCode>b__1(System.Reflection.PropertyInfo)
       mov       [rbp+18],r8
       mov       r8,rbp
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Select(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rsi,rax
       mov       rcx,221D00CBB68
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L01
       mov       rcx,offset MT_System.Func`2[[System.Object, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,221D00CBB58
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L04
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Standard.TypeHelper+<>c.<GetInstanceHashCode>b__11_2(System.Object)
       mov       [rdi+18],rdx
       mov       rcx,221D00CBB68
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rdi
M01_L01:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Where(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       mov       rcx,221D00CBB70
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L02
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Object, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,221D00CBB58
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M01_L05
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Utility.Standard.TypeHelper+<>c.<GetInstanceHashCode>b__11_3(Int32, System.Object)
       mov       [rsi+18],rdx
       mov       rcx,221D00CBB70
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,rsi
M01_L02:
       mov       rdx,rdi
       mov       r8d,0FFFFFFFF
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       mov       rcx,rbx
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L04:
       mov       rcx,rdi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L05:
       mov       rcx,rsi
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 586
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.TypeHelperPerfTestRunner.GetTypeDisplayNameTypeTest()
;             var result = TypeHelper.GetTypeDisplayName(typeof(PersonProper), true, true, true, '|');
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,offset MT_dotNetTips.Utility.Standard.Tester.Models.PersonProper
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       dword ptr [rsp+20],7C
       mov       edx,1
       mov       r8d,1
       mov       r9d,1
       call      dotNetTips.Utility.Standard.TypeHelper.GetTypeDisplayName(System.Type, Boolean, Boolean, Boolean, Char)
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; dotNetTips.Utility.Standard.TypeHelper.GetTypeDisplayName(System.Type, Boolean, Boolean, Boolean, Char)
;             if (type == null)
;             ^^^^^^^^^^^^^^^^^
;                 throw new ArgumentNullException(nameof(type), $"{nameof(type)} is null.");
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var builder = new StringBuilder();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             ProcessType(builder, type, new DisplayNameOptions(fullName, includeGenericParameterNames, includeGenericParameters, nestedTypeDelimiter));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return builder.ToString();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M01_L00
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r8d,dil
       movzx     ecx,bpl
       movzx     edx,bl
       mov       edi,[rsp+80]
       movzx     eax,di
       lea       r9,[rsp+28]
       mov       [r9],r8b
       mov       [r9+1],dl
       mov       [r9+2],cl
       mov       [r9+4],ax
       lea       r8,[rsp+28]
       mov       rcx,r14
       mov       rdx,rsi
       call      dotNetTips.Utility.Standard.TypeHelper.ProcessType(System.Text.StringBuilder, System.Type, DisplayNameOptions ByRef)
       mov       rcx,r14
       call      qword ptr [7FFF60C17010]
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,261
       mov       rdx,7FFF60BCF288
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,26B
       mov       rdx,7FFF60BCF288
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 258
```

## .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.TypeHelperPerfTestRunner.GetTypeDisplayNameVariableTest()
;             var result = TypeHelper.GetTypeDisplayName(this._personProper, true);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             base.Consumer.Consume(result);
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       test      rcx,rcx
       je        short M00_L00
       call      00007FFFC03F1F60
       mov       rcx,rax
       mov       dword ptr [rsp+20],2B
       mov       edx,1
       xor       r8d,r8d
       mov       r9d,1
       call      dotNetTips.Utility.Standard.TypeHelper.GetTypeDisplayName(System.Type, Boolean, Boolean, Boolean, Char)
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rcx,[rsi+8]
       mov       edx,[rcx]
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; dotNetTips.Utility.Standard.TypeHelper.GetTypeDisplayName(System.Type, Boolean, Boolean, Boolean, Char)
;             if (type == null)
;             ^^^^^^^^^^^^^^^^^
;                 throw new ArgumentNullException(nameof(type), $"{nameof(type)} is null.");
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var builder = new StringBuilder();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             ProcessType(builder, type, new DisplayNameOptions(fullName, includeGenericParameterNames, includeGenericParameters, nestedTypeDelimiter));
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return builder.ToString();
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       test      rsi,rsi
       je        near ptr M01_L00
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r8d,dil
       movzx     ecx,bpl
       movzx     edx,bl
       mov       edi,[rsp+80]
       movzx     eax,di
       lea       r9,[rsp+28]
       mov       [r9],r8b
       mov       [r9+1],dl
       mov       [r9+2],cl
       mov       [r9+4],ax
       lea       r8,[rsp+28]
       mov       rcx,r14
       mov       rdx,rsi
       call      dotNetTips.Utility.Standard.TypeHelper.ProcessType(System.Text.StringBuilder, System.Type, DisplayNameOptions ByRef)
       mov       rcx,r14
       call      qword ptr [7FFF60C07010]
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,261
       mov       rdx,7FFF60BBF288
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,26B
       mov       rdx,7FFF60BBF288
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 258
```

