using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "Character/Player")]
public class PlayerSO : ScriptableObject
{
    public int money;
    public int maxInventorySlot;
    public List<ItemSO> startingItens;

    public ItemSO headEquipament;
    public ItemSO chestEquipament;
    public ItemSO handsEquipament;
    public ItemSO legsEquipament;


}