using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Coded by: Joseph Arends
public class GenericMutation : PassiveEffect
{
    public GenericMutation()
    {
    }

    public override void ApplyPassive()
    {
        
        GameObject player = GameObject.Find("Player");
        Debug.Log(boolName);
        base.ApplyPassive();
        player.GetComponent<PlayerControls>().maxHealth += positivePower;
        player.GetComponent<Animator>().SetBool(boolName, true);
    }

    public override void RemovePassive()
    {
        GameObject player = GameObject.Find("Player");
        base.RemovePassive();
        player.GetComponent<PlayerControls>().maxHealth -= positivePower;
        player.GetComponent<Animator>().SetBool(boolName, false);
    }
}
