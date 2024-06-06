using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour {

    public float GameSeconds;
    public float GameMinutes;
    string stringSecond;
    string stringMinutes;
    public TextMesh TextTime;

    public void Update() {
        GameSeconds += Time.deltaTime;

        // Разделяем секунды на минуты и секунды
        GameMinutes = Mathf.Floor(GameSeconds / 60);
        float secondsLeft = GameSeconds % 60;

        // Форматируем строку времени
        stringSecond = secondsLeft.ToString("00"); 
        stringMinutes = GameMinutes.ToString("00");

        TextTime.text = "Время " + stringMinutes + ":" + stringSecond;
    }
}
