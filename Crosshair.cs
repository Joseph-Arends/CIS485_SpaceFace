using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public Texture2D aimCursor;
    public Texture2D hitCursor;
    public Texture2D grappleCursor;

    bool hover;
    // Start is called before the first frame update
    void Start()
    {

        Cursor.SetCursor(aimCursor, Vector2.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseStay()
    {
        if (gameObject.tag == "Grapple")
        {
            Cursor.SetCursor(grappleCursor, Vector2.zero, CursorMode.Auto);
        }
    
        if (gameObject.tag == "Enemy")
        {
            Cursor.SetCursor(aimCursor, Vector2.zero, CursorMode.Auto);
        }
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(aimCursor, Vector2.zero, CursorMode.Auto);
    }
}
