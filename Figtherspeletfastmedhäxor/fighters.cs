
using System.Xml;

public class Witch
{
public int hp = 40;
public string name;

public Power power;
//_________________________________________________________________________________________________________________________________

//skapa instans av witch
public Witch (string holderName, Power holderPower)
{
name = holderName;
power =  holderPower;
}
//_________________________________________________________________________________________________________________________________

// attackera en target
public void attack(Witch target)
{
    // power.damageGenerator();
    // int damage = power.dmg;
    // target.hp -= damage;
    Console.WriteLine($"{name} attacked!");

    int dmgDone = power.Attack(target);
    if (target.hp < 0)
    {
        target.hp = 0;
    }

    Console.WriteLine($"{target.name} now has {target.hp} hp.");
}
}

