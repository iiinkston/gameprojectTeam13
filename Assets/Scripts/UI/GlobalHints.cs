using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalHints : MonoBehaviour
{
    public GameObject hintText;
    public static int hintNumber;

    void Update()
    {
        if (hintNumber == 1)
        {
            hintNumber = 0;
            hintText.GetComponent<Text>().text = "Mission start points can be found by searching for the glowing orange points on your map.";
            hintText.SetActive(false);
            hintText.SetActive(true);
        }
        if (hintNumber == 2)
        {
            hintNumber = 0;
            hintText.GetComponent<Text>().text = "Press W to drive forward and press S to reverse the vehicle.";
            hintText.SetActive(false);
            hintText.SetActive(true);
        }
    }

}
