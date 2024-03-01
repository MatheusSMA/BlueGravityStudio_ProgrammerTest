using UnityEngine;

public class PlayerInteractable : MonoBehaviour
{
    [SerializeField] private float _rangeToCheckInteractables;
    private Collider2D[] _interactableColliders;
    private IInteractable _interactable;

    private void CheckNearbyInteractables()
    {
        _interactableColliders = Physics2D.OverlapCircleAll(transform.position, _rangeToCheckInteractables, PlayerConfig.INTERACTABLE_LAYER);

        // if (_interactableColliders.Length <= 0)
        // {
        //     if (_interactable != null)
        //     {
        //         _interactable = null;
        //         //TODO: Desligar UI de interação/ação
        //     }

        //     return;
        // }

        foreach (Collider2D collider in _interactableColliders)
        {
            if (collider.TryGetComponent<IInteractable>(out IInteractable interactable))
            {
                _interactable.Interact(this.gameObject);
            }
        }
    }
}