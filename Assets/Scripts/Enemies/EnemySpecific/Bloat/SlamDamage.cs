using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//coded by: Joseph Arends

public class SlamDamage : MonoBehaviour
{
    [SerializeField]
    public int damage = 60;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerControls>().TakeDamage(damage);
            
        }
    }
}
