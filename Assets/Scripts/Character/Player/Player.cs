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
    [SerializeField] private PlayerEquipament _playerEquipament;
    [SerializeField] private InventoryBase _playerInventory;
    [SerializeField] private MoneyBase _playerMoney;
    [SerializeField] private PlayerSO _playerSO;

    public PlayerInput PlayerInput { get => _playerInput; }
    public PlayerMovement PlayerMovent { get => _playerMovent; }
    public PlayerAnimation PlayerAnimation { get => _playerAnimation; }
    public PlayerInteractable PlayerInteractable { get => _playerInteractable; }
    public PlayerUI PlayerUI { get => _playerUI; }
    public InventoryBase PlayerInventory { get => _playerInventory; set => _playerInventory = value; }
    public MoneyBase PlayerMoney { get => _playerMoney; set => _playerMoney = value; }
    public PlayerEquipament PlayerEquipament { get => _playerEquipament; set => _playerEquipament = value; }
    public PlayerSO PlayerSO { get => _playerSO; set => _playerSO = value; }

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
        _playerEquipament.InitializePlayerClothes();
        _playerInventory.InitializeInventory(_playerSO.maxInventorySlot, _playerSO.money, _playerSO.startingItens);
        _playerUI.InitializeInventoryUiPlayer(_playerInventory);

        SetPlayerControl(true);
    }

    private void SetPlayerControl(bool state)
    {
        _playerInput.ChangeRecieveInputStatus(state);
        _playerMovent.ChangeMoveStatus(state);
        _playerInteractable.ChangeInteractionStatus(state);
    }

}

