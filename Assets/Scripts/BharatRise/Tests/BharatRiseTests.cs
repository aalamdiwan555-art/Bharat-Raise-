#if UNITY_INCLUDE_TESTS
using NUnit.Framework;
public class BharatRiseTests{
 [Test]public void NewGameHasPositiveStartingResources(){var d=new GameData();Assert.Greater(d.money,0);Assert.Greater(d.population,0);Assert.Greater(d.food,0);Assert.Greater(d.energy,0);}
 [Test]public void MissionCanBeCompleted(){var d=new GameData{population=200,happiness=80,level=5,food=400};Assert.IsTrue(Missions.Complete(d));}
 [Test]public void SaveDataIsSerializable(){var d=new GameData();d.money=1234;var json=UnityEngine.JsonUtility.ToJson(d);var copy=UnityEngine.JsonUtility.FromJson<GameData>(json);Assert.AreEqual(1234,copy.money);}
}
#endif