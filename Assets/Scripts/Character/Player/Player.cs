using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private PlayerMovement _playerMovent;
    [SerializeField] private PlayerAnimation _playerAnimation;

    public PlayerInput PlayerInput { get => _playerInput; }
    public PlayerMovement PlayerMovent { get => _playerMovent; }
    public PlayerAnimation PlayerAnimation { get => _playerAnimation; set => _playerAnimation = value; }

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
