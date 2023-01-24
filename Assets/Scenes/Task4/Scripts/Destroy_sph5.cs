using UnityEngine;
using UnityEngine.UI;

public class Destroy_sph5 : MonoBehaviour
{
    public Text textScoreGame;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Trig5") 
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            textScoreGame.text = "—чет игры: " + (ScoreGame.Score_Game += 5).ToString();
            ScoreGame.Score_GameObj++;
        }
        if (other.gameObject.name == "Plane")
        {
            Destroy(gameObject);
            textScoreGame.text = "—чет игры: " + (ScoreGame.Score_Game -= 5).ToString();
            ScoreGame.Score_GameObj++;
        } 
    }
}
