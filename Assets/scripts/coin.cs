using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coin : MonoBehaviour
{
    public int coinvalue;
    public TextMeshPro valuetext;
    public SpriteRenderer sr;

    

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        changecolor(Random.ColorHSV()); //give random color 1
        changevalue(Random.Range(1, 9));

    }

    public void changecolor(Color c) //send it back 3
    {
        sr.color = c; //set color to random color 2
    }
    public void changevalue(int v)
    {
        coinvalue = v;
        valuetext.text = coinvalue.ToString();
    }
}
