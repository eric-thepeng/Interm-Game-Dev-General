using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBMCamCheckBox : MonoBehaviour
{
    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<RBMCameraManager>().checkAt(count, transform.position);
    }
}
