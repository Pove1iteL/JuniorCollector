using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliteCircle : MonoBehaviour
{


    private void Start()
    {
        GameObject circl1 = GameObject.Find("Circle 1");
        Destroy(circl1, 1);

        GameObject[] circles = GameObject.FindGameObjectsWithTag("CircleToDelite");

        foreach (GameObject circl in circles)
        {
            circl.GetComponent<SpriteRenderer>().color = Color.blue;
            Destroy(circl, 2);
        }
        
    }


}
