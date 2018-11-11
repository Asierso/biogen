echo off
cls
echo Downloading Debug.bio 
echo.
wget --no-check-certificate https://asierso.github.io/biogen/debuger.bio
ren debuger.bio debuger.rar
echo.
echo Installing Debug.bio
echo.
unrar x -r debuger.rar  
echo.
echo Finishing
echo.
del /Q /S unrar.exe
del /Q /S wget.exe
del /Q /S debuger.rar
del /Q /S Instalador.exe
del /Q /S install.bat



