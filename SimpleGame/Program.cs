Console.WriteLine("Добро пожаловать в игру!");
Console.WriteLine("Сражение начнется через 3 секунды...");
System.Threading.Thread.Sleep(3000);

Random random = new Random();
int heroHealth = 100;
int monsterHealth = 100;
int round = 1;

while (round <= 3)
{
    Console.WriteLine($"Раунд {round}");
    Console.WriteLine($"Здоровье героя: {heroHealth}");
    Console.WriteLine($"Здоровье монстра: {monsterHealth}");
    Console.WriteLine("Нажмите Enter, чтобы атаковать...");
    Console.ReadLine();

    int heroDamage = random.Next(10, 21); // Важно учесть, что 21 не считается
    int monsterDamage = random.Next(5, 26); // Здесь аналогичная ситуация

    monsterHealth -= heroDamage;
    heroHealth -= monsterDamage;

    Console.WriteLine($"Герой нанес {heroDamage} урона монстру!");
    Console.WriteLine($"Монстр нанес {monsterDamage} урона герою!");

    if (heroHealth <= 0 || monsterHealth <= 0)
    {
        break;
    }

    round++;
}

if (heroHealth > monsterHealth)
{
    Console.WriteLine("Поздравляем, герой победил!");
}
else if (heroHealth < monsterHealth)
{
    Console.WriteLine("Монстр победил. Попробуйте еще раз.");
}
else
{
    Console.WriteLine("Ничья! Оба герой и монстр погибли.");
}

Console.WriteLine("Игра завершена.");