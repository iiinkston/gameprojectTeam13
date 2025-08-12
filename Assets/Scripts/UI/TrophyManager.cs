using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrophyManager : MonoBehaviour
{
    public GameObject trophy01;
    public GameObject trophy02;



    public AudioSource trophyUnlock;
    public static int trophyUnlocker01;
    public static int trophyUnlocker02;

    public int trophyStatus01;
    public int trophyStatus02;

    public int trophyCount;

    void Start()
    {
        trophyStatus01 = PlayerPrefs.GetInt("Trophy01");
        trophyStatus02 = PlayerPrefs.GetInt("Trophy02");
    }


    void Update()
    {
        if (trophyUnlocker01 == 1 && trophyStatus01 == 0)
        {
            PlayerPrefs.SetInt("Trophy01", 2);
            trophyUnlocker01 = 2;
            trophyCount = 1;
            StartCoroutine(UnlockingTrophy());
        }
        if (trophyUnlocker02 == 1 && trophyStatus02 == 0)
        {
            PlayerPrefs.SetInt("Trophy02", 2);
            trophyUnlocker02 = 2;
            trophyCount = 2;
            trophyStatus02 = 2;
            StartCoroutine(UnlockingTrophy());
        }
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    IEnumerator UnlockingTrophy()
    {
        trophyUnlock.Play();
        if (trophyCount == 1)
        {
            trophy01.SetActive(true);
            yield return new WaitForSeconds(5);
            trophy01.SetActive(false);
        }
        if (trophyCount == 2)
        {
            trophy02.SetActive(true);
            yield return new WaitForSeconds(5);
            trophy02.SetActive(false);
        }
    }
}
