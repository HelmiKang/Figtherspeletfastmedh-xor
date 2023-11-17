public class power
{
public int dmgmax;
public string name;

public int dmg;


protected List<SubPower> subPowers = new();

// private Random generator = new();



public void damageGenerator()
{
dmg = Random.Shared.Next(dmgmax);
}

public int Attack(Witch target)
{
    int i = Random.Shared.Next(subPowers.Count);
    SubPower power = subPowers[i];
    int dmg = Random.Shared.Next(power.maxDmg);
    Console.WriteLine($"Did {dmg} damage with {power.name} on {target.name}");
    target.hp -= dmg;

    return dmg;
    
}


}
