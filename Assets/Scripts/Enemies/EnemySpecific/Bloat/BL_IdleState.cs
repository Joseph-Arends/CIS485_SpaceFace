using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//coded by: Joseph Arends

public class BL_IdleState : Idle
{
    private Bloat enemy;
    public BL_IdleState(Entity aEntity, FiniteStateMachine aStateMachine, string aAnimBoolName, D_IdleState stateData, Bloat enemy) : base(aEntity, aStateMachine, aAnimBoolName, stateData)
    {
        this.enemy = enemy;
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if (playerDetected)
        {
            Debug.Log("Idle to Aggro");
            stateMachine.ChangeState(enemy.aggroState);
        }
        if (isIdleTimeOver)
        {
            Debug.Log("Idle to Walk");
            stateMachine.ChangeState(enemy.moveState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
