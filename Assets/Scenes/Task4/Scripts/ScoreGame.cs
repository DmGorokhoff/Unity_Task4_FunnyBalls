using UnityEngine;
using UnityEngine.UI;

public class ScoreGame : MonoBehaviour //Отражение результатов игры
{  
    [SerializeField] private Image imgGameOver;
    [SerializeField] private Text scoreTime;
    [SerializeField] private Text scoreGame;
    public static int Score_Game { get; set; }
    public static int Score_GameObj { get; set; }
    public static string Score_TimeOver { get; set; }
    public void Result()
    {        
        scoreGame.text = "Игра окончена!\n " + "Набрано очков: " + Score_Game.ToString();
        scoreTime.text = "Итоговое время: " + Score_TimeOver.ToString();
        imgGameOver.gameObject.SetActive(true);        
    }    
}
