using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSave : MonoBehaviour
{

    void Start()
    {
        PlayerPrefs.SetInt("SavePosition", 1);
    }


    void Update()
    {
        
    }
}
