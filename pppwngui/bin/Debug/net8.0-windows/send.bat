@echo off
setlocal
set "filePath=var1.temp"
set /p var1=<"%filePath%"
set "filePath1=var2.temp"
set /p var2=<"%filePath1%"
set "filePath2=var3.temp"
set /p var3=<"%filePath2%"
set "filePath3=var4.temp"
set /p var4=<"%filePath3%"
del var1.temp
del var2.temp
del var3.temp
del var4.temp
if %var4% == True goto autoretry
pppwn --interface %var2% --fw %var1% --stage2 "%var3%" --stage1 stage1.bin 
goto deltemp
:autoretry
pppwn --interface %var2% --fw %var1% --stage2 "%var3%" --stage1 stage1.bin -a
:deltemp
endlocal
exit
