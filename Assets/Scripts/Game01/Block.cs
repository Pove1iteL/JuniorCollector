using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Block : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Rigidbody2D _rigidbody2D;
    [SerializeField] float _jumpForse;

    public void OnPointerClick(PointerEventData eventData)
    {
        _rigidbody2D.AddForce(Vector2.up * _jumpForse);
    }
}
