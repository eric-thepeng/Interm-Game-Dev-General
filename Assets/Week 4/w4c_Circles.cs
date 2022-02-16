using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w4c_Circles : MonoBehaviour
{
    int nowStage = 0;

    private void Start()
    {
        nowStage = (int)Random.Range(0, 2);
        setStage();
    }

    void setStage()
    {
        if(nowStage == 0)
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
        else if(nowStage == 1)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        else if(nowStage == 2)
        {
            Object.Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        nowStage += 1;
        setStage();
    }
}
