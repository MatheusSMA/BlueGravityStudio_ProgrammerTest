using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementBase : MonoBehaviour
{
    [SerializeField] protected float _currentSpeed;
    protected Rigidbody2D _rb;
    protected Vector2 _input;
    protected bool _canMove, flipped = true;

    protected void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    protected void FixedUpdate()
    {
        if (_canMove)
        {
            Move();
            FlipSprite();
        }
    }
    protected virtual void Move()
    {
        _rb.MovePosition(_rb.position + _input.normalized * _currentSpeed * Time.deltaTime);
    }
    protected virtual void FlipSprite()
    {
        if (_input.x > 0 && flipped || _input.x < 0 && !flipped)
        {
            flipped = !flipped;
            transform.localScale *= new Vector2(-1, 1);
        }
    }
    public void GetInput(Vector2 input)
    {
        _input = input;
    }

    /// <summary>
    /// Tells whether or not ir can move
    /// </summary>
    /// <param name="state"></param>
    public void ChangeMoveStatus(bool state)
    {
        _canMove = state;
    }
}
