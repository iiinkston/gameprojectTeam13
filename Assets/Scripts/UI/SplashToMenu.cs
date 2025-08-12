using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(ProceedingToMenu());
    }

    IEnumerator ProceedingToMenu()
    {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene(0);
    }

}
