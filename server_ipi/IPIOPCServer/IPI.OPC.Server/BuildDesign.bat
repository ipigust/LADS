@ECHO off
SETLOCAL
set MODELCOMPILERPATH=%1
set SRCPATH=%2
set DSTPATH=%3

set MODELCOMPILER=%MODELCOMPILERPATH%\Opc.Ua.ModelCompiler.exe

ECHO Building Model OpcUaDiModel
%MODELCOMPILER% compile -d2 "%SRCPATH%\DI\OpcUaDiModel.xml" -cg "%SRCPATH%\DI\OpcUaDiModel.csv" -o2 "%DSTPATH%\DI\GeneratedCode"
IF %ERRORLEVEL% NEQ 0 ( ECHO Failed %MODEL% & EXIT /B 3 )

REM ECHO Building Model OpcUaRoboticsModel
REM %MODELCOMPILER% compile -d2 ".\OpcUaRobotics\OpcUaRoboticsModel.xml" -cg ".\OpcUaRobotics\OpcUaRoboticsModel.csv" -o2 ".\OpcUaRobotics\GeneratedCode"
REM IF %ERRORLEVEL% NEQ 0 ( ECHO Failed %MODEL% & EXIT /B 3 )

ECHO Building Model LADS
%MODELCOMPILER% compile -d2 "%SRCPATH%\LADS\LADSModel.xml" -cg "%SRCPATH%\LADS\LADSModel.csv" -o2 "%DSTPATH%\LADS\GeneratedCode"
IF %ERRORLEVEL% NEQ 0 ( ECHO Failed %MODEL% & EXIT /B 3 )

ECHO Building Model GAMModel
%MODELCOMPILER% compile -d2 "%SRCPATH%\GAM\GAMModel.xml" -cg "%SRCPATH%\GAM\GAMModel.csv" -o2 "%DSTPATH%\GAM\GeneratedCode"
IF %ERRORLEVEL% NEQ 0 ( ECHO Failed %MODEL% & EXIT /B 3 )
