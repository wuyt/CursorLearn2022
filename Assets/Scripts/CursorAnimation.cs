using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class CursorAnimation : ScriptableObject
{
    public CursorType cursorType;
    public Texture2D[] textureArray;
    public float frameRate;
    public Vector2 offset;
}
