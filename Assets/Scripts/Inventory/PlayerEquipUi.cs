using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerEquipUi : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private PlayerEquipSlot _headSlot;
    [SerializeField] private PlayerEquipSlot _bodySlot;
    [SerializeField] private PlayerEquipSlot _leftHandSlot;
    [SerializeField] private PlayerEquipSlot _righthandSlot;
    [SerializeField] private PlayerEquipSlot _legsSlot;
    [SerializeField] protected TextMeshProUGUI _panelNameTxt;

    [Header("Parameters")]
    [SerializeField] protected string _panelName;

    private void Awake()
    {
        _panelNameTxt.text = _panelName;
        _bodySlot.SetPlayerEquipUI(this);
        _headSlot.SetPlayerEquipUI(this);
        _leftHandSlot.SetPlayerEquipUI(this);
        _righthandSlot.SetPlayerEquipUI(this);
        _legsSlot.SetPlayerEquipUI(this);
    }

    private void OnEnable()
    {
        Player.Instance.PlayerEquipament.OnItemChange += UpdateEquipSlots;
        UpdateEquipSlots();
    }

    private void OnDisable()
    {
        Player.Instance.PlayerEquipament.OnItemChange -= UpdateEquipSlots;
    }

    private void UpdateEquipSlots()
    {
        UpdateEquipSlotsAux(Player.Instance.PlayerEquipament.CurrentChestClothes, _bodySlot);
        UpdateEquipSlotsAux(Player.Instance.PlayerEquipament.CurrentHeadClothes, _headSlot);
        UpdateEquipSlotsAux(Player.Instance.PlayerEquipament.CurrentLeftHandClothes, _leftHandSlot);
        UpdateEquipSlotsAux(Player.Instance.PlayerEquipament.CurrentRightHandItem, _righthandSlot);
        UpdateEquipSlotsAux(Player.Instance.PlayerEquipament.CurrentLegsClothes, _legsSlot);

    }

    private void UpdateEquipSlotsAux(ItemSO currentClothes, PlayerEquipSlot playerEquipSlot)
    {
        if (currentClothes != null) playerEquipSlot.AddItem(currentClothes);
    }
}
