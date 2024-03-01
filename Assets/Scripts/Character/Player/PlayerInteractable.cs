using UnityEngine;

public class PlayerInteractable : MonoBehaviour
{
    [SerializeField] private float _rangeToCheckInteractables;
    private Collider2D[] _interactableColliders;

    private void CheckNearbyInteractables()
    {
        _interactableColliders = Physics2D.OverlapCircleAll(transform.position, _rangeToCheckInteractables);

        if (_interactableColliders.Length <= 0)
        {
        
        }
    }
}