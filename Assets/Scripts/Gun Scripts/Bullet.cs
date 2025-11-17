using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float damage = 20;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    private AudioSource mAudioSrc;
    

    private Weapon weapon;

    public virtual void Start()
    {
        rb.velocity = transform.right * speed;
        weapon = GameObject.FindGameObjectWithTag("Player").GetComponent<Weapon>();
        damage = weapon.damage;
        if (weapon.hasSpread)
        {
            damage = weapon.damage / 5;
        }


    }

    public virtual void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();


        if (enemy != null)
        {

            if (weapon.hasFire)
            {
                enemy.isBurning = true;
            }
            enemy.TakeDamage(damage);
            

            
        }

        if (hitInfo.CompareTag("Enemy"))
        {

            Instantiate(impactEffect, transform.position, transform.rotation);
           
            Destroy(gameObject);

            
            

        }


        if (hitInfo.CompareTag("Platforms"))
        {
            Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            
        }
    }
    public virtual void OnBecameInvisible()
    {
        enabled = false;
        Destroy(gameObject);
    }

    
}

