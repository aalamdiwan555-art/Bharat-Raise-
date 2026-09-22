using UnityEngine;
public static class Missions{
 public static string Get(GameData d){
  if(d.population<180)return "Mission: Reach 180 population.";
  if(d.happiness<75)return "Mission: Reach 75% happiness.";
  if(d.level<5)return "Mission: Reach Level 5.";
  if(d.food<300)return "Mission: Store 300 food.";
  return "Mission: Build every district.";
 }
 public static bool Complete(GameData d){return d.population>=180&&d.happiness>=75&&d.level>=5&&d.food>=300;}
}