#if UNITY_EDITOR
using UnityEditor;using UnityEditor.SceneManagement;using UnityEngine;using System.IO;
public static class BuildAllScenes{
 static readonly string[] scenes={"MainMenu","City","Settings","Achievements"};
 [MenuItem("Bharat Rise/Build All Scenes")]public static void Build(){Directory.CreateDirectory("Assets/Scenes");var list=new EditorBuildSettingsScene[scenes.Length];for(int i=0;i<scenes.Length;i++){var s=EditorSceneManager.NewScene(NewSceneSetup.EmptyScene,NewSceneMode.Single);GameObject g=new GameObject("SceneEntry");var e=g.AddComponent<SceneEntry>();e.sceneName=scenes[i];if(scenes[i]=="City")g.AddComponent<CityController>();string path="Assets/Scenes/"+scenes[i]+".unity";EditorSceneManager.SaveScene(s,path);list[i]=new EditorBuildSettingsScene(path,true);}EditorBuildSettings.scenes=list;AssetDatabase.SaveAssets();AssetDatabase.Refresh();}
 [InitializeOnLoadMethod]static void Auto(){EditorApplication.delayCall+=()=>{if(!File.Exists("Assets/Scenes/MainMenu.unity"))Build();};}
}
#endif