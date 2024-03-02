using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipament : MonoBehaviour
{

    private ItemSO _currentBodyClothes;
    private ItemSO _currentHeadClothes;
    private ItemSO _currentTorsoClothes;
    private ItemSO _currentLegsClothes;

    public ItemSO CurrentBodyClothes { get => _currentBodyClothes; }
    public ItemSO CurrentHeadClothes { get => _currentHeadClothes; }
    public ItemSO CurrentTorsoClothes { get => _currentTorsoClothes; }
    public ItemSO CurrentLegsClothes { get => _currentLegsClothes; }

    public event Action OnItemChange;

    public void ItemChanged()
    {
        OnItemChange?.Invoke();
    }

    public void InitializePlayerClothes()
    {
        // SwitchClothes(Player.Instance.PlayerSO.headEquipament);
        // SwitchClothes(Player.Instance.PlayerSO.chestEquipament);
        // SwitchClothes(Player.Instance.PlayerSO.handsEquipament);
        // SwitchClothes(Player.Instance.PlayerSO.handsEquipament);
    }

    public void SwitchClothes(ItemSO item)
    {
        switch (item.itemBodyLocation)
        {
            case BodyLocation.Head:
                ChangeClothesHelper(ref _currentBodyClothes, item, Player.Instance.PlayerSO.headEquipament);
                break;
            case BodyLocation.Chest:
                ChangeClothesHelper(ref _currentHeadClothes, item, Player.Instance.PlayerSO.chestEquipament);
                break;
            case BodyLocation.Hands:
                ChangeClothesHelper(ref _currentTorsoClothes, item, Player.Instance.PlayerSO.handsEquipament);
                break;
            case BodyLocation.Legs:
                ChangeClothesHelper(ref _currentLegsClothes, item, Player.Instance.PlayerSO.legsEquipament);
                break;
        }
    }

    private void ChangeClothesHelper(ref ItemSO currentClothes, ItemSO newClothes, ItemSO baseClothes)
    {
        if (currentClothes != null) Player.Instance.PlayerInventory.AddItens(currentClothes);

        currentClothes = newClothes;
        ItemChanged();
    }

}
