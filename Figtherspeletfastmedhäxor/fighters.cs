
using System.Xml;

public class Witch
{
public int hp = 40;
public string name;

public power power;

public Witch (string nameo, power choice)
{
name = nameo;
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

