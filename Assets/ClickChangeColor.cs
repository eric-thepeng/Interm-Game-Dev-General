using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickChangeColor : MonoBehaviour
{
    List<Color> colors = new List<Color>() { Color.blue, Color.red, Color.cyan, Color.gray, Color.green, Color.magenta };

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<SpriteRenderer>().color = colors[Random.Range(0, colors.Count - 1)]; //= new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255),1); this does not work somehow. color is changed in the inspector but not actual object
        }
    }
}
