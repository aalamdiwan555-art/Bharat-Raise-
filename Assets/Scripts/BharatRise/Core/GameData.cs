using System;
[Serializable] public class BuildingState { public int level; public bool unlocked; }
[Serializable] public class GameData{
 public int saveVersion=3;
 public int money=5000,population=120,food=160,energy=140,happiness=62,year=1,level=1,xp=0;
 public bool tutorialSeen=false, cityComplete=false, freeBuild=false, paused=false;
 public int chapter=1, missionIndex=0, totalBuilt=0, eventSeed=1337;
 public float musicVolume=0.8f,sfxVolume=0.8f;
 public bool reducedMotion=false,vibration=true;
 public BuildingState[] buildings=new BuildingState[12];
 public bool[] achievements=new bool[10];
 public GameData(){for(int i=0;i<buildings.Length;i++)buildings[i]=new BuildingState();}
 public void Normalize(){if(buildings==null||buildings.Length!=12){var old=buildings;buildings=new BuildingState[12];for(int i=0;i<12;i++)buildings[i]=old!=null&&i<old.Length&&old[i]!=null?old[i]:new BuildingState();}for(int i=0;i<12;i++)if(buildings[i]==null)buildings[i]=new BuildingState();if(achievements==null||achievements.Length!=10)achievements=new bool[10];saveVersion=3;money=Math.Max(0,money);population=Math.Max(1,population);food=Math.Max(0,food);energy=Math.Max(0,energy);happiness=Math.Clamp(happiness,0,100);level=Math.Clamp(level,1,10);chapter=Math.Clamp(chapter,1,6);missionIndex=Math.Max(0,missionIndex);}
}