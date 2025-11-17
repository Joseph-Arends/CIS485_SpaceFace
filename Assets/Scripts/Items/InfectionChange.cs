using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Coded By: Joseph Arends
public class InfectionChange : MonoBehaviour
{
    public int infectionAmount;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("raise");
            collision.gameObject.GetComponent<PlayerControls>().ChangeInfection(infectionAmount);
            Destroy(gameObject);
        }
    }
}
