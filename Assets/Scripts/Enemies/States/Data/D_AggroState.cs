using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Coded by: Joseph Arends
[CreateAssetMenu(fileName = "newAggroStateData", menuName = "Data/State_Data/Aggro_State")]
public class D_AggroState : ScriptableObject
{
    public float meleeRange;
    public float longRange;
    public Transform playerDetection;
    public LayerMask player;

    public float minDecisionTime;
    public float maxDecisionTime;
}
