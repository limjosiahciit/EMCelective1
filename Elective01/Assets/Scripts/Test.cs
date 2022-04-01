using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Awake()
    {
        Time.timeScale = 0;    
    }

    public void OnClick()
    {
        Time.timeScale = 1;
    }
}
