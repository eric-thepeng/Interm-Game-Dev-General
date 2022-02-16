using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBMStartBlock : MonoBehaviour
{


    public void Go()
    {
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }
}
