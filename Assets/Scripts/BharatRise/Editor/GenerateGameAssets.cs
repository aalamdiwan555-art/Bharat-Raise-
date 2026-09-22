#if UNITY_EDITOR
using UnityEditor;using UnityEngine;using UnityEngine.SceneManagement;using System.IO;
public static class GenerateGameAssets{
 [MenuItem("Bharat Rise/Generate Complete Game")]
 public static void Generate(){Directory.CreateDirectory("Assets/Scenes");BuildScenes();BuildSettings();AssetDatabase.SaveAssets();AssetDatabase.Refresh();Debug.Log("Bharat Rise: generated complete scene set and runtime presentation hooks.");}
 static void BuildScenes(){string[] names={"MainMenu","City","Settings","Achievements"};var list=new EditorBuildSettingsScene[names.Length];for(int i=0;i<names.Length;i++){var s=EditorSceneManager.NewScene(NewSceneSetup.EmptyScene,NewSceneMode.Single);var go=new GameObject("SceneEntry");var e=go.AddComponent<SceneEntry>();e.sceneName=names[i];if(names[i]=="City")go.AddComponent<CityController>();SaveScene(s,names[i]);list[i]=new EditorBuildSettingsScene("Assets/Scenes/"+names[i]+".unity",true);}EditorBuildSettings.scenes=list;}
 static void SaveScene(Scene s,string n){EditorSceneManager.SaveScene(s,"Assets/Scenes/"+n+".unity");}
 static void BuildSettings(){PlayerSettings.companyName="Bharat Rise Studio";PlayerSettings.productName="Bharat Rise";PlayerSettings.applicationIdentifier="com.bharatrise.game";PlayerSettings.bundleVersion="1.0.0";PlayerSettings.Android.bundleVersionCode=1;PlayerSettings.defaultIsNativeResolution=true;PlayerSettings.allowedAutorotateToPortrait=true;PlayerSettings.allowedAutorotateToPortraitUpsideDown=true;PlayerSettings.allowedAutorotateToLandscapeLeft=false;PlayerSettings.allowedAutorotateToLandscapeRight=false;}
}
#endif