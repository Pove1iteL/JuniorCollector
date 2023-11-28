using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
    [SerializeField] private float _speed = 3;
    [SerializeField] private Vector2 _targetPosition;

    private void Start()
    {
        transform.DOMove(_targetPosition,_speed).SetLoops(-1,LoopType.Yoyo);
    }
}
