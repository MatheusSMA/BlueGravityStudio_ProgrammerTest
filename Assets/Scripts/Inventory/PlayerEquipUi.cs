using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerEquipUi : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Player _player;
    [SerializeField] private PlayerEquipSlot _bodySlot;
    [SerializeField] private PlayerEquipSlot _headSlot;
    [SerializeField] private PlayerEquipSlot _torsoSlot;
    [SerializeField] private PlayerEquipSlot _legsSlot;
    [SerializeField] protected TextMeshProUGUI _panelNameTxt;

    [Header("Parameters")]
    [SerializeField] protected string _panelName;

    public Player Player { get => _player; }

    private void Awake()
    {
        _panelNameTxt.text = _panelName;
        _bodySlot.SetPlayerEquipUI(this);
        _headSlot.SetPlayerEquipUI(this);
        _torsoSlot.SetPlayerEquipUI(this);
        _legsSlot.SetPlayerEquipUI(this);
    }

    private void OnEnable()
    {
        _player.PlayerEquipament.OnItemChange += UpdateEquipSlots;
        UpdateEquipSlots();
    }

    private void OnDisable()
    {
        _player.PlayerEquipament.OnItemChange -= UpdateEquipSlots;
    }

    private void UpdateEquipSlots()
    {
        UpdateEquipSlotsAux(_player.PlayerEquipament.CurrentBodyClothes, _bodySlot);
        UpdateEquipSlotsAux(_player.PlayerEquipament.CurrentHeadClothes, _headSlot);
        UpdateEquipSlotsAux(_player.PlayerEquipament.CurrentTorsoClothes, _torsoSlot);
        UpdateEquipSlotsAux(_player.PlayerEquipament.CurrentLegsClothes, _legsSlot);

    }

    private void UpdateEquipSlotsAux(ItemSO currentClothes, PlayerEquipSlot playerEquipSlot)
    {
        if (currentClothes != null)
        {
            playerEquipSlot.AddItem(currentClothes);
        }
    }
}
