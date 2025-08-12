using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M001 : MonoBehaviour
{
    public GameObject miniMapLoc;
    public GameObject missionStartPoint;
    public GameObject ourPhone;
    public GameObject sentMessage;
    public AudioSource phoneFX;
    public GameObject tonyB;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(MissionBegin());
    }


    IEnumerator MissionBegin()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        miniMapLoc.SetActive(false);
        ourPhone.SetActive(true);
        phoneFX.Play();
        tonyB.SetActive(true);
        yield return new WaitForSeconds(3);
        sentMessage.SetActive(true);
        yield return new WaitForSeconds(2);
        ourPhone.SetActive(false);
        missionStartPoint.SetActive(false);
    }
}
