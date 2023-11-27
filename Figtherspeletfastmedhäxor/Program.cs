
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
//_________________________________________________________________________________________________________________________________

// skapa witch 1
Console.WriteLine("Player 1, choose the name of your witch:");
string witchName = Console.ReadLine();

Space();

Witch Witch1 = new("", new Power());
bool rightInput = true;
string witchPower = "";

while (rightInput == true)
{   
    Console.WriteLine("Player 1, now you must choose the elemental power your witch will have..");
    Console.WriteLine("1 : The power of water.");
    Console.WriteLine("2 : The power of ice.");
    Console.WriteLine("3 : The power of fire.");
    Console.WriteLine("4 : The power of nature.");
    witchPower = Console.ReadLine();
    Space();

    // skapar instans av vald power, skapar instans av witch med namn och power
    if (witchPower == "1")
    {
        Power water = new Water();
        Witch1 = new(witchName, water);
        break;
    }
    if (witchPower == "2")
    {
        Power ice = new Ice();
        Witch1 = new(witchName, ice);
        break;
    }
    if (witchPower == "3")
    {
        Power fire = new Fire();
        Witch1 = new(witchName, fire);
        break;
    }
    if (witchPower == "4")
    {
        Power nature = new Nature();
        Witch1 = new(witchName, nature);
        break;
    }
    else
    {
        Console.WriteLine("Invalid input.");
        Space();
    }
}
Clear();
//_________________________________________________________________________________________________________________________________

// create witch 2
Console.WriteLine("Player 2, choose the name of your witch:");
witchName = Console.ReadLine();

Space();

Witch Witch2 = new("", new Power());
rightInput = true;

while (rightInput == true)
{   
    Console.WriteLine("Player 2, now you must choose the elemental power your witch will have..");
    Console.WriteLine("1 : The power of water.");
    Console.WriteLine("2 : The power of ice.");
    Console.WriteLine("3 : The power of fire.");
    Console.WriteLine("4 : The power of nature.");
    witchPower = Console.ReadLine();
    Space();
    
    // skapar instans av vald power, skapar instans av witch med namn och power
    if (witchPower == "1")
    {
        Power water = new Water();
        Witch2 = new(witchName, water);
        break;
    }
    if (witchPower == "2")
    {
        Power ice = new Ice();
        Witch2 = new(witchName, ice);
        break;
    }
    if (witchPower == "3")
    {
        Power fire = new Fire();
        Witch2 = new(witchName, fire);
        break;
    }
    if (witchPower == "4")
    {
        Power nature = new Nature();
        Witch2 = new(witchName, nature);
        break;
    }
    else
    {
        Console.WriteLine("Invalid input.");
        Space();
    }
}
Clear();
//___________________________________________________________________________________



//spelet
Console.WriteLine($"{Witch1.name} has {Witch1.hp} hp and the power of {Witch1.power.name}.");
Console.WriteLine($"{Witch2.name} has {Witch2.hp} hp and the power of {Witch2.power.name}.");
Clear();
//_________________________________________________________________________________________________________________________________

//attackerar tills någon dör
while (Witch1.hp >
 0 && Witch2.hp > 0)
{
    attackLoop(Witch1, Witch2);
    attackLoop(Witch2, Witch1);
    Clear();
}
//_________________________________________________________________________________________________________________________________

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
