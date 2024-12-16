using System;
using System.Collections.Generic;

public class Game
{
    private List<Player> players;
    private List<Enemy> enemies;

    public Game()
    {
        players = new List<Player>();
        enemies = new List<Enemy>();
    }

    public void AddPlayer(Player player)
    {
        players.Add(player);
    }

    public void AddEnemy(Enemy enemy)
    {
        enemies.Add(enemy);
    }

    public void Start()
    {
        Console.WriteLine("Game started!");
        foreach (var player in players)
        {
            foreach (var enemy in enemies)
            {
                player.Attack(enemy);
            }
        }
    }
}

public class Character
{
    public string Name { get; }
    protected int health;

    public Character(string name, int health)
    {
        Name = name;
        this.health = health;
    }

    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Console.WriteLine($"{Name} defeated!");
        }
    }
}

public class Player : Character
{
    private int attackPower;

    public Player(string name, int health, int attackPower) : base(name, health)
    {
        this.attackPower = attackPower;
    }

    public void Attack(Enemy enemy)
    {
        Console.WriteLine($"{Name} attacks {enemy.Name}!");
        enemy.TakeDamage(attackPower);
    }
}

public class Enemy : Character
{
    public Enemy(string name, int health) : base(name, health) { }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        Console.WriteLine($"{Name} took {damage} damage!");
    }
}

public class Program
{
    public static void Main()
    {
        Game game = new Game();
        game.AddPlayer(new Player("Hero", 100, 20));
        game.AddEnemy(new Enemy("Goblin", 50));
        game.AddEnemy(new Enemy("Orc", 80));
        game.Start();
    }
}