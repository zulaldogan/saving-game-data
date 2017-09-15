using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private string key = "MyFirstKey";
    public int value;

    void Start()
    {
        PlayerPrefs.SetInt(key,value);
       
        Debug.Log(PlayerPrefs.GetInt(key).ToString());
    }
}
