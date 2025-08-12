using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CredToMenu : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(ProceedingToMenu());
    }

    IEnumerator ProceedingToMenu()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(0);
    }

}
