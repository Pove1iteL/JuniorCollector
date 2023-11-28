using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtn : MonoBehaviour
{
    [SerializeField] private Image _button;
    public void OnButtnClic()
    {
        _button.color = Color.blue;
    }
}
