using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//coded by: Joseph Arends

[CreateAssetMenu(fileName = "newMoveStateData", menuName = "Data/State_Data/Move_State")]
public class D_MoveState : ScriptableObject
{
    public float movementSpeed = 3f;
    public float maxMoveTime = 3f;

    public Transform playerDetection;
    public LayerMask player;
    public float detectionRange;
}
