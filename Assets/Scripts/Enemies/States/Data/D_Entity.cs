using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Coded by: Joseph Arends
[CreateAssetMenu(fileName = "newEntityData", menuName = "Data/Entity_Data/Base_Data")]
public class D_Entity : ScriptableObject
{
    public float wallCheckDistance = 0.2f;
    public float ledgeCheckDistance = 0.4f;

    public LayerMask whatIsGround;
}
