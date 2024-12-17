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