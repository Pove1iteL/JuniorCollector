using UnityEngine;
using DG.Tweening;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _speed = 3;
    [SerializeField] private Vector3 _rotate;
    private void Start()
    {
        transform.DORotate(_rotate, _speed,RotateMode.FastBeyond360).SetLoops(-1,LoopType.Restart);
    }
}
