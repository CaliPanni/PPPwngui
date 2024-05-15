@echo off
echo PPPwn GUI v. 2.5 Based on PPPwn c++
echo.
echo Npcap Install Dir:
set KEY_NAME=HKLM\Software\WOW6432Node\Npcap
for /F "usebackq tokens=1,2*" %%A IN (`reg query "%KEY_NAME%" /ve 2^>nul ^| find "REG_SZ"`) do (
	set NPCAP_DIR=%%C
)
if defined NPCAP_DIR (goto DO_CHECK)
set KEY_NAME=HKLM\Software\Npcap
for /F "usebackq tokens=1,2*" %%A IN (`reg query "%KEY_NAME%" /ve 2^>nul ^| find "REG_SZ"`) do (
	set NPCAP_DIR=%%C
)
if defined NPCAP_DIR (goto DO_CHECK) else (goto ABORT)
:DO_CHECK
for /F "usebackq tokens=1,4" %%A in (`sc.exe qc npcap`) do (
	if %%A == START_TYPE (
	    if NOT %%B == SYSTEM_START (
		goto FIXINSTALL
	    )
	)
)
goto ABORT
:FIXINSTALL
goto ABORT
:ABORT
echo %NPCAP_DIR%
echo.
echo Ready! 
