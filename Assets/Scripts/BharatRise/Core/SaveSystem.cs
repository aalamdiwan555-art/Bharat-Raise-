using UnityEngine;
public static class SaveSystem{
 const string Key="BHARAT_RISE_SAVE_V2";
 public static GameData Load(){var raw=PlayerPrefs.GetString(Key,"");if(string.IsNullOrEmpty(raw))return new GameData();try{var d=JsonUtility.FromJson<GameData>(raw);return d??new GameData();}catch{return new GameData();}}
 public static void Save(GameData d){PlayerPrefs.SetString(Key,JsonUtility.ToJson(d));PlayerPrefs.Save();}
 public static void Delete(){PlayerPrefs.DeleteKey(Key);PlayerPrefs.Save();}
}