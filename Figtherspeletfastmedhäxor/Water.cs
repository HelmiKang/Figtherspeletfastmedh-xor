public class CreateWater : Power
{
  public CreateWater()
  {
    Name = "water";
    Dmg = 0;

    SubPowersList.Add(new SubPower() { Name = "watter bubble", Maxdmg = 5 });
    SubPowersList.Add(new SubPower() { Name = "pouring rain", Maxdmg = 10 });
    SubPowersList.Add(new SubPower() { Name = "explosive geyser", Maxdmg = 20 });
  }
}
