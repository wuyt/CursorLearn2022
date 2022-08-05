using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMananger : MonoBehaviour
{
    public CursorAnimation[] cursorAnimations;
    private CursorAnimation currentAnimation;

    private float frameRate;
    private int frameCount;
    private int currentFrame;
    private float frameTimer;

    private void Start()
    {
        SetActiveCursorAnimation(cursorAnimations[0]);
    }

    private void Update()
    {
        frameTimer -= Time.deltaTime;
        if (frameTimer <= 0f)
        {
            frameTimer += frameRate;
            currentFrame = (currentFrame + 1) % frameCount;
            Cursor.SetCursor(currentAnimation.textureArray[currentFrame], currentAnimation.offset, CursorMode.Auto);
        }

        if (Input.GetKeyDown(KeyCode.A)) SetActiveCursorAnimation(cursorAnimations[(int)CursorType.Arrow]);
        if (Input.GetKeyDown(KeyCode.S)) SetActiveCursorAnimation(cursorAnimations[(int)CursorType.Star]);
    }

    private void SetActiveCursorAnimation(CursorAnimation value)
    {
        currentAnimation = value;
        currentFrame = 0;
        frameTimer = value.frameRate;
        frameCount = value.textureArray.Length;
    }
}
