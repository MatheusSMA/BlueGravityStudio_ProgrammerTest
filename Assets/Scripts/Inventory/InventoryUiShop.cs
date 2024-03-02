using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InventoryUiShop : InventoryUIBase
{
    [SerializeField] private bool _isShop;
    [SerializeField] private bool _isCustomer;
    private InventoryBase _otherInventory;
    public event Action OnItemSold;

    public bool IsShop { get => _isShop; set => _isShop = value; }
    public bool IsCustomer { get => _isCustomer; set => _isCustomer = value; }

    public void ItemWasSold()
    {
        OnItemSold?.Invoke();
    }

    public void SetOther(InventoryBase otherInventory)
    {
        _otherInventory = otherInventory;
        UpdateSlots();
    }

    public bool CheckPrice(int value)
    {
        if (_otherInventory == null) return false;

        if (_otherInventory.MoneyBase.CurrentMoney < value) return false;

        return true;
    }

    public void ItemSold(ItemSO itemSold)
    {
        _otherInventory.AddItens(itemSold);
        _otherInventory.MoneyBase.RemoveMoney(itemSold.price);
        _inventory.MoneyBase.AddMoney(itemSold.price);
        _inventory.RemoveItens(itemSold);
        // _otherInventory.OnItemChange();
        ItemWasSold();

    }
}
