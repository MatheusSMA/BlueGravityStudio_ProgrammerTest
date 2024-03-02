using UnityEngine;

public class PlayerInteractable : MonoBehaviour
{
    [SerializeField] private float _rangeToCheckInteractables;
    [SerializeField] private Vector3 _rangeOffSet;
    [SerializeField] private LayerMask _interactableLayer;

    private Collider2D[] _interactableColliders;
    private IInteractable _interactableClosestObject;
    private bool _canInteract;

    private void Update()
    {
        if (_canInteract) CheckNearbyInteractables();
    }

    public void InteractWithObject()
    {
        _interactableClosestObject?.Interact(gameObject);
    }

    private void CheckNearbyInteractables()
    {
        _interactableColliders = Physics2D.OverlapCircleAll(transform.position + _rangeOffSet, _rangeToCheckInteractables, _interactableLayer);

        if (_interactableColliders.Length <= 0)
        {
            if (_interactableClosestObject != null)
            {
                _interactableClosestObject = null;
                Player.Instance.PlayerUI.TurnInteractionButtonOFF();
            }
            
            return;
        }

        foreach (Collider2D collider in _interactableColliders)
        {
            if (collider.TryGetComponent<IInteractable>(out IInteractable interactable))
            {
                _interactableClosestObject = interactable;
                Player.Instance.PlayerUI.PositionInteractButton(_interactableClosestObject.gameObject.transform);
            }
        }
    }

    /// <summary>
    /// Tells whether or not ir can interact
    /// </summary>
    /// <param name="state"></param>
    public void ChangeInteractionStatus(bool state)
    {
        _canInteract = state;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position + _rangeOffSet, _rangeToCheckInteractables);
    }
}