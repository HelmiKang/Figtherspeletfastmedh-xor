
using System.Xml;

public class Witch
{
public int hp;
public string name;

public power power;

public Witch (string nameo, int hpo, power choice)
{
name = nameo;
hp =  hpo;
power =  choice;
}

public void attack(Witch target)
{
    // power.damageGenerator();
    // int damage = power.dmg;
    // target.hp -= damage;
    Console.WriteLine($"{name} attacked!");

    int dmgDone = power.Attack(target);

    Console.WriteLine($"{target.name} now has {target.hp} hp.");
}

}
