using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    public void SetWalkAnim(Vector2 input)
    {
        _animator.SetFloat(PlayerConfig.WALKING_ANIMATION_KEY, input.magnitude);
    }
}
