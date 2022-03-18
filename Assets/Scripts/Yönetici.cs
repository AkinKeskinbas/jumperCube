using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Yönetici : MonoBehaviour
{
    public Text skorText;
    public static float skor;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skorText.text = skor.ToString();
    }
}
