﻿
using System.Xml;

public class Witch
{
public int Hp = 40;
public string Name;

public Power WitchPower;
//_________________________________________________________________________________________________________________________________

//skapa instans av witch
public Witch (string holderName, Power holderPower)
{
Name = holderName;
WitchPower =  holderPower;
}
//_________________________________________________________________________________________________________________________________

// attackera en target, ser till att hp inte går under 0
public void Attack(Witch target)
{
    // power.damageGenerator();
    // int damage = power.dmg;
    // target.hp -= damage;
    Console.WriteLine($"{Name} attacked!");

    int dmgDone = WitchPower.GenerateDmg(target);
    if (target.Hp < 0)
    {
        target.Hp = 0;
    }

    Console.WriteLine($"{target.Name} now has {target.Hp} hp.");
}
}

