using UnityEngine;

public class Shop : MonoBehaviour, IInteractable
{
    public bool isAvailableToInteract { get; set; }

    public void CheckIsAvailable()
    {
        //  if (UiManager.Instance.AnInventoryIsOpen) return;

        //     interactor.TryGetComponent<InventoryBase>(out _customerInventory);
        //     _customerUi.SetInventory(_customerInventory);
        //     _customerUi.SetOther(_shopInventory);
        //     _shopUi.SetOther(_customerInventory);
        //     _shopUiParent.SetActive(true);
        //     UiManager.Instance.ShopInventoryOpen();
    }


    public void Interact(GameObject objectToInteract)
    {
        Debug.Log("está perto da loja!!!");
    }
}