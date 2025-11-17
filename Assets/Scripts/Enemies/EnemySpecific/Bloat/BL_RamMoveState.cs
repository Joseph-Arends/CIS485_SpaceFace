using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//coded by: Joseph Arends

public class BL_RamMoveState : Move
{
    private Bloat enemy;
    public BL_RamMoveState(Entity aEntity, FiniteStateMachine aStateMachine, string aAnimBoolName, D_MoveState aStateData, Bloat enemy) : base(aEntity, aStateMachine, aAnimBoolName, aStateData)
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


        if (moveTime >= stateData.maxMoveTime)
        {
            Debug.Log("Charge to Aggro");
            //Debug.Log(moveTime);
            moveTime = 0;

            enemy.ramHitbox.GetComponent<Collider2D>().enabled = false;

            stateMachine.ChangeState(enemy.aggroState);
        }
        else
        {
            enemy.ramHitbox.GetComponent<Collider2D>().enabled = true;
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
