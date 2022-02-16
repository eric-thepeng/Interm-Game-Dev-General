using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGMFinale : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<RBMStarter>().Finale(collision.gameObject.name);
    }
}
