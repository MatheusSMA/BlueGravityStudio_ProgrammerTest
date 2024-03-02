using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUiPlayer : InventoryUIBase
{
    public void EquipItem(ItemSO itemToEquip)
    {
        Player.Instance.PlayerEquipament.SwitchClothes(itemToEquip);
        _inventory.RemoveItens(itemToEquip);
    }
}
