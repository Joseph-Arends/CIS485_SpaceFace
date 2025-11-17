using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//coded by: Joseph Arends

public class Blob : Entity
{
    public E_One_IdleState idleState { get; private set; }
    public E_One_MoveState moveState { get; private set; }

    [SerializeField]
    private D_IdleState idleStateData;
    [SerializeField]
    private D_MoveState moveStateData;

    public override void Start()
    {
        base.Start();

        moveState = new E_One_MoveState(this, stateMachine, "move", moveStateData, this);
        idleState = new E_One_IdleState(this, stateMachine, "idle", idleStateData, this);

        stateMachine.Initialize(moveState);
    }

    
}
