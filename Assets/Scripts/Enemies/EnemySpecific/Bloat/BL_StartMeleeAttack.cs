using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//coded by: Joseph Arends

public class BL_StartMeleeAttack : StartMeleeAttack
{
    private Bloat enemy;
    public BL_StartMeleeAttack(Entity aEntity, FiniteStateMachine aStateMachine, string aAnimBoolName, D_StartMeleeState stateData, Bloat enemy) : base(aEntity, aStateMachine, aAnimBoolName, stateData)
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

        if (landAttack)
        {
            Debug.Log("Start Melee to Land Melee");
            stateMachine.ChangeState(enemy.landMeleeAttackState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
