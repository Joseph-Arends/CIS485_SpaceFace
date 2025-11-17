using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//coded by: Joseph Arends
public class Move : State
{
    protected D_MoveState stateData;
    protected bool isDetectingWall;
    protected bool isDetectingLedge;

    protected float moveTime;

    protected LayerMask player;
    protected bool playerDetected;

    public Move(Entity aEntity, FiniteStateMachine aStateMachine, string aAnimBoolName, D_MoveState aStateData) : base(aEntity, aStateMachine, aAnimBoolName)
    {
        this.stateData = aStateData;
    }

    public override void Enter()
    {
        base.Enter();
        entity.SetVelocity(stateData.movementSpeed);
        
        // Remember this if it doesn't work
        isDetectingLedge = entity.CheckLedge();
        isDetectingWall = entity.CheckWall();
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

        // Remember this if it doesn't work
        isDetectingLedge = entity.CheckLedge();
        isDetectingWall = entity.CheckWall();
        
        moveTime += Time.deltaTime;
        entity.rb.MovePosition(entity.rb.position + entity.velcityWorkspace * Time.deltaTime);

        Collider2D[] detection = Physics2D.OverlapCircleAll(entity.rb.transform.position, stateData.detectionRange, stateData.player);
        if (detection.Length > 0)
        {
            playerDetected = true;
        }
    }
}
