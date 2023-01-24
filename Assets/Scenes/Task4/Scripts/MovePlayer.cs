using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MovePlayer : MonoBehaviour // ”правление игровым м€чом
{
    [SerializeField] private Text scoreGame;
    public ScoreGame ScoreGame;
    public float speed, thrust;
    private Rigidbody _rb;

    void ShowResult()
    {        
        if (ScoreGame.Score_GameObj == 5)
            ScoreGame.Result();        
    }
        
    void Start()
    {        
        scoreGame.text = "Cчет игры: " + ScoreGame.Score_Game.ToString();
     
        if (ScoreGame.Score_GameObj< 5)
        {
            print("Start Cor");
            StartCoroutine("corGameOver");
        }        
    }
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
        
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;
        _rb.velocity = transform.TransformDirection(new Vector3(h, _rb.velocity.y, v));        
    }
    private void OnCollisionEnter(Collision collision)
    {        
        _rb.AddForce(new Vector3(1, 0, 0) * thrust);     
    }

    IEnumerator corGameOver()
    {
        int count = 0;        
        while (true)
        {
            if (ScoreGame.Score_GameObj == 5)
            {
                ShowResult();                
                StopCoroutine("corGameOver");                
                break;
            }            
            yield return new WaitForSeconds(1f);
            count++;
        }
    }
}
