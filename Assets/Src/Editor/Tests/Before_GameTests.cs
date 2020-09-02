using Assets.Src.Runtime.Before.Characters;
using Assets.Src.Runtime.Common;
using NUnit.Framework;
using UnityEngine;

public class Before_GameTest
{
    [Test]
    public void Characters_Level1_DealDamage()
    {
        // Arrange
        var archer = new GameObject("Archer").AddComponent<Archer>();
        var archerEnemy = new GameObject("ArcherEnemy").AddComponent<Enemy>();
        var archerEnemyHealthBeforeDamage = archerEnemy.Health;

        var paladin = new GameObject("Paladin").AddComponent<Paladin>();
        var paladinEnemy = new GameObject("PaladinEnemy").AddComponent<Enemy>();
        var paladinEnemyEnemyHealthBeforeDamage = paladinEnemy.Health;

        var mage = new GameObject("Mage").AddComponent<Mage>();
        var mageEnemy = new GameObject("MageEnemy").AddComponent<Enemy>();
        var mageEnemyEnemyHealthBeforeDamage = mageEnemy.Health;

        // Act
        archer.Attack(archerEnemy);
        paladin.Attack(paladinEnemy);
        mage.Attack(mageEnemy);

        // Assert
        Assert.AreNotEqual(archerEnemyHealthBeforeDamage, archerEnemy.Health);
        Debug.Log($"ArcherEnemy health before: {archerEnemyHealthBeforeDamage}, after damage received: {archerEnemy.Health}");

        Assert.AreNotEqual(paladinEnemyEnemyHealthBeforeDamage, paladinEnemy.Health);
        Debug.Log($"PaladinEnemy health before: {paladinEnemyEnemyHealthBeforeDamage}, after damage received: {paladinEnemy.Health}");

        Assert.AreNotEqual(mageEnemyEnemyHealthBeforeDamage, mageEnemy.Health);
        Debug.Log($"MageEnemy health before: {mageEnemyEnemyHealthBeforeDamage}, after damage received: {mageEnemy.Health}");
    }

    [Test]
    public void Characters_Level2_DealDamage()
    {
        // Arrange
        var archer = new GameObject("Archer").AddComponent<Archer>();
        var archerEnemy = new GameObject("ArcherEnemy").AddComponent<Enemy>();
        var archerEnemyHealthBeforeDamage = archerEnemy.Health;

        var paladin = new GameObject("Paladin").AddComponent<Paladin>();
        var paladinEnemy = new GameObject("PaladinEnemy").AddComponent<Enemy>();
        var paladinEnemyEnemyHealthBeforeDamage = paladinEnemy.Health;

        var mage = new GameObject("Mage").AddComponent<Mage>();
        var mageEnemy = new GameObject("MageEnemy").AddComponent<Enemy>();
        var mageEnemyEnemyHealthBeforeDamage = mageEnemy.Health;

        // Act
        archer.IncreaseLevel();
        archer.Attack(archerEnemy);

        paladin.IncreaseLevel();
        paladin.Attack(paladinEnemy);

        mage.IncreaseLevel();
        mage.Attack(mageEnemy);

        // Assert
        Assert.AreNotEqual(archerEnemyHealthBeforeDamage, archerEnemy.Health);
        Debug.Log($"ArcherEnemy health before: {archerEnemyHealthBeforeDamage}, after damage received: {archerEnemy.Health}");

        Assert.AreNotEqual(paladinEnemyEnemyHealthBeforeDamage, paladinEnemy.Health);
        Debug.Log($"PaladinEnemy health before: {paladinEnemyEnemyHealthBeforeDamage}, after damage received: {paladinEnemy.Health}");

        Assert.AreNotEqual(mageEnemyEnemyHealthBeforeDamage, mageEnemy.Health);
        Debug.Log($"MageEnemy health before: {mageEnemyEnemyHealthBeforeDamage}, after damage received: {mageEnemy.Health}");
    }
}