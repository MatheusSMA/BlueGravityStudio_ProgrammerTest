using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Transform _interactionButtonParent;
    [SerializeField] private InteractionButtonUI _interactionButton;
    [SerializeField] private InventoryUiPlayer _inventoryUIPlayer;
    [SerializeField] private GameObject _inventoryUI;
    [SerializeField] private MoneyBase _moneyBase;

    private void OnEnable()
    {
        if (UiManager.Instance)
        {
            UiManager.Instance.OnPlayerInventoryOpen += InventoryOn;
            UiManager.Instance.OnShopInventoryOpen += ShopOn;
            UiManager.Instance.OnPlayerInventoryClose += InventoryOff;
            UiManager.Instance.OnShopInventoryClose += ShopOff;
        }
    }
    public void InitializeInventoryUiPlayer(InventoryBase inventory)
    {
        _inventoryUIPlayer.SetInventory(inventory);
    }
    public void TurnInteractionButtonON()
    {
        _interactionButton.gameObject.SetActive(true);
    }
    public void PositionInteractButton(Transform positionObject)
    {
        if (!_interactionButton.gameObject.activeInHierarchy) TurnInteractionButtonON();

        _interactionButton.SetPosition(positionObject);
    }

    public void TurnInteractionButtonOFF()
    {
        _interactionButton.gameObject.SetActive(false);
        _interactionButton.SetPosition(_interactionButtonParent);
    }

    public void TurnInventory(bool open)
    {
        if (open)
            if (!UiManager.Instance.InventoryIsOpen) UiManager.Instance.PlayerInventoryOpen();
            else
                UiManager.Instance.PlayerInventoryClose();
    }

    private void InventoryOn()
    {
        _inventoryUI.gameObject.SetActive(true);
        _interactionButton.gameObject.SetActive(false);
        TurnInteractionButtonOFF();
    }

    private void InventoryOff()
    {
        _inventoryUI.gameObject.SetActive(false);
        // _interactionButton.gameObject.SetActive(true);
    }
    private void ShopOn()
    {
        _interactionButton.gameObject.SetActive(false);
        TurnInteractionButtonOFF();
    }

    private void ShopOff()
    {
        // _interactionButton.gameObject.SetActive(true);

    }

    private void OnDisable()
    {
        if (UiManager.Instance)
        {
            UiManager.Instance.OnPlayerInventoryOpen -= InventoryOn;
            UiManager.Instance.OnShopInventoryOpen -= ShopOn;
            UiManager.Instance.OnPlayerInventoryClose -= InventoryOff;
            UiManager.Instance.OnShopInventoryClose -= ShopOff;
        }
    }
}