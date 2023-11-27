public class Water : Power
{
  public Water()
  {
    dmgMax = 10;
    name = "water";
    dmg = 0;

    subPowers.Add(new SubPower() { name = "watter bubble", maxDmg = 5 });
    subPowers.Add(new SubPower() { name = "pouring rain", maxDmg = 10 });
    subPowers.Add(new SubPower() { name = "explosive geyser", maxDmg = 20 });
  }
}
