
public class CreateNature : Power
{
    public CreateNature()
    {
        Name = "nature";
        Dmg = 0;

        SubPowersList.Add(new SubPower() {Name = "entangle", Maxdmg = 5});
        SubPowersList.Add(new SubPower() {Name = "poison ivy", Maxdmg = 10});
        SubPowersList.Add(new SubPower() {Name = "nature's wrath", Maxdmg = 20});

    }
}

