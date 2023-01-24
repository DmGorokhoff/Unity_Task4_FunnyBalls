using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Btn_MainMenu : MonoBehaviour
{
    public Image imgGOver;
    public void TransitionMainMenu()
    {
        SceneManager.LoadScene(0);        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
