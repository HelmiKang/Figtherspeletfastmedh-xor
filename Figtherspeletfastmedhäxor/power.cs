public class Power
{

public string Name;

public int Dmg;

protected List<SubPower> SubPowersList = new();

//_________________________________________________________________________________________________________________________________


//generera en damage
public int GenerateDmg(Witch target)
{
    //välj en random attack
    int i = Random.Shared.Next(SubPowersList.Count);
    SubPower WitchPower = SubPowersList[i];
    //generera en random damage inom scopet för vald attack
    int Dmg = Random.Shared.Next(WitchPower.Maxdmg);
    Console.WriteLine($"Did {Dmg} damage with {WitchPower.Name} on {target.Name}");
    
    target.Hp -= Dmg;

    return Dmg;
    
}


}
