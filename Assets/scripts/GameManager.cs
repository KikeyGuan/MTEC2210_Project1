using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ijnuhb;
    private float heightvalue = 4;
    private float widthvalue = 8;
    public Color[] coincolor;

    // Start is called before the first frame update
    void Start()
    {
        //spwancoin();

       InvokeRepeating("spwancoin", 4, 2); //InovkeRepeating (name,start time,repeat per time)
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spwancoin(){
        //Vector3 is the position. Vector3 name = new Vector3(0,0,0)
        Vector3 pos = new Vector3(Random.Range(-heightvalue, widthvalue),Random.Range(-4, 4),0); //Ramdom.Range(min number, max number)
        GameObject ijnuhbclone = Instantiate(ijnuhb,pos, Quaternion.identity); // (object,position,rotation)

        coin coinScript = ijnuhbclone.GetComponent<coin>();
        int rndValue = Random.Range(0, 3);
        coinScript.changecolor(coincolor[rndValue]);
    }
}
