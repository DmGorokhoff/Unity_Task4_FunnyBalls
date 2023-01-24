using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour //Запуск игры и перезагрузка сцены
{
    [SerializeField] private Image imgRules;
    private bool stay = false;
    public void Play()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(1);
        ScoreGame.Score_GameObj = 0;
        ScoreGame.Score_TimeOver = "0";
        ScoreGame.Score_Game = 0;
        TimeGame.timer = 0;
        TimeGame.timeGameStr = "";
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void RulesOfTheGame()
    {        
        if (stay == false)
            stay = true;
        else
            stay = false;

        imgRules.gameObject.SetActive(stay);        
    }
   
}
