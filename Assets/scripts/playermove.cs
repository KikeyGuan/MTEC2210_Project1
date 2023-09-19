using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playermove : MonoBehaviour
{
    public float movespeed = 100;
    Rigidbody2D rb;
    float xMove;
    float ymove;
    public TextMeshPro playerscoretext;
    int playerscore;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerscoretext.text = playerscore.ToString();
        xMove = Input.GetAxisRaw("Horizontal");
        ymove = Input.GetAxisRaw("Vertical");
    }

    public void IncrementScore(int scoreChange)
    {
        playerscore += scoreChange;
    }
    private void FixedUpdate()
    {
        print(Time.deltaTime * movespeed * xMove);
        rb.velocity = new Vector2(Time.deltaTime * movespeed * xMove, Time.deltaTime * movespeed * ymove);
    }
}
