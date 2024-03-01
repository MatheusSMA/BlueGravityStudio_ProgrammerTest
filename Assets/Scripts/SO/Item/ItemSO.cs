using UnityEngine;

[CreateAssetMenu(fileName = "Create a new Item", menuName = "Inventory/Item")]
public class ItemSO : ScriptableObject
{
    new public string name;
    public int price;
    public Sprite icon;
}