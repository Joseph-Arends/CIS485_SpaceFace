using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//coded by: Joseph Arends

public class BloatInfo : Enemy
{
    public GameObject blob;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        mAudioSrc = GetComponent<AudioSource>();
        matDefault = sr.material;

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            collision.gameObject.GetComponent<PlayerControls>().TakeDamage(attack);
        }

        if (collision.CompareTag("Bullet"))
        {
            sr.material = matWhite;

        }
        if (health <= 0)
        {
            Die();
        }
        else
        {
            Invoke("ResetMaterial", .2f);
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            collision.gameObject.GetComponent<PlayerControls>().TakeDamage(attack);
        }
    }

    void ResetMaterial()
    {
        sr.material = matDefault;
    }

    public override void Die()
    {
        base.Die();
        Instantiate(spawnList[0], transform.position, Quaternion.identity);
        Destroy(blob);
    }
}
