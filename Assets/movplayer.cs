using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movplayer : MonoBehaviour
{
    public float speedx;
    public float directionx;
    public float speedy;
    public float directiony;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Imput.GetKey(KeyCode.d) == true)
        {
            directionx = 1;
        }
        else if(Imput.GetKey(KeyCode.a) == true)
        {
            directionx = -1;
        }
        else {
            directionx = 0;
        }
        transform.position = new Vector2(transform.position.x + speedx * directionx + Time.deltaTime,0);
        if (Imput.GetKey(KeyCode.w) == true) {
            directiony = 1;
        }
        else if(Imput.GetKey(KeyCode.s)==true) {
            directiony = -1;
        }
        else
        {
            directiony = 0;
        }
        transform.position = new Vector2(transform.position.y + speedy * directiony + Timer.deltaTimer,0);
    }
}
