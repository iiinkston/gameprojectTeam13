using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRandomDestination : MonoBehaviour {

    public int genPos;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            genPos = Random.Range(1, 5);

            if (genPos == 4)
            {
                this.gameObject.transform.position = new Vector3(93, 16, 226);
            }
            if (genPos == 3)
            {
                this.gameObject.transform.position = new Vector3(150, 16, 249);
            }
            if (genPos == 2)
            {
                this.gameObject.transform.position = new Vector3(177, 16, 2266);
            }
            if (genPos == 1)
            {
                this.gameObject.transform.position = new Vector3(177, 16, 127);
            }

        }
    }
}
