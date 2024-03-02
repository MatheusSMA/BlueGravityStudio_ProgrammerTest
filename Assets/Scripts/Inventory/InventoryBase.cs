using System;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBase : MonoBehaviour
{
    [SerializeField] private MoneyBase _moneyBase;
    [SerializeField] private List<ItemSO> _itens = new List<ItemSO>();
    private int _maxInventorySlot;

    public MoneyBase MoneyBase { get => _moneyBase; }
    public List<ItemSO> Itens { get => _itens; }
    public int MaxInventorySlot { get => _maxInventorySlot; }
    public event Action OnItemChange;

    public void InitializeInventory(int maxSlot, int initialMoney, List<ItemSO> itens = null)
    {
        _maxInventorySlot = maxSlot;
        _moneyBase.SetStartMoney(initialMoney);

        if (itens != null)
            foreach (ItemSO item in itens)
                AddItens(item);
    }
    public void AddItens(ItemSO item)
    {
        if (_itens.Count > _maxInventorySlot)
        {
            _itens.Add(item);
        }
    }
    public void RemoveItens(ItemSO item)
    {
        _itens.Remove(item);
    }
}