using UnityEngine;

public interface IInteractable
{
    public void Interact(GameObject objectToInteract);
    public void CheckIsAvailable();
    public bool isAvailableToInteract { get; set; }

}