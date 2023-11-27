public class Power
{

public string name;

public int dmg;

protected int dmgMax;

protected List<SubPower> subPowers = new();

public void damageGenerator()
{
dmg = Random.Shared.Next(dmgMax);
}
//_________________________________________________________________________________________________________________________________


//generera en damage
public int Attack(Witch target)
{
    //välj en random attack
    int i = Random.Shared.Next(subPowers.Count);
    SubPower power = subPowers[i];
    //generera en random damage inom scopet för vald attack
    int dmg = Random.Shared.Next(power.maxDmg);
    Console.WriteLine($"Did {dmg} damage with {power.name} on {target.name}");
    
    target.hp -= dmg;

    return dmg;
    
}


}
