using UnityEngine;
using NUnit.Framework;

public class SaveTests
{
    [Test]
    public void SaveRecord_HighScoreIsUpdated_Correctly()
    {
        // Arrange
        float initialHighScore = 100f;
        PlayerPrefs.SetFloat("highScore", initialHighScore);
        GameControl.score = 150f; // Set a higher score

        // Act
        GameControl gameControl = new GameControl();
        gameControl.SaveRecord();

        // Assert
        float updatedHighScore = PlayerPrefs.GetFloat("highScore");
        Assert.AreEqual(updatedHighScore, GameControl.score);
    }

    [Test]
    public void SaveRecord_HighScoreIsNotUpdated_WhenNewScoreIsNotHigher()
    {
        // Arrange
        float initialHighScore = 100f;
        float newScore = 50f;
        PlayerPrefs.SetFloat("highScore", initialHighScore);
        GameControl.score = newScore; // Set a lower score

        // Act
        GameControl gameControl = new GameControl();
        gameControl.SaveRecord();

        // Assert
        float updatedHighScore = PlayerPrefs.GetFloat("highScore");
        Assert.AreEqual(updatedHighScore, initialHighScore);
    }
}
