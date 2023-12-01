
public class CreateFire : Power
{
  public CreateFire()
  {
    Name = "fire";
    Dmg = 0;

    SubPowersList.Add(new SubPower() { Name = "fire bolt", Maxdmg = 5 });
    SubPowersList.Add(new SubPower() { Name = "burning hands", Maxdmg = 10 });
    SubPowersList.Add(new SubPower() { Name = "fireball", Maxdmg = 20 });
  }
}
