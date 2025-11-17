using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Coded by: Joseph Arends
public class PassiveEffect : MutationInfo 
{
    // Start is called before the first frame update
    public GameObject player;
    //private Animator anim;
    void Start()
    {
        player = GameObject.Find("Player");
        //anim = player.GetComponent<Animator>();
        //ApplyPassive();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void ApplyPassive()
    {
        GameObject player = GameObject.Find("Player");
        Debug.Log(player.GetComponent<PlayerControls>().maxHealth);
        Debug.Log(player.name);
        if (healthBuff)
        {
            player.GetComponent<PlayerControls>().maxHealth += positivePower;
            //player.GetComponent<PlayerControls>().maxHealth = player.GetComponent<PlayerControls>().maxHealth * powerMultiplier;
        }

        if (speedBuff)
        {
            player.GetComponent<PlayerMovement>().runSpeed += positivePower;
        }

        if (healthDebuff)
        {
            player.GetComponent<PlayerControls>().maxHealth -= negativePower;
        }

        if (speedDebuff)
        {
            player.GetComponent<PlayerMovement>().runSpeed -= negativePower;
        }
        Debug.Log(boolName);



        //player.GetComponent<Animator>().SetBool(boolName, true);
    }

    // If somehow the player is able to remove the mutation from their character
    public virtual void RemovePassive()
    {
        GameObject player = GameObject.Find("Player");
        if (healthBuff)
        {
            player.GetComponent<PlayerControls>().maxHealth -= positivePower;
            //player.GetComponent<PlayerControls>().maxHealth = player.GetComponent<PlayerControls>().maxHealth * powerMultiplier;
        }
        if (speedBuff)
        {
            player.GetComponent<PlayerMovement>().runSpeed -= positivePower;
        }

        if (healthDebuff)
        {
            player.GetComponent<PlayerControls>().maxHealth += negativePower;
        }

        if (speedDebuff)
        {
            player.GetComponent<PlayerMovement>().runSpeed += negativePower;
        }

        //player.GetComponent<Animator>().SetBool(boolName, false);
    }
}
