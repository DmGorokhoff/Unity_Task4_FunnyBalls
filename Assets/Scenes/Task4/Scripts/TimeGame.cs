using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeGame : MonoBehaviour //—четчик времени игры
{
    [SerializeField] private Text timeGame;
    public static float timer;
    public static string timeGameStr;       
    
    public void Update()
    {
        if (ScoreGame.Score_GameObj < 5)
        {
            timer += Time.deltaTime;
            int seconds = (int)(timer % 60);
            int minutes = (int)(timer / 60) % 60;
            timeGameStr = string.Format($"{minutes} мин. {seconds} сек.");
            timeGame.text = "¬рем€ игры:\n " + timeGameStr;
            ScoreGame.Score_TimeOver = timeGameStr;            
        }            
    }
}
