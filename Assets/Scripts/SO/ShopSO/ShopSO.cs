using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Shop", menuName = "Character/Shop")]
public class ShopSO : ScriptableObject
{
    public string ShopName = "New Shop";
    public int InitialMoney = 5;
    public int MaxSlots = 5;
    public List<ItemSO> Items;
}
