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
   
    public void ApplyValueChange(int value)
    {
        _currentHealth += value;

        if (_currentHealth < _zeroLife)
        {
            _currentHealth = _zeroLife;
        }
        else if (_currentHealth > _health) 
        {
            _currentHealth = _health;
        }
        
        HealthChanged?.Invoke(_currentHealth, _health);
    }
}