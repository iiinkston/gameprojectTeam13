using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public int playerSavePoint;
    public AudioSource buttonSelect;
    public GameObject fadeOut;
    public GameObject buttonBlocker;

    void Start()
    {
        playerSavePoint = PlayerPrefs.GetInt("SavePosition");
    }


    void Update()
    {
        
    }

    public void NewGame()
    {
        StartCoroutine(NewStart());
    }

    IEnumerator NewStart()
    {
        buttonBlocker.SetActive(true);
        buttonSelect.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        if (playerSavePoint == 1)
        {
            StartCoroutine(LoadStart());

        }
    }

    IEnumerator LoadStart()
    {
        buttonBlocker.SetActive(true);
        buttonSelect.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }

    public void TrophyMenu()
    {
        StartCoroutine(TrophyStart());
    }

    IEnumerator TrophyStart()
    {
        buttonBlocker.SetActive(true);
        buttonSelect.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }

    public void Credits()
    {
        StartCoroutine(CredStart());
    }

    IEnumerator CredStart()
    {
        buttonBlocker.SetActive(true);
        buttonSelect.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(4);
    }
}
