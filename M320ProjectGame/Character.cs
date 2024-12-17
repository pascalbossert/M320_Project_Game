public class Character
{
    public string Name { get; }
    public int Health { get; set; }  // Public health property

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public virtual void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Console.WriteLine($"{Name} defeated!");
        }
    }
}