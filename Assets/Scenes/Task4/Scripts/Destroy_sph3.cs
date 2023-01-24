using UnityEngine;
using UnityEngine.UI;

public class Destroy_sph3 : MonoBehaviour
{
    public Text textScoreGame;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Trig3")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            textScoreGame.text = "—чет игры: " + (ScoreGame.Score_Game += 3).ToString();
            ScoreGame.Score_GameObj++;
        }
        if (other.gameObject.name == "Plane")
        {
            Destroy(gameObject);
            textScoreGame.text = "—чет игры: " + (ScoreGame.Score_Game -= 3).ToString();
            ScoreGame.Score_GameObj++;
        }        
    }
}
