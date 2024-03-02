using System;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public event Action OnPlayerInventoryOpen;
    public event Action OnPlayerInventoryClose;
    public event Action OnShopInventoryOpen;
    public event Action OnShopInventoryClose;

    private bool _inventoryIsOpen;
    public void PlayerInventoryOpen()
    {
        OnPlayerInventoryOpen?.Invoke();
        _inventoryIsOpen = true;
    }

    public void PlayerInventoryClose()
    {
        OnPlayerInventoryClose?.Invoke();
        _inventoryIsOpen = false;
    }
    public void ShopInventoryOpen()
    {
        OnShopInventoryOpen?.Invoke();
        _inventoryIsOpen = true;
    }

    public void ShopInventoryClose()
    {
        OnShopInventoryClose?.Invoke();
        _inventoryIsOpen = false;
    }
}