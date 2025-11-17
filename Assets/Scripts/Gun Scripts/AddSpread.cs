using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSpread : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Weapon>().hasSpread = true;
            Destroy(gameObject);
        }

    }
}
