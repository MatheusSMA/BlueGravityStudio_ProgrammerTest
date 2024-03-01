using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralMovement : MonoBehaviour
{
    [SerializeField] protected float _baseMoveSpeed;
    protected Rigidbody2D _rb;
    protected float _currentSpeed;
    protected Vector2 _input;
    protected bool _canMove;

    protected void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _currentSpeed = _baseMoveSpeed;
    }    
    protected void FixedUpdate()
    {
        if (_canMove)
            Move();
    }    
    protected virtual void Move()
    {
        _rb.MovePosition(_rb.position + _input.normalized * _currentSpeed * Time.deltaTime);
    }    

    public void GetInput(Vector2 input)
    {
        _input = input;
    }
    public void ChangeStatusIfCanMove(bool state)
    {
        _canMove = state;
    }

}
