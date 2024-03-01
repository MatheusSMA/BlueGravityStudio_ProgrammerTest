using System.Collections.Generic;
using UnityEngine;

public class InventoryBase : MonoBehaviour
{
    private int _maxInventorySlot;
    private List<ItemSO> _itensSO = new List<ItemSO>();

    private void InitializeInventory(List<ItemSO> itens, int maxSlot)
    {
        _maxInventorySlot = maxSlot;

        if (_itensSO != null)
        {
            foreach (ItemSO item in itens)
            {
                AddItens();
            }
        }
    }
    public void AddItens()
    {

    }
    public void RemoveItens()
    {

    }
}