@echo off
set /p user="Benutzer: "
set "psCommand=powershell -Command "$pword = read-host 'Passwort' -AsSecureString ; ^
    $BSTR=[System.Runtime.InteropServices.Marshal]::SecureStringToBSTR($pword); ^
        [System.Runtime.InteropServices.Marshal]::PtrToStringAuto($BSTR)""
for /f "usebackq delims=" %%p in (`%psCommand%`) do set password=%%p
@ECHO OFF

net use w: /delete

net use W: \\PLUESS-SE1000\Daten /User:%user% %password% /persistent:Yes