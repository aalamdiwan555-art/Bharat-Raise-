#if UNITY_EDITOR
using UnityEditor;using UnityEditor.SceneManagement;using UnityEngine;
public static class BharatRiseSceneBuilder{
 [MenuItem("Bharat Rise/Create Game Scene")]public static void Create(){var s=EditorSceneManager.NewScene(NewSceneSetup.EmptyScene,NewSceneMode.Single);new GameObject("BharatRiseBootstrap").AddComponent<BharatRiseBootstrap>();EditorSceneManager.SaveScene(s,"Assets/Scenes/BharatRise.unity");EditorBuildSettings.scenes=new[]{new EditorBuildSettingsScene("Assets/Scenes/BharatRise.unity",true)};AssetDatabase.Refresh();}
 [InitializeOnLoadMethod]static void Ensure(){EditorApplication.delayCall+=()=>{if(!System.IO.File.Exists("Assets/Scenes/BharatRise.unity"))Create();};}
}
#endif