using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Coded by: Joseph Arends
public class Chase : State
{
    

    protected D_ChaseState stateData;
    public Chase(Entity aEntity, FiniteStateMachine aStateMachine, string aAnimBoolName, D_ChaseState stateData) : base(aEntity, aStateMachine, aAnimBoolName)
    {
        this.stateData = stateData;
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
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
