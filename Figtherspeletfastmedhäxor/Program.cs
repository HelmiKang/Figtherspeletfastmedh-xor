
//skapar saker
using System.ComponentModel;

//funktioner

// metod används för att skapa ett mellanrum mellan rader
void Space()
{
    Console.WriteLine(" ");
}

// metod används för att attackera
void AttackLoop(CreateWitch attacker, CreateWitch target)
{
    Space();
    attacker.Attack(target);
}

// metod som tömmer skärmen
void Clear()
{
    Space();
    Console.WriteLine("(press any key)");
    Console.ReadLine();
    Console.Clear();
}
//_________________________________________________________________________________________________________________________________

// skapa witch 1
// välj namn på din witch
Console.WriteLine("Player 1, choose the name of your witch:");
string witchName = Console.ReadLine();

Space();

CreateWitch Witch1 = new("", new Power());
bool rightInput = true;
string witchPower = "";

while (rightInput == true)
{   
    Console.WriteLine("Player 1, now you must choose the elemental power your witch will have..");
    Console.WriteLine("1 : The power of water.");
    Console.WriteLine("2 : The power of ice.");
    Console.WriteLine("3 : The power of fire.");
    Console.WriteLine("4 : The power of nature.");
    Space();

    // skapar instans av vald power, skapar instans av witch med namn och power
    // testar om input är en int
    try {
    int n = int.Parse(Console.ReadLine());
    if (n == 1)
    {   
        Power water = new CreateWater();
        Witch1 = new(witchName, water);
        break;
    }
    if (n == 2)
    {
        Power ice = new CreateIce();
        Witch1 = new(witchName, ice);
        break;
    }
    if (n == 3)
    {
        Power fire = new CreateFire();
        Witch1 = new(witchName, fire);
        break;
    }
    if (n == 4)
    {
        Power nature = new CreateNature();
        Witch1 = new(witchName, nature);
        break;
    }
    else
    {
        Console.WriteLine("Invalid input.");
        Space();
    }
    }
    // om fel input så får man testa igen
    catch
    {
        Console.WriteLine("Invalid input.");
        Space();
    }
}
Console.WriteLine($"you have chosen the power of {Witch1.WitchPower.Name}");
Clear();
//_________________________________________________________________________________________________________________________________

// skapa  witch 2
// välj namn på din witch
Console.WriteLine("Player 2, choose the name of your witch:");
witchName = Console.ReadLine();

Space();

CreateWitch Witch2 = new("", new Power());
rightInput = true;

while (rightInput == true)
{   
    Console.WriteLine("Player 2, now you must choose the elemental power your witch will have..");
    Console.WriteLine("1 : The power of water.");
    Console.WriteLine("2 : The power of ice.");
    Console.WriteLine("3 : The power of fire.");
    Console.WriteLine("4 : The power of nature.");
    Space();
    
    // skapar instans av vald power, skapar instans av witch med namn och power
    // testar om input är en int
    try {
    int n = int.Parse(Console.ReadLine());
    if (n == 1)
    {   
        Power water = new CreateWater();
        Witch2 = new(witchName, water);
        break;
    }
    if (n == 2)
    {
        Power ice = new CreateIce();
        Witch2 = new(witchName, ice);
        break;
    }
    if (n == 3)
    {
        Power fire = new CreateFire();
        Witch2 = new(witchName, fire);
        break;
    }
    if (n == 4)
    {
        Power nature = new CreateNature();
        Witch2 = new(witchName, nature);
        break;
    }
    else
    {
        Console.WriteLine("Invalid input.");
        Space();
    }
    }
    // om fel input så får man testa igen
    catch
    {
        Console.WriteLine("Invalid input.");
        Space();
    }
}
Console.WriteLine($"you have chosen the power of {Witch2.WitchPower.Name}");
Clear();
//___________________________________________________________________________________


//spelet
Console.WriteLine($"{Witch1.Name} has {Witch1.Hp} hp and the power of {Witch1.WitchPower.Name}.");
Console.WriteLine($"{Witch2.Name} has {Witch2.Hp} hp and the power of {Witch2.WitchPower.Name}.");
Clear();

//attackerar tills någon dör (någons hp går till 0)
while (Witch1.Hp >
 0 && Witch2.Hp > 0)
{
    AttackLoop(Witch1, Witch2);
    AttackLoop(Witch2, Witch1);
    Clear();
}
//_________________________________________________________________________________________________________________________________

//Spelet är slut och säger vem som vann peroende på hp
Console.WriteLine("Nu är duellen slut!");

if (Witch1.Hp < 0 && Witch2.Hp < 0)
{
    Console.WriteLine("oavgjort");
}
if (Witch1.Hp < 0)
{
    Console.WriteLine($"{Witch2.Name} vann");
}
if (Witch2.Hp < 0)
{
    Console.WriteLine($"{Witch1.Name} vann");
}

Console.ReadLine();
