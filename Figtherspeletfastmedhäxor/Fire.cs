
public class Fire : power
{
  public Fire()
  {
    dmgmax = 10;
    name = "fire";
    dmg = 0;

    subPowers.Add(new SubPower() { name = "fire bolt", maxDmg = 5 });
    subPowers.Add(new SubPower() { name = "burning hands", maxDmg = 10 });
    subPowers.Add(new SubPower() { name = "fireball", maxDmg = 20 });
  }
}
