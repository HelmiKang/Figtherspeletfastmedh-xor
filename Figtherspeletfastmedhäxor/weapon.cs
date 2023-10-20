public class power
{
public int dmgmax;
public string name;

public int dmg;

private Random generator = new();

public power (string nameo, int dmgmaxo)
{
name = nameo;
dmgmax =  dmgmaxo;
}

public void damageGenerator()
{
dmg = generator.Next(dmgmax);
}


}
