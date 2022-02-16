using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Week4PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float jumpStrength = 5.0f;
    [SerializeField] float moveSpeed = 5.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

}
