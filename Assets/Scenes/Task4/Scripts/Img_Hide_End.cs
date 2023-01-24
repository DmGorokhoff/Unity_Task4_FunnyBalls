using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Img_Hide_End : MonoBehaviour
{
    public Image imgEnd;
    // Start is called before the first frame update
    public void Start()
    {
        imgEnd.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
