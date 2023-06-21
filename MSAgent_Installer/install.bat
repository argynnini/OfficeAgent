@echo off

call color 0a

echo Microsoft Agent Core Components �C���X�g�[�� for after Windows 8

openfiles > NUL 2>&1 
if not %ERRORLEVEL% == 0 (
  call color 4e
  echo �Ǘ��Ҍ����Ŏ��s���Ă��������B
  powershell start-process \"%~f0\" -Verb runas
  goto exit
)

rem �t�@�C�����݂̊m�F
echo %~dp0msAgentCoreComponents.exe
if exist "%~dp0msAgentCoreComponents.exe" (
  echo msAgentCoreComponents.exe ��������܂����B
) else (
  echo msAgentCoreComponents.exe ��������܂���B
  goto :END1
)
if exist "%~dp0msAgentCoreComponentsJP.exe" (
  echo msAgentCoreComponentsJP.exe ��������܂����B
) else (
  echo msAgentCoreComponentsJP.exe ��������܂���B
  goto :END1
)
rem �C���X�g�[������
echo Microsoft Agent Core Components (msAgentCoreComponents.exe) �̃C���X�g�[�����D�D�D
call "%~dp0msAgentCoreComponents.exe" /Q
echo Microsoft Agent Core Components Japanese (msAgentCoreComponentsJP.exe) �̃C���X�g�[�����D�D�D
call "%~dp0msAgentCoreComponentsJP.exe" /Q

rem �o�[�W�����̊m�F
ver | find /i "Version 6.3." > nul
if %ERRORLEVEL% equ 0 (
  echo OS �� "Windows 8.1" �ł��B
  goto :BIT
)
ver | find /i "Version 10.0." > nul
if %ERRORLEVEL% equ 0 (
  echo OS �� "Windows 10" �ł��B
  goto :BIT
)
goto :END1

rem bit���̊m�F
:BIT
if "%PROCESSOR_ARCHITECTURE%" equ "x86" (
  echo OS �� "x86" �ł��B
  goto :x86
)
if "%PROCESSOR_ARCHITECTURE%" equ "AMD64" (
  echo OS �� "x86-64" �ł��B
  goto :x64
)
goto :END1

rem ���W�X�g���ݒ�
:x86
echo �C���t�@�C���̃R�s�[���D�D�D
call xcopy "%~dp0x86\MSAgent" "C:\Windows\MSAgent" /S /R /Y /I /K /Q > nul
echo ���W�X�g���̐ݒ蒆�D�D�D
call regedit /s "%~dp0x86\MSAgent_x86.reg"
goto :END
:x64
echo �C���t�@�C���̃R�s�[���D�D�D
echo "%~dp0x64\MSAgent C:\Windows\MSAgent"
call xcopy "%~dp0x64\MSAgent" "C:\Windows\MSAgent" /S /R /Y /I /K /Q > nul
call xcopy "%~dp0x64\MSAgent64" "C:\Windows\MSAgent64" /S /R /Y /I /K /Q > nul
echo ���W�X�g���̐ݒ蒆�D�D�D�D�D�D
call regedit /s "%~dp0x64\MSAgent_x64.reg"
goto :END

:END
call color 17
echo ���C���X�g�[�����������܂����B��
goto :DONE

:END1
call color 4e
echo ���C���X�g�[���Ɏ��s���܂����B��
goto :DONE

:DONE
pause
exit
