using UnityEngine;

[RequireComponent(typeof(PlayerInput)), RequireComponent(typeof(PlayerMovement)), RequireComponent(typeof(PlayerAnimation)), RequireComponent(typeof(PlayerInteractable))]
public class Player : MonoBehaviour
{
    public static Player Instance;

    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private PlayerMovement _playerMovent;
    [SerializeField] private PlayerAnimation _playerAnimation;
    [SerializeField] private PlayerInteractable _playerInteractable;

    public PlayerInput PlayerInput { get => _playerInput; }
    public PlayerMovement PlayerMovent { get => _playerMovent; }
    public PlayerAnimation PlayerAnimation { get => _playerAnimation; }
    public PlayerInteractable PlayerInteractable { get => _playerInteractable; }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        InitiatePlayer();
    }

    private void InitiatePlayer()
    {
        SetPlayerMoveStatus(true);
    }

    private void SetPlayerMoveStatus(bool state)
    {
        _playerInput.ChangeStatusToRecieveInput(state);
        _playerMovent.ChangeStatusIfCanMove(state);
    }

}

