using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth;

    private int _currentHealth;
    private int _zeroHealth = 0;

    public event UnityAction<int,int> HealthChanged;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void Heal(int value)
    {
        ApplyValueChange(value);
    }

    public void Damage(int value)
    {
        ApplyValueChange(-value);
    }

    private void ApplyValueChange(int value)
    {
        _currentHealth = Mathf.Clamp(_currentHealth += value, _zeroHealth, _maxHealth);
        HealthChanged?.Invoke(_currentHealth, _maxHealth);
    }
}