using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//coded by: Joseph Arends
[CreateAssetMenu(fileName = "newIdleStateData", menuName = "Data/State_Data/Idle_State")]
public class D_IdleState : ScriptableObject
{
    public float minIdleTime = 1f;
    public float maxIdleTime = 2f;

    public Transform playerDetection;
    public LayerMask player;
    public float detectionRange;
}
