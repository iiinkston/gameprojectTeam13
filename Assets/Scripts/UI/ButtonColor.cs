using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonColor : MonoBehaviour
{
    public GameObject lightText;

    public void TurnOff()
    {
        //mouse enters button area
        lightText.SetActive(false);
    }

    public void TurnOn()
    {
        //mouse leaves button area
        lightText.SetActive(true);
    }

}
