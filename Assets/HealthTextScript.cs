﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthTextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<UnityEngine.UI.Text>().text = "Enemy Health: " + EnemyScript.health;
    }
}
