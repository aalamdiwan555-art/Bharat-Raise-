using System;
[Serializable] public class GameData{
 public int money=5000,population=120,food=160,energy=140,happiness=62,year=1,level=1,xp=0;
 public int day=1;
 public bool[] buildings=new bool[12];
 public bool tutorialSeen=false;
 public int[] achievements=new int[6];
}