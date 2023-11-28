using UnityEngine;
using DG.Tweening;

public class ScaleTo : MonoBehaviour
{
    [SerializeField] private float _speed = 3;
    [SerializeField] private float _neededScale = 3;

    private void Start()
    {
        transform.DOScale(new Vector3(_neededScale, _neededScale, _neededScale), _speed).SetLoops(-1, LoopType.Yoyo);
    }
}
