using UnityEngine;

[RequireComponent(typeof(PlayerInput)), RequireComponent(typeof(PlayerMovement)), RequireComponent(typeof(PlayerAnimation)), RequireComponent(typeof(PlayerInteractable))]
public class Player : MonoBehaviour
{
    public static Player Instance;

    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private PlayerMovement _playerMovent;
    [SerializeField] private PlayerAnimation _playerAnimation;
    [SerializeField] private PlayerInteractable _playerInteractable;
    [SerializeField] private PlayerUI _playerUI;

    public PlayerInput PlayerInput { get => _playerInput; }
    public PlayerMovement PlayerMovent { get => _playerMovent; }
    public PlayerAnimation PlayerAnimation { get => _playerAnimation; }
    public PlayerInteractable PlayerInteractable { get => _playerInteractable; }
    public PlayerUI PlayerUI { get => _playerUI; }

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
        SetPlayerControl(true);
    }

    private void SetPlayerControl(bool state)
    {
        _playerInput.ChangeRecieveInputStatus(state);
        _playerMovent.ChangeMoveStatus(state);
        _playerInteractable.ChangeInteractionStatus(state);
    }

}

