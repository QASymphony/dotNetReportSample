@echo off

cd NUnit.ConsoleRunner/tools
call nunit3-console.exe ../../Source/NUnitReportSample.Test.dll
move TestResult.xml ../..

pause