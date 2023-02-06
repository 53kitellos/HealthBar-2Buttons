using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ChangeValueButton : MonoBehaviour
{
    [SerializeField] private Button _valueChangeButton;
    [SerializeField] private int _value;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _valueChangeButton.onClick.AddListener(OnButtonClick);
    }

    private void OnDisable()
    {
        _valueChangeButton.onClick.RemoveListener(OnButtonClick);
    }

    public void OnButtonClick()
    {
        _player.ApplyValueChange(_value);
    }
}