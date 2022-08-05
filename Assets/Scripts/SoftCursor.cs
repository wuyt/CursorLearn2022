using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftCursor : MonoBehaviour
{
    public Texture2D texture;

    void Start()
    {
        Cursor.SetCursor(texture, new Vector2(40, 4), CursorMode.ForceSoftware);
    }
}
