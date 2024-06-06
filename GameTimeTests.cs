using UnityEngine;
using NUnit.Framework;

public class GameTimeTests
{
    [Test]
    public void TimeTextIsCorrectlyFormatted()
    {
        // Arrange
        GameObject gameObject = new GameObject();
        GameTime gameTime = gameObject.AddComponent<GameTime>();

        // Инициализируем все необходимые компоненты объекта GameTime
        gameTime.TextTime = gameObject.AddComponent<TextMesh>(); // Пример инициализации TextTime

        // Act
        gameTime.GameSeconds = 65; // Устанавливаем время в 65 секунд
        gameTime.GameMinutes = 1; // Устанавливаем минуты в 1

        gameTime.Update(); // Вызываем метод Update

        // Assert
        string expectedTimeString = "Время 01:05"; // Ожидаемая строка времени

        Assert.AreEqual(expectedTimeString, gameTime.TextTime.text); // Проверяем, что текст времени соответствует ожидаемому значению
    }
}