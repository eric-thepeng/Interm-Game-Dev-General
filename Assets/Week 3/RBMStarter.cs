using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RBMStarter : MonoBehaviour
{
    public RBMStartBlock StarterBlock;
    TMP_Text display;
    bool started = false;
    bool over = false;
    float timeCount = 0;

    void Start()
    {
        display = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (over) return;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            started = true;
            StarterBlock.Go();
        }

        if (started)
        {
            timeCount += Time.deltaTime;
            display.text = "Time Count: " + Mathf.Round(timeCount*10)/10 + "seconds";
        }
    }

    public void Finale(string inName)
    {
        over = true;
        display.text = "The winner is " + inName;
    }
}
