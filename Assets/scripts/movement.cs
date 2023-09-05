using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(gameObject.name);   <-prints out the object name
        
    }

    // Update is called once per frame
    void Update()
    {
        //combining A and D keys, shorten it
        //Debug.Log(Input.GetAxis("Horizontal"));
        float xInput = Input.GetAxis("Horizontal"); //GetAxisRaw: full number no decimals
        transform.Translate(speed * Time.deltaTime * xInput, 0, 0);

        /*if (Input.GetKey(KeyCode.D))    //if D is pressed object moves
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.A))    //goes left
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }*/

        //Time.deltaTime framerate depenant 
    }
}