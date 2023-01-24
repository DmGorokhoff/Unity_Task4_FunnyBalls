using UnityEngine;
using UnityEngine.UI;

public class ScoreGame : MonoBehaviour //��������� ����������� ����
{  
    [SerializeField] private Image imgGameOver;
    [SerializeField] private Text scoreTime;
    [SerializeField] private Text scoreGame;
    public static int Score_Game { get; set; }
    public static int Score_GameObj { get; set; }
    public static string Score_TimeOver { get; set; }
    public void Result()
    {        
        scoreGame.text = "���� ��������!\n " + "������� �����: " + Score_Game.ToString();
        scoreTime.text = "�������� �����: " + Score_TimeOver.ToString();
        imgGameOver.gameObject.SetActive(true);        
    }    
}
