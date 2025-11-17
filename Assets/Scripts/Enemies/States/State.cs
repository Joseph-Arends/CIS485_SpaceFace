using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Coded by: Joseph Arends
public class State
{
    protected FiniteStateMachine stateMachine;
    protected Entity entity;

    protected float startTime;

    protected string animBoolName;

    public State(Entity aEntity, FiniteStateMachine aStateMachine, string aAnimBoolName)
    {
        this.entity = aEntity;
        this.stateMachine = aStateMachine;
        this.animBoolName = aAnimBoolName;
    }

    public virtual void Enter()
    {
        startTime = Time.time;
        entity.anim.SetBool(animBoolName, true);
    }

    public virtual void Exit()
    {
        entity.anim.SetBool(animBoolName, false);
    }

    public virtual void LogicUpdate()
    {

    }

    public virtual void PhysicsUpdate()
    {

    }

}
