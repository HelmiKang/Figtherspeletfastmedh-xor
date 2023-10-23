
public class Ice : power
{
    public Ice()
    {
        dmgmax = 10;
        name = "ice";
        dmg = 0;

        subPowers.Add(new SubPower() {name = "ray of frost", maxDmg = 5});
        subPowers.Add(new SubPower() {name = "ice dagger", maxDmg = 10});
        subPowers.Add(new SubPower() {name = "cone of cold", maxDmg = 20});

    }
}
