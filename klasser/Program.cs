
List<Enemy> enemies = [];

for (int i = 0; i < 100; i++)
{
    enemies.Add();
}

Enemy e1 = new();
Hero h1 = new();

e1.Name = "Martin";
e1.Hp = 3;

h1.Hp -= e1.Attack();

Console.ReadLine();