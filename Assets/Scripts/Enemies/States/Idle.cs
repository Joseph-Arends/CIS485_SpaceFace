using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// coded by: Joseph Arends
public class Idle : State
{
    protected D_IdleState stateData;

    protected bool flipAfterIdle;
    protected bool isIdleTimeOver;

    protected float idleTime;
    protected float wait;

    protected LayerMask player;
    protected bool playerDetected;
    public Idle(Entity aEntity, FiniteStateMachine aStateMachine, string aAnimBoolName, D_IdleState stateData) : base(aEntity, aStateMachine, aAnimBoolName)
    {
        this.stateData = stateData;
    }

    public override void Enter()
    {
        base.Enter();
        entity.SetVelocity(0f);
        wait = 0f;
        isIdleTimeOver = false;
        SetRandomIdleTime();
        
    }

    public override void Exit()
    {
        base.Exit();

        if (flipAfterIdle)
        {
            entity.Flip();
        }
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        wait += Time.deltaTime;

        Collider2D[] detection = Physics2D.OverlapCircleAll(this.entity.transform.position, stateData.detectionRange, stateData.player);
        if (detection.Length > 0)
        {
            playerDetected = true;
        }

        if (wait >= idleTime)
        {
            //Debug.Log("start" + startTime);
            wait = 0f;
            isIdleTimeOver = true;
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    public void SetFlipAfterIdle(bool flip)
    {
        flipAfterIdle = flip;
    }

    private void SetRandomIdleTime()
    {
        idleTime = Random.Range(stateData.minIdleTime, stateData.maxIdleTime);
        //Debug.Log("idle " + idleTime);
    }
}
