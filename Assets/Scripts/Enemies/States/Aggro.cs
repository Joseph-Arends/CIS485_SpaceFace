using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Coded by: Joseph Arends
public class Aggro : State
{
    // This state is for when the enemy detects the player - It is in its "aggro" state

    protected D_AggroState stateData;

    protected bool isMeleeAttack;
    protected bool isLongAttack;
    protected bool returnToMove;
    protected bool isDecisionTimeOver;

    protected float decisionTime;
    protected float wait;

    protected Transform meleeDetection;
    protected LayerMask player;
    public Aggro(Entity aEntity, FiniteStateMachine aStateMachine, string aAnimBoolName, D_AggroState stateData) : base(aEntity, aStateMachine, aAnimBoolName)
    {
        this.stateData = stateData;
    }

    public override void Enter()
    {
        base.Enter();
        entity.SetVelocity(0f);
        wait = 0f;
        isDecisionTimeOver = false;
        isLongAttack = false;
        isMeleeAttack = false;
        returnToMove = false;

        SetRandomAggroTime();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        wait += Time.deltaTime;
        if (wait >= decisionTime)
        {
            
            wait = 0f;

            Collider2D[] detection = Physics2D.OverlapCircleAll(entity.rb.transform.position, stateData.meleeRange, stateData.player);
            Collider2D[] longRangeDetection = Physics2D.OverlapCircleAll(entity.rb.transform.position, stateData.longRange, stateData.player);
            if (detection.Length > 0)
            {
                
                Vector3 toTarget = (detection[0].transform.position - entity.rb.transform.position).normalized;
                var dot = Vector3.Dot(toTarget, entity.rb.transform.forward);
                Debug.Log(dot);

                if (dot > -0.8)
                {
                    Debug.Log("Target is in front of this game object.");
                }
                else
                {
                    Debug.Log("Target is behind this game object");
                    this.entity.Flip();
                }
                Debug.Log("Player detected");
                isMeleeAttack = true;
            }
            else if (longRangeDetection.Length > 0)
            {
                Vector3 toTarget = (longRangeDetection[0].transform.position - entity.rb.transform.position).normalized;
                var dot = Vector3.Dot(toTarget, entity.rb.transform.forward);
                Debug.Log(dot);

                if (dot > -0.8)
                {
                    Debug.Log("Target is in front of this game object.");
                }
                else
                {
                    Debug.Log("Target is behind this game object");
                    this.entity.Flip();
                }
                Debug.Log("charge player");
                isLongAttack = true;
            }
            else
            {
                returnToMove = true;
            }
            isDecisionTimeOver = true;
            
            //isIdleTimeOver = true;
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    private void SetRandomAggroTime()
    {
        decisionTime = Random.Range(stateData.minDecisionTime, stateData.maxDecisionTime);
    }
}
