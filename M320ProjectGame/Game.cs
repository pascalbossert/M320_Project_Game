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