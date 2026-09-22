using System.IO;using UnityEngine;
public static class SaveSystem{
 const string Key="BHARAT_RISE_SAVE_V3",BackupKey="BHARAT_RISE_SAVE_V3_BACKUP";
 public static GameData Load(){string raw=PlayerPrefs.GetString(Key,"");var d=Try(raw);if(d!=null){d.Normalize();return d;}var backup=Try(PlayerPrefs.GetString(BackupKey,""));if(backup!=null){backup.Normalize();Save(backup);return backup;}return new GameData();}
 static GameData Try(string raw){if(string.IsNullOrEmpty(raw))return null;try{return JsonUtility.FromJson<GameData>(raw);}catch{return null;}}
 public static void Save(GameData d){d.Normalize();string json=JsonUtility.ToJson(d);PlayerPrefs.SetString(BackupKey,json);PlayerPrefs.SetString(Key,json);PlayerPrefs.Save();}
 public static void Delete(){PlayerPrefs.DeleteKey(Key);PlayerPrefs.DeleteKey(BackupKey);PlayerPrefs.Save();}
}