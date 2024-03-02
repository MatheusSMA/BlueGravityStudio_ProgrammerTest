using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

public class MoneyBase : MonoBehaviour
{
    private float _currentMoney;
    public float CurrentMoney { get => _currentMoney; }
    public UnityEvent _onMoneyChange;

    public void SetStartMoney(float moneyValue)
    {
        _currentMoney = moneyValue;
        _onMoneyChange?.Invoke();
    }
    public void AddMoney(float amount)
    {
        _currentMoney += amount;
        _onMoneyChange?.Invoke();

    }
    public void RemoveMoney(float amount)
    {
        if (_currentMoney <= 0) return;
        _currentMoney -= amount;
        _onMoneyChange?.Invoke();
    }
}