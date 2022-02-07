using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D playerRb;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = PGTool.ChangeVector(playerRb.velocity, 1, playerRb.velocity.x) / 6;
    }
}
