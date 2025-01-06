namespace M320_Project_Game;

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
   
       while (enemies.Count > 0)
       {
           foreach (var player in players)
           {
               foreach (var enemy in enemies.ToList())
               {
                   player.Attack(enemy);
   
                   if (enemy.Health <= 0)
                   {
                       Console.WriteLine($"{enemy.Name} has been defeated!");
                       enemies.Remove(enemy);
                   }
               }
           }
       }
   
       Console.WriteLine("Victory! All enemies have been defeated!");
   }
}