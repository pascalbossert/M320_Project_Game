namespace M320_Project_Game;

public class Enemy : Character
{
    public Enemy(string name, int health) : base(name, health) { }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        Console.WriteLine($"{Name} took {damage} damage!");
    }
}