using UnityEngine;

public class Shop : MonoBehaviour, IInteractable
{
    public bool isAvailableToInteract { get; set; }

    public void CheckIsAvailable()
    {

    }

    public void Interact(GameObject objectToInteract)
    {
        Debug.Log("está perto da loja!!!");
    }
}