using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetpackEquipment : MonoBehaviour
{
    public DashState dashState;
    public float dashTimer;
    public float maxDash = 20f;
    public Rigidbody2D rb;
    public Vector2 savedVelocity;
    public float lastImageXpos;
    public float distanceBetweenImages;

    void Update()
    {
        switch (dashState)
        {
            case DashState.Ready:
                var isDashKeyDown = Input.GetKeyDown(KeyCode.LeftShift);
                if (isDashKeyDown)
                {
                    savedVelocity = rb.velocity;
                    rb.velocity = new Vector2(rb.velocity.x * 12f, rb.velocity.y * 0.01f);
                    dashState = DashState.Dashing;
                    AfterImagePool.Instance.GetFromPool();
                }
                break;
            case DashState.Dashing:
                dashTimer += Time.deltaTime * 4;
                if (dashTimer >= maxDash)
                {
                    dashTimer = maxDash;
                    rb.velocity = savedVelocity;
                    dashState = DashState.Cooldown;

                    if (Mathf.Abs(transform.position.x - lastImageXpos) > distanceBetweenImages)
                    {
                        AfterImagePool.Instance.GetFromPool();
                        lastImageXpos = transform.position.x;
                    }
                }
                break;
            case DashState.Cooldown:
                dashTimer -= Time.deltaTime;
                if (dashTimer <= 0)
                {
                    dashTimer = 0;
                    dashState = DashState.Ready;
                }
                break;
        }
    }
}

public enum DashState
{
    Ready,
    Dashing,
    Cooldown
}