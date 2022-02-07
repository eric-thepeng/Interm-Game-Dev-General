using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTranslate : MonoBehaviour
{
    public bool continous = true;
    public float speed = 0;
    public Vector3 direction = new Vector3(0,0,0);

    // Update is called once per frame
    void Update()
    {
        if (continous) transform.position += direction * speed * Time.deltaTime;
    }
}
