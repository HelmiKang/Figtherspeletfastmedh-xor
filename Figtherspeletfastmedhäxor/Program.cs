
//skapar saker
power Ice = new Ice();
power Fire = new Fire();

Witch Witch1 = new("Helmi", 40, Ice);
Witch Witch2 = new("Alva", 39, Fire);


//funktioner
void Space()
{
    Console.WriteLine(" ");
}

void attackLoop(Witch attacker, Witch target)
{
    Space();
    attacker.attack(target);
}

void Clear()
{
    Space();
    Console.WriteLine("(press any key)");
    Console.ReadLine();
    Console.Clear();
}

//spelet
//början
Console.WriteLine($"{Witch1.name} has {Witch1.hp} hp and the power of {Witch1.power.name}.");
Console.WriteLine($"{Witch2.name} has {Witch2.hp} hp and the power of {Witch2.power.name}.");
Clear();

//mitten
while (Witch1.hp >
 0 && Witch2.hp > 0)
{
    attackLoop(Witch1, Witch2);
    attackLoop(Witch2, Witch1);
    Clear();
}

//slut
Console.WriteLine("Nu är duellen slut!");

if (Witch1.hp < 0 && Witch2.hp < 0)
{
    Console.WriteLine("oavgjort");
}
if (Witch1.hp < 0)
{
    Console.WriteLine($"{Witch2.name} vann");
}
if (Witch2.hp < 0)
{
    Console.WriteLine($"{Witch1.name} vann");
}

Console.ReadLine();
