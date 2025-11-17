using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public float firerate = 0;
    public float damage = 20;
    public GameObject impactEffect;
    public LineRenderer lineRenderer;
    public float offset;
    public GameObject bullet;
    public Transform BulletTrailPrefab;
    public float timetoFire = 0;

    public bool hasFire = false;
    public bool hasSpread = false;



    // Update is called once per frame
    void Update()
    {
        Vector3 gunPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        if (gunPosition.x < transform.position.x)
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 180f, transform.rotation.z);
        }
        else
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 0f, transform.rotation.z);
        }

        if (firerate == 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                StartCoroutine(Shoot());
            }
        }
        else
        {
            if (Input.GetButtonDown("Fire1") && Time.time > timetoFire)
            {
                timetoFire = Time.time + 1 / firerate;
                StartCoroutine(Shoot());
            }
        }
    }


    IEnumerator Shoot ()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);
        if (hasSpread)
        {
            float spread = 20f;
            for (int i = 0; i < 8; i++)
            {
                float variance = Random.Range(-(spread), spread);
                Quaternion rotation = Quaternion.AngleAxis(variance, transform.forward);
                Quaternion finalRotation = rotation * firePoint.rotation;

                Instantiate(bullet, firePoint.position, finalRotation);

            }
        }
        else
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }
        
        Instantiate(BulletTrailPrefab, firePoint.position, firePoint.rotation);

        if (hitInfo)
        {
            
            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, hitInfo.point);

            
        }
        else
        {
            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, firePoint.position + firePoint.right * 100);
        }

        lineRenderer.enabled = true;

        yield return new WaitForSeconds(0.02f);

        lineRenderer.enabled = false;

        

    }


}
