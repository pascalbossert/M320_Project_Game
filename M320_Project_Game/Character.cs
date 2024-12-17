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