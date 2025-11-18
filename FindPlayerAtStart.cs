using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class FindPlayerAtStart : MonoBehaviour
{


    private CinemachineVirtualCamera vCam;
    public GameObject tPlayer;
    public Transform tFollowTarget;

    private void Start()
    {
        vCam = GetComponent<CinemachineVirtualCamera>();
    }

    void Update()
    {
        if (tPlayer == null)
        {
            tPlayer = GameObject.FindWithTag("Player");
            if (tPlayer != null)
            {
                tFollowTarget = tPlayer.transform;
                vCam.LookAt = tFollowTarget;
                vCam.Follow = tFollowTarget;
            }
        }
    }

}