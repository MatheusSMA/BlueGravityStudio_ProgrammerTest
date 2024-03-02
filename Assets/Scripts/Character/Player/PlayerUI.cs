using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Transform _interactionButtonParent;
    [SerializeField] private InteractionButtonUI _interactionButton;
    [SerializeField] private InventoryUiPlayer _inventoryUIPlayer;
    [SerializeField] private GameObject _inventoryUI;

    public void PositionInteractButton(Transform positionObject)
    {
        if (!_interactionButton.gameObject.activeInHierarchy) TurnInteractionButtonON();

        _interactionButton.SetPosition(positionObject);
    }

    public void TurnInteractionButtonON()
    {
        _interactionButton.gameObject.SetActive(true);
    }

    public void TurnInteractionButtonOFF()
    {
        _interactionButton.gameObject.SetActive(false);
        _interactionButton.SetPosition(_interactionButtonParent);
    }

    
}