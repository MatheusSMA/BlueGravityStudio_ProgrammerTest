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
                _playerEquipUi.Player.PlayerEquipament.SwitchClothes(_playerEquipUi.Player.PlayerSO.headEquipament);
                break;
            case BodyLocation.Chest:
                _playerEquipUi.Player.PlayerEquipament.SwitchClothes(_playerEquipUi.Player.PlayerSO.chestEquipament);
                break;
            case BodyLocation.Hands:
                _playerEquipUi.Player.PlayerEquipament.SwitchClothes(_playerEquipUi.Player.PlayerSO.handsEquipament);
                break;
            case BodyLocation.Legs:
                _playerEquipUi.Player.PlayerEquipament.SwitchClothes(_playerEquipUi.Player.PlayerSO.legsEquipament);
                break;
        }
    }

    public void SetPlayerEquipUI(PlayerEquipUi peUI)
    {
        _playerEquipUi = peUI;
    }
}
