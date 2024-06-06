using UnityEngine;
using NUnit.Framework;

public class TestScore
{
    [Test]
    public void AddScore_IncreasesScoreByGivenAmount()
    {
        // Arrange
        float initialScore = GameControl.score;
        float amountToAdd = 100;

        // Act
        GameControl.addScore(amountToAdd);

        // Assert
        Assert.AreEqual(initialScore + amountToAdd, GameControl.score);
    }
}
