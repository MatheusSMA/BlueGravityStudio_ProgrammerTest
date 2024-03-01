using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Vector2 _input;
    private bool _canInput;

    private void Update()
    {
        if (_canInput)
        {
            GetMoveInput();
        }
    }

    private void GetMoveInput()
    {
        _input.x = Input.GetAxisRaw("Horizontal");
        _input.y = Input.GetAxisRaw("Vertical");
        Player.Instance.PlayerMovent.GetInput(_input);
    }

    /// <summary>
    /// Tells whether or not ir can recieve input
    /// </summary>
    /// <param name="state"></param>
    public void ChangeRecieveInputStatus(bool state)
    {
        _canInput = state;
    }

}
