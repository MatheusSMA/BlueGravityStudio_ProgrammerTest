using UnityEngine;

public interface IInteractable
{
    public void Interact(GameObject objectToInteract);
    public GameObject gameObject { get; }
    public void CheckIsAvailable();
    public bool isAvailableToInteract { get; set; }

}