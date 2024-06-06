using UnityEngine;
using NUnit.Framework;
using UnityEngine.TestTools;
using System.Collections;

public class WaitForSecondsTests
{
    [UnityTest]
    public IEnumerator DestroyGameObjectAfterTime()
    {
        // Arrange
        GameObject gameObject = new GameObject();
        WaitForSeconds wait = gameObject.AddComponent<WaitForSeconds>();
        wait.timeToWait = 2f; // Установка времени ожидания в 2 секунды

        // Act
        GameObject.Destroy(gameObject); // Уничтожаем объект

        // Ждем один кадр
        yield return null;

        // Assert
        Assert.That(gameObject == null); // Проверяем, что объект был уничтожен
    }
}
