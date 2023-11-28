using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulInstantiateTwist : MonoBehaviour
{
    public GameObject CapsulPref;
    public int Count;
    public float Radian;

    private void Start()
    {
        float angle = 360 / Count;

        for (int i = 0; i < Count; i++)
        {
            GameObject capsul = Instantiate(CapsulPref, new Vector3(-19, -2, 0), Quaternion.identity);

            Transform newPosCapsu = capsul.GetComponent<Transform>();

            newPosCapsu.position = new Vector3(Radian * Mathf.Cos(angle * (i + 1) * Mathf.Deg2Rad) -19, Radian * Mathf.Sin(angle * (i + 1) * Mathf.Deg2Rad) -2,0);
            
        }
    }

}
