using NUnit.Framework;

[TestFixture]
public class PlayerTests
{
    [Test]
    public void Attack_ReducesEnemyHealth()
    {
        Player player = new Player("TestHero", 100, 20);
        Enemy enemy = new Enemy("TestEnemy", 50);

        player.Attack(enemy);

        Assert.That(enemy.Health, Is.EqualTo(30));
    }
}