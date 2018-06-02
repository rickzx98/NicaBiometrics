# NicaBiometrics
Fingerprint biometrics terminal for ZTK 


## Installation 

- Install the ZTK SDK included in this project

### 32 Bit
-  Copy all sdk *.dll files to %windir%\system32 folder , and then run cmd.exe ,enter the following command:
```
    regsvr32.exe %windir%\system32\zkemkeeper.dll
```
-  If you want to unregister sdk , run cmd.exe ,enter the following command:
```
  
    regsvr32.exe -u %windir%\system32\zkemkeeper.dll
```

### 64 Bit
- Copy all sdk *.dll files to %windir%\sysWOW64 folder , and then run cmd.exe ,enter the following command:
```
    %windir%\syswow64\regsvr32.exe %windir%\syswow64\zkemkeeper.dll
```
- If you want to unregister sdk , run cmd.exe ,enter the following command:
```
    %windir%\syswow64\regsvr32.exe -u %windir%\syswow64\zkemkeeper.dll
```
