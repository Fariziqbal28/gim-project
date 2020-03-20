using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiri : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) {
        	GetComponent<Rigidbody2D>().velocity = new Vector2(0,1) *speed;
        }
        else if(Input.GetKey(KeyCode.S)) {
        	GetComponent<Rigidbody2D>().velocity = new Vector2(0,-1) *speed;
        }
        else{
        	GetComponent<Rigidbody2D>().velocity = new Vector2(0,0) *speed;
        }
    }
}
