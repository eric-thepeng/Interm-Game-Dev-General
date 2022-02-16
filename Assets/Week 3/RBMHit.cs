using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBMHit : MonoBehaviour
{
    List<Color> colors = new List<Color>() { Color.blue, Color.red, Color.cyan, Color.gray, Color.green, Color.magenta };

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Color newColor = colors[Random.Range(0, colors.Count - 1)];
        while(newColor == GetComponent<SpriteRenderer>().color)
        {
            newColor = colors[Random.Range(0, colors.Count - 1)];
        }
        GetComponent<SpriteRenderer>().color = newColor; //= new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255),1); this does not work somehow. color is changed in the inspector but not actual object
    }

    // 

}
