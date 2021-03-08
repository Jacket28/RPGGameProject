echo Clearing Up Build Directory
rm -rf ../RPGGame/Build/

echo Starting Build Process
'C:\Program Files\Unity\Hub\Editor\2019.4.20f1\Editor\Unity.exe' -quit -batchmode -ProjectPath ../RPGGame/ -executeMethod BuildScript.PerformBuild

echo Ended Build Process