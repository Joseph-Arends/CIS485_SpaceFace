using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//coded by: Joseph Arends

public class E_One_MoveState : Move
{
    private Blob enemy;
    public E_One_MoveState(Entity aEntity, FiniteStateMachine aStateMachine, string aAnimBoolName, D_MoveState aStateData, Blob enemy) : base(aEntity, aStateMachine, aAnimBoolName, aStateData)
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
        //Debug.Log("wall" + isDetectingWall);
        //Debug.Log("ledge" + isDetectingLedge);
        /*if (isDetectingWall || !isDetectingLedge)
        {
            enemy.idleState.SetFlipAfterIdle(true);
            stateMachine.ChangeState(enemy.idleState);
        }*/

        if (moveTime >= stateData.maxMoveTime)
        {
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
