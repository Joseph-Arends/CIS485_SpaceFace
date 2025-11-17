using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Coded by: Joseph Arends
public class LandMeleeAttack : State
{
    protected D_LandMeleeAttack stateData;

    protected float wait;
    protected float waitTime;
    protected bool returnToAggro;
    public LandMeleeAttack(Entity aEntity, FiniteStateMachine aStateMachine, string aAnimBoolName, D_LandMeleeAttack stateData) : base(aEntity, aStateMachine, aAnimBoolName)
    {
        this.stateData = stateData;
    }

    public override void Enter()
    {
        base.Enter();
        wait = 0f;
        SetWaitTime();
        returnToAggro = false;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        wait += Time.deltaTime;

        if (wait >= waitTime)
        {
            wait = 0f;
            returnToAggro = true;
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    private void SetWaitTime()
    {
        waitTime = stateData.waitTime;
    }
}
