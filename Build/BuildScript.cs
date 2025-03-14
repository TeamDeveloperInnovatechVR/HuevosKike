using UnityEditor;
using System.IO;

public class BuildScript
{
    public static void BuildWebGL()
    {
        string buildPath = "Build/WebGL";
        if (!Directory.Exists(buildPath))
        {
            Directory.CreateDirectory(buildPath);
        }
        
        // Ajusta las escenas según tu proyecto
        string[] scenes = { "Assets/Scenes/MainScene.unity" };

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = buildPath + "/index.html",
            target = BuildTarget.WebGL,
            options = BuildOptions.None
        };

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
