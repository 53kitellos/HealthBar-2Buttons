using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    private int _currentHealth;
    private int _zeroLife = 0;

    public event UnityAction<int,int> HealthChanged;

    private void Start()
    {
        _currentHealth = _health;
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
        _currentHealth = Mathf.Clamp(_currentHealth += value, _zeroLife, _health);
        HealthChanged?.Invoke(_currentHealth, _health);
    }
}