using System.Collections;
using UnityEngine;

public class Signaling : MonoBehaviour
{
    [SerializeField] protected AudioSource Alarm;
    [SerializeField] protected float Speed;

    private float _fade = 0.01f;

    private void Awake()
    {
        Alarm.volume = 0;
    }

    protected IEnumerator SoundFading()
    {
        var waitForSeconds = new WaitForSeconds(_fade);

        while (Alarm.volume > 0)
        {
            Alarm.volume = Mathf.MoveTowards(Alarm.volume, 0, Speed * Time.deltaTime);

            yield return waitForSeconds;
        }

        Alarm.Stop();
    }

    protected IEnumerator SoundIncrease()
    {
        var waitForSeconds = new WaitForSeconds(_fade);

        while (Alarm.volume < 1)
        {
            Alarm.volume = Mathf.MoveTowards(Alarm.volume, 1, Speed * Time.deltaTime);

            yield return waitForSeconds;
        }
    }
}
