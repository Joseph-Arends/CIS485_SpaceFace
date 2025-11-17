using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//coded by: Joseph Arends

public class BL_LandMeleeAttack : LandMeleeAttack
{
    private Bloat enemy;
    public BL_LandMeleeAttack(Entity aEntity, FiniteStateMachine aStateMachine, string aAnimBoolName, D_LandMeleeAttack stateData, Bloat enemy) : base(aEntity, aStateMachine, aAnimBoolName, stateData)
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

        if (returnToAggro == false)
        {
            enemy.hitbox.GetComponent<Collider2D>().enabled = true;
        }

        if (returnToAggro)
        {
            enemy.hitbox.GetComponent<Collider2D>().enabled = false;
            Debug.Log("Land Melee to Aggro");
            stateMachine.ChangeState(enemy.aggroState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
