using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour, IInteractable
{
    [SerializeField] private ShopSO _shopInfo;
    [SerializeField] private InventoryBase _shopInventory;
    [SerializeField] private GameObject _shopUiParent;
    [SerializeField] private InventoryUiShop _shopUi;
    [SerializeField] private TextMeshProUGUI _shopNameTxt;
    public bool isAvailableToInteract { get; set; }

    public void CheckIsAvailable()
    {
        if (_shopInventory.Itens.Count > 0 || _shopInventory.MoneyBase.CurrentMoney > 0)
            isAvailableToInteract = true;
        else
            isAvailableToInteract = false;
    }

    public void CloseShopUI()
    {
        _shopUiParent.SetActive(false);
        UiManager.Instance.ShopInventoryClose();
    }

    public void Interact(GameObject objectToInteract)
    {
        if (UiManager.Instance.InventoryIsOpen) return;

        objectToInteract.TryGetComponent<InventoryBase>(out InventoryBase _customerInventory);
        _shopUi.SetInventory(_customerInventory);
        _shopUi.SetOther(_shopInventory);
        _shopUi.SetOther(_customerInventory);
        _shopUiParent.SetActive(true);
        UiManager.Instance.ShopInventoryOpen();
    }
}