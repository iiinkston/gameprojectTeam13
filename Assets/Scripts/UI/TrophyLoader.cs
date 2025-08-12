using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrophyLoader : MonoBehaviour
{
    public GameObject trophyUnlock01;
    public GameObject trophyUnlock02;

    public int unlocked01;
    public int unlocked02;

    public int trophyCount;
    public GameObject trophyDisplay;

    void Start()
    {
        unlocked01 = PlayerPrefs.GetInt("Trophy01");
        unlocked02 = PlayerPrefs.GetInt("Trophy02");
        if(unlocked01 == 2)
        {
            trophyUnlock01.SetActive(true);
            trophyCount += 1;
        }
        if (unlocked02 == 2)
        {
            trophyUnlock02.SetActive(true);
            trophyCount += 1;
        }

        trophyDisplay.GetComponent<Text>().text = "" + trophyCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
