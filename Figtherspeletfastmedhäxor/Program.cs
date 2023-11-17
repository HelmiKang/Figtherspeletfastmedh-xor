
//skapar saker
using System.ComponentModel;

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

 /*
    1. läsa in ett namn
    2. välja en kraft
    2.1 Läsa in 1 eller 2 eller 3 eller 4
    2.2 Om man valde 1, skapa instans av Ice
        power = new Ice()
    2.3 Om man valde 2, skapa instans av Fire
        power = new Fire()
    2.4 Skapa en instans av Witch, lägg till namn & kraft

    */


    Console.WriteLine("Player 1, choose the name of your witch:");
    string witchName = Console.ReadLine();    

    Space();

    Console.WriteLine("Player 1, now you must choose the elemental power your witch will have..");
    Console.WriteLine("1 : The power of water.");
    Console.WriteLine("2 : The power of ice.");
    Console.WriteLine("3 : The power of fire.");
    Console.WriteLine("4 : The power of nature.");
    string witchPower = Console.ReadLine();
    Space();

    if(witchPower == "2")
    { 
        power ice = new Ice();
        Witch Witch1 = new(witchName, Ice);
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
