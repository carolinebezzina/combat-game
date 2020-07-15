using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour {

    public int level;
    public int xp;
    public int health;
    public static int strength;

    // Use this for initialization
    void Start () {
        level = 1;
        xp = 0;
        health = 100;
        strength = 10;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
