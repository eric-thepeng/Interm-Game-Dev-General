using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TopTextController : MonoBehaviour
{
    [SerializeField] TMP_FontAsset typeFaceOne, typeFaceTwo;
    string gameName = "The Penglatformer";
    TMP_Text text;

    private void Start()
    {
        text = GetComponent<TMP_Text>();
        GoToName();
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)) GoToName();
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            text.text = "Live Long and Prosperous";
            text.font = typeFaceTwo;
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            text.text = "To Infinity and Beyond";
            text.font = typeFaceTwo;
        }
        
    }

    void GoToName()
    {
        text.font = typeFaceOne;
        text.text = gameName;
    }
}
