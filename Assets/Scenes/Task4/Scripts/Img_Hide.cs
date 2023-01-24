using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Img_Hide : MonoBehaviour
{
    public Image imgRules;
    // Start is called before the first frame update
    void Start()
    {
        imgRules.gameObject.SetActive(false); //Скрывает правила игры.      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HideImg()
    {
        imgRules.gameObject.SetActive(false);
    }
}
