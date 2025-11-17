using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViscosityEquipment : MonoBehaviour
{
    public GameObject currentTeleporter;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //anim
            if (currentTeleporter != null)
            {
                transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
                
            }
        }
    }

    public void OnTriggerStay2D(Collider2D obj)
    {
        if (obj.CompareTag("Teleporter"))
        {
            currentTeleporter = obj.gameObject;
            
        }
    }

    public void OnTriggerExit2D(Collider2D obj)
    {
        if (obj.CompareTag("Teleporter"))
        {
            if (obj.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }
}
