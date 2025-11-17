using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject[] spawnList;
    public float health = 100;
    public float attack = 25;
    public GameObject deathEffect;
    public Material matWhite;
    protected Material matDefault;
    public SpriteRenderer sr;
    protected AudioSource mAudioSrc;
    public GameObject deathEffect2;
    public bool isBurning;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        mAudioSrc = GetComponent<AudioSource>();
        matDefault = sr.material;

    }

    private void Update()
    {
        if (isBurning)
        {
            StartCoroutine(ResidualDamage());
        }
    }

    public virtual void TakeDamage (float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            
            Die();
            
        }

        
    }

    public virtual void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Instantiate(deathEffect2, transform.position, Quaternion.identity);
        Instantiate(spawnList[0], transform.position, Quaternion.identity);
        Destroy(gameObject);
        FindObjectOfType<Free>().Stop(0.1f);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            sr.material = matWhite;
            
        }
        if(health <= 0)
        {
            Die();
        }
        else
        {
            Invoke("ResetMaterial", .2f);
        }
    }

    void ResetMaterial()
    {
        sr.material = matDefault;
    }

    IEnumerator ResidualDamage()
    {

        

        Debug.Log("burning");
        TakeDamage(0.01f);



        yield return new WaitForSeconds(0.5f);
    }
}
