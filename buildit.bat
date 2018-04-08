
@echo off

rem Set variables here

set H=R:\KSP_1.3.1_dev
set GAMEDATA=GameData
set MODNAME=RecycledParts
set GAMEDIR=SpaceTuxIndustries\%MODNAME%
set LICENSE=Licenses.txt
set README=ReadMe.md
set CHANGELOG=ChangeLog.txt
set DEPENDSON=RequiredMods.txt

set RELEASEDIR=d:\Users\jbb\release
set ZIP="c:\Program Files\7-zip\7z.exe"

rem Copy files to GameData locations

copy /Y %MODNAME%.version %GAMEDATA%\%GAMEDIR%
copy /Y ..\MiniAVC.dll %GAMEDATA%\%GAMEDIR%

if "%LICENSE%" NEQ "" copy /y  %LICENSE% %GAMEDATA%\%GAMEDIR%
if "%README%" NEQ "" copy /Y %README% %GAMEDATA%\%GAMEDIR%
if "%CHANGELOG%" NEQ "" copy /Y %CHANGELOG% %GAMEDATA%\%GAMEDIR%
if "%DEPENDSON%" NEQ "" copy /Y %DEPENDSON% %GAMEDATA%\%GAMEDIR%

rem Get Version info


set VERSIONFILE=%MODNAME%.version
rem The following requires the JQ program, available here: https://stedolan.github.io/jq/download/
c:\local\jq-win64  ".VERSION.MAJOR" %VERSIONFILE% >tmpfile
set /P major=<tmpfile

c:\local\jq-win64  ".VERSION.MINOR"  %VERSIONFILE% >tmpfile
set /P minor=<tmpfile

c:\local\jq-win64  ".VERSION.PATCH"  %VERSIONFILE% >tmpfile
set /P patch=<tmpfile

c:\local\jq-win64  ".VERSION.BUILD"  %VERSIONFILE% >tmpfile
set /P build=<tmpfile
del tmpfile
set VERSION=%major%.%minor%.%patch%
if "%build%" NEQ "0"  set VERSION=%VERSION%.%build%

echo Version:  %VERSION%

rem Build the zip FILE

set FILE="%RELEASEDIR%\%MODNAME%-%VERSION%.zip"
IF EXIST %FILE% del /F %FILE%
%ZIP% a -tzip %FILE% %GAMEDATA% Ships

pause
