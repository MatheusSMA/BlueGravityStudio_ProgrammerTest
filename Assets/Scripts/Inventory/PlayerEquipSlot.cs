using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipSlot : InventorySlotBase
{
    private PlayerEquipUi _playerEquipUi;

    public override void Use()
    {
        if (_item == null) return;

        RemoveEquipedItem(_item);
    }

    private void RemoveEquipedItem(ItemSO item)
    {
        switch (item.itemBodyLocation)
        {
            case BodyLocation.Head:
                Player.Instance.PlayerEquipament.SwitchClothes(Player.Instance.PlayerSO.headEquipament);
                break;
            case BodyLocation.Chest:
                Player.Instance.PlayerEquipament.SwitchClothes(Player.Instance.PlayerSO.chestEquipament);
                break;
            case BodyLocation.Hands:
                Player.Instance.PlayerEquipament.SwitchClothes(Player.Instance.PlayerSO.handsEquipament);
                break;
            case BodyLocation.Legs:
                Player.Instance.PlayerEquipament.SwitchClothes(Player.Instance.PlayerSO.legsEquipament);
                break;
        }
    }

    public void SetPlayerEquipUI(PlayerEquipUi playerEquipUI)
    {
        _playerEquipUi = playerEquipUI;
    }
}
