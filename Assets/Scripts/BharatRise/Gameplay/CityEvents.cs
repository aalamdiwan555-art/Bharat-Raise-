using UnityEngine;
public static class CityEvents{
 public static string Apply(GameData d){
  int roll=Random.Range(0,100);
  if(roll<12){d.money+=700;d.happiness=Mathf.Clamp(d.happiness+5,0,100);return "Festival season! Tourism brought 700 and happiness increased.";}
  if(roll<24){d.food=Mathf.Max(0,d.food-35);d.money=Mathf.Max(0,d.money-250);return "Supply disruption. Food and emergency funds were used.";}
  if(roll<34){d.energy+=40;d.money+=250;return "Solar breakthrough! Energy +40 and grant +250.";}
  if(roll<42){d.population+=8;d.happiness=Mathf.Clamp(d.happiness+3,0,100);return "New families arrived. Population +8.";}
  return "A calm year. Your city continues to grow.";
 }
}