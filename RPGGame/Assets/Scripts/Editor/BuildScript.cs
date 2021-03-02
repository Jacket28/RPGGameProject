using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuildScript
{
    static void PerformBuild()
    {
        string[] defaultScene = { "Assets/Scenes/MainScene.Unity" };
        BuildPipeline.BuildPlayer(defaultScene, "./builds/RPGGame.exe", 
            BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}
