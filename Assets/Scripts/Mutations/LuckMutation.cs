using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Coded by: Joseph Arends
public class LuckMutation : PassiveEffect
{
    public float luckImprove;

    public LuckMutation()
    {
    }

    void Start()
    {
        GameObject player = GameObject.Find("Player");
        //anim = player.GetComponent<Animator>();
        //ApplyPassive();
    }
    public override void ApplyPassive()
    {
        
        GameObject player = GameObject.Find("Player");
        Debug.Log(boolName);
        base.ApplyPassive();
        player.GetComponent<PlayerMovement>().runSpeed += positivePower;
        player.GetComponent<PlayerControls>().luck += luckImprove;
        player.GetComponent<Animator>().SetBool(boolName, true);
    }

    public override void RemovePassive()
    {
        base.RemovePassive();
        player.GetComponent<PlayerMovement>().runSpeed -= positivePower;
        player.GetComponent<PlayerControls>().luck -= luckImprove;
        player.GetComponent<Animator>().SetBool(boolName, false);
    }

    
}
