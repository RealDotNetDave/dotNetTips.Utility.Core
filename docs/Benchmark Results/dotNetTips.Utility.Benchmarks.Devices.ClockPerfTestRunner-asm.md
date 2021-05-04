## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Devices.ClockPerfTestRunner.TestDaysInCurrentMonth()
       mov       rax,offset dotNetTips.Utility.Standard.Devices.Clock.get_DaysInCurrentMonth()
       jmp       rax
; Total bytes of code 13
```
```assembly
; dotNetTips.Utility.Standard.Devices.Clock.get_DaysInCurrentMonth()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       call      System.DateTime.get_Now()
       mov       [rsp+28],rax
       lea       rcx,[rsp+28]
       xor       edx,edx
       call      System.DateTime.GetDatePart(Int32)
       mov       esi,eax
       call      System.DateTime.get_Now()
       mov       [rsp+28],rax
       lea       rcx,[rsp+28]
       mov       edx,2
       call      System.DateTime.GetDatePart(Int32)
       mov       edx,eax
       mov       ecx,esi
       call      System.DateTime.DaysInMonth(Int32, Int32)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Devices.ClockPerfTestRunner.TestDaysInCurrentUtcMonth()
       mov       rax,offset dotNetTips.Utility.Standard.Devices.Clock.get_DaysInCurrentUtcMonth()
       jmp       rax
; Total bytes of code 13
```
```assembly
; dotNetTips.Utility.Standard.Devices.Clock.get_DaysInCurrentUtcMonth()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       call      System.DateTime.get_UtcNow()
       mov       [rsp+28],rax
       lea       rcx,[rsp+28]
       xor       edx,edx
       call      System.DateTime.GetDatePart(Int32)
       mov       esi,eax
       call      System.DateTime.get_UtcNow()
       mov       [rsp+28],rax
       lea       rcx,[rsp+28]
       mov       edx,2
       call      System.DateTime.GetDatePart(Int32)
       mov       edx,eax
       mov       ecx,esi
       call      System.DateTime.DaysInMonth(Int32, Int32)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Devices.ClockPerfTestRunner.TestLocalTime()
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       call      System.DateTime.get_Now()
       mov       [rsp+20],rax
       lea       rcx,[rsp+20]
       xor       edx,edx
       call      System.DateTime.ToLocalTime(Boolean)
       nop
       add       rsp,28
       ret
; Total bytes of code 39
```
```assembly
; System.DateTime.get_Now()
       push      rsi
       sub       rsp,40
       call      System.DateTime.get_UtcNow()
       mov       rsi,rax
       xor       edx,edx
       mov       [rsp+38],edx
       lea       rdx,[rsp+38]
       mov       rcx,rsi
       call      System.TimeZoneInfo.GetDateTimeNowUtcOffsetFromUtc(System.DateTime, Boolean ByRef)
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rsi
       add       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       jle       short M01_L00
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       rdx,2875F4373FFF
       mov       r8d,2
       call      System.DateTime..ctor(Int64, System.DateTimeKind)
       mov       rax,[rsp+20]
       add       rsp,40
       pop       rsi
       ret
M01_L00:
       test      rdx,rdx
       jge       short M01_L01
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       xor       edx,edx
       mov       r8d,2
       call      System.DateTime..ctor(Int64, System.DateTimeKind)
       mov       rax,[rsp+28]
       add       rsp,40
       pop       rsi
       ret
M01_L01:
       xor       r9d,r9d
       mov       [rsp+30],r9
       mov       r9d,[rsp+38]
       movzx     r9d,r9b
       lea       rcx,[rsp+30]
       mov       r8d,2
       call      System.DateTime..ctor(Int64, System.DateTimeKind, Boolean)
       mov       rax,[rsp+30]
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 192
```
```assembly
; System.DateTime.ToLocalTime(Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       mov       rsi,rcx
       mov       edi,edx
       mov       rcx,rsi
       call      System.DateTime.get_Kind()
       cmp       eax,2
       jne       short M02_L00
       mov       rax,[rsi]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       xor       ecx,ecx
       mov       [rsp+48],ecx
       mov       [rsp+40],ecx
       mov       rbx,[rsi]
       mov       rcx,14E3DE61420
       mov       rcx,[rcx]
       mov       rdx,[rcx+8]
       test      rdx,rdx
       jne       short M02_L01
       call      System.TimeZoneInfo+CachedData.CreateLocal()
       mov       rdx,rax
M02_L01:
       lea       r8,[rsp+48]
       lea       r9,[rsp+40]
       mov       rcx,rbx
       call      System.TimeZoneInfo.GetUtcOffsetFromUtc(System.DateTime, System.TimeZoneInfo, Boolean ByRef, Boolean ByRef)
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,[rsi]
       add       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       jle       short M02_L02
       test      dil,dil
       jne       near ptr M02_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       rdx,2875F4373FFF
       mov       r8d,2
       call      System.DateTime..ctor(Int64, System.DateTimeKind)
       mov       rax,[rsp+28]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       test      rdx,rdx
       jge       short M02_L03
       test      dil,dil
       jne       near ptr M02_L05
       xor       ecx,ecx
       mov       [rsp+30],rcx
       lea       rcx,[rsp+30]
       xor       edx,edx
       mov       r8d,2
       call      System.DateTime..ctor(Int64, System.DateTimeKind)
       mov       rax,[rsp+30]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       xor       r9d,r9d
       mov       [rsp+38],r9
       mov       r9d,[rsp+40]
       movzx     r9d,r9b
       lea       rcx,[rsp+38]
       mov       r8d,2
       call      System.DateTime..ctor(Int64, System.DateTimeKind, Boolean)
       mov       rax,[rsp+38]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,24C2
       mov       rdx,7FF88A5A4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,14E3DE63060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,24C2
       mov       rdx,7FF88A5A4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       rdx,14E3DE63060
       mov       rdx,[rdx]
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 438
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Devices.ClockPerfTestRunner.TestTickCount()
       mov       rax,7FF8EA1C04D0
       jmp       rax
; Total bytes of code 13
```

## .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
```assembly
; dotNetTips.Utility.Benchmarks.Devices.ClockPerfTestRunner.TestUtcTime()
       mov       rax,offset System.DateTime.get_UtcNow()
       jmp       rax
; Total bytes of code 13
```
```assembly
; System.DateTime.get_UtcNow()
       push      rsi
       sub       rsp,40
       lea       rcx,[rsp+28]
       call      00007FF8EA431070
       movzx     ecx,word ptr [rsp+28]
       movzx     edx,word ptr [rsp+2A]
       movzx     r8d,word ptr [rsp+2E]
       call      System.DateTime.DateToTicks(Int32, Int32, Int32)
       mov       rsi,rax
       movzx     ecx,word ptr [rsp+30]
       movzx     edx,word ptr [rsp+32]
       movzx     r8d,word ptr [rsp+34]
       call      System.DateTime.TimeToTicks(Int32, Int32, Int32)
       add       rsi,rax
       movzx     eax,word ptr [rsp+36]
       imul      rax,2710
       add       rsi,rax
       add       rsi,[rsp+38]
       mov       rax,0
       or        rax,rsi
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 102
```

