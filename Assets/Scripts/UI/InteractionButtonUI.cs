using UnityEngine;

public class InteractionButtonUI : MonoBehaviour
{
    [SerializeField] private Vector3 _positionOffset;

    public void SetPosition(Transform parentPosition)
    {
        transform.SetParent(parentPosition);
        transform.localPosition = _positionOffset;
    }
}