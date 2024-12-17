namespace M320_Project_Game;

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