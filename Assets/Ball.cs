﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
	//public int speed = 30;
    public Rigidbody2D sesuatu;
    public Animator animtr;
    public int counterP1 = 0;
    public int counterP2 = 0;
    public Text scoreText1;
    public Text scoreText2;
    // Start is called before the first frame update
    void Start()
    {
        int x = Random.Range(0, 2) * 2 - 1;
        int y = Random.Range(0, 2) * 2 - 1;
        int speed = Random.Range(20, 26);
        
        sesuatu.velocity = new Vector2(-1,1) *speed;
        animtr.SetBool("IsMove",true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(sesuatu.velocity.x > 0){
            sesuatu.GetComponent<Transform>().localScale = new Vector3(1,1,1);
        }
        else{
            sesuatu.GetComponent<Transform>().localScale = new Vector3(-1,1,1);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.name=="WallKanan" || other.collider.name == "WallKiri"){
            StartCoroutine(jeda());
        }
    }

    IEnumerator jeda(){
        sesuatu.velocity = new Vector2(0,0);
        animtr.SetBool("IsMove",false);
        sesuatu.GetComponent<Transform>().position = new Vector2(0,0);

        yield return new WaitForSeconds(1);

        int x = Random.Range(0, 2) * 2 - 1;
        int y = Random.Range(0, 2) * 2 - 1;
        int speed = Random.Range(20, 26);
        sesuatu.velocity = new Vector2(x,y) * speed;
        animtr.SetBool("IsMove",true);
        
    }
}
