using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Coded by: Joseph Arends
public class StartMeleeAttack : State
{
    protected D_StartMeleeState stateData;
    protected float wait;
    protected float attackTime;
    protected bool landAttack;
    public StartMeleeAttack(Entity aEntity, FiniteStateMachine aStateMachine, string aAnimBoolName, D_StartMeleeState stateData) : base(aEntity, aStateMachine, aAnimBoolName)
    {
        this.stateData = stateData;
    }

    public override void Enter()
    {
        base.Enter();
        wait = 0f;
        SetAttackTime();
        landAttack = false;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        wait += Time.deltaTime;
        
        if (wait >= attackTime)
        {
            wait = 0f;
            landAttack = true;
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    private void SetAttackTime()
    {
        attackTime = stateData.attackTime;
    }
}
