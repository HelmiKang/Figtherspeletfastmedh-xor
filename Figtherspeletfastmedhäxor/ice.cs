
public class CreateIce : Power
{
    public CreateIce()
    {
        Name = "ice";
        Dmg = 0;

        SubPowersList.Add(new SubPower() {Name = "ray of frost", Maxdmg = 5});
        SubPowersList.Add(new SubPower() {Name = "ice dagger", Maxdmg = 10});
        SubPowersList.Add(new SubPower() {Name = "cone of cold", Maxdmg = 20});

    }
}
