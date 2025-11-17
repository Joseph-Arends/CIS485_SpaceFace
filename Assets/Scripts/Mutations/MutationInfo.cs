using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Coded by Joseph Arends
// Similar to GunInfo, this is for mutation stats
// Abstract Class that both equippables(melee attacks) and passives take from
public abstract class MutationInfo : MonoBehaviour
{
    // Power is the general strength of the mutation
    // So this can be both attack or additive buffs
    public float positivePower;

    // Inversely, this is for any deductions to stats acquired by mutations
    public float negativePower;

    // This is for passives that add an extra multiplier to the buff
    // SHOULD BE IN THE RANGE OF 0-1!!! Otherwise wacky high numbers may ensue
    public float powerMultiplier;

    // This identifies whether the mutation is a weapon or a passive
    // This is for determining which array the game object will be sent to
    public string mutationClass;

    public string boolName;

    // These bools are checks for the types of passives
    public bool attackBuff;
    public bool healthBuff;
    public bool speedBuff;


    public bool attackDebuff;
    public bool healthDebuff;
    public bool speedDebuff;
    // This is for getting rid of certain mutations if they are not applicable to a certain infection tier
    public float maxInfectionTier;
    // Start is called before the first frame update
    
}
