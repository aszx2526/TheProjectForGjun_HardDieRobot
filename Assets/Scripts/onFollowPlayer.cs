﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onFollowPlayer : MonoBehaviour {
    public GameObject myPlayer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = myPlayer.transform.position;
	}
}
