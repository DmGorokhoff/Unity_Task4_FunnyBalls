using UnityEngine;
using UnityEngine.UI;

public class Destroy_sph1 : MonoBehaviour
{    
    [SerializeField] private Text textScoreGame;     

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Trig1")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            textScoreGame.text = "—чет игры: "+ (ScoreGame.Score_Game += 1).ToString();
            ScoreGame.Score_GameObj++;            
        }
        if (other.gameObject.name == "Plane")
        {
            Destroy(gameObject);            
            textScoreGame.text = "—чет игры: " + (ScoreGame.Score_Game -= 1).ToString();
            ScoreGame.Score_GameObj++;            
        }        
    }
}
