#if UNITY_EDITOR
using UnityEditor;using UnityEditor.Build.Reporting;using UnityEngine;
public static class AndroidBuildSetup{
 [MenuItem("Bharat Rise/Configure Android")]public static void Configure(){PlayerSettings.companyName="Bharat Rise Studio";PlayerSettings.productName="Bharat Rise";PlayerSettings.applicationIdentifier="com.bharatrise.game";PlayerSettings.bundleVersion="1.0.0";PlayerSettings.Android.bundleVersionCode=1;EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Android,BuildTarget.Android);Debug.Log("Android configured: com.bharatrise.game v1.0.0");}
 [MenuItem("Bharat Rise/Build Android APK")]public static void APK(){Configure();BuildPipeline.BuildPlayer(new BuildPlayerOptions{scenes=new[]{"Assets/Scenes/MainMenu.unity","Assets/Scenes/City.unity","Assets/Scenes/Settings.unity","Assets/Scenes/Achievements.unity"},locationPathName="Builds/BharatRise.apk",target=BuildTarget.Android,options=BuildOptions.None});}
}
#endif