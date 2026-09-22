using UnityEngine;using UnityEngine.SceneManagement;
public class GameApp:MonoBehaviour{
 public static GameApp I{get;private set;} public GameData Data{get;private set;}
 void Awake(){if(I!=null){Destroy(gameObject);return;}I=this;DontDestroyOnLoad(gameObject);Data=SaveSystem.Load();}
 public void Save(){SaveSystem.Save(Data);}
 public void Load(string scene){Save();SceneManager.LoadScene(scene);}
 public void NewGame(){Data=new GameData();Save();}
}