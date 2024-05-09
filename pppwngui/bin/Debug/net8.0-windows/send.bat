@echo off
setlocal
set "filePath=var1.temp"
set /p var1=<"%filePath%"
set "filePath1=var2.temp"
set /p var2=<"%filePath1%"
set "filePath2=var3.temp"
set /p var3=<"%filePath2%"
python pppwn.py --interface="%var2%" --fw=%var1% --stage2="%var3%"

endlocal
del var1.temp
del var2.temp
del var3.temp
exit
