using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBMCameraManager : MonoBehaviour
{
    int camPos = 0;
    // Start is called before the first frame update

    public void checkAt(int at, Vector3 newPos)
    {
        if(at > camPos)
        {
            camPos = at;
            transform.position = newPos;
        }
    }
}
