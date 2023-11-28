using UnityEngine;
using DG.Tweening;

public class ColorChangerDOTW : MonoBehaviour
{
    [SerializeField] private float _speed = 3;
    [SerializeField] private Color _targetColor;

    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _spriteRenderer.DOColor(_targetColor,_speed).SetLoops(-1, LoopType.Yoyo);
    }
}
