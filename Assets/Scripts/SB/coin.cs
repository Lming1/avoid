﻿using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour {


    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Player")
        {
            Destroy(gameObject);
            GameObject.Find("score").GetComponent<score>().addcoin(1);
        }
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
