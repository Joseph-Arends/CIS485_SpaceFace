using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//coded by: Joseph Arends

public class E_One_IdleState : Idle
{
    private Blob enemy;
    public E_One_IdleState(Entity aEntity, FiniteStateMachine aStateMachine, string aAnimBoolName, D_IdleState stateData, Blob enemy) : base(aEntity, aStateMachine, aAnimBoolName, stateData)
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
        //Debug.Log(isIdleTimeOver);
        //Debug.Log("wait " + wait);
        //Debug.Log("is " + isIdleTimeOver);

        if (isIdleTimeOver)
        {
            stateMachine.ChangeState(enemy.moveState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
