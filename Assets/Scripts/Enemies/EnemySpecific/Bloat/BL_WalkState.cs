using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//coded by: Joseph Arends

public class BL_WalkState : Move
{
    private Bloat enemy;
    public BL_WalkState(Entity aEntity, FiniteStateMachine aStateMachine, string aAnimBoolName, D_MoveState aStateData, Bloat enemy) : base(aEntity, aStateMachine, aAnimBoolName, aStateData)
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
            Debug.Log("Walk to Aggro");
            stateMachine.ChangeState(enemy.aggroState);
        }

        if (moveTime >= stateData.maxMoveTime)
        {
            Debug.Log("Walk to Idle");
            //Debug.Log(moveTime);
            moveTime = 0;
            enemy.idleState.SetFlipAfterIdle(true);
            stateMachine.ChangeState(enemy.idleState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
