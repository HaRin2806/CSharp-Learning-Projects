int heroHealth = 10;
int monsterHealth = 10;

Random random = new Random();
while (heroHealth > 0 && monsterHealth > 0)
{
    int heroAttack = random.Next(1, 11);
    monsterHealth -= heroAttack;

    Console.WriteLine($"Monster was damanged and lost {heroAttack} health and now has {monsterHealth} health.");
    if (monsterHealth <= 0)
    {
        Console.WriteLine("Hero wins!");
        break;
    }

    int monsterAttack = random.Next(1, 11);
    heroHealth -= monsterAttack;

    Console.WriteLine($"Hero wa damaged and lost {monsterAttack} health and now has {heroHealth} health.");

    if (heroHealth <= 0)
    {
        Console.WriteLine("Monster wins!");
    }
}

/*
//C2
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
*/