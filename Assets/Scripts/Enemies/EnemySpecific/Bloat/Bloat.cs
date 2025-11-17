using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//coded by: Joseph Arends

public class Bloat : Entity
{
    public E_AggroState aggroState { get; private set; }
    public BL_WalkState moveState { get; private set; }
    public BL_IdleState idleState { get; private set; }
    public BL_StartMeleeAttack startMeleeAttackState { get; private set; }
    public BL_LandMeleeAttack landMeleeAttackState { get; private set; }
    public BL_RamMoveState ramMoveState { get; private set; }

    public Collider2D hitbox;
    public Collider2D ramHitbox;
    

    [SerializeField]
    private D_IdleState idleStateData;
    [SerializeField]
    private D_MoveState moveStateData;
    [SerializeField]
    private D_AggroState aggroStateData;
    [SerializeField]
    private D_StartMeleeState startMeleeStateData;
    [SerializeField]
    private D_LandMeleeAttack landMeleeAttackData;
    [SerializeField]
    private D_MoveState ramMoveStateData;

    public override void Start()
    {
        base.Start();

        moveState = new BL_WalkState(this, stateMachine, "move", moveStateData, this);
        idleState = new BL_IdleState(this, stateMachine, "idle", idleStateData, this);
        aggroState = new E_AggroState(this, stateMachine, "aggro", aggroStateData, this);
        startMeleeAttackState = new BL_StartMeleeAttack(this, stateMachine, "startMeleeAttack", startMeleeStateData, this);
        landMeleeAttackState = new BL_LandMeleeAttack(this, stateMachine, "landMeleeAttack", landMeleeAttackData, this);
        ramMoveState = new BL_RamMoveState(this, stateMachine, "ramMove", ramMoveStateData, this);

        stateMachine.Initialize(moveState);
    }
    
}
