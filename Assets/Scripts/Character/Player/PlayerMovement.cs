using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : GeneralMovement
{
    protected override void Move()
    {
        base.Move();

        Player.Instance.PlayerAnimation.SetWalkAnim(_input);
    }
}
