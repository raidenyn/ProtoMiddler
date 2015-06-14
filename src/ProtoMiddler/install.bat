FOR /F "skip=2 tokens=2,*" %%A IN ('reg.exe query "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders" /v "Personal"') DO set "Personal=%%B"
CALL SET FiddlerInspectorsPath=%Personal%\Fiddler2\Inspectors
SET TargetDir=%1

if not exist "%FiddlerInspectorsPath%" mkdir "%FiddlerInspectorsPath%"
xcopy /E /Y /I "%TargetDir:~0,-1%" "%FiddlerInspectorsPath%" 