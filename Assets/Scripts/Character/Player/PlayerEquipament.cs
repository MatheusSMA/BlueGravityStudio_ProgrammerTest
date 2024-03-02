using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipament : MonoBehaviour
{

    private ItemSO _currentHeadItem, _currentChestItem, _currentLeftHandItem, _currentRightHandItem, _currentLegsItem;
    [SerializeField] private SpriteRenderer _currentHeadHolder, _currentChestHolder, _currentLeftHandHolder, _currentRightHandHolder, _currentLeftLegHolder, _currentRightLegHolder;

    public ItemSO CurrentHeadClothes { get => _currentHeadItem; }
    public ItemSO CurrentChestClothes { get => _currentChestItem; }
    public ItemSO CurrentLeftHandClothes { get => _currentLeftHandItem; }
    public ItemSO CurrentRightHandItem { get => _currentRightHandItem; }
    public ItemSO CurrentLegsClothes { get => _currentLegsItem; }

    public event Action OnItemChange;

    public void ItemChanged()
    {
        OnItemChange?.Invoke();
    }

    public void InitializePlayerClothes()
    {
        SwitchClothes(Player.Instance.PlayerSO.headEquipament);
        SwitchClothes(Player.Instance.PlayerSO.chestEquipament);
        SwitchClothes(Player.Instance.PlayerSO.lefthandEquipament);
        SwitchClothes(Player.Instance.PlayerSO.righthandEquipament);
        SwitchClothes(Player.Instance.PlayerSO.legsEquipament);
    }

    public void SwitchClothes(ItemSO item)
    {
        switch (item?.itemBodyLocation)
        {
            case BodyLocation.Head:
                ChangeClothesHelper(ref _currentHeadItem, item, Player.Instance.PlayerSO.headEquipament);
                _currentHeadHolder.sprite = _currentHeadItem.icon;
                break;
            case BodyLocation.Chest:
                ChangeClothesHelper(ref _currentChestItem, item, Player.Instance.PlayerSO.chestEquipament);
                _currentChestHolder.sprite = _currentChestItem.icon;
                break;
            case BodyLocation.LeftHand:
                ChangeClothesHelper(ref _currentLeftHandItem, item, Player.Instance.PlayerSO.lefthandEquipament);
                _currentLeftHandHolder.sprite = _currentLeftHandItem.icon;
                break;
            case BodyLocation.RightHand:
                ChangeClothesHelper(ref _currentRightHandItem, item, Player.Instance.PlayerSO.righthandEquipament);
                _currentRightHandHolder.sprite = _currentRightHandItem.icon;
                break;
            case BodyLocation.Legs:
                ChangeClothesHelper(ref _currentLegsItem, item, Player.Instance.PlayerSO.legsEquipament);
                _currentLeftLegHolder.sprite = _currentLegsItem.icon;
                _currentRightLegHolder.sprite = _currentLegsItem.icon;
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
