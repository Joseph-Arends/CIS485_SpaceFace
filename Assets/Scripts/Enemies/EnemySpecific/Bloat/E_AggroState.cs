using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//coded by: Joseph Arends

public class E_AggroState : Aggro
{
    private Bloat enemy;
    public E_AggroState(Entity aEntity, FiniteStateMachine aStateMachine, string aAnimBoolName, D_AggroState stateData, Bloat enemy) : base(aEntity, aStateMachine, aAnimBoolName, stateData)
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
        //Debug.Log(wait);

        if (isMeleeAttack)
        {
            Debug.Log("Aggro to start melee");
            stateMachine.ChangeState(enemy.startMeleeAttackState);

        }

        else if (isLongAttack)
        {
            stateMachine.ChangeState(enemy.ramMoveState);
        }
        else if (returnToMove)
        {
            stateMachine.ChangeState(enemy.moveState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
