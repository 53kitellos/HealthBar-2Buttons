using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Slider _slider;
    [SerializeField] private Player _player;

    public void OnValueChanged(int value, int maxValue)
    {
        _slider.DOValue((float)value / maxValue, 0.7f);
    }

    private void OnEnable()
    {
        _player.HealthChanged += OnValueChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnValueChanged;
    }
}