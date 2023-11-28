using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineColorChange : MonoBehaviour
{
    private SpriteRenderer Target;
    [SerializeField] private float _duration;
    [SerializeField] private Color _targetColor;
    private Color _startColor;

    private float runningTime;

    void Start()
    {
        Target = GetComponent<SpriteRenderer>();
        _startColor = Target.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (runningTime <= _duration)
        {
            runningTime += Time.deltaTime;

            float normalizeRunnindTime = runningTime / _duration;

            Target.color = Color.Lerp(_startColor,_targetColor, normalizeRunnindTime);
        }

    }
}
