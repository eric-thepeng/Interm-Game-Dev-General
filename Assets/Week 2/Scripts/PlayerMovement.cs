using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : SideScrollerPlayerMovement
{
    [SerializeField] Transform body;

    float friction = 3f, speedIndex = 0, speed = 4;
    Rigidbody2D rb;
    Vector2 movingDir = new Vector2(0, 0);


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PGSoundManager.PlaySound("Rain Sound");
    }

    void Update()
    {
        movingDir = new Vector2(GetHorizonal(), GetVertical());
        SetVelocity(movingDir);
    }

    float GetHorizonal()
    {
        int horizontalInput = 0;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) { horizontalInput -= 1; body.localScale = PGTool.ChangeVector(body.localScale, 1, -1); }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) { horizontalInput += 1; body.localScale = PGTool.ChangeVector(body.localScale, 1, 1); } 
        if (horizontalInput == 0)
        {
            speedIndex -= friction * Time.deltaTime;
            speedIndex = Mathf.Clamp(speedIndex, 0, 1);
            return speedIndex * Mathf.Sign(movingDir.x);
        }
        else
        {
            if (Mathf.Sign(horizontalInput) != Mathf.Sign(movingDir.x))
            { 
                speedIndex = 0;
            }
            speedIndex += friction * Time.deltaTime;
            speedIndex = Mathf.Clamp(speedIndex, 0, 1);
            return speedIndex * horizontalInput;
        }
    }

    float GetVertical()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {

        }
        else
        {

        }
        return 0f;
    }

    void SetVelocity(Vector2 velocity)
    {
        if (rb.velocity != velocity) rb.velocity = velocity;
    }

}