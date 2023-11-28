using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : Signaling
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Alarm.Play();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        StartCoroutine(SoundIncrease());
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        StartCoroutine(SoundFading());
    }
}
